using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Data;

namespace LOYADE.DATA.REALTIME
{
    /// <summary>
    /// 内存数据库五层静态模式
    /// 0层：设备外变量；1层设备：PAG变量；2层设备：设备变量；3层设备：从设备变量；4层设备：IQ模块变量
    /// 线程安全：
    /// 如果代码所在的进程中有多个线程在同时运行，而这些线程可能会同时运行这段代码。
    /// 如果每次运行结果和单线程运行的结果是一样的，而且其他的变量的值也和预期的是一样的，就是线程安全的。
    /// </summary>
    public class MemoryVariableOf5Levels : MemoryVariable
    {
        /// <summary>
        /// 设备外变量（全局变量、辅助变量、临时变量等）
        /// 8+16+48*n0 = 24+48*n0 bytes 
        /// 安全计算单个变量单条记录耗费 (24+48) = 72 bytes (Safe Memory Cost per Record of Variable, SMCpRoV)
        /// 正常1条记录是24+48*1=72,2条记录是24+48*2=120，以此类推
        /// 2G上限为例，0层最多27777777条，万点系统每个变量能记录2777次采集，秒采频率下，支持46分钟的高性能实时数据记录。
        /// 达到2G上限时，MDBVVProvider要启用转存和收缩线程（先存后删的一个单线程），会加锁保证线程安全，系统性能会临时下降。
        /// 删除操作会只留下Variable中最后一个VariableValue对象
        /// </summary>
        protected static ConcurrentDictionary<long, Variable> _data0;

        /// <summary>
        /// PAG变量
        /// SMCpRoV：16+16+48 = 80 bytes
        /// 2G上限为例，1层最多25000000条，万点系统每个变量能记录2500次采集，秒采频率下，支持41分钟的高性能实时数据记录。
        /// </summary>
        protected static ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>> _data1;

        /// <summary>
        /// PAG-设备变量
        /// SMCpRoV：24+16+48 = 88 bytes
        /// 2G上限为例，2层最多22727272条，万点系统每个变量能记录2272次采集，秒采频率下，支持37分钟的高性能实时数据记录。
        /// </summary>
        protected static ConcurrentDictionary<long, ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>>> _data2;

        /// <summary>
        /// /PAG-设备-从设备变量
        /// SMCpRoV：32+16+48 = 96 bytes
        /// 2G上限为例，3层最多20833333条，万点系统每个变量能记录2083次采集，秒采频率下，支持34分钟的高性能实时数据记录。
        /// </summary>
        protected static ConcurrentDictionary<long, ConcurrentDictionary<long, ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>>>> _data3;

        /// <summary>
        /// PAG-设备-从设备-IQ模块变量
        /// SMCpRoV：40+16+48 = 104 bytes
        /// 2G上限为例，4层最多19230803条，万点系统每个变量能记录1923次采集，秒采频率下，支持32分钟的高性能实时数据记录。
        /// </summary>
        protected static ConcurrentDictionary<long, ConcurrentDictionary<long, ConcurrentDictionary<long, ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>>>>> _data4;

        protected static MemoryVariableOf5Levels _mdo5l;
        protected MemoryVariableOf5Levels()
        {
            InitializeDATA();
        }

        protected override void InitializeDATA()
        {
            CurrentVariableValue = new ConcurrentDictionary<long, VariableValue>();
            CQ2Store = new ConcurrentQueue<VariableValue>();
            VariableCountOfLevel = new ConcurrentDictionary<int, int>();
            VariableCountOfLevel.TryAdd(0, 0);
            VariableCountOfLevel.TryAdd(1, 0);
            VariableCountOfLevel.TryAdd(2, 0);
            VariableCountOfLevel.TryAdd(3, 0);
            VariableCountOfLevel.TryAdd(4, 0);
            _data0 = new ConcurrentDictionary<long, Variable>();
            _data1 = new ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>>();
            _data2 = new ConcurrentDictionary<long, ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>>>();
            _data3 = new ConcurrentDictionary<long, ConcurrentDictionary<long, ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>>>>();
            _data4 = new ConcurrentDictionary<long, ConcurrentDictionary<long, ConcurrentDictionary<long, ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>>>>>();
        }

        public static MemoryVariableOf5Levels GetInstance()
        {
            if (_mdo5l == null)
                _mdo5l = new MemoryVariableOf5Levels();
            return _mdo5l;
        }

        public override DataTable GetOuterVariableTableStructure()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("VID", typeof(long)));
            dt.Columns.Add(new DataColumn("DID1", typeof(long)));
            dt.Columns.Add(new DataColumn("DID2", typeof(long)));
            dt.Columns.Add(new DataColumn("DID3", typeof(long)));
            dt.Columns.Add(new DataColumn("DID4", typeof(long))); 
            dt.Columns.Add(new DataColumn("LEVEL", typeof(int)));
            return dt;
        }

        /// <summary>
        /// DT格式：变量ID：VID，所属1层设备ID：DID1，所属2层设备ID：DID2，所属3层设备ID：DID3，所属4层设备ID：DID4，所在层次：LEVEL
        /// 第0层无设备，DID1 = DID2 = DID3 = DID4 = 0；   
        /// 第1层无234层设备，DID2 = DID3 = DID4 = 0；     
        /// 第2层无34层设备，DID3 = DID4 = 0；   
        /// 第3层无4层设备，DID4 = 0；   
        /// </summary>
        /// <param name="dt"></param>
        public override void GenerateRealtimeStructure(DataTable dt)
        {
            try
            {
                long tempvarid;
                long tempfdid1, tempfdid2, tempfdid3, tempfdid4;
                DataRow[] drs = dt.Select("LEVEL=0");
                foreach (DataRow dr in drs)
                {
                    Variable v0 = new Variable();
                    _data0.TryAdd((long)dr["VID"], v0);
                }
                drs = dt.Select("LEVEL=1");
                foreach (DataRow dr in drs)
                {
                    tempfdid1 = (long)dr["DID1"];
                    tempvarid = (long)dr["VID"];
                    ConcurrentDictionary<long, Variable> cd1 = new ConcurrentDictionary<long, Variable>();
                    _data1.TryAdd(tempfdid1, cd1);
                    Variable v10 = new Variable();
                    _data1[tempfdid1].TryAdd(tempvarid, v10);
                }
                drs = dt.Select("LEVEL=2");
                foreach (DataRow dr in drs)
                {
                    tempfdid1 = (long)dr["DID1"];
                    tempfdid2 = (long)dr["DID2"];
                    tempvarid = (long)dr["VID"];
                    ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>> cd2 = new ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>>();
                    _data2.TryAdd(tempfdid1, cd2);
                    ConcurrentDictionary<long, Variable> cd20 = new ConcurrentDictionary<long, Variable>();
                    _data2[tempfdid1].TryAdd(tempfdid2, cd20);
                    Variable v200 = new Variable();
                    _data2[tempfdid1][tempfdid2].TryAdd(tempvarid, v200);
                }
                drs = dt.Select("LEVEL=3");
                foreach (DataRow dr in drs)
                {
                    tempfdid1 = (long)dr["DID1"];
                    tempfdid2 = (long)dr["DID2"];
                    tempfdid3 = (long)dr["DID3"];
                    tempvarid = (long)dr["VID"];
                    ConcurrentDictionary<long, ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>>> cd3 = new ConcurrentDictionary<long, ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>>>();
                    _data3.TryAdd(tempfdid1, cd3);
                    ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>> cd30 = new ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>>();
                    _data3[tempfdid1].TryAdd(tempfdid2, cd30);
                    ConcurrentDictionary<long, Variable> cd300 = new ConcurrentDictionary<long, Variable>();
                    _data3[tempfdid1][tempfdid2].TryAdd(tempfdid3, cd300);
                    Variable v3000 = new Variable();
                    _data3[tempfdid1][tempfdid2][tempfdid3].TryAdd(tempvarid, v3000);
                }
                drs = dt.Select("LEVEL=4");
                foreach (DataRow dr in drs)
                {
                    tempfdid1 = (long)dr["DID1"];
                    tempfdid2 = (long)dr["DID2"];
                    tempfdid3 = (long)dr["DID3"];
                    tempfdid4 = (long)dr["DID4"];
                    tempvarid = (long)dr["VID"];
                    ConcurrentDictionary<long, ConcurrentDictionary<long, ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>>>> cd4 = new ConcurrentDictionary<long, ConcurrentDictionary<long, ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>>>>();
                    _data4.TryAdd(tempfdid1, cd4);
                    ConcurrentDictionary<long, ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>>> cd40 = new ConcurrentDictionary<long, ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>>>();
                    _data4[tempfdid1].TryAdd(tempfdid2, cd40);
                    ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>> cd400 = new ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>>();
                    _data4[tempfdid1][tempfdid2].TryAdd(tempfdid3, cd400);
                    ConcurrentDictionary<long, Variable> cd4000 = new ConcurrentDictionary<long, Variable>();
                    _data4[tempfdid1][tempfdid2][tempfdid3].TryAdd(tempfdid4, cd4000);
                    Variable v40000 = new Variable();
                    _data4[tempfdid1][tempfdid2][tempfdid3][tempfdid4].TryAdd(tempvarid, v40000);
                }
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        public void AddVariableValueRealtime0(long kv, VariableValue vv)
        {
            lock (_data0[kv].CQVariableValues)
            {
                _data0[kv].CQVariableValues.Enqueue(vv);
            }
        }

        public void AddVariableValueRealtime1(long kv, long k1, VariableValue vv)
        {
            ConcurrentDictionary<long, Variable> cd1 = _data1[k1];
            Variable v = _data1[k1][kv];
            lock (v.CQVariableValues)
            {
                v.CQVariableValues.Enqueue(vv);
            }
        }

        public void AddVariableValueRealtime2(long kv, long k1, long k2, VariableValue vv)
        {
            ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>> cd1 = _data2[k1];
            ConcurrentDictionary<long, Variable> cd2 = _data2[k1][k2];
            Variable v = _data2[k1][k2][kv];
            lock (v.CQVariableValues)
            {
                v.CQVariableValues.Enqueue(vv);
            }
        }

        public void AddVariableValueRealtime3(long kv, long k1, long k2, long k3, VariableValue vv)
        {
            ConcurrentDictionary<long, ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>>> cd1 = _data3[k1];
            ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>> cd2 = _data3[k1][k2];
            ConcurrentDictionary<long, Variable> cd3 = _data3[k1][k2][k3];
            Variable v = _data3[k1][k2][k3][kv];
            lock (v.CQVariableValues)
            {
                v.CQVariableValues.Enqueue(vv);
            }
        }

        public void AddVariableValueRealtime4(long kv, long k1, long k2, long k3, long k4, VariableValue vv)
        {
            ConcurrentDictionary<long, ConcurrentDictionary<long, ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>>>> cd1 = _data4[k1];
            ConcurrentDictionary<long, ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>>> cd2 = _data4[k1][k2];
            ConcurrentDictionary<long, ConcurrentDictionary<long, Variable>> cd3 = _data4[k1][k2][k3];
            ConcurrentDictionary<long, Variable> cd4 = _data4[k1][k2][k3][k4];
            Variable v = _data4[k1][k2][k3][k4][kv];
            lock (v.CQVariableValues)
            {
                v.CQVariableValues.Enqueue(vv);
            }
        }

        /// <summary>
        /// 使用时注意有可能返回值为null
        /// </summary>
        /// <param name="kv"></param>
        /// <returns></returns>
        public VariableValue GetLatestVariableValueRealtime0(long kv)
        {
            VariableValue vv;
            Variable v = _data0[kv];
            if (v.CQVariableValues.TryDequeue(out vv))
            {
                CQ2Store.Enqueue(vv);
                CurrentVariableValue.TryAdd(kv, vv);
                if (CurrentVariableValue.ContainsKey(kv))
                    CurrentVariableValue.TryAdd(kv, vv);
                else
                    CurrentVariableValue.TryUpdate(kv, vv, vv);
            }
            else
            {
                CurrentVariableValue.TryGetValue(kv, out vv);
            }
            return vv;
        }

        public VariableValue GetLatestVariableValueRealtime1(long kv, long k1)
        {
            VariableValue vv;
            Variable v = _data1[k1][kv];
            if (v.CQVariableValues.TryDequeue(out vv))
            {
                CQ2Store.Enqueue(vv);
                CurrentVariableValue.TryAdd(kv, vv);
                if (CurrentVariableValue.ContainsKey(kv))
                    CurrentVariableValue.TryAdd(kv, vv);
                else
                    CurrentVariableValue.TryUpdate(kv, vv, vv);
            }
            else
            {
                CurrentVariableValue.TryGetValue(kv, out vv);
            }
            return vv;
        }

        public VariableValue GetLatestVariableValueRealtime2(long kv, long k1, long k2)
        {
            VariableValue vv;
            Variable v = _data2[k1][k2][kv];
            if (v.CQVariableValues.TryDequeue(out vv))
            {
                CQ2Store.Enqueue(vv);
                CurrentVariableValue.TryAdd(kv, vv);
                if (CurrentVariableValue.ContainsKey(kv))
                    CurrentVariableValue.TryAdd(kv, vv);
                else
                    CurrentVariableValue.TryUpdate(kv, vv, vv);
            }
            else
            {
                CurrentVariableValue.TryGetValue(kv, out vv);
            }
            return vv;
        }

        public VariableValue GetLatestVariableValueRealtime3(long kv, long k1, long k2, long k3)
        {
            VariableValue vv;
            Variable v = _data3[k1][k2][k3][kv];
            if (v.CQVariableValues.TryDequeue(out vv))
            {
                CQ2Store.Enqueue(vv);
                CurrentVariableValue.TryAdd(kv, vv);
                if (CurrentVariableValue.ContainsKey(kv))
                    CurrentVariableValue.TryAdd(kv, vv);
                else
                    CurrentVariableValue.TryUpdate(kv, vv, vv);
            }
            else
            {
                CurrentVariableValue.TryGetValue(kv, out vv);
            }
            return vv;
        }

        public VariableValue GetLatestVariableValueRealtime4(long kv, long k1, long k2, long k3, long k4)
        {
            VariableValue vv;
            Variable v = _data4[k1][k2][k3][k4][kv];
            if (v.CQVariableValues.TryDequeue(out vv))
            {
                CQ2Store.Enqueue(vv);
                CurrentVariableValue.TryAdd(kv, vv);
                if (CurrentVariableValue.ContainsKey(kv))
                    CurrentVariableValue.TryAdd(kv, vv);
                else
                    CurrentVariableValue.TryUpdate(kv, vv, vv);
            }
            else
            {
                CurrentVariableValue.TryGetValue(kv, out vv);
            }
            return vv;
        }

    }
}
