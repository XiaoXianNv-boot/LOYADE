using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Container
{
    public class PIXIE_2a67c121_e64b_436d_b26f_bfcd03fc0b7a : Pixie
    {
        public PIXIE_2a67c121_e64b_436d_b26f_bfcd03fc0b7a()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 476f; _h = 970f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#e5e5e5'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(320,118);ctx.lineTo(386,141);ctx.lineTo(431,163);ctx.lineTo(454,184);ctx.lineTo(476,252);ctx.lineTo(476,880);ctx.lineTo(454,948);ctx.lineTo(431,970);ctx.lineTo(73,970);ctx.lineTo(50,948);ctx.lineTo(28,880);ctx.lineTo(28,252);ctx.lineTo(50,184);ctx.lineTo(73,163);ctx.lineTo(118,141);ctx.lineTo(184,118);ctx.lineTo(184,96);ctx.lineTo(320,96);ctx.lineTo(320,118);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(320,118));listpt.Add(new Point(386,141));listpt.Add(new Point(431,163));listpt.Add(new Point(454,184));listpt.Add(new Point(476,252));listpt.Add(new Point(476,880));listpt.Add(new Point(454,948));listpt.Add(new Point(431,970));listpt.Add(new Point(73,970));listpt.Add(new Point(50,948));listpt.Add(new Point(28,880));listpt.Add(new Point(28,252));listpt.Add(new Point(50,184));listpt.Add(new Point(73,163));listpt.Add(new Point(118,141));listpt.Add(new Point(184,118));listpt.Add(new Point(184,96));listpt.Add(new Point(320,96));listpt.Add(new Point(320,118));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}