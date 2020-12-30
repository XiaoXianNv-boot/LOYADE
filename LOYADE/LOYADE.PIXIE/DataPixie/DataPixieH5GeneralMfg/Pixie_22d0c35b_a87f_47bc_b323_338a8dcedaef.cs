using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_22d0c35b_a87f_47bc_b323_338a8dcedaef : Pixie
    {
        public PIXIE_22d0c35b_a87f_47bc_b323_338a8dcedaef()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 181f; _h = 257f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(7,257);ctx.lineTo(7,190);ctx.lineTo(60,190);ctx.lineTo(60,74);ctx.lineTo(7,74);ctx.lineTo(7,7);ctx.lineTo(181,7);ctx.lineTo(181,74);ctx.lineTo(127,74);ctx.lineTo(127,190);ctx.lineTo(181,190);ctx.lineTo(181,257);ctx.lineTo(7,257);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(7,257));listpt.Add(new Point(7,190));listpt.Add(new Point(60,190));listpt.Add(new Point(60,74));listpt.Add(new Point(7,74));listpt.Add(new Point(7,7));listpt.Add(new Point(181,7));listpt.Add(new Point(181,74));listpt.Add(new Point(127,74));listpt.Add(new Point(127,190));listpt.Add(new Point(181,190));listpt.Add(new Point(181,257));listpt.Add(new Point(7,257));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}