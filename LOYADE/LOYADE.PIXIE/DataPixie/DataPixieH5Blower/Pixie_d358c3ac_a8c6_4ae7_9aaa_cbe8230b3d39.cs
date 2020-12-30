using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Blower
{
    public class PIXIE_d358c3ac_a8c6_4ae7_9aaa_cbe8230b3d39 : Pixie
    {
        public PIXIE_d358c3ac_a8c6_4ae7_9aaa_cbe8230b3d39()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 970f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(656,735);ctx.lineTo(683,713);ctx.lineTo(707,689);ctx.lineTo(730,663);ctx.lineTo(749,636);ctx.lineTo(766,606);ctx.lineTo(781,576);ctx.lineTo(793,544);ctx.lineTo(802,511);ctx.lineTo(809,478);ctx.lineTo(813,443);ctx.lineTo(813,420);ctx.lineTo(970,420);ctx.lineTo(970,28);ctx.lineTo(420,28);ctx.lineTo(381,30);ctx.lineTo(342,36);ctx.lineTo(304,45);ctx.lineTo(268,59);ctx.lineTo(234,75);ctx.lineTo(201,95);ctx.lineTo(171,118);ctx.lineTo(143,143);ctx.lineTo(118,171);ctx.lineTo(95,201);ctx.lineTo(75,234);ctx.lineTo(59,268);ctx.lineTo(45,304);ctx.lineTo(36,342);ctx.lineTo(30,381);ctx.lineTo(28,400);ctx.lineTo(28,420);ctx.lineTo(28,432);ctx.lineTo(31,466);ctx.lineTo(36,500);ctx.lineTo(45,533);ctx.lineTo(56,566);ctx.lineTo(70,597);ctx.lineTo(87,627);ctx.lineTo(105,655);ctx.lineTo(127,681);ctx.lineTo(151,706);ctx.lineTo(176,728);ctx.lineTo(185,735);ctx.lineTo(67,970);ctx.lineTo(774,970);ctx.lineTo(656,735);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(420,420,196,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(656,735));listpt.Add(new Point(683,713));listpt.Add(new Point(707,689));listpt.Add(new Point(730,663));listpt.Add(new Point(749,636));listpt.Add(new Point(766,606));listpt.Add(new Point(781,576));listpt.Add(new Point(793,544));listpt.Add(new Point(802,511));listpt.Add(new Point(809,478));listpt.Add(new Point(813,443));listpt.Add(new Point(813,420));listpt.Add(new Point(970,420));listpt.Add(new Point(970,28));listpt.Add(new Point(420,28));listpt.Add(new Point(381,30));listpt.Add(new Point(342,36));listpt.Add(new Point(304,45));listpt.Add(new Point(268,59));listpt.Add(new Point(234,75));listpt.Add(new Point(201,95));listpt.Add(new Point(171,118));listpt.Add(new Point(143,143));listpt.Add(new Point(118,171));listpt.Add(new Point(95,201));listpt.Add(new Point(75,234));listpt.Add(new Point(59,268));listpt.Add(new Point(45,304));listpt.Add(new Point(36,342));listpt.Add(new Point(30,381));listpt.Add(new Point(28,400));listpt.Add(new Point(28,420));listpt.Add(new Point(28,432));listpt.Add(new Point(31,466));listpt.Add(new Point(36,500));listpt.Add(new Point(45,533));listpt.Add(new Point(56,566));listpt.Add(new Point(70,597));listpt.Add(new Point(87,627));listpt.Add(new Point(105,655));listpt.Add(new Point(127,681));listpt.Add(new Point(151,706));listpt.Add(new Point(176,728));listpt.Add(new Point(185,735));listpt.Add(new Point(67,970));listpt.Add(new Point(774,970));listpt.Add(new Point(656,735));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 224f,224f,392f,392f);g.DrawEllipse(p, 224f,224f,392f,392f);
        }
    }
}