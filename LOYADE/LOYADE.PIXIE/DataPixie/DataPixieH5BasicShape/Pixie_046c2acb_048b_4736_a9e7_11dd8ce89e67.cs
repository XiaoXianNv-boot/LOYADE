using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_046c2acb_048b_4736_a9e7_11dd8ce89e67 : Pixie
    {
        public PIXIE_046c2acb_048b_4736_a9e7_11dd8ce89e67()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 553f; _h = 553f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(553,503);ctx.lineTo(284,16);ctx.lineTo(16,503);ctx.lineTo(17,508);ctx.lineTo(28,518);ctx.lineTo(49,527);ctx.lineTo(62,531);ctx.lineTo(78,535);ctx.lineTo(95,538);ctx.lineTo(114,542);ctx.lineTo(135,545);ctx.lineTo(157,547);ctx.lineTo(180,549);ctx.lineTo(205,551);ctx.lineTo(230,552);ctx.lineTo(257,553);ctx.lineTo(311,553);ctx.lineTo(338,552);ctx.lineTo(364,551);ctx.lineTo(388,549);ctx.lineTo(412,547);ctx.lineTo(434,545);ctx.lineTo(455,542);ctx.lineTo(474,538);ctx.lineTo(491,535);ctx.lineTo(507,531);ctx.lineTo(532,523);ctx.lineTo(548,513);ctx.lineTo(552,508);ctx.lineTo(553,503);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(553,503));listpt.Add(new Point(284,16));listpt.Add(new Point(16,503));listpt.Add(new Point(17,508));listpt.Add(new Point(28,518));listpt.Add(new Point(49,527));listpt.Add(new Point(62,531));listpt.Add(new Point(78,535));listpt.Add(new Point(95,538));listpt.Add(new Point(114,542));listpt.Add(new Point(135,545));listpt.Add(new Point(157,547));listpt.Add(new Point(180,549));listpt.Add(new Point(205,551));listpt.Add(new Point(230,552));listpt.Add(new Point(257,553));listpt.Add(new Point(311,553));listpt.Add(new Point(338,552));listpt.Add(new Point(364,551));listpt.Add(new Point(388,549));listpt.Add(new Point(412,547));listpt.Add(new Point(434,545));listpt.Add(new Point(455,542));listpt.Add(new Point(474,538));listpt.Add(new Point(491,535));listpt.Add(new Point(507,531));listpt.Add(new Point(532,523));listpt.Add(new Point(548,513));listpt.Add(new Point(552,508));listpt.Add(new Point(553,503));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}