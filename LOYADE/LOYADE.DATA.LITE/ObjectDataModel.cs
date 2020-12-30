using System;
using System.Collections.Generic;
using System.Text;

namespace LOYADE.DATA.LITE
{
    public class ObjectDataModel
    {
        public ObjectDataModel()
        {

        }

        public ObjectDataModel(string fieldname, string label, string datatype, int maxlength)
        {
            this.FieldName = fieldname;
            this.Label = label;
            this.DataType = datatype;
            this.MaxLength = maxlength;

            this.Precision = -1;
            this.ExchangeKey = fieldname;
            this.UserVisible = true;
            this.UserReadOnly = false;
            this.IsAutoIncrease = false;
            this.IsAllowNull = false;
            this.DefaultValue = "";
            this.IsPrimaryKey = false;
        }

        public ObjectDataModel(string fieldname, string label, string datatype, int maxlength, int precision, string exchangekey, string defaultvalue, bool visible, bool onlyread, bool isallownull, bool isprimarykey)
        {
            this.FieldName = fieldname;
            this.Label = label;
            this.DataType = datatype;
            this.MaxLength = maxlength;
            this.Precision = precision;
            this.ExchangeKey = exchangekey;
            this.UserVisible = visible;
            this.UserReadOnly = onlyread;
            this.IsAllowNull = isallownull;
            this.DefaultValue = defaultvalue;
            this.IsPrimaryKey = isprimarykey;
        }

        public string FieldName { get; set; }
        public string Label { get; set; }
        public string ExchangeKey { get; set; }
        public bool UserVisible { get; set; }
        public bool UserReadOnly { get; set; }
        public string DataType { get; set; }
        public int MaxLength { get; set; }
        public int Precision { get; set; }
        public bool IsAllowNull { get; set; }
        public bool IsAutoIncrease { get; set; }
        public string DefaultValue { get; set; }
        public bool IsPrimaryKey { get; set; }

    }
}
