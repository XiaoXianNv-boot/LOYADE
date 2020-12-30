using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace LOYADE.BPM
{
    public abstract class ObjectPN : ObjectDataAdpter
    {
        public ObjectPN()
        {
            _status = PetriNetObjectStatus.Normal;
            _showproperty = true;
            _visible = true;
            _selected = false;
            _locked = false;
            _outerrectangle = new Rectangle(0, 0, 50, 50);
            _innerrectangle = new RectangleF(0, 0, 35.2f, 35.2f);
            _isnewtopnnotsaved = true;
        }

        public override string ToString()
        {
            return this.Label;
        }

        public object this[string propertyname]
        {
            get
            {
                if (_drdata.Table.Columns.Contains(propertyname))
                    return _drdata[propertyname];
                else
                    return null;
            }
            set
            {
                if (_drdata.Table.Columns.Contains(propertyname))
                    _drdata[propertyname] = value;
            }
        }

        protected RectangleF _innerrectangle;

        [Browsable(false)]
        public RectangleF InnerRectangle
        {
            get { return _innerrectangle; }
            set { _innerrectangle = value; }
        }

        protected Rectangle _outerrectangle;

        [Browsable(false)]
        public Rectangle OuterRectangle
        {
            get { return _outerrectangle; }
            set { _outerrectangle = value; }
        }

        [
            CategoryAttribute("只读"),
            DisplayName("系统标识"),
            DescriptionAttribute("ID: the unique system id of a petri net object."),
            ReadOnlyAttribute(true)
        ]
        public string ID
        {
            get { return _drdata["ID"].ToString(); }
            set { _drdata["ID"] = value; }
        }

        [
            CategoryAttribute("只读"),
            DisplayName("系统编号"),
            DescriptionAttribute("SN: the unique system id of a petri net object."),
            ReadOnlyAttribute(true)
        ]
        public string SN
        {
            get { return _drdata["SN"].ToString(); }
            set { _drdata["SN"] = value; }
        }

        [
            DisplayName("标签"),
            DescriptionAttribute("对象标签，用户可以编辑为自己熟悉的名字"),
            CategoryAttribute("设计"),
            ReadOnlyAttribute(false)
        ]
        public string Label
        {
            get { return _drdata["Label"].ToString(); }
            set { _drdata["Label"] = value; }
        }

        [
            CategoryAttribute("只读"),
            DisplayName("系统类型"),
            DescriptionAttribute("系统类型"),
            ReadOnlyAttribute(true)
        ]
        public string Type
        {
            get { return _drdata["type"].ToString(); }
            set { _drdata["type"] = value; }
        }

        [
            DisplayName("Introduction"),
            CategoryAttribute("Data"),
            DescriptionAttribute("Introduction"),
            ReadOnlyAttribute(false)
        ]
        public string Introduction
        {
            get { return _drdata["Introduction"].ToString(); }
            set { _drdata["Introduction"] = value; }
        }

        [
            DisplayName("Property Offset X"),
            CategoryAttribute("Layout"),
            DescriptionAttribute("Property Offset X"),
            ReadOnlyAttribute(false)
        ]
        public int PropertyOffsetX
        {
            get { return (int)_drdata["PropertyOffsetX"]; }
            set { _drdata["PropertyOffsetX"] = value; }
        }

        [
            DisplayName("Property Offset Y"),
            CategoryAttribute("Layout"),
            DescriptionAttribute("Property Offset Y"),
            ReadOnlyAttribute(false)
        ]
        public int PropertyOffsetY
        {
            get { return (int)_drdata["PropertyOffsetY"]; }
            set { _drdata["PropertyOffsetY"] = value; }
        }

        [
            DisplayName("Row Index"),
            DescriptionAttribute("Row Index"),
            ReadOnlyAttribute(true)
        ]
        public int RowIndex
        {
            get { return (int)_drdata["RowIndex"]; }
            set { _drdata["RowIndex"] = value; }
        }

        [
            DisplayName("Column Index"),
            DescriptionAttribute("Column Index"),
            ReadOnlyAttribute(true)
        ]
        public int ColumnIndex
        {
            get { return (int)_drdata["ColumnIndex"]; }
            set { _drdata["ColumnIndex"] = value; }
        }

        protected string _netname;

        [
            DisplayName("Net Label"),
            DescriptionAttribute("Net Label"),
            ReadOnlyAttribute(true)
        ]
        public string NetName
        {
            get { return _netname; }
            set { _netname = value; }
        }

        protected bool _selected;

        [
            DisplayName("Selected"),
            DescriptionAttribute("Selected"),
            ReadOnlyAttribute(true)
        ]
        public bool Selected
        {
            get { return _selected; }
            set { _selected = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Browsable(false)]
        public DataRow DrData
        {
            get { return _drdata; }
            set { _drdata = value; }
        }

        [
            DisplayName("X"),
            DescriptionAttribute("X"),
            CategoryAttribute("Layout"),
            ReadOnlyAttribute(true)
        ]
        public int X
        {
            get { return _outerrectangle.X; }
        }

        public virtual void SetX(int x)
        {
            _outerrectangle.X = x;
        }

        [
            DisplayName("Y"),
            DescriptionAttribute("Y"),
            CategoryAttribute("Layout"),
            ReadOnlyAttribute(true)
        ]
        public int Y
        {
            get { return _outerrectangle.Y; }
        }

        public virtual void SetY(int y)
        {
            _outerrectangle.Y = y;
        }

        [
            DisplayName("Width"),
            DescriptionAttribute("Width"),
            ReadOnlyAttribute(true)
        ]
        public int Width
        {
            get { return _outerrectangle.Width; }
        }

        [
            DisplayName("Height"),
            DescriptionAttribute("Height"),
            ReadOnlyAttribute(true)
        ]
        public int Height
        {
            get { return _outerrectangle.Height; }
        }

        protected bool _showproperty;

        [
            CategoryAttribute("Appearance"),
            DisplayName("Show Property"),
            DescriptionAttribute("Show Property"),
            ReadOnlyAttribute(false)
        ]
        public bool ShowProperty
        {
            get { return _showproperty; }
            set { _showproperty = value; }
        }

        protected bool _isnewtopnnotsaved;

        [
            CategoryAttribute("只读"),
            DisplayName("是否本次未保存的新增对象"),
            DescriptionAttribute("是否本次未保存的新增对象"),
            ReadOnlyAttribute(false)
        ]
        public bool IsNewToPNNotSaved
        {
            get { return _isnewtopnnotsaved; }
            set { _isnewtopnnotsaved = value; }
        }

        protected bool _locked;

        [
            DisplayName("Locked"),
            DescriptionAttribute("Locked"),
            ReadOnlyAttribute(true)
        ]
        public bool Locked
        {
            get { return _locked; }
            set { _locked = value; }
        }

        protected bool _visible;

        [Browsable(false)]
        public bool Visible
        {
            get { return _visible; }
            set { _visible = value; }
        }

        protected PetriNetObjectStatus _status;

        [Browsable(false)]
        public PetriNetObjectStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public virtual bool IsContain(int x, int y)
        {
            return _outerrectangle.Contains(x, y);
        }

        public abstract void RefreshObject(Graphics g);

        public abstract void Serialize();

        public abstract void DeSerialize();

        public virtual void SerializePNO()
        {
            _drdata["X"] = this.X;
            _drdata["Y"] = this.Y;
            _drdata["Width"] = this.Width;
            _drdata["Height"] = this.Height;
        }

        public virtual void DeSerializePNO()
        {
            this.SetX((int)_drdata["X"]);
            this.SetY((int)_drdata["Y"]);
        }

        public abstract ObjectPN Clone(DataSet ds, string netname);

        public virtual void ClonePetriNetObject(ObjectPN source, ObjectPN target)
        {
            target.Introduction = source.Introduction;
            target.ColumnIndex = source.ColumnIndex;
            target.RowIndex = source.RowIndex;
            target.SetX(source.X);
            target.SetY(source.Y);
            target.PropertyOffsetX = source.PropertyOffsetX;
            target.PropertyOffsetY = source.PropertyOffsetY;
        }

        public override void GenerateDataTableColumns(DataTable dt)
        {
            DataColumn dc = new DataColumn("ID", typeof(string));
            dc.Caption = "ID";
            dc.AllowDBNull = false;
            dc.DefaultValue = "";
            dt.Columns.Add(dc);

            dc = new DataColumn("SN", typeof(string));
            dc.Caption = "SN";
            dc.AllowDBNull = false;
            dc.DefaultValue = "";
            dt.Columns.Add(dc);

            dc = new DataColumn("Label", typeof(string));
            dc.Caption = "Label";
            dc.AllowDBNull = false;
            dc.DefaultValue = "";
            dt.Columns.Add(dc);

            dc = new DataColumn("Type", typeof(string));
            dc.Caption = "Type";
            dc.AllowDBNull = false;
            dc.DefaultValue = "normal";
            dt.Columns.Add(dc);

            dc = new DataColumn("X", typeof(int));
            dc.Caption = "X";
            dc.AllowDBNull = false;
            dc.DefaultValue = 0;
            dt.Columns.Add(dc);

            dc = new DataColumn("Y", typeof(int));
            dc.Caption = "Y";
            dc.AllowDBNull = false;
            dc.DefaultValue = 0;
            dt.Columns.Add(dc);

            dc = new DataColumn("Width", typeof(int));
            dc.Caption = "Width";
            dc.AllowDBNull = false;
            dc.DefaultValue = 50;
            dt.Columns.Add(dc);

            dc = new DataColumn("Height", typeof(int));
            dc.Caption = "Height";
            dc.AllowDBNull = false;
            dc.DefaultValue = 50;
            dt.Columns.Add(dc);

            dc = new DataColumn("Introduction", typeof(string));
            dc.Caption = "Introduction";
            dc.AllowDBNull = false;
            dc.DefaultValue = "";
            dt.Columns.Add(dc);

            dc = new DataColumn("PropertyOffsetX", typeof(int));
            dc.Caption = "PropertyOffsetX";
            dc.AllowDBNull = false;
            dc.DefaultValue = 55;
            dt.Columns.Add(dc);

            dc = new DataColumn("PropertyOffsetY", typeof(int));
            dc.Caption = "PropertyOffsetY";
            dc.AllowDBNull = false;
            dc.DefaultValue = 5;
            dt.Columns.Add(dc);

            dc = new DataColumn("RowIndex", typeof(int));
            dc.Caption = "RowIndex";
            dc.AllowDBNull = false;
            dc.DefaultValue = 0;
            dt.Columns.Add(dc);

            dc = new DataColumn("ColumnIndex", typeof(int));
            dc.Caption = "ColumnIndex";
            dc.AllowDBNull = false;
            dc.DefaultValue = 0;
            dt.Columns.Add(dc);
        }

        public virtual void CreateDataRow(DataTable dt)
        {
            _drdata = dt.NewRow();
            _drdata["ID"] = Guid.NewGuid().ToString();
            _drdata["SN"] = Guid.NewGuid().ToString();
            _drdata["Introduction"] = "";
            _drdata["X"] = 0;
            _drdata["Y"] = 0;
            _drdata["ColumnIndex"] = 0;
            _drdata["RowIndex"] = 0;
            dt.Rows.Add(_drdata);

        }

        public virtual void AddPrePNO(ObjectPN pno)
        {
        }

        public virtual void AddPostPNO(ObjectPN pno)
        {
        }

        public virtual void AddPreArc(ObjectArc a)
        {
        }

        public virtual void AddPostArc(ObjectArc a)
        {
        }
    }
}
