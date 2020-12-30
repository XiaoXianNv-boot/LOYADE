using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WaterWastewater
{
    public class PIXIE_758bbc2b_2c95_4f80_b6c0_432387ab37d5 : Pixie
    {
        public PIXIE_758bbc2b_2c95_4f80_b6c0_432387ab37d5()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#f0f0f0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 249f; _h = 870.5185f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#f0f0f0'; arrFillColor[1] = '#7f7f7f'; arrFillColor[2] = '#7f7fff'; arrFillColor[3] = '#7f7fff'; arrFillColor[4] = '#e5e5e5'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(249,66);ctx.lineTo(239,69);ctx.lineTo(215,71);ctx.lineTo(181,74);ctx.lineTo(138,76);ctx.lineTo(95,74);ctx.lineTo(60,71);ctx.lineTo(36,69);ctx.lineTo(28,66);ctx.lineTo(30,60);ctx.lineTo(36,54);ctx.lineTo(46,50);ctx.lineTo(60,46);ctx.lineTo(76,42);ctx.lineTo(95,40);ctx.lineTo(115,37);ctx.lineTo(138,36);ctx.lineTo(159,37);ctx.lineTo(181,40);ctx.lineTo(199,42);ctx.lineTo(215,46);ctx.lineTo(230,50);ctx.lineTo(239,54);ctx.lineTo(247,60);ctx.lineTo(249,66);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(1,1.125);ctx.arc(78,809.7778,24,0,Math.PI*2,true);ctx.scale(1,0.8888889);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(1,1.08);ctx.arc(76,843.5185,25,0,Math.PI*2,true);ctx.scale(1,0.9259259);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(1,1.105263);ctx.arc(76,824.2381,19,0,Math.PI*2,true);ctx.scale(1,0.904762);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(135,30);ctx.lineTo(135,42);ctx.lineTo(135,30);ctx.lineTo(97,30);ctx.lineTo(97,42);ctx.lineTo(97,30);ctx.lineTo(97,28);ctx.lineTo(135,28);ctx.lineTo(173,28);ctx.lineTo(173,30);ctx.lineTo(173,42);ctx.lineTo(173,30);ctx.lineTo(135,30);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(249,66));listpt.Add(new Point(239,69));listpt.Add(new Point(215,71));listpt.Add(new Point(181,74));listpt.Add(new Point(138,76));listpt.Add(new Point(95,74));listpt.Add(new Point(60,71));listpt.Add(new Point(36,69));listpt.Add(new Point(28,66));listpt.Add(new Point(30,60));listpt.Add(new Point(36,54));listpt.Add(new Point(46,50));listpt.Add(new Point(60,46));listpt.Add(new Point(76,42));listpt.Add(new Point(95,40));listpt.Add(new Point(115,37));listpt.Add(new Point(138,36));listpt.Add(new Point(159,37));listpt.Add(new Point(181,40));listpt.Add(new Point(199,42));listpt.Add(new Point(215,46));listpt.Add(new Point(230,50));listpt.Add(new Point(239,54));listpt.Add(new Point(247,60));listpt.Add(new Point(249,66));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 54f,782.7778f,48f,54f);g.DrawEllipse(p, 54f,782.7778f,48f,54f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillEllipse(sb, 51f,816.5185f,50f,54f);g.DrawEllipse(p, 51f,816.5185f,50f,54f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillEllipse(sb, 57f,803.2381f,38f,41.99999f);g.DrawEllipse(p, 57f,803.2381f,38f,41.99999f);
listpt = new List<Point>();listpt.Add(new Point(135,30));listpt.Add(new Point(135,42));listpt.Add(new Point(135,30));listpt.Add(new Point(97,30));listpt.Add(new Point(97,42));listpt.Add(new Point(97,30));listpt.Add(new Point(97,28));listpt.Add(new Point(135,28));listpt.Add(new Point(173,28));listpt.Add(new Point(173,30));listpt.Add(new Point(173,42));listpt.Add(new Point(173,30));listpt.Add(new Point(135,30));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}