using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEDuct
{
    public class PIXIE_288d2f08_7afa_4c1e_9ee0_ad1804065509 : Pixie
    {
        public PIXIE_288d2f08_7afa_4c1e_9ee0_ad1804065509()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 558f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(970,28);ctx.lineTo(970,322);ctx.lineTo(676,322);ctx.lineTo(676,558);ctx.lineTo(381,558);ctx.lineTo(381,381);ctx.lineTo(322,322);ctx.lineTo(28,322);ctx.lineTo(28,28);ctx.lineTo(970,28);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(970,28));listpt.Add(new Point(970,322));listpt.Add(new Point(676,322));listpt.Add(new Point(676,558));listpt.Add(new Point(381,558));listpt.Add(new Point(381,381));listpt.Add(new Point(322,322));listpt.Add(new Point(28,322));listpt.Add(new Point(28,28));listpt.Add(new Point(970,28));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}