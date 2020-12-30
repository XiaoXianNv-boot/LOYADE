using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_e56f485b_4061_4501_9384_349f3a99e6d5 : Pixie
    {
        public PIXIE_e56f485b_4061_4501_9384_349f3a99e6d5()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 462f; _h = 313f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(200,13);ctx.lineTo(388,13);ctx.lineTo(408,30);ctx.lineTo(425,50);ctx.lineTo(440,73);ctx.lineTo(451,97);ctx.lineTo(458,123);ctx.lineTo(462,149);ctx.lineTo(462,176);ctx.lineTo(458,203);ctx.lineTo(451,228);ctx.lineTo(440,252);ctx.lineTo(425,275);ctx.lineTo(408,295);ctx.lineTo(388,313);ctx.lineTo(200,313);ctx.lineTo(172,309);ctx.lineTo(144,302);ctx.lineTo(118,291);ctx.lineTo(94,277);ctx.lineTo(71,259);ctx.lineTo(52,238);ctx.lineTo(35,215);ctx.lineTo(22,190);ctx.lineTo(13,163);ctx.lineTo(22,136);ctx.lineTo(35,111);ctx.lineTo(52,87);ctx.lineTo(71,67);ctx.lineTo(94,49);ctx.lineTo(118,34);ctx.lineTo(144,23);ctx.lineTo(172,16);ctx.lineTo(200,13);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(200,13));listpt.Add(new Point(388,13));listpt.Add(new Point(408,30));listpt.Add(new Point(425,50));listpt.Add(new Point(440,73));listpt.Add(new Point(451,97));listpt.Add(new Point(458,123));listpt.Add(new Point(462,149));listpt.Add(new Point(462,176));listpt.Add(new Point(458,203));listpt.Add(new Point(451,228));listpt.Add(new Point(440,252));listpt.Add(new Point(425,275));listpt.Add(new Point(408,295));listpt.Add(new Point(388,313));listpt.Add(new Point(200,313));listpt.Add(new Point(172,309));listpt.Add(new Point(144,302));listpt.Add(new Point(118,291));listpt.Add(new Point(94,277));listpt.Add(new Point(71,259));listpt.Add(new Point(52,238));listpt.Add(new Point(35,215));listpt.Add(new Point(22,190));listpt.Add(new Point(13,163));listpt.Add(new Point(22,136));listpt.Add(new Point(35,111));listpt.Add(new Point(52,87));listpt.Add(new Point(71,67));listpt.Add(new Point(94,49));listpt.Add(new Point(118,34));listpt.Add(new Point(144,23));listpt.Add(new Point(172,16));listpt.Add(new Point(200,13));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}