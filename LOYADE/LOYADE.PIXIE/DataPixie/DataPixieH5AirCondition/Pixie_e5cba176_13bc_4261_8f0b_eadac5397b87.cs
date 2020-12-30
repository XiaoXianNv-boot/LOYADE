using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5AirCondition
{
    public class PIXIE_e5cba176_13bc_4261_8f0b_eadac5397b87 : Pixie
    {
        public PIXIE_e5cba176_13bc_4261_8f0b_eadac5397b87()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 242f; _h = 257f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(242,148);ctx.lineTo(242,210);ctx.lineTo(7,257);ctx.lineTo(7,7);ctx.lineTo(242,54);ctx.lineTo(242,117);ctx.lineTo(226,117);ctx.lineTo(211,121);ctx.lineTo(195,132);ctx.lineTo(211,144);ctx.lineTo(226,148);ctx.lineTo(242,148);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(242,148));listpt.Add(new Point(242,210));listpt.Add(new Point(7,257));listpt.Add(new Point(7,7));listpt.Add(new Point(242,54));listpt.Add(new Point(242,117));listpt.Add(new Point(226,117));listpt.Add(new Point(211,121));listpt.Add(new Point(195,132));listpt.Add(new Point(211,144));listpt.Add(new Point(226,148));listpt.Add(new Point(242,148));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}