using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5FlexibleTube
{
    public class PIXIE_508c7d74_e67d_48f4_8c15_ee38a336dc2b : Pixie
    {
        public PIXIE_508c7d74_e67d_48f4_8c15_ee38a336dc2b()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 935f; _h = 971f;
_content = "var arrFillColor = new Array(8); var arrBorderColor = new Array(8); var arrBorderWidth = new Array(8); arrFillColor[0] = '#ccc'; arrFillColor[1] = '#ccc'; arrFillColor[2] = '#ccc'; arrFillColor[3] = '#ccc'; arrFillColor[4] = '#ccc'; arrFillColor[5] = '#ccc'; arrFillColor[6] = '#ccc'; arrFillColor[7] = '#ccc'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderColor[6] = '#000'; arrBorderColor[7] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; arrBorderWidth[6] = '2'; arrBorderWidth[7] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(935,971);ctx.lineTo(935,918);ctx.lineTo(197,918);ctx.lineTo(197,971);ctx.lineTo(935,971);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(190,856);ctx.lineTo(195,907);ctx.lineTo(929,829);ctx.lineTo(924,778);ctx.lineTo(190,856);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(176,793);ctx.lineTo(188,846);ctx.lineTo(910,692);ctx.lineTo(899,641);ctx.lineTo(176,793);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(160,735);ctx.lineTo(175,786);ctx.lineTo(878,557);ctx.lineTo(862,506);ctx.lineTo(160,735);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(135,678);ctx.lineTo(156,727);ctx.lineTo(831,426);ctx.lineTo(809,378);ctx.lineTo(135,678);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(103,623);ctx.lineTo(129,671);ctx.lineTo(771,301);ctx.lineTo(745,256);ctx.lineTo(103,623);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(69,575);ctx.lineTo(99,616);ctx.lineTo(697,182);ctx.lineTo(665,139);ctx.lineTo(69,575);ctx.fillStyle = arrFillColor[6];ctx.fill();ctx.lineWidth = arrBorderWidth[6];ctx.strokeStyle = arrBorderColor[6];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(27,527);ctx.lineTo(63,567);ctx.lineTo(612,73);ctx.lineTo(577,33);ctx.lineTo(27,527);ctx.fillStyle = arrFillColor[7];ctx.fill();ctx.lineWidth = arrBorderWidth[7];ctx.strokeStyle = arrBorderColor[7];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(935,971));listpt.Add(new Point(935,918));listpt.Add(new Point(197,918));listpt.Add(new Point(197,971));listpt.Add(new Point(935,971));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(190,856));listpt.Add(new Point(195,907));listpt.Add(new Point(929,829));listpt.Add(new Point(924,778));listpt.Add(new Point(190,856));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(176,793));listpt.Add(new Point(188,846));listpt.Add(new Point(910,692));listpt.Add(new Point(899,641));listpt.Add(new Point(176,793));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(160,735));listpt.Add(new Point(175,786));listpt.Add(new Point(878,557));listpt.Add(new Point(862,506));listpt.Add(new Point(160,735));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(135,678));listpt.Add(new Point(156,727));listpt.Add(new Point(831,426));listpt.Add(new Point(809,378));listpt.Add(new Point(135,678));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(103,623));listpt.Add(new Point(129,671));listpt.Add(new Point(771,301));listpt.Add(new Point(745,256));listpt.Add(new Point(103,623));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(69,575));listpt.Add(new Point(99,616));listpt.Add(new Point(697,182));listpt.Add(new Point(665,139));listpt.Add(new Point(69,575));sb = new SolidBrush(_listfillcolor[6]);p = new Pen(Color.Black);p.Width = _listborderwidth[6];p.Color = _listbordercolor[6];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(27,527));listpt.Add(new Point(63,567));listpt.Add(new Point(612,73));listpt.Add(new Point(577,33));listpt.Add(new Point(27,527));sb = new SolidBrush(_listfillcolor[7]);p = new Pen(Color.Black);p.Width = _listborderwidth[7];p.Color = _listbordercolor[7];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}