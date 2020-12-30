using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5AirCondition
{
    public class PIXIE_27c75992_cc67_4f68_ab18_01e74214b070 : Pixie
    {
        public PIXIE_27c75992_cc67_4f68_ab18_01e74214b070()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 257f; _h = 257f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(257,257);ctx.lineTo(38,257);ctx.lineTo(37,251);ctx.lineTo(36,245);ctx.lineTo(33,240);ctx.lineTo(29,235);ctx.lineTo(24,231);ctx.lineTo(19,228);ctx.lineTo(13,227);ctx.lineTo(7,226);ctx.lineTo(7,7);ctx.lineTo(33,8);ctx.lineTo(57,12);ctx.lineTo(81,18);ctx.lineTo(104,27);ctx.lineTo(126,37);ctx.lineTo(147,50);ctx.lineTo(166,64);ctx.lineTo(184,80);ctx.lineTo(200,98);ctx.lineTo(214,117);ctx.lineTo(227,138);ctx.lineTo(237,160);ctx.lineTo(246,183);ctx.lineTo(252,207);ctx.lineTo(256,231);ctx.lineTo(257,257);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(257,257));listpt.Add(new Point(38,257));listpt.Add(new Point(37,251));listpt.Add(new Point(36,245));listpt.Add(new Point(33,240));listpt.Add(new Point(29,235));listpt.Add(new Point(24,231));listpt.Add(new Point(19,228));listpt.Add(new Point(13,227));listpt.Add(new Point(7,226));listpt.Add(new Point(7,7));listpt.Add(new Point(33,8));listpt.Add(new Point(57,12));listpt.Add(new Point(81,18));listpt.Add(new Point(104,27));listpt.Add(new Point(126,37));listpt.Add(new Point(147,50));listpt.Add(new Point(166,64));listpt.Add(new Point(184,80));listpt.Add(new Point(200,98));listpt.Add(new Point(214,117));listpt.Add(new Point(227,138));listpt.Add(new Point(237,160));listpt.Add(new Point(246,183));listpt.Add(new Point(252,207));listpt.Add(new Point(256,231));listpt.Add(new Point(257,257));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}