using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorBelt
{
    public class PIXIE_ec932941_9968_4751_a002_499abc5a9fdc : Pixie
    {
        public PIXIE_ec932941_9968_4751_a002_499abc5a9fdc()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#c0c0c0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#c0c0c0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 578f; _h = 970f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#000'; arrFillColor[1] = '#7f7f7f'; arrFillColor[2] = '#c0c0c0'; arrFillColor[3] = '#c0c0c0'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(48,970);ctx.lineTo(48,28);ctx.lineTo(558,28);ctx.lineTo(558,970);ctx.lineTo(48,970);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(264,970);ctx.lineTo(264,734);ctx.lineTo(558,283);ctx.lineTo(558,970);ctx.lineTo(264,970);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(558,257);ctx.lineTo(558,28);ctx.lineTo(578,28);ctx.lineTo(578,970);ctx.lineTo(558,970);ctx.lineTo(558,293);ctx.lineTo(264,735);ctx.lineTo(264,970);ctx.lineTo(244,970);ctx.lineTo(244,730);ctx.lineTo(558,257);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,970);ctx.lineTo(28,28);ctx.lineTo(48,28);ctx.lineTo(48,970);ctx.lineTo(28,970);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(48,970));listpt.Add(new Point(48,28));listpt.Add(new Point(558,28));listpt.Add(new Point(558,970));listpt.Add(new Point(48,970));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(264,970));listpt.Add(new Point(264,734));listpt.Add(new Point(558,283));listpt.Add(new Point(558,970));listpt.Add(new Point(264,970));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(558,257));listpt.Add(new Point(558,28));listpt.Add(new Point(578,28));listpt.Add(new Point(578,970));listpt.Add(new Point(558,970));listpt.Add(new Point(558,293));listpt.Add(new Point(264,735));listpt.Add(new Point(264,970));listpt.Add(new Point(244,970));listpt.Add(new Point(244,730));listpt.Add(new Point(558,257));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,970));listpt.Add(new Point(28,28));listpt.Add(new Point(48,28));listpt.Add(new Point(48,970));listpt.Add(new Point(28,970));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}