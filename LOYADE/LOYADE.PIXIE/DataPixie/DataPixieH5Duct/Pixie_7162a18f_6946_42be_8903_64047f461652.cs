using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Duct
{
    public class PIXIE_7162a18f_6946_42be_8903_64047f461652 : Pixie
    {
        public PIXIE_7162a18f_6946_42be_8903_64047f461652()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 970f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#ccc'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,162);ctx.lineTo(161,163);ctx.lineTo(161,28);ctx.lineTo(833,28);ctx.lineTo(835,163);ctx.lineTo(970,162);ctx.lineTo(970,835);ctx.lineTo(835,835);ctx.lineTo(835,970);ctx.lineTo(161,970);ctx.lineTo(161,835);ctx.lineTo(28,835);ctx.lineTo(28,162);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,162));listpt.Add(new Point(161,163));listpt.Add(new Point(161,28));listpt.Add(new Point(833,28));listpt.Add(new Point(835,163));listpt.Add(new Point(970,162));listpt.Add(new Point(970,835));listpt.Add(new Point(835,835));listpt.Add(new Point(835,970));listpt.Add(new Point(161,970));listpt.Add(new Point(161,835));listpt.Add(new Point(28,835));listpt.Add(new Point(28,162));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}