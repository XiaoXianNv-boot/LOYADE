using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_7e865b52_9541_4550_b1e7_6020da1046f6 : Pixie
    {
        public PIXIE_7e865b52_9541_4550_b1e7_6020da1046f6()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 553f; _h = 553f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(553,519);ctx.lineTo(553,49);ctx.lineTo(547,42);ctx.lineTo(530,36);ctx.lineTo(505,31);ctx.lineTo(489,28);ctx.lineTo(472,26);ctx.lineTo(453,24);ctx.lineTo(432,22);ctx.lineTo(410,20);ctx.lineTo(387,19);ctx.lineTo(363,18);ctx.lineTo(337,17);ctx.lineTo(311,16);ctx.lineTo(284,16);ctx.lineTo(257,16);ctx.lineTo(231,17);ctx.lineTo(206,18);ctx.lineTo(181,19);ctx.lineTo(158,20);ctx.lineTo(136,22);ctx.lineTo(115,24);ctx.lineTo(96,26);ctx.lineTo(79,28);ctx.lineTo(63,31);ctx.lineTo(38,36);ctx.lineTo(22,42);ctx.lineTo(18,46);ctx.lineTo(16,49);ctx.lineTo(16,519);ctx.lineTo(17,523);ctx.lineTo(21,527);ctx.lineTo(37,533);ctx.lineTo(62,538);ctx.lineTo(77,541);ctx.lineTo(95,543);ctx.lineTo(114,545);ctx.lineTo(134,547);ctx.lineTo(156,549);ctx.lineTo(180,550);ctx.lineTo(204,551);ctx.lineTo(230,552);ctx.lineTo(257,553);ctx.lineTo(284,553);ctx.lineTo(311,553);ctx.lineTo(338,552);ctx.lineTo(364,551);ctx.lineTo(388,550);ctx.lineTo(412,549);ctx.lineTo(434,547);ctx.lineTo(455,545);ctx.lineTo(474,543);ctx.lineTo(491,541);ctx.lineTo(507,538);ctx.lineTo(532,533);ctx.lineTo(548,527);ctx.lineTo(552,523);ctx.lineTo(553,520);ctx.lineTo(553,519);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(553,519));listpt.Add(new Point(553,49));listpt.Add(new Point(547,42));listpt.Add(new Point(530,36));listpt.Add(new Point(505,31));listpt.Add(new Point(489,28));listpt.Add(new Point(472,26));listpt.Add(new Point(453,24));listpt.Add(new Point(432,22));listpt.Add(new Point(410,20));listpt.Add(new Point(387,19));listpt.Add(new Point(363,18));listpt.Add(new Point(337,17));listpt.Add(new Point(311,16));listpt.Add(new Point(284,16));listpt.Add(new Point(257,16));listpt.Add(new Point(231,17));listpt.Add(new Point(206,18));listpt.Add(new Point(181,19));listpt.Add(new Point(158,20));listpt.Add(new Point(136,22));listpt.Add(new Point(115,24));listpt.Add(new Point(96,26));listpt.Add(new Point(79,28));listpt.Add(new Point(63,31));listpt.Add(new Point(38,36));listpt.Add(new Point(22,42));listpt.Add(new Point(18,46));listpt.Add(new Point(16,49));listpt.Add(new Point(16,519));listpt.Add(new Point(17,523));listpt.Add(new Point(21,527));listpt.Add(new Point(37,533));listpt.Add(new Point(62,538));listpt.Add(new Point(77,541));listpt.Add(new Point(95,543));listpt.Add(new Point(114,545));listpt.Add(new Point(134,547));listpt.Add(new Point(156,549));listpt.Add(new Point(180,550));listpt.Add(new Point(204,551));listpt.Add(new Point(230,552));listpt.Add(new Point(257,553));listpt.Add(new Point(284,553));listpt.Add(new Point(311,553));listpt.Add(new Point(338,552));listpt.Add(new Point(364,551));listpt.Add(new Point(388,550));listpt.Add(new Point(412,549));listpt.Add(new Point(434,547));listpt.Add(new Point(455,545));listpt.Add(new Point(474,543));listpt.Add(new Point(491,541));listpt.Add(new Point(507,538));listpt.Add(new Point(532,533));listpt.Add(new Point(548,527));listpt.Add(new Point(552,523));listpt.Add(new Point(553,520));listpt.Add(new Point(553,519));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}