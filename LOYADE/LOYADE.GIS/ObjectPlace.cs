using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace LOYADE.GIS
{
    public class ObjectPlace : ObjectGeo
    {
        public ObjectPlace()
        {

        }

        private Image _image;

        public Image SymbolImage
        {
            get { return _image; }
            set { _image = value; }
        }

        public override void Paint(Graphics g)
        {
            if (base.ListPointFs.Count == 1)
            {
                if (_image == null)
                {
                    g.DrawString(base.Label, new Font("宋体", 9), new SolidBrush(Color.Black), base.ListPointFs[0]);
                }
                else
                {
                    g.DrawImage(_image, base.ListPointFs[0]);
                }
            }
        }

        public override bool IsContaining(float x, float y)
        {
            if (Math.Abs(x - base.ListPointFs[0].X) < 5 && Math.Abs(y - base.ListPointFs[0].Y) < 5)
                return true;
            else
                return false;
        }
    }
}