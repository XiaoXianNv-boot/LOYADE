using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WaterWastewater
{
    public class PIXIE_c589225f_d515_46f7_9baf_12afed8330f0 : Pixie
    {
        public PIXIE_c589225f_d515_46f7_9baf_12afed8330f0()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#b2b2b2"));
_w = 461f; _h = 603f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#e5e5e5'; arrFillColor[1] = '#fff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#b2b2b2'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(133,603);ctx.lineTo(86,369);ctx.lineTo(133,135);ctx.lineTo(414,135);ctx.lineTo(461,369);ctx.lineTo(414,603);ctx.lineTo(133,603);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(148,578);ctx.lineTo(105,369);ctx.lineTo(148,158);ctx.lineTo(401,158);ctx.lineTo(442,369);ctx.lineTo(401,578);ctx.lineTo(148,578);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(133,603));listpt.Add(new Point(86,369));listpt.Add(new Point(133,135));listpt.Add(new Point(414,135));listpt.Add(new Point(461,369));listpt.Add(new Point(414,603));listpt.Add(new Point(133,603));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(148,578));listpt.Add(new Point(105,369));listpt.Add(new Point(148,158));listpt.Add(new Point(401,158));listpt.Add(new Point(442,369));listpt.Add(new Point(401,578));listpt.Add(new Point(148,578));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}