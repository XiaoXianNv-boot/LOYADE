using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Food
{
    public class PIXIE_942c3321_b445_4bf8_98f1_32fa6416efd4 : Pixie
    {
        public PIXIE_942c3321_b445_4bf8_98f1_32fa6416efd4()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#cff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#cff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#cff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 715f; _h = 970f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#cff'; arrFillColor[1] = '#cff'; arrFillColor[2] = '#cff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(485,855);ctx.lineTo(417,863);ctx.lineTo(346,863);ctx.lineTo(278,855);ctx.lineTo(218,839);ctx.lineTo(167,814);ctx.lineTo(131,784);ctx.lineTo(114,752);ctx.lineTo(114,139);ctx.lineTo(131,107);ctx.lineTo(167,77);ctx.lineTo(218,54);ctx.lineTo(278,37);ctx.lineTo(346,28);ctx.lineTo(417,28);ctx.lineTo(485,37);ctx.lineTo(547,54);ctx.lineTo(596,77);ctx.lineTo(632,107);ctx.lineTo(649,139);ctx.lineTo(649,752);ctx.lineTo(632,784);ctx.lineTo(596,814);ctx.lineTo(545,839);ctx.lineTo(485,855);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(114,970);ctx.lineTo(114,585);ctx.lineTo(49,671);ctx.lineTo(49,970);ctx.lineTo(114,970);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(651,970);ctx.lineTo(651,585);ctx.lineTo(715,671);ctx.lineTo(715,970);ctx.lineTo(651,970);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(485,855));listpt.Add(new Point(417,863));listpt.Add(new Point(346,863));listpt.Add(new Point(278,855));listpt.Add(new Point(218,839));listpt.Add(new Point(167,814));listpt.Add(new Point(131,784));listpt.Add(new Point(114,752));listpt.Add(new Point(114,139));listpt.Add(new Point(131,107));listpt.Add(new Point(167,77));listpt.Add(new Point(218,54));listpt.Add(new Point(278,37));listpt.Add(new Point(346,28));listpt.Add(new Point(417,28));listpt.Add(new Point(485,37));listpt.Add(new Point(547,54));listpt.Add(new Point(596,77));listpt.Add(new Point(632,107));listpt.Add(new Point(649,139));listpt.Add(new Point(649,752));listpt.Add(new Point(632,784));listpt.Add(new Point(596,814));listpt.Add(new Point(545,839));listpt.Add(new Point(485,855));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(114,970));listpt.Add(new Point(114,585));listpt.Add(new Point(49,671));listpt.Add(new Point(49,970));listpt.Add(new Point(114,970));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(651,970));listpt.Add(new Point(651,585));listpt.Add(new Point(715,671));listpt.Add(new Point(715,970));listpt.Add(new Point(651,970));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}