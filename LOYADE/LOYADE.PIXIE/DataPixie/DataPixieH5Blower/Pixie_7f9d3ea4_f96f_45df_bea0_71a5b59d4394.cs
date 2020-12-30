using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Blower
{
    public class PIXIE_7f9d3ea4_f96f_45df_bea0_71a5b59d4394 : Pixie
    {
        public PIXIE_7f9d3ea4_f96f_45df_bea0_71a5b59d4394()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#e5b24c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 590f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#e5b24c'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(99,425);ctx.lineTo(79,420);ctx.lineTo(45,388);ctx.lineTo(33,365);ctx.lineTo(28,341);ctx.lineTo(28,314);ctx.lineTo(33,288);ctx.lineTo(45,265);ctx.lineTo(79,233);ctx.lineTo(99,227);ctx.lineTo(99,82);ctx.lineTo(118,64);ctx.lineTo(154,64);ctx.lineTo(154,28);ctx.lineTo(518,28);ctx.lineTo(518,64);ctx.lineTo(554,64);ctx.lineTo(571,99);ctx.lineTo(951,99);ctx.lineTo(970,118);ctx.lineTo(970,480);ctx.lineTo(951,499);ctx.lineTo(899,499);ctx.lineTo(899,571);ctx.lineTo(844,571);ctx.lineTo(844,499);ctx.lineTo(571,499);ctx.lineTo(554,535);ctx.lineTo(263,535);ctx.lineTo(263,590);ctx.lineTo(173,590);ctx.lineTo(173,535);ctx.lineTo(118,535);ctx.lineTo(99,518);ctx.lineTo(99,425);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(99,425));listpt.Add(new Point(79,420));listpt.Add(new Point(45,388));listpt.Add(new Point(33,365));listpt.Add(new Point(28,341));listpt.Add(new Point(28,314));listpt.Add(new Point(33,288));listpt.Add(new Point(45,265));listpt.Add(new Point(79,233));listpt.Add(new Point(99,227));listpt.Add(new Point(99,82));listpt.Add(new Point(118,64));listpt.Add(new Point(154,64));listpt.Add(new Point(154,28));listpt.Add(new Point(518,28));listpt.Add(new Point(518,64));listpt.Add(new Point(554,64));listpt.Add(new Point(571,99));listpt.Add(new Point(951,99));listpt.Add(new Point(970,118));listpt.Add(new Point(970,480));listpt.Add(new Point(951,499));listpt.Add(new Point(899,499));listpt.Add(new Point(899,571));listpt.Add(new Point(844,571));listpt.Add(new Point(844,499));listpt.Add(new Point(571,499));listpt.Add(new Point(554,535));listpt.Add(new Point(263,535));listpt.Add(new Point(263,590));listpt.Add(new Point(173,590));listpt.Add(new Point(173,535));listpt.Add(new Point(118,535));listpt.Add(new Point(99,518));listpt.Add(new Point(99,425));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}