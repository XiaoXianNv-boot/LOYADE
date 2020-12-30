using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEControlEquipment
{
    public class PIXIE_f83d3245_bed3_4700_8da2_6834107f6c65 : Pixie
    {
        public PIXIE_f83d3245_bed3_4700_8da2_6834107f6c65()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 892f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(852,303);ctx.lineTo(862,330);ctx.lineTo(872,360);ctx.lineTo(881,390);ctx.lineTo(888,421);ctx.lineTo(891,450);ctx.lineTo(891,482);ctx.lineTo(887,525);ctx.lineTo(878,567);ctx.lineTo(865,608);ctx.lineTo(849,647);ctx.lineTo(829,683);ctx.lineTo(806,718);ctx.lineTo(779,750);ctx.lineTo(750,779);ctx.lineTo(718,806);ctx.lineTo(683,829);ctx.lineTo(647,849);ctx.lineTo(608,865);ctx.lineTo(567,878);ctx.lineTo(525,887);ctx.lineTo(482,891);ctx.lineTo(460,892);ctx.lineTo(437,891);ctx.lineTo(394,887);ctx.lineTo(352,878);ctx.lineTo(311,865);ctx.lineTo(273,849);ctx.lineTo(236,829);ctx.lineTo(201,806);ctx.lineTo(169,779);ctx.lineTo(140,750);ctx.lineTo(114,718);ctx.lineTo(91,683);ctx.lineTo(70,647);ctx.lineTo(54,608);ctx.lineTo(41,567);ctx.lineTo(33,525);ctx.lineTo(28,482);ctx.lineTo(28,460);ctx.lineTo(28,437);ctx.lineTo(33,394);ctx.lineTo(41,352);ctx.lineTo(54,311);ctx.lineTo(70,273);ctx.lineTo(91,236);ctx.lineTo(114,201);ctx.lineTo(140,169);ctx.lineTo(169,140);ctx.lineTo(201,114);ctx.lineTo(236,91);ctx.lineTo(273,70);ctx.lineTo(311,54);ctx.lineTo(352,41);ctx.lineTo(394,33);ctx.lineTo(437,28);ctx.lineTo(460,28);ctx.lineTo(970,28);ctx.lineTo(970,303);ctx.lineTo(852,303);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(852,303));listpt.Add(new Point(862,330));listpt.Add(new Point(872,360));listpt.Add(new Point(881,390));listpt.Add(new Point(888,421));listpt.Add(new Point(891,450));listpt.Add(new Point(891,482));listpt.Add(new Point(887,525));listpt.Add(new Point(878,567));listpt.Add(new Point(865,608));listpt.Add(new Point(849,647));listpt.Add(new Point(829,683));listpt.Add(new Point(806,718));listpt.Add(new Point(779,750));listpt.Add(new Point(750,779));listpt.Add(new Point(718,806));listpt.Add(new Point(683,829));listpt.Add(new Point(647,849));listpt.Add(new Point(608,865));listpt.Add(new Point(567,878));listpt.Add(new Point(525,887));listpt.Add(new Point(482,891));listpt.Add(new Point(460,892));listpt.Add(new Point(437,891));listpt.Add(new Point(394,887));listpt.Add(new Point(352,878));listpt.Add(new Point(311,865));listpt.Add(new Point(273,849));listpt.Add(new Point(236,829));listpt.Add(new Point(201,806));listpt.Add(new Point(169,779));listpt.Add(new Point(140,750));listpt.Add(new Point(114,718));listpt.Add(new Point(91,683));listpt.Add(new Point(70,647));listpt.Add(new Point(54,608));listpt.Add(new Point(41,567));listpt.Add(new Point(33,525));listpt.Add(new Point(28,482));listpt.Add(new Point(28,460));listpt.Add(new Point(28,437));listpt.Add(new Point(33,394));listpt.Add(new Point(41,352));listpt.Add(new Point(54,311));listpt.Add(new Point(70,273));listpt.Add(new Point(91,236));listpt.Add(new Point(114,201));listpt.Add(new Point(140,169));listpt.Add(new Point(169,140));listpt.Add(new Point(201,114));listpt.Add(new Point(236,91));listpt.Add(new Point(273,70));listpt.Add(new Point(311,54));listpt.Add(new Point(352,41));listpt.Add(new Point(394,33));listpt.Add(new Point(437,28));listpt.Add(new Point(460,28));listpt.Add(new Point(970,28));listpt.Add(new Point(970,303));listpt.Add(new Point(852,303));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}