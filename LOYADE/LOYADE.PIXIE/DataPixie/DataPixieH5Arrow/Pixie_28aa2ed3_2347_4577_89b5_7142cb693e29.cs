using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_28aa2ed3_2347_4577_89b5_7142cb693e29 : Pixie
    {
        public PIXIE_28aa2ed3_2347_4577_89b5_7142cb693e29()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 472f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(970,250);ctx.lineTo(695,28);ctx.lineTo(748,137);ctx.lineTo(28,28);ctx.lineTo(81,250);ctx.lineTo(28,472);ctx.lineTo(748,360);ctx.lineTo(695,472);ctx.lineTo(970,250);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(970,250));listpt.Add(new Point(695,28));listpt.Add(new Point(748,137));listpt.Add(new Point(28,28));listpt.Add(new Point(81,250));listpt.Add(new Point(28,472));listpt.Add(new Point(748,360));listpt.Add(new Point(695,472));listpt.Add(new Point(970,250));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}