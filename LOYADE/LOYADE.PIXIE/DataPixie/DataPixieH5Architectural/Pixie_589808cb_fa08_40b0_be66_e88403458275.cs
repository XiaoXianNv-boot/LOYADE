using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Architectural
{
    public class PIXIE_589808cb_fa08_40b0_be66_e88403458275 : Pixie
    {
        public PIXIE_589808cb_fa08_40b0_be66_e88403458275()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#cbe5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2cccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 970f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#cbe5e5'; arrFillColor[1] = '#b2cccc'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,28);ctx.lineTo(950,28);ctx.lineTo(950,950);ctx.lineTo(28,950);ctx.lineTo(28,28);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(48,970);ctx.lineTo(970,970);ctx.lineTo(970,47);ctx.lineTo(951,28);ctx.lineTo(951,950);ctx.lineTo(28,950);ctx.lineTo(48,970);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,28));listpt.Add(new Point(950,28));listpt.Add(new Point(950,950));listpt.Add(new Point(28,950));listpt.Add(new Point(28,28));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(48,970));listpt.Add(new Point(970,970));listpt.Add(new Point(970,47));listpt.Add(new Point(951,28));listpt.Add(new Point(951,950));listpt.Add(new Point(28,950));listpt.Add(new Point(48,970));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}