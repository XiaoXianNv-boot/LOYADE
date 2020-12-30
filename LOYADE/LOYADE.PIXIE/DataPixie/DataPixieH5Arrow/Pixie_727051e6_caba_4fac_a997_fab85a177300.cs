using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_727051e6_caba_4fac_a997_fab85a177300 : Pixie
    {
        public PIXIE_727051e6_caba_4fac_a997_fab85a177300()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 407f; _h = 971f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(218,27);ctx.lineTo(407,395);ctx.lineTo(282,395);ctx.lineTo(282,971);ctx.lineTo(153,971);ctx.lineTo(153,395);ctx.lineTo(27,395);ctx.lineTo(218,27);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(218,27));listpt.Add(new Point(407,395));listpt.Add(new Point(282,395));listpt.Add(new Point(282,971));listpt.Add(new Point(153,971));listpt.Add(new Point(153,395));listpt.Add(new Point(27,395));listpt.Add(new Point(218,27));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}