using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5AirCondition
{
    public class PIXIE_d81da2f8_7ef8_4ce2_acaa_23083322417a : Pixie
    {
        public PIXIE_d81da2f8_7ef8_4ce2_acaa_23083322417a()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 198f; _h = 198f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(198,46);ctx.lineTo(190,42);ctx.lineTo(182,38);ctx.lineTo(174,35);ctx.lineTo(167,33);ctx.lineTo(160,31);ctx.lineTo(152,30);ctx.lineTo(145,29);ctx.lineTo(138,29);ctx.lineTo(116,31);ctx.lineTo(96,38);ctx.lineTo(77,48);ctx.lineTo(61,61);ctx.lineTo(48,77);ctx.lineTo(38,96);ctx.lineTo(31,116);ctx.lineTo(29,138);ctx.lineTo(29,145);ctx.lineTo(30,152);ctx.lineTo(31,159);ctx.lineTo(33,166);ctx.lineTo(36,174);ctx.lineTo(39,182);ctx.lineTo(42,190);ctx.lineTo(47,198);ctx.lineTo(41,192);ctx.lineTo(35,185);ctx.lineTo(30,177);ctx.lineTo(26,168);ctx.lineTo(23,158);ctx.lineTo(20,148);ctx.lineTo(19,138);ctx.lineTo(18,127);ctx.lineTo(20,105);ctx.lineTo(27,85);ctx.lineTo(37,66);ctx.lineTo(50,50);ctx.lineTo(66,37);ctx.lineTo(85,27);ctx.lineTo(105,20);ctx.lineTo(127,18);ctx.lineTo(138,19);ctx.lineTo(148,20);ctx.lineTo(158,23);ctx.lineTo(168,26);ctx.lineTo(177,30);ctx.lineTo(185,35);ctx.lineTo(192,40);ctx.lineTo(198,46);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(198,46));listpt.Add(new Point(190,42));listpt.Add(new Point(182,38));listpt.Add(new Point(174,35));listpt.Add(new Point(167,33));listpt.Add(new Point(160,31));listpt.Add(new Point(152,30));listpt.Add(new Point(145,29));listpt.Add(new Point(138,29));listpt.Add(new Point(116,31));listpt.Add(new Point(96,38));listpt.Add(new Point(77,48));listpt.Add(new Point(61,61));listpt.Add(new Point(48,77));listpt.Add(new Point(38,96));listpt.Add(new Point(31,116));listpt.Add(new Point(29,138));listpt.Add(new Point(29,145));listpt.Add(new Point(30,152));listpt.Add(new Point(31,159));listpt.Add(new Point(33,166));listpt.Add(new Point(36,174));listpt.Add(new Point(39,182));listpt.Add(new Point(42,190));listpt.Add(new Point(47,198));listpt.Add(new Point(41,192));listpt.Add(new Point(35,185));listpt.Add(new Point(30,177));listpt.Add(new Point(26,168));listpt.Add(new Point(23,158));listpt.Add(new Point(20,148));listpt.Add(new Point(19,138));listpt.Add(new Point(18,127));listpt.Add(new Point(20,105));listpt.Add(new Point(27,85));listpt.Add(new Point(37,66));listpt.Add(new Point(50,50));listpt.Add(new Point(66,37));listpt.Add(new Point(85,27));listpt.Add(new Point(105,20));listpt.Add(new Point(127,18));listpt.Add(new Point(138,19));listpt.Add(new Point(148,20));listpt.Add(new Point(158,23));listpt.Add(new Point(168,26));listpt.Add(new Point(177,30));listpt.Add(new Point(185,35));listpt.Add(new Point(192,40));listpt.Add(new Point(198,46));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}