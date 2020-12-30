using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Timers;

namespace LOYADE.BPM
{
    public class ObjectTransition : ObjectPN
    {
        //定义委托
        public delegate void ControllingTimerElapsedHandler(object sender, EventArgs e);
        public delegate void ObservingTimerElapsedHandler(object sender, EventArgs e);
        //定义事件
        public event ControllingTimerElapsedHandler ControllingTimerElapsed;
        public event ObservingTimerElapsedHandler ObservingTimerElapsed;

        public ObjectTransition()
        {
            _listprearc = new List<ObjectArc>();
            _listpostarc = new List<ObjectArc>();
            _listpreplace = new List<ObjectPlace>();
            _listpostplace = new List<ObjectPlace>();
            _listtoken = new List<ObjectToken>();
            _controllingtimer = new Timer();
            _controllingtimer.Elapsed += _controllingtimer_Elapsed;
            _observingtimer = new Timer();
            _observingtimer.Elapsed += _observingtimer_Elapsed;
            _listsplitcolornames = new List<string>();
        }

        private void _observingtimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (ObservingTimerElapsed != null)
                ObservingTimerElapsed(this, new EventArgs());
        }

        private void _controllingtimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (ControllingTimerElapsed != null)
                ControllingTimerElapsed(this, new EventArgs());
        }

        private List<string> _listsplitcolornames;

        [
            Browsable(false)
        ]
        public List<string> ListSplitColorNames
        {
            get { return _listsplitcolornames; }
            set { _listsplitcolornames = value; }
        }

        private List<ObjectToken> _listtoken;

        [Browsable(false)]
        public List<ObjectToken> ListObjectToken
        {
            get { return _listtoken; }
            set { _listtoken = value; }
        }

        private Timer _controllingtimer;

        [Browsable(false)]
        public Timer ControllingTimer
        {
            get { return _controllingtimer; }
            set { _controllingtimer = value; }
        }

        private Timer _observingtimer;

        [Browsable(false)]
        public Timer ObservingTimer
        {
            get { return _observingtimer; }
            set { _observingtimer = value; }
        }

        private List<ObjectArc> _listprearc;

        [Browsable(false)]
        public List<ObjectArc> ListPreArc
        {
            get { return _listprearc; }
            set { _listprearc = value; }
        }

        private List<ObjectPlace> _listpreplace;

        [Browsable(false)]
        public List<ObjectPlace> ListPrePlace
        {
            get { return _listpreplace; }
            set { _listpreplace = value; }
        }

        private List<ObjectArc> _listpostarc;

        [Browsable(false)]
        public List<ObjectArc> ListPostArc
        {
            get { return _listpostarc; }
            set { _listpostarc = value; }
        }

        private List<ObjectPlace> _listpostplace;

        [Browsable(false)]
        public List<ObjectPlace> ListPostPlace
        {
            get { return _listpostplace; }
            set { _listpostplace = value; }
        }

        public override string ToString()
        {
            return "LOYADE.BPM.ObjectTransition";
        }

        public override ObjectPN Clone(DataSet ds, string netname)
        {
            string type = this.GetType().FullName;
            ObjectTransition pno = new ObjectTransition();
            pno.NetName = netname;
            if (!ds.Tables.Contains(type))
            {
                DataTable dt = new DataTable(type);
                pno.GenerateDataTableColumns(dt);
                ds.Tables.Add(dt);
            }
            pno.CreateDataRow(ds.Tables[type]);
            base.ClonePetriNetObject(this, pno);
            pno.ControllingPeriod = this.ControllingPeriod;
            pno.ObservingPeriod = this.ObservingPeriod;
            pno.ControllingProperty = this.ControllingProperty;
            pno.ObservingProperty = this.ObservingProperty;
            pno.Rate = this.Rate;
            pno.Priority = this.Priority;
            return pno;
        }

        public override void SetX(int x)
        {
            _outerrectangle.X = x;
            _innerrectangle.X = x + 7.4f;
        }

        public override void SetY(int y)
        {
            _outerrectangle.Y = y;
            _innerrectangle.Y = y + 7.4f;
        }


        public override void RefreshObject(Graphics g)
        {
            SolidBrush sb;
            if (this.ControllingPeriod == 0 && this.ObservingPeriod == 0)
                sb = new SolidBrush(Color.Cyan);
            else
                sb = new SolidBrush(Color.Purple);
            g.FillRectangle(sb, _outerrectangle);
            Pen p;
            switch (_status)
            {
                default:
                    p = new Pen(Color.SlateBlue, 3);
                    break;
                case PetriNetObjectStatus.Firing:
                    p = new Pen(Color.Blue, 5);
                    break;
                case PetriNetObjectStatus.Enabled:
                    p = new Pen(Color.DarkBlue, 5);
                    break;
            }
            g.DrawRectangle(p, _outerrectangle);
            if (_selected)
            {
                Pen ps = new Pen(Color.Green, 5);
                g.DrawRectangle(ps, _outerrectangle);
            }
            SolidBrush sbstr = new SolidBrush(Color.Black);
            if (_showproperty)
            {
                g.DrawString(this.Label,
                    new Font("Arial", 10f), sbstr,
                    _outerrectangle.X + base.PropertyOffsetX,
                    _outerrectangle.Y + base.PropertyOffsetY);
                if (this.ControllingPeriod > 0)
                {
                    g.DrawString("C=" + this.ControllingPeriod.ToString(),
                           new Font("Arial", 10f), sbstr,
                           _outerrectangle.X + base.PropertyOffsetX,
                           _outerrectangle.Y + base.PropertyOffsetY + _outerrectangle.Height / 2);
                }
                else if (this.ObservingPeriod > 0)
                {
                    g.DrawString("O=" + this.ObservingPeriod.ToString(),
                           new Font("Arial", 10f), sbstr,
                           _outerrectangle.X + base.PropertyOffsetX,
                           _outerrectangle.Y + base.PropertyOffsetY + _outerrectangle.Height / 2);
                }
                else
                {
                    g.DrawString("权限=" + this.ControllingProperty.ToString(),
                        new Font("Arial", 10f), sbstr,
                        _outerrectangle.X + base.PropertyOffsetX,
                        _outerrectangle.Y + base.PropertyOffsetY + _outerrectangle.Height / 2);
                }
            }
        }

        [
           DisplayName("Controlling Property"),
           DescriptionAttribute("Controlling Property"),
           CategoryAttribute("Behavior"),
           ReadOnlyAttribute(false)
        ]
        public string ControllingProperty
        {
            get { return _drdata["ControllingProperty"].ToString(); }
            set { _drdata["ControllingProperty"] = value; }
        }

        [
            DisplayName("Observing Property"),
            DescriptionAttribute("Observing Property"),
            CategoryAttribute("Behavior"),
            ReadOnlyAttribute(false)
        ]
        public string ObservingProperty
        {
            get { return _drdata["ObservingProperty"].ToString(); }
            set { _drdata["ObservingProperty"] = value; }
        }

        [
            CategoryAttribute("Data"),
            DisplayName("Priority"),
            DescriptionAttribute("Priority"),
            ReadOnlyAttribute(false)
        ]
        public decimal Priority
        {
            get { return (decimal)_drdata["Priority"]; }
            set { _drdata["Priority"] = value; }
        }

        [
            CategoryAttribute("Data"),
            DisplayName("Rate"),
            DescriptionAttribute("Rate"),
            ReadOnlyAttribute(false)
        ]
        public decimal Rate
        {
            get { return (decimal)_drdata["Rate"]; }
            set { _drdata["Rate"] = value; }
        }

        [
            CategoryAttribute("Behavior"),
            DisplayName("Observing Period"),
            DescriptionAttribute("Observing Period"),
            ReadOnlyAttribute(false)
        ]
        public int ObservingPeriod
        {
            get { return (int)_drdata["ObservingPeriod"]; }
            set
            {
                if (value > 0)
                {
                    _drdata["ControllingPeriod"] = 0;
                    _drdata["ObservingPeriod"] = value;
                    _drdata["Rate"] = 100;
                    _observingtimer.Interval = value;
                    foreach (ObjectArc a in _listprearc)
                        a.ArcType = ArcType.ObserveControl;
                    foreach (ObjectArc a in _listpostarc)
                        a.ArcType = ArcType.ObserveControl;
                }
                else
                {
                    _drdata["ObservingProperty"] = "";
                    foreach (ObjectArc a in _listprearc)
                        a.ArcType = ArcType.Normal;
                    foreach (ObjectArc a in _listpostarc)
                        a.ArcType = ArcType.Normal;
                }
            }
        }

        [
            CategoryAttribute("Design"),
            DisplayName("SortColorName"),
            DescriptionAttribute("Sort Color Label"),
            ReadOnlyAttribute(true)
        ]
        public string SortColorName
        {
            get { return _drdata["SortColorName"].ToString(); }
            set { _drdata["SortColorName"] = value; }
        }

        [
            CategoryAttribute("Design"),
            DisplayName("IsKeyColorOrderASC"),
            DescriptionAttribute("Is Key Color Order ASC"),
            ReadOnlyAttribute(false)
        ]
        public bool IsKeyColorOrderASC
        {
            get { return (bool)_drdata["IsKeyColorOrderASC"]; }
            set { _drdata["IsKeyColorOrderASC"] = value; }
        }

        [
            CategoryAttribute("Behavior"),
            DisplayName("Controlling Period"),
            DescriptionAttribute("Controlling Period"),
            ReadOnlyAttribute(false)
        ]
        public int ControllingPeriod
        {
            get { return (int)_drdata["ControllingPeriod"]; }
            set
            {
                if (value > 0)
                {
                    _drdata["ObservingPeriod"] = 0;
                    _drdata["Rate"] = 100;
                    _drdata["ControllingPeriod"] = value;
                    _controllingtimer.Interval = value;
                    foreach (ObjectArc a in _listpostarc)
                        a.ArcType = ArcType.ObserveControl;
                    foreach (ObjectArc a in _listprearc)
                        a.ArcType = ArcType.ObserveControl;
                }
                else
                {
                    _drdata["ControllingProperty"] = "";
                    foreach (ObjectArc a in _listprearc)
                        a.ArcType = ArcType.Normal;
                    foreach (ObjectArc a in _listpostarc)
                        a.ArcType = ArcType.Normal;
                }
            }
        }

        [
            Browsable(false)
        ]
        public string SplitColorNames
        {
            get { return _drdata["SplitColorNames"].ToString(); }
            set
            {
                _drdata["SplitColorNames"] = value;
                if (value == "")
                    _listsplitcolornames.Clear();
            }
        }

        public override void Serialize()
        {
            base.SerializePNO();
            System.Text.StringBuilder sbc = new System.Text.StringBuilder();
            for (int i = 0; i < _listsplitcolornames.Count; ++i)
            {
                sbc.Append(_listsplitcolornames[i]);
                sbc.Append(",");
            }
            _drdata["SplitColorNames"] = sbc.ToString();
        }

        public override void DeSerialize()
        {
            base.DeSerializePNO();
            string[] arr = _drdata["SplitColorNames"].ToString().Split(',');
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i].Trim() != "")
                {
                    _listsplitcolornames.Add(arr[i]);
                }
            }
        }

        public override void GenerateDataTableColumns(DataTable dt)
        {
            base.GenerateDataTableColumns(dt);
            DataColumn dc = new DataColumn("Rate", typeof(decimal));
            dc.Caption = "Rate";
            dc.AllowDBNull = false;
            dc.DefaultValue = 0;
            dt.Columns.Add(dc);

            dc = new DataColumn("SplitColorNames", typeof(string));
            dc.Caption = "SplitColorNames";
            dc.AllowDBNull = false;
            dc.DefaultValue = "";
            dt.Columns.Add(dc);

            dc = new DataColumn("Priority", typeof(decimal));
            dc.Caption = "Priority";
            dc.AllowDBNull = false;
            dc.DefaultValue = 0;
            dt.Columns.Add(dc);

            dc = new DataColumn("ObservingPeriod", typeof(int));
            dc.Caption = "ObservingPeriod";
            dc.AllowDBNull = false;
            dc.DefaultValue = 0;
            dt.Columns.Add(dc);

            dc = new DataColumn("ControllingPeriod", typeof(int));
            dc.Caption = "ControllingPeriod";
            dc.AllowDBNull = false;
            dc.DefaultValue = 0;
            dt.Columns.Add(dc);

            dc = new DataColumn("ControllingProperty", typeof(string));
            dc.Caption = "ControllingProperty";
            dc.AllowDBNull = false;
            dc.DefaultValue = "";
            dt.Columns.Add(dc);

            dc = new DataColumn("ObservingProperty", typeof(string));
            dc.Caption = "ObservingProperty";
            dc.AllowDBNull = false;
            dc.DefaultValue = "";
            dt.Columns.Add(dc);

            dc = new DataColumn("SortColorName", typeof(string));
            dc.Caption = "SortColorName";
            dc.AllowDBNull = false;
            dc.DefaultValue = "";
            dt.Columns.Add(dc);

            dc = new DataColumn("IsKeyColorOrderASC", typeof(bool));
            dc.Caption = "IsKeyColorOrderASC";
            dc.AllowDBNull = false;
            dc.DefaultValue = false;
            dt.Columns.Add(dc);


        }

        public override void CreateDataRow(DataTable dt)
        {
            base.CreateDataRow(dt);
            _drdata["ID"] = Guid.NewGuid().ToString();
            _drdata["SN"] = Guid.NewGuid().ToString();
            _drdata["Label"] = "T [" + DateTime.Now.ToString("MMddhhmmssffff") + " ]";
            _drdata["Rate"] = 1;
            _drdata["Priority"] = 1;
            _drdata["ObservingPeriod"] = 0;
            _drdata["ControllingPeriod"] = 0;
            _drdata["ControllingProperty"] = "";
            _drdata["SortColorName"] = "";
            _drdata["ObservingProperty"] = "";
            _drdata["IsKeyColorOrderASC"] = true;
        }

        public override void AddPrePNO(ObjectPN pno)
        {
            _listpreplace.Add(pno as ObjectPlace);
        }

        public override void AddPostPNO(ObjectPN pno)
        {
            _listpostplace.Add(pno as ObjectPlace);
        }

        public override void AddPreArc(ObjectArc a)
        {
            _listprearc.Add(a);
        }

        public override void AddPostArc(ObjectArc a)
        {
            _listpostarc.Add(a);
        }
    }
}
