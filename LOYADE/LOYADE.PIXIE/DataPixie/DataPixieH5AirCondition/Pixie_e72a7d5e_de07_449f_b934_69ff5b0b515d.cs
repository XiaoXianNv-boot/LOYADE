using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5AirCondition
{
    public class PIXIE_e72a7d5e_de07_449f_b934_69ff5b0b515d : Pixie
    {
        public PIXIE_e72a7d5e_de07_449f_b934_69ff5b0b515d()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 170f; _h = 170f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* circle */ ctx.arc(96,96,74,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(144,41);ctx.lineTo(139,38);ctx.lineTo(134,36);ctx.lineTo(128,34);ctx.lineTo(118,31);ctx.lineTo(108,30);ctx.lineTo(103,30);ctx.lineTo(88,31);ctx.lineTo(75,36);ctx.lineTo(62,43);ctx.lineTo(52,51);ctx.lineTo(43,62);ctx.lineTo(36,75);ctx.lineTo(31,88);ctx.lineTo(30,103);ctx.lineTo(31,113);ctx.lineTo(31,118);ctx.lineTo(33,123);ctx.lineTo(34,129);ctx.lineTo(36,134);ctx.lineTo(39,139);ctx.lineTo(42,145);ctx.lineTo(38,141);ctx.lineTo(34,136);ctx.lineTo(30,130);ctx.lineTo(28,124);ctx.lineTo(25,118);ctx.lineTo(23,111);ctx.lineTo(22,103);ctx.lineTo(22,96);ctx.lineTo(23,81);ctx.lineTo(28,68);ctx.lineTo(35,55);ctx.lineTo(44,44);ctx.lineTo(55,35);ctx.lineTo(67,28);ctx.lineTo(81,24);ctx.lineTo(96,22);ctx.lineTo(103,22);ctx.lineTo(110,23);ctx.lineTo(117,25);ctx.lineTo(124,27);ctx.lineTo(130,30);ctx.lineTo(135,33);ctx.lineTo(140,37);ctx.lineTo(144,41);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.DrawEllipse(p, 22f,22f,148f,148f);
listpt = new List<Point>();listpt.Add(new Point(144,41));listpt.Add(new Point(139,38));listpt.Add(new Point(134,36));listpt.Add(new Point(128,34));listpt.Add(new Point(118,31));listpt.Add(new Point(108,30));listpt.Add(new Point(103,30));listpt.Add(new Point(88,31));listpt.Add(new Point(75,36));listpt.Add(new Point(62,43));listpt.Add(new Point(52,51));listpt.Add(new Point(43,62));listpt.Add(new Point(36,75));listpt.Add(new Point(31,88));listpt.Add(new Point(30,103));listpt.Add(new Point(31,113));listpt.Add(new Point(31,118));listpt.Add(new Point(33,123));listpt.Add(new Point(34,129));listpt.Add(new Point(36,134));listpt.Add(new Point(39,139));listpt.Add(new Point(42,145));listpt.Add(new Point(38,141));listpt.Add(new Point(34,136));listpt.Add(new Point(30,130));listpt.Add(new Point(28,124));listpt.Add(new Point(25,118));listpt.Add(new Point(23,111));listpt.Add(new Point(22,103));listpt.Add(new Point(22,96));listpt.Add(new Point(23,81));listpt.Add(new Point(28,68));listpt.Add(new Point(35,55));listpt.Add(new Point(44,44));listpt.Add(new Point(55,35));listpt.Add(new Point(67,28));listpt.Add(new Point(81,24));listpt.Add(new Point(96,22));listpt.Add(new Point(103,22));listpt.Add(new Point(110,23));listpt.Add(new Point(117,25));listpt.Add(new Point(124,27));listpt.Add(new Point(130,30));listpt.Add(new Point(135,33));listpt.Add(new Point(140,37));listpt.Add(new Point(144,41));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}