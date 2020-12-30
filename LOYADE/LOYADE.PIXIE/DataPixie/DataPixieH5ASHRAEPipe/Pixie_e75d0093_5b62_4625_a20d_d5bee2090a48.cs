using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEPipe
{
    public class PIXIE_e75d0093_5b62_4625_a20d_d5bee2090a48 : Pixie
    {
        public PIXIE_e75d0093_5b62_4625_a20d_d5bee2090a48()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#e5b200"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fc0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 549f; _h = 185f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#e5b200'; arrFillColor[1] = '#fc0'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(495,165);ctx.lineTo(505,165);ctx.lineTo(505,185);ctx.lineTo(495,185);ctx.lineTo(495,165);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(451,28);ctx.lineTo(451,165);ctx.lineTo(549,165);ctx.lineTo(549,28);ctx.lineTo(539,28);ctx.lineTo(539,155);ctx.lineTo(461,155);ctx.lineTo(461,28);ctx.lineTo(451,28);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(495,165));listpt.Add(new Point(505,165));listpt.Add(new Point(505,185));listpt.Add(new Point(495,185));listpt.Add(new Point(495,165));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(451,28));listpt.Add(new Point(451,165));listpt.Add(new Point(549,165));listpt.Add(new Point(549,28));listpt.Add(new Point(539,28));listpt.Add(new Point(539,155));listpt.Add(new Point(461,155));listpt.Add(new Point(461,28));listpt.Add(new Point(451,28));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}