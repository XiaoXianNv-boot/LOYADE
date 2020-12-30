using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_f92057ca_a44c_47e5_9557_e1df6e30fe57 : Pixie
    {
        public PIXIE_f92057ca_a44c_47e5_9557_e1df6e30fe57()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#161717"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#161717"));
_w = 386f; _h = 255f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#161717'; arrBorderColor[1] = '#161717'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(326,146);ctx.lineTo(386,86);ctx.lineTo(311,11);ctx.lineTo(243,78);ctx.lineTo(240,89);ctx.lineTo(266,86);ctx.lineTo(326,146);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(11,146);ctx.lineTo(105,146);ctx.lineTo(105,224);ctx.lineTo(292,224);ctx.lineTo(292,146);ctx.lineTo(386,146);ctx.lineTo(386,161);ctx.lineTo(308,161);ctx.lineTo(308,255);ctx.lineTo(89,255);ctx.lineTo(89,161);ctx.lineTo(11,161);ctx.lineTo(11,146);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(326,146));listpt.Add(new Point(386,86));listpt.Add(new Point(311,11));listpt.Add(new Point(243,78));listpt.Add(new Point(240,89));listpt.Add(new Point(266,86));listpt.Add(new Point(326,146));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(11,146));listpt.Add(new Point(105,146));listpt.Add(new Point(105,224));listpt.Add(new Point(292,224));listpt.Add(new Point(292,146));listpt.Add(new Point(386,146));listpt.Add(new Point(386,161));listpt.Add(new Point(308,161));listpt.Add(new Point(308,255));listpt.Add(new Point(89,255));listpt.Add(new Point(89,161));listpt.Add(new Point(11,161));listpt.Add(new Point(11,146));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}