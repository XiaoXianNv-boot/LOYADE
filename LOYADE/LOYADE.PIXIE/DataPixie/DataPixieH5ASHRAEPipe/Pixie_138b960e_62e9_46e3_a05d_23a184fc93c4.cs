using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEPipe
{
    public class PIXIE_138b960e_62e9_46e3_a05d_23a184fc93c4 : Pixie
    {
        public PIXIE_138b960e_62e9_46e3_a05d_23a184fc93c4()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 735f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(970,735);ctx.lineTo(852,735);ctx.lineTo(851,704);ctx.lineTo(850,675);ctx.lineTo(846,645);ctx.lineTo(841,616);ctx.lineTo(834,588);ctx.lineTo(826,560);ctx.lineTo(817,532);ctx.lineTo(806,506);ctx.lineTo(794,480);ctx.lineTo(781,454);ctx.lineTo(767,430);ctx.lineTo(752,406);ctx.lineTo(735,383);ctx.lineTo(718,360);ctx.lineTo(699,339);ctx.lineTo(679,319);ctx.lineTo(659,299);ctx.lineTo(638,280);ctx.lineTo(615,263);ctx.lineTo(592,246);ctx.lineTo(568,231);ctx.lineTo(544,217);ctx.lineTo(518,204);ctx.lineTo(492,192);ctx.lineTo(466,181);ctx.lineTo(438,172);ctx.lineTo(410,164);ctx.lineTo(382,157);ctx.lineTo(353,152);ctx.lineTo(323,148);ctx.lineTo(294,147);ctx.lineTo(263,146);ctx.lineTo(263,28);ctx.lineTo(300,29);ctx.lineTo(335,32);ctx.lineTo(371,36);ctx.lineTo(406,42);ctx.lineTo(440,50);ctx.lineTo(473,60);ctx.lineTo(506,71);ctx.lineTo(538,83);ctx.lineTo(569,98);ctx.lineTo(600,114);ctx.lineTo(630,131);ctx.lineTo(658,149);ctx.lineTo(686,169);ctx.lineTo(712,189);ctx.lineTo(738,212);ctx.lineTo(763,235);ctx.lineTo(786,260);ctx.lineTo(809,286);ctx.lineTo(829,312);ctx.lineTo(849,340);ctx.lineTo(867,368);ctx.lineTo(884,398);ctx.lineTo(900,429);ctx.lineTo(915,460);ctx.lineTo(927,492);ctx.lineTo(938,525);ctx.lineTo(948,558);ctx.lineTo(956,592);ctx.lineTo(962,627);ctx.lineTo(966,663);ctx.lineTo(969,698);ctx.lineTo(970,735);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(970,735));listpt.Add(new Point(852,735));listpt.Add(new Point(851,704));listpt.Add(new Point(850,675));listpt.Add(new Point(846,645));listpt.Add(new Point(841,616));listpt.Add(new Point(834,588));listpt.Add(new Point(826,560));listpt.Add(new Point(817,532));listpt.Add(new Point(806,506));listpt.Add(new Point(794,480));listpt.Add(new Point(781,454));listpt.Add(new Point(767,430));listpt.Add(new Point(752,406));listpt.Add(new Point(735,383));listpt.Add(new Point(718,360));listpt.Add(new Point(699,339));listpt.Add(new Point(679,319));listpt.Add(new Point(659,299));listpt.Add(new Point(638,280));listpt.Add(new Point(615,263));listpt.Add(new Point(592,246));listpt.Add(new Point(568,231));listpt.Add(new Point(544,217));listpt.Add(new Point(518,204));listpt.Add(new Point(492,192));listpt.Add(new Point(466,181));listpt.Add(new Point(438,172));listpt.Add(new Point(410,164));listpt.Add(new Point(382,157));listpt.Add(new Point(353,152));listpt.Add(new Point(323,148));listpt.Add(new Point(294,147));listpt.Add(new Point(263,146));listpt.Add(new Point(263,28));listpt.Add(new Point(300,29));listpt.Add(new Point(335,32));listpt.Add(new Point(371,36));listpt.Add(new Point(406,42));listpt.Add(new Point(440,50));listpt.Add(new Point(473,60));listpt.Add(new Point(506,71));listpt.Add(new Point(538,83));listpt.Add(new Point(569,98));listpt.Add(new Point(600,114));listpt.Add(new Point(630,131));listpt.Add(new Point(658,149));listpt.Add(new Point(686,169));listpt.Add(new Point(712,189));listpt.Add(new Point(738,212));listpt.Add(new Point(763,235));listpt.Add(new Point(786,260));listpt.Add(new Point(809,286));listpt.Add(new Point(829,312));listpt.Add(new Point(849,340));listpt.Add(new Point(867,368));listpt.Add(new Point(884,398));listpt.Add(new Point(900,429));listpt.Add(new Point(915,460));listpt.Add(new Point(927,492));listpt.Add(new Point(938,525));listpt.Add(new Point(948,558));listpt.Add(new Point(956,592));listpt.Add(new Point(962,627));listpt.Add(new Point(966,663));listpt.Add(new Point(969,698));listpt.Add(new Point(970,735));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}