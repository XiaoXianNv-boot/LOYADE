using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Boiler
{
    public class PIXIE_d6b9b23f_a2b9_4d6a_8a03_c0a7a11ce48c : Pixie
    {
        public PIXIE_d6b9b23f_a2b9_4d6a_8a03_c0a7a11ce48c()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#366"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#191919"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 627f;
_content = "var arrFillColor = new Array(7); var arrBorderColor = new Array(7); var arrBorderWidth = new Array(7); arrFillColor[0] = '#366'; arrFillColor[1] = '#999'; arrFillColor[2] = '#ccc'; arrFillColor[3] = '#ccc'; arrFillColor[4] = '#191919'; arrFillColor[5] = '#4c4c4c'; arrFillColor[6] = '#ccc'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderColor[6] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; arrBorderWidth[6] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(784,352);ctx.lineTo(912,352);ctx.lineTo(912,520);ctx.lineTo(784,520);ctx.lineTo(784,352);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(37,597);ctx.lineTo(961,597);ctx.lineTo(961,618);ctx.lineTo(37,618);ctx.lineTo(37,597);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,597);ctx.lineTo(970,597);ctx.lineTo(970,588);ctx.lineTo(28,588);ctx.lineTo(28,597);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,627);ctx.lineTo(970,627);ctx.lineTo(970,618);ctx.lineTo(28,618);ctx.lineTo(28,627);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(735,195);ctx.lineTo(763,224);ctx.lineTo(793,224);ctx.lineTo(793,137);ctx.lineTo(803,137);ctx.lineTo(803,126);ctx.lineTo(753,126);ctx.lineTo(753,137);ctx.lineTo(763,137);ctx.lineTo(763,175);ctx.lineTo(735,146);ctx.lineTo(735,195);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(784,126);ctx.lineTo(784,28);ctx.lineTo(655,28);ctx.lineTo(655,77);ctx.lineTo(665,77);ctx.lineTo(665,37);ctx.lineTo(774,37);ctx.lineTo(774,126);ctx.lineTo(784,126);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(352,77);ctx.lineTo(352,67);ctx.lineTo(361,67);ctx.lineTo(361,58);ctx.lineTo(312,58);ctx.lineTo(312,67);ctx.lineTo(322,67);ctx.lineTo(322,77);ctx.lineTo(352,77);ctx.fillStyle = arrFillColor[6];ctx.fill();ctx.lineWidth = arrBorderWidth[6];ctx.strokeStyle = arrBorderColor[6];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(784,352));listpt.Add(new Point(912,352));listpt.Add(new Point(912,520));listpt.Add(new Point(784,520));listpt.Add(new Point(784,352));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(37,597));listpt.Add(new Point(961,597));listpt.Add(new Point(961,618));listpt.Add(new Point(37,618));listpt.Add(new Point(37,597));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,597));listpt.Add(new Point(970,597));listpt.Add(new Point(970,588));listpt.Add(new Point(28,588));listpt.Add(new Point(28,597));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,627));listpt.Add(new Point(970,627));listpt.Add(new Point(970,618));listpt.Add(new Point(28,618));listpt.Add(new Point(28,627));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(735,195));listpt.Add(new Point(763,224));listpt.Add(new Point(793,224));listpt.Add(new Point(793,137));listpt.Add(new Point(803,137));listpt.Add(new Point(803,126));listpt.Add(new Point(753,126));listpt.Add(new Point(753,137));listpt.Add(new Point(763,137));listpt.Add(new Point(763,175));listpt.Add(new Point(735,146));listpt.Add(new Point(735,195));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(784,126));listpt.Add(new Point(784,28));listpt.Add(new Point(655,28));listpt.Add(new Point(655,77));listpt.Add(new Point(665,77));listpt.Add(new Point(665,37));listpt.Add(new Point(774,37));listpt.Add(new Point(774,126));listpt.Add(new Point(784,126));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(352,77));listpt.Add(new Point(352,67));listpt.Add(new Point(361,67));listpt.Add(new Point(361,58));listpt.Add(new Point(312,58));listpt.Add(new Point(312,67));listpt.Add(new Point(322,67));listpt.Add(new Point(322,77));listpt.Add(new Point(352,77));sb = new SolidBrush(_listfillcolor[6]);p = new Pen(Color.Black);p.Width = _listborderwidth[6];p.Color = _listbordercolor[6];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}