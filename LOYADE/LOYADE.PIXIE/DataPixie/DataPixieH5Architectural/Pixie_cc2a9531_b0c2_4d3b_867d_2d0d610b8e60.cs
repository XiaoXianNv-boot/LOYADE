using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Architectural
{
    public class PIXIE_cc2a9531_b0c2_4d3b_867d_2d0d610b8e60 : Pixie
    {
        public PIXIE_cc2a9531_b0c2_4d3b_867d_2d0d610b8e60()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#f2f2f2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f00"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 650f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#f2f2f2'; arrFillColor[1] = '#f00'; arrFillColor[2] = '#fff'; arrFillColor[3] = '#ccc'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,47);ctx.lineTo(933,47);ctx.lineTo(933,650);ctx.lineTo(28,650);ctx.lineTo(28,47);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(65,84);ctx.lineTo(895,84);ctx.lineTo(895,612);ctx.lineTo(65,612);ctx.lineTo(65,84);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,47);ctx.lineTo(65,28);ctx.lineTo(970,28);ctx.lineTo(933,47);ctx.lineTo(28,47);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(933,650);ctx.lineTo(970,631);ctx.lineTo(970,28);ctx.lineTo(933,47);ctx.lineTo(933,650);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,47));listpt.Add(new Point(933,47));listpt.Add(new Point(933,650));listpt.Add(new Point(28,650));listpt.Add(new Point(28,47));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(65,84));listpt.Add(new Point(895,84));listpt.Add(new Point(895,612));listpt.Add(new Point(65,612));listpt.Add(new Point(65,84));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,47));listpt.Add(new Point(65,28));listpt.Add(new Point(970,28));listpt.Add(new Point(933,47));listpt.Add(new Point(28,47));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(933,650));listpt.Add(new Point(970,631));listpt.Add(new Point(970,28));listpt.Add(new Point(933,47));listpt.Add(new Point(933,650));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}