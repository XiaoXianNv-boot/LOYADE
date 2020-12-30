using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Valve
{
    public class PIXIE_1c884561_55a9_4da9_a093_6e17821e8dc9 : Pixie
    {
        public PIXIE_1c884561_55a9_4da9_a093_6e17821e8dc9()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 514f; _h = 432f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#999'; arrFillColor[1] = '#e5e5e5'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(463,432);ctx.lineTo(457,429);ctx.lineTo(448,412);ctx.lineTo(443,394);ctx.lineTo(439,371);ctx.lineTo(437,358);ctx.lineTo(436,344);ctx.lineTo(434,330);ctx.lineTo(433,315);ctx.lineTo(433,299);ctx.lineTo(432,282);ctx.lineTo(432,265);ctx.lineTo(432,248);ctx.lineTo(433,231);ctx.lineTo(433,215);ctx.lineTo(434,200);ctx.lineTo(436,186);ctx.lineTo(437,172);ctx.lineTo(441,147);ctx.lineTo(446,127);ctx.lineTo(451,111);ctx.lineTo(457,101);ctx.lineTo(460,99);ctx.lineTo(463,98);ctx.lineTo(495,98);ctx.lineTo(491,101);ctx.lineTo(485,118);ctx.lineTo(481,136);ctx.lineTo(479,159);ctx.lineTo(477,172);ctx.lineTo(476,186);ctx.lineTo(476,200);ctx.lineTo(475,215);ctx.lineTo(474,231);ctx.lineTo(474,299);ctx.lineTo(475,315);ctx.lineTo(476,330);ctx.lineTo(476,344);ctx.lineTo(477,358);ctx.lineTo(480,383);ctx.lineTo(483,403);ctx.lineTo(487,419);ctx.lineTo(491,429);ctx.lineTo(493,431);ctx.lineTo(495,432);ctx.lineTo(463,432);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(1,8.35);ctx.arc(494,31.73652,20,0,Math.PI*2,true);ctx.scale(1,0.1197605);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(463,432));listpt.Add(new Point(457,429));listpt.Add(new Point(448,412));listpt.Add(new Point(443,394));listpt.Add(new Point(439,371));listpt.Add(new Point(437,358));listpt.Add(new Point(436,344));listpt.Add(new Point(434,330));listpt.Add(new Point(433,315));listpt.Add(new Point(433,299));listpt.Add(new Point(432,282));listpt.Add(new Point(432,265));listpt.Add(new Point(432,248));listpt.Add(new Point(433,231));listpt.Add(new Point(433,215));listpt.Add(new Point(434,200));listpt.Add(new Point(436,186));listpt.Add(new Point(437,172));listpt.Add(new Point(441,147));listpt.Add(new Point(446,127));listpt.Add(new Point(451,111));listpt.Add(new Point(457,101));listpt.Add(new Point(460,99));listpt.Add(new Point(463,98));listpt.Add(new Point(495,98));listpt.Add(new Point(491,101));listpt.Add(new Point(485,118));listpt.Add(new Point(481,136));listpt.Add(new Point(479,159));listpt.Add(new Point(477,172));listpt.Add(new Point(476,186));listpt.Add(new Point(476,200));listpt.Add(new Point(475,215));listpt.Add(new Point(474,231));listpt.Add(new Point(474,299));listpt.Add(new Point(475,315));listpt.Add(new Point(476,330));listpt.Add(new Point(476,344));listpt.Add(new Point(477,358));listpt.Add(new Point(480,383));listpt.Add(new Point(483,403));listpt.Add(new Point(487,419));listpt.Add(new Point(491,429));listpt.Add(new Point(493,431));listpt.Add(new Point(495,432));listpt.Add(new Point(463,432));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 474f,-135.2635f,40f,334f);g.DrawEllipse(p, 474f,-135.2635f,40f,334f);
        }
    }
}