using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Architectural
{
    public class PIXIE_6d96f3b5_034f_4073_afe5_0fbbd7480778 : Pixie
    {
        public PIXIE_6d96f3b5_034f_4073_afe5_0fbbd7480778()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#ffff7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#cc0"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 332f; _h = 970f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#ffff7f'; arrFillColor[1] = '#b2b2b2'; arrFillColor[2] = '#e5e5e5'; arrFillColor[3] = '#999'; arrBorderColor[0] = '#cc0'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(44,169);ctx.lineTo(61,177);ctx.lineTo(82,181);ctx.lineTo(103,177);ctx.lineTo(119,169);ctx.lineTo(123,156);ctx.lineTo(40,156);ctx.lineTo(44,169);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(32,152);ctx.lineTo(40,102);ctx.lineTo(57,77);ctx.lineTo(106,77);ctx.lineTo(123,102);ctx.lineTo(131,152);ctx.lineTo(32,152);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,152);ctx.lineTo(28,160);ctx.lineTo(136,160);ctx.lineTo(136,152);ctx.lineTo(28,152);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(67,77);ctx.lineTo(67,28);ctx.lineTo(332,28);ctx.lineTo(332,970);ctx.lineTo(302,970);ctx.lineTo(302,57);ctx.lineTo(96,57);ctx.lineTo(96,77);ctx.lineTo(67,77);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(44,169));listpt.Add(new Point(61,177));listpt.Add(new Point(82,181));listpt.Add(new Point(103,177));listpt.Add(new Point(119,169));listpt.Add(new Point(123,156));listpt.Add(new Point(40,156));listpt.Add(new Point(44,169));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(32,152));listpt.Add(new Point(40,102));listpt.Add(new Point(57,77));listpt.Add(new Point(106,77));listpt.Add(new Point(123,102));listpt.Add(new Point(131,152));listpt.Add(new Point(32,152));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,152));listpt.Add(new Point(28,160));listpt.Add(new Point(136,160));listpt.Add(new Point(136,152));listpt.Add(new Point(28,152));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(67,77));listpt.Add(new Point(67,28));listpt.Add(new Point(332,28));listpt.Add(new Point(332,970));listpt.Add(new Point(302,970));listpt.Add(new Point(302,57));listpt.Add(new Point(96,57));listpt.Add(new Point(96,77));listpt.Add(new Point(67,77));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}