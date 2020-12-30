using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_39a06eb9_2122_4df6_be9e_1157f0c00bdd : Pixie
    {
        public PIXIE_39a06eb9_2122_4df6_be9e_1157f0c00bdd()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 386f; _h = 261f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(11,109);ctx.lineTo(89,109);ctx.lineTo(89,148);ctx.lineTo(94,159);ctx.lineTo(99,167);ctx.lineTo(105,176);ctx.lineTo(112,186);ctx.lineTo(120,195);ctx.lineTo(128,203);ctx.lineTo(136,210);ctx.lineTo(261,210);ctx.lineTo(268,203);ctx.lineTo(276,195);ctx.lineTo(284,186);ctx.lineTo(292,176);ctx.lineTo(298,167);ctx.lineTo(303,159);ctx.lineTo(308,148);ctx.lineTo(308,109);ctx.lineTo(386,109);ctx.lineTo(386,261);ctx.lineTo(11,261);ctx.lineTo(11,109);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(11,93);ctx.lineTo(105,93);ctx.lineTo(105,144);ctx.lineTo(109,154);ctx.lineTo(113,160);ctx.lineTo(118,168);ctx.lineTo(124,176);ctx.lineTo(135,190);ctx.lineTo(140,195);ctx.lineTo(257,195);ctx.lineTo(268,183);ctx.lineTo(273,176);ctx.lineTo(279,168);ctx.lineTo(284,160);ctx.lineTo(291,148);ctx.lineTo(292,144);ctx.lineTo(292,93);ctx.lineTo(386,93);ctx.lineTo(386,11);ctx.lineTo(11,11);ctx.lineTo(11,93);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(11,109));listpt.Add(new Point(89,109));listpt.Add(new Point(89,148));listpt.Add(new Point(94,159));listpt.Add(new Point(99,167));listpt.Add(new Point(105,176));listpt.Add(new Point(112,186));listpt.Add(new Point(120,195));listpt.Add(new Point(128,203));listpt.Add(new Point(136,210));listpt.Add(new Point(261,210));listpt.Add(new Point(268,203));listpt.Add(new Point(276,195));listpt.Add(new Point(284,186));listpt.Add(new Point(292,176));listpt.Add(new Point(298,167));listpt.Add(new Point(303,159));listpt.Add(new Point(308,148));listpt.Add(new Point(308,109));listpt.Add(new Point(386,109));listpt.Add(new Point(386,261));listpt.Add(new Point(11,261));listpt.Add(new Point(11,109));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(11,93));listpt.Add(new Point(105,93));listpt.Add(new Point(105,144));listpt.Add(new Point(109,154));listpt.Add(new Point(113,160));listpt.Add(new Point(118,168));listpt.Add(new Point(124,176));listpt.Add(new Point(135,190));listpt.Add(new Point(140,195));listpt.Add(new Point(257,195));listpt.Add(new Point(268,183));listpt.Add(new Point(273,176));listpt.Add(new Point(279,168));listpt.Add(new Point(284,160));listpt.Add(new Point(291,148));listpt.Add(new Point(292,144));listpt.Add(new Point(292,93));listpt.Add(new Point(386,93));listpt.Add(new Point(386,11));listpt.Add(new Point(11,11));listpt.Add(new Point(11,93));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}