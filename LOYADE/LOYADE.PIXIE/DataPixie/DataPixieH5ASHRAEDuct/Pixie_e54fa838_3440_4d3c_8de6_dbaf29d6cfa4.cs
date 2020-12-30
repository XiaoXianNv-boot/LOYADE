using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEDuct
{
    public class PIXIE_e54fa838_3440_4d3c_8de6_dbaf29d6cfa4 : Pixie
    {
        public PIXIE_e54fa838_3440_4d3c_8de6_dbaf29d6cfa4()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 970f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(970,28);ctx.lineTo(969,76);ctx.lineTo(965,124);ctx.lineTo(959,171);ctx.lineTo(951,217);ctx.lineTo(940,263);ctx.lineTo(928,307);ctx.lineTo(913,351);ctx.lineTo(896,394);ctx.lineTo(877,436);ctx.lineTo(856,476);ctx.lineTo(834,516);ctx.lineTo(809,554);ctx.lineTo(783,591);ctx.lineTo(754,627);ctx.lineTo(725,661);ctx.lineTo(694,693);ctx.lineTo(661,725);ctx.lineTo(627,754);ctx.lineTo(591,783);ctx.lineTo(554,809);ctx.lineTo(516,834);ctx.lineTo(476,856);ctx.lineTo(436,877);ctx.lineTo(394,896);ctx.lineTo(351,913);ctx.lineTo(307,928);ctx.lineTo(263,940);ctx.lineTo(217,951);ctx.lineTo(171,959);ctx.lineTo(124,965);ctx.lineTo(76,969);ctx.lineTo(28,970);ctx.lineTo(28,578);ctx.lineTo(56,577);ctx.lineTo(84,575);ctx.lineTo(111,571);ctx.lineTo(138,566);ctx.lineTo(165,560);ctx.lineTo(191,553);ctx.lineTo(217,544);ctx.lineTo(241,534);ctx.lineTo(266,523);ctx.lineTo(289,511);ctx.lineTo(312,498);ctx.lineTo(335,483);ctx.lineTo(356,468);ctx.lineTo(377,452);ctx.lineTo(397,435);ctx.lineTo(416,416);ctx.lineTo(435,397);ctx.lineTo(452,377);ctx.lineTo(468,356);ctx.lineTo(483,335);ctx.lineTo(498,312);ctx.lineTo(511,289);ctx.lineTo(523,266);ctx.lineTo(534,241);ctx.lineTo(544,217);ctx.lineTo(553,191);ctx.lineTo(560,165);ctx.lineTo(566,138);ctx.lineTo(571,111);ctx.lineTo(575,84);ctx.lineTo(577,56);ctx.lineTo(578,28);ctx.lineTo(970,28);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(970,28));listpt.Add(new Point(969,76));listpt.Add(new Point(965,124));listpt.Add(new Point(959,171));listpt.Add(new Point(951,217));listpt.Add(new Point(940,263));listpt.Add(new Point(928,307));listpt.Add(new Point(913,351));listpt.Add(new Point(896,394));listpt.Add(new Point(877,436));listpt.Add(new Point(856,476));listpt.Add(new Point(834,516));listpt.Add(new Point(809,554));listpt.Add(new Point(783,591));listpt.Add(new Point(754,627));listpt.Add(new Point(725,661));listpt.Add(new Point(694,693));listpt.Add(new Point(661,725));listpt.Add(new Point(627,754));listpt.Add(new Point(591,783));listpt.Add(new Point(554,809));listpt.Add(new Point(516,834));listpt.Add(new Point(476,856));listpt.Add(new Point(436,877));listpt.Add(new Point(394,896));listpt.Add(new Point(351,913));listpt.Add(new Point(307,928));listpt.Add(new Point(263,940));listpt.Add(new Point(217,951));listpt.Add(new Point(171,959));listpt.Add(new Point(124,965));listpt.Add(new Point(76,969));listpt.Add(new Point(28,970));listpt.Add(new Point(28,578));listpt.Add(new Point(56,577));listpt.Add(new Point(84,575));listpt.Add(new Point(111,571));listpt.Add(new Point(138,566));listpt.Add(new Point(165,560));listpt.Add(new Point(191,553));listpt.Add(new Point(217,544));listpt.Add(new Point(241,534));listpt.Add(new Point(266,523));listpt.Add(new Point(289,511));listpt.Add(new Point(312,498));listpt.Add(new Point(335,483));listpt.Add(new Point(356,468));listpt.Add(new Point(377,452));listpt.Add(new Point(397,435));listpt.Add(new Point(416,416));listpt.Add(new Point(435,397));listpt.Add(new Point(452,377));listpt.Add(new Point(468,356));listpt.Add(new Point(483,335));listpt.Add(new Point(498,312));listpt.Add(new Point(511,289));listpt.Add(new Point(523,266));listpt.Add(new Point(534,241));listpt.Add(new Point(544,217));listpt.Add(new Point(553,191));listpt.Add(new Point(560,165));listpt.Add(new Point(566,138));listpt.Add(new Point(571,111));listpt.Add(new Point(575,84));listpt.Add(new Point(577,56));listpt.Add(new Point(578,28));listpt.Add(new Point(970,28));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}