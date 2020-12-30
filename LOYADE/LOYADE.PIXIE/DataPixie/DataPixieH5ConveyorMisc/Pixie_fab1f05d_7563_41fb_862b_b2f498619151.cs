using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorMisc
{
    public class PIXIE_fab1f05d_7563_41fb_862b_b2f498619151 : Pixie
    {
        public PIXIE_fab1f05d_7563_41fb_862b_b2f498619151()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#263a59"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ff0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ff0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 264f; _h = 970f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#263a59'; arrFillColor[1] = '#7f7f7f'; arrFillColor[2] = '#7f7f7f'; arrFillColor[3] = '#ff0'; arrFillColor[4] = '#ff0'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(264,852);ctx.lineTo(28,852);ctx.lineTo(28,970);ctx.lineTo(264,970);ctx.lineTo(264,852);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(205,440);ctx.lineTo(234,440);ctx.lineTo(234,87);ctx.lineTo(205,87);ctx.lineTo(205,440);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(57,440);ctx.lineTo(87,440);ctx.lineTo(87,87);ctx.lineTo(57,87);ctx.lineTo(57,440);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(263,87);ctx.lineTo(28,87);ctx.lineTo(28,28);ctx.lineTo(263,28);ctx.lineTo(263,87);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(263,499);ctx.lineTo(28,499);ctx.lineTo(28,440);ctx.lineTo(263,440);ctx.lineTo(263,499);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(264,852));listpt.Add(new Point(28,852));listpt.Add(new Point(28,970));listpt.Add(new Point(264,970));listpt.Add(new Point(264,852));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(205,440));listpt.Add(new Point(234,440));listpt.Add(new Point(234,87));listpt.Add(new Point(205,87));listpt.Add(new Point(205,440));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(57,440));listpt.Add(new Point(87,440));listpt.Add(new Point(87,87));listpt.Add(new Point(57,87));listpt.Add(new Point(57,440));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(263,87));listpt.Add(new Point(28,87));listpt.Add(new Point(28,28));listpt.Add(new Point(263,28));listpt.Add(new Point(263,87));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(263,499));listpt.Add(new Point(28,499));listpt.Add(new Point(28,440));listpt.Add(new Point(263,440));listpt.Add(new Point(263,499));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}