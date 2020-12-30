using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Electrical
{
    public class PIXIE_03801a8c_e44a_4898_9ff7_180f002509af : Pixie
    {
        public PIXIE_03801a8c_e44a_4898_9ff7_180f002509af()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 160f; _h = 53f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#fff'; arrFillColor[1] = '#fff'; arrFillColor[2] = '#fff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(76,30);ctx.lineTo(77,33);ctx.lineTo(81,34);ctx.lineTo(84,33);ctx.lineTo(85,30);ctx.lineTo(84,26);ctx.lineTo(81,25);ctx.lineTo(77,26);ctx.lineTo(76,30);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(151,11);ctx.lineTo(152,14);ctx.lineTo(156,16);ctx.lineTo(159,14);ctx.lineTo(160,11);ctx.lineTo(159,8);ctx.lineTo(156,6);ctx.lineTo(152,8);ctx.lineTo(151,11);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(151,49);ctx.lineTo(152,52);ctx.lineTo(156,53);ctx.lineTo(159,52);ctx.lineTo(160,49);ctx.lineTo(159,45);ctx.lineTo(156,44);ctx.lineTo(152,45);ctx.lineTo(151,49);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(76,30));listpt.Add(new Point(77,33));listpt.Add(new Point(81,34));listpt.Add(new Point(84,33));listpt.Add(new Point(85,30));listpt.Add(new Point(84,26));listpt.Add(new Point(81,25));listpt.Add(new Point(77,26));listpt.Add(new Point(76,30));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(151,11));listpt.Add(new Point(152,14));listpt.Add(new Point(156,16));listpt.Add(new Point(159,14));listpt.Add(new Point(160,11));listpt.Add(new Point(159,8));listpt.Add(new Point(156,6));listpt.Add(new Point(152,8));listpt.Add(new Point(151,11));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(151,49));listpt.Add(new Point(152,52));listpt.Add(new Point(156,53));listpt.Add(new Point(159,52));listpt.Add(new Point(160,49));listpt.Add(new Point(159,45));listpt.Add(new Point(156,44));listpt.Add(new Point(152,45));listpt.Add(new Point(151,49));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}