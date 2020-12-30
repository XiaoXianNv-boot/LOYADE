using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

using LOYADE.DATA.REALTIME;

namespace TestLOYADE
{
    public partial class formTestDATAREALTIME : Form
    {
        private bool _isscada = false;
        private int _scadacount = 0;
        private int _freq = 1;
        private DataTable _dt, _dtcqstore; 
        private MemoryDATAOf5Levels _mdo5l;
        private List<Thread> _listthread;
        public formTestDATAREALTIME()
        {
            InitializeComponent();
            _mdo5l = MemoryDATAOf5Levels.GetInstance();
            _dt = _mdo5l.GetOuterVariableTableStructure();
            _dt.Columns.Add(new DataColumn("CURRENT_VALUE", typeof(decimal)));
            _dt.Columns.Add(new DataColumn("SCADA_DT", typeof(DateTime)));
        }

        private void formTestDATAREALTIME_Load(object sender, EventArgs e)
        {
            timerGetMem.Enabled = true;
        }

        private void timerGetMem_Tick(object sender, EventArgs e)
        {
            Process proc = Process.GetCurrentProcess();

            long memsize = proc.PrivateMemorySize64 / 1024 / 1024;
            txtMemSize.Text = memsize.ToString();
            VariableValue vv;
            foreach (DataRow dr in _dt.Rows)
            {
                switch ((int)dr["LEVEL"])
                {
                    default:
                        break;
                    case 0:
                        vv = _mdo5l.GetLatestVariableValueRealtime0((long)dr["VID"]);
                        if (vv != null)
                        {
                            dr["CURRENT_VALUE"] = vv.RawValue;
                            dr["SCADA_DT"] = vv.ScadaDT;
                        }
                        break;
                    case 1:
                        vv = _mdo5l.GetLatestVariableValueRealtime1((long)dr["VID"], (long)dr["DID1"]);
                        if (vv != null)
                        {
                            dr["CURRENT_VALUE"] = vv.RawValue;
                            dr["SCADA_DT"] = vv.ScadaDT;
                        }
                        break;
                    case 2:
                        vv = _mdo5l.GetLatestVariableValueRealtime2((long)dr["VID"], (long)dr["DID1"], (long)dr["DID2"]);
                        if (vv != null)
                        {
                            dr["CURRENT_VALUE"] = vv.RawValue;
                            dr["SCADA_DT"] = vv.ScadaDT;
                        }
                        break;
                    case 3:
                        vv = _mdo5l.GetLatestVariableValueRealtime3((long)dr["VID"], (long)dr["DID1"], (long)dr["DID2"], (long)dr["DID3"]);
                        if (vv != null)
                        {
                            dr["CURRENT_VALUE"] = vv.RawValue;
                            dr["SCADA_DT"] = vv.ScadaDT;
                        }
                        break;
                    case 4:
                        vv = _mdo5l.GetLatestVariableValueRealtime4((long)dr["VID"], (long)dr["DID1"], (long)dr["DID2"], (long)dr["DID3"], (long)dr["DID4"]);
                        if (vv != null)
                        {
                            dr["CURRENT_VALUE"] = vv.RawValue;
                            dr["SCADA_DT"] = vv.ScadaDT;
                        }
                        break;
                }
            }
        }

        private void buttonSCADA_Click(object sender, EventArgs e)
        {
            _scadacount = 0;
            _isscada = true;
            _freq = int.Parse(txtFreq.Text);
            int tc = int.Parse(txtThreadCount.Text);
            _listthread = new List<Thread>();
            for (int i = 0; i < tc; i++)
            {
                Thread t = new Thread(new ThreadStart(TSCADA));
                t.IsBackground = true;
                _listthread.Add(t);
                t.Start();
            }
        }

        /// <summary>
        /// 只使用了一个线程函数，实际环境应该每一层对应一个线程函数。
        /// 用随机行的方式从变量定义表中取得一个需要模拟的变量进行采集。
        /// </summary>
        private void TSCADA()
        {
            while (_isscada)
            {
                Random r = new Random();
                Random rv = new Random();
                int rowindex = r.Next(_dt.Rows.Count);
                VariableValue vv = new VariableValue();
                vv.RawValue = Convert.ToDecimal(rv.NextDouble() * 10000);
                vv.ScadaDT = DateTime.Now;
                long vid = (long)_dt.Rows[rowindex]["VID"];
                vv.VariableID = vid;
                switch ((int)_dt.Rows[rowindex]["LEVEL"])
                {
                    default:
                        break;
                    case 0:
                        _mdo5l.AddVariableValueRealtime0(vid, vv);
                        break;
                    case 1:
                        _mdo5l.AddVariableValueRealtime1(vid, (long)_dt.Rows[rowindex]["DID1"], vv);
                        break;
                    case 2:
                        _mdo5l.AddVariableValueRealtime2(vid, (long)_dt.Rows[rowindex]["DID1"], (long)_dt.Rows[rowindex]["DID2"], vv);
                        break;
                    case 3:
                        _mdo5l.AddVariableValueRealtime3(vid, (long)_dt.Rows[rowindex]["DID1"], (long)_dt.Rows[rowindex]["DID2"], (long)_dt.Rows[rowindex]["DID3"], vv);
                        break;
                    case 4:
                        _mdo5l.AddVariableValueRealtime4(vid, (long)_dt.Rows[rowindex]["DID1"], (long)_dt.Rows[rowindex]["DID2"], (long)_dt.Rows[rowindex]["DID3"], (long)_dt.Rows[rowindex]["DID4"], vv);
                        break;
                }
                _scadacount++;
                Thread.Sleep(_freq);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            _isscada = false;
            foreach (Thread t in _listthread)
            {
                t.Abort();
            }
            _listthread.Clear();
            txtSCADACount.Text = _scadacount.ToString();
        }
  

        private void buttonDT_Click(object sender, EventArgs e)
        {
            formVDT f = new formVDT(_dt);
            f.Show();
        }

        private void buttonGenStruct_Click(object sender, EventArgs e)
        {


        }

        private void buttonGenData_Click(object sender, EventArgs e)
        {
            int dc1 = int.Parse(txtDC1.Text);
            int dc2 = int.Parse(txtDC2.Text);
            int dc3 = int.Parse(txtDC3.Text);
            int dc4 = int.Parse(txtDC4.Text);
            int vc0 = int.Parse(txtVC0.Text);
            int vc1 = int.Parse(txtVC1.Text);
            int vc2 = int.Parse(txtVC2.Text);
            int vc3 = int.Parse(txtVC3.Text);
            int vc4 = int.Parse(txtVC4.Text);
            DataRow dr0, dr1, dr2, dr3, dr4;
            for (int i = 0; i < vc0; i++)
            {
                dr0 = _dt.NewRow();
                dr0["VID"] = 10000000 + i;
                dr0["DID1"] = 0;
                dr0["DID2"] = 0;
                dr0["DID3"] = 0;
                dr0["DID4"] = 0;
                dr0["LEVEL"] = 0;
                _dt.Rows.Add(dr0);
            }
            for (int i1 = 0; i1 < vc1; i1++)
            {
                dr1 = _dt.NewRow();
                dr1["VID"] = 20000000 + i1;
                dr1["DID1"] = 100000 + i1 / dc1;
                dr1["DID2"] = 0;
                dr1["DID3"] = 0;
                dr1["DID4"] = 0;
                dr1["LEVEL"] = 1;
                _dt.Rows.Add(dr1);
            }
            for (int i2 = 0; i2 < vc2; i2++)
            {
                dr2 = _dt.NewRow();
                dr2["VID"] = 30000000 + i2;
                dr2["DID1"] = 100000 + i2 / (vc2 / (vc1 / dc1));
                dr2["DID2"] = 200000 + i2 / dc2;
                dr2["DID3"] = 0;
                dr2["DID4"] = 0;
                dr2["LEVEL"] = 2;
                _dt.Rows.Add(dr2);
            }
            for (int i3 = 0; i3 < vc3; i3++)
            {
                dr3 = _dt.NewRow();
                dr3["VID"] = 40000000 + i3;
                dr3["DID1"] = 100000 + i3 / (vc3 / (vc1 / dc1));
                dr3["DID2"] = 200000 + i3 / (vc3 / (vc2 / dc2));
                dr3["DID3"] = 300000 + i3 / dc3;
                dr3["DID4"] = 0;
                dr3["LEVEL"] = 3;
                _dt.Rows.Add(dr3);
            }
            for (int i4 = 0; i4 < vc4; i4++)
            {
                dr4 = _dt.NewRow();
                dr4["VID"] = 50000000 + i4;
                dr4["DID1"] = 100000 + i4 / (vc4 / (vc1 / dc1));
                dr4["DID2"] = 200000 + i4 / (vc4 / (vc2 / dc2));
                dr4["DID3"] = 300000 + i4 / (vc4 / (vc3 / dc3));
                dr4["DID4"] = 400000 + i4 / dc4;
                dr4["LEVEL"] = 4;
                _dt.Rows.Add(dr4);
            }
            _mdo5l.GenerateRealtimeStructure(_dt);
            buttonDT_Click(null, null);
        }

        private void buttonCQStore_Click(object sender, EventArgs e)
        {
            formVCQStore f = new formVCQStore(_dtcqstore);

            f.Show();
        }
    }
}
