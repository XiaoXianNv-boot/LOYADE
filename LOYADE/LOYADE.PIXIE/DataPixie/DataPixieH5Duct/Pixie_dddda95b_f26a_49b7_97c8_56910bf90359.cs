using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Duct
{
    public class PIXIE_dddda95b_f26a_49b7_97c8_56910bf90359 : Pixie
    {
        public PIXIE_dddda95b_f26a_49b7_97c8_56910bf90359()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 889f; _h = 970f;
_content = "var arrFillColor = new Array(7); var arrBorderColor = new Array(7); var arrBorderWidth = new Array(7); arrFillColor[0] = '#ccc'; arrFillColor[1] = '#4c4c4c'; arrFillColor[2] = '#4c4c4c'; arrFillColor[3] = '#b2b2b2'; arrFillColor[4] = '#4c4c4c'; arrFillColor[5] = '#4c4c4c'; arrFillColor[6] = '#b2b2b2'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderColor[6] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; arrBorderWidth[6] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(840,383);ctx.lineTo(749,475);ctx.lineTo(840,475);ctx.lineTo(840,927);ctx.lineTo(118,927);ctx.lineTo(28,927);ctx.lineTo(28,475);ctx.lineTo(118,475);ctx.lineTo(524,67);ctx.lineTo(840,383);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(477,88);ctx.lineTo(524,39);ctx.lineTo(515,28);ctx.lineTo(466,77);ctx.lineTo(477,88);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(832,443);ctx.lineTo(882,394);ctx.lineTo(870,385);ctx.lineTo(823,432);ctx.lineTo(832,443);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(474,52);ctx.lineTo(491,37);ctx.lineTo(872,419);ctx.lineTo(857,436);ctx.lineTo(474,52);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(819,457);ctx.lineTo(889,457);ctx.lineTo(889,441);ctx.lineTo(819,441);ctx.lineTo(819,457);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(819,959);ctx.lineTo(889,959);ctx.lineTo(889,944);ctx.lineTo(819,944);ctx.lineTo(819,959);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(842,430);ctx.lineTo(865,430);ctx.lineTo(865,970);ctx.lineTo(842,970);ctx.lineTo(842,430);ctx.fillStyle = arrFillColor[6];ctx.fill();ctx.lineWidth = arrBorderWidth[6];ctx.strokeStyle = arrBorderColor[6];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(840,383));listpt.Add(new Point(749,475));listpt.Add(new Point(840,475));listpt.Add(new Point(840,927));listpt.Add(new Point(118,927));listpt.Add(new Point(28,927));listpt.Add(new Point(28,475));listpt.Add(new Point(118,475));listpt.Add(new Point(524,67));listpt.Add(new Point(840,383));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(477,88));listpt.Add(new Point(524,39));listpt.Add(new Point(515,28));listpt.Add(new Point(466,77));listpt.Add(new Point(477,88));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(832,443));listpt.Add(new Point(882,394));listpt.Add(new Point(870,385));listpt.Add(new Point(823,432));listpt.Add(new Point(832,443));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(474,52));listpt.Add(new Point(491,37));listpt.Add(new Point(872,419));listpt.Add(new Point(857,436));listpt.Add(new Point(474,52));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(819,457));listpt.Add(new Point(889,457));listpt.Add(new Point(889,441));listpt.Add(new Point(819,441));listpt.Add(new Point(819,457));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(819,959));listpt.Add(new Point(889,959));listpt.Add(new Point(889,944));listpt.Add(new Point(819,944));listpt.Add(new Point(819,959));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(842,430));listpt.Add(new Point(865,430));listpt.Add(new Point(865,970));listpt.Add(new Point(842,970));listpt.Add(new Point(842,430));sb = new SolidBrush(_listfillcolor[6]);p = new Pen(Color.Black);p.Width = _listborderwidth[6];p.Color = _listbordercolor[6];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}