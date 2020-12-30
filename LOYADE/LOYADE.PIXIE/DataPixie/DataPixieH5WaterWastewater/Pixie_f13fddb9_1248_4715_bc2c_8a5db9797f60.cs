using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WaterWastewater
{
    public class PIXIE_f13fddb9_1248_4715_bc2c_8a5db9797f60 : Pixie
    {
        public PIXIE_f13fddb9_1248_4715_bc2c_8a5db9797f60()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#666"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 656f; _h = 970f;
_content = "var arrFillColor = new Array(8); var arrBorderColor = new Array(8); var arrBorderWidth = new Array(8); arrFillColor[0] = '#666'; arrFillColor[1] = '#7f7f7f'; arrFillColor[2] = '#4c4c4c'; arrFillColor[3] = '#999'; arrFillColor[4] = '#999'; arrFillColor[5] = '#999'; arrFillColor[6] = '#999'; arrFillColor[7] = '#999'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderColor[6] = '#000'; arrBorderColor[7] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; arrBorderWidth[6] = '2'; arrBorderWidth[7] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(67,656);ctx.lineTo(617,656);ctx.lineTo(617,666);ctx.lineTo(342,671);ctx.lineTo(67,666);ctx.lineTo(67,656);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(385,355);ctx.lineTo(385,134);ctx.lineTo(395,134);ctx.lineTo(395,355);ctx.lineTo(385,355);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(87,366);ctx.lineTo(597,366);ctx.lineTo(597,355);ctx.lineTo(87,355);ctx.lineTo(87,366);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,970);ctx.lineTo(87,366);ctx.lineTo(106,366);ctx.lineTo(48,970);ctx.lineTo(28,970);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(597,366);ctx.lineTo(656,970);ctx.lineTo(637,970);ctx.lineTo(578,366);ctx.lineTo(597,366);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(185,970);ctx.lineTo(205,366);ctx.lineTo(224,366);ctx.lineTo(205,970);ctx.lineTo(185,970);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(480,366);ctx.lineTo(499,970);ctx.lineTo(480,970);ctx.lineTo(460,366);ctx.lineTo(480,366);ctx.fillStyle = arrFillColor[6];ctx.fill();ctx.lineWidth = arrBorderWidth[6];ctx.strokeStyle = arrBorderColor[6];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(332,970);ctx.lineTo(332,366);ctx.lineTo(352,366);ctx.lineTo(352,970);ctx.lineTo(332,970);ctx.fillStyle = arrFillColor[7];ctx.fill();ctx.lineWidth = arrBorderWidth[7];ctx.strokeStyle = arrBorderColor[7];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(67,656));listpt.Add(new Point(617,656));listpt.Add(new Point(617,666));listpt.Add(new Point(342,671));listpt.Add(new Point(67,666));listpt.Add(new Point(67,656));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(385,355));listpt.Add(new Point(385,134));listpt.Add(new Point(395,134));listpt.Add(new Point(395,355));listpt.Add(new Point(385,355));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(87,366));listpt.Add(new Point(597,366));listpt.Add(new Point(597,355));listpt.Add(new Point(87,355));listpt.Add(new Point(87,366));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,970));listpt.Add(new Point(87,366));listpt.Add(new Point(106,366));listpt.Add(new Point(48,970));listpt.Add(new Point(28,970));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(597,366));listpt.Add(new Point(656,970));listpt.Add(new Point(637,970));listpt.Add(new Point(578,366));listpt.Add(new Point(597,366));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(185,970));listpt.Add(new Point(205,366));listpt.Add(new Point(224,366));listpt.Add(new Point(205,970));listpt.Add(new Point(185,970));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(480,366));listpt.Add(new Point(499,970));listpt.Add(new Point(480,970));listpt.Add(new Point(460,366));listpt.Add(new Point(480,366));sb = new SolidBrush(_listfillcolor[6]);p = new Pen(Color.Black);p.Width = _listborderwidth[6];p.Color = _listbordercolor[6];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(332,970));listpt.Add(new Point(332,366));listpt.Add(new Point(352,366));listpt.Add(new Point(352,970));listpt.Add(new Point(332,970));sb = new SolidBrush(_listfillcolor[7]);p = new Pen(Color.Black);p.Width = _listborderwidth[7];p.Color = _listbordercolor[7];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}