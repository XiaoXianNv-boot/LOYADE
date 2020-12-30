using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Switch
{
    public class PIXIE_5fc6a972_cc10_4c8c_9171_989aa705c98b : Pixie
    {
        public PIXIE_5fc6a972_cc10_4c8c_9171_989aa705c98b()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#3c3"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 915f; _h = 916f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#e5e5e5'; arrFillColor[1] = '#7f7f7f'; arrFillColor[2] = '#b2b2b2'; arrFillColor[3] = '#000'; arrFillColor[4] = '#3c3'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(317,90);ctx.lineTo(88,318);ctx.lineTo(82,340);ctx.lineTo(82,659);ctx.lineTo(88,680);ctx.lineTo(317,910);ctx.lineTo(339,916);ctx.lineTo(657,916);ctx.lineTo(679,910);ctx.lineTo(908,680);ctx.lineTo(915,659);ctx.lineTo(915,340);ctx.lineTo(908,318);ctx.lineTo(679,90);ctx.lineTo(657,82);ctx.lineTo(339,82);ctx.lineTo(317,90);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(497,499,392,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(555,55);ctx.lineTo(555,137);ctx.lineTo(632,159);ctx.lineTo(704,197);ctx.lineTo(765,250);ctx.lineTo(813,314);ctx.lineTo(846,388);ctx.lineTo(862,467);ctx.lineTo(861,548);ctx.lineTo(840,626);ctx.lineTo(804,698);ctx.lineTo(753,760);ctx.lineTo(690,810);ctx.lineTo(617,845);ctx.lineTo(538,862);ctx.lineTo(459,862);ctx.lineTo(380,845);ctx.lineTo(305,810);ctx.lineTo(242,760);ctx.lineTo(192,698);ctx.lineTo(156,626);ctx.lineTo(136,548);ctx.lineTo(134,467);ctx.lineTo(150,388);ctx.lineTo(183,314);ctx.lineTo(232,250);ctx.lineTo(292,197);ctx.lineTo(365,159);ctx.lineTo(442,137);ctx.lineTo(442,55);ctx.lineTo(555,55);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(498,499,271,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(498,499,242,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(317,90));listpt.Add(new Point(88,318));listpt.Add(new Point(82,340));listpt.Add(new Point(82,659));listpt.Add(new Point(88,680));listpt.Add(new Point(317,910));listpt.Add(new Point(339,916));listpt.Add(new Point(657,916));listpt.Add(new Point(679,910));listpt.Add(new Point(908,680));listpt.Add(new Point(915,659));listpt.Add(new Point(915,340));listpt.Add(new Point(908,318));listpt.Add(new Point(679,90));listpt.Add(new Point(657,82));listpt.Add(new Point(339,82));listpt.Add(new Point(317,90));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 105f,107f,784f,784f);g.DrawEllipse(p, 105f,107f,784f,784f);
listpt = new List<Point>();listpt.Add(new Point(555,55));listpt.Add(new Point(555,137));listpt.Add(new Point(632,159));listpt.Add(new Point(704,197));listpt.Add(new Point(765,250));listpt.Add(new Point(813,314));listpt.Add(new Point(846,388));listpt.Add(new Point(862,467));listpt.Add(new Point(861,548));listpt.Add(new Point(840,626));listpt.Add(new Point(804,698));listpt.Add(new Point(753,760));listpt.Add(new Point(690,810));listpt.Add(new Point(617,845));listpt.Add(new Point(538,862));listpt.Add(new Point(459,862));listpt.Add(new Point(380,845));listpt.Add(new Point(305,810));listpt.Add(new Point(242,760));listpt.Add(new Point(192,698));listpt.Add(new Point(156,626));listpt.Add(new Point(136,548));listpt.Add(new Point(134,467));listpt.Add(new Point(150,388));listpt.Add(new Point(183,314));listpt.Add(new Point(232,250));listpt.Add(new Point(292,197));listpt.Add(new Point(365,159));listpt.Add(new Point(442,137));listpt.Add(new Point(442,55));listpt.Add(new Point(555,55));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillEllipse(sb, 227f,228f,542f,542f);g.DrawEllipse(p, 227f,228f,542f,542f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillEllipse(sb, 256f,257f,484f,484f);g.DrawEllipse(p, 256f,257f,484f,484f);
        }
    }
}