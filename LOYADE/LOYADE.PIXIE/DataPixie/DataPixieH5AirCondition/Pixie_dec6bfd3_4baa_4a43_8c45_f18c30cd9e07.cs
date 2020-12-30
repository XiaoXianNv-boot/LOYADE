using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5AirCondition
{
    public class PIXIE_dec6bfd3_4baa_4a43_8c45_f18c30cd9e07 : Pixie
    {
        public PIXIE_dec6bfd3_4baa_4a43_8c45_f18c30cd9e07()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 386f; _h = 132f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrFillColor[2] = '#000'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(386,74);ctx.lineTo(11,74);ctx.lineTo(15,61);ctx.lineTo(26,49);ctx.lineTo(34,44);ctx.lineTo(43,39);ctx.lineTo(54,34);ctx.lineTo(66,29);ctx.lineTo(79,25);ctx.lineTo(94,22);ctx.lineTo(109,19);ctx.lineTo(125,16);ctx.lineTo(142,14);ctx.lineTo(160,12);ctx.lineTo(179,11);ctx.lineTo(217,11);ctx.lineTo(236,12);ctx.lineTo(254,14);ctx.lineTo(271,16);ctx.lineTo(288,19);ctx.lineTo(303,22);ctx.lineTo(318,25);ctx.lineTo(331,29);ctx.lineTo(343,34);ctx.lineTo(354,39);ctx.lineTo(363,44);ctx.lineTo(371,49);ctx.lineTo(382,61);ctx.lineTo(386,74);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(347,128);ctx.lineTo(343,123);ctx.lineTo(340,118);ctx.lineTo(337,112);ctx.lineTo(335,106);ctx.lineTo(333,99);ctx.lineTo(331,92);ctx.lineTo(329,83);ctx.lineTo(327,74);ctx.lineTo(70,74);ctx.lineTo(68,83);ctx.lineTo(66,92);ctx.lineTo(64,99);ctx.lineTo(62,106);ctx.lineTo(60,112);ctx.lineTo(57,118);ctx.lineTo(54,123);ctx.lineTo(50,128);ctx.lineTo(347,128);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(50,128);ctx.lineTo(347,128);ctx.lineTo(347,132);ctx.lineTo(50,132);ctx.lineTo(50,128);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(386,74));listpt.Add(new Point(11,74));listpt.Add(new Point(15,61));listpt.Add(new Point(26,49));listpt.Add(new Point(34,44));listpt.Add(new Point(43,39));listpt.Add(new Point(54,34));listpt.Add(new Point(66,29));listpt.Add(new Point(79,25));listpt.Add(new Point(94,22));listpt.Add(new Point(109,19));listpt.Add(new Point(125,16));listpt.Add(new Point(142,14));listpt.Add(new Point(160,12));listpt.Add(new Point(179,11));listpt.Add(new Point(217,11));listpt.Add(new Point(236,12));listpt.Add(new Point(254,14));listpt.Add(new Point(271,16));listpt.Add(new Point(288,19));listpt.Add(new Point(303,22));listpt.Add(new Point(318,25));listpt.Add(new Point(331,29));listpt.Add(new Point(343,34));listpt.Add(new Point(354,39));listpt.Add(new Point(363,44));listpt.Add(new Point(371,49));listpt.Add(new Point(382,61));listpt.Add(new Point(386,74));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(347,128));listpt.Add(new Point(343,123));listpt.Add(new Point(340,118));listpt.Add(new Point(337,112));listpt.Add(new Point(335,106));listpt.Add(new Point(333,99));listpt.Add(new Point(331,92));listpt.Add(new Point(329,83));listpt.Add(new Point(327,74));listpt.Add(new Point(70,74));listpt.Add(new Point(68,83));listpt.Add(new Point(66,92));listpt.Add(new Point(64,99));listpt.Add(new Point(62,106));listpt.Add(new Point(60,112));listpt.Add(new Point(57,118));listpt.Add(new Point(54,123));listpt.Add(new Point(50,128));listpt.Add(new Point(347,128));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(50,128));listpt.Add(new Point(347,128));listpt.Add(new Point(347,132));listpt.Add(new Point(50,132));listpt.Add(new Point(50,128));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}