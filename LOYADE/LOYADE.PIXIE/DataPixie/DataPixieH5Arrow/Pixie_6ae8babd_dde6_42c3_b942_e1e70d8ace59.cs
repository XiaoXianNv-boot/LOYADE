using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_6ae8babd_dde6_42c3_b942_e1e70d8ace59 : Pixie
    {
        public PIXIE_6ae8babd_dde6_42c3_b942_e1e70d8ace59()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 530f; _h = 971f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(530,459);ctx.lineTo(371,367);ctx.lineTo(348,401);ctx.lineTo(327,433);ctx.lineTo(307,466);ctx.lineTo(288,498);ctx.lineTo(271,530);ctx.lineTo(255,562);ctx.lineTo(241,595);ctx.lineTo(227,630);ctx.lineTo(216,665);ctx.lineTo(205,702);ctx.lineTo(197,740);ctx.lineTo(190,781);ctx.lineTo(184,824);ctx.lineTo(182,870);ctx.lineTo(180,918);ctx.lineTo(180,971);ctx.lineTo(29,971);ctx.lineTo(28,944);ctx.lineTo(27,917);ctx.lineTo(28,892);ctx.lineTo(30,841);ctx.lineTo(35,792);ctx.lineTo(42,744);ctx.lineTo(51,697);ctx.lineTo(62,652);ctx.lineTo(75,609);ctx.lineTo(90,566);ctx.lineTo(105,525);ctx.lineTo(123,484);ctx.lineTo(142,445);ctx.lineTo(161,407);ctx.lineTo(182,369);ctx.lineTo(203,333);ctx.lineTo(224,297);ctx.lineTo(235,280);ctx.lineTo(88,196);ctx.lineTo(481,27);ctx.lineTo(530,459);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(530,459));listpt.Add(new Point(371,367));listpt.Add(new Point(348,401));listpt.Add(new Point(327,433));listpt.Add(new Point(307,466));listpt.Add(new Point(288,498));listpt.Add(new Point(271,530));listpt.Add(new Point(255,562));listpt.Add(new Point(241,595));listpt.Add(new Point(227,630));listpt.Add(new Point(216,665));listpt.Add(new Point(205,702));listpt.Add(new Point(197,740));listpt.Add(new Point(190,781));listpt.Add(new Point(184,824));listpt.Add(new Point(182,870));listpt.Add(new Point(180,918));listpt.Add(new Point(180,971));listpt.Add(new Point(29,971));listpt.Add(new Point(28,944));listpt.Add(new Point(27,917));listpt.Add(new Point(28,892));listpt.Add(new Point(30,841));listpt.Add(new Point(35,792));listpt.Add(new Point(42,744));listpt.Add(new Point(51,697));listpt.Add(new Point(62,652));listpt.Add(new Point(75,609));listpt.Add(new Point(90,566));listpt.Add(new Point(105,525));listpt.Add(new Point(123,484));listpt.Add(new Point(142,445));listpt.Add(new Point(161,407));listpt.Add(new Point(182,369));listpt.Add(new Point(203,333));listpt.Add(new Point(224,297));listpt.Add(new Point(235,280));listpt.Add(new Point(88,196));listpt.Add(new Point(481,27));listpt.Add(new Point(530,459));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}