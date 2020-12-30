using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Building
{
    public class PIXIE_69e8fa87_4672_4c05_9757_50a54d73ee57 : Pixie
    {
        public PIXIE_69e8fa87_4672_4c05_9757_50a54d73ee57()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#808040"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 971f; _h = 824f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#808040'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(27,824);ctx.lineTo(27,528);ctx.lineTo(248,323);ctx.lineTo(248,528);ctx.lineTo(465,325);ctx.lineTo(465,528);ctx.lineTo(683,323);ctx.lineTo(683,528);ctx.lineTo(740,528);ctx.lineTo(740,27);ctx.lineTo(829,27);ctx.lineTo(829,528);ctx.lineTo(882,528);ctx.lineTo(882,27);ctx.lineTo(971,27);ctx.lineTo(971,824);ctx.lineTo(27,824);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(27,824));listpt.Add(new Point(27,528));listpt.Add(new Point(248,323));listpt.Add(new Point(248,528));listpt.Add(new Point(465,325));listpt.Add(new Point(465,528));listpt.Add(new Point(683,323));listpt.Add(new Point(683,528));listpt.Add(new Point(740,528));listpt.Add(new Point(740,27));listpt.Add(new Point(829,27));listpt.Add(new Point(829,528));listpt.Add(new Point(882,528));listpt.Add(new Point(882,27));listpt.Add(new Point(971,27));listpt.Add(new Point(971,824));listpt.Add(new Point(27,824));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}