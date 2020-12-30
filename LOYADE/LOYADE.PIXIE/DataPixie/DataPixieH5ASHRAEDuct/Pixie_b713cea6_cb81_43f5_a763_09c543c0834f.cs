using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEDuct
{
    public class PIXIE_b713cea6_cb81_43f5_a763_09c543c0834f : Pixie
    {
        public PIXIE_b713cea6_cb81_43f5_a763_09c543c0834f()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 705f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(499,204);ctx.lineTo(535,206);ctx.lineTo(570,212);ctx.lineTo(604,221);ctx.lineTo(636,232);ctx.lineTo(667,247);ctx.lineTo(696,265);ctx.lineTo(724,285);ctx.lineTo(749,308);ctx.lineTo(772,333);ctx.lineTo(792,360);ctx.lineTo(810,390);ctx.lineTo(825,421);ctx.lineTo(836,453);ctx.lineTo(845,487);ctx.lineTo(851,522);ctx.lineTo(852,558);ctx.lineTo(852,705);ctx.lineTo(558,705);ctx.lineTo(558,558);ctx.lineTo(551,530);ctx.lineTo(532,509);ctx.lineTo(505,499);ctx.lineTo(499,499);ctx.lineTo(28,499);ctx.lineTo(28,28);ctx.lineTo(970,28);ctx.lineTo(970,204);ctx.lineTo(499,204);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(499,204));listpt.Add(new Point(535,206));listpt.Add(new Point(570,212));listpt.Add(new Point(604,221));listpt.Add(new Point(636,232));listpt.Add(new Point(667,247));listpt.Add(new Point(696,265));listpt.Add(new Point(724,285));listpt.Add(new Point(749,308));listpt.Add(new Point(772,333));listpt.Add(new Point(792,360));listpt.Add(new Point(810,390));listpt.Add(new Point(825,421));listpt.Add(new Point(836,453));listpt.Add(new Point(845,487));listpt.Add(new Point(851,522));listpt.Add(new Point(852,558));listpt.Add(new Point(852,705));listpt.Add(new Point(558,705));listpt.Add(new Point(558,558));listpt.Add(new Point(551,530));listpt.Add(new Point(532,509));listpt.Add(new Point(505,499));listpt.Add(new Point(499,499));listpt.Add(new Point(28,499));listpt.Add(new Point(28,28));listpt.Add(new Point(970,28));listpt.Add(new Point(970,204));listpt.Add(new Point(499,204));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}