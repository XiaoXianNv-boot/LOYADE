using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEControlEquipment
{
    public class PIXIE_ddb2e17a_ad6a_483c_9234_2cc0d626ade1 : Pixie
    {
        public PIXIE_ddb2e17a_ad6a_483c_9234_2cc0d626ade1()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 866f; _h = 796f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(761,272);ctx.lineTo(769,296);ctx.lineTo(778,323);ctx.lineTo(786,350);ctx.lineTo(792,377);ctx.lineTo(796,412);ctx.lineTo(794,451);ctx.lineTo(788,489);ctx.lineTo(779,526);ctx.lineTo(766,561);ctx.lineTo(749,595);ctx.lineTo(730,626);ctx.lineTo(708,656);ctx.lineTo(683,683);ctx.lineTo(656,708);ctx.lineTo(626,730);ctx.lineTo(595,750);ctx.lineTo(561,766);ctx.lineTo(526,779);ctx.lineTo(489,788);ctx.lineTo(451,794);ctx.lineTo(432,796);ctx.lineTo(412,796);ctx.lineTo(392,796);ctx.lineTo(354,791);ctx.lineTo(316,784);ctx.lineTo(280,773);ctx.lineTo(245,758);ctx.lineTo(213,740);ctx.lineTo(182,719);ctx.lineTo(154,696);ctx.lineTo(128,670);ctx.lineTo(104,641);ctx.lineTo(83,611);ctx.lineTo(66,578);ctx.lineTo(51,544);ctx.lineTo(40,508);ctx.lineTo(32,470);ctx.lineTo(28,432);ctx.lineTo(28,412);ctx.lineTo(28,392);ctx.lineTo(32,354);ctx.lineTo(40,316);ctx.lineTo(51,280);ctx.lineTo(66,245);ctx.lineTo(83,213);ctx.lineTo(104,182);ctx.lineTo(128,154);ctx.lineTo(154,128);ctx.lineTo(182,104);ctx.lineTo(213,83);ctx.lineTo(245,66);ctx.lineTo(280,51);ctx.lineTo(316,40);ctx.lineTo(354,32);ctx.lineTo(392,28);ctx.lineTo(412,28);ctx.lineTo(866,28);ctx.lineTo(866,272);ctx.lineTo(761,272);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(761,272));listpt.Add(new Point(769,296));listpt.Add(new Point(778,323));listpt.Add(new Point(786,350));listpt.Add(new Point(792,377));listpt.Add(new Point(796,412));listpt.Add(new Point(794,451));listpt.Add(new Point(788,489));listpt.Add(new Point(779,526));listpt.Add(new Point(766,561));listpt.Add(new Point(749,595));listpt.Add(new Point(730,626));listpt.Add(new Point(708,656));listpt.Add(new Point(683,683));listpt.Add(new Point(656,708));listpt.Add(new Point(626,730));listpt.Add(new Point(595,750));listpt.Add(new Point(561,766));listpt.Add(new Point(526,779));listpt.Add(new Point(489,788));listpt.Add(new Point(451,794));listpt.Add(new Point(432,796));listpt.Add(new Point(412,796));listpt.Add(new Point(392,796));listpt.Add(new Point(354,791));listpt.Add(new Point(316,784));listpt.Add(new Point(280,773));listpt.Add(new Point(245,758));listpt.Add(new Point(213,740));listpt.Add(new Point(182,719));listpt.Add(new Point(154,696));listpt.Add(new Point(128,670));listpt.Add(new Point(104,641));listpt.Add(new Point(83,611));listpt.Add(new Point(66,578));listpt.Add(new Point(51,544));listpt.Add(new Point(40,508));listpt.Add(new Point(32,470));listpt.Add(new Point(28,432));listpt.Add(new Point(28,412));listpt.Add(new Point(28,392));listpt.Add(new Point(32,354));listpt.Add(new Point(40,316));listpt.Add(new Point(51,280));listpt.Add(new Point(66,245));listpt.Add(new Point(83,213));listpt.Add(new Point(104,182));listpt.Add(new Point(128,154));listpt.Add(new Point(154,128));listpt.Add(new Point(182,104));listpt.Add(new Point(213,83));listpt.Add(new Point(245,66));listpt.Add(new Point(280,51));listpt.Add(new Point(316,40));listpt.Add(new Point(354,32));listpt.Add(new Point(392,28));listpt.Add(new Point(412,28));listpt.Add(new Point(866,28));listpt.Add(new Point(866,272));listpt.Add(new Point(761,272));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}