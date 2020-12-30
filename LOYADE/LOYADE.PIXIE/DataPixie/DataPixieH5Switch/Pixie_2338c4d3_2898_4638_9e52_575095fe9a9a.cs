using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Switch
{
    public class PIXIE_2338c4d3_2898_4638_9e52_575095fe9a9a : Pixie
    {
        public PIXIE_2338c4d3_2898_4638_9e52_575095fe9a9a()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 713f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#e5e5e5'; arrFillColor[1] = '#7f7f7f'; arrFillColor[2] = '#b2b2b2'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(283,107);ctx.lineTo(379,126);ctx.lineTo(466,183);ctx.lineTo(520,273);ctx.lineTo(539,372);ctx.lineTo(520,472);ctx.lineTo(466,562);ctx.lineTo(379,619);ctx.lineTo(283,638);ctx.lineTo(187,619);ctx.lineTo(101,562);ctx.lineTo(46,472);ctx.lineTo(28,372);ctx.lineTo(46,273);ctx.lineTo(101,183);ctx.lineTo(187,126);ctx.lineTo(283,107);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(970,28);ctx.lineTo(970,713);ctx.lineTo(884,713);ctx.lineTo(884,28);ctx.lineTo(970,28);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(884,28);ctx.lineTo(285,199);ctx.lineTo(285,542);ctx.lineTo(884,713);ctx.lineTo(884,28);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(283,107));listpt.Add(new Point(379,126));listpt.Add(new Point(466,183));listpt.Add(new Point(520,273));listpt.Add(new Point(539,372));listpt.Add(new Point(520,472));listpt.Add(new Point(466,562));listpt.Add(new Point(379,619));listpt.Add(new Point(283,638));listpt.Add(new Point(187,619));listpt.Add(new Point(101,562));listpt.Add(new Point(46,472));listpt.Add(new Point(28,372));listpt.Add(new Point(46,273));listpt.Add(new Point(101,183));listpt.Add(new Point(187,126));listpt.Add(new Point(283,107));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(970,28));listpt.Add(new Point(970,713));listpt.Add(new Point(884,713));listpt.Add(new Point(884,28));listpt.Add(new Point(970,28));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(884,28));listpt.Add(new Point(285,199));listpt.Add(new Point(285,542));listpt.Add(new Point(884,713));listpt.Add(new Point(884,28));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}