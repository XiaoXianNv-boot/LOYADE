using System;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;

using LOYADE;

namespace LOYADE.BPM
{
    public class ObjectToken : ObjectDataAdpter
    {
        public ObjectToken()
        {
            _islocked = false;
            _isinduration = false;
            _durationvalue = 0;
            _dictokencolor = new Dictionary<string, ObjectTokenColor>();
        }

        private string _originalsn;

        [
            DisplayName("Template Label"),
            DescriptionAttribute("Template Label."),
            ReadOnlyAttribute(true)
        ]
        public string TemplateName
        {
            get { return _drdata["TemplateName"].ToString(); }
            set { _drdata["TemplateName"] = value; }
        }
 
        [Browsable(false)]
        public DataRow DrData
        {
            get { return _drdata; }
            set { _drdata = value; }
        }

        private bool _isinduration;

        [
            DisplayName("Is In Duration"),
            DescriptionAttribute("Is In Duration"),
            ReadOnlyAttribute(true)
        ]
        public bool IsInDuration
        {
            get { return _isinduration; }
            set { _isinduration = value; }
        }

        private int _durationvalue;

        [
            DisplayName("Duration Value"),
            DescriptionAttribute("Duration Value"),
            ReadOnlyAttribute(true)
        ]
        public int DurationValue
        {
            get { return _durationvalue; }
            set { _durationvalue = value; }
        }


        public override void GenerateDataTableColumns(DataTable dt)
        {
            DataColumn dc = new DataColumn("SN", typeof(string));
            dc.Caption = "SN";
            dc.AllowDBNull = false;
            dc.DefaultValue = Guid.NewGuid().ToString();
            dt.Columns.Add(dc);

            dc = new DataColumn("PlaceSN", typeof(string));
            dc.Caption = "PlaceSN";
            dc.AllowDBNull = false;
            dc.DefaultValue = ""; ;
            dt.Columns.Add(dc);

            dc = new DataColumn("TemplateName", typeof(string));
            dc.Caption = "TemplateName";
            dc.AllowDBNull = false;
            dc.DefaultValue = "";
            dt.Columns.Add(dc);

            dc = new DataColumn("Label", typeof(string));
            dc.Caption = "Label";
            dc.AllowDBNull = false;
            dc.DefaultValue = ""; ;
            dt.Columns.Add(dc);
        }

        public virtual void CreateDataRow(DataTable dt)
        {
            _drdata = dt.NewRow();
            this.SN = Guid.NewGuid().ToString();
            _drdata["PlaceSN"] = "";
            _drdata["Label"] = "K [" + DateTime.Now.ToString("MMddhhmmssffff") + "]";
            dt.Rows.Add(_drdata);
        }

        public void Serialize()
        {
        }

        public void DeSerialize()
        {
        }

        protected ObjectTokenColor _markingtokencolor;


        public override string ToString()
        {
            return this.Label;
        }

        public ObjectTokenColor this[string key]
        {
            get { return _dictokencolor[key]; }
        }

        private Dictionary<string, ObjectTokenColor> _dictokencolor;

        [
            Browsable(false)
        ]
        public Dictionary<string, ObjectTokenColor> DicObjectTokenColor
        {
            get { return _dictokencolor; }
        }

        private bool _islocked;

        [
            DisplayName("Is Locked"),
            DescriptionAttribute("Is Locked."),
            ReadOnlyAttribute(true)
        ]
        public bool IsLocked
        {
            get { return _islocked; }
            set { _islocked = value; }
        }

        [
            DisplayName("SN"),
            DescriptionAttribute("SN."),
            ReadOnlyAttribute(true)
        ]
        public string SN
        {
            get { return _drdata["SN"].ToString(); }
            set
            {
                _drdata["SN"] = value;
                _originalsn = value;
            }
        }

        [
            DisplayName("Original SN"),
            DescriptionAttribute("Original SN."),
            ReadOnlyAttribute(true)
        ]
        public string OriginalSN
        {
            get { return _originalsn; }
            set { _originalsn = value; }
        }

        [
            DisplayName("PlaceSN"),
            DescriptionAttribute("PlaceSN."),
            ReadOnlyAttribute(true)
        ]
        public string PlaceSN
        {
            get { return _drdata["PlaceSN"].ToString(); }
            set { _drdata["PlaceSN"] = value; }
        }

        public void SetRunningPlace(ObjectPlace p)
        {
            if (!p.ListRunningObjectToken.Contains(this))
                p.ListRunningObjectToken.Add(this);
        }

        public void SetPlace(ObjectPlace p)
        {
            if (!p.ListObjectToken.Contains(this))
                p.ListObjectToken.Add(this);
            _drdata["PlaceSN"] = p.SN;
        }

        [
            DisplayName("Label"),
            CategoryAttribute("Design"),
            DescriptionAttribute("Label."),
            ReadOnlyAttribute(false)
        ]
        public string Label
        {
            get { return _drdata["Label"].ToString(); }
            set { _drdata["Label"] = value; }
        }
    }
}
