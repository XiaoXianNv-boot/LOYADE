using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LOYADE.VEHICLE
{
    public class PBerthBridge : PortObject
    {
        public PBerthBridge()
        {
            _w = 230;
            _h = 15;
            _bordercolor = Color.Blue;
            _fillcolor = Color.WhiteSmoke;
        }

        public override void Paint(Graphics g)
        {
            SolidBrush sb = new SolidBrush(_fillcolor);
            g.FillRectangle(sb, _xnow, _ynow, _w, _h);
            SolidBrush sbstring = new SolidBrush(Color.Black);
            Font f = new Font("Arial", 6);
            g.DrawString(_label, f, sbstring, new PointF(_xnow + 3, _ynow + 3));
            base.Paint(g);
        }

        private string _berthlabel;

        [
            DisplayName("所属泊位标签"),
            Category("只读"),
            ReadOnly(true)
        ]
        public string BerthLabel
        {
            get { return _berthlabel; }
            set { _berthlabel = value; }
        }

        private int _berthindex;
        [
            DisplayName("所属泊位索引号"),
            Category("只读"),
            ReadOnly(true)
        ]
        public int BerthIndex
        {
            get { return _berthindex; }
            set { _berthindex = value; }
        }
    }
}
