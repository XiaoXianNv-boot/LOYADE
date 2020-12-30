using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LOYADE.VEHICLE
{
    public class PYard : PortObject
    {
        public PYard()
        {
            _w = 300;
            _h = 100;
            _isemergency = false;
            _fillcolor = Color.LightGray;
            _listcontainer = new List<PContainer>();
            _listyardbridge = new List<PYardBridge>();
            _capacity = 200;
        }

        public override void Paint(Graphics g)
        {
            if (_isemergency)
                _fillcolor = Color.OldLace;
            SolidBrush sb = new SolidBrush(_fillcolor);
            g.FillRectangle(sb, _xnow, _ynow, _w, _h);
            SolidBrush sbstring = new SolidBrush(Color.Black);
            Font f = new Font("Arial", 6);
            g.DrawString(_label, f, sbstring, new PointF(_xnow + 3, _ynow + 3));
            base.Paint(g);
            foreach (PYardBridge pyb in _listyardbridge)
            {
                pyb.Paint(g);
            }
        }

        private List<PContainer> _listcontainer;

        [
            DisplayName("集装箱列表"),
            Category("调度参数"),
        ]
        public List<PContainer> ListContainer
        {
            get { return _listcontainer; }
            set { _listcontainer = value; }
        }


        private List<PYardBridge> _listyardbridge;

        [
            DisplayName("场桥列表"),
            Category("调度参数")
        ]
        public List<PYardBridge> ListYardBridge
        {
            get { return _listyardbridge; }
            set { _listyardbridge = value; }
        }

        private bool _isemergency;

        [
            DisplayName("是否为紧急存放区"),
            Category("调度参数")
        ]
        public bool IsEmergency
        {
            get { return _isemergency; }
            set { _isemergency = value; }
        }

        private int _capacity;

        [
            DisplayName("容量上限"),
            Category("调度参数")
        ]
        public int Capacity
        {
            get { return _capacity; }
            set
            {
                if (value > 100)
                    _capacity = value;
                else
                    _capacity = 200;
            }
        }
    }
}
