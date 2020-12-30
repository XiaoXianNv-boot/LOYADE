using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WaterWastewater
{
    public class PIXIE_8ec830b3_e92a_401f_add1_5f12bf8c3ded : Pixie
    {
        public PIXIE_8ec830b3_e92a_401f_add1_5f12bf8c3ded()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#bfbf00"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f0f0f0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 262f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#bfbf00'; arrFillColor[1] = '#f0f0f0'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(46,122);ctx.lineTo(75,138);ctx.lineTo(162,160);ctx.lineTo(270,175);ctx.lineTo(385,183);ctx.lineTo(495,187);ctx.lineTo(611,183);ctx.lineTo(734,173);ctx.lineTo(846,158);ctx.lineTo(925,138);ctx.lineTo(952,124);ctx.lineTo(962,107);ctx.lineTo(964,173);ctx.lineTo(954,189);ctx.lineTo(927,203);ctx.lineTo(883,216);ctx.lineTo(827,228);ctx.lineTo(758,238);ctx.lineTo(679,244);ctx.lineTo(593,250);ctx.lineTo(405,250);ctx.lineTo(319,244);ctx.lineTo(240,238);ctx.lineTo(171,228);ctx.lineTo(114,216);ctx.lineTo(71,203);ctx.lineTo(44,189);ctx.lineTo(34,173);ctx.lineTo(36,107);ctx.lineTo(46,122);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(964,163);ctx.lineTo(964,173);ctx.lineTo(954,189);ctx.lineTo(927,203);ctx.lineTo(883,216);ctx.lineTo(827,228);ctx.lineTo(758,238);ctx.lineTo(679,244);ctx.lineTo(593,248);ctx.lineTo(499,250);ctx.lineTo(405,248);ctx.lineTo(319,244);ctx.lineTo(240,238);ctx.lineTo(171,228);ctx.lineTo(114,216);ctx.lineTo(71,203);ctx.lineTo(44,189);ctx.lineTo(34,173);ctx.lineTo(36,163);ctx.lineTo(28,163);ctx.lineTo(28,187);ctx.lineTo(50,203);ctx.lineTo(87,216);ctx.lineTo(136,230);ctx.lineTo(195,240);ctx.lineTo(262,248);ctx.lineTo(338,256);ctx.lineTo(415,260);ctx.lineTo(497,262);ctx.lineTo(579,260);ctx.lineTo(660,256);ctx.lineTo(736,248);ctx.lineTo(805,240);ctx.lineTo(864,228);ctx.lineTo(915,216);ctx.lineTo(950,203);ctx.lineTo(970,187);ctx.lineTo(970,163);ctx.lineTo(964,163);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(46,122));listpt.Add(new Point(75,138));listpt.Add(new Point(162,160));listpt.Add(new Point(270,175));listpt.Add(new Point(385,183));listpt.Add(new Point(495,187));listpt.Add(new Point(611,183));listpt.Add(new Point(734,173));listpt.Add(new Point(846,158));listpt.Add(new Point(925,138));listpt.Add(new Point(952,124));listpt.Add(new Point(962,107));listpt.Add(new Point(964,173));listpt.Add(new Point(954,189));listpt.Add(new Point(927,203));listpt.Add(new Point(883,216));listpt.Add(new Point(827,228));listpt.Add(new Point(758,238));listpt.Add(new Point(679,244));listpt.Add(new Point(593,250));listpt.Add(new Point(405,250));listpt.Add(new Point(319,244));listpt.Add(new Point(240,238));listpt.Add(new Point(171,228));listpt.Add(new Point(114,216));listpt.Add(new Point(71,203));listpt.Add(new Point(44,189));listpt.Add(new Point(34,173));listpt.Add(new Point(36,107));listpt.Add(new Point(46,122));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(964,163));listpt.Add(new Point(964,173));listpt.Add(new Point(954,189));listpt.Add(new Point(927,203));listpt.Add(new Point(883,216));listpt.Add(new Point(827,228));listpt.Add(new Point(758,238));listpt.Add(new Point(679,244));listpt.Add(new Point(593,248));listpt.Add(new Point(499,250));listpt.Add(new Point(405,248));listpt.Add(new Point(319,244));listpt.Add(new Point(240,238));listpt.Add(new Point(171,228));listpt.Add(new Point(114,216));listpt.Add(new Point(71,203));listpt.Add(new Point(44,189));listpt.Add(new Point(34,173));listpt.Add(new Point(36,163));listpt.Add(new Point(28,163));listpt.Add(new Point(28,187));listpt.Add(new Point(50,203));listpt.Add(new Point(87,216));listpt.Add(new Point(136,230));listpt.Add(new Point(195,240));listpt.Add(new Point(262,248));listpt.Add(new Point(338,256));listpt.Add(new Point(415,260));listpt.Add(new Point(497,262));listpt.Add(new Point(579,260));listpt.Add(new Point(660,256));listpt.Add(new Point(736,248));listpt.Add(new Point(805,240));listpt.Add(new Point(864,228));listpt.Add(new Point(915,216));listpt.Add(new Point(950,203));listpt.Add(new Point(970,187));listpt.Add(new Point(970,163));listpt.Add(new Point(964,163));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}