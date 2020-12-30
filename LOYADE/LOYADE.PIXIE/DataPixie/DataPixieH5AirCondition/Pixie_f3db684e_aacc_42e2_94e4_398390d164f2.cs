using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5AirCondition
{
    public class PIXIE_f3db684e_aacc_42e2_94e4_398390d164f2 : Pixie
    {
        public PIXIE_f3db684e_aacc_42e2_94e4_398390d164f2()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 88f; _h = 257f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(88,240);ctx.lineTo(88,25);ctx.lineTo(87,18);ctx.lineTo(83,12);ctx.lineTo(77,8);ctx.lineTo(70,7);ctx.lineTo(64,8);ctx.lineTo(58,12);ctx.lineTo(54,18);ctx.lineTo(53,25);ctx.lineTo(53,240);ctx.lineTo(54,246);ctx.lineTo(58,252);ctx.lineTo(64,256);ctx.lineTo(70,257);ctx.lineTo(77,256);ctx.lineTo(83,252);ctx.lineTo(87,246);ctx.lineTo(88,240);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(88,240));listpt.Add(new Point(88,25));listpt.Add(new Point(87,18));listpt.Add(new Point(83,12));listpt.Add(new Point(77,8));listpt.Add(new Point(70,7));listpt.Add(new Point(64,8));listpt.Add(new Point(58,12));listpt.Add(new Point(54,18));listpt.Add(new Point(53,25));listpt.Add(new Point(53,240));listpt.Add(new Point(54,246));listpt.Add(new Point(58,252));listpt.Add(new Point(64,256));listpt.Add(new Point(70,257));listpt.Add(new Point(77,256));listpt.Add(new Point(83,252));listpt.Add(new Point(87,246));listpt.Add(new Point(88,240));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}