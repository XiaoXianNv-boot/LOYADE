using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEControlEquipment
{
    public class PIXIE_7950268f_96d7_4f2a_ad62_27f06b05a9e2 : Pixie
    {
        public PIXIE_7950268f_96d7_4f2a_ad62_27f06b05a9e2()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 499f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,499);ctx.lineTo(62,322);ctx.lineTo(163,163);ctx.lineTo(322,61);ctx.lineTo(499,28);ctx.lineTo(676,61);ctx.lineTo(835,163);ctx.lineTo(937,322);ctx.lineTo(970,499);ctx.lineTo(28,499);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,499));listpt.Add(new Point(62,322));listpt.Add(new Point(163,163));listpt.Add(new Point(322,61));listpt.Add(new Point(499,28));listpt.Add(new Point(676,61));listpt.Add(new Point(835,163));listpt.Add(new Point(937,322));listpt.Add(new Point(970,499));listpt.Add(new Point(28,499));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}