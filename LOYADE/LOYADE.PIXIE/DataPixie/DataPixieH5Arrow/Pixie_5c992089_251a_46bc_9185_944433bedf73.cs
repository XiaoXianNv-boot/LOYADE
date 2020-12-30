using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_5c992089_251a_46bc_9185_944433bedf73 : Pixie
    {
        public PIXIE_5c992089_251a_46bc_9185_944433bedf73()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 788f; _h = 549f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(404,22);ctx.lineTo(769,470);ctx.lineTo(780,486);ctx.lineTo(787,499);ctx.lineTo(788,503);ctx.lineTo(788,507);ctx.lineTo(783,527);ctx.lineTo(768,542);ctx.lineTo(753,548);ctx.lineTo(749,549);ctx.lineTo(745,549);ctx.lineTo(724,542);ctx.lineTo(708,530);ctx.lineTo(703,524);ctx.lineTo(404,156);ctx.lineTo(105,524);ctx.lineTo(89,539);ctx.lineTo(69,549);ctx.lineTo(48,546);ctx.lineTo(32,535);ctx.lineTo(27,528);ctx.lineTo(23,515);ctx.lineTo(22,510);ctx.lineTo(22,506);ctx.lineTo(29,486);ctx.lineTo(40,470);ctx.lineTo(404,22);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(404,22));listpt.Add(new Point(769,470));listpt.Add(new Point(780,486));listpt.Add(new Point(787,499));listpt.Add(new Point(788,503));listpt.Add(new Point(788,507));listpt.Add(new Point(783,527));listpt.Add(new Point(768,542));listpt.Add(new Point(753,548));listpt.Add(new Point(749,549));listpt.Add(new Point(745,549));listpt.Add(new Point(724,542));listpt.Add(new Point(708,530));listpt.Add(new Point(703,524));listpt.Add(new Point(404,156));listpt.Add(new Point(105,524));listpt.Add(new Point(89,539));listpt.Add(new Point(69,549));listpt.Add(new Point(48,546));listpt.Add(new Point(32,535));listpt.Add(new Point(27,528));listpt.Add(new Point(23,515));listpt.Add(new Point(22,510));listpt.Add(new Point(22,506));listpt.Add(new Point(29,486));listpt.Add(new Point(40,470));listpt.Add(new Point(404,22));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}