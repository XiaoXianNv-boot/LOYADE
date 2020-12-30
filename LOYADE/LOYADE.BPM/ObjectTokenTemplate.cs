using System;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;

using LOYADE;

namespace LOYADE.BPM
{
    public class ObjectTokenTemplate : ObjectDataAdpter
    {
        public ObjectTokenTemplate()
        {
            _dictokencolortemplate = new Dictionary<string, ObjectTokenColorTemplate>();
        }
 
        [Browsable(false)]
        public DataRow DrData
        {
            get { return _drdata; }
            set { _drdata = value; }
        }

        public override void GenerateDataTableColumns(DataTable dt)
        {
            dt.Columns.Add(new DataColumn("Label", typeof(string)));
            dt.Columns.Add(new DataColumn("Introduction", typeof(string)));
        }

        public virtual void CreateDataRow(DataTable dt)
        {
            _drdata = dt.NewRow();
            _drdata["Label"] = Guid.NewGuid().ToString();
            _drdata["Introduction"] = "";
            dt.Rows.Add(_drdata);
        }

        public void Serialize()
        {
        }

        public void DeSerialize()
        {
        }
        public override string ToString()
        {
            return this.Label;
        }

        public ObjectTokenColorTemplate this[string key]
        {
            get { return _dictokencolortemplate[key]; }
        }

        private Dictionary<string, ObjectTokenColorTemplate> _dictokencolortemplate;

        [
            Browsable(false)
        ]
        public Dictionary<string, ObjectTokenColorTemplate> DicObjectTokenColorTemplate
        {
            get { return _dictokencolortemplate; }
        }

        [
            DisplayName("Introduction"),
            CategoryAttribute("Design"),
            DescriptionAttribute("Introduction."),
            ReadOnlyAttribute(false)
        ]
        public string Introduction
        {
            get { return _drdata["Introduction"].ToString(); }
            set { _drdata["Introduction"] = value; }
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
