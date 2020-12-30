using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Vehicle
{
    public class PIXIE_605c83f5_2cd7_4ad9_be2d_db23a2e903c5 : Pixie
    {
        public PIXIE_605c83f5_2cd7_4ad9_be2d_db23a2e903c5()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#808080"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 971f; _h = 562f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#808080'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(949,27);ctx.lineTo(949,381);ctx.lineTo(967,401);ctx.lineTo(970,408);ctx.lineTo(971,416);ctx.lineTo(971,425);ctx.lineTo(964,451);ctx.lineTo(943,466);ctx.lineTo(940,468);ctx.lineTo(906,509);ctx.lineTo(866,509);ctx.lineTo(848,539);ctx.lineTo(821,556);ctx.lineTo(789,560);ctx.lineTo(758,550);ctx.lineTo(734,527);ctx.lineTo(729,516);ctx.lineTo(240,516);ctx.lineTo(222,544);ctx.lineTo(193,559);ctx.lineTo(182,562);ctx.lineTo(172,562);ctx.lineTo(161,562);ctx.lineTo(130,551);ctx.lineTo(108,527);ctx.lineTo(103,516);ctx.lineTo(27,516);ctx.lineTo(27,483);ctx.lineTo(44,468);ctx.lineTo(61,387);ctx.lineTo(170,351);ctx.lineTo(229,248);ctx.lineTo(338,234);ctx.lineTo(338,196);ctx.lineTo(90,196);ctx.lineTo(90,27);ctx.lineTo(949,27);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(796,489,43,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(172,491,43,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(949,27));listpt.Add(new Point(949,381));listpt.Add(new Point(967,401));listpt.Add(new Point(970,408));listpt.Add(new Point(971,416));listpt.Add(new Point(971,425));listpt.Add(new Point(964,451));listpt.Add(new Point(943,466));listpt.Add(new Point(940,468));listpt.Add(new Point(906,509));listpt.Add(new Point(866,509));listpt.Add(new Point(848,539));listpt.Add(new Point(821,556));listpt.Add(new Point(789,560));listpt.Add(new Point(758,550));listpt.Add(new Point(734,527));listpt.Add(new Point(729,516));listpt.Add(new Point(240,516));listpt.Add(new Point(222,544));listpt.Add(new Point(193,559));listpt.Add(new Point(182,562));listpt.Add(new Point(172,562));listpt.Add(new Point(161,562));listpt.Add(new Point(130,551));listpt.Add(new Point(108,527));listpt.Add(new Point(103,516));listpt.Add(new Point(27,516));listpt.Add(new Point(27,483));listpt.Add(new Point(44,468));listpt.Add(new Point(61,387));listpt.Add(new Point(170,351));listpt.Add(new Point(229,248));listpt.Add(new Point(338,234));listpt.Add(new Point(338,196));listpt.Add(new Point(90,196));listpt.Add(new Point(90,27));listpt.Add(new Point(949,27));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.DrawEllipse(p, 753f,446f,86f,86f);
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.DrawEllipse(p, 129f,448f,86f,86f);
        }
    }
}