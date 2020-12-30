using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Architectural
{
    public class PIXIE_162132b0_a87a_4073_aa91_7eea2289779f : Pixie
    {
        public PIXIE_162132b0_a87a_4073_aa91_7eea2289779f()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#699"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#194c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 518f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#699'; arrFillColor[1] = '#b2e5e5'; arrFillColor[2] = '#194c4c'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,65);ctx.lineTo(899,65);ctx.lineTo(899,518);ctx.lineTo(28,518);ctx.lineTo(28,65);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,65);ctx.lineTo(99,28);ctx.lineTo(970,28);ctx.lineTo(899,65);ctx.lineTo(28,65);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(899,65);ctx.lineTo(970,28);ctx.lineTo(970,482);ctx.lineTo(899,518);ctx.lineTo(899,65);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,65));listpt.Add(new Point(899,65));listpt.Add(new Point(899,518));listpt.Add(new Point(28,518));listpt.Add(new Point(28,65));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,65));listpt.Add(new Point(99,28));listpt.Add(new Point(970,28));listpt.Add(new Point(899,65));listpt.Add(new Point(28,65));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(899,65));listpt.Add(new Point(970,28));listpt.Add(new Point(970,482));listpt.Add(new Point(899,518));listpt.Add(new Point(899,65));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}