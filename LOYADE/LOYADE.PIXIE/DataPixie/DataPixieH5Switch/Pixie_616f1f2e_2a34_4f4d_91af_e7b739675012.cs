using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Switch
{
    public class PIXIE_616f1f2e_2a34_4f4d_91af_e7b739675012 : Pixie
    {
        public PIXIE_616f1f2e_2a34_4f4d_91af_e7b739675012()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 915f; _h = 916f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#e5e5e5'; arrFillColor[1] = '#7f7f7f'; arrFillColor[2] = '#b2b2b2'; arrFillColor[3] = '#000'; arrFillColor[4] = '#000'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(317,90);ctx.lineTo(88,317);ctx.lineTo(81,339);ctx.lineTo(81,659);ctx.lineTo(88,681);ctx.lineTo(317,910);ctx.lineTo(339,916);ctx.lineTo(657,916);ctx.lineTo(680,910);ctx.lineTo(908,681);ctx.lineTo(915,659);ctx.lineTo(915,339);ctx.lineTo(908,317);ctx.lineTo(680,90);ctx.lineTo(657,82);ctx.lineTo(339,82);ctx.lineTo(317,90);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(498,499,392,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(555,55);ctx.lineTo(555,138);ctx.lineTo(633,160);ctx.lineTo(703,198);ctx.lineTo(766,250);ctx.lineTo(813,314);ctx.lineTo(845,388);ctx.lineTo(861,467);ctx.lineTo(860,549);ctx.lineTo(840,626);ctx.lineTo(804,698);ctx.lineTo(753,760);ctx.lineTo(691,809);ctx.lineTo(617,844);ctx.lineTo(539,861);ctx.lineTo(458,861);ctx.lineTo(379,844);ctx.lineTo(306,809);ctx.lineTo(243,760);ctx.lineTo(192,698);ctx.lineTo(156,626);ctx.lineTo(137,549);ctx.lineTo(133,467);ctx.lineTo(149,388);ctx.lineTo(183,314);ctx.lineTo(230,250);ctx.lineTo(291,198);ctx.lineTo(363,160);ctx.lineTo(443,138);ctx.lineTo(443,55);ctx.lineTo(555,55);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(498,499,271,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(498,499,243,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(317,90));listpt.Add(new Point(88,317));listpt.Add(new Point(81,339));listpt.Add(new Point(81,659));listpt.Add(new Point(88,681));listpt.Add(new Point(317,910));listpt.Add(new Point(339,916));listpt.Add(new Point(657,916));listpt.Add(new Point(680,910));listpt.Add(new Point(908,681));listpt.Add(new Point(915,659));listpt.Add(new Point(915,339));listpt.Add(new Point(908,317));listpt.Add(new Point(680,90));listpt.Add(new Point(657,82));listpt.Add(new Point(339,82));listpt.Add(new Point(317,90));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 106f,107f,784f,784f);g.DrawEllipse(p, 106f,107f,784f,784f);
listpt = new List<Point>();listpt.Add(new Point(555,55));listpt.Add(new Point(555,138));listpt.Add(new Point(633,160));listpt.Add(new Point(703,198));listpt.Add(new Point(766,250));listpt.Add(new Point(813,314));listpt.Add(new Point(845,388));listpt.Add(new Point(861,467));listpt.Add(new Point(860,549));listpt.Add(new Point(840,626));listpt.Add(new Point(804,698));listpt.Add(new Point(753,760));listpt.Add(new Point(691,809));listpt.Add(new Point(617,844));listpt.Add(new Point(539,861));listpt.Add(new Point(458,861));listpt.Add(new Point(379,844));listpt.Add(new Point(306,809));listpt.Add(new Point(243,760));listpt.Add(new Point(192,698));listpt.Add(new Point(156,626));listpt.Add(new Point(137,549));listpt.Add(new Point(133,467));listpt.Add(new Point(149,388));listpt.Add(new Point(183,314));listpt.Add(new Point(230,250));listpt.Add(new Point(291,198));listpt.Add(new Point(363,160));listpt.Add(new Point(443,138));listpt.Add(new Point(443,55));listpt.Add(new Point(555,55));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillEllipse(sb, 227f,228f,542f,542f);g.DrawEllipse(p, 227f,228f,542f,542f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillEllipse(sb, 255f,256f,486f,486f);g.DrawEllipse(p, 255f,256f,486f,486f);
        }
    }
}