using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Food
{
    public class PIXIE_35dc051e_6694_4abc_a7bb_b7c1ab282460 : Pixie
    {
        public PIXIE_35dc051e_6694_4abc_a7bb_b7c1ab282460()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f2f2f2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 263f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#ccc'; arrFillColor[1] = '#f2f2f2'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(814,107);ctx.lineTo(970,28);ctx.lineTo(970,184);ctx.lineTo(814,263);ctx.lineTo(814,107);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(814,107);ctx.lineTo(970,28);ctx.lineTo(184,28);ctx.lineTo(28,107);ctx.lineTo(814,107);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(814,107));listpt.Add(new Point(970,28));listpt.Add(new Point(970,184));listpt.Add(new Point(814,263));listpt.Add(new Point(814,107));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(814,107));listpt.Add(new Point(970,28));listpt.Add(new Point(184,28));listpt.Add(new Point(28,107));listpt.Add(new Point(814,107));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}