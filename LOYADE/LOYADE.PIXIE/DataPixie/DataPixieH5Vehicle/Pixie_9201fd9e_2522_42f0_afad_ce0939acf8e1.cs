using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Vehicle
{
    public class PIXIE_9201fd9e_2522_42f0_afad_ce0939acf8e1 : Pixie
    {
        public PIXIE_9201fd9e_2522_42f0_afad_ce0939acf8e1()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#00f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 876f; _h = 971f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#00f'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(404,581);ctx.lineTo(27,719);ctx.lineTo(27,623);ctx.lineTo(404,384);ctx.lineTo(404,60);ctx.lineTo(417,38);ctx.lineTo(444,27);ctx.lineTo(469,31);ctx.lineTo(490,50);ctx.lineTo(493,66);ctx.lineTo(493,384);ctx.lineTo(876,623);ctx.lineTo(876,719);ctx.lineTo(493,581);ctx.lineTo(493,826);ctx.lineTo(580,892);ctx.lineTo(580,971);ctx.lineTo(448,910);ctx.lineTo(318,971);ctx.lineTo(318,892);ctx.lineTo(404,826);ctx.lineTo(404,581);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(404,581));listpt.Add(new Point(27,719));listpt.Add(new Point(27,623));listpt.Add(new Point(404,384));listpt.Add(new Point(404,60));listpt.Add(new Point(417,38));listpt.Add(new Point(444,27));listpt.Add(new Point(469,31));listpt.Add(new Point(490,50));listpt.Add(new Point(493,66));listpt.Add(new Point(493,384));listpt.Add(new Point(876,623));listpt.Add(new Point(876,719));listpt.Add(new Point(493,581));listpt.Add(new Point(493,826));listpt.Add(new Point(580,892));listpt.Add(new Point(580,971));listpt.Add(new Point(448,910));listpt.Add(new Point(318,971));listpt.Add(new Point(318,892));listpt.Add(new Point(404,826));listpt.Add(new Point(404,581));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}