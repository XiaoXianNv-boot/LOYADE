using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LOYADE.VEHICLE
{
    public class PContainer : PortObject, IComparable<PContainer>
    {
        public PContainer(string pbl, int pbli, int l)
        {
            _shiplabel = pbl;
            _shipindex = pbli;
            _coverlevel = l;
            _borderwidth = 1;
            _fillcolor = Color.Yellow;
            _w = 10;
            _h = 20;
            _priority = 1;
            _yardlabel = "";
        }

        /// <summary>
        /// 自定义排序：第一级使用CoverLevel降序，覆盖层越小越早被吊走；第二级使用优先级，优先级越大越早被吊走
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(PContainer other)
        {
            if (other == null)
                return 1;
            int value = this.CoverLevel - other.CoverLevel;
            if (value == 0)
                value = other.Priority - this.Priority;
            return value;
        }

        public override void Paint(Graphics g)
        {
            SolidBrush sb = new SolidBrush(_fillcolor);
            g.FillRectangle(sb, _xnow, _ynow, _w, _h);
            if (_isemergency)
                g.FillRectangle(new SolidBrush(Color.Red), _xnow, _ynow, _w, _h);
            else
                g.FillRectangle(new SolidBrush(Color.Orange), _xnow, _ynow, _w, _h * _priority / 100);
            SolidBrush sbstring = new SolidBrush(Color.Black);
            Font f = new Font("Arial", 1);
            g.DrawString(_label, f, sbstring, new PointF(_xnow + 2, _ynow + 2));
            base.Paint(g);
        }


        private bool _isemergency;
        [
            DisplayName("是否紧急"),
            Category("调度参数")
        ]
        public bool IsEmergency
        {
            get { return _isemergency; }
            set { _isemergency = value; }
        }

        private int _priority;
        [
            DisplayName("优先级"),
            Category("调度参数"),
            Description("0-100，大于90则自动转为紧急")
        ]
        public int Priority
        {
            get { return _priority; }
            set
            {
                _priority = value;
                if (_priority > 90)
                    _isemergency = true;
                else
                    _isemergency = false;
            }
        }

        private float _berthbridgex;
        [
            DisplayName("岸桥范围坐标X"),
            Category("只读"),
            ReadOnly(true)
        ]
        public float BerthBridgeX
        {
            get { return _berthbridgex; }
            set { _berthbridgex = value; }
        }

        private float _berthbridgey;
        [
            DisplayName("岸桥范围坐标Y"),
            Category("只读"),
            ReadOnly(true)
        ]
        public float BerthBridgeY
        {
            get { return _berthbridgey; }
            set { _berthbridgey = value; }
        }

        private float _yardbridgex;
        [
            DisplayName("场桥范围坐标X"),
            Category("只读"),
            ReadOnly(true)
        ]
        public float YardBridgeX
        {
            get { return _yardbridgex; }
            set { _yardbridgex = value; }
        }

        private float _yardbridgey;
        [
            DisplayName("场桥范围坐标Y"),
            Category("只读"),
            ReadOnly(true)
        ]
        public float YardBridgeY
        {
            get { return _yardbridgey; }
            set { _yardbridgey = value; }
        }

        private int _column;
        [
            DisplayName("所在列"),
            Category("靠岸参数"),
            Description("影响岸桥工作状态")
        ]
        public int Column
        {
            get { return _column; }
            set { _column = value; }
        }

        private int _row;
        [
            DisplayName("所在行"),
            Category("靠岸参数"),
            Description("影响岸桥工作状态")
        ]
        public int Row
        {
            get { return _row; }
            set { _row = value; }
        }

        private int _coverlevel;
        [
            DisplayName("该集装箱上面覆盖的层数"),
            Category("靠岸参数"),
            Description("影响岸桥工作状态，若层数为0则表示该集装箱在表面可以被吊走，若层数为3表示该箱被另外三个箱压在底下")
        ]
        public int CoverLevel
        {
            get { return _coverlevel; }
            set { _coverlevel = value; }
        }

        private string _shiplabel;
        [
            DisplayName("所属船舶"),
            Category("只读"),
            ReadOnly(true)
        ]
        public string ShipLabel
        {
            get { return _shiplabel; }
            set { _shiplabel = value; }
        }

        private int _shipindex;
        [
            DisplayName("所属船舶索引号"),
            Category("只读"),
            ReadOnly(true)
        ]
        public int ShipIndex
        {
            get { return _shipindex; }
            set { _shipindex = value; }
        }

        private string _yardbridgelabel;
        [
            DisplayName("分配的卸载场桥"),
            Category("只读"),
            ReadOnly(true)
        ]
        public string YardBridgeLabel
        {
            get { return _yardbridgelabel; }
            set { _yardbridgelabel = value; }
        }

        private int _yardbridgeindex;
        [
            DisplayName("分配的卸载场桥索引号"),
            Category("只读"),
            ReadOnly(true)
        ]
        public int YardBridgeIndex
        {
            get { return _yardbridgeindex; }
            set { _yardbridgeindex = value; }
        }

        private string _berthbridgelabel;
        [
            DisplayName("分配的卸载岸桥"),
            Category("只读"),
            ReadOnly(true)
        ]
        public string BerthBridgeLabel
        {
            get { return _berthbridgelabel; }
            set { _berthbridgelabel = value; }
        }

        private int _berthbridgeindex;
        [
            DisplayName("分配的卸载岸桥索引号"),
            Category("只读"),
            ReadOnly(true)
        ]
        public int BerthBridgeIndex
        {
            get { return _berthbridgeindex; }
            set { _berthbridgeindex = value; }
        }

        private string _yardlabel;
        [
            DisplayName("所属堆场"),
            Category("只读"),
            ReadOnly(true)
        ]
        public string YardLabel
        {
            get { return _yardlabel; }
            set { _yardlabel = value; }
        }

        private int _yardindex;
        [
            DisplayName("所属堆场索引号"),
            Category("只读"),
            ReadOnly(true)
        ]
        public int YardIndex
        {
            get { return _yardindex; }
            set { _yardindex = value; }
        }

        private DateTime _unloadtoyarddt;
        [
            DisplayName("卸载到堆场的时间"),
            Category("只读"),
            ReadOnly(true)
        ]
        public DateTime UnloadToYardDateTime
        {
            get { return _unloadtoyarddt; }
            set { _unloadtoyarddt = value; }
        }

        private DateTime _loadtoagvdt;
        [
            DisplayName("装载到AGV的时间"),
            Category("只读"),
            ReadOnly(true)
        ]
        public DateTime LoadToAGVDateTime
        {
            get { return _loadtoagvdt; }
            set { _loadtoagvdt = value; }
        }

        private string _agvlabel;
        [
            DisplayName("所属AGV"),
            Category("只读"),
            ReadOnly(true)
        ]
        public string AGVLabel
        {
            get { return _agvlabel; }
            set { _agvlabel = value; }
        }

        private int _agvindex;
        [
            DisplayName("所属AGV索引号"),
            Category("只读"),
            ReadOnly(true)
        ]
        public int AGVIndex
        {
            get { return _agvindex; }
            set { _agvindex = value; }
        }
    }
}
