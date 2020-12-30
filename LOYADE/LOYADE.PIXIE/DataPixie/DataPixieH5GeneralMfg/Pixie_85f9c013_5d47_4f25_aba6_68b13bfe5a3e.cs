using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_85f9c013_5d47_4f25_aba6_68b13bfe5a3e : Pixie
    {
        public PIXIE_85f9c013_5d47_4f25_aba6_68b13bfe5a3e()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 257f; _h = 257f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(7,195);ctx.lineTo(7,179);ctx.lineTo(7,164);ctx.lineTo(7,148);ctx.lineTo(7,70);ctx.lineTo(8,54);ctx.lineTo(10,40);ctx.lineTo(14,29);ctx.lineTo(21,21);ctx.lineTo(29,15);ctx.lineTo(40,10);ctx.lineTo(53,8);ctx.lineTo(69,7);ctx.lineTo(85,7);ctx.lineTo(194,7);ctx.lineTo(210,8);ctx.lineTo(224,10);ctx.lineTo(235,15);ctx.lineTo(243,21);ctx.lineTo(249,29);ctx.lineTo(254,40);ctx.lineTo(256,54);ctx.lineTo(257,70);ctx.lineTo(257,85);ctx.lineTo(257,195);ctx.lineTo(256,212);ctx.lineTo(254,226);ctx.lineTo(249,237);ctx.lineTo(243,245);ctx.lineTo(235,251);ctx.lineTo(224,254);ctx.lineTo(210,256);ctx.lineTo(194,257);ctx.lineTo(179,257);ctx.lineTo(69,257);ctx.lineTo(53,256);ctx.lineTo(40,254);ctx.lineTo(29,250);ctx.lineTo(21,243);ctx.lineTo(14,235);ctx.lineTo(10,224);ctx.lineTo(8,211);ctx.lineTo(7,195);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(132,132,94,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(7,195));listpt.Add(new Point(7,179));listpt.Add(new Point(7,164));listpt.Add(new Point(7,148));listpt.Add(new Point(7,70));listpt.Add(new Point(8,54));listpt.Add(new Point(10,40));listpt.Add(new Point(14,29));listpt.Add(new Point(21,21));listpt.Add(new Point(29,15));listpt.Add(new Point(40,10));listpt.Add(new Point(53,8));listpt.Add(new Point(69,7));listpt.Add(new Point(85,7));listpt.Add(new Point(194,7));listpt.Add(new Point(210,8));listpt.Add(new Point(224,10));listpt.Add(new Point(235,15));listpt.Add(new Point(243,21));listpt.Add(new Point(249,29));listpt.Add(new Point(254,40));listpt.Add(new Point(256,54));listpt.Add(new Point(257,70));listpt.Add(new Point(257,85));listpt.Add(new Point(257,195));listpt.Add(new Point(256,212));listpt.Add(new Point(254,226));listpt.Add(new Point(249,237));listpt.Add(new Point(243,245));listpt.Add(new Point(235,251));listpt.Add(new Point(224,254));listpt.Add(new Point(210,256));listpt.Add(new Point(194,257));listpt.Add(new Point(179,257));listpt.Add(new Point(69,257));listpt.Add(new Point(53,256));listpt.Add(new Point(40,254));listpt.Add(new Point(29,250));listpt.Add(new Point(21,243));listpt.Add(new Point(14,235));listpt.Add(new Point(10,224));listpt.Add(new Point(8,211));listpt.Add(new Point(7,195));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 38f,38f,188f,188f);g.DrawEllipse(p, 38f,38f,188f,188f);
        }
    }
}