using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_0823affe_3683_4619_8eea_b530dfc59340 : Pixie
    {
        public PIXIE_0823affe_3683_4619_8eea_b530dfc59340()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 971f; _h = 445f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(390,204);ctx.lineTo(734,204);ctx.lineTo(723,179);ctx.lineTo(715,153);ctx.lineTo(709,127);ctx.lineTo(705,101);ctx.lineTo(703,66);ctx.lineTo(705,38);ctx.lineTo(707,31);ctx.lineTo(707,27);ctx.lineTo(716,27);ctx.lineTo(737,56);ctx.lineTo(758,78);ctx.lineTo(784,102);ctx.lineTo(807,121);ctx.lineTo(833,141);ctx.lineTo(863,161);ctx.lineTo(884,174);ctx.lineTo(907,188);ctx.lineTo(931,202);ctx.lineTo(957,215);ctx.lineTo(971,222);ctx.lineTo(971,251);ctx.lineTo(945,264);ctx.lineTo(920,278);ctx.lineTo(897,290);ctx.lineTo(875,303);ctx.lineTo(846,322);ctx.lineTo(821,340);ctx.lineTo(792,365);ctx.lineTo(766,388);ctx.lineTo(743,411);ctx.lineTo(722,434);ctx.lineTo(713,445);ctx.lineTo(707,445);ctx.lineTo(704,419);ctx.lineTo(704,390);ctx.lineTo(708,354);ctx.lineTo(713,328);ctx.lineTo(720,302);ctx.lineTo(730,276);ctx.lineTo(734,268);ctx.lineTo(390,268);ctx.lineTo(390,204);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(390,204));listpt.Add(new Point(734,204));listpt.Add(new Point(723,179));listpt.Add(new Point(715,153));listpt.Add(new Point(709,127));listpt.Add(new Point(705,101));listpt.Add(new Point(703,66));listpt.Add(new Point(705,38));listpt.Add(new Point(707,31));listpt.Add(new Point(707,27));listpt.Add(new Point(716,27));listpt.Add(new Point(737,56));listpt.Add(new Point(758,78));listpt.Add(new Point(784,102));listpt.Add(new Point(807,121));listpt.Add(new Point(833,141));listpt.Add(new Point(863,161));listpt.Add(new Point(884,174));listpt.Add(new Point(907,188));listpt.Add(new Point(931,202));listpt.Add(new Point(957,215));listpt.Add(new Point(971,222));listpt.Add(new Point(971,251));listpt.Add(new Point(945,264));listpt.Add(new Point(920,278));listpt.Add(new Point(897,290));listpt.Add(new Point(875,303));listpt.Add(new Point(846,322));listpt.Add(new Point(821,340));listpt.Add(new Point(792,365));listpt.Add(new Point(766,388));listpt.Add(new Point(743,411));listpt.Add(new Point(722,434));listpt.Add(new Point(713,445));listpt.Add(new Point(707,445));listpt.Add(new Point(704,419));listpt.Add(new Point(704,390));listpt.Add(new Point(708,354));listpt.Add(new Point(713,328));listpt.Add(new Point(720,302));listpt.Add(new Point(730,276));listpt.Add(new Point(734,268));listpt.Add(new Point(390,268));listpt.Add(new Point(390,204));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}