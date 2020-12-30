using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Electrical
{
    public class PIXIE_a2c4b66e_117b_493f_8044_ef4c18d2d495 : Pixie
    {
        public PIXIE_a2c4b66e_117b_493f_8044_ef4c18d2d495()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 656f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(656,28);ctx.lineTo(688,29);ctx.lineTo(718,34);ctx.lineTo(748,42);ctx.lineTo(777,53);ctx.lineTo(804,66);ctx.lineTo(830,81);ctx.lineTo(855,99);ctx.lineTo(877,120);ctx.lineTo(897,142);ctx.lineTo(916,166);ctx.lineTo(932,192);ctx.lineTo(945,220);ctx.lineTo(956,249);ctx.lineTo(964,279);ctx.lineTo(969,310);ctx.lineTo(970,326);ctx.lineTo(970,342);ctx.lineTo(970,358);ctx.lineTo(967,390);ctx.lineTo(960,420);ctx.lineTo(951,450);ctx.lineTo(939,478);ctx.lineTo(924,505);ctx.lineTo(907,530);ctx.lineTo(888,553);ctx.lineTo(866,574);ctx.lineTo(843,593);ctx.lineTo(818,611);ctx.lineTo(791,625);ctx.lineTo(763,637);ctx.lineTo(734,646);ctx.lineTo(703,652);ctx.lineTo(672,656);ctx.lineTo(656,656);ctx.lineTo(28,656);ctx.lineTo(28,28);ctx.lineTo(656,28);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(656,28));listpt.Add(new Point(688,29));listpt.Add(new Point(718,34));listpt.Add(new Point(748,42));listpt.Add(new Point(777,53));listpt.Add(new Point(804,66));listpt.Add(new Point(830,81));listpt.Add(new Point(855,99));listpt.Add(new Point(877,120));listpt.Add(new Point(897,142));listpt.Add(new Point(916,166));listpt.Add(new Point(932,192));listpt.Add(new Point(945,220));listpt.Add(new Point(956,249));listpt.Add(new Point(964,279));listpt.Add(new Point(969,310));listpt.Add(new Point(970,326));listpt.Add(new Point(970,342));listpt.Add(new Point(970,358));listpt.Add(new Point(967,390));listpt.Add(new Point(960,420));listpt.Add(new Point(951,450));listpt.Add(new Point(939,478));listpt.Add(new Point(924,505));listpt.Add(new Point(907,530));listpt.Add(new Point(888,553));listpt.Add(new Point(866,574));listpt.Add(new Point(843,593));listpt.Add(new Point(818,611));listpt.Add(new Point(791,625));listpt.Add(new Point(763,637));listpt.Add(new Point(734,646));listpt.Add(new Point(703,652));listpt.Add(new Point(672,656));listpt.Add(new Point(656,656));listpt.Add(new Point(28,656));listpt.Add(new Point(28,28));listpt.Add(new Point(656,28));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}