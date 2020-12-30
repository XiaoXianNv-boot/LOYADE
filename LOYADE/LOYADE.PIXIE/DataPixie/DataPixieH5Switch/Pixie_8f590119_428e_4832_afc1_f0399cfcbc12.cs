using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Switch
{
    public class PIXIE_8f590119_428e_4832_afc1_f0399cfcbc12 : Pixie
    {
        public PIXIE_8f590119_428e_4832_afc1_f0399cfcbc12()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 712f; _h = 970f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#e5e5e5'; arrFillColor[1] = '#b2b2b2'; arrFillColor[2] = '#7f7f7f'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(106,715);ctx.lineTo(125,619);ctx.lineTo(182,532);ctx.lineTo(272,478);ctx.lineTo(371,460);ctx.lineTo(471,478);ctx.lineTo(561,532);ctx.lineTo(617,619);ctx.lineTo(637,715);ctx.lineTo(617,811);ctx.lineTo(561,898);ctx.lineTo(471,952);ctx.lineTo(371,970);ctx.lineTo(272,952);ctx.lineTo(182,898);ctx.lineTo(125,811);ctx.lineTo(106,715);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,28);ctx.lineTo(712,28);ctx.lineTo(712,114);ctx.lineTo(28,114);ctx.lineTo(28,28);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,114);ctx.lineTo(198,714);ctx.lineTo(541,714);ctx.lineTo(712,114);ctx.lineTo(28,114);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(106,715));listpt.Add(new Point(125,619));listpt.Add(new Point(182,532));listpt.Add(new Point(272,478));listpt.Add(new Point(371,460));listpt.Add(new Point(471,478));listpt.Add(new Point(561,532));listpt.Add(new Point(617,619));listpt.Add(new Point(637,715));listpt.Add(new Point(617,811));listpt.Add(new Point(561,898));listpt.Add(new Point(471,952));listpt.Add(new Point(371,970));listpt.Add(new Point(272,952));listpt.Add(new Point(182,898));listpt.Add(new Point(125,811));listpt.Add(new Point(106,715));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,28));listpt.Add(new Point(712,28));listpt.Add(new Point(712,114));listpt.Add(new Point(28,114));listpt.Add(new Point(28,28));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,114));listpt.Add(new Point(198,714));listpt.Add(new Point(541,714));listpt.Add(new Point(712,114));listpt.Add(new Point(28,114));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}