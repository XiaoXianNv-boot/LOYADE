using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_b227ad79_568d_41f2_9033_bf84a27eedc6 : Pixie
    {
        public PIXIE_b227ad79_568d_41f2_9033_bf84a27eedc6()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 777f; _h = 970f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(264,477);ctx.lineTo(279,500);ctx.lineTo(302,524);ctx.lineTo(329,543);ctx.lineTo(359,557);ctx.lineTo(384,564);ctx.lineTo(410,568);ctx.lineTo(437,571);ctx.lineTo(466,571);ctx.lineTo(495,569);ctx.lineTo(505,568);ctx.lineTo(505,434);ctx.lineTo(777,702);ctx.lineTo(505,970);ctx.lineTo(505,836);ctx.lineTo(471,836);ctx.lineTo(433,833);ctx.lineTo(393,829);ctx.lineTo(365,825);ctx.lineTo(336,819);ctx.lineTo(307,812);ctx.lineTo(279,802);ctx.lineTo(250,791);ctx.lineTo(222,777);ctx.lineTo(196,760);ctx.lineTo(171,740);ctx.lineTo(147,717);ctx.lineTo(126,690);ctx.lineTo(107,660);ctx.lineTo(90,626);ctx.lineTo(76,593);ctx.lineTo(64,559);ctx.lineTo(54,526);ctx.lineTo(47,492);ctx.lineTo(40,458);ctx.lineTo(36,423);ctx.lineTo(32,388);ctx.lineTo(30,352);ctx.lineTo(29,314);ctx.lineTo(28,275);ctx.lineTo(28,255);ctx.lineTo(28,235);ctx.lineTo(28,193);ctx.lineTo(28,148);ctx.lineTo(28,102);ctx.lineTo(28,53);ctx.lineTo(28,28);ctx.lineTo(34,33);ctx.lineTo(58,51);ctx.lineTo(83,63);ctx.lineTo(109,70);ctx.lineTo(143,70);ctx.lineTo(168,65);ctx.lineTo(192,53);ctx.lineTo(214,37);ctx.lineTo(224,28);ctx.lineTo(224,61);ctx.lineTo(224,93);ctx.lineTo(224,125);ctx.lineTo(223,157);ctx.lineTo(223,189);ctx.lineTo(223,220);ctx.lineTo(224,250);ctx.lineTo(225,280);ctx.lineTo(226,308);ctx.lineTo(229,348);ctx.lineTo(234,386);ctx.lineTo(242,420);ctx.lineTo(251,451);ctx.lineTo(264,477);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(264,477));listpt.Add(new Point(279,500));listpt.Add(new Point(302,524));listpt.Add(new Point(329,543));listpt.Add(new Point(359,557));listpt.Add(new Point(384,564));listpt.Add(new Point(410,568));listpt.Add(new Point(437,571));listpt.Add(new Point(466,571));listpt.Add(new Point(495,569));listpt.Add(new Point(505,568));listpt.Add(new Point(505,434));listpt.Add(new Point(777,702));listpt.Add(new Point(505,970));listpt.Add(new Point(505,836));listpt.Add(new Point(471,836));listpt.Add(new Point(433,833));listpt.Add(new Point(393,829));listpt.Add(new Point(365,825));listpt.Add(new Point(336,819));listpt.Add(new Point(307,812));listpt.Add(new Point(279,802));listpt.Add(new Point(250,791));listpt.Add(new Point(222,777));listpt.Add(new Point(196,760));listpt.Add(new Point(171,740));listpt.Add(new Point(147,717));listpt.Add(new Point(126,690));listpt.Add(new Point(107,660));listpt.Add(new Point(90,626));listpt.Add(new Point(76,593));listpt.Add(new Point(64,559));listpt.Add(new Point(54,526));listpt.Add(new Point(47,492));listpt.Add(new Point(40,458));listpt.Add(new Point(36,423));listpt.Add(new Point(32,388));listpt.Add(new Point(30,352));listpt.Add(new Point(29,314));listpt.Add(new Point(28,275));listpt.Add(new Point(28,255));listpt.Add(new Point(28,235));listpt.Add(new Point(28,193));listpt.Add(new Point(28,148));listpt.Add(new Point(28,102));listpt.Add(new Point(28,53));listpt.Add(new Point(28,28));listpt.Add(new Point(34,33));listpt.Add(new Point(58,51));listpt.Add(new Point(83,63));listpt.Add(new Point(109,70));listpt.Add(new Point(143,70));listpt.Add(new Point(168,65));listpt.Add(new Point(192,53));listpt.Add(new Point(214,37));listpt.Add(new Point(224,28));listpt.Add(new Point(224,61));listpt.Add(new Point(224,93));listpt.Add(new Point(224,125));listpt.Add(new Point(223,157));listpt.Add(new Point(223,189));listpt.Add(new Point(223,220));listpt.Add(new Point(224,250));listpt.Add(new Point(225,280));listpt.Add(new Point(226,308));listpt.Add(new Point(229,348));listpt.Add(new Point(234,386));listpt.Add(new Point(242,420));listpt.Add(new Point(251,451));listpt.Add(new Point(264,477));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}