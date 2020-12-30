using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Data;

namespace LOYADE.BPM
{
    public class ObjectPlace : ObjectPN
    {
        public ObjectPlace()
        {
            _listprearc = new List<ObjectArc>();
            _listpostarc = new List<ObjectArc>();
            _listpretransition = new List<ObjectTransition>();
            _listposttransition = new List<ObjectTransition>();
            _listtoken = new List<ObjectToken>();
            _listrunningtoken = new List<ObjectToken>();

        }

        private List<ObjectToken> _listtoken;

        [Browsable(false)]
        public List<ObjectToken> ListObjectToken
        {
            get { return _listtoken; }
            set { _listtoken = value; }
        }

        private List<ObjectToken> _listrunningtoken;

        [Browsable(false)]
        public List<ObjectToken> ListRunningObjectToken
        {
            get { return _listrunningtoken; }
            set { _listrunningtoken = value; }
        }

        private List<ObjectArc> _listprearc;

        [Browsable(false)]
        public List<ObjectArc> ListPreArc
        {
            get { return _listprearc; }
            set { _listprearc = value; }
        }

        private List<ObjectTransition> _listpretransition;

        [Browsable(false)]
        public List<ObjectTransition> ListPreTransition
        {
            get { return _listpretransition; }
            set { _listpretransition = value; }
        }

        private List<ObjectArc> _listpostarc;

        [Browsable(false)]
        public List<ObjectArc> ListPostArc
        {
            get { return _listpostarc; }
            set { _listpostarc = value; }
        }

        private List<ObjectTransition> _listposttransition;

        [Browsable(false)]
        public List<ObjectTransition> ListPostTransition
        {
            get { return _listposttransition; }
            set { _listposttransition = value; }
        }

        public override string ToString()
        {
            return this.GetType().FullName;
        }

        public override ObjectPN Clone(DataSet ds, string netname)
        {
            string type = this.ToString();
            ObjectPlace pno = new ObjectPlace();
            pno.NetName = netname;
            if (!ds.Tables.Contains(type))
            {
                DataTable dt = new DataTable(type);
                pno.GenerateDataTableColumns(dt);
                ds.Tables.Add(dt);
            }
            pno.CreateDataRow(ds.Tables[type]);
            base.ClonePetriNetObject(this, pno);
            pno.DurationColorName = this.DurationColorName;
            return pno;
        }

        public override void RefreshObject(Graphics g)
        {
            Pen p;
            SolidBrush sb;
            sb = new SolidBrush(Color.Yellow);
            g.FillEllipse(sb, _outerrectangle);
            switch (_status)
            {
                default:
                    p = new Pen(Color.Orange, 3);
                    break;
                case PetriNetObjectStatus.Firing:
                    p = new Pen(Color.Red, 5);
                    break;
                case PetriNetObjectStatus.Enabled:
                    p = new Pen(Color.Brown, 5);
                    break;
            }
            g.DrawEllipse(p, _outerrectangle);
            if (_selected)
            {
                Pen ps = new Pen(Color.Green, 3);
                g.DrawRectangle(ps, _outerrectangle);
            }
            SolidBrush sbstr = new SolidBrush(Color.Black);
            if (_showproperty)
            {
                g.DrawString(this.Label,
                    new Font("Arial", 10f), sbstr,
                    _outerrectangle.X + base.PropertyOffsetX,
                    _outerrectangle.Y + base.PropertyOffsetY);
                g.DrawString("C=" + this.Capacity.ToString() + "; M=" + _listrunningtoken.Count.ToString() + "/" + _listtoken.Count.ToString(),
                    new Font("Arial", 10f), sbstr,
                    _outerrectangle.X + base.PropertyOffsetX,
                    _outerrectangle.Y + base.PropertyOffsetY + _outerrectangle.Height / 2);
            }
        }

        [
            DisplayName("Duration Color Label"),
            CategoryAttribute("Design"),
            DescriptionAttribute("Duration Color Label"),
            ReadOnlyAttribute(false)
        ]
        public string DurationColorName
        {
            get { return _drdata["DurationColorName"].ToString(); }
            set { _drdata["DurationColorName"] = value; }
        }

        [
            DisplayName("Capacity"),
            CategoryAttribute("Data"),
            DescriptionAttribute("Capacity: The maximum of token count."),
            ReadOnlyAttribute(false)
        ]
        public int Capacity
        {
            get { return (int)_drdata["Capacity"]; }
            set { _drdata["Capacity"] = value; }
        }

        public override void Serialize()
        {
            base.SerializePNO();
        }

        public override void DeSerialize()
        {
            base.DeSerializePNO();
        }

        public override void GenerateDataTableColumns(DataTable dt)
        {
            base.GenerateDataTableColumns(dt);
            DataColumn dc = new DataColumn("DurationColorName", typeof(string));
            dc.Caption = "DurationColorName";
            dc.AllowDBNull = false;
            dc.DefaultValue = "";
            dt.Columns.Add(dc);

            dc = new DataColumn("Capacity", typeof(int));
            dc.Caption = "Capacity";
            dc.AllowDBNull = false;
            dc.DefaultValue = 0;
            dt.Columns.Add(dc);

        }

        public override void CreateDataRow(DataTable dt)
        {
            base.CreateDataRow(dt);
            _drdata["ID"] = Guid.NewGuid().ToString();
            _drdata["SN"] = Guid.NewGuid().ToString();
            _drdata["Label"] = "P [" + DateTime.Now.ToString("MMddhhmmssffff") + " ]";
            _drdata["DurationColorName"] = "";
            _drdata["Capacity"] = 0;
        }

        public override void AddPrePNO(ObjectPN pno)
        {
            _listpretransition.Add(pno as ObjectTransition);
        }

        public override void AddPostPNO(ObjectPN pno)
        {
            _listposttransition.Add(pno as ObjectTransition);
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
