using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5AirCondition
{
    public class PIXIE_c334babc_2286_4b7b_a50f_58681368774c : Pixie
    {
        public PIXIE_c334babc_2286_4b7b_a50f_58681368774c()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 168f; _h = 257f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrFillColor[2] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(21,95);ctx.lineTo(168,95);ctx.lineTo(168,257);ctx.lineTo(21,257);ctx.lineTo(21,95);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(94,95,73,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(142,42);ctx.lineTo(137,39);ctx.lineTo(132,36);ctx.lineTo(126,34);ctx.lineTo(116,31);ctx.lineTo(107,29);ctx.lineTo(102,29);ctx.lineTo(87,31);ctx.lineTo(73,35);ctx.lineTo(61,42);ctx.lineTo(50,51);ctx.lineTo(41,62);ctx.lineTo(35,74);ctx.lineTo(30,88);ctx.lineTo(29,102);ctx.lineTo(30,112);ctx.lineTo(30,117);ctx.lineTo(33,127);ctx.lineTo(35,133);ctx.lineTo(37,138);ctx.lineTo(40,144);ctx.lineTo(36,140);ctx.lineTo(33,135);ctx.lineTo(30,129);ctx.lineTo(27,123);ctx.lineTo(24,117);ctx.lineTo(23,110);ctx.lineTo(21,103);ctx.lineTo(21,96);ctx.lineTo(23,81);ctx.lineTo(27,67);ctx.lineTo(34,54);ctx.lineTo(43,43);ctx.lineTo(54,34);ctx.lineTo(66,28);ctx.lineTo(80,23);ctx.lineTo(94,22);ctx.lineTo(101,22);ctx.lineTo(108,23);ctx.lineTo(115,25);ctx.lineTo(122,27);ctx.lineTo(128,30);ctx.lineTo(134,33);ctx.lineTo(138,37);ctx.lineTo(142,42);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(21,95));listpt.Add(new Point(168,95));listpt.Add(new Point(168,257));listpt.Add(new Point(21,257));listpt.Add(new Point(21,95));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 21f,22f,146f,146f);g.DrawEllipse(p, 21f,22f,146f,146f);
listpt = new List<Point>();listpt.Add(new Point(142,42));listpt.Add(new Point(137,39));listpt.Add(new Point(132,36));listpt.Add(new Point(126,34));listpt.Add(new Point(116,31));listpt.Add(new Point(107,29));listpt.Add(new Point(102,29));listpt.Add(new Point(87,31));listpt.Add(new Point(73,35));listpt.Add(new Point(61,42));listpt.Add(new Point(50,51));listpt.Add(new Point(41,62));listpt.Add(new Point(35,74));listpt.Add(new Point(30,88));listpt.Add(new Point(29,102));listpt.Add(new Point(30,112));listpt.Add(new Point(30,117));listpt.Add(new Point(33,127));listpt.Add(new Point(35,133));listpt.Add(new Point(37,138));listpt.Add(new Point(40,144));listpt.Add(new Point(36,140));listpt.Add(new Point(33,135));listpt.Add(new Point(30,129));listpt.Add(new Point(27,123));listpt.Add(new Point(24,117));listpt.Add(new Point(23,110));listpt.Add(new Point(21,103));listpt.Add(new Point(21,96));listpt.Add(new Point(23,81));listpt.Add(new Point(27,67));listpt.Add(new Point(34,54));listpt.Add(new Point(43,43));listpt.Add(new Point(54,34));listpt.Add(new Point(66,28));listpt.Add(new Point(80,23));listpt.Add(new Point(94,22));listpt.Add(new Point(101,22));listpt.Add(new Point(108,23));listpt.Add(new Point(115,25));listpt.Add(new Point(122,27));listpt.Add(new Point(128,30));listpt.Add(new Point(134,33));listpt.Add(new Point(138,37));listpt.Add(new Point(142,42));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}