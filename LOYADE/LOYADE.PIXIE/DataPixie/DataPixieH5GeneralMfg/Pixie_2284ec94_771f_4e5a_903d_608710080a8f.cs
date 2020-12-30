using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_2284ec94_771f_4e5a_903d_608710080a8f : Pixie
    {
        public PIXIE_2284ec94_771f_4e5a_903d_608710080a8f()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 310f; _h = 134f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,134);ctx.lineTo(15,128);ctx.lineTo(11,122);ctx.lineTo(9,115);ctx.lineTo(9,104);ctx.lineTo(9,28);ctx.lineTo(15,15);ctx.lineTo(21,11);ctx.lineTo(28,9);ctx.lineTo(44,9);ctx.lineTo(291,9);ctx.lineTo(304,15);ctx.lineTo(308,21);ctx.lineTo(310,28);ctx.lineTo(310,39);ctx.lineTo(310,115);ctx.lineTo(304,128);ctx.lineTo(298,132);ctx.lineTo(291,134);ctx.lineTo(288,134);ctx.lineTo(278,134);ctx.lineTo(278,115);ctx.lineTo(285,115);ctx.lineTo(289,113);ctx.lineTo(291,109);ctx.lineTo(291,34);ctx.lineTo(289,30);ctx.lineTo(285,28);ctx.lineTo(34,28);ctx.lineTo(30,30);ctx.lineTo(28,34);ctx.lineTo(28,109);ctx.lineTo(30,113);ctx.lineTo(34,115);ctx.lineTo(40,115);ctx.lineTo(40,134);ctx.lineTo(28,134);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,134));listpt.Add(new Point(15,128));listpt.Add(new Point(11,122));listpt.Add(new Point(9,115));listpt.Add(new Point(9,104));listpt.Add(new Point(9,28));listpt.Add(new Point(15,15));listpt.Add(new Point(21,11));listpt.Add(new Point(28,9));listpt.Add(new Point(44,9));listpt.Add(new Point(291,9));listpt.Add(new Point(304,15));listpt.Add(new Point(308,21));listpt.Add(new Point(310,28));listpt.Add(new Point(310,39));listpt.Add(new Point(310,115));listpt.Add(new Point(304,128));listpt.Add(new Point(298,132));listpt.Add(new Point(291,134));listpt.Add(new Point(288,134));listpt.Add(new Point(278,134));listpt.Add(new Point(278,115));listpt.Add(new Point(285,115));listpt.Add(new Point(289,113));listpt.Add(new Point(291,109));listpt.Add(new Point(291,34));listpt.Add(new Point(289,30));listpt.Add(new Point(285,28));listpt.Add(new Point(34,28));listpt.Add(new Point(30,30));listpt.Add(new Point(28,34));listpt.Add(new Point(28,109));listpt.Add(new Point(30,113));listpt.Add(new Point(34,115));listpt.Add(new Point(40,115));listpt.Add(new Point(40,134));listpt.Add(new Point(28,134));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}