using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WaterWastewater
{
    public class PIXIE_efe032f3_6f01_4892_ab2a_20a10a06a90c : Pixie
    {
        public PIXIE_efe032f3_6f01_4892_ab2a_20a10a06a90c()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f0f0f0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f0f0f0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f0f0f0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#191919"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#191919"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#191919"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#191919"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listfillcolor.Add(ColorTranslator.FromHtml("#0000ad"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listfillcolor.Add(ColorTranslator.FromHtml("#f0f0f0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e0e0e0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0000bf"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0000ad"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f0f0f0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e0e0e0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e0e0e0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#717171"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e0e0e0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 928f;
_content = "var arrFillColor = new Array(24); var arrBorderColor = new Array(24); var arrBorderWidth = new Array(24); arrFillColor[0] = '#7f7f7f'; arrFillColor[1] = '#f0f0f0'; arrFillColor[2] = '#f0f0f0'; arrFillColor[3] = '#f0f0f0'; arrFillColor[4] = '#191919'; arrFillColor[5] = '#191919'; arrFillColor[6] = '#191919'; arrFillColor[7] = '#191919'; arrFillColor[8] = '#000'; arrFillColor[9] = '#000'; arrFillColor[10] = '#0000ad'; arrFillColor[11] = '#f0f0f0'; arrFillColor[12] = '#e0e0e0'; arrFillColor[13] = '#0000bf'; arrFillColor[14] = '#0000ad'; arrFillColor[15] = '#f0f0f0'; arrFillColor[16] = '#e0e0e0'; arrFillColor[17] = '#e5e5e5'; arrFillColor[18] = '#ccc'; arrFillColor[19] = '#ccc'; arrFillColor[20] = '#e0e0e0'; arrFillColor[21] = '#fff'; arrFillColor[22] = '#717171'; arrFillColor[23] = '#e0e0e0'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderColor[6] = '#000'; arrBorderColor[7] = '#000'; arrBorderColor[8] = '#000'; arrBorderColor[9] = '#7f7f7f'; arrBorderColor[10] = '#7f7f7f'; arrBorderColor[11] = '#000'; arrBorderColor[12] = '#000'; arrBorderColor[13] = '#000'; arrBorderColor[14] = '#000'; arrBorderColor[15] = '#000'; arrBorderColor[16] = '#000'; arrBorderColor[17] = '#000'; arrBorderColor[18] = '#7f7f7f'; arrBorderColor[19] = '#000'; arrBorderColor[20] = '#000'; arrBorderColor[21] = '#000'; arrBorderColor[22] = '#000'; arrBorderColor[23] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; arrBorderWidth[6] = '2'; arrBorderWidth[7] = '2'; arrBorderWidth[8] = '2'; arrBorderWidth[9] = '2'; arrBorderWidth[10] = '2'; arrBorderWidth[11] = '2'; arrBorderWidth[12] = '2'; arrBorderWidth[13] = '2'; arrBorderWidth[14] = '2'; arrBorderWidth[15] = '2'; arrBorderWidth[16] = '2'; arrBorderWidth[17] = '2'; arrBorderWidth[18] = '2'; arrBorderWidth[19] = '2'; arrBorderWidth[20] = '2'; arrBorderWidth[21] = '2'; arrBorderWidth[22] = '2'; arrBorderWidth[23] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(31,928);ctx.lineTo(932,928);ctx.lineTo(970,764);ctx.lineTo(193,764);ctx.lineTo(31,928);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(145,613);ctx.lineTo(137,615);ctx.lineTo(133,625);ctx.lineTo(133,643);ctx.lineTo(141,645);ctx.lineTo(147,643);ctx.lineTo(147,633);ctx.lineTo(149,629);ctx.lineTo(155,627);ctx.lineTo(304,627);ctx.lineTo(304,613);ctx.lineTo(145,613);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(896,809);ctx.lineTo(904,805);ctx.lineTo(908,797);ctx.lineTo(908,779);ctx.lineTo(900,777);ctx.lineTo(894,779);ctx.lineTo(894,787);ctx.lineTo(892,793);ctx.lineTo(886,795);ctx.lineTo(373,795);ctx.lineTo(373,809);ctx.lineTo(896,809);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(341,797);ctx.lineTo(345,805);ctx.lineTo(353,809);ctx.lineTo(373,809);ctx.lineTo(376,803);ctx.lineTo(373,795);ctx.lineTo(363,795);ctx.lineTo(357,793);ctx.lineTo(355,789);ctx.lineTo(355,768);ctx.lineTo(341,768);ctx.lineTo(341,797);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(813,651);ctx.lineTo(835,651);ctx.lineTo(835,902);ctx.lineTo(813,902);ctx.lineTo(813,651);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(471,651);ctx.lineTo(493,651);ctx.lineTo(493,902);ctx.lineTo(471,902);ctx.lineTo(471,651);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(442,651);ctx.lineTo(454,651);ctx.lineTo(454,902);ctx.lineTo(442,902);ctx.lineTo(442,651);ctx.fillStyle = arrFillColor[6];ctx.fill();ctx.lineWidth = arrBorderWidth[6];ctx.strokeStyle = arrBorderColor[6];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(242,651);ctx.lineTo(254,651);ctx.lineTo(254,902);ctx.lineTo(242,902);ctx.lineTo(242,651);ctx.fillStyle = arrFillColor[7];ctx.fill();ctx.lineWidth = arrBorderWidth[7];ctx.strokeStyle = arrBorderColor[7];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(472,72);ctx.lineTo(833,72);ctx.lineTo(833,783);ctx.lineTo(472,783);ctx.lineTo(472,72);ctx.fillStyle = arrFillColor[8];ctx.fill();ctx.lineWidth = arrBorderWidth[8];ctx.strokeStyle = arrBorderColor[8];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(472,74);ctx.lineTo(503,80);ctx.lineTo(551,84);ctx.lineTo(582,84);ctx.lineTo(616,86);ctx.lineTo(689,86);ctx.lineTo(722,84);ctx.lineTo(754,84);ctx.lineTo(802,80);ctx.lineTo(829,76);ctx.lineTo(833,74);ctx.lineTo(802,48);ctx.lineTo(780,42);ctx.lineTo(754,36);ctx.lineTo(722,32);ctx.lineTo(689,29);ctx.lineTo(653,28);ctx.lineTo(616,29);ctx.lineTo(582,32);ctx.lineTo(551,36);ctx.lineTo(525,42);ctx.lineTo(487,56);ctx.lineTo(472,74);ctx.fillStyle = arrFillColor[9];ctx.fill();ctx.lineWidth = arrBorderWidth[9];ctx.strokeStyle = arrBorderColor[9];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(248,58);ctx.lineTo(250,58);ctx.lineTo(254,60);ctx.lineTo(264,60);ctx.lineTo(276,62);ctx.lineTo(290,62);ctx.lineTo(308,64);ctx.lineTo(388,64);ctx.lineTo(404,62);ctx.lineTo(420,62);ctx.lineTo(432,60);ctx.lineTo(446,58);ctx.lineTo(448,58);ctx.lineTo(446,52);ctx.lineTo(440,48);ctx.lineTo(432,44);ctx.lineTo(420,40);ctx.lineTo(404,36);ctx.lineTo(388,33);ctx.lineTo(367,32);ctx.lineTo(327,32);ctx.lineTo(308,33);ctx.lineTo(290,36);ctx.lineTo(276,40);ctx.lineTo(264,44);ctx.lineTo(254,48);ctx.lineTo(250,52);ctx.lineTo(248,58);ctx.fillStyle = arrFillColor[10];ctx.fill();ctx.lineWidth = arrBorderWidth[10];ctx.strokeStyle = arrBorderColor[10];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(898,110);ctx.lineTo(896,102);ctx.lineTo(886,98);ctx.lineTo(798,98);ctx.lineTo(796,106);ctx.lineTo(798,113);ctx.lineTo(878,113);ctx.lineTo(882,115);ctx.lineTo(883,121);ctx.lineTo(883,252);ctx.lineTo(898,252);ctx.lineTo(898,110);ctx.fillStyle = arrFillColor[11];ctx.fill();ctx.lineWidth = arrBorderWidth[11];ctx.strokeStyle = arrBorderColor[11];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(661,287);ctx.lineTo(762,287);ctx.lineTo(762,388);ctx.lineTo(661,388);ctx.lineTo(661,287);ctx.fillStyle = arrFillColor[12];ctx.fill();ctx.lineWidth = arrBorderWidth[12];ctx.strokeStyle = arrBorderColor[12];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(600,805);ctx.lineTo(709,805);ctx.lineTo(709,886);ctx.lineTo(600,886);ctx.lineTo(600,805);ctx.fillStyle = arrFillColor[13];ctx.fill();ctx.lineWidth = arrBorderWidth[13];ctx.strokeStyle = arrBorderColor[13];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(600,787);ctx.lineTo(562,787);ctx.lineTo(562,888);ctx.lineTo(600,888);ctx.lineTo(600,787);ctx.fillStyle = arrFillColor[14];ctx.fill();ctx.lineWidth = arrBorderWidth[14];ctx.strokeStyle = arrBorderColor[14];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(541,827);ctx.lineTo(562,827);ctx.lineTo(562,847);ctx.lineTo(541,847);ctx.lineTo(541,827);ctx.fillStyle = arrFillColor[15];ctx.fill();ctx.lineWidth = arrBorderWidth[15];ctx.strokeStyle = arrBorderColor[15];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(527,501);ctx.lineTo(539,501);ctx.lineTo(539,795);ctx.lineTo(527,795);ctx.lineTo(527,501);ctx.fillStyle = arrFillColor[16];ctx.fill();ctx.lineWidth = arrBorderWidth[16];ctx.strokeStyle = arrBorderColor[16];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(110,681);ctx.lineTo(169,681);ctx.lineTo(169,673);ctx.lineTo(110,673);ctx.lineTo(110,681);ctx.fillStyle = arrFillColor[17];ctx.fill();ctx.lineWidth = arrBorderWidth[17];ctx.strokeStyle = arrBorderColor[17];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(448,507);ctx.lineTo(440,509);ctx.lineTo(432,509);ctx.lineTo(420,512);ctx.lineTo(404,512);ctx.lineTo(388,513);ctx.lineTo(308,513);ctx.lineTo(290,512);ctx.lineTo(276,512);ctx.lineTo(264,509);ctx.lineTo(254,509);ctx.lineTo(250,507);ctx.lineTo(248,507);ctx.lineTo(248,489);ctx.lineTo(250,491);ctx.lineTo(254,491);ctx.lineTo(264,493);ctx.lineTo(290,493);ctx.lineTo(308,495);ctx.lineTo(388,495);ctx.lineTo(404,493);ctx.lineTo(432,493);ctx.lineTo(440,491);ctx.lineTo(446,491);ctx.lineTo(448,489);ctx.lineTo(448,507);ctx.fillStyle = arrFillColor[18];ctx.fill();ctx.lineWidth = arrBorderWidth[18];ctx.strokeStyle = arrBorderColor[18];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(424,281);ctx.lineTo(639,281);ctx.lineTo(639,495);ctx.lineTo(631,501);ctx.lineTo(416,289);ctx.lineTo(424,281);ctx.fillStyle = arrFillColor[19];ctx.fill();ctx.lineWidth = arrBorderWidth[19];ctx.strokeStyle = arrBorderColor[19];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(416,287);ctx.lineTo(631,287);ctx.lineTo(631,501);ctx.lineTo(416,501);ctx.lineTo(416,287);ctx.fillStyle = arrFillColor[20];ctx.fill();ctx.lineWidth = arrBorderWidth[20];ctx.strokeStyle = arrBorderColor[20];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(430,301);ctx.lineTo(537,301);ctx.lineTo(537,408);ctx.lineTo(430,408);ctx.lineTo(430,301);ctx.fillStyle = arrFillColor[21];ctx.fill();ctx.lineWidth = arrBorderWidth[21];ctx.strokeStyle = arrBorderColor[21];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(140,795,112,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[22];ctx.fill();ctx.lineWidth = arrBorderWidth[22];ctx.strokeStyle = arrBorderColor[22];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(72,888);ctx.lineTo(207,888);ctx.lineTo(220,919);ctx.lineTo(57,919);ctx.lineTo(72,888);ctx.fillStyle = arrFillColor[23];ctx.fill();ctx.lineWidth = arrBorderWidth[23];ctx.strokeStyle = arrBorderColor[23];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(31,928));listpt.Add(new Point(932,928));listpt.Add(new Point(970,764));listpt.Add(new Point(193,764));listpt.Add(new Point(31,928));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(145,613));listpt.Add(new Point(137,615));listpt.Add(new Point(133,625));listpt.Add(new Point(133,643));listpt.Add(new Point(141,645));listpt.Add(new Point(147,643));listpt.Add(new Point(147,633));listpt.Add(new Point(149,629));listpt.Add(new Point(155,627));listpt.Add(new Point(304,627));listpt.Add(new Point(304,613));listpt.Add(new Point(145,613));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(896,809));listpt.Add(new Point(904,805));listpt.Add(new Point(908,797));listpt.Add(new Point(908,779));listpt.Add(new Point(900,777));listpt.Add(new Point(894,779));listpt.Add(new Point(894,787));listpt.Add(new Point(892,793));listpt.Add(new Point(886,795));listpt.Add(new Point(373,795));listpt.Add(new Point(373,809));listpt.Add(new Point(896,809));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(341,797));listpt.Add(new Point(345,805));listpt.Add(new Point(353,809));listpt.Add(new Point(373,809));listpt.Add(new Point(376,803));listpt.Add(new Point(373,795));listpt.Add(new Point(363,795));listpt.Add(new Point(357,793));listpt.Add(new Point(355,789));listpt.Add(new Point(355,768));listpt.Add(new Point(341,768));listpt.Add(new Point(341,797));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(813,651));listpt.Add(new Point(835,651));listpt.Add(new Point(835,902));listpt.Add(new Point(813,902));listpt.Add(new Point(813,651));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(471,651));listpt.Add(new Point(493,651));listpt.Add(new Point(493,902));listpt.Add(new Point(471,902));listpt.Add(new Point(471,651));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(442,651));listpt.Add(new Point(454,651));listpt.Add(new Point(454,902));listpt.Add(new Point(442,902));listpt.Add(new Point(442,651));sb = new SolidBrush(_listfillcolor[6]);p = new Pen(Color.Black);p.Width = _listborderwidth[6];p.Color = _listbordercolor[6];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(242,651));listpt.Add(new Point(254,651));listpt.Add(new Point(254,902));listpt.Add(new Point(242,902));listpt.Add(new Point(242,651));sb = new SolidBrush(_listfillcolor[7]);p = new Pen(Color.Black);p.Width = _listborderwidth[7];p.Color = _listbordercolor[7];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(472,72));listpt.Add(new Point(833,72));listpt.Add(new Point(833,783));listpt.Add(new Point(472,783));listpt.Add(new Point(472,72));sb = new SolidBrush(_listfillcolor[8]);p = new Pen(Color.Black);p.Width = _listborderwidth[8];p.Color = _listbordercolor[8];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(472,74));listpt.Add(new Point(503,80));listpt.Add(new Point(551,84));listpt.Add(new Point(582,84));listpt.Add(new Point(616,86));listpt.Add(new Point(689,86));listpt.Add(new Point(722,84));listpt.Add(new Point(754,84));listpt.Add(new Point(802,80));listpt.Add(new Point(829,76));listpt.Add(new Point(833,74));listpt.Add(new Point(802,48));listpt.Add(new Point(780,42));listpt.Add(new Point(754,36));listpt.Add(new Point(722,32));listpt.Add(new Point(689,29));listpt.Add(new Point(653,28));listpt.Add(new Point(616,29));listpt.Add(new Point(582,32));listpt.Add(new Point(551,36));listpt.Add(new Point(525,42));listpt.Add(new Point(487,56));listpt.Add(new Point(472,74));sb = new SolidBrush(_listfillcolor[9]);p = new Pen(Color.Black);p.Width = _listborderwidth[9];p.Color = _listbordercolor[9];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(248,58));listpt.Add(new Point(250,58));listpt.Add(new Point(254,60));listpt.Add(new Point(264,60));listpt.Add(new Point(276,62));listpt.Add(new Point(290,62));listpt.Add(new Point(308,64));listpt.Add(new Point(388,64));listpt.Add(new Point(404,62));listpt.Add(new Point(420,62));listpt.Add(new Point(432,60));listpt.Add(new Point(446,58));listpt.Add(new Point(448,58));listpt.Add(new Point(446,52));listpt.Add(new Point(440,48));listpt.Add(new Point(432,44));listpt.Add(new Point(420,40));listpt.Add(new Point(404,36));listpt.Add(new Point(388,33));listpt.Add(new Point(367,32));listpt.Add(new Point(327,32));listpt.Add(new Point(308,33));listpt.Add(new Point(290,36));listpt.Add(new Point(276,40));listpt.Add(new Point(264,44));listpt.Add(new Point(254,48));listpt.Add(new Point(250,52));listpt.Add(new Point(248,58));sb = new SolidBrush(_listfillcolor[10]);p = new Pen(Color.Black);p.Width = _listborderwidth[10];p.Color = _listbordercolor[10];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(898,110));listpt.Add(new Point(896,102));listpt.Add(new Point(886,98));listpt.Add(new Point(798,98));listpt.Add(new Point(796,106));listpt.Add(new Point(798,113));listpt.Add(new Point(878,113));listpt.Add(new Point(882,115));listpt.Add(new Point(883,121));listpt.Add(new Point(883,252));listpt.Add(new Point(898,252));listpt.Add(new Point(898,110));sb = new SolidBrush(_listfillcolor[11]);p = new Pen(Color.Black);p.Width = _listborderwidth[11];p.Color = _listbordercolor[11];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(661,287));listpt.Add(new Point(762,287));listpt.Add(new Point(762,388));listpt.Add(new Point(661,388));listpt.Add(new Point(661,287));sb = new SolidBrush(_listfillcolor[12]);p = new Pen(Color.Black);p.Width = _listborderwidth[12];p.Color = _listbordercolor[12];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(600,805));listpt.Add(new Point(709,805));listpt.Add(new Point(709,886));listpt.Add(new Point(600,886));listpt.Add(new Point(600,805));sb = new SolidBrush(_listfillcolor[13]);p = new Pen(Color.Black);p.Width = _listborderwidth[13];p.Color = _listbordercolor[13];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(600,787));listpt.Add(new Point(562,787));listpt.Add(new Point(562,888));listpt.Add(new Point(600,888));listpt.Add(new Point(600,787));sb = new SolidBrush(_listfillcolor[14]);p = new Pen(Color.Black);p.Width = _listborderwidth[14];p.Color = _listbordercolor[14];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(541,827));listpt.Add(new Point(562,827));listpt.Add(new Point(562,847));listpt.Add(new Point(541,847));listpt.Add(new Point(541,827));sb = new SolidBrush(_listfillcolor[15]);p = new Pen(Color.Black);p.Width = _listborderwidth[15];p.Color = _listbordercolor[15];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(527,501));listpt.Add(new Point(539,501));listpt.Add(new Point(539,795));listpt.Add(new Point(527,795));listpt.Add(new Point(527,501));sb = new SolidBrush(_listfillcolor[16]);p = new Pen(Color.Black);p.Width = _listborderwidth[16];p.Color = _listbordercolor[16];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(110,681));listpt.Add(new Point(169,681));listpt.Add(new Point(169,673));listpt.Add(new Point(110,673));listpt.Add(new Point(110,681));sb = new SolidBrush(_listfillcolor[17]);p = new Pen(Color.Black);p.Width = _listborderwidth[17];p.Color = _listbordercolor[17];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(448,507));listpt.Add(new Point(440,509));listpt.Add(new Point(432,509));listpt.Add(new Point(420,512));listpt.Add(new Point(404,512));listpt.Add(new Point(388,513));listpt.Add(new Point(308,513));listpt.Add(new Point(290,512));listpt.Add(new Point(276,512));listpt.Add(new Point(264,509));listpt.Add(new Point(254,509));listpt.Add(new Point(250,507));listpt.Add(new Point(248,507));listpt.Add(new Point(248,489));listpt.Add(new Point(250,491));listpt.Add(new Point(254,491));listpt.Add(new Point(264,493));listpt.Add(new Point(290,493));listpt.Add(new Point(308,495));listpt.Add(new Point(388,495));listpt.Add(new Point(404,493));listpt.Add(new Point(432,493));listpt.Add(new Point(440,491));listpt.Add(new Point(446,491));listpt.Add(new Point(448,489));listpt.Add(new Point(448,507));sb = new SolidBrush(_listfillcolor[18]);p = new Pen(Color.Black);p.Width = _listborderwidth[18];p.Color = _listbordercolor[18];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(424,281));listpt.Add(new Point(639,281));listpt.Add(new Point(639,495));listpt.Add(new Point(631,501));listpt.Add(new Point(416,289));listpt.Add(new Point(424,281));sb = new SolidBrush(_listfillcolor[19]);p = new Pen(Color.Black);p.Width = _listborderwidth[19];p.Color = _listbordercolor[19];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(416,287));listpt.Add(new Point(631,287));listpt.Add(new Point(631,501));listpt.Add(new Point(416,501));listpt.Add(new Point(416,287));sb = new SolidBrush(_listfillcolor[20]);p = new Pen(Color.Black);p.Width = _listborderwidth[20];p.Color = _listbordercolor[20];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(430,301));listpt.Add(new Point(537,301));listpt.Add(new Point(537,408));listpt.Add(new Point(430,408));listpt.Add(new Point(430,301));sb = new SolidBrush(_listfillcolor[21]);p = new Pen(Color.Black);p.Width = _listborderwidth[21];p.Color = _listbordercolor[21];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[22]);p = new Pen(Color.Black);p.Width = _listborderwidth[22];p.Color = _listbordercolor[22];g.FillEllipse(sb, 28f,683f,224f,224f);g.DrawEllipse(p, 28f,683f,224f,224f);
listpt = new List<Point>();listpt.Add(new Point(72,888));listpt.Add(new Point(207,888));listpt.Add(new Point(220,919));listpt.Add(new Point(57,919));listpt.Add(new Point(72,888));sb = new SolidBrush(_listfillcolor[23]);p = new Pen(Color.Black);p.Width = _listborderwidth[23];p.Color = _listbordercolor[23];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}