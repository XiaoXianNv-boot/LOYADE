using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace LOYADE.GIS
{
    public class ObjectRegion :  ObjectGeo
    {
        public ObjectRegion()
        {
        }

        protected decimal _totalarea;

        [
            DisplayName("面积"),
            CategoryAttribute("地理信息"),
            DescriptionAttribute("该区域的地理面积。"),
            ReadOnlyAttribute(false)
        ]
        public decimal TotalArea
        {
            get { return _totalarea; }
            set { _totalarea = value; }
        }

        public override void Paint(Graphics g)
        {
            if (base.ListPointFs.Count > 1)
            {
                Pen p;
                PointF[] pts = base.ListPointFs.ToArray();
                if (base.IsSelected)
                {
                    g.FillPolygon(new SolidBrush(Color.Yellow), pts);
                    p = new Pen(Color.Blue);
                }
                else
                {
                    g.FillPolygon(new SolidBrush(Color.White), pts);
                    p = new Pen(Color.Black);
                }
                p.Width = 1;
                g.DrawLines(p, pts);
                p.Dispose();
            }
        }

        public override bool IsContaining(float x, float y)
        {
            if (base.ListPointFs.Count > 1)
            {
                GraphicsPath myGraphicsPath = new GraphicsPath();
                Region myRegion = new Region();
                myGraphicsPath.Reset();
                //多边形点                     
                myGraphicsPath.AddPolygon(base.ListPointFs.ToArray());
                myRegion.MakeEmpty();
                myRegion.Union(myGraphicsPath);
                //返回判断点是否在多边形里
                return myRegion.IsVisible(x, y);
            }
            return false;
        }
    }
}
