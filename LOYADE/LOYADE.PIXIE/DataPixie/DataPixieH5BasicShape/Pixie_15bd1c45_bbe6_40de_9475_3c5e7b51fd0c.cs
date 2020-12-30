using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_15bd1c45_bbe6_40de_9475_3c5e7b51fd0c : Pixie
    {
        public PIXIE_15bd1c45_bbe6_40de_9475_3c5e7b51fd0c()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 971f; _h = 509f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(27,489);ctx.lineTo(950,489);ctx.lineTo(950,27);ctx.lineTo(27,27);ctx.lineTo(27,489);ctx.moveTo(38,489);ctx.lineTo(38,499);ctx.lineTo(960,499);ctx.lineTo(960,38);ctx.lineTo(950,38);ctx.lineTo(950,489);ctx.lineTo(38,489);ctx.moveTo(48,499);ctx.lineTo(48,509);ctx.lineTo(971,509);ctx.lineTo(971,48);ctx.lineTo(960,48);ctx.lineTo(960,499);ctx.lineTo(48,499);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(27,489));listpt.Add(new Point(950,489));listpt.Add(new Point(950,27));listpt.Add(new Point(27,27));listpt.Add(new Point(27,489));listpt.Add(new Point(38,489));listpt.Add(new Point(38,499));listpt.Add(new Point(960,499));listpt.Add(new Point(960,38));listpt.Add(new Point(950,38));listpt.Add(new Point(950,489));listpt.Add(new Point(38,489));listpt.Add(new Point(48,499));listpt.Add(new Point(48,509));listpt.Add(new Point(971,509));listpt.Add(new Point(971,48));listpt.Add(new Point(960,48));listpt.Add(new Point(960,499));listpt.Add(new Point(48,499));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}