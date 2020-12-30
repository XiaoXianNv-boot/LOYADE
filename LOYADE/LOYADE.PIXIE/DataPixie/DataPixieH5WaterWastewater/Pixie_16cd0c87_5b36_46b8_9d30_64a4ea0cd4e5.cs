using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WaterWastewater
{
    public class PIXIE_16cd0c87_5b36_46b8_9d30_64a4ea0cd4e5 : Pixie
    {
        public PIXIE_16cd0c87_5b36_46b8_9d30_64a4ea0cd4e5()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 475f; _h = 503f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#fff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(105,503);ctx.lineTo(86,484);ctx.lineTo(86,135);ctx.lineTo(105,114);ctx.lineTo(456,114);ctx.lineTo(475,135);ctx.lineTo(475,484);ctx.lineTo(456,503);ctx.lineTo(105,503);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(105,503));listpt.Add(new Point(86,484));listpt.Add(new Point(86,135));listpt.Add(new Point(105,114));listpt.Add(new Point(456,114));listpt.Add(new Point(475,135));listpt.Add(new Point(475,484));listpt.Add(new Point(456,503));listpt.Add(new Point(105,503));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}