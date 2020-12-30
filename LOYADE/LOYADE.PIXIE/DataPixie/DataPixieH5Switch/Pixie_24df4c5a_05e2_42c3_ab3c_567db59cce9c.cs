using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Switch
{
    public class PIXIE_24df4c5a_05e2_42c3_ab3c_567db59cce9c : Pixie
    {
        public PIXIE_24df4c5a_05e2_42c3_ab3c_567db59cce9c()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#f00"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 952f; _h = 949f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#f00'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(49,497);ctx.lineTo(81,330);ctx.lineTo(179,179);ctx.lineTo(332,78);ctx.lineTo(497,46);ctx.lineTo(668,78);ctx.lineTo(819,179);ctx.lineTo(920,330);ctx.lineTo(952,497);ctx.lineTo(920,666);ctx.lineTo(819,819);ctx.lineTo(668,917);ctx.lineTo(497,949);ctx.lineTo(332,917);ctx.lineTo(179,819);ctx.lineTo(81,666);ctx.lineTo(49,497);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(49,497));listpt.Add(new Point(81,330));listpt.Add(new Point(179,179));listpt.Add(new Point(332,78));listpt.Add(new Point(497,46));listpt.Add(new Point(668,78));listpt.Add(new Point(819,179));listpt.Add(new Point(920,330));listpt.Add(new Point(952,497));listpt.Add(new Point(920,666));listpt.Add(new Point(819,819));listpt.Add(new Point(668,917));listpt.Add(new Point(497,949));listpt.Add(new Point(332,917));listpt.Add(new Point(179,819));listpt.Add(new Point(81,666));listpt.Add(new Point(49,497));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}