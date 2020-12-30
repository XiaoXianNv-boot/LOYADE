using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Food
{
    public class PIXIE_c1d93e53_36e4_47be_a7a6_159c872842b7 : Pixie
    {
        public PIXIE_c1d93e53_36e4_47be_a7a6_159c872842b7()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#bfbfcc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#333"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 530f; _h = 615f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#4c4c4c'; arrFillColor[1] = '#bfbfcc'; arrFillColor[2] = '#333'; arrBorderColor[0] = '#7f7f7f'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* circle */ ctx.arc(289,248,32,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(225,585);ctx.lineTo(204,558);ctx.lineTo(195,526);ctx.lineTo(195,492);ctx.lineTo(204,460);ctx.lineTo(225,434);ctx.lineTo(252,415);ctx.lineTo(283,404);ctx.lineTo(316,404);ctx.lineTo(348,415);ctx.lineTo(376,434);ctx.lineTo(395,460);ctx.lineTo(404,492);ctx.lineTo(404,526);ctx.lineTo(395,558);ctx.lineTo(376,585);ctx.lineTo(348,603);ctx.lineTo(317,615);ctx.lineTo(283,615);ctx.lineTo(252,603);ctx.lineTo(225,585);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(300,509,39,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(489,551);ctx.lineTo(530,551);ctx.lineTo(530,592);ctx.lineTo(489,592);ctx.lineTo(489,551);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.DrawEllipse(p, 257f,216f,64f,64f);
listpt = new List<Point>();listpt.Add(new Point(225,585));listpt.Add(new Point(204,558));listpt.Add(new Point(195,526));listpt.Add(new Point(195,492));listpt.Add(new Point(204,460));listpt.Add(new Point(225,434));listpt.Add(new Point(252,415));listpt.Add(new Point(283,404));listpt.Add(new Point(316,404));listpt.Add(new Point(348,415));listpt.Add(new Point(376,434));listpt.Add(new Point(395,460));listpt.Add(new Point(404,492));listpt.Add(new Point(404,526));listpt.Add(new Point(395,558));listpt.Add(new Point(376,585));listpt.Add(new Point(348,603));listpt.Add(new Point(317,615));listpt.Add(new Point(283,615));listpt.Add(new Point(252,603));listpt.Add(new Point(225,585));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillEllipse(sb, 261f,470f,78f,78f);g.DrawEllipse(p, 261f,470f,78f,78f);
listpt = new List<Point>();listpt.Add(new Point(489,551));listpt.Add(new Point(530,551));listpt.Add(new Point(530,592));listpt.Add(new Point(489,592));listpt.Add(new Point(489,551));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}