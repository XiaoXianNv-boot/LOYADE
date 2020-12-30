using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_0bdd76cd_45e4_4e27_b7b7_c593e66f37bf : Pixie
    {
        public PIXIE_0bdd76cd_45e4_4e27_b7b7_c593e66f37bf()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 386f; _h = 261f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrFillColor[2] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(211,11);ctx.lineTo(210,42);ctx.lineTo(187,42);ctx.lineTo(186,11);ctx.lineTo(169,14);ctx.lineTo(154,19);ctx.lineTo(140,25);ctx.lineTo(128,33);ctx.lineTo(118,42);ctx.lineTo(111,52);ctx.lineTo(107,63);ctx.lineTo(105,74);ctx.lineTo(292,74);ctx.lineTo(290,63);ctx.lineTo(286,52);ctx.lineTo(279,42);ctx.lineTo(269,33);ctx.lineTo(257,25);ctx.lineTo(243,19);ctx.lineTo(228,14);ctx.lineTo(211,11);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(245,74);ctx.lineTo(245,261);ctx.lineTo(386,261);ctx.lineTo(382,245);ctx.lineTo(386,230);ctx.lineTo(382,214);ctx.lineTo(386,199);ctx.lineTo(382,183);ctx.lineTo(386,167);ctx.lineTo(382,152);ctx.lineTo(386,136);ctx.lineTo(323,136);ctx.lineTo(323,74);ctx.lineTo(245,74);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(152,261);ctx.lineTo(152,74);ctx.lineTo(11,74);ctx.lineTo(15,81);ctx.lineTo(11,89);ctx.lineTo(15,97);ctx.lineTo(11,105);ctx.lineTo(15,113);ctx.lineTo(11,120);ctx.lineTo(15,128);ctx.lineTo(11,136);ctx.lineTo(73,136);ctx.lineTo(73,261);ctx.lineTo(152,261);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(211,11));listpt.Add(new Point(210,42));listpt.Add(new Point(187,42));listpt.Add(new Point(186,11));listpt.Add(new Point(169,14));listpt.Add(new Point(154,19));listpt.Add(new Point(140,25));listpt.Add(new Point(128,33));listpt.Add(new Point(118,42));listpt.Add(new Point(111,52));listpt.Add(new Point(107,63));listpt.Add(new Point(105,74));listpt.Add(new Point(292,74));listpt.Add(new Point(290,63));listpt.Add(new Point(286,52));listpt.Add(new Point(279,42));listpt.Add(new Point(269,33));listpt.Add(new Point(257,25));listpt.Add(new Point(243,19));listpt.Add(new Point(228,14));listpt.Add(new Point(211,11));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(245,74));listpt.Add(new Point(245,261));listpt.Add(new Point(386,261));listpt.Add(new Point(382,245));listpt.Add(new Point(386,230));listpt.Add(new Point(382,214));listpt.Add(new Point(386,199));listpt.Add(new Point(382,183));listpt.Add(new Point(386,167));listpt.Add(new Point(382,152));listpt.Add(new Point(386,136));listpt.Add(new Point(323,136));listpt.Add(new Point(323,74));listpt.Add(new Point(245,74));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(152,261));listpt.Add(new Point(152,74));listpt.Add(new Point(11,74));listpt.Add(new Point(15,81));listpt.Add(new Point(11,89));listpt.Add(new Point(15,97));listpt.Add(new Point(11,105));listpt.Add(new Point(15,113));listpt.Add(new Point(11,120));listpt.Add(new Point(15,128));listpt.Add(new Point(11,136));listpt.Add(new Point(73,136));listpt.Add(new Point(73,261));listpt.Add(new Point(152,261));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}