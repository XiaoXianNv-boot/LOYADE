using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Electrical
{
    public class PIXIE_f202999a_0cbf_42d4_9464_1717a5a8df38 : Pixie
    {
        public PIXIE_f202999a_0cbf_42d4_9464_1717a5a8df38()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 656f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(342,28);ctx.lineTo(371,28);ctx.lineTo(399,29);ctx.lineTo(452,32);ctx.lineTo(503,37);ctx.lineTo(550,44);ctx.lineTo(595,53);ctx.lineTo(637,65);ctx.lineTo(677,80);ctx.lineTo(715,97);ctx.lineTo(751,116);ctx.lineTo(785,139);ctx.lineTo(818,165);ctx.lineTo(850,194);ctx.lineTo(881,226);ctx.lineTo(911,261);ctx.lineTo(941,299);ctx.lineTo(955,320);ctx.lineTo(970,342);ctx.lineTo(955,364);ctx.lineTo(926,404);ctx.lineTo(896,441);ctx.lineTo(865,475);ctx.lineTo(834,505);ctx.lineTo(802,532);ctx.lineTo(768,556);ctx.lineTo(733,578);ctx.lineTo(696,596);ctx.lineTo(657,612);ctx.lineTo(616,625);ctx.lineTo(573,636);ctx.lineTo(527,644);ctx.lineTo(478,650);ctx.lineTo(426,654);ctx.lineTo(371,656);ctx.lineTo(342,656);ctx.lineTo(28,656);ctx.lineTo(55,625);ctx.lineTo(79,590);ctx.lineTo(100,553);ctx.lineTo(116,514);ctx.lineTo(129,472);ctx.lineTo(138,430);ctx.lineTo(144,386);ctx.lineTo(146,342);ctx.lineTo(144,298);ctx.lineTo(138,254);ctx.lineTo(129,211);ctx.lineTo(116,170);ctx.lineTo(100,131);ctx.lineTo(80,93);ctx.lineTo(56,59);ctx.lineTo(42,43);ctx.lineTo(28,28);ctx.lineTo(342,28);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(342,28));listpt.Add(new Point(371,28));listpt.Add(new Point(399,29));listpt.Add(new Point(452,32));listpt.Add(new Point(503,37));listpt.Add(new Point(550,44));listpt.Add(new Point(595,53));listpt.Add(new Point(637,65));listpt.Add(new Point(677,80));listpt.Add(new Point(715,97));listpt.Add(new Point(751,116));listpt.Add(new Point(785,139));listpt.Add(new Point(818,165));listpt.Add(new Point(850,194));listpt.Add(new Point(881,226));listpt.Add(new Point(911,261));listpt.Add(new Point(941,299));listpt.Add(new Point(955,320));listpt.Add(new Point(970,342));listpt.Add(new Point(955,364));listpt.Add(new Point(926,404));listpt.Add(new Point(896,441));listpt.Add(new Point(865,475));listpt.Add(new Point(834,505));listpt.Add(new Point(802,532));listpt.Add(new Point(768,556));listpt.Add(new Point(733,578));listpt.Add(new Point(696,596));listpt.Add(new Point(657,612));listpt.Add(new Point(616,625));listpt.Add(new Point(573,636));listpt.Add(new Point(527,644));listpt.Add(new Point(478,650));listpt.Add(new Point(426,654));listpt.Add(new Point(371,656));listpt.Add(new Point(342,656));listpt.Add(new Point(28,656));listpt.Add(new Point(55,625));listpt.Add(new Point(79,590));listpt.Add(new Point(100,553));listpt.Add(new Point(116,514));listpt.Add(new Point(129,472));listpt.Add(new Point(138,430));listpt.Add(new Point(144,386));listpt.Add(new Point(146,342));listpt.Add(new Point(144,298));listpt.Add(new Point(138,254));listpt.Add(new Point(129,211));listpt.Add(new Point(116,170));listpt.Add(new Point(100,131));listpt.Add(new Point(80,93));listpt.Add(new Point(56,59));listpt.Add(new Point(42,43));listpt.Add(new Point(28,28));listpt.Add(new Point(342,28));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}