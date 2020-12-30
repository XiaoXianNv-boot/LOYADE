using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5AirCondition
{
    public class PIXIE_b52807f1_f195_4f8d_ba75_bcf61de24d0e : Pixie
    {
        public PIXIE_b52807f1_f195_4f8d_ba75_bcf61de24d0e()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 200f; _h = 200f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(200,54);ctx.lineTo(192,50);ctx.lineTo(185,46);ctx.lineTo(177,44);ctx.lineTo(170,41);ctx.lineTo(163,40);ctx.lineTo(156,39);ctx.lineTo(149,38);ctx.lineTo(142,38);ctx.lineTo(121,40);ctx.lineTo(102,46);ctx.lineTo(84,56);ctx.lineTo(69,69);ctx.lineTo(56,84);ctx.lineTo(46,102);ctx.lineTo(40,121);ctx.lineTo(38,142);ctx.lineTo(38,149);ctx.lineTo(39,156);ctx.lineTo(40,162);ctx.lineTo(42,169);ctx.lineTo(44,177);ctx.lineTo(47,184);ctx.lineTo(51,192);ctx.lineTo(55,200);ctx.lineTo(49,194);ctx.lineTo(44,187);ctx.lineTo(39,179);ctx.lineTo(36,171);ctx.lineTo(32,162);ctx.lineTo(30,152);ctx.lineTo(29,142);ctx.lineTo(28,132);ctx.lineTo(30,111);ctx.lineTo(36,91);ctx.lineTo(46,73);ctx.lineTo(58,58);ctx.lineTo(74,45);ctx.lineTo(91,35);ctx.lineTo(111,29);ctx.lineTo(132,27);ctx.lineTo(142,28);ctx.lineTo(152,29);ctx.lineTo(162,32);ctx.lineTo(171,35);ctx.lineTo(180,39);ctx.lineTo(188,43);ctx.lineTo(194,49);ctx.lineTo(200,54);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(200,54));listpt.Add(new Point(192,50));listpt.Add(new Point(185,46));listpt.Add(new Point(177,44));listpt.Add(new Point(170,41));listpt.Add(new Point(163,40));listpt.Add(new Point(156,39));listpt.Add(new Point(149,38));listpt.Add(new Point(142,38));listpt.Add(new Point(121,40));listpt.Add(new Point(102,46));listpt.Add(new Point(84,56));listpt.Add(new Point(69,69));listpt.Add(new Point(56,84));listpt.Add(new Point(46,102));listpt.Add(new Point(40,121));listpt.Add(new Point(38,142));listpt.Add(new Point(38,149));listpt.Add(new Point(39,156));listpt.Add(new Point(40,162));listpt.Add(new Point(42,169));listpt.Add(new Point(44,177));listpt.Add(new Point(47,184));listpt.Add(new Point(51,192));listpt.Add(new Point(55,200));listpt.Add(new Point(49,194));listpt.Add(new Point(44,187));listpt.Add(new Point(39,179));listpt.Add(new Point(36,171));listpt.Add(new Point(32,162));listpt.Add(new Point(30,152));listpt.Add(new Point(29,142));listpt.Add(new Point(28,132));listpt.Add(new Point(30,111));listpt.Add(new Point(36,91));listpt.Add(new Point(46,73));listpt.Add(new Point(58,58));listpt.Add(new Point(74,45));listpt.Add(new Point(91,35));listpt.Add(new Point(111,29));listpt.Add(new Point(132,27));listpt.Add(new Point(142,28));listpt.Add(new Point(152,29));listpt.Add(new Point(162,32));listpt.Add(new Point(171,35));listpt.Add(new Point(180,39));listpt.Add(new Point(188,43));listpt.Add(new Point(194,49));listpt.Add(new Point(200,54));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}