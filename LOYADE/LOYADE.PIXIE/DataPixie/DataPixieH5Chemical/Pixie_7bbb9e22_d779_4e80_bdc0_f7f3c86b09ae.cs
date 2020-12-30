using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Chemical
{
    public class PIXIE_7bbb9e22_d779_4e80_bdc0_f7f3c86b09ae : Pixie
    {
        public PIXIE_7bbb9e22_d779_4e80_bdc0_f7f3c86b09ae()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#699"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 499f; _h = 970f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#699'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(499,107);ctx.lineTo(488,83);ctx.lineTo(465,66);ctx.lineTo(438,54);ctx.lineTo(413,46);ctx.lineTo(386,39);ctx.lineTo(355,34);ctx.lineTo(322,30);ctx.lineTo(288,28);ctx.lineTo(276,28);ctx.lineTo(263,28);ctx.lineTo(228,29);ctx.lineTo(194,31);ctx.lineTo(162,36);ctx.lineTo(132,41);ctx.lineTo(106,49);ctx.lineTo(75,60);ctx.lineTo(51,73);ctx.lineTo(32,91);ctx.lineTo(28,103);ctx.lineTo(28,107);ctx.lineTo(28,814);ctx.lineTo(226,970);ctx.lineTo(303,970);ctx.lineTo(499,814);ctx.lineTo(499,107);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(499,107));listpt.Add(new Point(488,83));listpt.Add(new Point(465,66));listpt.Add(new Point(438,54));listpt.Add(new Point(413,46));listpt.Add(new Point(386,39));listpt.Add(new Point(355,34));listpt.Add(new Point(322,30));listpt.Add(new Point(288,28));listpt.Add(new Point(276,28));listpt.Add(new Point(263,28));listpt.Add(new Point(228,29));listpt.Add(new Point(194,31));listpt.Add(new Point(162,36));listpt.Add(new Point(132,41));listpt.Add(new Point(106,49));listpt.Add(new Point(75,60));listpt.Add(new Point(51,73));listpt.Add(new Point(32,91));listpt.Add(new Point(28,103));listpt.Add(new Point(28,107));listpt.Add(new Point(28,814));listpt.Add(new Point(226,970));listpt.Add(new Point(303,970));listpt.Add(new Point(499,814));listpt.Add(new Point(499,107));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}