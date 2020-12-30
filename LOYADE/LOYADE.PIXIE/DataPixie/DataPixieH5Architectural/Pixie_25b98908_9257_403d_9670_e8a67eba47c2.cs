using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Architectural
{
    public class PIXIE_25b98908_9257_403d_9670_e8a67eba47c2 : Pixie
    {
        public PIXIE_25b98908_9257_403d_9670_e8a67eba47c2()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#98b2e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c6699"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 957f; _h = 970f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#98b2e5'; arrFillColor[1] = '#4c6699'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(248,262);ctx.lineTo(273,239);ctx.lineTo(299,219);ctx.lineTo(327,203);ctx.lineTo(357,188);ctx.lineTo(388,177);ctx.lineTo(420,168);ctx.lineTo(453,163);ctx.lineTo(486,161);ctx.lineTo(520,163);ctx.lineTo(553,168);ctx.lineTo(586,177);ctx.lineTo(616,188);ctx.lineTo(646,203);ctx.lineTo(674,219);ctx.lineTo(700,239);ctx.lineTo(724,261);ctx.lineTo(746,285);ctx.lineTo(765,311);ctx.lineTo(782,339);ctx.lineTo(797,368);ctx.lineTo(808,399);ctx.lineTo(816,431);ctx.lineTo(822,465);ctx.lineTo(823,499);ctx.lineTo(823,970);ctx.lineTo(957,970);ctx.lineTo(957,499);ctx.lineTo(955,451);ctx.lineTo(948,404);ctx.lineTo(936,359);ctx.lineTo(920,315);ctx.lineTo(900,274);ctx.lineTo(877,235);ctx.lineTo(850,199);ctx.lineTo(819,166);ctx.lineTo(786,135);ctx.lineTo(749,108);ctx.lineTo(710,84);ctx.lineTo(669,65);ctx.lineTo(626,49);ctx.lineTo(581,37);ctx.lineTo(534,30);ctx.lineTo(510,28);ctx.lineTo(486,28);ctx.lineTo(474,28);ctx.lineTo(440,30);ctx.lineTo(406,35);ctx.lineTo(372,42);ctx.lineTo(338,52);ctx.lineTo(305,64);ctx.lineTo(274,78);ctx.lineTo(243,95);ctx.lineTo(214,114);ctx.lineTo(186,134);ctx.lineTo(160,157);ctx.lineTo(152,165);ctx.lineTo(248,262);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(142,316);ctx.lineTo(92,267);ctx.lineTo(52,212);ctx.lineTo(29,165);ctx.lineTo(28,127);ctx.lineTo(44,110);ctx.lineTo(80,112);ctx.lineTo(129,135);ctx.lineTo(182,175);ctx.lineTo(233,225);ctx.lineTo(273,278);ctx.lineTo(295,327);ctx.lineTo(299,363);ctx.lineTo(280,382);ctx.lineTo(245,378);ctx.lineTo(195,355);ctx.lineTo(142,316);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(248,262));listpt.Add(new Point(273,239));listpt.Add(new Point(299,219));listpt.Add(new Point(327,203));listpt.Add(new Point(357,188));listpt.Add(new Point(388,177));listpt.Add(new Point(420,168));listpt.Add(new Point(453,163));listpt.Add(new Point(486,161));listpt.Add(new Point(520,163));listpt.Add(new Point(553,168));listpt.Add(new Point(586,177));listpt.Add(new Point(616,188));listpt.Add(new Point(646,203));listpt.Add(new Point(674,219));listpt.Add(new Point(700,239));listpt.Add(new Point(724,261));listpt.Add(new Point(746,285));listpt.Add(new Point(765,311));listpt.Add(new Point(782,339));listpt.Add(new Point(797,368));listpt.Add(new Point(808,399));listpt.Add(new Point(816,431));listpt.Add(new Point(822,465));listpt.Add(new Point(823,499));listpt.Add(new Point(823,970));listpt.Add(new Point(957,970));listpt.Add(new Point(957,499));listpt.Add(new Point(955,451));listpt.Add(new Point(948,404));listpt.Add(new Point(936,359));listpt.Add(new Point(920,315));listpt.Add(new Point(900,274));listpt.Add(new Point(877,235));listpt.Add(new Point(850,199));listpt.Add(new Point(819,166));listpt.Add(new Point(786,135));listpt.Add(new Point(749,108));listpt.Add(new Point(710,84));listpt.Add(new Point(669,65));listpt.Add(new Point(626,49));listpt.Add(new Point(581,37));listpt.Add(new Point(534,30));listpt.Add(new Point(510,28));listpt.Add(new Point(486,28));listpt.Add(new Point(474,28));listpt.Add(new Point(440,30));listpt.Add(new Point(406,35));listpt.Add(new Point(372,42));listpt.Add(new Point(338,52));listpt.Add(new Point(305,64));listpt.Add(new Point(274,78));listpt.Add(new Point(243,95));listpt.Add(new Point(214,114));listpt.Add(new Point(186,134));listpt.Add(new Point(160,157));listpt.Add(new Point(152,165));listpt.Add(new Point(248,262));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(142,316));listpt.Add(new Point(92,267));listpt.Add(new Point(52,212));listpt.Add(new Point(29,165));listpt.Add(new Point(28,127));listpt.Add(new Point(44,110));listpt.Add(new Point(80,112));listpt.Add(new Point(129,135));listpt.Add(new Point(182,175));listpt.Add(new Point(233,225));listpt.Add(new Point(273,278));listpt.Add(new Point(295,327));listpt.Add(new Point(299,363));listpt.Add(new Point(280,382));listpt.Add(new Point(245,378));listpt.Add(new Point(195,355));listpt.Add(new Point(142,316));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}