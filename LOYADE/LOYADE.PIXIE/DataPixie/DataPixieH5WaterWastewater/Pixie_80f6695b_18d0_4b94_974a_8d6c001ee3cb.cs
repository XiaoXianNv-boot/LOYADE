using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WaterWastewater
{
    public class PIXIE_80f6695b_18d0_4b94_974a_8d6c001ee3cb : Pixie
    {
        public PIXIE_80f6695b_18d0_4b94_974a_8d6c001ee3cb()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#ccb299"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#666"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#666"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#666"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 655f; _h = 970f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#ccb299'; arrFillColor[1] = '#666'; arrFillColor[2] = '#666'; arrFillColor[3] = '#666'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(611,918);ctx.lineTo(630,970);ctx.lineTo(54,970);ctx.lineTo(71,918);ctx.lineTo(61,891);ctx.lineTo(52,863);ctx.lineTo(45,834);ctx.lineTo(39,805);ctx.lineTo(34,775);ctx.lineTo(31,744);ctx.lineTo(28,714);ctx.lineTo(28,698);ctx.lineTo(28,691);ctx.lineTo(28,683);ctx.lineTo(29,635);ctx.lineTo(34,588);ctx.lineTo(42,543);ctx.lineTo(53,500);ctx.lineTo(66,459);ctx.lineTo(81,420);ctx.lineTo(100,384);ctx.lineTo(120,350);ctx.lineTo(142,320);ctx.lineTo(166,293);ctx.lineTo(192,269);ctx.lineTo(220,249);ctx.lineTo(249,233);ctx.lineTo(278,222);ctx.lineTo(310,214);ctx.lineTo(326,212);ctx.lineTo(342,212);ctx.lineTo(358,212);ctx.lineTo(389,217);ctx.lineTo(420,227);ctx.lineTo(449,240);ctx.lineTo(477,258);ctx.lineTo(504,280);ctx.lineTo(529,306);ctx.lineTo(552,335);ctx.lineTo(574,366);ctx.lineTo(593,402);ctx.lineTo(610,439);ctx.lineTo(624,479);ctx.lineTo(636,521);ctx.lineTo(645,566);ctx.lineTo(652,611);ctx.lineTo(655,659);ctx.lineTo(655,683);ctx.lineTo(655,691);ctx.lineTo(655,721);ctx.lineTo(652,752);ctx.lineTo(648,782);ctx.lineTo(643,812);ctx.lineTo(637,842);ctx.lineTo(629,870);ctx.lineTo(619,898);ctx.lineTo(611,918);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(217,68);ctx.lineTo(296,68);ctx.lineTo(296,114);ctx.lineTo(217,114);ctx.lineTo(217,68);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(302,68);ctx.lineTo(381,68);ctx.lineTo(381,114);ctx.lineTo(302,114);ctx.lineTo(302,68);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(387,68);ctx.lineTo(466,68);ctx.lineTo(466,114);ctx.lineTo(387,114);ctx.lineTo(387,68);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(611,918));listpt.Add(new Point(630,970));listpt.Add(new Point(54,970));listpt.Add(new Point(71,918));listpt.Add(new Point(61,891));listpt.Add(new Point(52,863));listpt.Add(new Point(45,834));listpt.Add(new Point(39,805));listpt.Add(new Point(34,775));listpt.Add(new Point(31,744));listpt.Add(new Point(28,714));listpt.Add(new Point(28,698));listpt.Add(new Point(28,691));listpt.Add(new Point(28,683));listpt.Add(new Point(29,635));listpt.Add(new Point(34,588));listpt.Add(new Point(42,543));listpt.Add(new Point(53,500));listpt.Add(new Point(66,459));listpt.Add(new Point(81,420));listpt.Add(new Point(100,384));listpt.Add(new Point(120,350));listpt.Add(new Point(142,320));listpt.Add(new Point(166,293));listpt.Add(new Point(192,269));listpt.Add(new Point(220,249));listpt.Add(new Point(249,233));listpt.Add(new Point(278,222));listpt.Add(new Point(310,214));listpt.Add(new Point(326,212));listpt.Add(new Point(342,212));listpt.Add(new Point(358,212));listpt.Add(new Point(389,217));listpt.Add(new Point(420,227));listpt.Add(new Point(449,240));listpt.Add(new Point(477,258));listpt.Add(new Point(504,280));listpt.Add(new Point(529,306));listpt.Add(new Point(552,335));listpt.Add(new Point(574,366));listpt.Add(new Point(593,402));listpt.Add(new Point(610,439));listpt.Add(new Point(624,479));listpt.Add(new Point(636,521));listpt.Add(new Point(645,566));listpt.Add(new Point(652,611));listpt.Add(new Point(655,659));listpt.Add(new Point(655,683));listpt.Add(new Point(655,691));listpt.Add(new Point(655,721));listpt.Add(new Point(652,752));listpt.Add(new Point(648,782));listpt.Add(new Point(643,812));listpt.Add(new Point(637,842));listpt.Add(new Point(629,870));listpt.Add(new Point(619,898));listpt.Add(new Point(611,918));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(217,68));listpt.Add(new Point(296,68));listpt.Add(new Point(296,114));listpt.Add(new Point(217,114));listpt.Add(new Point(217,68));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(302,68));listpt.Add(new Point(381,68));listpt.Add(new Point(381,114));listpt.Add(new Point(302,114));listpt.Add(new Point(302,68));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(387,68));listpt.Add(new Point(466,68));listpt.Add(new Point(466,114));listpt.Add(new Point(387,114));listpt.Add(new Point(387,68));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}