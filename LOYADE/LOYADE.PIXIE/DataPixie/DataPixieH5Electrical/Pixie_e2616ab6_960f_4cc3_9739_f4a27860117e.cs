using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Electrical
{
    public class PIXIE_e2616ab6_960f_4cc3_9739_f4a27860117e : Pixie
    {
        public PIXIE_e2616ab6_960f_4cc3_9739_f4a27860117e()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 160f; _h = 58f;
_content = "var arrFillColor = new Array(6); var arrBorderColor = new Array(6); var arrBorderWidth = new Array(6); arrFillColor[0] = '#fff'; arrFillColor[1] = '#fff'; arrFillColor[2] = '#fff'; arrFillColor[3] = '#fff'; arrFillColor[4] = '#fff'; arrFillColor[5] = '#fff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(76,16);ctx.lineTo(77,19);ctx.lineTo(81,20);ctx.lineTo(84,19);ctx.lineTo(85,16);ctx.lineTo(84,12);ctx.lineTo(81,11);ctx.lineTo(77,12);ctx.lineTo(76,16);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(114,16);ctx.lineTo(115,19);ctx.lineTo(118,20);ctx.lineTo(122,19);ctx.lineTo(123,16);ctx.lineTo(122,12);ctx.lineTo(118,11);ctx.lineTo(115,12);ctx.lineTo(114,16);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(151,16);ctx.lineTo(152,19);ctx.lineTo(156,20);ctx.lineTo(159,19);ctx.lineTo(160,16);ctx.lineTo(159,12);ctx.lineTo(156,11);ctx.lineTo(152,12);ctx.lineTo(151,16);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(76,53);ctx.lineTo(77,57);ctx.lineTo(81,58);ctx.lineTo(84,57);ctx.lineTo(85,53);ctx.lineTo(84,50);ctx.lineTo(81,49);ctx.lineTo(77,50);ctx.lineTo(76,53);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(114,53);ctx.lineTo(115,57);ctx.lineTo(118,58);ctx.lineTo(122,57);ctx.lineTo(123,53);ctx.lineTo(122,50);ctx.lineTo(118,49);ctx.lineTo(115,50);ctx.lineTo(114,53);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(151,53);ctx.lineTo(152,57);ctx.lineTo(156,58);ctx.lineTo(159,57);ctx.lineTo(160,53);ctx.lineTo(159,50);ctx.lineTo(156,49);ctx.lineTo(152,50);ctx.lineTo(151,53);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(76,16));listpt.Add(new Point(77,19));listpt.Add(new Point(81,20));listpt.Add(new Point(84,19));listpt.Add(new Point(85,16));listpt.Add(new Point(84,12));listpt.Add(new Point(81,11));listpt.Add(new Point(77,12));listpt.Add(new Point(76,16));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(114,16));listpt.Add(new Point(115,19));listpt.Add(new Point(118,20));listpt.Add(new Point(122,19));listpt.Add(new Point(123,16));listpt.Add(new Point(122,12));listpt.Add(new Point(118,11));listpt.Add(new Point(115,12));listpt.Add(new Point(114,16));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(151,16));listpt.Add(new Point(152,19));listpt.Add(new Point(156,20));listpt.Add(new Point(159,19));listpt.Add(new Point(160,16));listpt.Add(new Point(159,12));listpt.Add(new Point(156,11));listpt.Add(new Point(152,12));listpt.Add(new Point(151,16));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(76,53));listpt.Add(new Point(77,57));listpt.Add(new Point(81,58));listpt.Add(new Point(84,57));listpt.Add(new Point(85,53));listpt.Add(new Point(84,50));listpt.Add(new Point(81,49));listpt.Add(new Point(77,50));listpt.Add(new Point(76,53));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(114,53));listpt.Add(new Point(115,57));listpt.Add(new Point(118,58));listpt.Add(new Point(122,57));listpt.Add(new Point(123,53));listpt.Add(new Point(122,50));listpt.Add(new Point(118,49));listpt.Add(new Point(115,50));listpt.Add(new Point(114,53));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(151,53));listpt.Add(new Point(152,57));listpt.Add(new Point(156,58));listpt.Add(new Point(159,57));listpt.Add(new Point(160,53));listpt.Add(new Point(159,50));listpt.Add(new Point(156,49));listpt.Add(new Point(152,50));listpt.Add(new Point(151,53));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}