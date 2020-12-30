using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Architectural
{
    public class PIXIE_b409676f_7380_482f_947c_3646715eff46 : Pixie
    {
        public PIXIE_b409676f_7380_482f_947c_3646715eff46()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ffff7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#cc0"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 262f; _h = 970f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#999'; arrFillColor[1] = '#ffff7f'; arrFillColor[2] = '#b2b2b2'; arrFillColor[3] = '#e5e5e5'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#cc0'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(111,743);ctx.lineTo(111,29);ctx.lineTo(176,28);ctx.lineTo(176,743);ctx.lineTo(111,743);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(65,946);ctx.lineTo(98,962);ctx.lineTo(143,970);ctx.lineTo(188,962);ctx.lineTo(225,946);ctx.lineTo(233,917);ctx.lineTo(52,917);ctx.lineTo(65,946);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(36,909);ctx.lineTo(52,798);ctx.lineTo(89,744);ctx.lineTo(196,744);ctx.lineTo(233,798);ctx.lineTo(254,909);ctx.lineTo(36,909);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,909);ctx.lineTo(28,925);ctx.lineTo(262,925);ctx.lineTo(262,909);ctx.lineTo(28,909);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(111,743));listpt.Add(new Point(111,29));listpt.Add(new Point(176,28));listpt.Add(new Point(176,743));listpt.Add(new Point(111,743));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(65,946));listpt.Add(new Point(98,962));listpt.Add(new Point(143,970));listpt.Add(new Point(188,962));listpt.Add(new Point(225,946));listpt.Add(new Point(233,917));listpt.Add(new Point(52,917));listpt.Add(new Point(65,946));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(36,909));listpt.Add(new Point(52,798));listpt.Add(new Point(89,744));listpt.Add(new Point(196,744));listpt.Add(new Point(233,798));listpt.Add(new Point(254,909));listpt.Add(new Point(36,909));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,909));listpt.Add(new Point(28,925));listpt.Add(new Point(262,925));listpt.Add(new Point(262,909));listpt.Add(new Point(28,909));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}