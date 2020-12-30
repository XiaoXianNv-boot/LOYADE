using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_30f6ab2e_dbcb_41ab_abe5_8ad8278054cc : Pixie
    {
        public PIXIE_30f6ab2e_dbcb_41ab_abe5_8ad8278054cc()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 639f; _h = 639f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(377,573);ctx.lineTo(600,342);ctx.lineTo(609,330);ctx.lineTo(616,316);ctx.lineTo(623,302);ctx.lineTo(629,287);ctx.lineTo(633,272);ctx.lineTo(636,256);ctx.lineTo(638,241);ctx.lineTo(639,225);ctx.lineTo(638,204);ctx.lineTo(635,183);ctx.lineTo(630,164);ctx.lineTo(623,145);ctx.lineTo(614,126);ctx.lineTo(604,109);ctx.lineTo(592,93);ctx.lineTo(578,79);ctx.lineTo(564,65);ctx.lineTo(548,53);ctx.lineTo(531,43);ctx.lineTo(512,34);ctx.lineTo(493,27);ctx.lineTo(474,22);ctx.lineTo(453,19);ctx.lineTo(432,18);ctx.lineTo(416,19);ctx.lineTo(401,20);ctx.lineTo(385,23);ctx.lineTo(371,27);ctx.lineTo(356,33);ctx.lineTo(342,39);ctx.lineTo(328,47);ctx.lineTo(315,55);ctx.lineTo(85,280);ctx.lineTo(70,295);ctx.lineTo(57,312);ctx.lineTo(45,330);ctx.lineTo(36,349);ctx.lineTo(28,369);ctx.lineTo(23,390);ctx.lineTo(19,411);ctx.lineTo(18,432);ctx.lineTo(19,453);ctx.lineTo(22,474);ctx.lineTo(27,493);ctx.lineTo(34,512);ctx.lineTo(43,531);ctx.lineTo(53,548);ctx.lineTo(65,564);ctx.lineTo(79,578);ctx.lineTo(93,592);ctx.lineTo(109,604);ctx.lineTo(126,614);ctx.lineTo(145,623);ctx.lineTo(164,630);ctx.lineTo(183,635);ctx.lineTo(204,638);ctx.lineTo(225,639);ctx.lineTo(246,638);ctx.lineTo(267,635);ctx.lineTo(288,629);ctx.lineTo(308,622);ctx.lineTo(327,612);ctx.lineTo(345,601);ctx.lineTo(362,588);ctx.lineTo(377,573);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(377,573));listpt.Add(new Point(600,342));listpt.Add(new Point(609,330));listpt.Add(new Point(616,316));listpt.Add(new Point(623,302));listpt.Add(new Point(629,287));listpt.Add(new Point(633,272));listpt.Add(new Point(636,256));listpt.Add(new Point(638,241));listpt.Add(new Point(639,225));listpt.Add(new Point(638,204));listpt.Add(new Point(635,183));listpt.Add(new Point(630,164));listpt.Add(new Point(623,145));listpt.Add(new Point(614,126));listpt.Add(new Point(604,109));listpt.Add(new Point(592,93));listpt.Add(new Point(578,79));listpt.Add(new Point(564,65));listpt.Add(new Point(548,53));listpt.Add(new Point(531,43));listpt.Add(new Point(512,34));listpt.Add(new Point(493,27));listpt.Add(new Point(474,22));listpt.Add(new Point(453,19));listpt.Add(new Point(432,18));listpt.Add(new Point(416,19));listpt.Add(new Point(401,20));listpt.Add(new Point(385,23));listpt.Add(new Point(371,27));listpt.Add(new Point(356,33));listpt.Add(new Point(342,39));listpt.Add(new Point(328,47));listpt.Add(new Point(315,55));listpt.Add(new Point(85,280));listpt.Add(new Point(70,295));listpt.Add(new Point(57,312));listpt.Add(new Point(45,330));listpt.Add(new Point(36,349));listpt.Add(new Point(28,369));listpt.Add(new Point(23,390));listpt.Add(new Point(19,411));listpt.Add(new Point(18,432));listpt.Add(new Point(19,453));listpt.Add(new Point(22,474));listpt.Add(new Point(27,493));listpt.Add(new Point(34,512));listpt.Add(new Point(43,531));listpt.Add(new Point(53,548));listpt.Add(new Point(65,564));listpt.Add(new Point(79,578));listpt.Add(new Point(93,592));listpt.Add(new Point(109,604));listpt.Add(new Point(126,614));listpt.Add(new Point(145,623));listpt.Add(new Point(164,630));listpt.Add(new Point(183,635));listpt.Add(new Point(204,638));listpt.Add(new Point(225,639));listpt.Add(new Point(246,638));listpt.Add(new Point(267,635));listpt.Add(new Point(288,629));listpt.Add(new Point(308,622));listpt.Add(new Point(327,612));listpt.Add(new Point(345,601));listpt.Add(new Point(362,588));listpt.Add(new Point(377,573));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}