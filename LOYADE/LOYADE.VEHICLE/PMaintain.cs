using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LOYADE.VEHICLE
{
    public class PMaintain : PortObject
    {
        public PMaintain()
        {
            _w = 100;
            _h = 70;
        }

        public override void Paint(Graphics g)
        {
            SolidBrush sbstring = new SolidBrush(Color.Black);
            Font f = new Font("Arial", 9);
            g.DrawString(_label, f, sbstring, new PointF(_xnow + 3, _ynow + 3));
            base.Paint(g);
        }
    }
}
