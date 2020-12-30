using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5AirCondition
{
    public class PIXIE_a31e6b1c_05a4_4b4c_b732_c42eafdc43f8 : Pixie
    {
        public PIXIE_a31e6b1c_05a4_4b4c_b732_c42eafdc43f8()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 257f; _h = 257f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(257,101);ctx.lineTo(257,7);ctx.lineTo(7,7);ctx.lineTo(7,226);ctx.lineTo(13,227);ctx.lineTo(19,228);ctx.lineTo(24,231);ctx.lineTo(29,235);ctx.lineTo(33,240);ctx.lineTo(36,245);ctx.lineTo(37,251);ctx.lineTo(38,257);ctx.lineTo(226,257);ctx.lineTo(226,132);ctx.lineTo(227,126);ctx.lineTo(228,120);ctx.lineTo(231,115);ctx.lineTo(235,110);ctx.lineTo(240,106);ctx.lineTo(245,103);ctx.lineTo(251,102);ctx.lineTo(257,101);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(257,101));listpt.Add(new Point(257,7));listpt.Add(new Point(7,7));listpt.Add(new Point(7,226));listpt.Add(new Point(13,227));listpt.Add(new Point(19,228));listpt.Add(new Point(24,231));listpt.Add(new Point(29,235));listpt.Add(new Point(33,240));listpt.Add(new Point(36,245));listpt.Add(new Point(37,251));listpt.Add(new Point(38,257));listpt.Add(new Point(226,257));listpt.Add(new Point(226,132));listpt.Add(new Point(227,126));listpt.Add(new Point(228,120));listpt.Add(new Point(231,115));listpt.Add(new Point(235,110));listpt.Add(new Point(240,106));listpt.Add(new Point(245,103));listpt.Add(new Point(251,102));listpt.Add(new Point(257,101));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}