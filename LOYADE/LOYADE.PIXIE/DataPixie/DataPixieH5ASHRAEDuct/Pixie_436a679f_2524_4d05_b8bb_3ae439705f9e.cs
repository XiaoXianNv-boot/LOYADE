using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEDuct
{
    public class PIXIE_436a679f_2524_4d05_b8bb_3ae439705f9e : Pixie
    {
        public PIXIE_436a679f_2524_4d05_b8bb_3ae439705f9e()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 309f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(124,28);ctx.lineTo(71,62);ctx.lineTo(39,112);ctx.lineTo(28,169);ctx.lineTo(39,224);ctx.lineTo(71,277);ctx.lineTo(124,309);ctx.lineTo(970,309);ctx.lineTo(918,277);ctx.lineTo(886,224);ctx.lineTo(874,169);ctx.lineTo(886,112);ctx.lineTo(918,62);ctx.lineTo(970,28);ctx.lineTo(124,28);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(124,28));listpt.Add(new Point(71,62));listpt.Add(new Point(39,112));listpt.Add(new Point(28,169));listpt.Add(new Point(39,224));listpt.Add(new Point(71,277));listpt.Add(new Point(124,309));listpt.Add(new Point(970,309));listpt.Add(new Point(918,277));listpt.Add(new Point(886,224));listpt.Add(new Point(874,169));listpt.Add(new Point(886,112));listpt.Add(new Point(918,62));listpt.Add(new Point(970,28));listpt.Add(new Point(124,28));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}