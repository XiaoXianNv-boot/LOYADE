using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_3c486d8f_53a5_44ec_a434_3c1bdd446b65 : Pixie
    {
        public PIXIE_3c486d8f_53a5_44ec_a434_3c1bdd446b65()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 393f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(561,28);ctx.lineTo(522,29);ctx.lineTo(486,32);ctx.lineTo(454,38);ctx.lineTo(424,45);ctx.lineTo(398,53);ctx.lineTo(374,62);ctx.lineTo(343,78);ctx.lineTo(318,93);ctx.lineTo(294,112);ctx.lineTo(274,133);ctx.lineTo(270,138);ctx.lineTo(270,138);ctx.lineTo(28,138);ctx.lineTo(50,117);ctx.lineTo(75,99);ctx.lineTo(100,84);ctx.lineTo(131,68);ctx.lineTo(155,59);ctx.lineTo(181,50);ctx.lineTo(211,42);ctx.lineTo(243,35);ctx.lineTo(279,31);ctx.lineTo(317,28);ctx.lineTo(337,28);ctx.lineTo(561,28);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(337,28);ctx.lineTo(376,28);ctx.lineTo(412,30);ctx.lineTo(446,34);ctx.lineTo(476,38);ctx.lineTo(505,43);ctx.lineTo(531,50);ctx.lineTo(566,60);ctx.lineTo(595,72);ctx.lineTo(621,85);ctx.lineTo(647,104);ctx.lineTo(667,122);ctx.lineTo(683,144);ctx.lineTo(692,169);ctx.lineTo(697,196);ctx.lineTo(698,228);ctx.lineTo(696,256);ctx.lineTo(695,267);ctx.lineTo(590,267);ctx.lineTo(776,393);ctx.lineTo(970,267);ctx.lineTo(875,267);ctx.lineTo(873,235);ctx.lineTo(870,208);ctx.lineTo(865,179);ctx.lineTo(859,153);ctx.lineTo(845,128);ctx.lineTo(826,108);ctx.lineTo(807,91);ctx.lineTo(779,73);ctx.lineTo(752,60);ctx.lineTo(720,48);ctx.lineTo(695,41);ctx.lineTo(666,36);ctx.lineTo(635,31);ctx.lineTo(600,29);ctx.lineTo(581,28);ctx.lineTo(561,28);ctx.lineTo(337,28);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(561,28));listpt.Add(new Point(522,29));listpt.Add(new Point(486,32));listpt.Add(new Point(454,38));listpt.Add(new Point(424,45));listpt.Add(new Point(398,53));listpt.Add(new Point(374,62));listpt.Add(new Point(343,78));listpt.Add(new Point(318,93));listpt.Add(new Point(294,112));listpt.Add(new Point(274,133));listpt.Add(new Point(270,138));listpt.Add(new Point(270,138));listpt.Add(new Point(28,138));listpt.Add(new Point(50,117));listpt.Add(new Point(75,99));listpt.Add(new Point(100,84));listpt.Add(new Point(131,68));listpt.Add(new Point(155,59));listpt.Add(new Point(181,50));listpt.Add(new Point(211,42));listpt.Add(new Point(243,35));listpt.Add(new Point(279,31));listpt.Add(new Point(317,28));listpt.Add(new Point(337,28));listpt.Add(new Point(561,28));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(337,28));listpt.Add(new Point(376,28));listpt.Add(new Point(412,30));listpt.Add(new Point(446,34));listpt.Add(new Point(476,38));listpt.Add(new Point(505,43));listpt.Add(new Point(531,50));listpt.Add(new Point(566,60));listpt.Add(new Point(595,72));listpt.Add(new Point(621,85));listpt.Add(new Point(647,104));listpt.Add(new Point(667,122));listpt.Add(new Point(683,144));listpt.Add(new Point(692,169));listpt.Add(new Point(697,196));listpt.Add(new Point(698,228));listpt.Add(new Point(696,256));listpt.Add(new Point(695,267));listpt.Add(new Point(590,267));listpt.Add(new Point(776,393));listpt.Add(new Point(970,267));listpt.Add(new Point(875,267));listpt.Add(new Point(873,235));listpt.Add(new Point(870,208));listpt.Add(new Point(865,179));listpt.Add(new Point(859,153));listpt.Add(new Point(845,128));listpt.Add(new Point(826,108));listpt.Add(new Point(807,91));listpt.Add(new Point(779,73));listpt.Add(new Point(752,60));listpt.Add(new Point(720,48));listpt.Add(new Point(695,41));listpt.Add(new Point(666,36));listpt.Add(new Point(635,31));listpt.Add(new Point(600,29));listpt.Add(new Point(581,28));listpt.Add(new Point(561,28));listpt.Add(new Point(337,28));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}