using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ComputerHardware
{
    public class PIXIE_32821828_d1d2_48ec_b662_e9cfed8ac04b : Pixie
    {
        public PIXIE_32821828_d1d2_48ec_b662_e9cfed8ac04b()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#c1c1c1"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#828282"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#006"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#c1c1c1"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#828282"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 840f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#c1c1c1'; arrFillColor[1] = '#828282'; arrFillColor[2] = '#006'; arrFillColor[3] = '#c1c1c1'; arrFillColor[4] = '#828282'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,68);ctx.lineTo(28,64);ctx.lineTo(28,61);ctx.lineTo(28,58);ctx.lineTo(37,33);ctx.lineTo(66,28);ctx.lineTo(75,28);ctx.lineTo(81,28);ctx.lineTo(87,28);ctx.lineTo(917,28);ctx.lineTo(947,29);ctx.lineTo(969,45);ctx.lineTo(970,60);ctx.lineTo(970,63);ctx.lineTo(970,67);ctx.lineTo(970,658);ctx.lineTo(968,686);ctx.lineTo(945,699);ctx.lineTo(942,700);ctx.lineTo(939,700);ctx.lineTo(936,700);ctx.lineTo(74,700);ctx.lineTo(46,697);ctx.lineTo(29,676);ctx.lineTo(28,644);ctx.lineTo(28,68);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(263,700);ctx.lineTo(735,700);ctx.lineTo(735,744);ctx.lineTo(263,744);ctx.lineTo(263,700);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(99,156);ctx.lineTo(99,151);ctx.lineTo(99,147);ctx.lineTo(99,143);ctx.lineTo(103,115);ctx.lineTo(128,105);ctx.lineTo(140,104);ctx.lineTo(145,104);ctx.lineTo(150,104);ctx.lineTo(852,104);ctx.lineTo(880,107);ctx.lineTo(898,126);ctx.lineTo(899,148);ctx.lineTo(899,543);ctx.lineTo(900,559);ctx.lineTo(900,562);ctx.lineTo(900,564);ctx.lineTo(878,582);ctx.lineTo(847,583);ctx.lineTo(155,583);ctx.lineTo(136,583);ctx.lineTo(132,583);ctx.lineTo(128,583);ctx.lineTo(103,575);ctx.lineTo(99,546);ctx.lineTo(99,156);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,840);ctx.lineTo(970,840);ctx.lineTo(970,807);ctx.lineTo(735,744);ctx.lineTo(263,744);ctx.lineTo(28,807);ctx.lineTo(28,840);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(889,623);ctx.lineTo(889,671);ctx.lineTo(663,671);ctx.lineTo(663,623);ctx.lineTo(889,623);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,68));listpt.Add(new Point(28,64));listpt.Add(new Point(28,61));listpt.Add(new Point(28,58));listpt.Add(new Point(37,33));listpt.Add(new Point(66,28));listpt.Add(new Point(75,28));listpt.Add(new Point(81,28));listpt.Add(new Point(87,28));listpt.Add(new Point(917,28));listpt.Add(new Point(947,29));listpt.Add(new Point(969,45));listpt.Add(new Point(970,60));listpt.Add(new Point(970,63));listpt.Add(new Point(970,67));listpt.Add(new Point(970,658));listpt.Add(new Point(968,686));listpt.Add(new Point(945,699));listpt.Add(new Point(942,700));listpt.Add(new Point(939,700));listpt.Add(new Point(936,700));listpt.Add(new Point(74,700));listpt.Add(new Point(46,697));listpt.Add(new Point(29,676));listpt.Add(new Point(28,644));listpt.Add(new Point(28,68));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(263,700));listpt.Add(new Point(735,700));listpt.Add(new Point(735,744));listpt.Add(new Point(263,744));listpt.Add(new Point(263,700));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(99,156));listpt.Add(new Point(99,151));listpt.Add(new Point(99,147));listpt.Add(new Point(99,143));listpt.Add(new Point(103,115));listpt.Add(new Point(128,105));listpt.Add(new Point(140,104));listpt.Add(new Point(145,104));listpt.Add(new Point(150,104));listpt.Add(new Point(852,104));listpt.Add(new Point(880,107));listpt.Add(new Point(898,126));listpt.Add(new Point(899,148));listpt.Add(new Point(899,543));listpt.Add(new Point(900,559));listpt.Add(new Point(900,562));listpt.Add(new Point(900,564));listpt.Add(new Point(878,582));listpt.Add(new Point(847,583));listpt.Add(new Point(155,583));listpt.Add(new Point(136,583));listpt.Add(new Point(132,583));listpt.Add(new Point(128,583));listpt.Add(new Point(103,575));listpt.Add(new Point(99,546));listpt.Add(new Point(99,156));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,840));listpt.Add(new Point(970,840));listpt.Add(new Point(970,807));listpt.Add(new Point(735,744));listpt.Add(new Point(263,744));listpt.Add(new Point(28,807));listpt.Add(new Point(28,840));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(889,623));listpt.Add(new Point(889,671));listpt.Add(new Point(663,671));listpt.Add(new Point(663,623));listpt.Add(new Point(889,623));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}