using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Architectural
{
    public class PIXIE_fca60d96_c6b8_4de5_b2f4_0da79a8ab237 : Pixie
    {
        public PIXIE_fca60d96_c6b8_4de5_b2f4_0da79a8ab237()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#666"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#666"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 146f; _h = 970f;
_content = "var arrFillColor = new Array(6); var arrBorderColor = new Array(6); var arrBorderWidth = new Array(6); arrFillColor[0] = '#666'; arrFillColor[1] = '#666'; arrFillColor[2] = '#999'; arrFillColor[3] = '#b2b2b2'; arrFillColor[4] = '#ccc'; arrFillColor[5] = '#ccc'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(77,970);ctx.lineTo(77,156);ctx.lineTo(96,156);ctx.lineTo(96,970);ctx.lineTo(77,970);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(77,143);ctx.lineTo(77,156);ctx.lineTo(96,156);ctx.lineTo(96,143);ctx.lineTo(77,143);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(77,146);ctx.lineTo(126,143);ctx.lineTo(141,62);ctx.lineTo(146,62);ctx.lineTo(92,33);ctx.lineTo(92,28);ctx.lineTo(82,28);ctx.lineTo(82,33);ctx.lineTo(28,62);ctx.lineTo(72,62);ctx.lineTo(77,146);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(77,146);ctx.lineTo(72,60);ctx.lineTo(33,62);ctx.lineTo(47,141);ctx.lineTo(77,146);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(79,82);ctx.lineTo(81,76);ctx.lineTo(87,70);ctx.lineTo(95,67);ctx.lineTo(105,66);ctx.lineTo(115,67);ctx.lineTo(123,70);ctx.lineTo(129,76);ctx.lineTo(131,82);ctx.lineTo(121,138);ctx.lineTo(82,141);ctx.lineTo(79,82);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(39,78);ctx.lineTo(40,74);ctx.lineTo(43,70);ctx.lineTo(49,68);ctx.lineTo(54,67);ctx.lineTo(60,68);ctx.lineTo(65,70);ctx.lineTo(68,74);ctx.lineTo(69,78);ctx.lineTo(72,141);ctx.lineTo(52,138);ctx.lineTo(39,78);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(77,970));listpt.Add(new Point(77,156));listpt.Add(new Point(96,156));listpt.Add(new Point(96,970));listpt.Add(new Point(77,970));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(77,143));listpt.Add(new Point(77,156));listpt.Add(new Point(96,156));listpt.Add(new Point(96,143));listpt.Add(new Point(77,143));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(77,146));listpt.Add(new Point(126,143));listpt.Add(new Point(141,62));listpt.Add(new Point(146,62));listpt.Add(new Point(92,33));listpt.Add(new Point(92,28));listpt.Add(new Point(82,28));listpt.Add(new Point(82,33));listpt.Add(new Point(28,62));listpt.Add(new Point(72,62));listpt.Add(new Point(77,146));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(77,146));listpt.Add(new Point(72,60));listpt.Add(new Point(33,62));listpt.Add(new Point(47,141));listpt.Add(new Point(77,146));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(79,82));listpt.Add(new Point(81,76));listpt.Add(new Point(87,70));listpt.Add(new Point(95,67));listpt.Add(new Point(105,66));listpt.Add(new Point(115,67));listpt.Add(new Point(123,70));listpt.Add(new Point(129,76));listpt.Add(new Point(131,82));listpt.Add(new Point(121,138));listpt.Add(new Point(82,141));listpt.Add(new Point(79,82));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(39,78));listpt.Add(new Point(40,74));listpt.Add(new Point(43,70));listpt.Add(new Point(49,68));listpt.Add(new Point(54,67));listpt.Add(new Point(60,68));listpt.Add(new Point(65,70));listpt.Add(new Point(68,74));listpt.Add(new Point(69,78));listpt.Add(new Point(72,141));listpt.Add(new Point(52,138));listpt.Add(new Point(39,78));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}