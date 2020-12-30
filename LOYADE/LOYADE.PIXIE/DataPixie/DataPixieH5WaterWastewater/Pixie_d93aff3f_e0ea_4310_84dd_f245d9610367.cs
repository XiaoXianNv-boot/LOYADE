using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WaterWastewater
{
    public class PIXIE_d93aff3f_e0ea_4310_84dd_f245d9610367 : Pixie
    {
        public PIXIE_d93aff3f_e0ea_4310_84dd_f245d9610367()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#8ca0bf"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#405473"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#405473"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#596d8c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 933f; _h = 218f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#8ca0bf'; arrFillColor[1] = '#405473'; arrFillColor[2] = '#405473'; arrFillColor[3] = '#596d8c'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* ellipse */ ctx.scale(6.038462,1);ctx.arc(82.63694,140,78,0,Math.PI*2,true);ctx.scale(0.1656051,1);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(741,200);ctx.lineTo(665,206);ctx.lineTo(584,210);ctx.lineTo(499,211);ctx.lineTo(415,210);ctx.lineTo(333,206);ctx.lineTo(258,200);ctx.lineTo(192,191);ctx.lineTo(138,180);ctx.lineTo(98,168);ctx.lineTo(74,154);ctx.lineTo(65,141);ctx.lineTo(73,127);ctx.lineTo(98,114);ctx.lineTo(138,101);ctx.lineTo(741,200);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(925,154);ctx.lineTo(333,75);ctx.lineTo(414,71);ctx.lineTo(499,70);ctx.lineTo(583,71);ctx.lineTo(665,75);ctx.lineTo(740,82);ctx.lineTo(806,91);ctx.lineTo(860,101);ctx.lineTo(900,114);ctx.lineTo(924,127);ctx.lineTo(933,141);ctx.lineTo(925,154);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(741,200);ctx.lineTo(665,206);ctx.lineTo(604,209);ctx.lineTo(138,127);ctx.lineTo(138,101);ctx.lineTo(741,200);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillEllipse(sb, 4.63694f,62f,156f,156f);g.DrawEllipse(p, 4.63694f,62f,156f,156f);
listpt = new List<Point>();listpt.Add(new Point(741,200));listpt.Add(new Point(665,206));listpt.Add(new Point(584,210));listpt.Add(new Point(499,211));listpt.Add(new Point(415,210));listpt.Add(new Point(333,206));listpt.Add(new Point(258,200));listpt.Add(new Point(192,191));listpt.Add(new Point(138,180));listpt.Add(new Point(98,168));listpt.Add(new Point(74,154));listpt.Add(new Point(65,141));listpt.Add(new Point(73,127));listpt.Add(new Point(98,114));listpt.Add(new Point(138,101));listpt.Add(new Point(741,200));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(925,154));listpt.Add(new Point(333,75));listpt.Add(new Point(414,71));listpt.Add(new Point(499,70));listpt.Add(new Point(583,71));listpt.Add(new Point(665,75));listpt.Add(new Point(740,82));listpt.Add(new Point(806,91));listpt.Add(new Point(860,101));listpt.Add(new Point(900,114));listpt.Add(new Point(924,127));listpt.Add(new Point(933,141));listpt.Add(new Point(925,154));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(741,200));listpt.Add(new Point(665,206));listpt.Add(new Point(604,209));listpt.Add(new Point(138,127));listpt.Add(new Point(138,101));listpt.Add(new Point(741,200));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}