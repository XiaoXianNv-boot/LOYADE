using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Boiler
{
    public class PIXIE_68ccae3e_7488_42a4_8290_a0eca293dc1a : Pixie
    {
        public PIXIE_68ccae3e_7488_42a4_8290_a0eca293dc1a()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#666"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 637f; _h = 931f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#e5e5e5'; arrFillColor[1] = '#7f7f7f'; arrFillColor[2] = '#ccc'; arrFillColor[3] = '#b2b2b2'; arrFillColor[4] = '#666'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(137,925);ctx.lineTo(116,931);ctx.lineTo(96,931);ctx.lineTo(77,925);ctx.lineTo(58,915);ctx.lineTo(43,901);ctx.lineTo(33,884);ctx.lineTo(28,863);ctx.lineTo(28,842);ctx.lineTo(33,821);ctx.lineTo(43,804);ctx.lineTo(58,789);ctx.lineTo(77,780);ctx.lineTo(96,774);ctx.lineTo(224,774);ctx.lineTo(224,863);ctx.lineTo(184,863);ctx.lineTo(179,884);ctx.lineTo(169,901);ctx.lineTo(154,915);ctx.lineTo(137,925);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(106,852,20,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(224,852);ctx.lineTo(245,842);ctx.lineTo(245,793);ctx.lineTo(224,784);ctx.lineTo(224,852);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(401,184);ctx.lineTo(322,233);ctx.lineTo(322,303);ctx.lineTo(401,303);ctx.lineTo(401,420);ctx.lineTo(557,420);ctx.lineTo(557,303);ctx.lineTo(637,303);ctx.lineTo(637,243);ctx.lineTo(557,184);ctx.lineTo(557,67);ctx.lineTo(478,60);ctx.lineTo(475,49);ctx.lineTo(467,39);ctx.lineTo(458,32);ctx.lineTo(446,28);ctx.lineTo(433,28);ctx.lineTo(422,32);ctx.lineTo(412,39);ctx.lineTo(405,49);ctx.lineTo(401,60);ctx.lineTo(401,184);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(517,67,39,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(137,925));listpt.Add(new Point(116,931));listpt.Add(new Point(96,931));listpt.Add(new Point(77,925));listpt.Add(new Point(58,915));listpt.Add(new Point(43,901));listpt.Add(new Point(33,884));listpt.Add(new Point(28,863));listpt.Add(new Point(28,842));listpt.Add(new Point(33,821));listpt.Add(new Point(43,804));listpt.Add(new Point(58,789));listpt.Add(new Point(77,780));listpt.Add(new Point(96,774));listpt.Add(new Point(224,774));listpt.Add(new Point(224,863));listpt.Add(new Point(184,863));listpt.Add(new Point(179,884));listpt.Add(new Point(169,901));listpt.Add(new Point(154,915));listpt.Add(new Point(137,925));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 86f,832f,40f,40f);g.DrawEllipse(p, 86f,832f,40f,40f);
listpt = new List<Point>();listpt.Add(new Point(224,852));listpt.Add(new Point(245,842));listpt.Add(new Point(245,793));listpt.Add(new Point(224,784));listpt.Add(new Point(224,852));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(401,184));listpt.Add(new Point(322,233));listpt.Add(new Point(322,303));listpt.Add(new Point(401,303));listpt.Add(new Point(401,420));listpt.Add(new Point(557,420));listpt.Add(new Point(557,303));listpt.Add(new Point(637,303));listpt.Add(new Point(637,243));listpt.Add(new Point(557,184));listpt.Add(new Point(557,67));listpt.Add(new Point(478,60));listpt.Add(new Point(475,49));listpt.Add(new Point(467,39));listpt.Add(new Point(458,32));listpt.Add(new Point(446,28));listpt.Add(new Point(433,28));listpt.Add(new Point(422,32));listpt.Add(new Point(412,39));listpt.Add(new Point(405,49));listpt.Add(new Point(401,60));listpt.Add(new Point(401,184));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillEllipse(sb, 478f,28f,78f,78f);g.DrawEllipse(p, 478f,28f,78f,78f);
        }
    }
}