using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5FlowMeter
{
    public class PIXIE_cadb97de_cbe3_4e75_a5cd_1cb9ce12cdcd : Pixie
    {
        public PIXIE_cadb97de_cbe3_4e75_a5cd_1cb9ce12cdcd()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 101f; _h = 104f;
_content = "var arrFillColor = new Array(11); var arrBorderColor = new Array(11); var arrBorderWidth = new Array(11); arrFillColor[0] = '#999'; arrFillColor[1] = '#ccc'; arrFillColor[2] = '#7f7f7f'; arrFillColor[3] = '#999'; arrFillColor[4] = '#999'; arrFillColor[5] = '#ccc'; arrFillColor[6] = '#ccc'; arrFillColor[7] = '#b2b2b2'; arrFillColor[8] = '#999'; arrFillColor[9] = '#999'; arrFillColor[10] = '#999'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderColor[6] = '#000'; arrBorderColor[7] = '#000'; arrBorderColor[8] = '#000'; arrBorderColor[9] = '#000'; arrBorderColor[10] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; arrBorderWidth[6] = '2'; arrBorderWidth[7] = '2'; arrBorderWidth[8] = '2'; arrBorderWidth[9] = '2'; arrBorderWidth[10] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(22,38);ctx.lineTo(15,29);ctx.lineTo(15,22);ctx.lineTo(22,21);ctx.lineTo(22,38);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(1,2.666667);ctx.arc(98,12.75,3,0,Math.PI*2,true);ctx.scale(1,0.375);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(99,39,2,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(29,92);ctx.lineTo(29,88);ctx.lineTo(33,88);ctx.lineTo(33,92);ctx.lineTo(29,92);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(83,92);ctx.lineTo(83,88);ctx.lineTo(88,88);ctx.lineTo(88,92);ctx.lineTo(83,92);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(29,95);ctx.lineTo(29,92);ctx.lineTo(33,92);ctx.lineTo(33,95);ctx.lineTo(29,95);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(83,95);ctx.lineTo(83,92);ctx.lineTo(88,92);ctx.lineTo(88,95);ctx.lineTo(83,95);ctx.fillStyle = arrFillColor[6];ctx.fill();ctx.lineWidth = arrBorderWidth[6];ctx.strokeStyle = arrBorderColor[6];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(50,88);ctx.lineTo(66,88);ctx.lineTo(66,104);ctx.lineTo(50,104);ctx.lineTo(50,88);ctx.fillStyle = arrFillColor[7];ctx.fill();ctx.lineWidth = arrBorderWidth[7];ctx.strokeStyle = arrBorderColor[7];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(50,90);ctx.lineTo(54,90);ctx.lineTo(54,100);ctx.lineTo(50,100);ctx.lineTo(50,90);ctx.fillStyle = arrFillColor[8];ctx.fill();ctx.lineWidth = arrBorderWidth[8];ctx.strokeStyle = arrBorderColor[8];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(56,90);ctx.lineTo(59,90);ctx.lineTo(59,100);ctx.lineTo(56,100);ctx.lineTo(56,90);ctx.fillStyle = arrFillColor[9];ctx.fill();ctx.lineWidth = arrBorderWidth[9];ctx.strokeStyle = arrBorderColor[9];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(62,90);ctx.lineTo(65,90);ctx.lineTo(65,100);ctx.lineTo(62,100);ctx.lineTo(62,90);ctx.fillStyle = arrFillColor[10];ctx.fill();ctx.lineWidth = arrBorderWidth[10];ctx.strokeStyle = arrBorderColor[10];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(22,38));listpt.Add(new Point(15,29));listpt.Add(new Point(15,22));listpt.Add(new Point(22,21));listpt.Add(new Point(22,38));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 95f,4.749999f,6f,16f);g.DrawEllipse(p, 95f,4.749999f,6f,16f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillEllipse(sb, 97f,37f,4f,4f);g.DrawEllipse(p, 97f,37f,4f,4f);
listpt = new List<Point>();listpt.Add(new Point(29,92));listpt.Add(new Point(29,88));listpt.Add(new Point(33,88));listpt.Add(new Point(33,92));listpt.Add(new Point(29,92));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(83,92));listpt.Add(new Point(83,88));listpt.Add(new Point(88,88));listpt.Add(new Point(88,92));listpt.Add(new Point(83,92));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(29,95));listpt.Add(new Point(29,92));listpt.Add(new Point(33,92));listpt.Add(new Point(33,95));listpt.Add(new Point(29,95));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(83,95));listpt.Add(new Point(83,92));listpt.Add(new Point(88,92));listpt.Add(new Point(88,95));listpt.Add(new Point(83,95));sb = new SolidBrush(_listfillcolor[6]);p = new Pen(Color.Black);p.Width = _listborderwidth[6];p.Color = _listbordercolor[6];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(50,88));listpt.Add(new Point(66,88));listpt.Add(new Point(66,104));listpt.Add(new Point(50,104));listpt.Add(new Point(50,88));sb = new SolidBrush(_listfillcolor[7]);p = new Pen(Color.Black);p.Width = _listborderwidth[7];p.Color = _listbordercolor[7];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(50,90));listpt.Add(new Point(54,90));listpt.Add(new Point(54,100));listpt.Add(new Point(50,100));listpt.Add(new Point(50,90));sb = new SolidBrush(_listfillcolor[8]);p = new Pen(Color.Black);p.Width = _listborderwidth[8];p.Color = _listbordercolor[8];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(56,90));listpt.Add(new Point(59,90));listpt.Add(new Point(59,100));listpt.Add(new Point(56,100));listpt.Add(new Point(56,90));sb = new SolidBrush(_listfillcolor[9]);p = new Pen(Color.Black);p.Width = _listborderwidth[9];p.Color = _listbordercolor[9];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(62,90));listpt.Add(new Point(65,90));listpt.Add(new Point(65,100));listpt.Add(new Point(62,100));listpt.Add(new Point(62,90));sb = new SolidBrush(_listfillcolor[10]);p = new Pen(Color.Black);p.Width = _listborderwidth[10];p.Color = _listbordercolor[10];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}