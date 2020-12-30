using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Valve
{
    public class PIXIE_87e736b1_323a_4666_aed6_3914c8fc525c : Pixie
    {
        public PIXIE_87e736b1_323a_4666_aed6_3914c8fc525c()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 432f; _h = 98f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#999'; arrFillColor[1] = '#e5e5e5'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(432,67);ctx.lineTo(429,73);ctx.lineTo(412,82);ctx.lineTo(394,87);ctx.lineTo(371,91);ctx.lineTo(358,93);ctx.lineTo(344,94);ctx.lineTo(330,96);ctx.lineTo(315,97);ctx.lineTo(299,97);ctx.lineTo(282,98);ctx.lineTo(265,98);ctx.lineTo(248,98);ctx.lineTo(231,97);ctx.lineTo(216,97);ctx.lineTo(200,96);ctx.lineTo(186,94);ctx.lineTo(172,93);ctx.lineTo(148,89);ctx.lineTo(127,84);ctx.lineTo(112,79);ctx.lineTo(100,70);ctx.lineTo(99,67);ctx.lineTo(99,36);ctx.lineTo(112,44);ctx.lineTo(127,47);ctx.lineTo(148,51);ctx.lineTo(172,53);ctx.lineTo(186,54);ctx.lineTo(200,55);ctx.lineTo(216,56);ctx.lineTo(231,57);ctx.lineTo(299,57);ctx.lineTo(315,56);ctx.lineTo(330,55);ctx.lineTo(344,54);ctx.lineTo(358,53);ctx.lineTo(383,51);ctx.lineTo(403,47);ctx.lineTo(419,44);ctx.lineTo(429,40);ctx.lineTo(431,38);ctx.lineTo(432,36);ctx.lineTo(432,67);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(7.904762,1);ctx.arc(33.5241,36,21,0,Math.PI*2,true);ctx.scale(0.126506,1);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(432,67));listpt.Add(new Point(429,73));listpt.Add(new Point(412,82));listpt.Add(new Point(394,87));listpt.Add(new Point(371,91));listpt.Add(new Point(358,93));listpt.Add(new Point(344,94));listpt.Add(new Point(330,96));listpt.Add(new Point(315,97));listpt.Add(new Point(299,97));listpt.Add(new Point(282,98));listpt.Add(new Point(265,98));listpt.Add(new Point(248,98));listpt.Add(new Point(231,97));listpt.Add(new Point(216,97));listpt.Add(new Point(200,96));listpt.Add(new Point(186,94));listpt.Add(new Point(172,93));listpt.Add(new Point(148,89));listpt.Add(new Point(127,84));listpt.Add(new Point(112,79));listpt.Add(new Point(100,70));listpt.Add(new Point(99,67));listpt.Add(new Point(99,36));listpt.Add(new Point(112,44));listpt.Add(new Point(127,47));listpt.Add(new Point(148,51));listpt.Add(new Point(172,53));listpt.Add(new Point(186,54));listpt.Add(new Point(200,55));listpt.Add(new Point(216,56));listpt.Add(new Point(231,57));listpt.Add(new Point(299,57));listpt.Add(new Point(315,56));listpt.Add(new Point(330,55));listpt.Add(new Point(344,54));listpt.Add(new Point(358,53));listpt.Add(new Point(383,51));listpt.Add(new Point(403,47));listpt.Add(new Point(419,44));listpt.Add(new Point(429,40));listpt.Add(new Point(431,38));listpt.Add(new Point(432,36));listpt.Add(new Point(432,67));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 12.5241f,15f,42f,42f);g.DrawEllipse(p, 12.5241f,15f,42f,42f);
        }
    }
}