using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_3941c9cd_a1d9_41b6_9f48_4133f92d39e7 : Pixie
    {
        public PIXIE_3941c9cd_a1d9_41b6_9f48_4133f92d39e7()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 368f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(744,28);ctx.lineTo(970,198);ctx.lineTo(744,368);ctx.lineTo(744,262);ctx.lineTo(360,262);ctx.lineTo(304,368);ctx.lineTo(238,368);ctx.lineTo(293,262);ctx.lineTo(254,262);ctx.lineTo(199,368);ctx.lineTo(136,368);ctx.lineTo(192,262);ctx.lineTo(142,262);ctx.lineTo(88,368);ctx.lineTo(28,368);ctx.lineTo(81,262);ctx.lineTo(81,136);ctx.lineTo(28,28);ctx.lineTo(88,28);ctx.lineTo(142,136);ctx.lineTo(192,136);ctx.lineTo(136,28);ctx.lineTo(199,28);ctx.lineTo(254,136);ctx.lineTo(293,136);ctx.lineTo(238,28);ctx.lineTo(304,28);ctx.lineTo(360,136);ctx.lineTo(744,136);ctx.lineTo(744,28);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(744,28));listpt.Add(new Point(970,198));listpt.Add(new Point(744,368));listpt.Add(new Point(744,262));listpt.Add(new Point(360,262));listpt.Add(new Point(304,368));listpt.Add(new Point(238,368));listpt.Add(new Point(293,262));listpt.Add(new Point(254,262));listpt.Add(new Point(199,368));listpt.Add(new Point(136,368));listpt.Add(new Point(192,262));listpt.Add(new Point(142,262));listpt.Add(new Point(88,368));listpt.Add(new Point(28,368));listpt.Add(new Point(81,262));listpt.Add(new Point(81,136));listpt.Add(new Point(28,28));listpt.Add(new Point(88,28));listpt.Add(new Point(142,136));listpt.Add(new Point(192,136));listpt.Add(new Point(136,28));listpt.Add(new Point(199,28));listpt.Add(new Point(254,136));listpt.Add(new Point(293,136));listpt.Add(new Point(238,28));listpt.Add(new Point(304,28));listpt.Add(new Point(360,136));listpt.Add(new Point(744,136));listpt.Add(new Point(744,28));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}