using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_137c841b_2797_43d6_93f9_1d85663f61ee : Pixie
    {
        public PIXIE_137c841b_2797_43d6_93f9_1d85663f61ee()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#c0c0c0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#c0c0c0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#c0c0c0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 347f; _h = 197f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#c0c0c0'; arrFillColor[1] = '#c0c0c0'; arrFillColor[2] = '#c0c0c0'; arrFillColor[3] = '#fff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(47,47);ctx.lineTo(85,47);ctx.lineTo(47,10);ctx.lineTo(47,47);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(47,122);ctx.lineTo(47,160);ctx.lineTo(85,197);ctx.lineTo(85,160);ctx.lineTo(310,160);ctx.lineTo(272,122);ctx.lineTo(47,122);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(272,160);ctx.lineTo(310,197);ctx.lineTo(347,122);ctx.lineTo(310,47);ctx.lineTo(272,10);ctx.lineTo(310,85);ctx.lineTo(272,160);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(10,85);ctx.lineTo(47,10);ctx.lineTo(47,47);ctx.lineTo(272,47);ctx.lineTo(272,10);ctx.lineTo(310,85);ctx.lineTo(272,160);ctx.lineTo(272,122);ctx.lineTo(47,122);ctx.lineTo(47,160);ctx.lineTo(10,85);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(47,47));listpt.Add(new Point(85,47));listpt.Add(new Point(47,10));listpt.Add(new Point(47,47));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(47,122));listpt.Add(new Point(47,160));listpt.Add(new Point(85,197));listpt.Add(new Point(85,160));listpt.Add(new Point(310,160));listpt.Add(new Point(272,122));listpt.Add(new Point(47,122));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(272,160));listpt.Add(new Point(310,197));listpt.Add(new Point(347,122));listpt.Add(new Point(310,47));listpt.Add(new Point(272,10));listpt.Add(new Point(310,85));listpt.Add(new Point(272,160));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(10,85));listpt.Add(new Point(47,10));listpt.Add(new Point(47,47));listpt.Add(new Point(272,47));listpt.Add(new Point(272,10));listpt.Add(new Point(310,85));listpt.Add(new Point(272,160));listpt.Add(new Point(272,122));listpt.Add(new Point(47,122));listpt.Add(new Point(47,160));listpt.Add(new Point(10,85));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}