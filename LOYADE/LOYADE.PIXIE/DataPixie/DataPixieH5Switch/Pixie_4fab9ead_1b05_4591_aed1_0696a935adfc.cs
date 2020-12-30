using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Switch
{
    public class PIXIE_4fab9ead_1b05_4591_aed1_0696a935adfc : Pixie
    {
        public PIXIE_4fab9ead_1b05_4591_aed1_0696a935adfc()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 971f; _h = 713f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#e5e5e5'; arrFillColor[1] = '#b2b2b2'; arrFillColor[2] = '#7f7f7f'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(715,634);ctx.lineTo(619,615);ctx.lineTo(532,558);ctx.lineTo(478,468);ctx.lineTo(459,368);ctx.lineTo(478,269);ctx.lineTo(532,179);ctx.lineTo(619,122);ctx.lineTo(715,103);ctx.lineTo(811,122);ctx.lineTo(898,179);ctx.lineTo(952,269);ctx.lineTo(971,368);ctx.lineTo(952,468);ctx.lineTo(898,558);ctx.lineTo(811,615);ctx.lineTo(715,634);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(27,713);ctx.lineTo(27,27);ctx.lineTo(113,27);ctx.lineTo(113,713);ctx.lineTo(27,713);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(113,713);ctx.lineTo(714,542);ctx.lineTo(714,199);ctx.lineTo(113,27);ctx.lineTo(113,713);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(715,634));listpt.Add(new Point(619,615));listpt.Add(new Point(532,558));listpt.Add(new Point(478,468));listpt.Add(new Point(459,368));listpt.Add(new Point(478,269));listpt.Add(new Point(532,179));listpt.Add(new Point(619,122));listpt.Add(new Point(715,103));listpt.Add(new Point(811,122));listpt.Add(new Point(898,179));listpt.Add(new Point(952,269));listpt.Add(new Point(971,368));listpt.Add(new Point(952,468));listpt.Add(new Point(898,558));listpt.Add(new Point(811,615));listpt.Add(new Point(715,634));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(27,713));listpt.Add(new Point(27,27));listpt.Add(new Point(113,27));listpt.Add(new Point(113,713));listpt.Add(new Point(27,713));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(113,713));listpt.Add(new Point(714,542));listpt.Add(new Point(714,199));listpt.Add(new Point(113,27));listpt.Add(new Point(113,713));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}