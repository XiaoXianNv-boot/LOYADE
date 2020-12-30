using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WaterWastewater
{
    public class PIXIE_99eae60a_1988_4e9d_9c98_f145c4d49584 : Pixie
    {
        public PIXIE_99eae60a_1988_4e9d_9c98_f145c4d49584()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#e5cbb2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 656f; _h = 184f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#e5cbb2'; arrFillColor[1] = '#7f7f7f'; arrFillColor[2] = '#e5e5e5'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* ellipse */ ctx.scale(6.038462,1);ctx.arc(82.63694,106,78,0,Math.PI*2,true);ctx.scale(0.1656051,1);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(656,109);ctx.lineTo(656,100);ctx.lineTo(342,100);ctx.lineTo(343,112);ctx.lineTo(369,124);ctx.lineTo(399,130);ctx.lineTo(438,134);ctx.lineTo(468,135);ctx.lineTo(483,136);ctx.lineTo(515,136);ctx.lineTo(545,135);ctx.lineTo(574,133);ctx.lineTo(610,128);ctx.lineTo(637,122);ctx.lineTo(655,112);ctx.lineTo(656,109);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(6.038462,1);ctx.arc(82.63694,100,26,0,Math.PI*2,true);ctx.scale(0.1656051,1);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillEllipse(sb, 4.63694f,28f,156f,156f);g.DrawEllipse(p, 4.63694f,28f,156f,156f);
listpt = new List<Point>();listpt.Add(new Point(656,109));listpt.Add(new Point(656,100));listpt.Add(new Point(342,100));listpt.Add(new Point(343,112));listpt.Add(new Point(369,124));listpt.Add(new Point(399,130));listpt.Add(new Point(438,134));listpt.Add(new Point(468,135));listpt.Add(new Point(483,136));listpt.Add(new Point(515,136));listpt.Add(new Point(545,135));listpt.Add(new Point(574,133));listpt.Add(new Point(610,128));listpt.Add(new Point(637,122));listpt.Add(new Point(655,112));listpt.Add(new Point(656,109));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillEllipse(sb, 56.63694f,74f,52f,52f);g.DrawEllipse(p, 56.63694f,74f,52f,52f);
        }
    }
}