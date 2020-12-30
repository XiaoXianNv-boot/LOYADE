using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5FlowMeter
{
    public class PIXIE_9a4fdcae_7811_4232_8b8f_60fda87d088c : Pixie
    {
        public PIXIE_9a4fdcae_7811_4232_8b8f_60fda87d088c()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 660f; _h = 396f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#7f7f7f'; arrFillColor[1] = '#b2b2b2'; arrFillColor[2] = '#4c4c4c'; arrFillColor[3] = '#999'; arrFillColor[4] = '#b2b2b2'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(655,396);ctx.lineTo(658,369);ctx.lineTo(659,339);ctx.lineTo(660,333);ctx.lineTo(660,328);ctx.lineTo(660,323);ctx.lineTo(659,295);ctx.lineTo(657,265);ctx.lineTo(653,236);ctx.lineTo(646,210);ctx.lineTo(644,204);ctx.lineTo(354,204);ctx.lineTo(347,230);ctx.lineTo(342,258);ctx.lineTo(339,288);ctx.lineTo(339,303);ctx.lineTo(338,311);ctx.lineTo(338,318);ctx.lineTo(339,349);ctx.lineTo(341,378);ctx.lineTo(342,392);ctx.lineTo(343,396);ctx.lineTo(655,396);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(381,184);ctx.lineTo(421,184);ctx.lineTo(421,171);ctx.lineTo(381,171);ctx.lineTo(381,184);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(642,396);ctx.lineTo(643,369);ctx.lineTo(644,339);ctx.lineTo(644,333);ctx.lineTo(644,328);ctx.lineTo(644,323);ctx.lineTo(644,290);ctx.lineTo(641,260);ctx.lineTo(635,231);ctx.lineTo(633,226);ctx.lineTo(631,220);ctx.lineTo(367,220);ctx.lineTo(359,248);ctx.lineTo(355,278);ctx.lineTo(354,297);ctx.lineTo(354,304);ctx.lineTo(354,311);ctx.lineTo(354,339);ctx.lineTo(355,369);ctx.lineTo(356,392);ctx.lineTo(356,396);ctx.lineTo(642,396);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(401,308,20,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(302,184);ctx.lineTo(343,184);ctx.lineTo(343,171);ctx.lineTo(302,171);ctx.lineTo(302,184);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(655,396));listpt.Add(new Point(658,369));listpt.Add(new Point(659,339));listpt.Add(new Point(660,333));listpt.Add(new Point(660,328));listpt.Add(new Point(660,323));listpt.Add(new Point(659,295));listpt.Add(new Point(657,265));listpt.Add(new Point(653,236));listpt.Add(new Point(646,210));listpt.Add(new Point(644,204));listpt.Add(new Point(354,204));listpt.Add(new Point(347,230));listpt.Add(new Point(342,258));listpt.Add(new Point(339,288));listpt.Add(new Point(339,303));listpt.Add(new Point(338,311));listpt.Add(new Point(338,318));listpt.Add(new Point(339,349));listpt.Add(new Point(341,378));listpt.Add(new Point(342,392));listpt.Add(new Point(343,396));listpt.Add(new Point(655,396));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(381,184));listpt.Add(new Point(421,184));listpt.Add(new Point(421,171));listpt.Add(new Point(381,171));listpt.Add(new Point(381,184));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(642,396));listpt.Add(new Point(643,369));listpt.Add(new Point(644,339));listpt.Add(new Point(644,333));listpt.Add(new Point(644,328));listpt.Add(new Point(644,323));listpt.Add(new Point(644,290));listpt.Add(new Point(641,260));listpt.Add(new Point(635,231));listpt.Add(new Point(633,226));listpt.Add(new Point(631,220));listpt.Add(new Point(367,220));listpt.Add(new Point(359,248));listpt.Add(new Point(355,278));listpt.Add(new Point(354,297));listpt.Add(new Point(354,304));listpt.Add(new Point(354,311));listpt.Add(new Point(354,339));listpt.Add(new Point(355,369));listpt.Add(new Point(356,392));listpt.Add(new Point(356,396));listpt.Add(new Point(642,396));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillEllipse(sb, 381f,288f,40f,40f);g.DrawEllipse(p, 381f,288f,40f,40f);
listpt = new List<Point>();listpt.Add(new Point(302,184));listpt.Add(new Point(343,184));listpt.Add(new Point(343,171));listpt.Add(new Point(302,171));listpt.Add(new Point(302,184));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}