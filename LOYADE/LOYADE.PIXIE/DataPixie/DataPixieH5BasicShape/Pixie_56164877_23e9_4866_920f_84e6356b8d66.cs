using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_56164877_23e9_4866_920f_84e6356b8d66 : Pixie
    {
        public PIXIE_56164877_23e9_4866_920f_84e6356b8d66()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 501f; _h = 314f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(51,14);ctx.lineTo(464,14);ctx.lineTo(478,45);ctx.lineTo(489,78);ctx.lineTo(497,112);ctx.lineTo(501,146);ctx.lineTo(501,181);ctx.lineTo(497,216);ctx.lineTo(489,249);ctx.lineTo(478,282);ctx.lineTo(464,314);ctx.lineTo(51,314);ctx.lineTo(37,282);ctx.lineTo(25,249);ctx.lineTo(18,216);ctx.lineTo(14,181);ctx.lineTo(14,146);ctx.lineTo(18,112);ctx.lineTo(25,78);ctx.lineTo(37,45);ctx.lineTo(51,14);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(51,14));listpt.Add(new Point(464,14));listpt.Add(new Point(478,45));listpt.Add(new Point(489,78));listpt.Add(new Point(497,112));listpt.Add(new Point(501,146));listpt.Add(new Point(501,181));listpt.Add(new Point(497,216));listpt.Add(new Point(489,249));listpt.Add(new Point(478,282));listpt.Add(new Point(464,314));listpt.Add(new Point(51,314));listpt.Add(new Point(37,282));listpt.Add(new Point(25,249));listpt.Add(new Point(18,216));listpt.Add(new Point(14,181));listpt.Add(new Point(14,146));listpt.Add(new Point(18,112));listpt.Add(new Point(25,78));listpt.Add(new Point(37,45));listpt.Add(new Point(51,14));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}