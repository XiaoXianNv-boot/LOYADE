using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Architectural
{
    public class PIXIE_d7b6e7fa_fe51_432d_a955_34cf31a61b25 : Pixie
    {
        public PIXIE_d7b6e7fa_fe51_432d_a955_34cf31a61b25()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#7f0000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f0000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 617f; _h = 597f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#7f0000'; arrFillColor[1] = '#7f0000'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(480,597);ctx.lineTo(465,569);ctx.lineTo(460,499);ctx.lineTo(465,429);ctx.lineTo(480,401);ctx.lineTo(558,401);ctx.lineTo(558,440);ctx.lineTo(617,440);ctx.lineTo(617,558);ctx.lineTo(558,558);ctx.lineTo(558,597);ctx.lineTo(480,597);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(165,597);ctx.lineTo(179,569);ctx.lineTo(185,499);ctx.lineTo(179,429);ctx.lineTo(165,401);ctx.lineTo(87,401);ctx.lineTo(87,440);ctx.lineTo(28,440);ctx.lineTo(28,558);ctx.lineTo(87,558);ctx.lineTo(87,597);ctx.lineTo(165,597);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(480,597));listpt.Add(new Point(465,569));listpt.Add(new Point(460,499));listpt.Add(new Point(465,429));listpt.Add(new Point(480,401));listpt.Add(new Point(558,401));listpt.Add(new Point(558,440));listpt.Add(new Point(617,440));listpt.Add(new Point(617,558));listpt.Add(new Point(558,558));listpt.Add(new Point(558,597));listpt.Add(new Point(480,597));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(165,597));listpt.Add(new Point(179,569));listpt.Add(new Point(185,499));listpt.Add(new Point(179,429));listpt.Add(new Point(165,401));listpt.Add(new Point(87,401));listpt.Add(new Point(87,440));listpt.Add(new Point(28,440));listpt.Add(new Point(28,558));listpt.Add(new Point(87,558));listpt.Add(new Point(87,597));listpt.Add(new Point(165,597));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}