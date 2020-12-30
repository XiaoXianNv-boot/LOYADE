using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Architectural
{
    public class PIXIE_42938ce7_ebbd_4c33_8c51_a8305f85a53b : Pixie
    {
        public PIXIE_42938ce7_ebbd_4c33_8c51_a8305f85a53b()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#666"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fffff7"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 342f; _h = 970f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#666'; arrFillColor[1] = '#fffff7'; arrFillColor[2] = '#7f7f7f'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,970);ctx.lineTo(28,184);ctx.lineTo(42,184);ctx.lineTo(42,970);ctx.lineTo(28,970);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(294,57);ctx.lineTo(295,61);ctx.lineTo(298,62);ctx.lineTo(334,62);ctx.lineTo(338,61);ctx.lineTo(339,51);ctx.lineTo(294,57);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(260,54);ctx.lineTo(260,36);ctx.lineTo(263,33);ctx.lineTo(294,29);ctx.lineTo(318,28);ctx.lineTo(339,28);ctx.lineTo(342,30);ctx.lineTo(342,49);ctx.lineTo(340,51);ctx.lineTo(324,54);ctx.lineTo(300,57);ctx.lineTo(263,57);ctx.lineTo(260,54);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,970));listpt.Add(new Point(28,184));listpt.Add(new Point(42,184));listpt.Add(new Point(42,970));listpt.Add(new Point(28,970));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(294,57));listpt.Add(new Point(295,61));listpt.Add(new Point(298,62));listpt.Add(new Point(334,62));listpt.Add(new Point(338,61));listpt.Add(new Point(339,51));listpt.Add(new Point(294,57));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(260,54));listpt.Add(new Point(260,36));listpt.Add(new Point(263,33));listpt.Add(new Point(294,29));listpt.Add(new Point(318,28));listpt.Add(new Point(339,28));listpt.Add(new Point(342,30));listpt.Add(new Point(342,49));listpt.Add(new Point(340,51));listpt.Add(new Point(324,54));listpt.Add(new Point(300,57));listpt.Add(new Point(263,57));listpt.Add(new Point(260,54));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}