using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorMisc
{
    public class PIXIE_bb08371f_3ad0_4506_81f7_bd15f9e3ae2e : Pixie
    {
        public PIXIE_bb08371f_3ad0_4506_81f7_bd15f9e3ae2e()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 133f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(857,126);ctx.lineTo(840,133);ctx.lineTo(54,133);ctx.lineTo(35,126);ctx.lineTo(28,107);ctx.lineTo(35,88);ctx.lineTo(141,35);ctx.lineTo(158,28);ctx.lineTo(944,28);ctx.lineTo(963,35);ctx.lineTo(970,54);ctx.lineTo(963,73);ctx.lineTo(857,126);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(857,126));listpt.Add(new Point(840,133));listpt.Add(new Point(54,133));listpt.Add(new Point(35,126));listpt.Add(new Point(28,107));listpt.Add(new Point(35,88));listpt.Add(new Point(141,35));listpt.Add(new Point(158,28));listpt.Add(new Point(944,28));listpt.Add(new Point(963,35));listpt.Add(new Point(970,54));listpt.Add(new Point(963,73));listpt.Add(new Point(857,126));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}