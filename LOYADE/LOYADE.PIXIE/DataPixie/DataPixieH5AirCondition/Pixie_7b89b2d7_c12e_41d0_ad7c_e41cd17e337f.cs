using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5AirCondition
{
    public class PIXIE_7b89b2d7_c12e_41d0_ad7c_e41cd17e337f : Pixie
    {
        public PIXIE_7b89b2d7_c12e_41d0_ad7c_e41cd17e337f()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 257f; _h = 256f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(7,256);ctx.lineTo(8,235);ctx.lineTo(11,214);ctx.lineTo(15,193);ctx.lineTo(21,173);ctx.lineTo(29,153);ctx.lineTo(39,135);ctx.lineTo(49,117);ctx.lineTo(62,100);ctx.lineTo(75,84);ctx.lineTo(90,69);ctx.lineTo(106,55);ctx.lineTo(123,42);ctx.lineTo(141,31);ctx.lineTo(160,22);ctx.lineTo(179,13);ctx.lineTo(200,7);ctx.lineTo(257,225);ctx.lineTo(252,227);ctx.lineTo(247,230);ctx.lineTo(240,237);ctx.lineTo(235,246);ctx.lineTo(233,251);ctx.lineTo(233,256);ctx.lineTo(7,256);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(7,256));listpt.Add(new Point(8,235));listpt.Add(new Point(11,214));listpt.Add(new Point(15,193));listpt.Add(new Point(21,173));listpt.Add(new Point(29,153));listpt.Add(new Point(39,135));listpt.Add(new Point(49,117));listpt.Add(new Point(62,100));listpt.Add(new Point(75,84));listpt.Add(new Point(90,69));listpt.Add(new Point(106,55));listpt.Add(new Point(123,42));listpt.Add(new Point(141,31));listpt.Add(new Point(160,22));listpt.Add(new Point(179,13));listpt.Add(new Point(200,7));listpt.Add(new Point(257,225));listpt.Add(new Point(252,227));listpt.Add(new Point(247,230));listpt.Add(new Point(240,237));listpt.Add(new Point(235,246));listpt.Add(new Point(233,251));listpt.Add(new Point(233,256));listpt.Add(new Point(7,256));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}