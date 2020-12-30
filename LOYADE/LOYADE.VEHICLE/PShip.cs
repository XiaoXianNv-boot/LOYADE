using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LOYADE.VEHICLE
{
    public class PShip : PortObject, IComparable<PShip>
    {
        public PShip()
        {
            _w = 65;
            _h = 150;
            _bordercolor = Color.Green;
            _fillcolor = Color.WhiteSmoke;
            _levelcount = 4;
            _rowcount = 5;
            _columncount = 2;
            _listcontainer = new List<PContainer>();
        }

        public int CompareTo(PShip other)
        {
            if (other == null)
                return 1;
            int value = other.Priority - this.Priority;
            return value;
        }

        public override void Paint(Graphics g)
        {
            SolidBrush sbstring = new SolidBrush(Color.Black);
            Font f = new Font("Arial", 6);
            g.DrawString(_label, f, sbstring, new PointF(_xnow + 3, _ynow + 3));
            base.Paint(g);
            foreach (PContainer pc in _listcontainer)
                pc.Paint(g);
        }

        public override void MoveTo(float x, float y)
        {
            float deltax = _xnow - x;
            float deltay = _ynow - y;
            _xnow = x;
            _ynow = y;
            foreach (PContainer pc in _listcontainer)
            {
                pc.XNow -= deltax;
                pc.YNow -= deltay;
            }
        }

        public override void Move(float deltax, float deltay)
        {
            _xnow += deltax;
            _ynow += deltay;
            foreach (PContainer pc in _listcontainer)
            {
                pc.XNow += deltax;
                pc.YNow += deltay;
            }
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

        private List<PContainer> _listcontainer;

        [
            DisplayName("集装箱列表"),
            Category("调度参数")
        ]
        public List<PContainer> ListContainer
        {
            get { return _listcontainer; }
            set { _listcontainer = value; }
        }

        private int _levelcount;

        [
            DisplayName("集装箱最高层数"),
            Category("调度参数")
        ]
        public int LevelCount
        {
            get { return _levelcount; }
            set
            {
                if (value > 0)
                    _levelcount = value;
                else
                    _levelcount = 1;
            }
        }

        private int _rowcount;

        [
            DisplayName("集装箱摆放行数"),
            Category("调度参数")
        ]
        public int RowCount
        {
            get { return _rowcount; }
            set
            {
                if (value > 5)
                    _rowcount = value;
                else
                    _rowcount = 5;
            }
        }

        private int _columncount;

        [
            DisplayName("集装箱摆放列数"),
            Category("调度参数")
        ]
        public int ColumnCount
        {
            get { return _columncount; }
            set
            {
                if (value > 2)
                    _columncount = value;
                else
                    _columncount = 2;
            }
        }

        private int _berthindex;

        [
            DisplayName("船舶停靠的泊位索引号"),
            Category("调度参数")
        ]
        public int BerthIndex
        {
            get { return _berthindex; }
            set
            {
                if (value > 0)
                    _berthindex = value;
                else
                    _berthindex = 0;
            }
        }
    }
}
