using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Valve
{
    public class PIXIE_71ec9cb7_5537_476d_b25b_5536c8667395 : Pixie
    {
        public PIXIE_71ec9cb7_5537_476d_b25b_5536c8667395()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 441f; _h = 97f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#b2b2b2'; arrFillColor[1] = '#e5e5e5'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(381,48);ctx.lineTo(441,48);ctx.lineTo(441,97);ctx.lineTo(381,97);ctx.lineTo(381,48);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(396,73);ctx.lineTo(396,48);ctx.lineTo(386,48);ctx.lineTo(386,45);ctx.lineTo(435,45);ctx.lineTo(435,48);ctx.lineTo(426,48);ctx.lineTo(426,73);ctx.lineTo(396,73);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(381,48));listpt.Add(new Point(441,48));listpt.Add(new Point(441,97));listpt.Add(new Point(381,97));listpt.Add(new Point(381,48));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(396,73));listpt.Add(new Point(396,48));listpt.Add(new Point(386,48));listpt.Add(new Point(386,45));listpt.Add(new Point(435,45));listpt.Add(new Point(435,48));listpt.Add(new Point(426,48));listpt.Add(new Point(426,73));listpt.Add(new Point(396,73));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}