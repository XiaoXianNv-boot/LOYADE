using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorBelt
{
    public class PIXIE_03201cb9_d3e1_4f12_8c79_d82ff78d182e : Pixie
    {
        public PIXIE_03201cb9_d3e1_4f12_8c79_d82ff78d182e()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#c0c0c0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 546f; _h = 499f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#c0c0c0'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(546,15);ctx.lineTo(546,389);ctx.lineTo(473,396);ctx.lineTo(402,418);ctx.lineTo(338,452);ctx.lineTo(280,499);ctx.lineTo(15,234);ctx.lineTo(131,141);ctx.lineTo(259,73);ctx.lineTo(400,29);ctx.lineTo(546,15);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(546,15));listpt.Add(new Point(546,389));listpt.Add(new Point(473,396));listpt.Add(new Point(402,418));listpt.Add(new Point(338,452));listpt.Add(new Point(280,499));listpt.Add(new Point(15,234));listpt.Add(new Point(131,141));listpt.Add(new Point(259,73));listpt.Add(new Point(400,29));listpt.Add(new Point(546,15));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}