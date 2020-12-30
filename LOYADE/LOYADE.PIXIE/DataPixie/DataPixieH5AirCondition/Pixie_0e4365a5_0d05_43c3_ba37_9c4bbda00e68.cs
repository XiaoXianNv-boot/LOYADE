using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5AirCondition
{
    public class PIXIE_0e4365a5_0d05_43c3_ba37_9c4bbda00e68 : Pixie
    {
        public PIXIE_0e4365a5_0d05_43c3_ba37_9c4bbda00e68()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 101f; _h = 257f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(101,257);ctx.lineTo(38,257);ctx.lineTo(37,251);ctx.lineTo(36,245);ctx.lineTo(33,240);ctx.lineTo(29,235);ctx.lineTo(24,231);ctx.lineTo(19,228);ctx.lineTo(13,227);ctx.lineTo(7,226);ctx.lineTo(7,7);ctx.lineTo(25,8);ctx.lineTo(40,12);ctx.lineTo(53,18);ctx.lineTo(64,27);ctx.lineTo(74,37);ctx.lineTo(81,50);ctx.lineTo(87,64);ctx.lineTo(92,80);ctx.lineTo(95,98);ctx.lineTo(98,117);ctx.lineTo(100,138);ctx.lineTo(101,160);ctx.lineTo(101,257);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(101,257));listpt.Add(new Point(38,257));listpt.Add(new Point(37,251));listpt.Add(new Point(36,245));listpt.Add(new Point(33,240));listpt.Add(new Point(29,235));listpt.Add(new Point(24,231));listpt.Add(new Point(19,228));listpt.Add(new Point(13,227));listpt.Add(new Point(7,226));listpt.Add(new Point(7,7));listpt.Add(new Point(25,8));listpt.Add(new Point(40,12));listpt.Add(new Point(53,18));listpt.Add(new Point(64,27));listpt.Add(new Point(74,37));listpt.Add(new Point(81,50));listpt.Add(new Point(87,64));listpt.Add(new Point(92,80));listpt.Add(new Point(95,98));listpt.Add(new Point(98,117));listpt.Add(new Point(100,138));listpt.Add(new Point(101,160));listpt.Add(new Point(101,257));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}