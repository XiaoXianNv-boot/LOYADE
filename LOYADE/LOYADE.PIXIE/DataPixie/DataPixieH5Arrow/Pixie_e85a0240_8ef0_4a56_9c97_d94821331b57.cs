using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_e85a0240_8ef0_4a56_9c97_d94821331b57 : Pixie
    {
        public PIXIE_e85a0240_8ef0_4a56_9c97_d94821331b57()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 368f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(370,28);ctx.lineTo(370,146);ctx.lineTo(801,146);ctx.lineTo(801,28);ctx.lineTo(970,196);ctx.lineTo(801,368);ctx.lineTo(801,254);ctx.lineTo(370,254);ctx.lineTo(370,368);ctx.lineTo(28,368);ctx.lineTo(199,196);ctx.lineTo(28,28);ctx.lineTo(370,28);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(370,28));listpt.Add(new Point(370,146));listpt.Add(new Point(801,146));listpt.Add(new Point(801,28));listpt.Add(new Point(970,196));listpt.Add(new Point(801,368));listpt.Add(new Point(801,254));listpt.Add(new Point(370,254));listpt.Add(new Point(370,368));listpt.Add(new Point(28,368));listpt.Add(new Point(199,196));listpt.Add(new Point(28,28));listpt.Add(new Point(370,28));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}