using System;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;

using LOYADE;

namespace LOYADE.BPM
{
    public class ObjectTokenColor : ObjectDataAdpter
    {
        /// <summary>
        /// 构造函数，用于内存创建
        /// </summary>
        public ObjectTokenColor()
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
            dc = new DataColumn("ObjectTokenSN", typeof(string)); dt.Columns.Add(dc);
            dc = new DataColumn("MaxValue", typeof(double)); dc.DefaultValue = 0; dt.Columns.Add(dc);
            dc = new DataColumn("MinValue", typeof(double)); dc.DefaultValue = 0; dt.Columns.Add(dc);
            dc = new DataColumn("InitialValue", typeof(double)); dc.DefaultValue = 0; dt.Columns.Add(dc);
            dc = new DataColumn("CurrentValue", typeof(double)); dc.DefaultValue = 0; dt.Columns.Add(dc);
            dc = new DataColumn("TempValue", typeof(double)); dc.DefaultValue = 0; dt.Columns.Add(dc);
            dc = new DataColumn("IsVisible", typeof(bool)); dc.DefaultValue = true; dt.Columns.Add(dc);
            dc = new DataColumn("IsReadOnly", typeof(bool)); dc.DefaultValue = false; dt.Columns.Add(dc);
            dc = new DataColumn("FieldName", typeof(string)); dc.DefaultValue = ""; dt.Columns.Add(dc);
            dc = new DataColumn("ExchangeKey", typeof(string)); dc.DefaultValue = ""; dt.Columns.Add(dc);
        }

        public void CreateDataRow(DataTable dt)
        {
            _drdata = dt.NewRow();
            _drdata["ObjectTokenSN"] = Guid.NewGuid().ToString();
            _drdata["FieldName"] = _drdata["ObjectTokenSN"] ; 
            dt.Rows.Add(_drdata);
        }

        public void Serialize()
        {

        }

        public void DeSerialize()
        {

        }         

        [
            DisplayName("ObjectToken SN"),
            DescriptionAttribute("ObjectToken SN."),
            ReadOnlyAttribute(true)
        ]
        public string ObjectTokenSN
        {
            get { return _drdata["ObjectTokenSN"].ToString(); }
            set { _drdata["ObjectTokenSN"] = value; }
        }

        [
            DisplayName("Label"),
            DescriptionAttribute("Label."),
            ReadOnlyAttribute(true)
        ]
        public string Label
        {
            get { return _drdata["Label"].ToString(); }
            set { _drdata["Label"] = value; }
        }

        [
            DisplayName("IsVisible"),
            CategoryAttribute("Data"),
            DescriptionAttribute("IsVisible."),
            ReadOnlyAttribute(false)
        ]
        public bool IsVisible
        {
            get { return (bool)_drdata["IsVisible"]; }
            set { _drdata["IsVisible"] = value; }
        }

        [
            DisplayName("IsReadOnly"),
            CategoryAttribute("Data"),
            DescriptionAttribute("IsReadOnly."),
            ReadOnlyAttribute(false)
        ]
        public bool IsReadOnly
        {
            get { return (bool)_drdata["IsReadOnly"]; }
            set { _drdata["IsReadOnly"] = value; }
        }

        [
            DisplayName("FieldName"),
            CategoryAttribute("Data"),
            DescriptionAttribute("FieldName."),
            ReadOnlyAttribute(false)
        ]
        public string FieldName
        {
            get { return (string)_drdata["FieldName"]; }
            set { _drdata["FieldName"] = value; }
        }

        [
            DisplayName("ExchangeKey"),
            CategoryAttribute("Data"),
            DescriptionAttribute("ExchangeKey."),
            ReadOnlyAttribute(false)
        ]
        public string ExchangeKey
        {
            get { return (string)_drdata["ExchangeKey"]; }
            set { _drdata["ExchangeKey"] = value; }
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
