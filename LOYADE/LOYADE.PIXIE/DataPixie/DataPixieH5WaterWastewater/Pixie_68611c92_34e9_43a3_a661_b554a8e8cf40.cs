using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WaterWastewater
{
    public class PIXIE_68611c92_34e9_43a3_a661_b554a8e8cf40 : Pixie
    {
        public PIXIE_68611c92_34e9_43a3_a661_b554a8e8cf40()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 332f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#7f7f7f'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(970,254);ctx.lineTo(949,277);ctx.lineTo(924,288);ctx.lineTo(889,297);ctx.lineTo(862,304);ctx.lineTo(832,309);ctx.lineTo(798,314);ctx.lineTo(762,319);ctx.lineTo(723,323);ctx.lineTo(682,326);ctx.lineTo(639,329);ctx.lineTo(594,331);ctx.lineTo(547,332);ctx.lineTo(523,332);ctx.lineTo(499,332);ctx.lineTo(451,332);ctx.lineTo(404,331);ctx.lineTo(359,329);ctx.lineTo(316,326);ctx.lineTo(275,323);ctx.lineTo(236,319);ctx.lineTo(200,314);ctx.lineTo(166,309);ctx.lineTo(136,304);ctx.lineTo(109,297);ctx.lineTo(74,288);ctx.lineTo(49,277);ctx.lineTo(28,258);ctx.lineTo(28,254);ctx.lineTo(28,97);ctx.lineTo(970,97);ctx.lineTo(970,254);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(6.926471,1);ctx.arc(72.04246,96,68,0,Math.PI*2,true);ctx.scale(0.1443737,1);ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(970,254));listpt.Add(new Point(949,277));listpt.Add(new Point(924,288));listpt.Add(new Point(889,297));listpt.Add(new Point(862,304));listpt.Add(new Point(832,309));listpt.Add(new Point(798,314));listpt.Add(new Point(762,319));listpt.Add(new Point(723,323));listpt.Add(new Point(682,326));listpt.Add(new Point(639,329));listpt.Add(new Point(594,331));listpt.Add(new Point(547,332));listpt.Add(new Point(523,332));listpt.Add(new Point(499,332));listpt.Add(new Point(451,332));listpt.Add(new Point(404,331));listpt.Add(new Point(359,329));listpt.Add(new Point(316,326));listpt.Add(new Point(275,323));listpt.Add(new Point(236,319));listpt.Add(new Point(200,314));listpt.Add(new Point(166,309));listpt.Add(new Point(136,304));listpt.Add(new Point(109,297));listpt.Add(new Point(74,288));listpt.Add(new Point(49,277));listpt.Add(new Point(28,258));listpt.Add(new Point(28,254));listpt.Add(new Point(28,97));listpt.Add(new Point(970,97));listpt.Add(new Point(970,254));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.DrawEllipse(p, 4.042458f,28f,136f,136f);
        }
    }
}