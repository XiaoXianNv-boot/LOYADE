using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_76335b9b_3885_4e45_ac2a_770d1398cfe4 : Pixie
    {
        public PIXIE_76335b9b_3885_4e45_ac2a_770d1398cfe4()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 535f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(223,522);ctx.lineTo(214,495);ctx.lineTo(218,465);ctx.lineTo(225,438);ctx.lineTo(232,411);ctx.lineTo(237,380);ctx.lineTo(230,351);ctx.lineTo(227,347);ctx.lineTo(198,349);ctx.lineTo(176,367);ctx.lineTo(154,389);ctx.lineTo(133,404);ctx.lineTo(102,410);ctx.lineTo(76,403);ctx.lineTo(52,382);ctx.lineTo(40,358);ctx.lineTo(32,328);ctx.lineTo(28,294);ctx.lineTo(28,283);ctx.lineTo(28,271);ctx.lineTo(31,238);ctx.lineTo(38,207);ctx.lineTo(50,181);ctx.lineTo(71,159);ctx.lineTo(100,156);ctx.lineTo(125,164);ctx.lineTo(149,176);ctx.lineTo(172,187);ctx.lineTo(198,196);ctx.lineTo(227,189);ctx.lineTo(235,165);ctx.lineTo(232,137);ctx.lineTo(224,109);ctx.lineTo(216,81);ctx.lineTo(214,51);ctx.lineTo(230,29);ctx.lineTo(234,28);ctx.lineTo(238,28);ctx.lineTo(242,28);ctx.lineTo(270,32);ctx.lineTo(298,39);ctx.lineTo(328,48);ctx.lineTo(359,56);ctx.lineTo(389,63);ctx.lineTo(415,66);ctx.lineTo(433,65);ctx.lineTo(459,81);ctx.lineTo(484,91);ctx.lineTo(513,100);ctx.lineTo(543,108);ctx.lineTo(572,114);ctx.lineTo(604,118);ctx.lineTo(627,116);ctx.lineTo(651,137);ctx.lineTo(675,152);ctx.lineTo(702,166);ctx.lineTo(730,178);ctx.lineTo(758,188);ctx.lineTo(785,195);ctx.lineTo(815,197);ctx.lineTo(825,197);ctx.lineTo(848,218);ctx.lineTo(873,232);ctx.lineTo(897,242);ctx.lineTo(926,251);ctx.lineTo(952,262);ctx.lineTo(967,274);ctx.lineTo(970,278);ctx.lineTo(968,281);ctx.lineTo(944,298);ctx.lineTo(919,310);ctx.lineTo(894,322);ctx.lineTo(868,336);ctx.lineTo(845,352);ctx.lineTo(822,373);ctx.lineTo(789,374);ctx.lineTo(762,379);ctx.lineTo(733,387);ctx.lineTo(702,397);ctx.lineTo(672,409);ctx.lineTo(644,422);ctx.lineTo(621,436);ctx.lineTo(617,440);ctx.lineTo(588,437);ctx.lineTo(557,440);ctx.lineTo(527,447);ctx.lineTo(498,458);ctx.lineTo(472,471);ctx.lineTo(451,485);ctx.lineTo(444,490);ctx.lineTo(414,489);ctx.lineTo(383,495);ctx.lineTo(353,505);ctx.lineTo(325,516);ctx.lineTo(297,527);ctx.lineTo(271,534);ctx.lineTo(265,534);ctx.lineTo(259,535);ctx.lineTo(253,535);ctx.lineTo(227,526);ctx.lineTo(223,522);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(223,522));listpt.Add(new Point(214,495));listpt.Add(new Point(218,465));listpt.Add(new Point(225,438));listpt.Add(new Point(232,411));listpt.Add(new Point(237,380));listpt.Add(new Point(230,351));listpt.Add(new Point(227,347));listpt.Add(new Point(198,349));listpt.Add(new Point(176,367));listpt.Add(new Point(154,389));listpt.Add(new Point(133,404));listpt.Add(new Point(102,410));listpt.Add(new Point(76,403));listpt.Add(new Point(52,382));listpt.Add(new Point(40,358));listpt.Add(new Point(32,328));listpt.Add(new Point(28,294));listpt.Add(new Point(28,283));listpt.Add(new Point(28,271));listpt.Add(new Point(31,238));listpt.Add(new Point(38,207));listpt.Add(new Point(50,181));listpt.Add(new Point(71,159));listpt.Add(new Point(100,156));listpt.Add(new Point(125,164));listpt.Add(new Point(149,176));listpt.Add(new Point(172,187));listpt.Add(new Point(198,196));listpt.Add(new Point(227,189));listpt.Add(new Point(235,165));listpt.Add(new Point(232,137));listpt.Add(new Point(224,109));listpt.Add(new Point(216,81));listpt.Add(new Point(214,51));listpt.Add(new Point(230,29));listpt.Add(new Point(234,28));listpt.Add(new Point(238,28));listpt.Add(new Point(242,28));listpt.Add(new Point(270,32));listpt.Add(new Point(298,39));listpt.Add(new Point(328,48));listpt.Add(new Point(359,56));listpt.Add(new Point(389,63));listpt.Add(new Point(415,66));listpt.Add(new Point(433,65));listpt.Add(new Point(459,81));listpt.Add(new Point(484,91));listpt.Add(new Point(513,100));listpt.Add(new Point(543,108));listpt.Add(new Point(572,114));listpt.Add(new Point(604,118));listpt.Add(new Point(627,116));listpt.Add(new Point(651,137));listpt.Add(new Point(675,152));listpt.Add(new Point(702,166));listpt.Add(new Point(730,178));listpt.Add(new Point(758,188));listpt.Add(new Point(785,195));listpt.Add(new Point(815,197));listpt.Add(new Point(825,197));listpt.Add(new Point(848,218));listpt.Add(new Point(873,232));listpt.Add(new Point(897,242));listpt.Add(new Point(926,251));listpt.Add(new Point(952,262));listpt.Add(new Point(967,274));listpt.Add(new Point(970,278));listpt.Add(new Point(968,281));listpt.Add(new Point(944,298));listpt.Add(new Point(919,310));listpt.Add(new Point(894,322));listpt.Add(new Point(868,336));listpt.Add(new Point(845,352));listpt.Add(new Point(822,373));listpt.Add(new Point(789,374));listpt.Add(new Point(762,379));listpt.Add(new Point(733,387));listpt.Add(new Point(702,397));listpt.Add(new Point(672,409));listpt.Add(new Point(644,422));listpt.Add(new Point(621,436));listpt.Add(new Point(617,440));listpt.Add(new Point(588,437));listpt.Add(new Point(557,440));listpt.Add(new Point(527,447));listpt.Add(new Point(498,458));listpt.Add(new Point(472,471));listpt.Add(new Point(451,485));listpt.Add(new Point(444,490));listpt.Add(new Point(414,489));listpt.Add(new Point(383,495));listpt.Add(new Point(353,505));listpt.Add(new Point(325,516));listpt.Add(new Point(297,527));listpt.Add(new Point(271,534));listpt.Add(new Point(265,534));listpt.Add(new Point(259,535));listpt.Add(new Point(253,535));listpt.Add(new Point(227,526));listpt.Add(new Point(223,522));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}