using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WaterWastewater
{
    public class PIXIE_7077f7da_68c2_4bea_9722_9882792d3bd4 : Pixie
    {
        public PIXIE_7077f7da_68c2_4bea_9722_9882792d3bd4()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#d9d9d9"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f2f2f2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#d9d9d9"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#bfbfbf"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 499f;
_content = "var arrFillColor = new Array(7); var arrBorderColor = new Array(7); var arrBorderWidth = new Array(7); arrFillColor[0] = '#d9d9d9'; arrFillColor[1] = '#f2f2f2'; arrFillColor[2] = '#b2b2b2'; arrFillColor[3] = '#fff'; arrFillColor[4] = '#fff'; arrFillColor[5] = '#d9d9d9'; arrFillColor[6] = '#bfbfbf'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderColor[6] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; arrBorderWidth[6] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(955,43);ctx.lineTo(602,82);ctx.lineTo(445,82);ctx.lineTo(92,43);ctx.lineTo(92,411);ctx.lineTo(955,411);ctx.lineTo(955,43);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(538,440);ctx.lineTo(892,499);ctx.lineTo(892,106);ctx.lineTo(538,106);ctx.lineTo(538,440);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(892,106);ctx.lineTo(906,92);ctx.lineTo(906,460);ctx.lineTo(955,411);ctx.lineTo(955,43);ctx.lineTo(970,28);ctx.lineTo(970,420);ctx.lineTo(892,499);ctx.lineTo(892,106);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(92,43);ctx.lineTo(106,28);ctx.lineTo(460,67);ctx.lineTo(617,67);ctx.lineTo(970,28);ctx.lineTo(955,43);ctx.lineTo(602,82);ctx.lineTo(440,82);ctx.lineTo(92,43);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(892,106);ctx.lineTo(906,92);ctx.lineTo(43,92);ctx.lineTo(28,106);ctx.lineTo(892,106);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(381,440);ctx.lineTo(538,440);ctx.lineTo(538,106);ctx.lineTo(381,106);ctx.lineTo(381,440);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,499);ctx.lineTo(381,440);ctx.lineTo(381,106);ctx.lineTo(28,106);ctx.lineTo(28,499);ctx.fillStyle = arrFillColor[6];ctx.fill();ctx.lineWidth = arrBorderWidth[6];ctx.strokeStyle = arrBorderColor[6];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(955,43));listpt.Add(new Point(602,82));listpt.Add(new Point(445,82));listpt.Add(new Point(92,43));listpt.Add(new Point(92,411));listpt.Add(new Point(955,411));listpt.Add(new Point(955,43));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(538,440));listpt.Add(new Point(892,499));listpt.Add(new Point(892,106));listpt.Add(new Point(538,106));listpt.Add(new Point(538,440));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(892,106));listpt.Add(new Point(906,92));listpt.Add(new Point(906,460));listpt.Add(new Point(955,411));listpt.Add(new Point(955,43));listpt.Add(new Point(970,28));listpt.Add(new Point(970,420));listpt.Add(new Point(892,499));listpt.Add(new Point(892,106));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(92,43));listpt.Add(new Point(106,28));listpt.Add(new Point(460,67));listpt.Add(new Point(617,67));listpt.Add(new Point(970,28));listpt.Add(new Point(955,43));listpt.Add(new Point(602,82));listpt.Add(new Point(440,82));listpt.Add(new Point(92,43));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(892,106));listpt.Add(new Point(906,92));listpt.Add(new Point(43,92));listpt.Add(new Point(28,106));listpt.Add(new Point(892,106));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(381,440));listpt.Add(new Point(538,440));listpt.Add(new Point(538,106));listpt.Add(new Point(381,106));listpt.Add(new Point(381,440));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,499));listpt.Add(new Point(381,440));listpt.Add(new Point(381,106));listpt.Add(new Point(28,106));listpt.Add(new Point(28,499));sb = new SolidBrush(_listfillcolor[6]);p = new Pen(Color.Black);p.Width = _listborderwidth[6];p.Color = _listbordercolor[6];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}