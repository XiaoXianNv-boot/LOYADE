using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEDuct
{
    public class PIXIE_46390822_490a_4a8f_836e_e836682be351 : Pixie
    {
        public PIXIE_46390822_490a_4a8f_836e_e836682be351()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 499f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(188,499);ctx.lineTo(808,499);ctx.lineTo(899,444);ctx.lineTo(951,358);ctx.lineTo(970,263);ctx.lineTo(951,169);ctx.lineTo(899,84);ctx.lineTo(808,28);ctx.lineTo(188,28);ctx.lineTo(99,84);ctx.lineTo(47,169);ctx.lineTo(28,263);ctx.lineTo(47,358);ctx.lineTo(99,444);ctx.lineTo(188,499);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(188,499));listpt.Add(new Point(808,499));listpt.Add(new Point(899,444));listpt.Add(new Point(951,358));listpt.Add(new Point(970,263));listpt.Add(new Point(951,169));listpt.Add(new Point(899,84));listpt.Add(new Point(808,28));listpt.Add(new Point(188,28));listpt.Add(new Point(99,84));listpt.Add(new Point(47,169));listpt.Add(new Point(28,263));listpt.Add(new Point(47,358));listpt.Add(new Point(99,444));listpt.Add(new Point(188,499));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}