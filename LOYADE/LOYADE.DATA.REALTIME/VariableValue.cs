using System;
using System.Collections.Generic;
using System.Text;

namespace LOYADE.DATA.REALTIME
{
    /// <summary>
    /// 6*8 = 48bytes
    /// </summary>
    public class VariableValue
    {
        private string _variableid;

        private string _deviceid;

        private DateTime _scadadt;

        private DateTime _receivedt;

        private DateTime _storedt;

        private string _rawvalue;

        private string _convertedvalue; 

        private string _sendmsg; 

        private string _receivemsg;

        private int _commandindex;

        private int _bitlength;

        private int _startbyteindex;

        private int _endbyteindex;

        private int _startbitindex;

        private int _endbitindex; 
         

        public string VariableID
        {
            get
            {
                return _variableid;
            }

            set
            {
                _variableid = value;
            }
        }

        public string DeviceID
        {
            get
            {
                return _variableid;
            }

            set
            {
                _variableid = value;
            }
        }

        public DateTime ScadaDT
        {
            get
            {
                return _scadadt;
            }

            set
            {
                _scadadt = value;
            }
        }

        public DateTime ReceiveDT
        {
            get
            {
                return _receivedt;
            }

            set
            {
                _receivedt = value;
            }
        }

        public DateTime StoreDT
        {
            get
            {
                return _storedt;
            }

            set
            {
                _storedt = value;
            }
        }

        public string RawValue
        {
            get
            {
                return _rawvalue;
            }

            set
            {
                _rawvalue = value;
            }
        }

        public string ConvertedValue
        {
            get
            {
                return _convertedvalue;
            }

            set
            {
                _convertedvalue = value;
            }
        }

        public string SendMSG
        {
            get
            {
                return _sendmsg;
            }

            set
            {
                _sendmsg = value;
            }
        }

        public string ReceiveMSG
        {
            get
            {
                return _receivemsg;
            }

            set
            {
                _receivemsg = value;
            }
        }

        public int CommandIndex
        {
            get
            {
                return _commandindex;
            }

            set
            {
                _commandindex = value;
            }
        }

        public int StartByteIndex
        {
            get
            {
                return _startbyteindex;
            }

            set
            {
                _startbyteindex = value;
            }
        }

        public int EndByteIndex
        {
            get
            {
                return _endbyteindex;
            }

            set
            {
                _endbyteindex = value;
            }
        }

        public int StartBitIndex
        {
            get
            {
                return _startbitindex;
            }

            set
            {
                _startbitindex = value;
            }
        }

        public int EndBitIndex
        {
            get
            {
                return _endbitindex;
            }

            set
            {
                _endbitindex = value;
            }
        }

        public int BitLength
        {
            get
            {
                return _bitlength;
            }

            set
            {
                _bitlength = value;
            }
        }
    }
}
