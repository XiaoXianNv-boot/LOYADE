using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_2471dd42_2ecc_45c4_b45d_dd7e6805a0a5 : Pixie
    {
        public PIXIE_2471dd42_2ecc_45c4_b45d_dd7e6805a0a5()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 691f; _h = 557f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(674,110);ctx.lineTo(690,93);ctx.lineTo(691,87);ctx.lineTo(689,80);ctx.lineTo(676,67);ctx.lineTo(651,55);ctx.lineTo(634,50);ctx.lineTo(614,44);ctx.lineTo(593,40);ctx.lineTo(569,35);ctx.lineTo(543,31);ctx.lineTo(515,28);ctx.lineTo(486,25);ctx.lineTo(455,23);ctx.lineTo(423,21);ctx.lineTo(389,20);ctx.lineTo(355,20);ctx.lineTo(321,20);ctx.lineTo(288,21);ctx.lineTo(256,23);ctx.lineTo(225,25);ctx.lineTo(196,28);ctx.lineTo(168,31);ctx.lineTo(142,35);ctx.lineTo(119,40);ctx.lineTo(97,44);ctx.lineTo(77,50);ctx.lineTo(46,61);ctx.lineTo(27,73);ctx.lineTo(22,80);ctx.lineTo(20,87);ctx.lineTo(21,93);ctx.lineTo(37,110);ctx.lineTo(289,541);ctx.lineTo(290,547);ctx.lineTo(309,553);ctx.lineTo(330,556);ctx.lineTo(342,557);ctx.lineTo(356,557);ctx.lineTo(382,556);ctx.lineTo(403,553);ctx.lineTo(422,547);ctx.lineTo(423,542);ctx.lineTo(422,542);ctx.lineTo(422,541);ctx.lineTo(674,110);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(674,110));listpt.Add(new Point(690,93));listpt.Add(new Point(691,87));listpt.Add(new Point(689,80));listpt.Add(new Point(676,67));listpt.Add(new Point(651,55));listpt.Add(new Point(634,50));listpt.Add(new Point(614,44));listpt.Add(new Point(593,40));listpt.Add(new Point(569,35));listpt.Add(new Point(543,31));listpt.Add(new Point(515,28));listpt.Add(new Point(486,25));listpt.Add(new Point(455,23));listpt.Add(new Point(423,21));listpt.Add(new Point(389,20));listpt.Add(new Point(355,20));listpt.Add(new Point(321,20));listpt.Add(new Point(288,21));listpt.Add(new Point(256,23));listpt.Add(new Point(225,25));listpt.Add(new Point(196,28));listpt.Add(new Point(168,31));listpt.Add(new Point(142,35));listpt.Add(new Point(119,40));listpt.Add(new Point(97,44));listpt.Add(new Point(77,50));listpt.Add(new Point(46,61));listpt.Add(new Point(27,73));listpt.Add(new Point(22,80));listpt.Add(new Point(20,87));listpt.Add(new Point(21,93));listpt.Add(new Point(37,110));listpt.Add(new Point(289,541));listpt.Add(new Point(290,547));listpt.Add(new Point(309,553));listpt.Add(new Point(330,556));listpt.Add(new Point(342,557));listpt.Add(new Point(356,557));listpt.Add(new Point(382,556));listpt.Add(new Point(403,553));listpt.Add(new Point(422,547));listpt.Add(new Point(423,542));listpt.Add(new Point(422,542));listpt.Add(new Point(422,541));listpt.Add(new Point(674,110));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}