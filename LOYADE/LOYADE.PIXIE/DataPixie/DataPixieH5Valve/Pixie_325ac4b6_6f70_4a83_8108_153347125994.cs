using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Valve
{
    public class PIXIE_325ac4b6_6f70_4a83_8108_153347125994 : Pixie
    {
        public PIXIE_325ac4b6_6f70_4a83_8108_153347125994()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 371f; _h = 456f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#7f7f7f'; arrFillColor[1] = '#b2b2b2'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(322,248);ctx.lineTo(322,76);ctx.lineTo(371,146);ctx.lineTo(371,184);ctx.lineTo(322,248);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(71,456);ctx.lineTo(150,188);ctx.lineTo(333,188);ctx.lineTo(333,129);ctx.lineTo(141,129);ctx.lineTo(86,167);ctx.lineTo(54,226);ctx.lineTo(43,312);ctx.lineTo(48,456);ctx.lineTo(71,456);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(322,248));listpt.Add(new Point(322,76));listpt.Add(new Point(371,146));listpt.Add(new Point(371,184));listpt.Add(new Point(322,248));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(71,456));listpt.Add(new Point(150,188));listpt.Add(new Point(333,188));listpt.Add(new Point(333,129));listpt.Add(new Point(141,129));listpt.Add(new Point(86,167));listpt.Add(new Point(54,226));listpt.Add(new Point(43,312));listpt.Add(new Point(48,456));listpt.Add(new Point(71,456));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}