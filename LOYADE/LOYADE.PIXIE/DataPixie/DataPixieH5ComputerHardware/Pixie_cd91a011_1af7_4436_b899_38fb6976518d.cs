using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ComputerHardware
{
    public class PIXIE_cd91a011_1af7_4436_b899_38fb6976518d : Pixie
    {
        public PIXIE_cd91a011_1af7_4436_b899_38fb6976518d()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#333"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f00"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));
_w = 970f; _h = 970f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#333'; arrFillColor[1] = '#000'; arrFillColor[2] = '#000'; arrFillColor[3] = '#f00'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#7f7f7f'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,676);ctx.lineTo(35,649);ctx.lineTo(55,628);ctx.lineTo(81,618);ctx.lineTo(86,618);ctx.lineTo(112,618);ctx.lineTo(912,618);ctx.lineTo(938,625);ctx.lineTo(959,645);ctx.lineTo(970,671);ctx.lineTo(970,676);ctx.lineTo(970,684);ctx.lineTo(970,912);ctx.lineTo(963,941);ctx.lineTo(943,961);ctx.lineTo(917,970);ctx.lineTo(912,970);ctx.lineTo(886,970);ctx.lineTo(86,970);ctx.lineTo(60,963);ctx.lineTo(39,943);ctx.lineTo(28,917);ctx.lineTo(28,912);ctx.lineTo(28,904);ctx.lineTo(28,676);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(750,618);ctx.lineTo(750,484);ctx.lineTo(765,469);ctx.lineTo(765,116);ctx.lineTo(757,101);ctx.lineTo(757,43);ctx.lineTo(765,28);ctx.lineTo(793,28);ctx.lineTo(801,43);ctx.lineTo(801,101);ctx.lineTo(793,116);ctx.lineTo(793,469);ctx.lineTo(808,484);ctx.lineTo(808,618);ctx.lineTo(750,618);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(50,691);ctx.lineTo(61,663);ctx.lineTo(80,646);ctx.lineTo(100,639);ctx.lineTo(105,639);ctx.lineTo(129,639);ctx.lineTo(891,639);ctx.lineTo(917,646);ctx.lineTo(937,663);ctx.lineTo(947,686);ctx.lineTo(948,691);ctx.lineTo(948,698);ctx.lineTo(948,897);ctx.lineTo(940,923);ctx.lineTo(917,942);ctx.lineTo(896,947);ctx.lineTo(891,948);ctx.lineTo(867,948);ctx.lineTo(105,948);ctx.lineTo(76,939);ctx.lineTo(55,916);ctx.lineTo(51,902);ctx.lineTo(50,897);ctx.lineTo(50,890);ctx.lineTo(50,691);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(793,676,15,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(794,675,21,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,676));listpt.Add(new Point(35,649));listpt.Add(new Point(55,628));listpt.Add(new Point(81,618));listpt.Add(new Point(86,618));listpt.Add(new Point(112,618));listpt.Add(new Point(912,618));listpt.Add(new Point(938,625));listpt.Add(new Point(959,645));listpt.Add(new Point(970,671));listpt.Add(new Point(970,676));listpt.Add(new Point(970,684));listpt.Add(new Point(970,912));listpt.Add(new Point(963,941));listpt.Add(new Point(943,961));listpt.Add(new Point(917,970));listpt.Add(new Point(912,970));listpt.Add(new Point(886,970));listpt.Add(new Point(86,970));listpt.Add(new Point(60,963));listpt.Add(new Point(39,943));listpt.Add(new Point(28,917));listpt.Add(new Point(28,912));listpt.Add(new Point(28,904));listpt.Add(new Point(28,676));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(750,618));listpt.Add(new Point(750,484));listpt.Add(new Point(765,469));listpt.Add(new Point(765,116));listpt.Add(new Point(757,101));listpt.Add(new Point(757,43));listpt.Add(new Point(765,28));listpt.Add(new Point(793,28));listpt.Add(new Point(801,43));listpt.Add(new Point(801,101));listpt.Add(new Point(793,116));listpt.Add(new Point(793,469));listpt.Add(new Point(808,484));listpt.Add(new Point(808,618));listpt.Add(new Point(750,618));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(50,691));listpt.Add(new Point(61,663));listpt.Add(new Point(80,646));listpt.Add(new Point(100,639));listpt.Add(new Point(105,639));listpt.Add(new Point(129,639));listpt.Add(new Point(891,639));listpt.Add(new Point(917,646));listpt.Add(new Point(937,663));listpt.Add(new Point(947,686));listpt.Add(new Point(948,691));listpt.Add(new Point(948,698));listpt.Add(new Point(948,897));listpt.Add(new Point(940,923));listpt.Add(new Point(917,942));listpt.Add(new Point(896,947));listpt.Add(new Point(891,948));listpt.Add(new Point(867,948));listpt.Add(new Point(105,948));listpt.Add(new Point(76,939));listpt.Add(new Point(55,916));listpt.Add(new Point(51,902));listpt.Add(new Point(50,897));listpt.Add(new Point(50,890));listpt.Add(new Point(50,691));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillEllipse(sb, 778f,661f,30f,30f);g.DrawEllipse(p, 778f,661f,30f,30f);
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.DrawEllipse(p, 773f,654f,42f,42f);
        }
    }
}