using System;
using System.Collections.Concurrent;
using System.Data;
using System.IO;

namespace LOYADE.DATA.REALTIME
{
    public abstract class MemoryVariable
    { 
        /// <summary>
        /// 默认内存数据使用上限为2G内存，超过2G则开始调用转存和收缩方法
        /// （注意：除变量数据外，C#线程也会占用内存，32位线程占内存0.02-2mb，64位占0.05-5mb，
        /// 此上限不宜设置超过服务器内存的1/2）
        /// </summary>
        public static long MemorySize = 2000000000;

        /// <summary>
        /// 每层的变量数字典
        /// </summary>
        public static ConcurrentDictionary<int, int> VariableCountOfLevel;

        /// <summary>
        /// 当前最后时刻的实时变量值集合，避免采集缓冲队列彻底出空（如采集故障）之后无法找到最后时刻的实时值
        /// <变量ID，当前值>
        /// </summary>
        public static ConcurrentDictionary<long, VariableValue> CurrentVariableValue;

        /// <summary>
        /// 转存队列
        /// 支持多线程从采集缓冲队列出队后，入本队列
        /// 支持多线程从本队列出队后，转存历史数据库
        /// 当实时数据库内存占用达到上限时，对本队列进行出队转存
        /// </summary>
        public static ConcurrentQueue<VariableValue> CQ2Store;

        /// <summary>
        /// 层数
        /// </summary>
        public int LevelCount
        {
            get
            {
                return VariableCountOfLevel.Count;
            }
        }

        /// <summary>
        /// 初始化
        /// </summary>
        protected abstract void InitializeDATA();

        /// <summary>
        /// 取得内存数据库支持的外部变量定义表结构
        /// </summary>
        /// <returns></returns>
        public abstract DataTable GetOuterVariableTableStructure();

        /// <summary>
        /// 依据外部变量定义表生成实时内存数据库结构
        /// </summary>
        /// <param name="dt"></param>
        public abstract void GenerateRealtimeStructure(DataTable dt);

        /// <summary>
        /// 使用动态层次化结构时用的方法：添加实时变量
        /// （静态层次化结构不适用，单独在其内部定义）
        /// </summary>
        /// <param name="level"></param>
        /// <param name="fdid"></param>
        /// <param name="vid"></param>
        /// <returns></returns>
        public virtual bool AddVariableRealtime(int level, long fdid, long vid)
        {
            return false;
        }

        /// <summary>
        /// 使用动态层次化结构时用的方法：移除实时变量
        /// （静态层次化结构不适用，单独在其内部定义）
        /// </summary>
        /// <param name="level"></param>
        /// <param name="fdid"></param>
        /// <param name="vid"></param>
        /// <returns></returns>
        public virtual bool RemoveVariableRealtime(int level, long fdid, long vid)
        {
            return false;
        }
 
    }
}
