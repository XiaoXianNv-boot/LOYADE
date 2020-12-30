using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEPipe
{
    public class PIXIE_505a9e51_c3a9_4fa9_9355_f0014a75e29e : Pixie
    {
        public PIXIE_505a9e51_c3a9_4fa9_9355_f0014a75e29e()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 656f; _h = 970f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(656,852);ctx.lineTo(646,882);ctx.lineTo(625,904);ctx.lineTo(602,918);ctx.lineTo(574,932);ctx.lineTo(542,943);ctx.lineTo(505,953);ctx.lineTo(478,959);ctx.lineTo(450,963);ctx.lineTo(420,966);ctx.lineTo(390,969);ctx.lineTo(374,970);ctx.lineTo(358,970);ctx.lineTo(342,970);ctx.lineTo(310,970);ctx.lineTo(279,968);ctx.lineTo(249,965);ctx.lineTo(220,961);ctx.lineTo(192,956);ctx.lineTo(166,950);ctx.lineTo(131,940);ctx.lineTo(100,927);ctx.lineTo(73,913);ctx.lineTo(53,898);ctx.lineTo(34,876);ctx.lineTo(28,858);ctx.lineTo(28,852);ctx.lineTo(28,28);ctx.lineTo(656,28);ctx.lineTo(656,852);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(656,852));listpt.Add(new Point(646,882));listpt.Add(new Point(625,904));listpt.Add(new Point(602,918));listpt.Add(new Point(574,932));listpt.Add(new Point(542,943));listpt.Add(new Point(505,953));listpt.Add(new Point(478,959));listpt.Add(new Point(450,963));listpt.Add(new Point(420,966));listpt.Add(new Point(390,969));listpt.Add(new Point(374,970));listpt.Add(new Point(358,970));listpt.Add(new Point(342,970));listpt.Add(new Point(310,970));listpt.Add(new Point(279,968));listpt.Add(new Point(249,965));listpt.Add(new Point(220,961));listpt.Add(new Point(192,956));listpt.Add(new Point(166,950));listpt.Add(new Point(131,940));listpt.Add(new Point(100,927));listpt.Add(new Point(73,913));listpt.Add(new Point(53,898));listpt.Add(new Point(34,876));listpt.Add(new Point(28,858));listpt.Add(new Point(28,852));listpt.Add(new Point(28,28));listpt.Add(new Point(656,28));listpt.Add(new Point(656,852));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}