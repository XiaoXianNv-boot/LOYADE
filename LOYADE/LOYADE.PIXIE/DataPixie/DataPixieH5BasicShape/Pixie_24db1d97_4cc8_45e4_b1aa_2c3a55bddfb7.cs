using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_24db1d97_4cc8_45e4_b1aa_2c3a55bddfb7 : Pixie
    {
        public PIXIE_24db1d97_4cc8_45e4_b1aa_2c3a55bddfb7()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 934f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(727,934);ctx.lineTo(272,934);ctx.lineTo(243,930);ctx.lineTo(226,909);ctx.lineTo(220,893);ctx.lineTo(44,342);ctx.lineTo(35,313);ctx.lineTo(30,287);ctx.lineTo(28,270);ctx.lineTo(28,265);ctx.lineTo(28,261);ctx.lineTo(32,231);ctx.lineTo(45,206);ctx.lineTo(69,184);ctx.lineTo(95,169);ctx.lineTo(105,164);ctx.lineTo(393,46);ctx.lineTo(422,37);ctx.lineTo(448,31);ctx.lineTo(476,28);ctx.lineTo(484,28);ctx.lineTo(491,28);ctx.lineTo(499,28);ctx.lineTo(530,29);ctx.lineTo(558,33);ctx.lineTo(584,39);ctx.lineTo(607,46);ctx.lineTo(891,164);ctx.lineTo(920,179);ctx.lineTo(942,194);ctx.lineTo(960,218);ctx.lineTo(969,247);ctx.lineTo(970,255);ctx.lineTo(970,263);ctx.lineTo(970,266);ctx.lineTo(967,292);ctx.lineTo(960,320);ctx.lineTo(955,342);ctx.lineTo(794,849);ctx.lineTo(786,877);ctx.lineTo(778,903);ctx.lineTo(762,925);ctx.lineTo(734,934);ctx.lineTo(727,934);ctx.lineTo(727,934);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(727,934));listpt.Add(new Point(272,934));listpt.Add(new Point(243,930));listpt.Add(new Point(226,909));listpt.Add(new Point(220,893));listpt.Add(new Point(44,342));listpt.Add(new Point(35,313));listpt.Add(new Point(30,287));listpt.Add(new Point(28,270));listpt.Add(new Point(28,265));listpt.Add(new Point(28,261));listpt.Add(new Point(32,231));listpt.Add(new Point(45,206));listpt.Add(new Point(69,184));listpt.Add(new Point(95,169));listpt.Add(new Point(105,164));listpt.Add(new Point(393,46));listpt.Add(new Point(422,37));listpt.Add(new Point(448,31));listpt.Add(new Point(476,28));listpt.Add(new Point(484,28));listpt.Add(new Point(491,28));listpt.Add(new Point(499,28));listpt.Add(new Point(530,29));listpt.Add(new Point(558,33));listpt.Add(new Point(584,39));listpt.Add(new Point(607,46));listpt.Add(new Point(891,164));listpt.Add(new Point(920,179));listpt.Add(new Point(942,194));listpt.Add(new Point(960,218));listpt.Add(new Point(969,247));listpt.Add(new Point(970,255));listpt.Add(new Point(970,263));listpt.Add(new Point(970,266));listpt.Add(new Point(967,292));listpt.Add(new Point(960,320));listpt.Add(new Point(955,342));listpt.Add(new Point(794,849));listpt.Add(new Point(786,877));listpt.Add(new Point(778,903));listpt.Add(new Point(762,925));listpt.Add(new Point(734,934));listpt.Add(new Point(727,934));listpt.Add(new Point(727,934));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}