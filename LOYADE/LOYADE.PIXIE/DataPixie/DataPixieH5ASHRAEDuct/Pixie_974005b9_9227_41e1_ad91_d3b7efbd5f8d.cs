using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEDuct
{
    public class PIXIE_974005b9_9227_41e1_ad91_d3b7efbd5f8d : Pixie
    {
        public PIXIE_974005b9_9227_41e1_ad91_d3b7efbd5f8d()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 971f; _h = 807f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(27,583);ctx.lineTo(65,583);ctx.lineTo(103,586);ctx.lineTo(141,591);ctx.lineTo(179,598);ctx.lineTo(216,607);ctx.lineTo(253,617);ctx.lineTo(289,629);ctx.lineTo(325,643);ctx.lineTo(360,658);ctx.lineTo(395,675);ctx.lineTo(428,694);ctx.lineTo(461,713);ctx.lineTo(492,735);ctx.lineTo(523,758);ctx.lineTo(552,782);ctx.lineTo(580,807);ctx.lineTo(971,416);ctx.lineTo(948,394);ctx.lineTo(924,372);ctx.lineTo(899,351);ctx.lineTo(874,330);ctx.lineTo(848,310);ctx.lineTo(823,290);ctx.lineTo(796,271);ctx.lineTo(768,253);ctx.lineTo(742,235);ctx.lineTo(713,218);ctx.lineTo(685,202);ctx.lineTo(656,186);ctx.lineTo(627,171);ctx.lineTo(598,157);ctx.lineTo(567,143);ctx.lineTo(538,130);ctx.lineTo(507,119);ctx.lineTo(477,107);ctx.lineTo(446,96);ctx.lineTo(415,86);ctx.lineTo(383,77);ctx.lineTo(351,68);ctx.lineTo(319,61);ctx.lineTo(287,54);ctx.lineTo(255,47);ctx.lineTo(223,42);ctx.lineTo(191,38);ctx.lineTo(158,34);ctx.lineTo(125,31);ctx.lineTo(93,29);ctx.lineTo(60,27);ctx.lineTo(27,27);ctx.lineTo(27,583);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(27,583));listpt.Add(new Point(65,583));listpt.Add(new Point(103,586));listpt.Add(new Point(141,591));listpt.Add(new Point(179,598));listpt.Add(new Point(216,607));listpt.Add(new Point(253,617));listpt.Add(new Point(289,629));listpt.Add(new Point(325,643));listpt.Add(new Point(360,658));listpt.Add(new Point(395,675));listpt.Add(new Point(428,694));listpt.Add(new Point(461,713));listpt.Add(new Point(492,735));listpt.Add(new Point(523,758));listpt.Add(new Point(552,782));listpt.Add(new Point(580,807));listpt.Add(new Point(971,416));listpt.Add(new Point(948,394));listpt.Add(new Point(924,372));listpt.Add(new Point(899,351));listpt.Add(new Point(874,330));listpt.Add(new Point(848,310));listpt.Add(new Point(823,290));listpt.Add(new Point(796,271));listpt.Add(new Point(768,253));listpt.Add(new Point(742,235));listpt.Add(new Point(713,218));listpt.Add(new Point(685,202));listpt.Add(new Point(656,186));listpt.Add(new Point(627,171));listpt.Add(new Point(598,157));listpt.Add(new Point(567,143));listpt.Add(new Point(538,130));listpt.Add(new Point(507,119));listpt.Add(new Point(477,107));listpt.Add(new Point(446,96));listpt.Add(new Point(415,86));listpt.Add(new Point(383,77));listpt.Add(new Point(351,68));listpt.Add(new Point(319,61));listpt.Add(new Point(287,54));listpt.Add(new Point(255,47));listpt.Add(new Point(223,42));listpt.Add(new Point(191,38));listpt.Add(new Point(158,34));listpt.Add(new Point(125,31));listpt.Add(new Point(93,29));listpt.Add(new Point(60,27));listpt.Add(new Point(27,27));listpt.Add(new Point(27,583));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}