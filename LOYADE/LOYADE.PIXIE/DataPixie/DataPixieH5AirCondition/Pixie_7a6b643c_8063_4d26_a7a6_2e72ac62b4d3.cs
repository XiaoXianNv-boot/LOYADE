using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5AirCondition
{
    public class PIXIE_7a6b643c_8063_4d26_a7a6_2e72ac62b4d3 : Pixie
    {
        public PIXIE_7a6b643c_8063_4d26_a7a6_2e72ac62b4d3()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 339f; _h = 144f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(339,124);ctx.lineTo(328,129);ctx.lineTo(314,133);ctx.lineTo(299,136);ctx.lineTo(281,139);ctx.lineTo(262,141);ctx.lineTo(242,143);ctx.lineTo(220,144);ctx.lineTo(198,144);ctx.lineTo(176,144);ctx.lineTo(154,143);ctx.lineTo(134,141);ctx.lineTo(115,139);ctx.lineTo(97,136);ctx.lineTo(82,133);ctx.lineTo(69,129);ctx.lineTo(58,124);ctx.lineTo(58,89);ctx.lineTo(339,89);ctx.lineTo(339,124);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(339,124));listpt.Add(new Point(328,129));listpt.Add(new Point(314,133));listpt.Add(new Point(299,136));listpt.Add(new Point(281,139));listpt.Add(new Point(262,141));listpt.Add(new Point(242,143));listpt.Add(new Point(220,144));listpt.Add(new Point(198,144));listpt.Add(new Point(176,144));listpt.Add(new Point(154,143));listpt.Add(new Point(134,141));listpt.Add(new Point(115,139));listpt.Add(new Point(97,136));listpt.Add(new Point(82,133));listpt.Add(new Point(69,129));listpt.Add(new Point(58,124));listpt.Add(new Point(58,89));listpt.Add(new Point(339,89));listpt.Add(new Point(339,124));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}