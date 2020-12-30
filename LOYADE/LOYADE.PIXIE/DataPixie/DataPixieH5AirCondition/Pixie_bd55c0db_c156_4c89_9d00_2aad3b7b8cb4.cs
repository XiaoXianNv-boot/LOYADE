using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5AirCondition
{
    public class PIXIE_bd55c0db_c156_4c89_9d00_2aad3b7b8cb4 : Pixie
    {
        public PIXIE_bd55c0db_c156_4c89_9d00_2aad3b7b8cb4()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 170f; _h = 257f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(170,95);ctx.lineTo(170,257);ctx.lineTo(22,257);ctx.lineTo(22,95);ctx.lineTo(24,80);ctx.lineTo(28,66);ctx.lineTo(35,54);ctx.lineTo(44,43);ctx.lineTo(55,34);ctx.lineTo(68,28);ctx.lineTo(81,23);ctx.lineTo(96,22);ctx.lineTo(111,23);ctx.lineTo(124,28);ctx.lineTo(137,34);ctx.lineTo(148,43);ctx.lineTo(157,54);ctx.lineTo(164,66);ctx.lineTo(168,80);ctx.lineTo(170,95);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(170,95));listpt.Add(new Point(170,257));listpt.Add(new Point(22,257));listpt.Add(new Point(22,95));listpt.Add(new Point(24,80));listpt.Add(new Point(28,66));listpt.Add(new Point(35,54));listpt.Add(new Point(44,43));listpt.Add(new Point(55,34));listpt.Add(new Point(68,28));listpt.Add(new Point(81,23));listpt.Add(new Point(96,22));listpt.Add(new Point(111,23));listpt.Add(new Point(124,28));listpt.Add(new Point(137,34));listpt.Add(new Point(148,43));listpt.Add(new Point(157,54));listpt.Add(new Point(164,66));listpt.Add(new Point(168,80));listpt.Add(new Point(170,95));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}