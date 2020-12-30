using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_b1743ec0_a4f1_4edb_b018_b344b6559d83 : Pixie
    {
        public PIXIE_b1743ec0_a4f1_4edb_b018_b344b6559d83()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 386f; _h = 261f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(11,249);ctx.lineTo(11,236);ctx.lineTo(11,223);ctx.lineTo(11,210);ctx.lineTo(11,41);ctx.lineTo(14,30);ctx.lineTo(20,20);ctx.lineTo(30,14);ctx.lineTo(35,12);ctx.lineTo(40,11);ctx.lineTo(53,11);ctx.lineTo(278,11);ctx.lineTo(289,14);ctx.lineTo(299,20);ctx.lineTo(306,30);ctx.lineTo(307,35);ctx.lineTo(308,41);ctx.lineTo(308,249);ctx.lineTo(278,249);ctx.lineTo(278,56);ctx.lineTo(277,50);ctx.lineTo(274,45);ctx.lineTo(264,41);ctx.lineTo(56,41);ctx.lineTo(50,42);ctx.lineTo(45,45);ctx.lineTo(41,50);ctx.lineTo(40,56);ctx.lineTo(40,249);ctx.lineTo(11,249);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(345,261);ctx.lineTo(365,234);ctx.lineTo(386,261);ctx.lineTo(345,261);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(11,249));listpt.Add(new Point(11,236));listpt.Add(new Point(11,223));listpt.Add(new Point(11,210));listpt.Add(new Point(11,41));listpt.Add(new Point(14,30));listpt.Add(new Point(20,20));listpt.Add(new Point(30,14));listpt.Add(new Point(35,12));listpt.Add(new Point(40,11));listpt.Add(new Point(53,11));listpt.Add(new Point(278,11));listpt.Add(new Point(289,14));listpt.Add(new Point(299,20));listpt.Add(new Point(306,30));listpt.Add(new Point(307,35));listpt.Add(new Point(308,41));listpt.Add(new Point(308,249));listpt.Add(new Point(278,249));listpt.Add(new Point(278,56));listpt.Add(new Point(277,50));listpt.Add(new Point(274,45));listpt.Add(new Point(264,41));listpt.Add(new Point(56,41));listpt.Add(new Point(50,42));listpt.Add(new Point(45,45));listpt.Add(new Point(41,50));listpt.Add(new Point(40,56));listpt.Add(new Point(40,249));listpt.Add(new Point(11,249));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(345,261));listpt.Add(new Point(365,234));listpt.Add(new Point(386,261));listpt.Add(new Point(345,261));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}