using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Chemical
{
    public class PIXIE_8f87d41d_a1ab_4c6b_933d_0489b7aca8b8 : Pixie
    {
        public PIXIE_8f87d41d_a1ab_4c6b_933d_0489b7aca8b8()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#666"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 182f; _h = 794f;
_content = "var arrFillColor = new Array(6); var arrBorderColor = new Array(6); var arrBorderWidth = new Array(6); arrFillColor[0] = '#666'; arrFillColor[1] = '#e5e5e5'; arrFillColor[2] = '#e5e5e5'; arrFillColor[3] = '#999'; arrFillColor[4] = '#999'; arrFillColor[5] = '#999'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(76,111);ctx.lineTo(182,111);ctx.lineTo(182,120);ctx.lineTo(76,120);ctx.lineTo(76,111);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(164,120);ctx.lineTo(173,120);ctx.lineTo(173,147);ctx.lineTo(164,147);ctx.lineTo(164,120);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(85,120);ctx.lineTo(94,120);ctx.lineTo(94,147);ctx.lineTo(85,147);ctx.lineTo(85,120);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,243);ctx.lineTo(76,243);ctx.lineTo(76,257);ctx.lineTo(28,257);ctx.lineTo(28,243);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,459);ctx.lineTo(76,459);ctx.lineTo(76,473);ctx.lineTo(28,473);ctx.lineTo(28,459);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,781);ctx.lineTo(76,781);ctx.lineTo(76,794);ctx.lineTo(28,794);ctx.lineTo(28,781);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(76,111));listpt.Add(new Point(182,111));listpt.Add(new Point(182,120));listpt.Add(new Point(76,120));listpt.Add(new Point(76,111));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(164,120));listpt.Add(new Point(173,120));listpt.Add(new Point(173,147));listpt.Add(new Point(164,147));listpt.Add(new Point(164,120));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(85,120));listpt.Add(new Point(94,120));listpt.Add(new Point(94,147));listpt.Add(new Point(85,147));listpt.Add(new Point(85,120));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,243));listpt.Add(new Point(76,243));listpt.Add(new Point(76,257));listpt.Add(new Point(28,257));listpt.Add(new Point(28,243));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,459));listpt.Add(new Point(76,459));listpt.Add(new Point(76,473));listpt.Add(new Point(28,473));listpt.Add(new Point(28,459));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,781));listpt.Add(new Point(76,781));listpt.Add(new Point(76,794));listpt.Add(new Point(28,794));listpt.Add(new Point(28,781));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}