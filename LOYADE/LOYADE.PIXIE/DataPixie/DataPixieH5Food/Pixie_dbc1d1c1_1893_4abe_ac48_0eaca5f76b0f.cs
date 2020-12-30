using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Food
{
    public class PIXIE_dbc1d1c1_1893_4abe_ac48_0eaca5f76b0f : Pixie
    {
        public PIXIE_dbc1d1c1_1893_4abe_ac48_0eaca5f76b0f()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#c93"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 618f; _h = 88f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#c93'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(618,88);ctx.lineTo(618,79);ctx.lineTo(590,60);ctx.lineTo(535,45);ctx.lineTo(459,34);ctx.lineTo(370,28);ctx.lineTo(276,28);ctx.lineTo(187,34);ctx.lineTo(111,45);ctx.lineTo(56,60);ctx.lineTo(28,79);ctx.lineTo(28,88);ctx.lineTo(618,88);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(618,88));listpt.Add(new Point(618,79));listpt.Add(new Point(590,60));listpt.Add(new Point(535,45));listpt.Add(new Point(459,34));listpt.Add(new Point(370,28));listpt.Add(new Point(276,28));listpt.Add(new Point(187,34));listpt.Add(new Point(111,45));listpt.Add(new Point(56,60));listpt.Add(new Point(28,79));listpt.Add(new Point(28,88));listpt.Add(new Point(618,88));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}