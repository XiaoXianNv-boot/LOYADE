using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Valve
{
    public class PIXIE_f311edb9_1ab3_4eb7_94a1_690b01c9d273 : Pixie
    {
        public PIXIE_f311edb9_1ab3_4eb7_94a1_690b01c9d273()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));
_w = 366f; _h = 233f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#7f7f7f'; arrBorderColor[0] = '#7f7f7f'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(363,231);ctx.lineTo(365,233);ctx.lineTo(366,233);ctx.lineTo(366,232);ctx.lineTo(366,231);ctx.lineTo(363,231);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(363,231));listpt.Add(new Point(365,233));listpt.Add(new Point(366,233));listpt.Add(new Point(366,232));listpt.Add(new Point(366,231));listpt.Add(new Point(363,231));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}