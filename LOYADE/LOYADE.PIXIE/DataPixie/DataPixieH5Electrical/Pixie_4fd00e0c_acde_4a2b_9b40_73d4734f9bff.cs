using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Electrical
{
    public class PIXIE_4fd00e0c_acde_4a2b_9b40_73d4734f9bff : Pixie
    {
        public PIXIE_4fd00e0c_acde_4a2b_9b40_73d4734f9bff()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 160f; _h = 29f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#fff'; arrFillColor[1] = '#fff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(151,24);ctx.lineTo(152,21);ctx.lineTo(156,19);ctx.lineTo(159,21);ctx.lineTo(160,24);ctx.lineTo(159,27);ctx.lineTo(156,29);ctx.lineTo(152,27);ctx.lineTo(151,24);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(76,24);ctx.lineTo(77,21);ctx.lineTo(81,19);ctx.lineTo(84,21);ctx.lineTo(85,24);ctx.lineTo(84,27);ctx.lineTo(81,29);ctx.lineTo(77,27);ctx.lineTo(76,24);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(151,24));listpt.Add(new Point(152,21));listpt.Add(new Point(156,19));listpt.Add(new Point(159,21));listpt.Add(new Point(160,24));listpt.Add(new Point(159,27));listpt.Add(new Point(156,29));listpt.Add(new Point(152,27));listpt.Add(new Point(151,24));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(76,24));listpt.Add(new Point(77,21));listpt.Add(new Point(81,19));listpt.Add(new Point(84,21));listpt.Add(new Point(85,24));listpt.Add(new Point(84,27));listpt.Add(new Point(81,29));listpt.Add(new Point(77,27));listpt.Add(new Point(76,24));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}