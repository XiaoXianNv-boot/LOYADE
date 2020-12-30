using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Architectural
{
    public class PIXIE_421ed6cb_7327_4795_a13e_86c5b33b451d : Pixie
    {
        public PIXIE_421ed6cb_7327_4795_a13e_86c5b33b451d()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#98b2e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 735f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#98b2e5'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(852,67);ctx.lineTo(852,145);ctx.lineTo(793,145);ctx.lineTo(793,99);ctx.lineTo(768,91);ctx.lineTo(738,86);ctx.lineTo(705,90);ctx.lineTo(677,99);ctx.lineTo(650,114);ctx.lineTo(625,135);ctx.lineTo(603,160);ctx.lineTo(584,190);ctx.lineTo(567,223);ctx.lineTo(558,248);ctx.lineTo(551,273);ctx.lineTo(545,300);ctx.lineTo(541,327);ctx.lineTo(539,356);ctx.lineTo(538,380);ctx.lineTo(735,380);ctx.lineTo(735,322);ctx.lineTo(814,322);ctx.lineTo(814,380);ctx.lineTo(970,380);ctx.lineTo(970,390);ctx.lineTo(967,422);ctx.lineTo(960,458);ctx.lineTo(954,484);ctx.lineTo(947,511);ctx.lineTo(938,538);ctx.lineTo(929,565);ctx.lineTo(918,592);ctx.lineTo(906,618);ctx.lineTo(893,642);ctx.lineTo(880,665);ctx.lineTo(859,695);ctx.lineTo(837,719);ctx.lineTo(822,730);ctx.lineTo(814,735);ctx.lineTo(794,735);ctx.lineTo(184,735);ctx.lineTo(161,719);ctx.lineTo(139,695);ctx.lineTo(118,665);ctx.lineTo(105,642);ctx.lineTo(92,618);ctx.lineTo(80,592);ctx.lineTo(69,565);ctx.lineTo(60,538);ctx.lineTo(51,511);ctx.lineTo(44,484);ctx.lineTo(38,458);ctx.lineTo(31,422);ctx.lineTo(28,390);ctx.lineTo(28,380);ctx.lineTo(184,380);ctx.lineTo(184,322);ctx.lineTo(263,322);ctx.lineTo(263,380);ctx.lineTo(460,380);ctx.lineTo(461,344);ctx.lineTo(465,310);ctx.lineTo(472,276);ctx.lineTo(481,243);ctx.lineTo(493,212);ctx.lineTo(507,183);ctx.lineTo(523,156);ctx.lineTo(541,131);ctx.lineTo(560,108);ctx.lineTo(581,88);ctx.lineTo(604,70);ctx.lineTo(628,55);ctx.lineTo(653,43);ctx.lineTo(680,35);ctx.lineTo(707,30);ctx.lineTo(721,28);ctx.lineTo(735,28);ctx.lineTo(742,28);ctx.lineTo(772,33);ctx.lineTo(802,43);ctx.lineTo(831,56);ctx.lineTo(852,67);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(852,67));listpt.Add(new Point(852,145));listpt.Add(new Point(793,145));listpt.Add(new Point(793,99));listpt.Add(new Point(768,91));listpt.Add(new Point(738,86));listpt.Add(new Point(705,90));listpt.Add(new Point(677,99));listpt.Add(new Point(650,114));listpt.Add(new Point(625,135));listpt.Add(new Point(603,160));listpt.Add(new Point(584,190));listpt.Add(new Point(567,223));listpt.Add(new Point(558,248));listpt.Add(new Point(551,273));listpt.Add(new Point(545,300));listpt.Add(new Point(541,327));listpt.Add(new Point(539,356));listpt.Add(new Point(538,380));listpt.Add(new Point(735,380));listpt.Add(new Point(735,322));listpt.Add(new Point(814,322));listpt.Add(new Point(814,380));listpt.Add(new Point(970,380));listpt.Add(new Point(970,390));listpt.Add(new Point(967,422));listpt.Add(new Point(960,458));listpt.Add(new Point(954,484));listpt.Add(new Point(947,511));listpt.Add(new Point(938,538));listpt.Add(new Point(929,565));listpt.Add(new Point(918,592));listpt.Add(new Point(906,618));listpt.Add(new Point(893,642));listpt.Add(new Point(880,665));listpt.Add(new Point(859,695));listpt.Add(new Point(837,719));listpt.Add(new Point(822,730));listpt.Add(new Point(814,735));listpt.Add(new Point(794,735));listpt.Add(new Point(184,735));listpt.Add(new Point(161,719));listpt.Add(new Point(139,695));listpt.Add(new Point(118,665));listpt.Add(new Point(105,642));listpt.Add(new Point(92,618));listpt.Add(new Point(80,592));listpt.Add(new Point(69,565));listpt.Add(new Point(60,538));listpt.Add(new Point(51,511));listpt.Add(new Point(44,484));listpt.Add(new Point(38,458));listpt.Add(new Point(31,422));listpt.Add(new Point(28,390));listpt.Add(new Point(28,380));listpt.Add(new Point(184,380));listpt.Add(new Point(184,322));listpt.Add(new Point(263,322));listpt.Add(new Point(263,380));listpt.Add(new Point(460,380));listpt.Add(new Point(461,344));listpt.Add(new Point(465,310));listpt.Add(new Point(472,276));listpt.Add(new Point(481,243));listpt.Add(new Point(493,212));listpt.Add(new Point(507,183));listpt.Add(new Point(523,156));listpt.Add(new Point(541,131));listpt.Add(new Point(560,108));listpt.Add(new Point(581,88));listpt.Add(new Point(604,70));listpt.Add(new Point(628,55));listpt.Add(new Point(653,43));listpt.Add(new Point(680,35));listpt.Add(new Point(707,30));listpt.Add(new Point(721,28));listpt.Add(new Point(735,28));listpt.Add(new Point(742,28));listpt.Add(new Point(772,33));listpt.Add(new Point(802,43));listpt.Add(new Point(831,56));listpt.Add(new Point(852,67));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}