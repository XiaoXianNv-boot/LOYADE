using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_f4123318_74bf_4046_82a2_19f2bb9e2c9e : Pixie
    {
        public PIXIE_f4123318_74bf_4046_82a2_19f2bb9e2c9e()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 283f; _h = 637f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(283,615);ctx.lineTo(217,29);ctx.lineTo(197,21);ctx.lineTo(176,19);ctx.lineTo(163,18);ctx.lineTo(137,18);ctx.lineTo(114,20);ctx.lineTo(96,23);ctx.lineTo(86,27);ctx.lineTo(85,29);ctx.lineTo(18,615);ctx.lineTo(21,619);ctx.lineTo(41,627);ctx.lineTo(57,630);ctx.lineTo(77,633);ctx.lineTo(99,635);ctx.lineTo(124,637);ctx.lineTo(177,637);ctx.lineTo(202,635);ctx.lineTo(224,633);ctx.lineTo(244,630);ctx.lineTo(260,627);ctx.lineTo(280,619);ctx.lineTo(283,615);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(283,615));listpt.Add(new Point(217,29));listpt.Add(new Point(197,21));listpt.Add(new Point(176,19));listpt.Add(new Point(163,18));listpt.Add(new Point(137,18));listpt.Add(new Point(114,20));listpt.Add(new Point(96,23));listpt.Add(new Point(86,27));listpt.Add(new Point(85,29));listpt.Add(new Point(18,615));listpt.Add(new Point(21,619));listpt.Add(new Point(41,627));listpt.Add(new Point(57,630));listpt.Add(new Point(77,633));listpt.Add(new Point(99,635));listpt.Add(new Point(124,637));listpt.Add(new Point(177,637));listpt.Add(new Point(202,635));listpt.Add(new Point(224,633));listpt.Add(new Point(244,630));listpt.Add(new Point(260,627));listpt.Add(new Point(280,619));listpt.Add(new Point(283,615));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}