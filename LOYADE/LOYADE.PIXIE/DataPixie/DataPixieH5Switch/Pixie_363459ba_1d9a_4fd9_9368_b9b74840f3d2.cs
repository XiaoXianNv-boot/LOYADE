using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Switch
{
    public class PIXIE_363459ba_1d9a_4fd9_9368_b9b74840f3d2 : Pixie
    {
        public PIXIE_363459ba_1d9a_4fd9_9368_b9b74840f3d2()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 720f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#000'; arrFillColor[1] = '#7f7f7f'; arrFillColor[2] = '#b2b2b2'; arrFillColor[3] = '#7f7f7f'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(970,525);ctx.lineTo(970,28);ctx.lineTo(28,28);ctx.lineTo(28,525);ctx.lineTo(970,525);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(499,499);ctx.lineTo(499,54);ctx.lineTo(56,54);ctx.lineTo(56,499);ctx.lineTo(499,499);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(499,499);ctx.lineTo(887,720);ctx.lineTo(887,277);ctx.lineTo(499,54);ctx.lineTo(499,499);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(942,277);ctx.lineTo(942,322);ctx.lineTo(941,366);ctx.lineTo(939,409);ctx.lineTo(938,449);ctx.lineTo(935,488);ctx.lineTo(933,524);ctx.lineTo(929,558);ctx.lineTo(926,590);ctx.lineTo(922,618);ctx.lineTo(916,655);ctx.lineTo(909,685);ctx.lineTo(898,710);ctx.lineTo(890,719);ctx.lineTo(887,720);ctx.lineTo(887,277);ctx.lineTo(905,253);ctx.lineTo(913,225);ctx.lineTo(919,194);ctx.lineTo(924,168);ctx.lineTo(928,137);ctx.lineTo(932,104);ctx.lineTo(935,67);ctx.lineTo(936,54);ctx.lineTo(942,54);ctx.lineTo(942,277);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(970,525));listpt.Add(new Point(970,28));listpt.Add(new Point(28,28));listpt.Add(new Point(28,525));listpt.Add(new Point(970,525));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(499,499));listpt.Add(new Point(499,54));listpt.Add(new Point(56,54));listpt.Add(new Point(56,499));listpt.Add(new Point(499,499));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(499,499));listpt.Add(new Point(887,720));listpt.Add(new Point(887,277));listpt.Add(new Point(499,54));listpt.Add(new Point(499,499));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(942,277));listpt.Add(new Point(942,322));listpt.Add(new Point(941,366));listpt.Add(new Point(939,409));listpt.Add(new Point(938,449));listpt.Add(new Point(935,488));listpt.Add(new Point(933,524));listpt.Add(new Point(929,558));listpt.Add(new Point(926,590));listpt.Add(new Point(922,618));listpt.Add(new Point(916,655));listpt.Add(new Point(909,685));listpt.Add(new Point(898,710));listpt.Add(new Point(890,719));listpt.Add(new Point(887,720));listpt.Add(new Point(887,277));listpt.Add(new Point(905,253));listpt.Add(new Point(913,225));listpt.Add(new Point(919,194));listpt.Add(new Point(924,168));listpt.Add(new Point(928,137));listpt.Add(new Point(932,104));listpt.Add(new Point(935,67));listpt.Add(new Point(936,54));listpt.Add(new Point(942,54));listpt.Add(new Point(942,277));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}