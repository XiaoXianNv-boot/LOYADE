using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace LOYADE.DATA.REALTIME
{
    public class TransferHandler
    {
        private bool _isposting = false;
        private bool _issaving = false;
        private Thread _tpost;
        private Thread _tsave;
        private string _url = "";
        private string _result = "";
        public MemoryMappingVariable MMV;
        public int TimeSpan = 500;

        public List<string> LogTransferToHMI = new List<string>();

        public TransferHandler(string url)
        {
            _url = url;
            MMV = new MemoryMappingVariable();
        }

        public TransferHandler(string url, string devicesn)
        {
            _url = url;
            MMV = new MemoryMappingVariable(devicesn);
        }

        public void StartTransferToHMI()
        {
            LogTransferToHMI.Clear();
            _tpost = new Thread(new ThreadStart(TPostData));
            _tpost.IsBackground = true;
            _isposting = true;
            _tpost.Start();
        }

        private void TPostData()
        {
            List<string> avids = new List<string>();//记录哪些变量的值队列被发送了
            while (_isposting)
            {
                try
                {
                    string data = "";
                    avids.Clear();
                    if (MMV != null && MMV.CurrentVariables != null)
                    {
                        foreach (string key in MMV.CurrentVariables.Keys)
                        {
                            VariableValue vv = MMV.GetVaraibleValueByTest(key);//使用测试型取值
                            if (vv != null)//必须检测是否为空
                            {
                                avids.Add(key);//记录哪些变量的值队列被发送了
                                data += vv.VariableID + "|" + vv.ScadaDT.ToString() + "|" + vv.ConvertedValue.ToString() + "|";
                            }
                        }
                    }
                    if (data != "")
                    {
                        HttpPostWithFormData httpRequestClient = new HttpPostWithFormData();
                        httpRequestClient.SetFieldValue("dsn", MMV.DeviceSN);
                        httpRequestClient.SetFieldValue("vvs", data);
                        httpRequestClient.Upload(_url, out _result);
                        if (_result == "1")
                        {
                            //发送成功才清除队顶变量值对象
                            foreach (string k in avids)
                            {
                                MMV.RemovePeekVaraibleValue(k);
                            }
                            Thread.Sleep(TimeSpan);
                            LogTransferToHMI.Add(DateTime.Now.ToString() + ": [OK] " + avids.Count + "个变量发送成功！");
                        }
                        else
                        {
                            LogTransferToHMI.Add(DateTime.Now.ToString() + ": [FAIL] " + _result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    _result = ex.Message;
                }
            }
        }

        public void StopTransferToHMI()
        {
            _isposting = false;
            if (_tpost != null)
            {
                _tpost.Abort();
                _tpost = null;
            } 
        }

        private void StartTransferToHDB()
        {
            _tsave = new Thread(new ThreadStart(TSaveData));
            _tsave.IsBackground = true;
            _issaving = true;
            _tsave.Start();
        }

        private void TSaveData()
        {

        }

        private void StopTransferToHDB()
        {
            _issaving = false;
            if (_tsave != null)
            {
                _tsave.Abort();
                _tsave = null;
            }
        }
    }
}
