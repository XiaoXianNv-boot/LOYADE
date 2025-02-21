using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Electrical
{
    public class PIXIE_17802dcf_99c4_48d7_a246_06f3a6020081 : Pixie
    {
        public PIXIE_17802dcf_99c4_48d7_a246_06f3a6020081()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 579f; _h = 258f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#000'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(465,258);ctx.lineTo(579,143);ctx.lineTo(465,28);ctx.lineTo(465,258);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(465,258));listpt.Add(new Point(579,143));listpt.Add(new Point(465,28));listpt.Add(new Point(465,258));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}