using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5AirCondition
{
    public class PIXIE_ba4a2df3_1151_483b_8abe_aa96f24e32fb : Pixie
    {
        public PIXIE_ba4a2df3_1151_483b_8abe_aa96f24e32fb()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 234f; _h = 235f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* circle */ ctx.arc(131,132,103,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(200,56);ctx.lineTo(192,52);ctx.lineTo(185,48);ctx.lineTo(177,45);ctx.lineTo(170,42);ctx.lineTo(163,41);ctx.lineTo(156,39);ctx.lineTo(149,38);ctx.lineTo(142,38);ctx.lineTo(121,40);ctx.lineTo(102,46);ctx.lineTo(84,56);ctx.lineTo(69,69);ctx.lineTo(56,84);ctx.lineTo(46,102);ctx.lineTo(40,121);ctx.lineTo(38,142);ctx.lineTo(38,149);ctx.lineTo(39,156);ctx.lineTo(40,163);ctx.lineTo(42,170);ctx.lineTo(44,177);ctx.lineTo(47,185);ctx.lineTo(51,192);ctx.lineTo(55,200);ctx.lineTo(49,194);ctx.lineTo(44,187);ctx.lineTo(39,179);ctx.lineTo(36,171);ctx.lineTo(32,162);ctx.lineTo(30,152);ctx.lineTo(29,142);ctx.lineTo(28,132);ctx.lineTo(30,111);ctx.lineTo(36,92);ctx.lineTo(46,74);ctx.lineTo(58,59);ctx.lineTo(73,46);ctx.lineTo(91,36);ctx.lineTo(110,30);ctx.lineTo(131,28);ctx.lineTo(141,29);ctx.lineTo(152,30);ctx.lineTo(161,33);ctx.lineTo(171,36);ctx.lineTo(179,40);ctx.lineTo(187,45);ctx.lineTo(194,50);ctx.lineTo(200,56);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillEllipse(sb, 28f,29f,206f,206f);g.DrawEllipse(p, 28f,29f,206f,206f);
listpt = new List<Point>();listpt.Add(new Point(200,56));listpt.Add(new Point(192,52));listpt.Add(new Point(185,48));listpt.Add(new Point(177,45));listpt.Add(new Point(170,42));listpt.Add(new Point(163,41));listpt.Add(new Point(156,39));listpt.Add(new Point(149,38));listpt.Add(new Point(142,38));listpt.Add(new Point(121,40));listpt.Add(new Point(102,46));listpt.Add(new Point(84,56));listpt.Add(new Point(69,69));listpt.Add(new Point(56,84));listpt.Add(new Point(46,102));listpt.Add(new Point(40,121));listpt.Add(new Point(38,142));listpt.Add(new Point(38,149));listpt.Add(new Point(39,156));listpt.Add(new Point(40,163));listpt.Add(new Point(42,170));listpt.Add(new Point(44,177));listpt.Add(new Point(47,185));listpt.Add(new Point(51,192));listpt.Add(new Point(55,200));listpt.Add(new Point(49,194));listpt.Add(new Point(44,187));listpt.Add(new Point(39,179));listpt.Add(new Point(36,171));listpt.Add(new Point(32,162));listpt.Add(new Point(30,152));listpt.Add(new Point(29,142));listpt.Add(new Point(28,132));listpt.Add(new Point(30,111));listpt.Add(new Point(36,92));listpt.Add(new Point(46,74));listpt.Add(new Point(58,59));listpt.Add(new Point(73,46));listpt.Add(new Point(91,36));listpt.Add(new Point(110,30));listpt.Add(new Point(131,28));listpt.Add(new Point(141,29));listpt.Add(new Point(152,30));listpt.Add(new Point(161,33));listpt.Add(new Point(171,36));listpt.Add(new Point(179,40));listpt.Add(new Point(187,45));listpt.Add(new Point(194,50));listpt.Add(new Point(200,56));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}