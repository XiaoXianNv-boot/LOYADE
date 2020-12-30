using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_200471fc_e621_4ecf_a792_83171f25cc23 : Pixie
    {
        public PIXIE_200471fc_e621_4ecf_a792_83171f25cc23()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 257f; _h = 257f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(7,7);ctx.lineTo(49,210);ctx.lineTo(90,7);ctx.lineTo(132,210);ctx.lineTo(174,7);ctx.lineTo(215,210);ctx.lineTo(257,7);ctx.lineTo(257,54);ctx.lineTo(215,257);ctx.lineTo(174,54);ctx.lineTo(132,257);ctx.lineTo(90,54);ctx.lineTo(49,257);ctx.lineTo(7,54);ctx.lineTo(7,7);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(7,7));listpt.Add(new Point(49,210));listpt.Add(new Point(90,7));listpt.Add(new Point(132,210));listpt.Add(new Point(174,7));listpt.Add(new Point(215,210));listpt.Add(new Point(257,7));listpt.Add(new Point(257,54));listpt.Add(new Point(215,257));listpt.Add(new Point(174,54));listpt.Add(new Point(132,257));listpt.Add(new Point(90,54));listpt.Add(new Point(49,257));listpt.Add(new Point(7,54));listpt.Add(new Point(7,7));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}