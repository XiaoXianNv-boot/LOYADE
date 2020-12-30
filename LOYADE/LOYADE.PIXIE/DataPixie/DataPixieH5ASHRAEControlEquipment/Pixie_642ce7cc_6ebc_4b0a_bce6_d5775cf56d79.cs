using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEControlEquipment
{
    public class PIXIE_642ce7cc_6ebc_4b0a_bce6_d5775cf56d79 : Pixie
    {
        public PIXIE_642ce7cc_6ebc_4b0a_bce6_d5775cf56d79()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 726f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(132,726);ctx.lineTo(171,726);ctx.lineTo(209,724);ctx.lineTo(247,722);ctx.lineTo(283,719);ctx.lineTo(319,716);ctx.lineTo(353,712);ctx.lineTo(387,707);ctx.lineTo(420,701);ctx.lineTo(453,694);ctx.lineTo(484,687);ctx.lineTo(515,679);ctx.lineTo(545,671);ctx.lineTo(574,661);ctx.lineTo(602,652);ctx.lineTo(630,641);ctx.lineTo(656,630);ctx.lineTo(682,618);ctx.lineTo(707,606);ctx.lineTo(731,593);ctx.lineTo(754,579);ctx.lineTo(777,565);ctx.lineTo(799,551);ctx.lineTo(819,535);ctx.lineTo(859,504);ctx.lineTo(895,470);ctx.lineTo(927,434);ctx.lineTo(957,396);ctx.lineTo(970,377);ctx.lineTo(957,357);ctx.lineTo(927,320);ctx.lineTo(895,284);ctx.lineTo(859,250);ctx.lineTo(819,218);ctx.lineTo(799,203);ctx.lineTo(777,188);ctx.lineTo(754,174);ctx.lineTo(731,161);ctx.lineTo(707,148);ctx.lineTo(682,136);ctx.lineTo(656,124);ctx.lineTo(630,113);ctx.lineTo(602,102);ctx.lineTo(574,92);ctx.lineTo(545,83);ctx.lineTo(515,74);ctx.lineTo(484,67);ctx.lineTo(453,59);ctx.lineTo(420,53);ctx.lineTo(387,47);ctx.lineTo(353,42);ctx.lineTo(319,38);ctx.lineTo(283,34);ctx.lineTo(247,31);ctx.lineTo(209,29);ctx.lineTo(171,28);ctx.lineTo(132,28);ctx.lineTo(151,48);ctx.lineTo(169,68);ctx.lineTo(186,88);ctx.lineTo(201,109);ctx.lineTo(215,130);ctx.lineTo(240,174);ctx.lineTo(260,218);ctx.lineTo(274,263);ctx.lineTo(284,308);ctx.lineTo(289,354);ctx.lineTo(289,400);ctx.lineTo(284,446);ctx.lineTo(274,491);ctx.lineTo(260,536);ctx.lineTo(240,580);ctx.lineTo(215,623);ctx.lineTo(201,644);ctx.lineTo(186,665);ctx.lineTo(169,686);ctx.lineTo(151,706);ctx.lineTo(132,726);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(132,726));listpt.Add(new Point(171,726));listpt.Add(new Point(209,724));listpt.Add(new Point(247,722));listpt.Add(new Point(283,719));listpt.Add(new Point(319,716));listpt.Add(new Point(353,712));listpt.Add(new Point(387,707));listpt.Add(new Point(420,701));listpt.Add(new Point(453,694));listpt.Add(new Point(484,687));listpt.Add(new Point(515,679));listpt.Add(new Point(545,671));listpt.Add(new Point(574,661));listpt.Add(new Point(602,652));listpt.Add(new Point(630,641));listpt.Add(new Point(656,630));listpt.Add(new Point(682,618));listpt.Add(new Point(707,606));listpt.Add(new Point(731,593));listpt.Add(new Point(754,579));listpt.Add(new Point(777,565));listpt.Add(new Point(799,551));listpt.Add(new Point(819,535));listpt.Add(new Point(859,504));listpt.Add(new Point(895,470));listpt.Add(new Point(927,434));listpt.Add(new Point(957,396));listpt.Add(new Point(970,377));listpt.Add(new Point(957,357));listpt.Add(new Point(927,320));listpt.Add(new Point(895,284));listpt.Add(new Point(859,250));listpt.Add(new Point(819,218));listpt.Add(new Point(799,203));listpt.Add(new Point(777,188));listpt.Add(new Point(754,174));listpt.Add(new Point(731,161));listpt.Add(new Point(707,148));listpt.Add(new Point(682,136));listpt.Add(new Point(656,124));listpt.Add(new Point(630,113));listpt.Add(new Point(602,102));listpt.Add(new Point(574,92));listpt.Add(new Point(545,83));listpt.Add(new Point(515,74));listpt.Add(new Point(484,67));listpt.Add(new Point(453,59));listpt.Add(new Point(420,53));listpt.Add(new Point(387,47));listpt.Add(new Point(353,42));listpt.Add(new Point(319,38));listpt.Add(new Point(283,34));listpt.Add(new Point(247,31));listpt.Add(new Point(209,29));listpt.Add(new Point(171,28));listpt.Add(new Point(132,28));listpt.Add(new Point(151,48));listpt.Add(new Point(169,68));listpt.Add(new Point(186,88));listpt.Add(new Point(201,109));listpt.Add(new Point(215,130));listpt.Add(new Point(240,174));listpt.Add(new Point(260,218));listpt.Add(new Point(274,263));listpt.Add(new Point(284,308));listpt.Add(new Point(289,354));listpt.Add(new Point(289,400));listpt.Add(new Point(284,446));listpt.Add(new Point(274,491));listpt.Add(new Point(260,536));listpt.Add(new Point(240,580));listpt.Add(new Point(215,623));listpt.Add(new Point(201,644));listpt.Add(new Point(186,665));listpt.Add(new Point(169,686));listpt.Add(new Point(151,706));listpt.Add(new Point(132,726));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}