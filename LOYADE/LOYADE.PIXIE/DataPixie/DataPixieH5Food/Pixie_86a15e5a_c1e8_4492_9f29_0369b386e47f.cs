using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Food
{
    public class PIXIE_86a15e5a_c1e8_4492_9f29_0369b386e47f : Pixie
    {
        public PIXIE_86a15e5a_c1e8_4492_9f29_0369b386e47f()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listfillcolor.Add(ColorTranslator.FromHtml("#333"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 342f; _h = 870f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#ccc'; arrFillColor[1] = '#ccc'; arrFillColor[2] = '#ccc'; arrFillColor[3] = '#333'; arrFillColor[4] = '#b2b2b2'; arrBorderColor[0] = '#7f7f7f'; arrBorderColor[1] = '#7f7f7f'; arrBorderColor[2] = '#7f7f7f'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* circle */ ctx.arc(301,469,41,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(301,680,41,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(203,782,17,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(329,735);ctx.lineTo(333,746);ctx.lineTo(337,757);ctx.lineTo(337,769);ctx.lineTo(337,778);ctx.lineTo(335,787);ctx.lineTo(331,795);ctx.lineTo(325,801);ctx.lineTo(62,870);ctx.lineTo(56,869);ctx.lineTo(48,865);ctx.lineTo(43,857);ctx.lineTo(37,850);ctx.lineTo(31,838);ctx.lineTo(30,827);ctx.lineTo(28,816);ctx.lineTo(28,804);ctx.lineTo(30,795);ctx.lineTo(33,787);ctx.lineTo(39,784);ctx.lineTo(303,714);ctx.lineTo(309,714);ctx.lineTo(316,718);ctx.lineTo(324,725);ctx.lineTo(329,735);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(77,802);ctx.lineTo(80,812);ctx.lineTo(84,825);ctx.lineTo(86,837);ctx.lineTo(84,846);ctx.lineTo(82,855);ctx.lineTo(79,863);ctx.lineTo(73,867);ctx.lineTo(62,870);ctx.lineTo(56,869);ctx.lineTo(48,865);ctx.lineTo(43,857);ctx.lineTo(37,850);ctx.lineTo(31,838);ctx.lineTo(30,827);ctx.lineTo(28,816);ctx.lineTo(28,804);ctx.lineTo(30,795);ctx.lineTo(33,787);ctx.lineTo(39,784);ctx.lineTo(50,780);ctx.lineTo(58,782);ctx.lineTo(63,786);ctx.lineTo(71,793);ctx.lineTo(77,802);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillEllipse(sb, 260f,428f,82f,82f);g.DrawEllipse(p, 260f,428f,82f,82f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 260f,639f,82f,82f);g.DrawEllipse(p, 260f,639f,82f,82f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillEllipse(sb, 186f,765f,34f,34f);g.DrawEllipse(p, 186f,765f,34f,34f);
listpt = new List<Point>();listpt.Add(new Point(329,735));listpt.Add(new Point(333,746));listpt.Add(new Point(337,757));listpt.Add(new Point(337,769));listpt.Add(new Point(337,778));listpt.Add(new Point(335,787));listpt.Add(new Point(331,795));listpt.Add(new Point(325,801));listpt.Add(new Point(62,870));listpt.Add(new Point(56,869));listpt.Add(new Point(48,865));listpt.Add(new Point(43,857));listpt.Add(new Point(37,850));listpt.Add(new Point(31,838));listpt.Add(new Point(30,827));listpt.Add(new Point(28,816));listpt.Add(new Point(28,804));listpt.Add(new Point(30,795));listpt.Add(new Point(33,787));listpt.Add(new Point(39,784));listpt.Add(new Point(303,714));listpt.Add(new Point(309,714));listpt.Add(new Point(316,718));listpt.Add(new Point(324,725));listpt.Add(new Point(329,735));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(77,802));listpt.Add(new Point(80,812));listpt.Add(new Point(84,825));listpt.Add(new Point(86,837));listpt.Add(new Point(84,846));listpt.Add(new Point(82,855));listpt.Add(new Point(79,863));listpt.Add(new Point(73,867));listpt.Add(new Point(62,870));listpt.Add(new Point(56,869));listpt.Add(new Point(48,865));listpt.Add(new Point(43,857));listpt.Add(new Point(37,850));listpt.Add(new Point(31,838));listpt.Add(new Point(30,827));listpt.Add(new Point(28,816));listpt.Add(new Point(28,804));listpt.Add(new Point(30,795));listpt.Add(new Point(33,787));listpt.Add(new Point(39,784));listpt.Add(new Point(50,780));listpt.Add(new Point(58,782));listpt.Add(new Point(63,786));listpt.Add(new Point(71,793));listpt.Add(new Point(77,802));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}