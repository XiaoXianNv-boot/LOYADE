using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Electrical
{
    public class PIXIE_4bb6d019_1b7d_48c2_9465_ce21acb09d96 : Pixie
    {
        public PIXIE_4bb6d019_1b7d_48c2_9465_ce21acb09d96()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 498f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(645,254);ctx.lineTo(970,254);ctx.lineTo(970,271);ctx.lineTo(645,271);ctx.lineTo(640,306);ctx.lineTo(631,337);ctx.lineTo(617,365);ctx.lineTo(601,389);ctx.lineTo(582,410);ctx.lineTo(561,428);ctx.lineTo(537,444);ctx.lineTo(511,458);ctx.lineTo(484,469);ctx.lineTo(457,478);ctx.lineTo(428,485);ctx.lineTo(399,490);ctx.lineTo(370,494);ctx.lineTo(342,496);ctx.lineTo(315,498);ctx.lineTo(301,498);ctx.lineTo(288,498);ctx.lineTo(288,401);ctx.lineTo(28,401);ctx.lineTo(28,384);ctx.lineTo(288,384);ctx.lineTo(288,140);ctx.lineTo(28,140);ctx.lineTo(28,125);ctx.lineTo(288,125);ctx.lineTo(288,28);ctx.lineTo(303,28);ctx.lineTo(333,29);ctx.lineTo(363,31);ctx.lineTo(393,34);ctx.lineTo(422,38);ctx.lineTo(451,44);ctx.lineTo(480,53);ctx.lineTo(506,62);ctx.lineTo(532,75);ctx.lineTo(555,89);ctx.lineTo(576,106);ctx.lineTo(596,126);ctx.lineTo(612,149);ctx.lineTo(626,175);ctx.lineTo(636,204);ctx.lineTo(643,237);ctx.lineTo(645,254);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(321,43);ctx.lineTo(320,43);ctx.lineTo(318,43);ctx.lineTo(315,43);ctx.lineTo(305,43);ctx.lineTo(304,43);ctx.lineTo(304,483);ctx.lineTo(336,481);ctx.lineTo(368,478);ctx.lineTo(401,472);ctx.lineTo(433,466);ctx.lineTo(464,458);ctx.lineTo(496,446);ctx.lineTo(527,431);ctx.lineTo(556,411);ctx.lineTo(581,385);ctx.lineTo(603,354);ctx.lineTo(619,316);ctx.lineTo(625,295);ctx.lineTo(629,271);ctx.lineTo(629,269);ctx.lineTo(625,231);ctx.lineTo(613,189);ctx.lineTo(595,154);ctx.lineTo(570,124);ctx.lineTo(540,100);ctx.lineTo(504,80);ctx.lineTo(462,65);ctx.lineTo(415,54);ctx.lineTo(389,49);ctx.lineTo(362,45);ctx.lineTo(330,43);ctx.lineTo(321,43);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(645,254));listpt.Add(new Point(970,254));listpt.Add(new Point(970,271));listpt.Add(new Point(645,271));listpt.Add(new Point(640,306));listpt.Add(new Point(631,337));listpt.Add(new Point(617,365));listpt.Add(new Point(601,389));listpt.Add(new Point(582,410));listpt.Add(new Point(561,428));listpt.Add(new Point(537,444));listpt.Add(new Point(511,458));listpt.Add(new Point(484,469));listpt.Add(new Point(457,478));listpt.Add(new Point(428,485));listpt.Add(new Point(399,490));listpt.Add(new Point(370,494));listpt.Add(new Point(342,496));listpt.Add(new Point(315,498));listpt.Add(new Point(301,498));listpt.Add(new Point(288,498));listpt.Add(new Point(288,401));listpt.Add(new Point(28,401));listpt.Add(new Point(28,384));listpt.Add(new Point(288,384));listpt.Add(new Point(288,140));listpt.Add(new Point(28,140));listpt.Add(new Point(28,125));listpt.Add(new Point(288,125));listpt.Add(new Point(288,28));listpt.Add(new Point(303,28));listpt.Add(new Point(333,29));listpt.Add(new Point(363,31));listpt.Add(new Point(393,34));listpt.Add(new Point(422,38));listpt.Add(new Point(451,44));listpt.Add(new Point(480,53));listpt.Add(new Point(506,62));listpt.Add(new Point(532,75));listpt.Add(new Point(555,89));listpt.Add(new Point(576,106));listpt.Add(new Point(596,126));listpt.Add(new Point(612,149));listpt.Add(new Point(626,175));listpt.Add(new Point(636,204));listpt.Add(new Point(643,237));listpt.Add(new Point(645,254));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(321,43));listpt.Add(new Point(320,43));listpt.Add(new Point(318,43));listpt.Add(new Point(315,43));listpt.Add(new Point(305,43));listpt.Add(new Point(304,43));listpt.Add(new Point(304,483));listpt.Add(new Point(336,481));listpt.Add(new Point(368,478));listpt.Add(new Point(401,472));listpt.Add(new Point(433,466));listpt.Add(new Point(464,458));listpt.Add(new Point(496,446));listpt.Add(new Point(527,431));listpt.Add(new Point(556,411));listpt.Add(new Point(581,385));listpt.Add(new Point(603,354));listpt.Add(new Point(619,316));listpt.Add(new Point(625,295));listpt.Add(new Point(629,271));listpt.Add(new Point(629,269));listpt.Add(new Point(625,231));listpt.Add(new Point(613,189));listpt.Add(new Point(595,154));listpt.Add(new Point(570,124));listpt.Add(new Point(540,100));listpt.Add(new Point(504,80));listpt.Add(new Point(462,65));listpt.Add(new Point(415,54));listpt.Add(new Point(389,49));listpt.Add(new Point(362,45));listpt.Add(new Point(330,43));listpt.Add(new Point(321,43));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}