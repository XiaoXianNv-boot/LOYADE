using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_a241e087_0bad_43e5_b874_d23551bfc0c8 : Pixie
    {
        public PIXIE_a241e087_0bad_43e5_b874_d23551bfc0c8()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 958f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(174,28);ctx.lineTo(824,28);ctx.lineTo(833,28);ctx.lineTo(842,28);ctx.lineTo(875,31);ctx.lineTo(903,37);ctx.lineTo(931,47);ctx.lineTo(956,70);ctx.lineTo(968,97);ctx.lineTo(970,108);ctx.lineTo(970,120);ctx.lineTo(970,123);ctx.lineTo(969,139);ctx.lineTo(885,827);ctx.lineTo(878,860);ctx.lineTo(869,888);ctx.lineTo(858,910);ctx.lineTo(840,932);ctx.lineTo(817,947);ctx.lineTo(787,955);ctx.lineTo(767,958);ctx.lineTo(760,958);ctx.lineTo(752,958);ctx.lineTo(238,958);ctx.lineTo(211,955);ctx.lineTo(181,947);ctx.lineTo(157,932);ctx.lineTo(139,910);ctx.lineTo(128,888);ctx.lineTo(119,860);ctx.lineTo(113,827);ctx.lineTo(29,139);ctx.lineTo(28,131);ctx.lineTo(28,129);ctx.lineTo(28,126);ctx.lineTo(30,97);ctx.lineTo(42,70);ctx.lineTo(63,50);ctx.lineTo(89,38);ctx.lineTo(116,32);ctx.lineTo(147,29);ctx.lineTo(174,28);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(174,28));listpt.Add(new Point(824,28));listpt.Add(new Point(833,28));listpt.Add(new Point(842,28));listpt.Add(new Point(875,31));listpt.Add(new Point(903,37));listpt.Add(new Point(931,47));listpt.Add(new Point(956,70));listpt.Add(new Point(968,97));listpt.Add(new Point(970,108));listpt.Add(new Point(970,120));listpt.Add(new Point(970,123));listpt.Add(new Point(969,139));listpt.Add(new Point(885,827));listpt.Add(new Point(878,860));listpt.Add(new Point(869,888));listpt.Add(new Point(858,910));listpt.Add(new Point(840,932));listpt.Add(new Point(817,947));listpt.Add(new Point(787,955));listpt.Add(new Point(767,958));listpt.Add(new Point(760,958));listpt.Add(new Point(752,958));listpt.Add(new Point(238,958));listpt.Add(new Point(211,955));listpt.Add(new Point(181,947));listpt.Add(new Point(157,932));listpt.Add(new Point(139,910));listpt.Add(new Point(128,888));listpt.Add(new Point(119,860));listpt.Add(new Point(113,827));listpt.Add(new Point(29,139));listpt.Add(new Point(28,131));listpt.Add(new Point(28,129));listpt.Add(new Point(28,126));listpt.Add(new Point(30,97));listpt.Add(new Point(42,70));listpt.Add(new Point(63,50));listpt.Add(new Point(89,38));listpt.Add(new Point(116,32));listpt.Add(new Point(147,29));listpt.Add(new Point(174,28));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}