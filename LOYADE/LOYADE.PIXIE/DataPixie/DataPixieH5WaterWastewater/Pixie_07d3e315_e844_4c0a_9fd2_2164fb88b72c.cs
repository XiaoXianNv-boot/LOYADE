using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WaterWastewater
{
    public class PIXIE_07d3e315_e844_4c0a_9fd2_2164fb88b72c : Pixie
    {
        public PIXIE_07d3e315_e844_4c0a_9fd2_2164fb88b72c()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 584f; _h = 970f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrFillColor[2] = '#0ff'; arrFillColor[3] = '#0ff'; arrFillColor[4] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(92,670);ctx.lineTo(92,949);ctx.lineTo(157,949);ctx.lineTo(157,670);ctx.lineTo(92,670);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(456,670);ctx.lineTo(456,949);ctx.lineTo(520,949);ctx.lineTo(520,670);ctx.lineTo(456,670);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(70,970);ctx.lineTo(70,949);ctx.lineTo(177,949);ctx.lineTo(177,970);ctx.lineTo(70,970);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(435,970);ctx.lineTo(435,949);ctx.lineTo(542,949);ctx.lineTo(542,970);ctx.lineTo(435,970);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(584,620);ctx.lineTo(572,647);ctx.lineTo(551,664);ctx.lineTo(521,679);ctx.lineTo(493,689);ctx.lineTo(462,697);ctx.lineTo(427,703);ctx.lineTo(389,708);ctx.lineTo(363,711);ctx.lineTo(335,712);ctx.lineTo(321,713);ctx.lineTo(307,713);ctx.lineTo(278,712);ctx.lineTo(251,711);ctx.lineTo(224,708);ctx.lineTo(186,703);ctx.lineTo(151,697);ctx.lineTo(119,689);ctx.lineTo(92,679);ctx.lineTo(68,668);ctx.lineTo(45,652);ctx.lineTo(29,629);ctx.lineTo(28,624);ctx.lineTo(28,620);ctx.lineTo(28,121);ctx.lineTo(40,93);ctx.lineTo(62,76);ctx.lineTo(92,61);ctx.lineTo(119,52);ctx.lineTo(151,43);ctx.lineTo(186,37);ctx.lineTo(224,32);ctx.lineTo(251,29);ctx.lineTo(278,28);ctx.lineTo(292,28);ctx.lineTo(307,28);ctx.lineTo(335,28);ctx.lineTo(363,29);ctx.lineTo(389,32);ctx.lineTo(427,37);ctx.lineTo(462,43);ctx.lineTo(493,52);ctx.lineTo(521,61);ctx.lineTo(544,72);ctx.lineTo(568,89);ctx.lineTo(583,111);ctx.lineTo(584,116);ctx.lineTo(584,121);ctx.lineTo(584,620);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(92,670));listpt.Add(new Point(92,949));listpt.Add(new Point(157,949));listpt.Add(new Point(157,670));listpt.Add(new Point(92,670));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(456,670));listpt.Add(new Point(456,949));listpt.Add(new Point(520,949));listpt.Add(new Point(520,670));listpt.Add(new Point(456,670));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(70,970));listpt.Add(new Point(70,949));listpt.Add(new Point(177,949));listpt.Add(new Point(177,970));listpt.Add(new Point(70,970));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(435,970));listpt.Add(new Point(435,949));listpt.Add(new Point(542,949));listpt.Add(new Point(542,970));listpt.Add(new Point(435,970));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(584,620));listpt.Add(new Point(572,647));listpt.Add(new Point(551,664));listpt.Add(new Point(521,679));listpt.Add(new Point(493,689));listpt.Add(new Point(462,697));listpt.Add(new Point(427,703));listpt.Add(new Point(389,708));listpt.Add(new Point(363,711));listpt.Add(new Point(335,712));listpt.Add(new Point(321,713));listpt.Add(new Point(307,713));listpt.Add(new Point(278,712));listpt.Add(new Point(251,711));listpt.Add(new Point(224,708));listpt.Add(new Point(186,703));listpt.Add(new Point(151,697));listpt.Add(new Point(119,689));listpt.Add(new Point(92,679));listpt.Add(new Point(68,668));listpt.Add(new Point(45,652));listpt.Add(new Point(29,629));listpt.Add(new Point(28,624));listpt.Add(new Point(28,620));listpt.Add(new Point(28,121));listpt.Add(new Point(40,93));listpt.Add(new Point(62,76));listpt.Add(new Point(92,61));listpt.Add(new Point(119,52));listpt.Add(new Point(151,43));listpt.Add(new Point(186,37));listpt.Add(new Point(224,32));listpt.Add(new Point(251,29));listpt.Add(new Point(278,28));listpt.Add(new Point(292,28));listpt.Add(new Point(307,28));listpt.Add(new Point(335,28));listpt.Add(new Point(363,29));listpt.Add(new Point(389,32));listpt.Add(new Point(427,37));listpt.Add(new Point(462,43));listpt.Add(new Point(493,52));listpt.Add(new Point(521,61));listpt.Add(new Point(544,72));listpt.Add(new Point(568,89));listpt.Add(new Point(583,111));listpt.Add(new Point(584,116));listpt.Add(new Point(584,121));listpt.Add(new Point(584,620));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}