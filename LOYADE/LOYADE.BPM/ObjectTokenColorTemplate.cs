using System;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;

using LOYADE;

namespace LOYADE.BPM
{
    public class ObjectTokenColorTemplate : ObjectDataAdpter
    {
        /// <summary>
        /// 构造函数，用于内存创建
        /// </summary>
        public ObjectTokenColorTemplate()
        {

        }
 
        [Browsable(false)]
        public DataRow DrData
        {
            get { return _drdata; }
            set { _drdata = value; }
        }

        public override string ToString()
        {
            return this.Label;
        }

        public override void GenerateDataTableColumns(DataTable dt)
        {
            DataColumn dc = new DataColumn("Label", typeof(string));
            dt.Columns.Add(dc);
            dc = new DataColumn("Introduction", typeof(string)); dt.Columns.Add(dc);
            dc = new DataColumn("ObjectTokenTemplateName", typeof(string)); dt.Columns.Add(dc);
            dc = new DataColumn("MaxValue", typeof(double)); dc.DefaultValue = 0; dt.Columns.Add(dc);
            dc = new DataColumn("MinValue", typeof(double)); dc.DefaultValue = 0; dt.Columns.Add(dc);
            dc = new DataColumn("InitialValue", typeof(double)); dc.DefaultValue = 0; dt.Columns.Add(dc);
            dc = new DataColumn("CurrentValue", typeof(double)); dc.DefaultValue = 0; dt.Columns.Add(dc);
            dc = new DataColumn("TempValue", typeof(double)); dc.DefaultValue = 0; dt.Columns.Add(dc);
        }

        public void CreateDataRow(DataTable dt)
        {
            _drdata = dt.NewRow();
            _drdata["Label"] = Guid.NewGuid().ToString();
            _drdata["Introduction"] = "";
            _drdata["ObjectTokenTemplateName"] = "";
            _drdata["MaxValue"] = 0;
            _drdata["MinValue"] = 0;
            _drdata["InitialValue"] = 0;
            _drdata["CurrentValue"] = 0;
            _drdata["TempValue"] = 0;
            dt.Rows.Add(_drdata);
        }

        public void Serialize()
        {

        }

        public void DeSerialize()
        {

        }

        [
            DisplayName("ObjectToken Template Label"),
            DescriptionAttribute("ObjectToken Template Label."),
            ReadOnlyAttribute(true)
        ]
        public string ObjectTokenTemplateName
        {
            get { return _drdata["ObjectTokenTemplateName"].ToString(); }
            set { _drdata["ObjectTokenTemplateName"] = value; }
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

        [
            DisplayName("Max Value"),
            CategoryAttribute("Data"),
            DescriptionAttribute("Max Value."),
            ReadOnlyAttribute(false)
        ]
        public double MaxValue
        {
            get { return (double)_drdata["MaxValue"]; }
            set { _drdata["MaxValue"] = value; }
        }

        [
            DisplayName("Min Value"),
            CategoryAttribute("Data"),
            DescriptionAttribute("Min Value."),
            ReadOnlyAttribute(false)
        ]
        public double MinValue
        {
            get { return (double)_drdata["MinValue"]; }
            set { _drdata["MinValue"] = value; }
        }

        [
            DisplayName("Initial Value"),
            CategoryAttribute("Data"),
            DescriptionAttribute("Initial Value."),
            ReadOnlyAttribute(false)
        ]
        public double InitialValue
        {
            get { return (double)_drdata["InitialValue"]; }
            set { _drdata["InitialValue"] = value; }
        }

        [
            DisplayName("Current Value"),
            CategoryAttribute("Data"),
            DescriptionAttribute("Current Value."),
            ReadOnlyAttribute(false)
        ]
        public double CurrentValue
        {
            get { return (double)_drdata["CurrentValue"]; }
            set { _drdata["CurrentValue"] = value; }
        }

        [
            DisplayName("Temp Value"),
            DescriptionAttribute("Temp Value."),
            ReadOnlyAttribute(true)
        ]
        public double TempValue
        {
            get { return (double)_drdata["TempValue"]; }
            set { _drdata["TempValue"] = value; }
        }
    }
}
