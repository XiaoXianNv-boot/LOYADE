using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Food
{
    public class PIXIE_a18c34c6_7d67_428b_8700_048e780892c6 : Pixie
    {
        public PIXIE_a18c34c6_7d67_428b_8700_048e780892c6()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#c63"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#c63"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#666"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 510f; _h = 970f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#c63'; arrFillColor[1] = '#c63'; arrFillColor[2] = '#4c4c4c'; arrFillColor[3] = '#666'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(39,478);ctx.lineTo(39,56);ctx.lineTo(56,48);ctx.lineTo(86,41);ctx.lineTo(129,35);ctx.lineTo(184,29);ctx.lineTo(244,28);ctx.lineTo(305,28);ctx.lineTo(365,29);ctx.lineTo(420,35);ctx.lineTo(463,41);ctx.lineTo(493,48);ctx.lineTo(510,56);ctx.lineTo(510,478);ctx.lineTo(39,478);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(341,967);ctx.lineTo(297,970);ctx.lineTo(252,970);ctx.lineTo(209,967);ctx.lineTo(169,959);ctx.lineTo(167,917);ctx.lineTo(137,906);ctx.lineTo(114,895);ctx.lineTo(103,882);ctx.lineTo(103,759);ctx.lineTo(446,759);ctx.lineTo(446,882);ctx.lineTo(435,895);ctx.lineTo(412,906);ctx.lineTo(382,917);ctx.lineTo(380,959);ctx.lineTo(341,967);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(39,478);ctx.lineTo(50,488);ctx.lineTo(50,520);ctx.lineTo(499,520);ctx.lineTo(499,488);ctx.lineTo(510,478);ctx.lineTo(39,478);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(9,1);ctx.arc(30.44444,701,19,0,Math.PI*2,true);ctx.scale(0.1111111,1);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(39,478));listpt.Add(new Point(39,56));listpt.Add(new Point(56,48));listpt.Add(new Point(86,41));listpt.Add(new Point(129,35));listpt.Add(new Point(184,29));listpt.Add(new Point(244,28));listpt.Add(new Point(305,28));listpt.Add(new Point(365,29));listpt.Add(new Point(420,35));listpt.Add(new Point(463,41));listpt.Add(new Point(493,48));listpt.Add(new Point(510,56));listpt.Add(new Point(510,478));listpt.Add(new Point(39,478));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(341,967));listpt.Add(new Point(297,970));listpt.Add(new Point(252,970));listpt.Add(new Point(209,967));listpt.Add(new Point(169,959));listpt.Add(new Point(167,917));listpt.Add(new Point(137,906));listpt.Add(new Point(114,895));listpt.Add(new Point(103,882));listpt.Add(new Point(103,759));listpt.Add(new Point(446,759));listpt.Add(new Point(446,882));listpt.Add(new Point(435,895));listpt.Add(new Point(412,906));listpt.Add(new Point(382,917));listpt.Add(new Point(380,959));listpt.Add(new Point(341,967));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(39,478));listpt.Add(new Point(50,488));listpt.Add(new Point(50,520));listpt.Add(new Point(499,520));listpt.Add(new Point(499,488));listpt.Add(new Point(510,478));listpt.Add(new Point(39,478));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillEllipse(sb, 11.44444f,682f,38f,38f);g.DrawEllipse(p, 11.44444f,682f,38f,38f);
        }
    }
}