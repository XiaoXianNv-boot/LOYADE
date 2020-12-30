using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_5519bf6c_b862_4668_9659_43a2520c79e9 : Pixie
    {
        public PIXIE_5519bf6c_b862_4668_9659_43a2520c79e9()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 386f; _h = 230f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrFillColor[2] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(52,82);ctx.lineTo(26,66);ctx.lineTo(80,52);ctx.lineTo(66,26);ctx.lineTo(120,41);ctx.lineTo(120,11);ctx.lineTo(159,52);ctx.lineTo(175,26);ctx.lineTo(189,80);ctx.lineTo(215,66);ctx.lineTo(200,120);ctx.lineTo(230,121);ctx.lineTo(189,160);ctx.lineTo(215,175);ctx.lineTo(161,189);ctx.lineTo(175,215);ctx.lineTo(121,200);ctx.lineTo(120,230);ctx.lineTo(81,190);ctx.lineTo(66,215);ctx.lineTo(52,161);ctx.lineTo(26,175);ctx.lineTo(41,121);ctx.lineTo(11,121);ctx.lineTo(52,82);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(331,191);ctx.lineTo(120,191);ctx.lineTo(131,190);ctx.lineTo(142,187);ctx.lineTo(151,182);ctx.lineTo(159,175);ctx.lineTo(166,167);ctx.lineTo(171,157);ctx.lineTo(174,147);ctx.lineTo(175,136);ctx.lineTo(174,125);ctx.lineTo(171,115);ctx.lineTo(166,106);ctx.lineTo(159,98);ctx.lineTo(151,91);ctx.lineTo(142,86);ctx.lineTo(131,83);ctx.lineTo(120,82);ctx.lineTo(331,82);ctx.lineTo(342,83);ctx.lineTo(353,86);ctx.lineTo(362,91);ctx.lineTo(370,98);ctx.lineTo(377,106);ctx.lineTo(382,115);ctx.lineTo(385,125);ctx.lineTo(386,136);ctx.lineTo(385,147);ctx.lineTo(382,157);ctx.lineTo(377,167);ctx.lineTo(370,175);ctx.lineTo(362,182);ctx.lineTo(353,187);ctx.lineTo(342,190);ctx.lineTo(331,191);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(121,136);ctx.lineTo(121,128);ctx.lineTo(124,129);ctx.lineTo(126,130);ctx.lineTo(127,133);ctx.lineTo(128,136);ctx.lineTo(127,139);ctx.lineTo(126,142);ctx.lineTo(124,143);ctx.lineTo(121,144);ctx.lineTo(121,136);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(52,82));listpt.Add(new Point(26,66));listpt.Add(new Point(80,52));listpt.Add(new Point(66,26));listpt.Add(new Point(120,41));listpt.Add(new Point(120,11));listpt.Add(new Point(159,52));listpt.Add(new Point(175,26));listpt.Add(new Point(189,80));listpt.Add(new Point(215,66));listpt.Add(new Point(200,120));listpt.Add(new Point(230,121));listpt.Add(new Point(189,160));listpt.Add(new Point(215,175));listpt.Add(new Point(161,189));listpt.Add(new Point(175,215));listpt.Add(new Point(121,200));listpt.Add(new Point(120,230));listpt.Add(new Point(81,190));listpt.Add(new Point(66,215));listpt.Add(new Point(52,161));listpt.Add(new Point(26,175));listpt.Add(new Point(41,121));listpt.Add(new Point(11,121));listpt.Add(new Point(52,82));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(331,191));listpt.Add(new Point(120,191));listpt.Add(new Point(131,190));listpt.Add(new Point(142,187));listpt.Add(new Point(151,182));listpt.Add(new Point(159,175));listpt.Add(new Point(166,167));listpt.Add(new Point(171,157));listpt.Add(new Point(174,147));listpt.Add(new Point(175,136));listpt.Add(new Point(174,125));listpt.Add(new Point(171,115));listpt.Add(new Point(166,106));listpt.Add(new Point(159,98));listpt.Add(new Point(151,91));listpt.Add(new Point(142,86));listpt.Add(new Point(131,83));listpt.Add(new Point(120,82));listpt.Add(new Point(331,82));listpt.Add(new Point(342,83));listpt.Add(new Point(353,86));listpt.Add(new Point(362,91));listpt.Add(new Point(370,98));listpt.Add(new Point(377,106));listpt.Add(new Point(382,115));listpt.Add(new Point(385,125));listpt.Add(new Point(386,136));listpt.Add(new Point(385,147));listpt.Add(new Point(382,157));listpt.Add(new Point(377,167));listpt.Add(new Point(370,175));listpt.Add(new Point(362,182));listpt.Add(new Point(353,187));listpt.Add(new Point(342,190));listpt.Add(new Point(331,191));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(121,136));listpt.Add(new Point(121,128));listpt.Add(new Point(124,129));listpt.Add(new Point(126,130));listpt.Add(new Point(127,133));listpt.Add(new Point(128,136));listpt.Add(new Point(127,139));listpt.Add(new Point(126,142));listpt.Add(new Point(124,143));listpt.Add(new Point(121,144));listpt.Add(new Point(121,136));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}