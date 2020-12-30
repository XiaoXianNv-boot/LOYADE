using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_d34c8f76_dbc9_458f_a84f_a0a3fde85278 : Pixie
    {
        public PIXIE_d34c8f76_dbc9_458f_a84f_a0a3fde85278()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 385f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(970,207);ctx.lineTo(792,385);ctx.lineTo(792,215);ctx.lineTo(383,215);ctx.lineTo(273,326);ctx.lineTo(265,317);ctx.lineTo(366,215);ctx.lineTo(271,215);ctx.lineTo(159,327);ctx.lineTo(149,321);ctx.lineTo(252,215);ctx.lineTo(149,215);ctx.lineTo(39,325);ctx.lineTo(30,315);ctx.lineTo(138,210);ctx.lineTo(28,98);ctx.lineTo(35,89);ctx.lineTo(149,203);ctx.lineTo(252,203);ctx.lineTo(149,98);ctx.lineTo(159,89);ctx.lineTo(271,203);ctx.lineTo(366,203);ctx.lineTo(262,98);ctx.lineTo(271,89);ctx.lineTo(383,203);ctx.lineTo(792,203);ctx.lineTo(792,28);ctx.lineTo(970,207);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(970,207));listpt.Add(new Point(792,385));listpt.Add(new Point(792,215));listpt.Add(new Point(383,215));listpt.Add(new Point(273,326));listpt.Add(new Point(265,317));listpt.Add(new Point(366,215));listpt.Add(new Point(271,215));listpt.Add(new Point(159,327));listpt.Add(new Point(149,321));listpt.Add(new Point(252,215));listpt.Add(new Point(149,215));listpt.Add(new Point(39,325));listpt.Add(new Point(30,315));listpt.Add(new Point(138,210));listpt.Add(new Point(28,98));listpt.Add(new Point(35,89));listpt.Add(new Point(149,203));listpt.Add(new Point(252,203));listpt.Add(new Point(149,98));listpt.Add(new Point(159,89));listpt.Add(new Point(271,203));listpt.Add(new Point(366,203));listpt.Add(new Point(262,98));listpt.Add(new Point(271,89));listpt.Add(new Point(383,203));listpt.Add(new Point(792,203));listpt.Add(new Point(792,28));listpt.Add(new Point(970,207));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}