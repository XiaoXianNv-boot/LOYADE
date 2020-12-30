using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace LOYADE.GIS
{
    public class ObjectPline : ObjectGeo
    {
        public ObjectPline()
        {

        }

        protected decimal _totallength;

        [
            DisplayName("长度"),
            CategoryAttribute("地理信息"),
            DescriptionAttribute("该路线的地理长度。"),
            ReadOnlyAttribute(false)
        ]
        public decimal TotalLength
        {
            get { return _totallength; }
            set { _totallength = value; }
        }

        public override void Paint(Graphics g)
        {
            if (base.ListPointFs.Count > 1)
            {
                Pen p;
                if (base.IsSelected)
                    p = new Pen(Color.Blue);
                else
                    p = new Pen(Color.Black);
                p.Width = 1;
                g.DrawLines(p, base.ListPointFs.ToArray());
                p.Dispose();
            }

        }

        public override bool IsContaining(float x, float y)
        {
            double a, b, c;
            for (int i = 0; i < base.ListPointFs.Count - 1; ++i)
            {
                a = Math.Sqrt((x - base.ListPointFs[i].X) * (x - base.ListPointFs[i].X) + (y - base.ListPointFs[i].Y) * (y - base.ListPointFs[i].Y));
                b = Math.Sqrt((x - base.ListPointFs[i + 1].X) * (x - base.ListPointFs[i + 1].X) + (y - base.ListPointFs[i + 1].Y) * (y - base.ListPointFs[i + 1].Y));
                c = Math.Sqrt((base.ListPointFs[i + 1].X - base.ListPointFs[i].X) * (base.ListPointFs[i + 1].X - base.ListPointFs[i].X) + (base.ListPointFs[i + 1].Y - base.ListPointFs[i].Y) * (base.ListPointFs[i + 1].Y - base.ListPointFs[i].Y));
                if (a + b - c < 2)
                    return true;
            }
            return false;
        }
    }
}
