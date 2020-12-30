using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_45455d98_8744_4b84_9799_a067a840471c : Pixie
    {
        public PIXIE_45455d98_8744_4b84_9799_a067a840471c()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 969f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(958,946);ctx.lineTo(946,920);ctx.lineTo(931,891);ctx.lineTo(916,861);ctx.lineTo(900,829);ctx.lineTo(883,795);ctx.lineTo(866,759);ctx.lineTo(847,723);ctx.lineTo(828,685);ctx.lineTo(809,646);ctx.lineTo(789,607);ctx.lineTo(770,568);ctx.lineTo(750,528);ctx.lineTo(730,488);ctx.lineTo(710,449);ctx.lineTo(691,410);ctx.lineTo(671,372);ctx.lineTo(653,335);ctx.lineTo(635,298);ctx.lineTo(617,264);ctx.lineTo(601,230);ctx.lineTo(585,199);ctx.lineTo(570,169);ctx.lineTo(556,142);ctx.lineTo(544,117);ctx.lineTo(523,75);ctx.lineTo(508,45);ctx.lineTo(500,30);ctx.lineTo(499,28);ctx.lineTo(498,30);ctx.lineTo(483,59);ctx.lineTo(465,95);ctx.lineTo(454,117);ctx.lineTo(442,142);ctx.lineTo(428,169);ctx.lineTo(413,199);ctx.lineTo(397,230);ctx.lineTo(381,264);ctx.lineTo(363,298);ctx.lineTo(345,334);ctx.lineTo(326,372);ctx.lineTo(307,410);ctx.lineTo(288,449);ctx.lineTo(268,488);ctx.lineTo(248,528);ctx.lineTo(228,568);ctx.lineTo(208,607);ctx.lineTo(189,646);ctx.lineTo(169,685);ctx.lineTo(151,722);ctx.lineTo(132,759);ctx.lineTo(114,795);ctx.lineTo(97,829);ctx.lineTo(81,861);ctx.lineTo(66,891);ctx.lineTo(52,920);ctx.lineTo(39,946);ctx.lineTo(28,969);ctx.lineTo(57,948);ctx.lineTo(87,928);ctx.lineTo(116,910);ctx.lineTo(145,893);ctx.lineTo(174,877);ctx.lineTo(204,863);ctx.lineTo(233,850);ctx.lineTo(263,838);ctx.lineTo(292,828);ctx.lineTo(322,820);ctx.lineTo(352,812);ctx.lineTo(381,806);ctx.lineTo(410,801);ctx.lineTo(440,798);ctx.lineTo(469,796);ctx.lineTo(499,795);ctx.lineTo(529,796);ctx.lineTo(558,798);ctx.lineTo(588,801);ctx.lineTo(617,806);ctx.lineTo(646,812);ctx.lineTo(676,820);ctx.lineTo(706,828);ctx.lineTo(735,838);ctx.lineTo(765,850);ctx.lineTo(794,863);ctx.lineTo(824,877);ctx.lineTo(853,893);ctx.lineTo(882,910);ctx.lineTo(911,928);ctx.lineTo(941,948);ctx.lineTo(970,969);ctx.lineTo(958,946);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(958,946));listpt.Add(new Point(946,920));listpt.Add(new Point(931,891));listpt.Add(new Point(916,861));listpt.Add(new Point(900,829));listpt.Add(new Point(883,795));listpt.Add(new Point(866,759));listpt.Add(new Point(847,723));listpt.Add(new Point(828,685));listpt.Add(new Point(809,646));listpt.Add(new Point(789,607));listpt.Add(new Point(770,568));listpt.Add(new Point(750,528));listpt.Add(new Point(730,488));listpt.Add(new Point(710,449));listpt.Add(new Point(691,410));listpt.Add(new Point(671,372));listpt.Add(new Point(653,335));listpt.Add(new Point(635,298));listpt.Add(new Point(617,264));listpt.Add(new Point(601,230));listpt.Add(new Point(585,199));listpt.Add(new Point(570,169));listpt.Add(new Point(556,142));listpt.Add(new Point(544,117));listpt.Add(new Point(523,75));listpt.Add(new Point(508,45));listpt.Add(new Point(500,30));listpt.Add(new Point(499,28));listpt.Add(new Point(498,30));listpt.Add(new Point(483,59));listpt.Add(new Point(465,95));listpt.Add(new Point(454,117));listpt.Add(new Point(442,142));listpt.Add(new Point(428,169));listpt.Add(new Point(413,199));listpt.Add(new Point(397,230));listpt.Add(new Point(381,264));listpt.Add(new Point(363,298));listpt.Add(new Point(345,334));listpt.Add(new Point(326,372));listpt.Add(new Point(307,410));listpt.Add(new Point(288,449));listpt.Add(new Point(268,488));listpt.Add(new Point(248,528));listpt.Add(new Point(228,568));listpt.Add(new Point(208,607));listpt.Add(new Point(189,646));listpt.Add(new Point(169,685));listpt.Add(new Point(151,722));listpt.Add(new Point(132,759));listpt.Add(new Point(114,795));listpt.Add(new Point(97,829));listpt.Add(new Point(81,861));listpt.Add(new Point(66,891));listpt.Add(new Point(52,920));listpt.Add(new Point(39,946));listpt.Add(new Point(28,969));listpt.Add(new Point(57,948));listpt.Add(new Point(87,928));listpt.Add(new Point(116,910));listpt.Add(new Point(145,893));listpt.Add(new Point(174,877));listpt.Add(new Point(204,863));listpt.Add(new Point(233,850));listpt.Add(new Point(263,838));listpt.Add(new Point(292,828));listpt.Add(new Point(322,820));listpt.Add(new Point(352,812));listpt.Add(new Point(381,806));listpt.Add(new Point(410,801));listpt.Add(new Point(440,798));listpt.Add(new Point(469,796));listpt.Add(new Point(499,795));listpt.Add(new Point(529,796));listpt.Add(new Point(558,798));listpt.Add(new Point(588,801));listpt.Add(new Point(617,806));listpt.Add(new Point(646,812));listpt.Add(new Point(676,820));listpt.Add(new Point(706,828));listpt.Add(new Point(735,838));listpt.Add(new Point(765,850));listpt.Add(new Point(794,863));listpt.Add(new Point(824,877));listpt.Add(new Point(853,893));listpt.Add(new Point(882,910));listpt.Add(new Point(911,928));listpt.Add(new Point(941,948));listpt.Add(new Point(970,969));listpt.Add(new Point(958,946));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}