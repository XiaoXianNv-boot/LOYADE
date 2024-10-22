﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;

namespace LOYADE.IOCP
{
    //异步Socket调用对象，所有的协议处理都从本类继承
    public class AsyncSocketInvokeElement
    {
        protected AsyncSocketServer m_asyncSocketServer;
        protected AsyncSocketUserToken m_asyncSocketUserToken;
        public AsyncSocketUserToken AsyncSocketUserToken { get { return m_asyncSocketUserToken; } }

        private bool m_netByteOrder;
        public bool NetByteOrder { get { return m_netByteOrder; } set { m_netByteOrder = value; } } //长度是否使用网络字节顺序

        protected IncomingDataParser m_incomingDataParser; //协议解析器，用来解析客户端接收到的命令
        protected OutgoingDataAssembler m_outgoingDataAssembler; //协议组装器，用来组织服务端返回的命令

        protected bool m_sendAsync; //标识是否有发送异步事件

        protected DateTime m_connectDT;
        public DateTime ConnectDT { get { return m_connectDT; } }
        protected DateTime m_activeDT;
        public DateTime ActiveDT { get { return m_activeDT; } }

        public AsyncSocketInvokeElement(AsyncSocketServer asyncSocketServer, AsyncSocketUserToken asyncSocketUserToken)
        {
            m_asyncSocketServer = asyncSocketServer;
            m_asyncSocketUserToken = asyncSocketUserToken;

            m_netByteOrder = false;

            m_incomingDataParser = new IncomingDataParser();
            m_outgoingDataAssembler = new OutgoingDataAssembler();

            m_sendAsync = false;

            m_connectDT = DateTime.UtcNow;
            m_activeDT = DateTime.UtcNow;
        }

        public virtual void Close()
        {
        }

        /// <summary>
        /// 异步数据接收有可能收到的数据不是一个完整包，或者接收到的数据超过一个包的大小，
        /// 因此我们需要把接收的数据进行缓存。异步发送我们也需要把每个发送的包加入到一个队列，
        /// 然后通过队列逐个发送出去，如果每个都实时发送，有可能造成上一个数据包未发送完成，
        /// 这时再调用SendAsync会抛出异常，提示SocketAsyncEventArgs正在进行异步操作，因此我们需要建立接收缓存和发送缓存。
        /// </summary>        
        public virtual bool ProcessReceive(byte[] buffer, int offset, int count) //接收异步事件返回的数据，用于对数据进行缓存和分包
        {
            m_activeDT = DateTime.UtcNow;
            DynamicBufferManager receiveBuffer = m_asyncSocketUserToken.ReceiveBuffer;

            receiveBuffer.WriteBuffer(buffer, offset, count);
            bool result = true;
            while (receiveBuffer.DataCount > sizeof(int))
            {
                //按照长度分包
                int packetLength = BitConverter.ToInt32(receiveBuffer.Buffer, 0); //获取包长度
                if (NetByteOrder)
                    packetLength = System.Net.IPAddress.NetworkToHostOrder(packetLength); //把网络字节顺序转为本地字节顺序


                if ((packetLength > 10 * 1024 * 1024) | (receiveBuffer.DataCount > 10 * 1024 * 1024)) //最大Buffer异常保护
                    return false;

                if ((receiveBuffer.DataCount - sizeof(int)) >= packetLength) //收到的数据达到包长度
                {
                    result = ProcessPacket(receiveBuffer.Buffer, sizeof(int), packetLength);
                    if (result)
                        receiveBuffer.Clear(packetLength + sizeof(int)); //从缓存中清理
                    else
                        return result;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }

        /// <summary>
        /// 通过Completed事件响应后调用AsyncSocketInvokeElement.ProcessReceive，
        /// 在ProcessReceive中，我们把收到数据先写入一个缓存，然后进行分包，
        /// 分包后压给包处理函数ProcessPacket，ProcessPacket函数然后调用ProcessCommand处理具体的命令，
        /// 也是各个协议实现业务逻辑的地方
        /// </summary>
        public virtual bool ProcessPacket(byte[] buffer, int offset, int count) //处理分完包后的数据，把命令和数据分开，并对命令进行解析
        {
            if (count < sizeof(int))
                return false;
            int commandLen = BitConverter.ToInt32(buffer, offset); //取出命令长度
            string tmpStr = Encoding.UTF8.GetString(buffer, offset + sizeof(int), commandLen);
            if (!m_incomingDataParser.DecodeProtocolText(tmpStr)) //解析命令
                return false;

            return ProcessCommand(buffer, offset + sizeof(int) + commandLen, count - sizeof(int) - commandLen); //处理命令
        }

        public virtual bool ProcessCommand(byte[] buffer, int offset, int count) //处理具体命令，子类从这个方法继承，buffer是收到的数据
        {
            return true;
        }

        /// <summary>
        /// 通过Completed事件响应后调用AsyncSocketInvokeElement.SendCompleted，
        /// 在SendCompleted中我们需要在队列中清除已发送的包，并检测是否还有剩余需要发送的数据包，
        /// 如果有，则继续发送
        /// </summary>
        /// <returns></returns>
        public virtual bool SendCompleted()
        {
            m_activeDT = DateTime.UtcNow;
            m_sendAsync = false;
            AsyncSendBufferManager asyncSendBufferManager = m_asyncSocketUserToken.SendBuffer;
            asyncSendBufferManager.ClearFirstPacket(); //清除已发送的包
            int offset = 0;
            int count = 0;
            if (asyncSendBufferManager.GetFirstPacket(ref offset, ref count))
            {
                m_sendAsync = true;
                return m_asyncSocketServer.SendAsyncEvent(m_asyncSocketUserToken.ConnectSocket, m_asyncSocketUserToken.SendEventArgs,
                    asyncSendBufferManager.DynamicBufferManager.Buffer, offset, count);
            }
            else
                return SendCallback();
        }

        //发送回调函数，用于连续下发数据
        public virtual bool SendCallback()
        {
            return true;
        }

        /// <summary>
        /// 在AsyncSocketInvokeElement中提供函数给子类发送数据，业务逻辑是把当前数据包写入缓存，
        /// 并检测当前是否正在发送包，如果正在发送，则等待回调，如果没有正在发送的数据包，则投递发送请求。
        /// </summary>
        /// <returns></returns>
        public bool DoSendResult()
        {
            string commandText = m_outgoingDataAssembler.GetProtocolText();
            byte[] bufferUTF8 = Encoding.UTF8.GetBytes(commandText);
            int totalLength = sizeof(int) + bufferUTF8.Length; //获取总大小
            AsyncSendBufferManager asyncSendBufferManager = m_asyncSocketUserToken.SendBuffer;
            asyncSendBufferManager.StartPacket();
            asyncSendBufferManager.DynamicBufferManager.WriteInt(totalLength, false); //写入总大小
            asyncSendBufferManager.DynamicBufferManager.WriteInt(bufferUTF8.Length, false); //写入命令大小
            asyncSendBufferManager.DynamicBufferManager.WriteBuffer(bufferUTF8); //写入命令内容
            asyncSendBufferManager.EndPacket();

            bool result = true;
            if (!m_sendAsync)
            {
                int packetOffset = 0;
                int packetCount = 0;
                if (asyncSendBufferManager.GetFirstPacket(ref packetOffset, ref packetCount))
                {
                    m_sendAsync = true;
                    result = m_asyncSocketServer.SendAsyncEvent(m_asyncSocketUserToken.ConnectSocket, m_asyncSocketUserToken.SendEventArgs,
                        asyncSendBufferManager.DynamicBufferManager.Buffer, packetOffset, packetCount);
                }
            }
            return result;
        }

        public bool DoSendResult(byte[] buffer, int offset, int count)
        {
            string commandText = m_outgoingDataAssembler.GetProtocolText();
            byte[] bufferUTF8 = Encoding.UTF8.GetBytes(commandText);
            int totalLength = sizeof(int) + bufferUTF8.Length + count; //获取总大小
            AsyncSendBufferManager asyncSendBufferManager = m_asyncSocketUserToken.SendBuffer;
            asyncSendBufferManager.StartPacket();
            asyncSendBufferManager.DynamicBufferManager.WriteInt(totalLength, false); //写入总大小
            asyncSendBufferManager.DynamicBufferManager.WriteInt(bufferUTF8.Length, false); //写入命令大小
            asyncSendBufferManager.DynamicBufferManager.WriteBuffer(bufferUTF8); //写入命令内容
            asyncSendBufferManager.DynamicBufferManager.WriteBuffer(buffer, offset, count); //写入二进制数据
            asyncSendBufferManager.EndPacket();

            bool result = true;
            if (!m_sendAsync)
            {
                int packetOffset = 0;
                int packetCount = 0;
                if (asyncSendBufferManager.GetFirstPacket(ref packetOffset, ref packetCount))
                {
                    m_sendAsync = true;
                    result = m_asyncSocketServer.SendAsyncEvent(m_asyncSocketUserToken.ConnectSocket, m_asyncSocketUserToken.SendEventArgs,
                        asyncSendBufferManager.DynamicBufferManager.Buffer, packetOffset, packetCount);
                }
            }
            return result;
        }

        public bool DoSendBuffer(byte[] buffer, int offset, int count) //不是按包格式下发一个内存块，用于日志这类下发协议
        {
            AsyncSendBufferManager asyncSendBufferManager = m_asyncSocketUserToken.SendBuffer;
            asyncSendBufferManager.StartPacket();
            asyncSendBufferManager.DynamicBufferManager.WriteBuffer(buffer, offset, count);
            asyncSendBufferManager.EndPacket();

            bool result = true;
            if (!m_sendAsync)
            {
                int packetOffset = 0;
                int packetCount = 0;
                if (asyncSendBufferManager.GetFirstPacket(ref packetOffset, ref packetCount))
                {
                    m_sendAsync = true;
                    result = m_asyncSocketServer.SendAsyncEvent(m_asyncSocketUserToken.ConnectSocket, m_asyncSocketUserToken.SendEventArgs,
                        asyncSendBufferManager.DynamicBufferManager.Buffer, packetOffset, packetCount);
                }
            }
            return result;
        }
    }
}