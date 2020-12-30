using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Food
{
    public class PIXIE_bcb8c084_0558_4556_aaf2_af1330a8ceff : Pixie
    {
        public PIXIE_bcb8c084_0558_4556_aaf2_af1330a8ceff()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#030"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#363"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#030"));_listfillcolor.Add(ColorTranslator.FromHtml("#363"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 759f; _h = 931f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#030'; arrFillColor[1] = '#363'; arrFillColor[2] = '#b2b2b2'; arrFillColor[3] = '#ccc'; arrFillColor[4] = '#363'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#030'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(56,629);ctx.lineTo(56,917);ctx.lineTo(111,917);ctx.lineTo(111,629);ctx.lineTo(552,629);ctx.lineTo(552,917);ctx.lineTo(605,917);ctx.lineTo(605,629);ctx.lineTo(614,629);ctx.lineTo(614,576);ctx.lineTo(111,576);ctx.lineTo(111,531);ctx.lineTo(56,531);ctx.lineTo(56,576);ctx.lineTo(46,576);ctx.lineTo(46,629);ctx.lineTo(56,629);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(623,642);ctx.lineTo(759,642);ctx.lineTo(759,748);ctx.lineTo(623,748);ctx.lineTo(623,642);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(210,382);ctx.lineTo(210,335);ctx.lineTo(220,335);ctx.lineTo(220,229);ctx.lineTo(152,229);ctx.lineTo(152,316);ctx.lineTo(210,382);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(451,37,10,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(37,623);ctx.lineTo(37,931);ctx.lineTo(95,931);ctx.lineTo(95,623);ctx.lineTo(567,623);ctx.lineTo(567,931);ctx.lineTo(623,931);ctx.lineTo(623,623);ctx.lineTo(633,623);ctx.lineTo(633,565);ctx.lineTo(95,565);ctx.lineTo(95,518);ctx.lineTo(37,518);ctx.lineTo(37,565);ctx.lineTo(28,565);ctx.lineTo(28,623);ctx.lineTo(37,623);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(56,629));listpt.Add(new Point(56,917));listpt.Add(new Point(111,917));listpt.Add(new Point(111,629));listpt.Add(new Point(552,629));listpt.Add(new Point(552,917));listpt.Add(new Point(605,917));listpt.Add(new Point(605,629));listpt.Add(new Point(614,629));listpt.Add(new Point(614,576));listpt.Add(new Point(111,576));listpt.Add(new Point(111,531));listpt.Add(new Point(56,531));listpt.Add(new Point(56,576));listpt.Add(new Point(46,576));listpt.Add(new Point(46,629));listpt.Add(new Point(56,629));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(623,642));listpt.Add(new Point(759,642));listpt.Add(new Point(759,748));listpt.Add(new Point(623,748));listpt.Add(new Point(623,642));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(210,382));listpt.Add(new Point(210,335));listpt.Add(new Point(220,335));listpt.Add(new Point(220,229));listpt.Add(new Point(152,229));listpt.Add(new Point(152,316));listpt.Add(new Point(210,382));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillEllipse(sb, 441f,27f,20f,20f);g.DrawEllipse(p, 441f,27f,20f,20f);
listpt = new List<Point>();listpt.Add(new Point(37,623));listpt.Add(new Point(37,931));listpt.Add(new Point(95,931));listpt.Add(new Point(95,623));listpt.Add(new Point(567,623));listpt.Add(new Point(567,931));listpt.Add(new Point(623,931));listpt.Add(new Point(623,623));listpt.Add(new Point(633,623));listpt.Add(new Point(633,565));listpt.Add(new Point(95,565));listpt.Add(new Point(95,518));listpt.Add(new Point(37,518));listpt.Add(new Point(37,565));listpt.Add(new Point(28,565));listpt.Add(new Point(28,623));listpt.Add(new Point(37,623));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}