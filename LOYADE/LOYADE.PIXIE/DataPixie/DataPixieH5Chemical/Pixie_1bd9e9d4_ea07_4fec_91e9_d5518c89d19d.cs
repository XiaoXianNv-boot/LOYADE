using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Chemical
{
    public class PIXIE_1bd9e9d4_ea07_4fec_91e9_d5518c89d19d : Pixie
    {
        public PIXIE_1bd9e9d4_ea07_4fec_91e9_d5518c89d19d()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#8c8c8c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 498f; _h = 420f;
_content = "var arrFillColor = new Array(7); var arrBorderColor = new Array(7); var arrBorderWidth = new Array(7); arrFillColor[0] = '#000'; arrFillColor[1] = '#000'; arrFillColor[2] = '#7f7f7f'; arrFillColor[3] = '#8c8c8c'; arrFillColor[4] = '#000'; arrFillColor[5] = '#4c4c4c'; arrFillColor[6] = '#4c4c4c'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderColor[6] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; arrBorderWidth[6] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(403,214);ctx.lineTo(298,361);ctx.lineTo(284,361);ctx.lineTo(389,214);ctx.lineTo(403,214);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(123,214);ctx.lineTo(228,361);ctx.lineTo(242,361);ctx.lineTo(137,214);ctx.lineTo(123,214);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(37,164);ctx.lineTo(37,28);ctx.lineTo(489,28);ctx.lineTo(489,164);ctx.lineTo(479,164);ctx.lineTo(479,37);ctx.lineTo(47,37);ctx.lineTo(47,89);ctx.lineTo(479,89);ctx.lineTo(479,98);ctx.lineTo(47,98);ctx.lineTo(47,164);ctx.lineTo(37,164);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,164);ctx.lineTo(498,164);ctx.lineTo(498,194);ctx.lineTo(28,194);ctx.lineTo(28,164);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(67,194);ctx.lineTo(459,194);ctx.lineTo(459,213);ctx.lineTo(67,213);ctx.lineTo(67,194);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(459,214);ctx.lineTo(312,420);ctx.lineTo(292,420);ctx.lineTo(439,214);ctx.lineTo(459,214);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(66,214);ctx.lineTo(214,420);ctx.lineTo(233,420);ctx.lineTo(86,214);ctx.lineTo(66,214);ctx.fillStyle = arrFillColor[6];ctx.fill();ctx.lineWidth = arrBorderWidth[6];ctx.strokeStyle = arrBorderColor[6];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(403,214));listpt.Add(new Point(298,361));listpt.Add(new Point(284,361));listpt.Add(new Point(389,214));listpt.Add(new Point(403,214));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(123,214));listpt.Add(new Point(228,361));listpt.Add(new Point(242,361));listpt.Add(new Point(137,214));listpt.Add(new Point(123,214));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(37,164));listpt.Add(new Point(37,28));listpt.Add(new Point(489,28));listpt.Add(new Point(489,164));listpt.Add(new Point(479,164));listpt.Add(new Point(479,37));listpt.Add(new Point(47,37));listpt.Add(new Point(47,89));listpt.Add(new Point(479,89));listpt.Add(new Point(479,98));listpt.Add(new Point(47,98));listpt.Add(new Point(47,164));listpt.Add(new Point(37,164));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,164));listpt.Add(new Point(498,164));listpt.Add(new Point(498,194));listpt.Add(new Point(28,194));listpt.Add(new Point(28,164));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(67,194));listpt.Add(new Point(459,194));listpt.Add(new Point(459,213));listpt.Add(new Point(67,213));listpt.Add(new Point(67,194));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(459,214));listpt.Add(new Point(312,420));listpt.Add(new Point(292,420));listpt.Add(new Point(439,214));listpt.Add(new Point(459,214));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(66,214));listpt.Add(new Point(214,420));listpt.Add(new Point(233,420));listpt.Add(new Point(86,214));listpt.Add(new Point(66,214));sb = new SolidBrush(_listfillcolor[6]);p = new Pen(Color.Black);p.Width = _listborderwidth[6];p.Color = _listbordercolor[6];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}