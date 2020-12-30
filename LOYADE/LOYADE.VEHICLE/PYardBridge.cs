using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LOYADE.VEHICLE
{
    public class PYardBridge : PortObject
    {
        public PYardBridge()
        {
            _w = 50;
            _h = 110;
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

        private string _yardlabel;

        [
            DisplayName("所属堆区标签"),
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
            DisplayName("所属堆区索引号"),
            Category("只读"),
            ReadOnly(true)
        ]
        public int YardIndex
        {
            get { return _yardindex; }
            set { _yardindex = value; }
        }
    }
}
