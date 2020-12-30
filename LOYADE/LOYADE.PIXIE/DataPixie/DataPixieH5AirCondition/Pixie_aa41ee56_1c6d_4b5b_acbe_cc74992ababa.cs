using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5AirCondition
{
    public class PIXIE_aa41ee56_1c6d_4b5b_acbe_cc74992ababa : Pixie
    {
        public PIXIE_aa41ee56_1c6d_4b5b_acbe_cc74992ababa()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 194f; _h = 130f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(29,128);ctx.lineTo(170,128);ctx.lineTo(170,130);ctx.lineTo(29,130);ctx.lineTo(29,128);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(5,48);ctx.lineTo(7,48);ctx.lineTo(13,48);ctx.lineTo(22,48);ctx.lineTo(35,48);ctx.lineTo(49,48);ctx.lineTo(65,48);ctx.lineTo(82,48);ctx.lineTo(100,48);ctx.lineTo(117,48);ctx.lineTo(134,48);ctx.lineTo(150,48);ctx.lineTo(164,48);ctx.lineTo(177,48);ctx.lineTo(186,48);ctx.lineTo(192,48);ctx.lineTo(194,48);ctx.lineTo(170,128);ctx.lineTo(29,128);ctx.lineTo(5,48);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(29,128));listpt.Add(new Point(170,128));listpt.Add(new Point(170,130));listpt.Add(new Point(29,130));listpt.Add(new Point(29,128));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(5,48));listpt.Add(new Point(7,48));listpt.Add(new Point(13,48));listpt.Add(new Point(22,48));listpt.Add(new Point(35,48));listpt.Add(new Point(49,48));listpt.Add(new Point(65,48));listpt.Add(new Point(82,48));listpt.Add(new Point(100,48));listpt.Add(new Point(117,48));listpt.Add(new Point(134,48));listpt.Add(new Point(150,48));listpt.Add(new Point(164,48));listpt.Add(new Point(177,48));listpt.Add(new Point(186,48));listpt.Add(new Point(192,48));listpt.Add(new Point(194,48));listpt.Add(new Point(170,128));listpt.Add(new Point(29,128));listpt.Add(new Point(5,48));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}