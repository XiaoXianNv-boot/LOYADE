using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Blower
{
    public class PIXIE_4695d71c_222e_4d36_8159_a203736ee37a : Pixie
    {
        public PIXIE_4695d71c_222e_4d36_8159_a203736ee37a()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 784f; _h = 249f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#000'; arrFillColor[1] = '#4c4c4c'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(784,107);ctx.lineTo(784,67);ctx.lineTo(774,37);ctx.lineTo(765,27);ctx.lineTo(755,27);ctx.lineTo(744,37);ctx.lineTo(735,67);ctx.lineTo(735,107);ctx.lineTo(744,61);ctx.lineTo(755,37);ctx.lineTo(759,33);ctx.lineTo(765,37);ctx.lineTo(774,61);ctx.lineTo(780,107);ctx.lineTo(784,107);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(333,200,49,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(784,107));listpt.Add(new Point(784,67));listpt.Add(new Point(774,37));listpt.Add(new Point(765,27));listpt.Add(new Point(755,27));listpt.Add(new Point(744,37));listpt.Add(new Point(735,67));listpt.Add(new Point(735,107));listpt.Add(new Point(744,61));listpt.Add(new Point(755,37));listpt.Add(new Point(759,33));listpt.Add(new Point(765,37));listpt.Add(new Point(774,61));listpt.Add(new Point(780,107));listpt.Add(new Point(784,107));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 284f,151f,98f,98f);g.DrawEllipse(p, 284f,151f,98f,98f);
        }
    }
}