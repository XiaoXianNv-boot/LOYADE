using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ComputerHardware
{
    public class PIXIE_fca2dc4c_2570_47c6_964d_ade4227979b5 : Pixie
    {
        public PIXIE_fca2dc4c_2570_47c6_964d_ade4227979b5()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#00f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#00f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#00f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#00f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 429f; _h = 970f;
_content = "var arrFillColor = new Array(8); var arrBorderColor = new Array(8); var arrBorderWidth = new Array(8); arrFillColor[0] = '#fff'; arrFillColor[1] = '#fff'; arrFillColor[2] = '#fff'; arrFillColor[3] = '#00f'; arrFillColor[4] = '#00f'; arrFillColor[5] = '#00f'; arrFillColor[6] = '#00f'; arrFillColor[7] = '#fff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderColor[6] = '#000'; arrBorderColor[7] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; arrBorderWidth[6] = '2'; arrBorderWidth[7] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,173);ctx.lineTo(343,173);ctx.lineTo(343,970);ctx.lineTo(28,970);ctx.lineTo(28,173);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(343,970);ctx.lineTo(429,825);ctx.lineTo(429,28);ctx.lineTo(114,28);ctx.lineTo(28,173);ctx.lineTo(343,173);ctx.lineTo(343,970);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(45,910);ctx.lineTo(45,532);ctx.lineTo(45,405);ctx.lineTo(45,277);ctx.lineTo(45,210);ctx.lineTo(45,188);ctx.lineTo(282,188);ctx.lineTo(282,210);ctx.lineTo(282,277);ctx.lineTo(282,405);ctx.lineTo(282,532);ctx.lineTo(282,910);ctx.lineTo(45,910);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(200,247);ctx.lineTo(200,222);ctx.lineTo(265,222);ctx.lineTo(265,247);ctx.lineTo(200,247);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(99,315);ctx.lineTo(99,289);ctx.lineTo(265,289);ctx.lineTo(265,315);ctx.lineTo(99,315);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(99,442);ctx.lineTo(99,417);ctx.lineTo(265,417);ctx.lineTo(265,442);ctx.lineTo(99,442);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(169,570);ctx.lineTo(169,545);ctx.lineTo(265,545);ctx.lineTo(265,570);ctx.lineTo(169,570);ctx.fillStyle = arrFillColor[6];ctx.fill();ctx.lineWidth = arrBorderWidth[6];ctx.strokeStyle = arrBorderColor[6];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(292,324);ctx.lineTo(292,210);ctx.lineTo(292,188);ctx.lineTo(333,188);ctx.lineTo(333,210);ctx.lineTo(333,324);ctx.lineTo(292,324);ctx.fillStyle = arrFillColor[7];ctx.fill();ctx.lineWidth = arrBorderWidth[7];ctx.strokeStyle = arrBorderColor[7];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,173));listpt.Add(new Point(343,173));listpt.Add(new Point(343,970));listpt.Add(new Point(28,970));listpt.Add(new Point(28,173));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(343,970));listpt.Add(new Point(429,825));listpt.Add(new Point(429,28));listpt.Add(new Point(114,28));listpt.Add(new Point(28,173));listpt.Add(new Point(343,173));listpt.Add(new Point(343,970));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(45,910));listpt.Add(new Point(45,532));listpt.Add(new Point(45,405));listpt.Add(new Point(45,277));listpt.Add(new Point(45,210));listpt.Add(new Point(45,188));listpt.Add(new Point(282,188));listpt.Add(new Point(282,210));listpt.Add(new Point(282,277));listpt.Add(new Point(282,405));listpt.Add(new Point(282,532));listpt.Add(new Point(282,910));listpt.Add(new Point(45,910));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(200,247));listpt.Add(new Point(200,222));listpt.Add(new Point(265,222));listpt.Add(new Point(265,247));listpt.Add(new Point(200,247));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(99,315));listpt.Add(new Point(99,289));listpt.Add(new Point(265,289));listpt.Add(new Point(265,315));listpt.Add(new Point(99,315));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(99,442));listpt.Add(new Point(99,417));listpt.Add(new Point(265,417));listpt.Add(new Point(265,442));listpt.Add(new Point(99,442));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(169,570));listpt.Add(new Point(169,545));listpt.Add(new Point(265,545));listpt.Add(new Point(265,570));listpt.Add(new Point(169,570));sb = new SolidBrush(_listfillcolor[6]);p = new Pen(Color.Black);p.Width = _listborderwidth[6];p.Color = _listbordercolor[6];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(292,324));listpt.Add(new Point(292,210));listpt.Add(new Point(292,188));listpt.Add(new Point(333,188));listpt.Add(new Point(333,210));listpt.Add(new Point(333,324));listpt.Add(new Point(292,324));sb = new SolidBrush(_listfillcolor[7]);p = new Pen(Color.Black);p.Width = _listborderwidth[7];p.Color = _listbordercolor[7];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}