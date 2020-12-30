using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_8a57e2b9_8481_463f_83ab_49f12da29224 : Pixie
    {
        public PIXIE_8a57e2b9_8481_463f_83ab_49f12da29224()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#161717"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#161717"));
_w = 380f; _h = 243f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#161717'; arrBorderColor[1] = '#161717'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(297,243);ctx.lineTo(297,238);ctx.lineTo(297,234);ctx.lineTo(297,229);ctx.lineTo(297,225);ctx.lineTo(306,213);ctx.lineTo(315,201);ctx.lineTo(322,189);ctx.lineTo(327,177);ctx.lineTo(332,165);ctx.lineTo(335,152);ctx.lineTo(337,140);ctx.lineTo(338,127);ctx.lineTo(337,114);ctx.lineTo(335,102);ctx.lineTo(332,89);ctx.lineTo(327,77);ctx.lineTo(322,65);ctx.lineTo(315,53);ctx.lineTo(306,41);ctx.lineTo(297,29);ctx.lineTo(297,15);ctx.lineTo(297,11);ctx.lineTo(303,11);ctx.lineTo(360,11);ctx.lineTo(365,26);ctx.lineTo(369,41);ctx.lineTo(372,55);ctx.lineTo(375,70);ctx.lineTo(377,84);ctx.lineTo(378,98);ctx.lineTo(379,113);ctx.lineTo(380,127);ctx.lineTo(379,141);ctx.lineTo(378,156);ctx.lineTo(377,170);ctx.lineTo(375,184);ctx.lineTo(372,199);ctx.lineTo(369,213);ctx.lineTo(365,228);ctx.lineTo(360,243);ctx.lineTo(354,243);ctx.lineTo(297,243);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(109,207);ctx.lineTo(104,198);ctx.lineTo(102,190);ctx.lineTo(101,180);ctx.lineTo(15,180);ctx.lineTo(11,180);ctx.lineTo(11,175);ctx.lineTo(11,73);ctx.lineTo(101,73);ctx.lineTo(102,63);ctx.lineTo(107,50);ctx.lineTo(109,47);ctx.lineTo(116,44);ctx.lineTo(129,42);ctx.lineTo(147,41);ctx.lineTo(167,40);ctx.lineTo(190,41);ctx.lineTo(212,42);ctx.lineTo(234,44);ctx.lineTo(252,47);ctx.lineTo(265,54);ctx.lineTo(276,62);ctx.lineTo(285,72);ctx.lineTo(293,82);ctx.lineTo(298,93);ctx.lineTo(303,104);ctx.lineTo(305,115);ctx.lineTo(306,127);ctx.lineTo(305,139);ctx.lineTo(303,150);ctx.lineTo(298,161);ctx.lineTo(293,172);ctx.lineTo(285,182);ctx.lineTo(276,192);ctx.lineTo(265,200);ctx.lineTo(252,207);ctx.lineTo(234,210);ctx.lineTo(212,212);ctx.lineTo(190,213);ctx.lineTo(167,214);ctx.lineTo(147,213);ctx.lineTo(129,212);ctx.lineTo(116,210);ctx.lineTo(109,207);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(297,243));listpt.Add(new Point(297,238));listpt.Add(new Point(297,234));listpt.Add(new Point(297,229));listpt.Add(new Point(297,225));listpt.Add(new Point(306,213));listpt.Add(new Point(315,201));listpt.Add(new Point(322,189));listpt.Add(new Point(327,177));listpt.Add(new Point(332,165));listpt.Add(new Point(335,152));listpt.Add(new Point(337,140));listpt.Add(new Point(338,127));listpt.Add(new Point(337,114));listpt.Add(new Point(335,102));listpt.Add(new Point(332,89));listpt.Add(new Point(327,77));listpt.Add(new Point(322,65));listpt.Add(new Point(315,53));listpt.Add(new Point(306,41));listpt.Add(new Point(297,29));listpt.Add(new Point(297,15));listpt.Add(new Point(297,11));listpt.Add(new Point(303,11));listpt.Add(new Point(360,11));listpt.Add(new Point(365,26));listpt.Add(new Point(369,41));listpt.Add(new Point(372,55));listpt.Add(new Point(375,70));listpt.Add(new Point(377,84));listpt.Add(new Point(378,98));listpt.Add(new Point(379,113));listpt.Add(new Point(380,127));listpt.Add(new Point(379,141));listpt.Add(new Point(378,156));listpt.Add(new Point(377,170));listpt.Add(new Point(375,184));listpt.Add(new Point(372,199));listpt.Add(new Point(369,213));listpt.Add(new Point(365,228));listpt.Add(new Point(360,243));listpt.Add(new Point(354,243));listpt.Add(new Point(297,243));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(109,207));listpt.Add(new Point(104,198));listpt.Add(new Point(102,190));listpt.Add(new Point(101,180));listpt.Add(new Point(15,180));listpt.Add(new Point(11,180));listpt.Add(new Point(11,175));listpt.Add(new Point(11,73));listpt.Add(new Point(101,73));listpt.Add(new Point(102,63));listpt.Add(new Point(107,50));listpt.Add(new Point(109,47));listpt.Add(new Point(116,44));listpt.Add(new Point(129,42));listpt.Add(new Point(147,41));listpt.Add(new Point(167,40));listpt.Add(new Point(190,41));listpt.Add(new Point(212,42));listpt.Add(new Point(234,44));listpt.Add(new Point(252,47));listpt.Add(new Point(265,54));listpt.Add(new Point(276,62));listpt.Add(new Point(285,72));listpt.Add(new Point(293,82));listpt.Add(new Point(298,93));listpt.Add(new Point(303,104));listpt.Add(new Point(305,115));listpt.Add(new Point(306,127));listpt.Add(new Point(305,139));listpt.Add(new Point(303,150));listpt.Add(new Point(298,161));listpt.Add(new Point(293,172));listpt.Add(new Point(285,182));listpt.Add(new Point(276,192));listpt.Add(new Point(265,200));listpt.Add(new Point(252,207));listpt.Add(new Point(234,210));listpt.Add(new Point(212,212));listpt.Add(new Point(190,213));listpt.Add(new Point(167,214));listpt.Add(new Point(147,213));listpt.Add(new Point(129,212));listpt.Add(new Point(116,210));listpt.Add(new Point(109,207));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}