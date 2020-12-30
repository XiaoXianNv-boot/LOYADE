using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LOYADE.VEHICLE
{
    public class PBerth : PortObject
    {
        public PBerth()
        {
            _w = 150;
            _h = 150;
            _isoccupy = false;
            _listberthbridge = new List<PBerthBridge>();
        }

        public override void Paint(Graphics g)
        {
            SolidBrush sbstring = new SolidBrush(Color.Black);
            Font f = new Font("Arial", 9);
            g.DrawString(_label, f, sbstring, new PointF(_xnow + 3, _ynow + 3));
            base.Paint(g);
            foreach(PBerthBridge pbb in _listberthbridge)
            {
                pbb.Paint(g);
            }
        }

        private bool _isoccupy;

        [
            DisplayName("是否被占用"),
            Category("只读"),
            ReadOnly(true)
        ]
        public bool IsOccupy
        {
            get { return _isoccupy; }
            set { _isoccupy = value; }
        }

        private PShip _currentship;

        [
            DisplayName("当前停靠船舶"),
            Category("只读"),
            ReadOnly(true)
        ]
        public PShip CurrentShip
        {
            get { return _currentship; }
            set { _currentship = value; }
        }

        private List<PBerthBridge> _listberthbridge;

        [
            DisplayName("岸桥列表"),
            Category("调度参数")
        ]
        public List<PBerthBridge> ListBerthBridge
        {
            get { return _listberthbridge; }
            set { _listberthbridge = value; }
        }
    }
}
