using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Switch
{
    public class PIXIE_1008ac3e_9e98_4974_b00e_5b0acaee61ce : Pixie
    {
        public PIXIE_1008ac3e_9e98_4974_b00e_5b0acaee61ce()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 721f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#000'; arrFillColor[1] = '#b2b2b2'; arrFillColor[2] = '#7f7f7f'; arrFillColor[3] = '#ccc'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,527);ctx.lineTo(28,28);ctx.lineTo(970,28);ctx.lineTo(970,527);ctx.lineTo(28,527);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(499,499);ctx.lineTo(499,56);ctx.lineTo(942,56);ctx.lineTo(942,499);ctx.lineTo(499,499);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(499,499);ctx.lineTo(111,721);ctx.lineTo(111,277);ctx.lineTo(499,56);ctx.lineTo(499,499);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(56,277);ctx.lineTo(56,322);ctx.lineTo(57,366);ctx.lineTo(59,409);ctx.lineTo(60,449);ctx.lineTo(63,488);ctx.lineTo(65,525);ctx.lineTo(69,559);ctx.lineTo(72,591);ctx.lineTo(76,620);ctx.lineTo(82,657);ctx.lineTo(89,686);ctx.lineTo(100,712);ctx.lineTo(108,721);ctx.lineTo(111,721);ctx.lineTo(111,277);ctx.lineTo(93,253);ctx.lineTo(85,225);ctx.lineTo(79,195);ctx.lineTo(74,168);ctx.lineTo(70,138);ctx.lineTo(66,105);ctx.lineTo(63,69);ctx.lineTo(62,56);ctx.lineTo(56,56);ctx.lineTo(56,277);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,527));listpt.Add(new Point(28,28));listpt.Add(new Point(970,28));listpt.Add(new Point(970,527));listpt.Add(new Point(28,527));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(499,499));listpt.Add(new Point(499,56));listpt.Add(new Point(942,56));listpt.Add(new Point(942,499));listpt.Add(new Point(499,499));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(499,499));listpt.Add(new Point(111,721));listpt.Add(new Point(111,277));listpt.Add(new Point(499,56));listpt.Add(new Point(499,499));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(56,277));listpt.Add(new Point(56,322));listpt.Add(new Point(57,366));listpt.Add(new Point(59,409));listpt.Add(new Point(60,449));listpt.Add(new Point(63,488));listpt.Add(new Point(65,525));listpt.Add(new Point(69,559));listpt.Add(new Point(72,591));listpt.Add(new Point(76,620));listpt.Add(new Point(82,657));listpt.Add(new Point(89,686));listpt.Add(new Point(100,712));listpt.Add(new Point(108,721));listpt.Add(new Point(111,721));listpt.Add(new Point(111,277));listpt.Add(new Point(93,253));listpt.Add(new Point(85,225));listpt.Add(new Point(79,195));listpt.Add(new Point(74,168));listpt.Add(new Point(70,138));listpt.Add(new Point(66,105));listpt.Add(new Point(63,69));listpt.Add(new Point(62,56));listpt.Add(new Point(56,56));listpt.Add(new Point(56,277));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}