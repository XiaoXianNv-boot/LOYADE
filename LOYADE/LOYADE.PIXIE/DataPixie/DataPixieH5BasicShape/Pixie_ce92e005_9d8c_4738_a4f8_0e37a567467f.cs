using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_ce92e005_9d8c_4738_a4f8_0e37a567467f : Pixie
    {
        public PIXIE_ce92e005_9d8c_4738_a4f8_0e37a567467f()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 444f; _h = 656f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(433,378);ctx.lineTo(439,401);ctx.lineTo(442,418);ctx.lineTo(443,427);ctx.lineTo(444,436);ctx.lineTo(444,444);ctx.lineTo(443,466);ctx.lineTo(440,487);ctx.lineTo(434,507);ctx.lineTo(427,526);ctx.lineTo(418,545);ctx.lineTo(408,562);ctx.lineTo(395,579);ctx.lineTo(382,594);ctx.lineTo(366,608);ctx.lineTo(350,620);ctx.lineTo(333,630);ctx.lineTo(314,639);ctx.lineTo(295,646);ctx.lineTo(274,652);ctx.lineTo(253,655);ctx.lineTo(232,656);ctx.lineTo(210,655);ctx.lineTo(189,652);ctx.lineTo(169,646);ctx.lineTo(149,639);ctx.lineTo(131,630);ctx.lineTo(113,620);ctx.lineTo(97,607);ctx.lineTo(82,593);ctx.lineTo(68,578);ctx.lineTo(56,562);ctx.lineTo(45,545);ctx.lineTo(36,526);ctx.lineTo(29,507);ctx.lineTo(23,486);ctx.lineTo(20,465);ctx.lineTo(19,444);ctx.lineTo(19,434);ctx.lineTo(21,413);ctx.lineTo(26,392);ctx.lineTo(31,373);ctx.lineTo(35,363);ctx.lineTo(133,87);ctx.lineTo(140,72);ctx.lineTo(159,48);ctx.lineTo(185,30);ctx.lineTo(216,21);ctx.lineTo(232,19);ctx.lineTo(249,20);ctx.lineTo(265,24);ctx.lineTo(280,31);ctx.lineTo(306,50);ctx.lineTo(317,62);ctx.lineTo(326,77);ctx.lineTo(333,92);ctx.lineTo(433,378);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(433,378));listpt.Add(new Point(439,401));listpt.Add(new Point(442,418));listpt.Add(new Point(443,427));listpt.Add(new Point(444,436));listpt.Add(new Point(444,444));listpt.Add(new Point(443,466));listpt.Add(new Point(440,487));listpt.Add(new Point(434,507));listpt.Add(new Point(427,526));listpt.Add(new Point(418,545));listpt.Add(new Point(408,562));listpt.Add(new Point(395,579));listpt.Add(new Point(382,594));listpt.Add(new Point(366,608));listpt.Add(new Point(350,620));listpt.Add(new Point(333,630));listpt.Add(new Point(314,639));listpt.Add(new Point(295,646));listpt.Add(new Point(274,652));listpt.Add(new Point(253,655));listpt.Add(new Point(232,656));listpt.Add(new Point(210,655));listpt.Add(new Point(189,652));listpt.Add(new Point(169,646));listpt.Add(new Point(149,639));listpt.Add(new Point(131,630));listpt.Add(new Point(113,620));listpt.Add(new Point(97,607));listpt.Add(new Point(82,593));listpt.Add(new Point(68,578));listpt.Add(new Point(56,562));listpt.Add(new Point(45,545));listpt.Add(new Point(36,526));listpt.Add(new Point(29,507));listpt.Add(new Point(23,486));listpt.Add(new Point(20,465));listpt.Add(new Point(19,444));listpt.Add(new Point(19,434));listpt.Add(new Point(21,413));listpt.Add(new Point(26,392));listpt.Add(new Point(31,373));listpt.Add(new Point(35,363));listpt.Add(new Point(133,87));listpt.Add(new Point(140,72));listpt.Add(new Point(159,48));listpt.Add(new Point(185,30));listpt.Add(new Point(216,21));listpt.Add(new Point(232,19));listpt.Add(new Point(249,20));listpt.Add(new Point(265,24));listpt.Add(new Point(280,31));listpt.Add(new Point(306,50));listpt.Add(new Point(317,62));listpt.Add(new Point(326,77));listpt.Add(new Point(333,92));listpt.Add(new Point(433,378));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}