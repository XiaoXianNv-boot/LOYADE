using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Duct
{
    public class PIXIE_abaa769d_5b92_4d2d_b84d_78ecde43fc81 : Pixie
    {
        public PIXIE_abaa769d_5b92_4d2d_b84d_78ecde43fc81()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 697f; _h = 970f;
_content = "var arrFillColor = new Array(7); var arrBorderColor = new Array(7); var arrBorderWidth = new Array(7); arrFillColor[0] = '#ccc'; arrFillColor[1] = '#4c4c4c'; arrFillColor[2] = '#4c4c4c'; arrFillColor[3] = '#b2b2b2'; arrFillColor[4] = '#4c4c4c'; arrFillColor[5] = '#4c4c4c'; arrFillColor[6] = '#b2b2b2'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderColor[6] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; arrBorderWidth[6] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(130,254);ctx.lineTo(294,86);ctx.lineTo(637,429);ctx.lineTo(569,497);ctx.lineTo(637,567);ctx.lineTo(296,908);ctx.lineTo(226,840);ctx.lineTo(130,738);ctx.lineTo(28,738);ctx.lineTo(30,256);ctx.lineTo(130,254);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(686,409);ctx.lineTo(633,461);ctx.lineTo(644,473);ctx.lineTo(695,420);ctx.lineTo(686,409);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(303,28);ctx.lineTo(252,79);ctx.lineTo(262,90);ctx.lineTo(314,39);ctx.lineTo(303,28);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(687,446);ctx.lineTo(671,463);ctx.lineTo(260,52);ctx.lineTo(277,35);ctx.lineTo(687,446);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(635,537);ctx.lineTo(686,589);ctx.lineTo(697,578);ctx.lineTo(646,525);ctx.lineTo(635,537);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(252,919);ctx.lineTo(305,970);ctx.lineTo(316,959);ctx.lineTo(263,908);ctx.lineTo(252,919);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(671,533);ctx.lineTo(689,552);ctx.lineTo(278,961);ctx.lineTo(262,944);ctx.lineTo(671,533);ctx.fillStyle = arrFillColor[6];ctx.fill();ctx.lineWidth = arrBorderWidth[6];ctx.strokeStyle = arrBorderColor[6];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(130,254));listpt.Add(new Point(294,86));listpt.Add(new Point(637,429));listpt.Add(new Point(569,497));listpt.Add(new Point(637,567));listpt.Add(new Point(296,908));listpt.Add(new Point(226,840));listpt.Add(new Point(130,738));listpt.Add(new Point(28,738));listpt.Add(new Point(30,256));listpt.Add(new Point(130,254));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(686,409));listpt.Add(new Point(633,461));listpt.Add(new Point(644,473));listpt.Add(new Point(695,420));listpt.Add(new Point(686,409));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(303,28));listpt.Add(new Point(252,79));listpt.Add(new Point(262,90));listpt.Add(new Point(314,39));listpt.Add(new Point(303,28));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(687,446));listpt.Add(new Point(671,463));listpt.Add(new Point(260,52));listpt.Add(new Point(277,35));listpt.Add(new Point(687,446));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(635,537));listpt.Add(new Point(686,589));listpt.Add(new Point(697,578));listpt.Add(new Point(646,525));listpt.Add(new Point(635,537));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(252,919));listpt.Add(new Point(305,970));listpt.Add(new Point(316,959));listpt.Add(new Point(263,908));listpt.Add(new Point(252,919));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(671,533));listpt.Add(new Point(689,552));listpt.Add(new Point(278,961));listpt.Add(new Point(262,944));listpt.Add(new Point(671,533));sb = new SolidBrush(_listfillcolor[6]);p = new Pen(Color.Black);p.Width = _listborderwidth[6];p.Color = _listbordercolor[6];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}