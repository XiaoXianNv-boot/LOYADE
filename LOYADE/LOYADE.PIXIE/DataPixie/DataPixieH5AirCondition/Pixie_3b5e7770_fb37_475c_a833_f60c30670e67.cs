using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5AirCondition
{
    public class PIXIE_3b5e7770_fb37_475c_a833_f60c30670e67 : Pixie
    {
        public PIXIE_3b5e7770_fb37_475c_a833_f60c30670e67()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 132f; _h = 257f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(132,257);ctx.lineTo(38,257);ctx.lineTo(37,251);ctx.lineTo(36,245);ctx.lineTo(33,240);ctx.lineTo(29,235);ctx.lineTo(24,231);ctx.lineTo(19,228);ctx.lineTo(13,227);ctx.lineTo(7,226);ctx.lineTo(7,7);ctx.lineTo(30,8);ctx.lineTo(50,12);ctx.lineTo(68,18);ctx.lineTo(82,27);ctx.lineTo(94,37);ctx.lineTo(105,50);ctx.lineTo(113,64);ctx.lineTo(119,80);ctx.lineTo(124,98);ctx.lineTo(127,117);ctx.lineTo(130,138);ctx.lineTo(131,160);ctx.lineTo(132,183);ctx.lineTo(132,257);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(132,257));listpt.Add(new Point(38,257));listpt.Add(new Point(37,251));listpt.Add(new Point(36,245));listpt.Add(new Point(33,240));listpt.Add(new Point(29,235));listpt.Add(new Point(24,231));listpt.Add(new Point(19,228));listpt.Add(new Point(13,227));listpt.Add(new Point(7,226));listpt.Add(new Point(7,7));listpt.Add(new Point(30,8));listpt.Add(new Point(50,12));listpt.Add(new Point(68,18));listpt.Add(new Point(82,27));listpt.Add(new Point(94,37));listpt.Add(new Point(105,50));listpt.Add(new Point(113,64));listpt.Add(new Point(119,80));listpt.Add(new Point(124,98));listpt.Add(new Point(127,117));listpt.Add(new Point(130,138));listpt.Add(new Point(131,160));listpt.Add(new Point(132,183));listpt.Add(new Point(132,257));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}