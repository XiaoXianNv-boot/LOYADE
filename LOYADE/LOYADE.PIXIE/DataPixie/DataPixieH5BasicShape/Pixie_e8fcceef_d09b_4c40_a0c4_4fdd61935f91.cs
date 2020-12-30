using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_e8fcceef_d09b_4c40_a0c4_4fdd61935f91 : Pixie
    {
        public PIXIE_e8fcceef_d09b_4c40_a0c4_4fdd61935f91()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 694f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,694);ctx.lineTo(970,694);ctx.lineTo(969,648);ctx.lineTo(965,602);ctx.lineTo(960,556);ctx.lineTo(951,511);ctx.lineTo(941,465);ctx.lineTo(929,421);ctx.lineTo(914,377);ctx.lineTo(897,334);ctx.lineTo(878,291);ctx.lineTo(858,250);ctx.lineTo(835,209);ctx.lineTo(811,170);ctx.lineTo(784,132);ctx.lineTo(756,96);ctx.lineTo(726,61);ctx.lineTo(694,28);ctx.lineTo(28,694);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,694));listpt.Add(new Point(970,694));listpt.Add(new Point(969,648));listpt.Add(new Point(965,602));listpt.Add(new Point(960,556));listpt.Add(new Point(951,511));listpt.Add(new Point(941,465));listpt.Add(new Point(929,421));listpt.Add(new Point(914,377));listpt.Add(new Point(897,334));listpt.Add(new Point(878,291));listpt.Add(new Point(858,250));listpt.Add(new Point(835,209));listpt.Add(new Point(811,170));listpt.Add(new Point(784,132));listpt.Add(new Point(756,96));listpt.Add(new Point(726,61));listpt.Add(new Point(694,28));listpt.Add(new Point(28,694));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}