using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace LOYADE.GIS
{
    public abstract class ObjectGeo
    {
        public ObjectGeo()
        {
            _isselected = false;
            _listpfs = new List<PointF>();
        }

        protected string _sn;

        [
            DisplayName("系统编号"), 
            ReadOnlyAttribute(true)
        ]
        public string SN
        {
            get { return _sn; }
            set { _sn = value; }
        }

        protected string _fathersn;

        [
            DisplayName("父级对象系统编号"),
            ReadOnlyAttribute(true)
        ]
        public string FatherSN
        {
            get { return _fathersn; }
            set { _fathersn = value; }
        }

        protected string _typesn;

        [
            DisplayName("地理对象类型编号"),
            ReadOnlyAttribute(true)
        ]
        public string TypeSN
        {
            get { return _typesn; }
            set { _typesn = value; }
        }

        protected string _customsn;

        [
            DisplayName("编码"),
            CategoryAttribute("地理信息"),
            DescriptionAttribute("该地理对象的编码（区域、路线或地标编码）。"),
            ReadOnlyAttribute(false)
        ]
        public string CustomSN
        {
            get { return _customsn; }
            set { _customsn = value; }
        }

        protected string _typelabel;

        [
            DisplayName("地理对象类型名称"),            
            ReadOnlyAttribute(true)
        ]
        public string TypeLabel
        {
            get { return _typelabel; }
            set { _typelabel = value; }
        }

        protected string _label;

        [
            DisplayName("名称"),
            CategoryAttribute("地理信息"),
            DescriptionAttribute("该地理对象的名称（区域、路线或地标名称）。"),
            ReadOnlyAttribute(false)
        ]
        public string Label
        {
            get { return _label; }
            set { _label = value; }
        }

        protected int _typelevel;

        [
            DisplayName("地理对象类型层级"),
            ReadOnlyAttribute(true)
        ]
        public int TypeLevel
        {
            get { return _typelevel; }
            set { _typelevel = value; }
        }

        public void InitializeData(DataRow[] drs)
        {
            _listpfs.Clear();
            for (int i = 0; i < drs.Length; ++i)
            {
                _listpfs.Add(new PointF(ActionGeo.GetScreenX(Convert.ToSingle(drs[i]["geo_x"])),
                    ActionGeo.GetScreenY(Convert.ToSingle(drs[i]["geo_y"]))));
            }
        }

        protected bool _isselected;

        [
            DisplayName("是否被选定"),
            ReadOnlyAttribute(true)
        ]
        public bool IsSelected
        {
            get { return _isselected; }
            set { _isselected = value; }
        }

        protected List<PointF> _listpfs;

        [
            Browsable(false)
        ]
        public List<PointF> ListPointFs
        {
            get { return _listpfs; }
            set { _listpfs = value; }
        }

        public abstract void Paint(Graphics g);
        public abstract bool IsContaining(float x, float y);

    }
}
