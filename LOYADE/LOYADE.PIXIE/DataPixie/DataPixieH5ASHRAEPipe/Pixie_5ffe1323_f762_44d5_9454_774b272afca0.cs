using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEPipe
{
    public class PIXIE_5ffe1323_f762_44d5_9454_774b272afca0 : Pixie
    {
        public PIXIE_5ffe1323_f762_44d5_9454_774b272afca0()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 899f; _h = 382f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(169,99);ctx.lineTo(559,99);ctx.lineTo(843,382);ctx.lineTo(896,329);ctx.lineTo(668,99);ctx.lineTo(899,99);ctx.lineTo(899,28);ctx.lineTo(169,28);ctx.lineTo(169,99);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(169,99));listpt.Add(new Point(559,99));listpt.Add(new Point(843,382));listpt.Add(new Point(896,329));listpt.Add(new Point(668,99));listpt.Add(new Point(899,99));listpt.Add(new Point(899,28));listpt.Add(new Point(169,28));listpt.Add(new Point(169,99));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}