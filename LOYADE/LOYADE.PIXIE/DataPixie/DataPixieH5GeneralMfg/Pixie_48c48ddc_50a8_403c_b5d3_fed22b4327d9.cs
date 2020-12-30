using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_48c48ddc_50a8_403c_b5d3_fed22b4327d9 : Pixie
    {
        public PIXIE_48c48ddc_50a8_403c_b5d3_fed22b4327d9()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#161717"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#161717"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#161717"));
_w = 194f; _h = 216f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrFillColor[2] = '#0ff'; arrBorderColor[0] = '#161717'; arrBorderColor[1] = '#161717'; arrBorderColor[2] = '#161717'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* circle */ ctx.arc(100,110,78,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(24,153);ctx.lineTo(20,148);ctx.lineTo(17,144);ctx.lineTo(13,139);ctx.lineTo(9,135);ctx.lineTo(8,141);ctx.lineTo(8,146);ctx.lineTo(7,152);ctx.lineTo(6,158);ctx.lineTo(10,153);ctx.lineTo(11,152);ctx.lineTo(12,156);ctx.lineTo(16,165);ctx.lineTo(23,177);ctx.lineTo(34,191);ctx.lineTo(49,203);ctx.lineTo(69,212);ctx.lineTo(95,216);ctx.lineTo(127,211);ctx.lineTo(125,205);ctx.lineTo(125,204);ctx.lineTo(96,209);ctx.lineTo(71,206);ctx.lineTo(52,198);ctx.lineTo(38,186);ctx.lineTo(27,174);ctx.lineTo(20,163);ctx.lineTo(17,154);ctx.lineTo(16,151);ctx.lineTo(18,152);ctx.lineTo(20,152);ctx.lineTo(22,153);ctx.lineTo(24,153);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(176,68);ctx.lineTo(180,72);ctx.lineTo(184,77);ctx.lineTo(187,81);ctx.lineTo(191,86);ctx.lineTo(192,80);ctx.lineTo(193,74);ctx.lineTo(193,69);ctx.lineTo(194,63);ctx.lineTo(192,66);ctx.lineTo(190,67);ctx.lineTo(189,69);ctx.lineTo(188,65);ctx.lineTo(184,56);ctx.lineTo(177,44);ctx.lineTo(166,30);ctx.lineTo(151,18);ctx.lineTo(130,9);ctx.lineTo(105,6);ctx.lineTo(73,10);ctx.lineTo(73,12);ctx.lineTo(75,16);ctx.lineTo(75,17);ctx.lineTo(104,13);ctx.lineTo(129,16);ctx.lineTo(148,24);ctx.lineTo(163,35);ctx.lineTo(173,47);ctx.lineTo(180,58);ctx.lineTo(183,67);ctx.lineTo(184,70);ctx.lineTo(182,69);ctx.lineTo(180,69);ctx.lineTo(178,68);ctx.lineTo(176,68);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillEllipse(sb, 22f,32f,156f,156f);g.DrawEllipse(p, 22f,32f,156f,156f);
listpt = new List<Point>();listpt.Add(new Point(24,153));listpt.Add(new Point(20,148));listpt.Add(new Point(17,144));listpt.Add(new Point(13,139));listpt.Add(new Point(9,135));listpt.Add(new Point(8,141));listpt.Add(new Point(8,146));listpt.Add(new Point(7,152));listpt.Add(new Point(6,158));listpt.Add(new Point(10,153));listpt.Add(new Point(11,152));listpt.Add(new Point(12,156));listpt.Add(new Point(16,165));listpt.Add(new Point(23,177));listpt.Add(new Point(34,191));listpt.Add(new Point(49,203));listpt.Add(new Point(69,212));listpt.Add(new Point(95,216));listpt.Add(new Point(127,211));listpt.Add(new Point(125,205));listpt.Add(new Point(125,204));listpt.Add(new Point(96,209));listpt.Add(new Point(71,206));listpt.Add(new Point(52,198));listpt.Add(new Point(38,186));listpt.Add(new Point(27,174));listpt.Add(new Point(20,163));listpt.Add(new Point(17,154));listpt.Add(new Point(16,151));listpt.Add(new Point(18,152));listpt.Add(new Point(20,152));listpt.Add(new Point(22,153));listpt.Add(new Point(24,153));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(176,68));listpt.Add(new Point(180,72));listpt.Add(new Point(184,77));listpt.Add(new Point(187,81));listpt.Add(new Point(191,86));listpt.Add(new Point(192,80));listpt.Add(new Point(193,74));listpt.Add(new Point(193,69));listpt.Add(new Point(194,63));listpt.Add(new Point(192,66));listpt.Add(new Point(190,67));listpt.Add(new Point(189,69));listpt.Add(new Point(188,65));listpt.Add(new Point(184,56));listpt.Add(new Point(177,44));listpt.Add(new Point(166,30));listpt.Add(new Point(151,18));listpt.Add(new Point(130,9));listpt.Add(new Point(105,6));listpt.Add(new Point(73,10));listpt.Add(new Point(73,12));listpt.Add(new Point(75,16));listpt.Add(new Point(75,17));listpt.Add(new Point(104,13));listpt.Add(new Point(129,16));listpt.Add(new Point(148,24));listpt.Add(new Point(163,35));listpt.Add(new Point(173,47));listpt.Add(new Point(180,58));listpt.Add(new Point(183,67));listpt.Add(new Point(184,70));listpt.Add(new Point(182,69));listpt.Add(new Point(180,69));listpt.Add(new Point(178,68));listpt.Add(new Point(176,68));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}