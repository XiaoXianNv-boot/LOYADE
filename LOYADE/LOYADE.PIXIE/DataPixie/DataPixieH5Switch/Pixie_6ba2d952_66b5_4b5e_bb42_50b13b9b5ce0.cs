using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Switch
{
    public class PIXIE_6ba2d952_66b5_4b5e_bb42_50b13b9b5ce0 : Pixie
    {
        public PIXIE_6ba2d952_66b5_4b5e_bb42_50b13b9b5ce0()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ff0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 914f; _h = 917f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#e5e5e5'; arrFillColor[1] = '#7f7f7f'; arrFillColor[2] = '#b2b2b2'; arrFillColor[3] = '#000'; arrFillColor[4] = '#ff0'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(318,89);ctx.lineTo(88,318);ctx.lineTo(81,341);ctx.lineTo(81,659);ctx.lineTo(88,680);ctx.lineTo(318,910);ctx.lineTo(339,917);ctx.lineTo(657,917);ctx.lineTo(679,910);ctx.lineTo(909,680);ctx.lineTo(914,659);ctx.lineTo(914,341);ctx.lineTo(909,318);ctx.lineTo(679,89);ctx.lineTo(657,83);ctx.lineTo(339,83);ctx.lineTo(318,89);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(498,499,392,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(554,55);ctx.lineTo(554,138);ctx.lineTo(632,159);ctx.lineTo(704,197);ctx.lineTo(765,249);ctx.lineTo(813,315);ctx.lineTo(847,388);ctx.lineTo(862,467);ctx.lineTo(860,549);ctx.lineTo(840,627);ctx.lineTo(804,698);ctx.lineTo(754,760);ctx.lineTo(690,811);ctx.lineTo(616,844);ctx.lineTo(538,863);ctx.lineTo(459,863);ctx.lineTo(379,844);ctx.lineTo(306,811);ctx.lineTo(243,760);ctx.lineTo(193,698);ctx.lineTo(157,627);ctx.lineTo(136,549);ctx.lineTo(134,467);ctx.lineTo(150,388);ctx.lineTo(183,315);ctx.lineTo(232,249);ctx.lineTo(292,197);ctx.lineTo(365,159);ctx.lineTo(442,138);ctx.lineTo(442,55);ctx.lineTo(554,55);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(498,499,271,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(498,499,242,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(318,89));listpt.Add(new Point(88,318));listpt.Add(new Point(81,341));listpt.Add(new Point(81,659));listpt.Add(new Point(88,680));listpt.Add(new Point(318,910));listpt.Add(new Point(339,917));listpt.Add(new Point(657,917));listpt.Add(new Point(679,910));listpt.Add(new Point(909,680));listpt.Add(new Point(914,659));listpt.Add(new Point(914,341));listpt.Add(new Point(909,318));listpt.Add(new Point(679,89));listpt.Add(new Point(657,83));listpt.Add(new Point(339,83));listpt.Add(new Point(318,89));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 106f,107f,784f,784f);g.DrawEllipse(p, 106f,107f,784f,784f);
listpt = new List<Point>();listpt.Add(new Point(554,55));listpt.Add(new Point(554,138));listpt.Add(new Point(632,159));listpt.Add(new Point(704,197));listpt.Add(new Point(765,249));listpt.Add(new Point(813,315));listpt.Add(new Point(847,388));listpt.Add(new Point(862,467));listpt.Add(new Point(860,549));listpt.Add(new Point(840,627));listpt.Add(new Point(804,698));listpt.Add(new Point(754,760));listpt.Add(new Point(690,811));listpt.Add(new Point(616,844));listpt.Add(new Point(538,863));listpt.Add(new Point(459,863));listpt.Add(new Point(379,844));listpt.Add(new Point(306,811));listpt.Add(new Point(243,760));listpt.Add(new Point(193,698));listpt.Add(new Point(157,627));listpt.Add(new Point(136,549));listpt.Add(new Point(134,467));listpt.Add(new Point(150,388));listpt.Add(new Point(183,315));listpt.Add(new Point(232,249));listpt.Add(new Point(292,197));listpt.Add(new Point(365,159));listpt.Add(new Point(442,138));listpt.Add(new Point(442,55));listpt.Add(new Point(554,55));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillEllipse(sb, 227f,228f,542f,542f);g.DrawEllipse(p, 227f,228f,542f,542f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillEllipse(sb, 256f,257f,484f,484f);g.DrawEllipse(p, 256f,257f,484f,484f);
        }
    }
}