using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WaterWastewater
{
    public class PIXIE_31d1671b_f256_46aa_84a2_46abfe0a32bd : Pixie
    {
        public PIXIE_31d1671b_f256_46aa_84a2_46abfe0a32bd()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#661900"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 853f; _h = 630f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#7f7f7f'; arrFillColor[1] = '#7f7f7f'; arrFillColor[2] = '#7f7f7f'; arrFillColor[3] = '#7f7f7f'; arrFillColor[4] = '#661900'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(375,106);ctx.lineTo(377,102);ctx.lineTo(382,99);ctx.lineTo(388,98);ctx.lineTo(393,99);ctx.lineTo(398,102);ctx.lineTo(401,106);ctx.lineTo(375,106);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(335,106);ctx.lineTo(338,102);ctx.lineTo(343,99);ctx.lineTo(348,98);ctx.lineTo(354,99);ctx.lineTo(358,102);ctx.lineTo(361,106);ctx.lineTo(335,106);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(637,106);ctx.lineTo(640,102);ctx.lineTo(644,99);ctx.lineTo(650,98);ctx.lineTo(655,99);ctx.lineTo(660,102);ctx.lineTo(663,106);ctx.lineTo(637,106);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(597,106);ctx.lineTo(600,102);ctx.lineTo(605,99);ctx.lineTo(610,98);ctx.lineTo(616,99);ctx.lineTo(621,102);ctx.lineTo(623,106);ctx.lineTo(597,106);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(440,630);ctx.lineTo(440,237);ctx.lineTo(342,237);ctx.lineTo(289,185);ctx.lineTo(159,185);ctx.lineTo(159,132);ctx.lineTo(145,132);ctx.lineTo(145,80);ctx.lineTo(289,80);ctx.lineTo(289,93);ctx.lineTo(316,93);ctx.lineTo(316,106);ctx.lineTo(421,106);ctx.lineTo(421,28);ctx.lineTo(499,28);ctx.lineTo(532,54);ctx.lineTo(578,54);ctx.lineTo(578,106);ctx.lineTo(683,106);ctx.lineTo(683,93);ctx.lineTo(709,93);ctx.lineTo(709,80);ctx.lineTo(853,80);ctx.lineTo(853,132);ctx.lineTo(840,132);ctx.lineTo(840,185);ctx.lineTo(709,185);ctx.lineTo(656,237);ctx.lineTo(558,237);ctx.lineTo(558,630);ctx.lineTo(440,630);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(375,106));listpt.Add(new Point(377,102));listpt.Add(new Point(382,99));listpt.Add(new Point(388,98));listpt.Add(new Point(393,99));listpt.Add(new Point(398,102));listpt.Add(new Point(401,106));listpt.Add(new Point(375,106));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(335,106));listpt.Add(new Point(338,102));listpt.Add(new Point(343,99));listpt.Add(new Point(348,98));listpt.Add(new Point(354,99));listpt.Add(new Point(358,102));listpt.Add(new Point(361,106));listpt.Add(new Point(335,106));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(637,106));listpt.Add(new Point(640,102));listpt.Add(new Point(644,99));listpt.Add(new Point(650,98));listpt.Add(new Point(655,99));listpt.Add(new Point(660,102));listpt.Add(new Point(663,106));listpt.Add(new Point(637,106));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(597,106));listpt.Add(new Point(600,102));listpt.Add(new Point(605,99));listpt.Add(new Point(610,98));listpt.Add(new Point(616,99));listpt.Add(new Point(621,102));listpt.Add(new Point(623,106));listpt.Add(new Point(597,106));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(440,630));listpt.Add(new Point(440,237));listpt.Add(new Point(342,237));listpt.Add(new Point(289,185));listpt.Add(new Point(159,185));listpt.Add(new Point(159,132));listpt.Add(new Point(145,132));listpt.Add(new Point(145,80));listpt.Add(new Point(289,80));listpt.Add(new Point(289,93));listpt.Add(new Point(316,93));listpt.Add(new Point(316,106));listpt.Add(new Point(421,106));listpt.Add(new Point(421,28));listpt.Add(new Point(499,28));listpt.Add(new Point(532,54));listpt.Add(new Point(578,54));listpt.Add(new Point(578,106));listpt.Add(new Point(683,106));listpt.Add(new Point(683,93));listpt.Add(new Point(709,93));listpt.Add(new Point(709,80));listpt.Add(new Point(853,80));listpt.Add(new Point(853,132));listpt.Add(new Point(840,132));listpt.Add(new Point(840,185));listpt.Add(new Point(709,185));listpt.Add(new Point(656,237));listpt.Add(new Point(558,237));listpt.Add(new Point(558,630));listpt.Add(new Point(440,630));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}