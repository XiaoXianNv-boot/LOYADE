using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WaterWastewater
{
    public class PIXIE_f4bc72e6_ffed_4f28_99f5_572fa907dfd1 : Pixie
    {
        public PIXIE_f4bc72e6_ffed_4f28_99f5_572fa907dfd1()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#ba6666"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ba6666"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#933"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 628f; _h = 672f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#ba6666'; arrFillColor[1] = '#ba6666'; arrFillColor[2] = '#933'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(180,78);ctx.lineTo(142,40);ctx.lineTo(42,141);ctx.lineTo(79,179);ctx.lineTo(92,166);ctx.lineTo(67,141);ctx.lineTo(142,65);ctx.lineTo(168,90);ctx.lineTo(180,78);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(612,577);ctx.lineTo(585,583);ctx.lineTo(564,562);ctx.lineTo(564,540);ctx.lineTo(538,524);ctx.lineTo(569,492);ctx.lineTo(586,519);ctx.lineTo(606,519);ctx.lineTo(628,540);ctx.lineTo(622,567);ctx.lineTo(612,577);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(522,667);ctx.lineTo(495,672);ctx.lineTo(474,651);ctx.lineTo(474,630);ctx.lineTo(448,614);ctx.lineTo(479,582);ctx.lineTo(495,609);ctx.lineTo(516,609);ctx.lineTo(538,630);ctx.lineTo(532,657);ctx.lineTo(522,667);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(180,78));listpt.Add(new Point(142,40));listpt.Add(new Point(42,141));listpt.Add(new Point(79,179));listpt.Add(new Point(92,166));listpt.Add(new Point(67,141));listpt.Add(new Point(142,65));listpt.Add(new Point(168,90));listpt.Add(new Point(180,78));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(612,577));listpt.Add(new Point(585,583));listpt.Add(new Point(564,562));listpt.Add(new Point(564,540));listpt.Add(new Point(538,524));listpt.Add(new Point(569,492));listpt.Add(new Point(586,519));listpt.Add(new Point(606,519));listpt.Add(new Point(628,540));listpt.Add(new Point(622,567));listpt.Add(new Point(612,577));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(522,667));listpt.Add(new Point(495,672));listpt.Add(new Point(474,651));listpt.Add(new Point(474,630));listpt.Add(new Point(448,614));listpt.Add(new Point(479,582));listpt.Add(new Point(495,609));listpt.Add(new Point(516,609));listpt.Add(new Point(538,630));listpt.Add(new Point(532,657));listpt.Add(new Point(522,667));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}