using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Switch
{
    public class PIXIE_9055a8b5_cbba_4601_a2dd_c3cdab7b6e84 : Pixie
    {
        public PIXIE_9055a8b5_cbba_4601_a2dd_c3cdab7b6e84()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listfillcolor.Add(ColorTranslator.FromHtml("#f00"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 970f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#999'; arrFillColor[1] = '#e5e5e5'; arrFillColor[2] = '#f00'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#b2b2b2'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(678,938);ctx.lineTo(562,970);ctx.lineTo(436,970);ctx.lineTo(320,938);ctx.lineTo(212,877);ctx.lineTo(121,786);ctx.lineTo(60,678);ctx.lineTo(28,562);ctx.lineTo(28,436);ctx.lineTo(60,320);ctx.lineTo(121,212);ctx.lineTo(212,121);ctx.lineTo(320,60);ctx.lineTo(436,28);ctx.lineTo(562,28);ctx.lineTo(678,60);ctx.lineTo(786,121);ctx.lineTo(877,212);ctx.lineTo(938,320);ctx.lineTo(970,436);ctx.lineTo(970,562);ctx.lineTo(938,678);ctx.lineTo(877,786);ctx.lineTo(786,877);ctx.lineTo(678,938);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(360,896);ctx.lineTo(247,848);ctx.lineTo(164,769);ctx.lineTo(107,671);ctx.lineTo(77,558);ctx.lineTo(77,443);ctx.lineTo(107,334);ctx.lineTo(164,236);ctx.lineTo(247,153);ctx.lineTo(344,98);ctx.lineTo(454,67);ctx.lineTo(569,67);ctx.lineTo(680,98);ctx.lineTo(763,155);ctx.lineTo(855,254);ctx.lineTo(634,157);ctx.lineTo(208,726);ctx.lineTo(360,896);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(640,843);ctx.lineTo(546,868);ctx.lineTo(450,868);ctx.lineTo(357,843);ctx.lineTo(274,793);ctx.lineTo(205,726);ctx.lineTo(155,641);ctx.lineTo(130,548);ctx.lineTo(130,452);ctx.lineTo(155,358);ctx.lineTo(205,274);ctx.lineTo(272,206);ctx.lineTo(357,157);ctx.lineTo(450,132);ctx.lineTo(546,132);ctx.lineTo(640,157);ctx.lineTo(724,206);ctx.lineTo(792,274);ctx.lineTo(841,358);ctx.lineTo(866,452);ctx.lineTo(866,548);ctx.lineTo(841,641);ctx.lineTo(792,726);ctx.lineTo(724,793);ctx.lineTo(640,843);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(678,938));listpt.Add(new Point(562,970));listpt.Add(new Point(436,970));listpt.Add(new Point(320,938));listpt.Add(new Point(212,877));listpt.Add(new Point(121,786));listpt.Add(new Point(60,678));listpt.Add(new Point(28,562));listpt.Add(new Point(28,436));listpt.Add(new Point(60,320));listpt.Add(new Point(121,212));listpt.Add(new Point(212,121));listpt.Add(new Point(320,60));listpt.Add(new Point(436,28));listpt.Add(new Point(562,28));listpt.Add(new Point(678,60));listpt.Add(new Point(786,121));listpt.Add(new Point(877,212));listpt.Add(new Point(938,320));listpt.Add(new Point(970,436));listpt.Add(new Point(970,562));listpt.Add(new Point(938,678));listpt.Add(new Point(877,786));listpt.Add(new Point(786,877));listpt.Add(new Point(678,938));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(360,896));listpt.Add(new Point(247,848));listpt.Add(new Point(164,769));listpt.Add(new Point(107,671));listpt.Add(new Point(77,558));listpt.Add(new Point(77,443));listpt.Add(new Point(107,334));listpt.Add(new Point(164,236));listpt.Add(new Point(247,153));listpt.Add(new Point(344,98));listpt.Add(new Point(454,67));listpt.Add(new Point(569,67));listpt.Add(new Point(680,98));listpt.Add(new Point(763,155));listpt.Add(new Point(855,254));listpt.Add(new Point(634,157));listpt.Add(new Point(208,726));listpt.Add(new Point(360,896));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(640,843));listpt.Add(new Point(546,868));listpt.Add(new Point(450,868));listpt.Add(new Point(357,843));listpt.Add(new Point(274,793));listpt.Add(new Point(205,726));listpt.Add(new Point(155,641));listpt.Add(new Point(130,548));listpt.Add(new Point(130,452));listpt.Add(new Point(155,358));listpt.Add(new Point(205,274));listpt.Add(new Point(272,206));listpt.Add(new Point(357,157));listpt.Add(new Point(450,132));listpt.Add(new Point(546,132));listpt.Add(new Point(640,157));listpt.Add(new Point(724,206));listpt.Add(new Point(792,274));listpt.Add(new Point(841,358));listpt.Add(new Point(866,452));listpt.Add(new Point(866,548));listpt.Add(new Point(841,641));listpt.Add(new Point(792,726));listpt.Add(new Point(724,793));listpt.Add(new Point(640,843));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}