using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Electrical
{
    public class PIXIE_4df23c31_29a0_4e9b_943f_afd23b61c659 : Pixie
    {
        public PIXIE_4df23c31_29a0_4e9b_943f_afd23b61c659()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 160f; _h = 34f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#fff'; arrFillColor[1] = '#fff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(151,30);ctx.lineTo(152,27);ctx.lineTo(156,25);ctx.lineTo(159,27);ctx.lineTo(160,30);ctx.lineTo(159,33);ctx.lineTo(156,34);ctx.lineTo(152,33);ctx.lineTo(151,30);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(76,30);ctx.lineTo(77,27);ctx.lineTo(81,25);ctx.lineTo(84,27);ctx.lineTo(85,30);ctx.lineTo(84,33);ctx.lineTo(81,34);ctx.lineTo(77,33);ctx.lineTo(76,30);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(151,30));listpt.Add(new Point(152,27));listpt.Add(new Point(156,25));listpt.Add(new Point(159,27));listpt.Add(new Point(160,30));listpt.Add(new Point(159,33));listpt.Add(new Point(156,34));listpt.Add(new Point(152,33));listpt.Add(new Point(151,30));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(76,30));listpt.Add(new Point(77,27));listpt.Add(new Point(81,25));listpt.Add(new Point(84,27));listpt.Add(new Point(85,30));listpt.Add(new Point(84,33));listpt.Add(new Point(81,34));listpt.Add(new Point(77,33));listpt.Add(new Point(76,30));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}