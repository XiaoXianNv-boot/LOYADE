using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Vehicle
{
    public class PIXIE_de3d565c_d1ea_4dea_ba02_41e1d93de679 : Pixie
    {
        public PIXIE_de3d565c_d1ea_4dea_ba02_41e1d93de679()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#fc0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#cff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#cff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 365f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#fc0'; arrFillColor[1] = '#fff'; arrFillColor[2] = '#b2b2b2'; arrFillColor[3] = '#cff'; arrFillColor[4] = '#cff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(58,365);ctx.lineTo(64,335);ctx.lineTo(81,309);ctx.lineTo(107,292);ctx.lineTo(137,286);ctx.lineTo(167,292);ctx.lineTo(194,309);ctx.lineTo(211,335);ctx.lineTo(216,365);ctx.lineTo(295,365);ctx.lineTo(295,28);ctx.lineTo(77,28);ctx.lineTo(98,43);ctx.lineTo(77,186);ctx.lineTo(58,186);ctx.lineTo(37,205);ctx.lineTo(37,326);ctx.lineTo(28,326);ctx.lineTo(28,365);ctx.lineTo(58,365);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(49,290);ctx.lineTo(37,290);ctx.lineTo(37,320);ctx.lineTo(49,320);ctx.lineTo(49,290);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(305,280);ctx.lineTo(970,280);ctx.lineTo(970,122);ctx.lineTo(305,122);ctx.lineTo(305,280);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(58,186);ctx.lineTo(82,28);ctx.lineTo(98,43);ctx.lineTo(77,186);ctx.lineTo(58,186);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(256,147);ctx.lineTo(256,67);ctx.lineTo(137,67);ctx.lineTo(128,147);ctx.lineTo(256,147);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(58,365));listpt.Add(new Point(64,335));listpt.Add(new Point(81,309));listpt.Add(new Point(107,292));listpt.Add(new Point(137,286));listpt.Add(new Point(167,292));listpt.Add(new Point(194,309));listpt.Add(new Point(211,335));listpt.Add(new Point(216,365));listpt.Add(new Point(295,365));listpt.Add(new Point(295,28));listpt.Add(new Point(77,28));listpt.Add(new Point(98,43));listpt.Add(new Point(77,186));listpt.Add(new Point(58,186));listpt.Add(new Point(37,205));listpt.Add(new Point(37,326));listpt.Add(new Point(28,326));listpt.Add(new Point(28,365));listpt.Add(new Point(58,365));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(49,290));listpt.Add(new Point(37,290));listpt.Add(new Point(37,320));listpt.Add(new Point(49,320));listpt.Add(new Point(49,290));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(305,280));listpt.Add(new Point(970,280));listpt.Add(new Point(970,122));listpt.Add(new Point(305,122));listpt.Add(new Point(305,280));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(58,186));listpt.Add(new Point(82,28));listpt.Add(new Point(98,43));listpt.Add(new Point(77,186));listpt.Add(new Point(58,186));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(256,147));listpt.Add(new Point(256,67));listpt.Add(new Point(137,67));listpt.Add(new Point(128,147));listpt.Add(new Point(256,147));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}