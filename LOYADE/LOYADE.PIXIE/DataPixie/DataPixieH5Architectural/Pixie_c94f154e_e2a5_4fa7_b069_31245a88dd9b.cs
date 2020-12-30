using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Architectural
{
    public class PIXIE_c94f154e_e2a5_4fa7_b069_31245a88dd9b : Pixie
    {
        public PIXIE_c94f154e_e2a5_4fa7_b069_31245a88dd9b()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#98b2e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 971f; _h = 688f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#98b2e5'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(971,90);ctx.lineTo(971,216);ctx.lineTo(876,216);ctx.lineTo(876,143);ctx.lineTo(848,133);ctx.lineTo(818,126);ctx.lineTo(788,122);ctx.lineTo(750,124);ctx.lineTo(719,131);ctx.lineTo(689,143);ctx.lineTo(660,158);ctx.lineTo(632,177);ctx.lineTo(606,200);ctx.lineTo(582,227);ctx.lineTo(560,256);ctx.lineTo(539,289);ctx.lineTo(521,324);ctx.lineTo(505,361);ctx.lineTo(492,401);ctx.lineTo(481,443);ctx.lineTo(473,487);ctx.lineTo(469,532);ctx.lineTo(467,578);ctx.lineTo(467,593);ctx.lineTo(593,593);ctx.lineTo(593,499);ctx.lineTo(720,499);ctx.lineTo(720,593);ctx.lineTo(782,593);ctx.lineTo(782,688);ctx.lineTo(28,688);ctx.lineTo(28,593);ctx.lineTo(90,593);ctx.lineTo(90,499);ctx.lineTo(216,499);ctx.lineTo(216,593);ctx.lineTo(343,593);ctx.lineTo(343,564);ctx.lineTo(345,536);ctx.lineTo(348,508);ctx.lineTo(352,480);ctx.lineTo(356,452);ctx.lineTo(362,426);ctx.lineTo(369,399);ctx.lineTo(377,374);ctx.lineTo(386,349);ctx.lineTo(396,324);ctx.lineTo(406,301);ctx.lineTo(418,278);ctx.lineTo(430,255);ctx.lineTo(443,234);ctx.lineTo(471,194);ctx.lineTo(502,157);ctx.lineTo(536,125);ctx.lineTo(572,96);ctx.lineTo(611,72);ctx.lineTo(651,53);ctx.lineTo(693,39);ctx.lineTo(737,31);ctx.lineTo(759,28);ctx.lineTo(782,28);ctx.lineTo(794,28);ctx.lineTo(831,33);ctx.lineTo(867,43);ctx.lineTo(891,51);ctx.lineTo(915,61);ctx.lineTo(938,72);ctx.lineTo(960,84);ctx.lineTo(971,90);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(971,90));listpt.Add(new Point(971,216));listpt.Add(new Point(876,216));listpt.Add(new Point(876,143));listpt.Add(new Point(848,133));listpt.Add(new Point(818,126));listpt.Add(new Point(788,122));listpt.Add(new Point(750,124));listpt.Add(new Point(719,131));listpt.Add(new Point(689,143));listpt.Add(new Point(660,158));listpt.Add(new Point(632,177));listpt.Add(new Point(606,200));listpt.Add(new Point(582,227));listpt.Add(new Point(560,256));listpt.Add(new Point(539,289));listpt.Add(new Point(521,324));listpt.Add(new Point(505,361));listpt.Add(new Point(492,401));listpt.Add(new Point(481,443));listpt.Add(new Point(473,487));listpt.Add(new Point(469,532));listpt.Add(new Point(467,578));listpt.Add(new Point(467,593));listpt.Add(new Point(593,593));listpt.Add(new Point(593,499));listpt.Add(new Point(720,499));listpt.Add(new Point(720,593));listpt.Add(new Point(782,593));listpt.Add(new Point(782,688));listpt.Add(new Point(28,688));listpt.Add(new Point(28,593));listpt.Add(new Point(90,593));listpt.Add(new Point(90,499));listpt.Add(new Point(216,499));listpt.Add(new Point(216,593));listpt.Add(new Point(343,593));listpt.Add(new Point(343,564));listpt.Add(new Point(345,536));listpt.Add(new Point(348,508));listpt.Add(new Point(352,480));listpt.Add(new Point(356,452));listpt.Add(new Point(362,426));listpt.Add(new Point(369,399));listpt.Add(new Point(377,374));listpt.Add(new Point(386,349));listpt.Add(new Point(396,324));listpt.Add(new Point(406,301));listpt.Add(new Point(418,278));listpt.Add(new Point(430,255));listpt.Add(new Point(443,234));listpt.Add(new Point(471,194));listpt.Add(new Point(502,157));listpt.Add(new Point(536,125));listpt.Add(new Point(572,96));listpt.Add(new Point(611,72));listpt.Add(new Point(651,53));listpt.Add(new Point(693,39));listpt.Add(new Point(737,31));listpt.Add(new Point(759,28));listpt.Add(new Point(782,28));listpt.Add(new Point(794,28));listpt.Add(new Point(831,33));listpt.Add(new Point(867,43));listpt.Add(new Point(891,51));listpt.Add(new Point(915,61));listpt.Add(new Point(938,72));listpt.Add(new Point(960,84));listpt.Add(new Point(971,90));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}