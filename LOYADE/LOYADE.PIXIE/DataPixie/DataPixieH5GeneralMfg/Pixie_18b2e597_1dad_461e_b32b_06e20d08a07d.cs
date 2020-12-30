using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_18b2e597_1dad_461e_b32b_06e20d08a07d : Pixie
    {
        public PIXIE_18b2e597_1dad_461e_b32b_06e20d08a07d()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 257f; _h = 132f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(257,132);ctx.lineTo(252,132);ctx.lineTo(247,132);ctx.lineTo(242,132);ctx.lineTo(233,131);ctx.lineTo(227,124);ctx.lineTo(226,120);ctx.lineTo(226,46);ctx.lineTo(224,40);ctx.lineTo(218,38);ctx.lineTo(144,38);ctx.lineTo(140,37);ctx.lineTo(133,31);ctx.lineTo(132,27);ctx.lineTo(132,22);ctx.lineTo(132,12);ctx.lineTo(132,7);ctx.lineTo(136,7);ctx.lineTo(148,7);ctx.lineTo(148,20);ctx.lineTo(150,23);ctx.lineTo(226,23);ctx.lineTo(231,24);ctx.lineTo(236,27);ctx.lineTo(240,32);ctx.lineTo(241,38);ctx.lineTo(241,114);ctx.lineTo(244,116);ctx.lineTo(254,116);ctx.lineTo(257,116);ctx.lineTo(257,120);ctx.lineTo(257,132);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(7,132);ctx.lineTo(12,132);ctx.lineTo(17,132);ctx.lineTo(21,132);ctx.lineTo(30,131);ctx.lineTo(37,124);ctx.lineTo(38,120);ctx.lineTo(38,46);ctx.lineTo(41,40);ctx.lineTo(46,38);ctx.lineTo(120,38);ctx.lineTo(124,37);ctx.lineTo(131,31);ctx.lineTo(132,27);ctx.lineTo(132,22);ctx.lineTo(132,12);ctx.lineTo(132,7);ctx.lineTo(128,7);ctx.lineTo(116,7);ctx.lineTo(116,20);ctx.lineTo(115,22);ctx.lineTo(113,23);ctx.lineTo(38,23);ctx.lineTo(32,24);ctx.lineTo(28,27);ctx.lineTo(24,32);ctx.lineTo(23,38);ctx.lineTo(23,114);ctx.lineTo(20,116);ctx.lineTo(10,116);ctx.lineTo(7,116);ctx.lineTo(7,120);ctx.lineTo(7,132);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(257,132));listpt.Add(new Point(252,132));listpt.Add(new Point(247,132));listpt.Add(new Point(242,132));listpt.Add(new Point(233,131));listpt.Add(new Point(227,124));listpt.Add(new Point(226,120));listpt.Add(new Point(226,46));listpt.Add(new Point(224,40));listpt.Add(new Point(218,38));listpt.Add(new Point(144,38));listpt.Add(new Point(140,37));listpt.Add(new Point(133,31));listpt.Add(new Point(132,27));listpt.Add(new Point(132,22));listpt.Add(new Point(132,12));listpt.Add(new Point(132,7));listpt.Add(new Point(136,7));listpt.Add(new Point(148,7));listpt.Add(new Point(148,20));listpt.Add(new Point(150,23));listpt.Add(new Point(226,23));listpt.Add(new Point(231,24));listpt.Add(new Point(236,27));listpt.Add(new Point(240,32));listpt.Add(new Point(241,38));listpt.Add(new Point(241,114));listpt.Add(new Point(244,116));listpt.Add(new Point(254,116));listpt.Add(new Point(257,116));listpt.Add(new Point(257,120));listpt.Add(new Point(257,132));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(7,132));listpt.Add(new Point(12,132));listpt.Add(new Point(17,132));listpt.Add(new Point(21,132));listpt.Add(new Point(30,131));listpt.Add(new Point(37,124));listpt.Add(new Point(38,120));listpt.Add(new Point(38,46));listpt.Add(new Point(41,40));listpt.Add(new Point(46,38));listpt.Add(new Point(120,38));listpt.Add(new Point(124,37));listpt.Add(new Point(131,31));listpt.Add(new Point(132,27));listpt.Add(new Point(132,22));listpt.Add(new Point(132,12));listpt.Add(new Point(132,7));listpt.Add(new Point(128,7));listpt.Add(new Point(116,7));listpt.Add(new Point(116,20));listpt.Add(new Point(115,22));listpt.Add(new Point(113,23));listpt.Add(new Point(38,23));listpt.Add(new Point(32,24));listpt.Add(new Point(28,27));listpt.Add(new Point(24,32));listpt.Add(new Point(23,38));listpt.Add(new Point(23,114));listpt.Add(new Point(20,116));listpt.Add(new Point(10,116));listpt.Add(new Point(7,116));listpt.Add(new Point(7,120));listpt.Add(new Point(7,132));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}