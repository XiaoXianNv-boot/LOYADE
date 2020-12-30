using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_3185cc76_9ce8_4fa7_b2b6_663f48ecef7e : Pixie
    {
        public PIXIE_3185cc76_9ce8_4fa7_b2b6_663f48ecef7e()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 463f; _h = 163f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(88,163);ctx.lineTo(388,163);ctx.lineTo(404,161);ctx.lineTo(420,155);ctx.lineTo(434,146);ctx.lineTo(446,134);ctx.lineTo(455,120);ctx.lineTo(461,104);ctx.lineTo(463,88);ctx.lineTo(461,71);ctx.lineTo(455,55);ctx.lineTo(446,41);ctx.lineTo(434,29);ctx.lineTo(420,20);ctx.lineTo(404,15);ctx.lineTo(388,13);ctx.lineTo(88,13);ctx.lineTo(71,15);ctx.lineTo(55,20);ctx.lineTo(41,29);ctx.lineTo(29,41);ctx.lineTo(20,55);ctx.lineTo(15,71);ctx.lineTo(13,88);ctx.lineTo(15,104);ctx.lineTo(20,120);ctx.lineTo(29,134);ctx.lineTo(41,146);ctx.lineTo(55,155);ctx.lineTo(71,161);ctx.lineTo(88,163);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(88,163));listpt.Add(new Point(388,163));listpt.Add(new Point(404,161));listpt.Add(new Point(420,155));listpt.Add(new Point(434,146));listpt.Add(new Point(446,134));listpt.Add(new Point(455,120));listpt.Add(new Point(461,104));listpt.Add(new Point(463,88));listpt.Add(new Point(461,71));listpt.Add(new Point(455,55));listpt.Add(new Point(446,41));listpt.Add(new Point(434,29));listpt.Add(new Point(420,20));listpt.Add(new Point(404,15));listpt.Add(new Point(388,13));listpt.Add(new Point(88,13));listpt.Add(new Point(71,15));listpt.Add(new Point(55,20));listpt.Add(new Point(41,29));listpt.Add(new Point(29,41));listpt.Add(new Point(20,55));listpt.Add(new Point(15,71));listpt.Add(new Point(13,88));listpt.Add(new Point(15,104));listpt.Add(new Point(20,120));listpt.Add(new Point(29,134));listpt.Add(new Point(41,146));listpt.Add(new Point(55,155));listpt.Add(new Point(71,161));listpt.Add(new Point(88,163));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}