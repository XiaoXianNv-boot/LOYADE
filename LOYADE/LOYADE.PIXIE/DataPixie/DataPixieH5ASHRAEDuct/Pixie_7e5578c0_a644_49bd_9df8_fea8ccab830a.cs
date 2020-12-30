using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEDuct
{
    public class PIXIE_7e5578c0_a644_49bd_9df8_fea8ccab830a : Pixie
    {
        public PIXIE_7e5578c0_a644_49bd_9df8_fea8ccab830a()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 970f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,28);ctx.lineTo(76,29);ctx.lineTo(124,33);ctx.lineTo(171,39);ctx.lineTo(217,47);ctx.lineTo(263,58);ctx.lineTo(307,70);ctx.lineTo(351,85);ctx.lineTo(394,102);ctx.lineTo(436,121);ctx.lineTo(476,142);ctx.lineTo(516,164);ctx.lineTo(554,189);ctx.lineTo(591,215);ctx.lineTo(627,244);ctx.lineTo(661,273);ctx.lineTo(694,304);ctx.lineTo(725,337);ctx.lineTo(754,371);ctx.lineTo(783,407);ctx.lineTo(809,444);ctx.lineTo(834,482);ctx.lineTo(856,522);ctx.lineTo(877,562);ctx.lineTo(896,604);ctx.lineTo(913,647);ctx.lineTo(928,691);ctx.lineTo(940,735);ctx.lineTo(951,781);ctx.lineTo(959,827);ctx.lineTo(965,874);ctx.lineTo(969,922);ctx.lineTo(970,970);ctx.lineTo(578,970);ctx.lineTo(577,942);ctx.lineTo(575,914);ctx.lineTo(571,887);ctx.lineTo(566,860);ctx.lineTo(560,833);ctx.lineTo(553,807);ctx.lineTo(544,781);ctx.lineTo(534,757);ctx.lineTo(523,732);ctx.lineTo(511,709);ctx.lineTo(498,686);ctx.lineTo(483,663);ctx.lineTo(468,642);ctx.lineTo(452,621);ctx.lineTo(435,601);ctx.lineTo(416,582);ctx.lineTo(397,563);ctx.lineTo(377,546);ctx.lineTo(356,530);ctx.lineTo(335,515);ctx.lineTo(312,500);ctx.lineTo(289,487);ctx.lineTo(266,475);ctx.lineTo(241,464);ctx.lineTo(217,454);ctx.lineTo(191,445);ctx.lineTo(165,438);ctx.lineTo(138,432);ctx.lineTo(111,427);ctx.lineTo(84,423);ctx.lineTo(56,421);ctx.lineTo(28,420);ctx.lineTo(28,28);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,28));listpt.Add(new Point(76,29));listpt.Add(new Point(124,33));listpt.Add(new Point(171,39));listpt.Add(new Point(217,47));listpt.Add(new Point(263,58));listpt.Add(new Point(307,70));listpt.Add(new Point(351,85));listpt.Add(new Point(394,102));listpt.Add(new Point(436,121));listpt.Add(new Point(476,142));listpt.Add(new Point(516,164));listpt.Add(new Point(554,189));listpt.Add(new Point(591,215));listpt.Add(new Point(627,244));listpt.Add(new Point(661,273));listpt.Add(new Point(694,304));listpt.Add(new Point(725,337));listpt.Add(new Point(754,371));listpt.Add(new Point(783,407));listpt.Add(new Point(809,444));listpt.Add(new Point(834,482));listpt.Add(new Point(856,522));listpt.Add(new Point(877,562));listpt.Add(new Point(896,604));listpt.Add(new Point(913,647));listpt.Add(new Point(928,691));listpt.Add(new Point(940,735));listpt.Add(new Point(951,781));listpt.Add(new Point(959,827));listpt.Add(new Point(965,874));listpt.Add(new Point(969,922));listpt.Add(new Point(970,970));listpt.Add(new Point(578,970));listpt.Add(new Point(577,942));listpt.Add(new Point(575,914));listpt.Add(new Point(571,887));listpt.Add(new Point(566,860));listpt.Add(new Point(560,833));listpt.Add(new Point(553,807));listpt.Add(new Point(544,781));listpt.Add(new Point(534,757));listpt.Add(new Point(523,732));listpt.Add(new Point(511,709));listpt.Add(new Point(498,686));listpt.Add(new Point(483,663));listpt.Add(new Point(468,642));listpt.Add(new Point(452,621));listpt.Add(new Point(435,601));listpt.Add(new Point(416,582));listpt.Add(new Point(397,563));listpt.Add(new Point(377,546));listpt.Add(new Point(356,530));listpt.Add(new Point(335,515));listpt.Add(new Point(312,500));listpt.Add(new Point(289,487));listpt.Add(new Point(266,475));listpt.Add(new Point(241,464));listpt.Add(new Point(217,454));listpt.Add(new Point(191,445));listpt.Add(new Point(165,438));listpt.Add(new Point(138,432));listpt.Add(new Point(111,427));listpt.Add(new Point(84,423));listpt.Add(new Point(56,421));listpt.Add(new Point(28,420));listpt.Add(new Point(28,28));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}