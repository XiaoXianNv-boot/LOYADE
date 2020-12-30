using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.SPECIAL
{
    public class PIXIE_TEXT : Pixie
    {
        public PIXIE_TEXT()
        {
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();

            _x = 0f;
            _y = 0f;
            _z = 0f;

            _listfillcolor.Add(ColorTranslator.FromHtml("#000"));
            _listborderwidth.Add(2);
            _listbordercolor.Add(ColorTranslator.FromHtml("#000"));
            _w = 116f; _h = 257f;
            _content = "Text";
        }

        public override void Paint(Graphics g)
        {
            SolidBrush sb;
            Pen p;
            List<Point> listpt;

            listpt = new List<Point>();
            sb = new SolidBrush(_listfillcolor[0]);
            p = new Pen(_listbordercolor[0]);
            p.Width = _listborderwidth[0];
            g.DrawString(_label, new Font("Arial", 20), sb, _x, _y);
        }
    }
}