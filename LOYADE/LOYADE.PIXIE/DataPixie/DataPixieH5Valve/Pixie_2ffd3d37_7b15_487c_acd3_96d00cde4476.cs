using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Valve
{
    public class PIXIE_2ffd3d37_7b15_487c_acd3_96d00cde4476 : Pixie
    {
        public PIXIE_2ffd3d37_7b15_487c_acd3_96d00cde4476()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 971f; _h = 759f;
_content = "var arrFillColor = new Array(7); var arrBorderColor = new Array(7); var arrBorderWidth = new Array(7); arrFillColor[0] = '#999'; arrFillColor[1] = '#999'; arrFillColor[2] = '#7f7f7f'; arrFillColor[3] = '#b2b2b2'; arrFillColor[4] = '#e5e5e5'; arrFillColor[5] = '#7f7f7f'; arrFillColor[6] = '#999'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderColor[6] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; arrBorderWidth[6] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(480,297);ctx.lineTo(518,259);ctx.lineTo(903,259);ctx.lineTo(943,297);ctx.lineTo(943,682);ctx.lineTo(903,722);ctx.lineTo(518,722);ctx.lineTo(480,682);ctx.lineTo(480,297);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(673,756);ctx.lineTo(673,226);ctx.lineTo(676,220);ctx.lineTo(744,220);ctx.lineTo(750,226);ctx.lineTo(750,756);ctx.lineTo(744,759);ctx.lineTo(676,759);ctx.lineTo(673,756);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(943,393);ctx.lineTo(971,388);ctx.lineTo(971,342);ctx.lineTo(943,337);ctx.lineTo(943,393);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(943,384);ctx.lineTo(971,380);ctx.lineTo(971,342);ctx.lineTo(943,337);ctx.lineTo(943,384);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(971,350);ctx.lineTo(971,342);ctx.lineTo(943,337);ctx.lineTo(943,346);ctx.lineTo(971,350);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(527,259);ctx.lineTo(527,229);ctx.lineTo(644,229);ctx.lineTo(644,259);ctx.lineTo(527,259);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(605,229);ctx.lineTo(605,67);ctx.lineTo(595,37);ctx.lineTo(567,27);ctx.lineTo(340,27);ctx.lineTo(340,67);ctx.lineTo(557,67);ctx.lineTo(567,76);ctx.lineTo(567,229);ctx.lineTo(605,229);ctx.fillStyle = arrFillColor[6];ctx.fill();ctx.lineWidth = arrBorderWidth[6];ctx.strokeStyle = arrBorderColor[6];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(480,297));listpt.Add(new Point(518,259));listpt.Add(new Point(903,259));listpt.Add(new Point(943,297));listpt.Add(new Point(943,682));listpt.Add(new Point(903,722));listpt.Add(new Point(518,722));listpt.Add(new Point(480,682));listpt.Add(new Point(480,297));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(673,756));listpt.Add(new Point(673,226));listpt.Add(new Point(676,220));listpt.Add(new Point(744,220));listpt.Add(new Point(750,226));listpt.Add(new Point(750,756));listpt.Add(new Point(744,759));listpt.Add(new Point(676,759));listpt.Add(new Point(673,756));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(943,393));listpt.Add(new Point(971,388));listpt.Add(new Point(971,342));listpt.Add(new Point(943,337));listpt.Add(new Point(943,393));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(943,384));listpt.Add(new Point(971,380));listpt.Add(new Point(971,342));listpt.Add(new Point(943,337));listpt.Add(new Point(943,384));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(971,350));listpt.Add(new Point(971,342));listpt.Add(new Point(943,337));listpt.Add(new Point(943,346));listpt.Add(new Point(971,350));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(527,259));listpt.Add(new Point(527,229));listpt.Add(new Point(644,229));listpt.Add(new Point(644,259));listpt.Add(new Point(527,259));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(605,229));listpt.Add(new Point(605,67));listpt.Add(new Point(595,37));listpt.Add(new Point(567,27));listpt.Add(new Point(340,27));listpt.Add(new Point(340,67));listpt.Add(new Point(557,67));listpt.Add(new Point(567,76));listpt.Add(new Point(567,229));listpt.Add(new Point(605,229));sb = new SolidBrush(_listfillcolor[6]);p = new Pen(Color.Black);p.Width = _listborderwidth[6];p.Color = _listbordercolor[6];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}