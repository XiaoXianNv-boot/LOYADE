using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Chemical
{
    public class PIXIE_c86241bd_9bfb_4216_97ea_891ad5c43b47 : Pixie
    {
        public PIXIE_c86241bd_9bfb_4216_97ea_891ad5c43b47()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 205f; _h = 970f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#4c4c4c'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(205,950);ctx.lineTo(204,952);ctx.lineTo(182,965);ctx.lineTo(149,969);ctx.lineTo(142,970);ctx.lineTo(134,970);ctx.lineTo(126,970);ctx.lineTo(96,969);ctx.lineTo(65,963);ctx.lineTo(48,952);ctx.lineTo(48,950);ctx.lineTo(48,67);ctx.lineTo(61,45);ctx.lineTo(89,33);ctx.lineTo(118,28);ctx.lineTo(126,28);ctx.lineTo(134,28);ctx.lineTo(163,33);ctx.lineTo(187,43);ctx.lineTo(204,63);ctx.lineTo(205,67);ctx.lineTo(205,950);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(205,950));listpt.Add(new Point(204,952));listpt.Add(new Point(182,965));listpt.Add(new Point(149,969));listpt.Add(new Point(142,970));listpt.Add(new Point(134,970));listpt.Add(new Point(126,970));listpt.Add(new Point(96,969));listpt.Add(new Point(65,963));listpt.Add(new Point(48,952));listpt.Add(new Point(48,950));listpt.Add(new Point(48,67));listpt.Add(new Point(61,45));listpt.Add(new Point(89,33));listpt.Add(new Point(118,28));listpt.Add(new Point(126,28));listpt.Add(new Point(134,28));listpt.Add(new Point(163,33));listpt.Add(new Point(187,43));listpt.Add(new Point(204,63));listpt.Add(new Point(205,67));listpt.Add(new Point(205,950));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}