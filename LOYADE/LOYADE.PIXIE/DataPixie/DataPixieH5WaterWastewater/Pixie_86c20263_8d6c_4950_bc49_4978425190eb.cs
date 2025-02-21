using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WaterWastewater
{
    public class PIXIE_86c20263_8d6c_4950_bc49_4978425190eb : Pixie
    {
        public PIXIE_86c20263_8d6c_4950_bc49_4978425190eb()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 592f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#ccc'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,592);ctx.lineTo(28,62);ctx.lineTo(67,62);ctx.lineTo(67,553);ctx.lineTo(303,553);ctx.lineTo(342,514);ctx.lineTo(656,514);ctx.lineTo(695,553);ctx.lineTo(931,553);ctx.lineTo(931,62);ctx.lineTo(970,62);ctx.lineTo(970,592);ctx.lineTo(28,592);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,592));listpt.Add(new Point(28,62));listpt.Add(new Point(67,62));listpt.Add(new Point(67,553));listpt.Add(new Point(303,553));listpt.Add(new Point(342,514));listpt.Add(new Point(656,514));listpt.Add(new Point(695,553));listpt.Add(new Point(931,553));listpt.Add(new Point(931,62));listpt.Add(new Point(970,62));listpt.Add(new Point(970,592));listpt.Add(new Point(28,592));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}