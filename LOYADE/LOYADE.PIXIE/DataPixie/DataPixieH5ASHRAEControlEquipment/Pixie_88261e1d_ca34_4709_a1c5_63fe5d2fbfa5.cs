using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEControlEquipment
{
    public class PIXIE_88261e1d_ca34_4709_a1c5_63fe5d2fbfa5 : Pixie
    {
        public PIXIE_88261e1d_ca34_4709_a1c5_63fe5d2fbfa5()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 671f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(931,28);ctx.lineTo(946,31);ctx.lineTo(959,39);ctx.lineTo(967,52);ctx.lineTo(970,67);ctx.lineTo(967,82);ctx.lineTo(959,95);ctx.lineTo(946,103);ctx.lineTo(931,106);ctx.lineTo(656,106);ctx.lineTo(641,103);ctx.lineTo(628,95);ctx.lineTo(620,82);ctx.lineTo(617,67);ctx.lineTo(620,52);ctx.lineTo(628,39);ctx.lineTo(641,31);ctx.lineTo(656,28);ctx.lineTo(931,28);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,467);ctx.lineTo(146,263);ctx.lineTo(381,263);ctx.lineTo(499,467);ctx.lineTo(381,671);ctx.lineTo(146,671);ctx.lineTo(28,467);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(264,604,39,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(931,28));listpt.Add(new Point(946,31));listpt.Add(new Point(959,39));listpt.Add(new Point(967,52));listpt.Add(new Point(970,67));listpt.Add(new Point(967,82));listpt.Add(new Point(959,95));listpt.Add(new Point(946,103));listpt.Add(new Point(931,106));listpt.Add(new Point(656,106));listpt.Add(new Point(641,103));listpt.Add(new Point(628,95));listpt.Add(new Point(620,82));listpt.Add(new Point(617,67));listpt.Add(new Point(620,52));listpt.Add(new Point(628,39));listpt.Add(new Point(641,31));listpt.Add(new Point(656,28));listpt.Add(new Point(931,28));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,467));listpt.Add(new Point(146,263));listpt.Add(new Point(381,263));listpt.Add(new Point(499,467));listpt.Add(new Point(381,671));listpt.Add(new Point(146,671));listpt.Add(new Point(28,467));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.DrawEllipse(p, 225f,565f,78f,78f);
        }
    }
}