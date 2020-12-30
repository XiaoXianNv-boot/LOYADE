using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5AirCondition
{
    public class PIXIE_d72ce77f_6d83_40b8_9f1b_f81b0cd6b9f6 : Pixie
    {
        public PIXIE_d72ce77f_6d83_40b8_9f1b_f81b0cd6b9f6()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 127f; _h = 64f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(127,35);ctx.lineTo(124,28);ctx.lineTo(118,22);ctx.lineTo(112,17);ctx.lineTo(104,12);ctx.lineTo(96,8);ctx.lineTo(86,5);ctx.lineTo(76,4);ctx.lineTo(65,3);ctx.lineTo(54,4);ctx.lineTo(44,5);ctx.lineTo(35,8);ctx.lineTo(26,12);ctx.lineTo(18,17);ctx.lineTo(12,22);ctx.lineTo(7,28);ctx.lineTo(3,35);ctx.lineTo(127,35);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,35);ctx.lineTo(103,35);ctx.lineTo(103,64);ctx.lineTo(28,64);ctx.lineTo(28,35);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(127,35));listpt.Add(new Point(124,28));listpt.Add(new Point(118,22));listpt.Add(new Point(112,17));listpt.Add(new Point(104,12));listpt.Add(new Point(96,8));listpt.Add(new Point(86,5));listpt.Add(new Point(76,4));listpt.Add(new Point(65,3));listpt.Add(new Point(54,4));listpt.Add(new Point(44,5));listpt.Add(new Point(35,8));listpt.Add(new Point(26,12));listpt.Add(new Point(18,17));listpt.Add(new Point(12,22));listpt.Add(new Point(7,28));listpt.Add(new Point(3,35));listpt.Add(new Point(127,35));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,35));listpt.Add(new Point(103,35));listpt.Add(new Point(103,64));listpt.Add(new Point(28,64));listpt.Add(new Point(28,35));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}