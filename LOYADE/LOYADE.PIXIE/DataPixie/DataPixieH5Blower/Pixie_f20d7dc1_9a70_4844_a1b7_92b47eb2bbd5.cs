using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Blower
{
    public class PIXIE_f20d7dc1_9a70_4844_a1b7_92b47eb2bbd5 : Pixie
    {
        public PIXIE_f20d7dc1_9a70_4844_a1b7_92b47eb2bbd5()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f2f2f2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f2f2f2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 833f; _h = 970f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#ccc'; arrFillColor[1] = '#f2f2f2'; arrFillColor[2] = '#f2f2f2'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(265,143);ctx.lineTo(293,131);ctx.lineTo(322,121);ctx.lineTo(352,114);ctx.lineTo(381,109);ctx.lineTo(410,107);ctx.lineTo(438,107);ctx.lineTo(474,111);ctx.lineTo(508,118);ctx.lineTo(542,128);ctx.lineTo(573,142);ctx.lineTo(604,158);ctx.lineTo(632,177);ctx.lineTo(658,199);ctx.lineTo(682,223);ctx.lineTo(704,249);ctx.lineTo(723,277);ctx.lineTo(739,307);ctx.lineTo(753,338);ctx.lineTo(763,371);ctx.lineTo(770,406);ctx.lineTo(774,441);ctx.lineTo(774,459);ctx.lineTo(774,478);ctx.lineTo(770,513);ctx.lineTo(763,547);ctx.lineTo(753,581);ctx.lineTo(739,612);ctx.lineTo(723,643);ctx.lineTo(704,671);ctx.lineTo(682,697);ctx.lineTo(658,721);ctx.lineTo(632,743);ctx.lineTo(604,762);ctx.lineTo(573,779);ctx.lineTo(542,792);ctx.lineTo(508,802);ctx.lineTo(474,810);ctx.lineTo(438,813);ctx.lineTo(420,814);ctx.lineTo(402,813);ctx.lineTo(366,810);ctx.lineTo(332,802);ctx.lineTo(299,792);ctx.lineTo(267,779);ctx.lineTo(237,762);ctx.lineTo(209,743);ctx.lineTo(183,721);ctx.lineTo(159,697);ctx.lineTo(137,671);ctx.lineTo(119,643);ctx.lineTo(102,612);ctx.lineTo(89,581);ctx.lineTo(78,547);ctx.lineTo(71,513);ctx.lineTo(68,478);ctx.lineTo(67,459);ctx.lineTo(67,67);ctx.lineTo(263,67);ctx.lineTo(265,143);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(67,67);ctx.lineTo(28,28);ctx.lineTo(303,28);ctx.lineTo(263,67);ctx.lineTo(67,67);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(793,931);ctx.lineTo(833,970);ctx.lineTo(67,970);ctx.lineTo(107,931);ctx.lineTo(793,931);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(265,143));listpt.Add(new Point(293,131));listpt.Add(new Point(322,121));listpt.Add(new Point(352,114));listpt.Add(new Point(381,109));listpt.Add(new Point(410,107));listpt.Add(new Point(438,107));listpt.Add(new Point(474,111));listpt.Add(new Point(508,118));listpt.Add(new Point(542,128));listpt.Add(new Point(573,142));listpt.Add(new Point(604,158));listpt.Add(new Point(632,177));listpt.Add(new Point(658,199));listpt.Add(new Point(682,223));listpt.Add(new Point(704,249));listpt.Add(new Point(723,277));listpt.Add(new Point(739,307));listpt.Add(new Point(753,338));listpt.Add(new Point(763,371));listpt.Add(new Point(770,406));listpt.Add(new Point(774,441));listpt.Add(new Point(774,459));listpt.Add(new Point(774,478));listpt.Add(new Point(770,513));listpt.Add(new Point(763,547));listpt.Add(new Point(753,581));listpt.Add(new Point(739,612));listpt.Add(new Point(723,643));listpt.Add(new Point(704,671));listpt.Add(new Point(682,697));listpt.Add(new Point(658,721));listpt.Add(new Point(632,743));listpt.Add(new Point(604,762));listpt.Add(new Point(573,779));listpt.Add(new Point(542,792));listpt.Add(new Point(508,802));listpt.Add(new Point(474,810));listpt.Add(new Point(438,813));listpt.Add(new Point(420,814));listpt.Add(new Point(402,813));listpt.Add(new Point(366,810));listpt.Add(new Point(332,802));listpt.Add(new Point(299,792));listpt.Add(new Point(267,779));listpt.Add(new Point(237,762));listpt.Add(new Point(209,743));listpt.Add(new Point(183,721));listpt.Add(new Point(159,697));listpt.Add(new Point(137,671));listpt.Add(new Point(119,643));listpt.Add(new Point(102,612));listpt.Add(new Point(89,581));listpt.Add(new Point(78,547));listpt.Add(new Point(71,513));listpt.Add(new Point(68,478));listpt.Add(new Point(67,459));listpt.Add(new Point(67,67));listpt.Add(new Point(263,67));listpt.Add(new Point(265,143));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(67,67));listpt.Add(new Point(28,28));listpt.Add(new Point(303,28));listpt.Add(new Point(263,67));listpt.Add(new Point(67,67));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(793,931));listpt.Add(new Point(833,970));listpt.Add(new Point(67,970));listpt.Add(new Point(107,931));listpt.Add(new Point(793,931));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}