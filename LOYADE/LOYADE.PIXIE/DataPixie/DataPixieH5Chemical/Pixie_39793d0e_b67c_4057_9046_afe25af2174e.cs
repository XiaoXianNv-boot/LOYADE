using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Chemical
{
    public class PIXIE_39793d0e_b67c_4057_9046_afe25af2174e : Pixie
    {
        public PIXIE_39793d0e_b67c_4057_9046_afe25af2174e()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 559f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#7f7f7f'; arrFillColor[1] = '#b2b2b2'; arrFillColor[2] = '#999'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(320,491);ctx.lineTo(970,491);ctx.lineTo(970,559);ctx.lineTo(320,559);ctx.lineTo(320,491);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(388,491);ctx.lineTo(902,491);ctx.lineTo(902,216);ctx.lineTo(388,216);ctx.lineTo(388,491);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(148,303);ctx.lineTo(79,303);ctx.lineTo(79,79);ctx.lineTo(310,79);ctx.lineTo(310,286);ctx.lineTo(326,309);ctx.lineTo(356,304);ctx.lineTo(361,292);ctx.lineTo(361,286);ctx.lineTo(361,28);ctx.lineTo(28,28);ctx.lineTo(28,354);ctx.lineTo(148,354);ctx.lineTo(148,303);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(320,491));listpt.Add(new Point(970,491));listpt.Add(new Point(970,559));listpt.Add(new Point(320,559));listpt.Add(new Point(320,491));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(388,491));listpt.Add(new Point(902,491));listpt.Add(new Point(902,216));listpt.Add(new Point(388,216));listpt.Add(new Point(388,491));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(148,303));listpt.Add(new Point(79,303));listpt.Add(new Point(79,79));listpt.Add(new Point(310,79));listpt.Add(new Point(310,286));listpt.Add(new Point(326,309));listpt.Add(new Point(356,304));listpt.Add(new Point(361,292));listpt.Add(new Point(361,286));listpt.Add(new Point(361,28));listpt.Add(new Point(28,28));listpt.Add(new Point(28,354));listpt.Add(new Point(148,354));listpt.Add(new Point(148,303));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}