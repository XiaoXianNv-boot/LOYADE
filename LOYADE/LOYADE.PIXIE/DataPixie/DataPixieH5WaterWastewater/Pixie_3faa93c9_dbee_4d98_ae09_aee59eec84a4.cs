using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WaterWastewater
{
    public class PIXIE_3faa93c9_dbee_4d98_ae09_aee59eec84a4 : Pixie
    {
        public PIXIE_3faa93c9_dbee_4d98_ae09_aee59eec84a4()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#8c8c8c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#adb2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 224f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#8c8c8c'; arrFillColor[1] = '#ccc'; arrFillColor[2] = '#999'; arrFillColor[3] = '#ccc'; arrFillColor[4] = '#adb2b2'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(970,185);ctx.lineTo(970,67);ctx.lineTo(28,67);ctx.lineTo(28,185);ctx.lineTo(28,187);ctx.lineTo(56,198);ctx.lineTo(85,204);ctx.lineTo(122,208);ctx.lineTo(151,211);ctx.lineTo(182,214);ctx.lineTo(218,216);ctx.lineTo(255,218);ctx.lineTo(295,220);ctx.lineTo(337,222);ctx.lineTo(382,223);ctx.lineTo(427,224);ctx.lineTo(451,224);ctx.lineTo(475,224);ctx.lineTo(499,224);ctx.lineTo(547,224);ctx.lineTo(594,223);ctx.lineTo(639,222);ctx.lineTo(682,221);ctx.lineTo(723,219);ctx.lineTo(762,218);ctx.lineTo(798,215);ctx.lineTo(832,212);ctx.lineTo(862,210);ctx.lineTo(889,207);ctx.lineTo(924,202);ctx.lineTo(955,195);ctx.lineTo(970,187);ctx.lineTo(970,185);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(12.07692,1);ctx.arc(41.31847,67,39,0,Math.PI*2,true);ctx.scale(0.08280255,1);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(13.03125,1);ctx.arc(38.29256,65,32,0,Math.PI*2,true);ctx.scale(0.07673861,1);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(12.25,1);ctx.arc(40.7347,67,8,0,Math.PI*2,true);ctx.scale(0.08163265,1);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(439,96);ctx.lineTo(581,68);ctx.lineTo(421,68);ctx.lineTo(255,90);ctx.lineTo(265,91);ctx.lineTo(275,92);ctx.lineTo(286,92);ctx.lineTo(297,92);ctx.lineTo(308,93);ctx.lineTo(319,93);ctx.lineTo(331,94);ctx.lineTo(343,94);ctx.lineTo(354,94);ctx.lineTo(366,95);ctx.lineTo(378,95);ctx.lineTo(390,95);ctx.lineTo(402,95);ctx.lineTo(414,96);ctx.lineTo(426,96);ctx.lineTo(439,96);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(970,185));listpt.Add(new Point(970,67));listpt.Add(new Point(28,67));listpt.Add(new Point(28,185));listpt.Add(new Point(28,187));listpt.Add(new Point(56,198));listpt.Add(new Point(85,204));listpt.Add(new Point(122,208));listpt.Add(new Point(151,211));listpt.Add(new Point(182,214));listpt.Add(new Point(218,216));listpt.Add(new Point(255,218));listpt.Add(new Point(295,220));listpt.Add(new Point(337,222));listpt.Add(new Point(382,223));listpt.Add(new Point(427,224));listpt.Add(new Point(451,224));listpt.Add(new Point(475,224));listpt.Add(new Point(499,224));listpt.Add(new Point(547,224));listpt.Add(new Point(594,223));listpt.Add(new Point(639,222));listpt.Add(new Point(682,221));listpt.Add(new Point(723,219));listpt.Add(new Point(762,218));listpt.Add(new Point(798,215));listpt.Add(new Point(832,212));listpt.Add(new Point(862,210));listpt.Add(new Point(889,207));listpt.Add(new Point(924,202));listpt.Add(new Point(955,195));listpt.Add(new Point(970,187));listpt.Add(new Point(970,185));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 2.31847f,28f,78f,78f);g.DrawEllipse(p, 2.31847f,28f,78f,78f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillEllipse(sb, 6.292561f,33f,64f,64f);g.DrawEllipse(p, 6.292561f,33f,64f,64f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillEllipse(sb, 32.7347f,59f,16f,16f);g.DrawEllipse(p, 32.7347f,59f,16f,16f);
listpt = new List<Point>();listpt.Add(new Point(439,96));listpt.Add(new Point(581,68));listpt.Add(new Point(421,68));listpt.Add(new Point(255,90));listpt.Add(new Point(265,91));listpt.Add(new Point(275,92));listpt.Add(new Point(286,92));listpt.Add(new Point(297,92));listpt.Add(new Point(308,93));listpt.Add(new Point(319,93));listpt.Add(new Point(331,94));listpt.Add(new Point(343,94));listpt.Add(new Point(354,94));listpt.Add(new Point(366,95));listpt.Add(new Point(378,95));listpt.Add(new Point(390,95));listpt.Add(new Point(402,95));listpt.Add(new Point(414,96));listpt.Add(new Point(426,96));listpt.Add(new Point(439,96));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}