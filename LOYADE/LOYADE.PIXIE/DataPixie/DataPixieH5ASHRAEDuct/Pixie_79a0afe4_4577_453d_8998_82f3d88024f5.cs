using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEDuct
{
    public class PIXIE_79a0afe4_4577_453d_8998_82f3d88024f5 : Pixie
    {
        public PIXIE_79a0afe4_4577_453d_8998_82f3d88024f5()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 970f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,970);ctx.lineTo(29,922);ctx.lineTo(33,874);ctx.lineTo(39,827);ctx.lineTo(47,781);ctx.lineTo(58,735);ctx.lineTo(70,691);ctx.lineTo(85,647);ctx.lineTo(102,604);ctx.lineTo(121,562);ctx.lineTo(142,522);ctx.lineTo(164,482);ctx.lineTo(189,444);ctx.lineTo(215,407);ctx.lineTo(244,371);ctx.lineTo(273,337);ctx.lineTo(305,304);ctx.lineTo(337,273);ctx.lineTo(371,244);ctx.lineTo(407,215);ctx.lineTo(444,189);ctx.lineTo(482,164);ctx.lineTo(522,142);ctx.lineTo(562,121);ctx.lineTo(604,102);ctx.lineTo(647,85);ctx.lineTo(691,70);ctx.lineTo(735,58);ctx.lineTo(781,47);ctx.lineTo(827,39);ctx.lineTo(874,33);ctx.lineTo(922,29);ctx.lineTo(970,28);ctx.lineTo(970,420);ctx.lineTo(942,421);ctx.lineTo(914,423);ctx.lineTo(887,427);ctx.lineTo(860,432);ctx.lineTo(833,438);ctx.lineTo(807,445);ctx.lineTo(781,454);ctx.lineTo(757,464);ctx.lineTo(732,475);ctx.lineTo(709,487);ctx.lineTo(686,500);ctx.lineTo(663,515);ctx.lineTo(642,530);ctx.lineTo(621,546);ctx.lineTo(601,563);ctx.lineTo(582,582);ctx.lineTo(563,601);ctx.lineTo(546,621);ctx.lineTo(530,642);ctx.lineTo(515,663);ctx.lineTo(500,686);ctx.lineTo(487,709);ctx.lineTo(475,732);ctx.lineTo(464,757);ctx.lineTo(454,781);ctx.lineTo(445,807);ctx.lineTo(438,833);ctx.lineTo(432,860);ctx.lineTo(427,887);ctx.lineTo(423,914);ctx.lineTo(421,942);ctx.lineTo(420,970);ctx.lineTo(28,970);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,970));listpt.Add(new Point(29,922));listpt.Add(new Point(33,874));listpt.Add(new Point(39,827));listpt.Add(new Point(47,781));listpt.Add(new Point(58,735));listpt.Add(new Point(70,691));listpt.Add(new Point(85,647));listpt.Add(new Point(102,604));listpt.Add(new Point(121,562));listpt.Add(new Point(142,522));listpt.Add(new Point(164,482));listpt.Add(new Point(189,444));listpt.Add(new Point(215,407));listpt.Add(new Point(244,371));listpt.Add(new Point(273,337));listpt.Add(new Point(305,304));listpt.Add(new Point(337,273));listpt.Add(new Point(371,244));listpt.Add(new Point(407,215));listpt.Add(new Point(444,189));listpt.Add(new Point(482,164));listpt.Add(new Point(522,142));listpt.Add(new Point(562,121));listpt.Add(new Point(604,102));listpt.Add(new Point(647,85));listpt.Add(new Point(691,70));listpt.Add(new Point(735,58));listpt.Add(new Point(781,47));listpt.Add(new Point(827,39));listpt.Add(new Point(874,33));listpt.Add(new Point(922,29));listpt.Add(new Point(970,28));listpt.Add(new Point(970,420));listpt.Add(new Point(942,421));listpt.Add(new Point(914,423));listpt.Add(new Point(887,427));listpt.Add(new Point(860,432));listpt.Add(new Point(833,438));listpt.Add(new Point(807,445));listpt.Add(new Point(781,454));listpt.Add(new Point(757,464));listpt.Add(new Point(732,475));listpt.Add(new Point(709,487));listpt.Add(new Point(686,500));listpt.Add(new Point(663,515));listpt.Add(new Point(642,530));listpt.Add(new Point(621,546));listpt.Add(new Point(601,563));listpt.Add(new Point(582,582));listpt.Add(new Point(563,601));listpt.Add(new Point(546,621));listpt.Add(new Point(530,642));listpt.Add(new Point(515,663));listpt.Add(new Point(500,686));listpt.Add(new Point(487,709));listpt.Add(new Point(475,732));listpt.Add(new Point(464,757));listpt.Add(new Point(454,781));listpt.Add(new Point(445,807));listpt.Add(new Point(438,833));listpt.Add(new Point(432,860));listpt.Add(new Point(427,887));listpt.Add(new Point(423,914));listpt.Add(new Point(421,942));listpt.Add(new Point(420,970));listpt.Add(new Point(28,970));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}