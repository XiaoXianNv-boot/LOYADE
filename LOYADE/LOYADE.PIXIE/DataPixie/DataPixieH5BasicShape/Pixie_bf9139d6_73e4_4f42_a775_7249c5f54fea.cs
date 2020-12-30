using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_bf9139d6_73e4_4f42_a775_7249c5f54fea : Pixie
    {
        public PIXIE_bf9139d6_73e4_4f42_a775_7249c5f54fea()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 671f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(32,651);ctx.lineTo(40,611);ctx.lineTo(46,571);ctx.lineTo(52,531);ctx.lineTo(56,490);ctx.lineTo(60,450);ctx.lineTo(62,410);ctx.lineTo(63,370);ctx.lineTo(63,329);ctx.lineTo(62,289);ctx.lineTo(60,249);ctx.lineTo(56,209);ctx.lineTo(52,169);ctx.lineTo(46,128);ctx.lineTo(40,88);ctx.lineTo(32,48);ctx.lineTo(28,28);ctx.lineTo(54,33);ctx.lineTo(82,37);ctx.lineTo(110,41);ctx.lineTo(138,45);ctx.lineTo(167,49);ctx.lineTo(196,52);ctx.lineTo(225,55);ctx.lineTo(255,58);ctx.lineTo(285,60);ctx.lineTo(315,62);ctx.lineTo(345,64);ctx.lineTo(376,66);ctx.lineTo(406,67);ctx.lineTo(437,67);ctx.lineTo(468,68);ctx.lineTo(499,68);ctx.lineTo(530,68);ctx.lineTo(561,67);ctx.lineTo(592,67);ctx.lineTo(622,66);ctx.lineTo(653,64);ctx.lineTo(683,62);ctx.lineTo(713,60);ctx.lineTo(743,58);ctx.lineTo(773,55);ctx.lineTo(802,52);ctx.lineTo(831,49);ctx.lineTo(860,45);ctx.lineTo(888,41);ctx.lineTo(916,37);ctx.lineTo(944,33);ctx.lineTo(970,28);ctx.lineTo(966,45);ctx.lineTo(958,82);ctx.lineTo(952,119);ctx.lineTo(946,158);ctx.lineTo(942,197);ctx.lineTo(938,237);ctx.lineTo(936,278);ctx.lineTo(935,319);ctx.lineTo(935,360);ctx.lineTo(936,402);ctx.lineTo(938,444);ctx.lineTo(942,486);ctx.lineTo(946,528);ctx.lineTo(952,569);ctx.lineTo(958,611);ctx.lineTo(966,651);ctx.lineTo(970,671);ctx.lineTo(944,667);ctx.lineTo(916,662);ctx.lineTo(888,658);ctx.lineTo(860,654);ctx.lineTo(831,650);ctx.lineTo(802,647);ctx.lineTo(773,644);ctx.lineTo(743,641);ctx.lineTo(713,639);ctx.lineTo(683,637);ctx.lineTo(653,635);ctx.lineTo(622,634);ctx.lineTo(592,633);ctx.lineTo(561,632);ctx.lineTo(530,631);ctx.lineTo(499,631);ctx.lineTo(468,631);ctx.lineTo(437,632);ctx.lineTo(406,633);ctx.lineTo(376,634);ctx.lineTo(345,635);ctx.lineTo(315,637);ctx.lineTo(285,639);ctx.lineTo(255,641);ctx.lineTo(225,644);ctx.lineTo(196,647);ctx.lineTo(167,650);ctx.lineTo(138,654);ctx.lineTo(110,658);ctx.lineTo(82,662);ctx.lineTo(54,667);ctx.lineTo(28,671);ctx.lineTo(32,651);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(32,651));listpt.Add(new Point(40,611));listpt.Add(new Point(46,571));listpt.Add(new Point(52,531));listpt.Add(new Point(56,490));listpt.Add(new Point(60,450));listpt.Add(new Point(62,410));listpt.Add(new Point(63,370));listpt.Add(new Point(63,329));listpt.Add(new Point(62,289));listpt.Add(new Point(60,249));listpt.Add(new Point(56,209));listpt.Add(new Point(52,169));listpt.Add(new Point(46,128));listpt.Add(new Point(40,88));listpt.Add(new Point(32,48));listpt.Add(new Point(28,28));listpt.Add(new Point(54,33));listpt.Add(new Point(82,37));listpt.Add(new Point(110,41));listpt.Add(new Point(138,45));listpt.Add(new Point(167,49));listpt.Add(new Point(196,52));listpt.Add(new Point(225,55));listpt.Add(new Point(255,58));listpt.Add(new Point(285,60));listpt.Add(new Point(315,62));listpt.Add(new Point(345,64));listpt.Add(new Point(376,66));listpt.Add(new Point(406,67));listpt.Add(new Point(437,67));listpt.Add(new Point(468,68));listpt.Add(new Point(499,68));listpt.Add(new Point(530,68));listpt.Add(new Point(561,67));listpt.Add(new Point(592,67));listpt.Add(new Point(622,66));listpt.Add(new Point(653,64));listpt.Add(new Point(683,62));listpt.Add(new Point(713,60));listpt.Add(new Point(743,58));listpt.Add(new Point(773,55));listpt.Add(new Point(802,52));listpt.Add(new Point(831,49));listpt.Add(new Point(860,45));listpt.Add(new Point(888,41));listpt.Add(new Point(916,37));listpt.Add(new Point(944,33));listpt.Add(new Point(970,28));listpt.Add(new Point(966,45));listpt.Add(new Point(958,82));listpt.Add(new Point(952,119));listpt.Add(new Point(946,158));listpt.Add(new Point(942,197));listpt.Add(new Point(938,237));listpt.Add(new Point(936,278));listpt.Add(new Point(935,319));listpt.Add(new Point(935,360));listpt.Add(new Point(936,402));listpt.Add(new Point(938,444));listpt.Add(new Point(942,486));listpt.Add(new Point(946,528));listpt.Add(new Point(952,569));listpt.Add(new Point(958,611));listpt.Add(new Point(966,651));listpt.Add(new Point(970,671));listpt.Add(new Point(944,667));listpt.Add(new Point(916,662));listpt.Add(new Point(888,658));listpt.Add(new Point(860,654));listpt.Add(new Point(831,650));listpt.Add(new Point(802,647));listpt.Add(new Point(773,644));listpt.Add(new Point(743,641));listpt.Add(new Point(713,639));listpt.Add(new Point(683,637));listpt.Add(new Point(653,635));listpt.Add(new Point(622,634));listpt.Add(new Point(592,633));listpt.Add(new Point(561,632));listpt.Add(new Point(530,631));listpt.Add(new Point(499,631));listpt.Add(new Point(468,631));listpt.Add(new Point(437,632));listpt.Add(new Point(406,633));listpt.Add(new Point(376,634));listpt.Add(new Point(345,635));listpt.Add(new Point(315,637));listpt.Add(new Point(285,639));listpt.Add(new Point(255,641));listpt.Add(new Point(225,644));listpt.Add(new Point(196,647));listpt.Add(new Point(167,650));listpt.Add(new Point(138,654));listpt.Add(new Point(110,658));listpt.Add(new Point(82,662));listpt.Add(new Point(54,667));listpt.Add(new Point(28,671));listpt.Add(new Point(32,651));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}