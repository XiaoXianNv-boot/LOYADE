using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ComputerHardware
{
    public class PIXIE_ae52e75e_95c9_4d81_87d0_15361a68acca : Pixie
    {
        public PIXIE_ae52e75e_95c9_4d81_87d0_15361a68acca()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 814f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#7f7f7f'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,814);ctx.lineTo(28,578);ctx.lineTo(343,578);ctx.lineTo(361,539);ctx.lineTo(205,539);ctx.lineTo(205,28);ctx.lineTo(793,28);ctx.lineTo(793,539);ctx.lineTo(637,539);ctx.lineTo(655,578);ctx.lineTo(970,578);ctx.lineTo(970,814);ctx.lineTo(28,814);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,814));listpt.Add(new Point(28,578));listpt.Add(new Point(343,578));listpt.Add(new Point(361,539));listpt.Add(new Point(205,539));listpt.Add(new Point(205,28));listpt.Add(new Point(793,28));listpt.Add(new Point(793,539));listpt.Add(new Point(637,539));listpt.Add(new Point(655,578));listpt.Add(new Point(970,578));listpt.Add(new Point(970,814));listpt.Add(new Point(28,814));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}