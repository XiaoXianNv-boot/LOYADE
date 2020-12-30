using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Valve
{
    public class PIXIE_5372195c_6b93_4876_98f2_fc0dd79cc396 : Pixie
    {
        public PIXIE_5372195c_6b93_4876_98f2_fc0dd79cc396()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#7f99cc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 441f; _h = 224f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#7f99cc'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,48);ctx.lineTo(28,224);ctx.lineTo(431,224);ctx.lineTo(441,214);ctx.lineTo(441,58);ctx.lineTo(431,48);ctx.lineTo(28,48);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,48));listpt.Add(new Point(28,224));listpt.Add(new Point(431,224));listpt.Add(new Point(441,214));listpt.Add(new Point(441,58));listpt.Add(new Point(431,48));listpt.Add(new Point(28,48));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}