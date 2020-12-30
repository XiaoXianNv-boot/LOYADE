using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Building
{
    public class PIXIE_548a4d3f_c33e_4f1f_9717_890f16b1b8d5 : Pixie
    {
        public PIXIE_548a4d3f_c33e_4f1f_9717_890f16b1b8d5()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f0f0f0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 515f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#4c4c4c'; arrFillColor[1] = '#ccc'; arrFillColor[2] = '#7f7f7f'; arrFillColor[3] = '#f0f0f0'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(392,514);ctx.lineTo(28,418);ctx.lineTo(606,241);ctx.lineTo(970,337);ctx.lineTo(392,514);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,417);ctx.lineTo(102,439);ctx.lineTo(102,257);ctx.lineTo(311,320);ctx.lineTo(311,407);ctx.lineTo(311,494);ctx.lineTo(392,515);ctx.lineTo(392,447);ctx.lineTo(392,379);ctx.lineTo(369,290);ctx.lineTo(314,233);ctx.lineTo(254,201);ctx.lineTo(216,187);ctx.lineTo(144,170);ctx.lineTo(85,172);ctx.lineTo(43,204);ctx.lineTo(28,269);ctx.lineTo(28,343);ctx.lineTo(28,417);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(102,396);ctx.lineTo(102,257);ctx.lineTo(311,320);ctx.lineTo(311,341);ctx.lineTo(102,396);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(392,515);ctx.lineTo(392,447);ctx.lineTo(392,379);ctx.lineTo(369,290);ctx.lineTo(314,233);ctx.lineTo(254,201);ctx.lineTo(216,187);ctx.lineTo(144,170);ctx.lineTo(98,172);ctx.lineTo(441,96);ctx.lineTo(739,30);ctx.lineTo(784,28);ctx.lineTo(837,45);ctx.lineTo(867,57);ctx.lineTo(913,87);ctx.lineTo(953,140);ctx.lineTo(970,216);ctx.lineTo(970,278);ctx.lineTo(970,337);ctx.lineTo(699,420);ctx.lineTo(392,515);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(392,514));listpt.Add(new Point(28,418));listpt.Add(new Point(606,241));listpt.Add(new Point(970,337));listpt.Add(new Point(392,514));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,417));listpt.Add(new Point(102,439));listpt.Add(new Point(102,257));listpt.Add(new Point(311,320));listpt.Add(new Point(311,407));listpt.Add(new Point(311,494));listpt.Add(new Point(392,515));listpt.Add(new Point(392,447));listpt.Add(new Point(392,379));listpt.Add(new Point(369,290));listpt.Add(new Point(314,233));listpt.Add(new Point(254,201));listpt.Add(new Point(216,187));listpt.Add(new Point(144,170));listpt.Add(new Point(85,172));listpt.Add(new Point(43,204));listpt.Add(new Point(28,269));listpt.Add(new Point(28,343));listpt.Add(new Point(28,417));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(102,396));listpt.Add(new Point(102,257));listpt.Add(new Point(311,320));listpt.Add(new Point(311,341));listpt.Add(new Point(102,396));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(392,515));listpt.Add(new Point(392,447));listpt.Add(new Point(392,379));listpt.Add(new Point(369,290));listpt.Add(new Point(314,233));listpt.Add(new Point(254,201));listpt.Add(new Point(216,187));listpt.Add(new Point(144,170));listpt.Add(new Point(98,172));listpt.Add(new Point(441,96));listpt.Add(new Point(739,30));listpt.Add(new Point(784,28));listpt.Add(new Point(837,45));listpt.Add(new Point(867,57));listpt.Add(new Point(913,87));listpt.Add(new Point(953,140));listpt.Add(new Point(970,216));listpt.Add(new Point(970,278));listpt.Add(new Point(970,337));listpt.Add(new Point(699,420));listpt.Add(new Point(392,515));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}