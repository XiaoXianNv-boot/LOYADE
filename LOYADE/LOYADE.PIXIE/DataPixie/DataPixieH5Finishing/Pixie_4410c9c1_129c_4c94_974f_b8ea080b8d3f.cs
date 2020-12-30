using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Finishing
{
    public class PIXIE_4410c9c1_129c_4c94_974f_b8ea080b8d3f : Pixie
    {
        public PIXIE_4410c9c1_129c_4c94_974f_b8ea080b8d3f()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 550f; _h = 906f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#e5e5e5'; arrFillColor[1] = '#b2b2b2'; arrFillColor[2] = '#ccc'; arrFillColor[3] = '#b2b2b2'; arrFillColor[4] = '#ccc'; arrBorderColor[0] = '#7f7f7f'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(454,195);ctx.lineTo(441,169);ctx.lineTo(441,156);ctx.lineTo(544,156);ctx.lineTo(544,169);ctx.lineTo(531,195);ctx.lineTo(505,182);ctx.lineTo(480,182);ctx.lineTo(454,195);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(435,893);ctx.lineTo(473,893);ctx.lineTo(473,906);ctx.lineTo(435,906);ctx.lineTo(435,893);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(454,893);ctx.lineTo(467,893);ctx.lineTo(467,840);ctx.lineTo(454,840);ctx.lineTo(454,893);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(550,893);ctx.lineTo(512,893);ctx.lineTo(512,906);ctx.lineTo(550,906);ctx.lineTo(550,893);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(531,893);ctx.lineTo(518,893);ctx.lineTo(518,840);ctx.lineTo(531,840);ctx.lineTo(531,893);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(454,195));listpt.Add(new Point(441,169));listpt.Add(new Point(441,156));listpt.Add(new Point(544,156));listpt.Add(new Point(544,169));listpt.Add(new Point(531,195));listpt.Add(new Point(505,182));listpt.Add(new Point(480,182));listpt.Add(new Point(454,195));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(435,893));listpt.Add(new Point(473,893));listpt.Add(new Point(473,906));listpt.Add(new Point(435,906));listpt.Add(new Point(435,893));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(454,893));listpt.Add(new Point(467,893));listpt.Add(new Point(467,840));listpt.Add(new Point(454,840));listpt.Add(new Point(454,893));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(550,893));listpt.Add(new Point(512,893));listpt.Add(new Point(512,906));listpt.Add(new Point(550,906));listpt.Add(new Point(550,893));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(531,893));listpt.Add(new Point(518,893));listpt.Add(new Point(518,840));listpt.Add(new Point(531,840));listpt.Add(new Point(531,893));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}