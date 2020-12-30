using System;
using System.Collections.Concurrent;
using System.Text;

namespace LOYADE.DATA.REALTIME
{
    public class Variable
    {
        /// <summary>
        /// 2*8 + 48*n=16+48*n bytes
        /// </summary>
        public Variable()
        {
            _cqvv = new ConcurrentQueue<VariableValue>();
        }

        public Variable(long id)
        {
            _id = id;
            _cqvv = new ConcurrentQueue<VariableValue>();
        }

        private long _id;
        private long _deviceid;
        private VariableType _vartype;
        private ConcurrentQueue<VariableValue> _cqvv;

        public long ID
        {
            get
            {
                return _id;
            } 
            set
            {
                _id = value;
            }
        }

        public VariableType VarType
        {
            get
            {
                return _vartype;
            }
            set
            {
                _vartype = value;
            }
        }

        public long DeviceID
        {
            get
            {
                return _deviceid;
            } 
            set
            {
                _deviceid = value;
            }
        }

        /// <summary>
        /// 供多线程通信采集程序使用的缓冲队列
        /// </summary>
        public ConcurrentQueue<VariableValue> CQVariableValues
        {
            get
            {
                return _cqvv;
            } 
            set
            {
                _cqvv = value;
            }
        }
    }
}
