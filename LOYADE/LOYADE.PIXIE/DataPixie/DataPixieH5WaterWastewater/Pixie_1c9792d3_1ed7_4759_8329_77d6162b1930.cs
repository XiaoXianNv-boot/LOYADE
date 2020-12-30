using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WaterWastewater
{
    public class PIXIE_1c9792d3_1ed7_4759_8329_77d6162b1930 : Pixie
    {
        public PIXIE_1c9792d3_1ed7_4759_8329_77d6162b1930()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#98b2a5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 971f; _h = 814f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#98b2a5'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(27,27);ctx.lineTo(27,186);ctx.lineTo(207,186);ctx.lineTo(207,657);ctx.lineTo(499,814);ctx.lineTo(793,657);ctx.lineTo(793,186);ctx.lineTo(971,186);ctx.lineTo(971,27);ctx.lineTo(27,27);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(27,27));listpt.Add(new Point(27,186));listpt.Add(new Point(207,186));listpt.Add(new Point(207,657));listpt.Add(new Point(499,814));listpt.Add(new Point(793,657));listpt.Add(new Point(793,186));listpt.Add(new Point(971,186));listpt.Add(new Point(971,27));listpt.Add(new Point(27,27));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}