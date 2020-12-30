using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_dbc1765e_f6c4_4be6_916d_849c85d1e13c : Pixie
    {
        public PIXIE_dbc1765e_f6c4_4be6_916d_849c85d1e13c()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 642f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(254,371);ctx.lineTo(28,28);ctx.lineTo(439,51);ctx.lineTo(374,162);ctx.lineTo(408,183);ctx.lineTo(441,203);ctx.lineTo(475,223);ctx.lineTo(509,242);ctx.lineTo(544,261);ctx.lineTo(579,279);ctx.lineTo(614,296);ctx.lineTo(650,313);ctx.lineTo(687,329);ctx.lineTo(725,345);ctx.lineTo(763,359);ctx.lineTo(803,373);ctx.lineTo(843,386);ctx.lineTo(884,399);ctx.lineTo(927,410);ctx.lineTo(949,416);ctx.lineTo(970,421);ctx.lineTo(961,420);ctx.lineTo(924,421);ctx.lineTo(890,422);ctx.lineTo(857,422);ctx.lineTo(823,422);ctx.lineTo(789,420);ctx.lineTo(762,418);ctx.lineTo(733,413);ctx.lineTo(702,407);ctx.lineTo(680,402);ctx.lineTo(702,425);ctx.lineTo(722,447);ctx.lineTo(739,470);ctx.lineTo(754,493);ctx.lineTo(768,515);ctx.lineTo(780,537);ctx.lineTo(792,560);ctx.lineTo(804,582);ctx.lineTo(817,605);ctx.lineTo(830,627);ctx.lineTo(834,634);ctx.lineTo(839,642);ctx.lineTo(823,626);ctx.lineTo(792,594);ctx.lineTo(760,564);ctx.lineTo(728,535);ctx.lineTo(696,507);ctx.lineTo(664,481);ctx.lineTo(632,455);ctx.lineTo(599,431);ctx.lineTo(566,407);ctx.lineTo(534,385);ctx.lineTo(501,363);ctx.lineTo(468,342);ctx.lineTo(435,322);ctx.lineTo(402,304);ctx.lineTo(369,286);ctx.lineTo(336,268);ctx.lineTo(319,260);ctx.lineTo(254,371);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(254,371));listpt.Add(new Point(28,28));listpt.Add(new Point(439,51));listpt.Add(new Point(374,162));listpt.Add(new Point(408,183));listpt.Add(new Point(441,203));listpt.Add(new Point(475,223));listpt.Add(new Point(509,242));listpt.Add(new Point(544,261));listpt.Add(new Point(579,279));listpt.Add(new Point(614,296));listpt.Add(new Point(650,313));listpt.Add(new Point(687,329));listpt.Add(new Point(725,345));listpt.Add(new Point(763,359));listpt.Add(new Point(803,373));listpt.Add(new Point(843,386));listpt.Add(new Point(884,399));listpt.Add(new Point(927,410));listpt.Add(new Point(949,416));listpt.Add(new Point(970,421));listpt.Add(new Point(961,420));listpt.Add(new Point(924,421));listpt.Add(new Point(890,422));listpt.Add(new Point(857,422));listpt.Add(new Point(823,422));listpt.Add(new Point(789,420));listpt.Add(new Point(762,418));listpt.Add(new Point(733,413));listpt.Add(new Point(702,407));listpt.Add(new Point(680,402));listpt.Add(new Point(702,425));listpt.Add(new Point(722,447));listpt.Add(new Point(739,470));listpt.Add(new Point(754,493));listpt.Add(new Point(768,515));listpt.Add(new Point(780,537));listpt.Add(new Point(792,560));listpt.Add(new Point(804,582));listpt.Add(new Point(817,605));listpt.Add(new Point(830,627));listpt.Add(new Point(834,634));listpt.Add(new Point(839,642));listpt.Add(new Point(823,626));listpt.Add(new Point(792,594));listpt.Add(new Point(760,564));listpt.Add(new Point(728,535));listpt.Add(new Point(696,507));listpt.Add(new Point(664,481));listpt.Add(new Point(632,455));listpt.Add(new Point(599,431));listpt.Add(new Point(566,407));listpt.Add(new Point(534,385));listpt.Add(new Point(501,363));listpt.Add(new Point(468,342));listpt.Add(new Point(435,322));listpt.Add(new Point(402,304));listpt.Add(new Point(369,286));listpt.Add(new Point(336,268));listpt.Add(new Point(319,260));listpt.Add(new Point(254,371));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}