using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Building
{
    public class PIXIE_bc6e9bcb_bca5_4d61_8429_27ccd7cb4b5a : Pixie
    {
        public PIXIE_bc6e9bcb_bca5_4d61_8429_27ccd7cb4b5a()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#ccb299"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#997f66"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ffe5cc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b89e85"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b89e85"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#997f66"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#997f66"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#997f66"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#997f66"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#997f66"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#997f66"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#997f66"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#997f66"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#856b52"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#856b52"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#664c33"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#664c33"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#664c33"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#664c33"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#664c33"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#664c33"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#664c33"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#664c33"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#664c33"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#664c33"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccb299"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccb299"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#997f66"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#997f66"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 838f;
_content = "var arrFillColor = new Array(29); var arrBorderColor = new Array(29); var arrBorderWidth = new Array(29); arrFillColor[0] = '#ccb299'; arrFillColor[1] = '#997f66'; arrFillColor[2] = '#ffe5cc'; arrFillColor[3] = '#b89e85'; arrFillColor[4] = '#b89e85'; arrFillColor[5] = '#997f66'; arrFillColor[6] = '#997f66'; arrFillColor[7] = '#997f66'; arrFillColor[8] = '#997f66'; arrFillColor[9] = '#997f66'; arrFillColor[10] = '#997f66'; arrFillColor[11] = '#997f66'; arrFillColor[12] = '#997f66'; arrFillColor[13] = '#856b52'; arrFillColor[14] = '#856b52'; arrFillColor[15] = '#664c33'; arrFillColor[16] = '#664c33'; arrFillColor[17] = '#664c33'; arrFillColor[18] = '#664c33'; arrFillColor[19] = '#664c33'; arrFillColor[20] = '#664c33'; arrFillColor[21] = '#664c33'; arrFillColor[22] = '#664c33'; arrFillColor[23] = '#664c33'; arrFillColor[24] = '#664c33'; arrFillColor[25] = '#ccb299'; arrFillColor[26] = '#ccb299'; arrFillColor[27] = '#997f66'; arrFillColor[28] = '#997f66'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderColor[6] = '#000'; arrBorderColor[7] = '#000'; arrBorderColor[8] = '#000'; arrBorderColor[9] = '#000'; arrBorderColor[10] = '#000'; arrBorderColor[11] = '#000'; arrBorderColor[12] = '#000'; arrBorderColor[13] = '#000'; arrBorderColor[14] = '#000'; arrBorderColor[15] = '#000'; arrBorderColor[16] = '#000'; arrBorderColor[17] = '#000'; arrBorderColor[18] = '#000'; arrBorderColor[19] = '#000'; arrBorderColor[20] = '#000'; arrBorderColor[21] = '#000'; arrBorderColor[22] = '#000'; arrBorderColor[23] = '#000'; arrBorderColor[24] = '#000'; arrBorderColor[25] = '#000'; arrBorderColor[26] = '#000'; arrBorderColor[27] = '#000'; arrBorderColor[28] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; arrBorderWidth[6] = '2'; arrBorderWidth[7] = '2'; arrBorderWidth[8] = '2'; arrBorderWidth[9] = '2'; arrBorderWidth[10] = '2'; arrBorderWidth[11] = '2'; arrBorderWidth[12] = '2'; arrBorderWidth[13] = '2'; arrBorderWidth[14] = '2'; arrBorderWidth[15] = '2'; arrBorderWidth[16] = '2'; arrBorderWidth[17] = '2'; arrBorderWidth[18] = '2'; arrBorderWidth[19] = '2'; arrBorderWidth[20] = '2'; arrBorderWidth[21] = '2'; arrBorderWidth[22] = '2'; arrBorderWidth[23] = '2'; arrBorderWidth[24] = '2'; arrBorderWidth[25] = '2'; arrBorderWidth[26] = '2'; arrBorderWidth[27] = '2'; arrBorderWidth[28] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,838);ctx.lineTo(28,445);ctx.lineTo(813,445);ctx.lineTo(813,838);ctx.lineTo(28,838);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(970,759);ctx.lineTo(970,366);ctx.lineTo(813,445);ctx.lineTo(813,838);ctx.lineTo(970,759);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,445);ctx.lineTo(126,396);ctx.lineTo(558,396);ctx.lineTo(617,366);ctx.lineTo(970,366);ctx.lineTo(813,445);ctx.lineTo(28,445);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,749);ctx.lineTo(28,671);ctx.lineTo(813,671);ctx.lineTo(813,749);ctx.lineTo(28,749);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,592);ctx.lineTo(28,514);ctx.lineTo(813,514);ctx.lineTo(813,592);ctx.lineTo(28,592);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(617,592);ctx.lineTo(617,514);ctx.lineTo(754,514);ctx.lineTo(754,592);ctx.lineTo(617,592);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(440,592);ctx.lineTo(440,514);ctx.lineTo(578,514);ctx.lineTo(578,592);ctx.lineTo(440,592);ctx.fillStyle = arrFillColor[6];ctx.fill();ctx.lineWidth = arrBorderWidth[6];ctx.strokeStyle = arrBorderColor[6];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(264,592);ctx.lineTo(264,514);ctx.lineTo(401,514);ctx.lineTo(401,592);ctx.lineTo(264,592);ctx.fillStyle = arrFillColor[7];ctx.fill();ctx.lineWidth = arrBorderWidth[7];ctx.strokeStyle = arrBorderColor[7];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(87,592);ctx.lineTo(87,514);ctx.lineTo(224,514);ctx.lineTo(224,592);ctx.lineTo(87,592);ctx.fillStyle = arrFillColor[8];ctx.fill();ctx.lineWidth = arrBorderWidth[8];ctx.strokeStyle = arrBorderColor[8];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(87,749);ctx.lineTo(87,671);ctx.lineTo(224,671);ctx.lineTo(224,749);ctx.lineTo(87,749);ctx.fillStyle = arrFillColor[9];ctx.fill();ctx.lineWidth = arrBorderWidth[9];ctx.strokeStyle = arrBorderColor[9];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(264,749);ctx.lineTo(264,671);ctx.lineTo(401,671);ctx.lineTo(401,749);ctx.lineTo(264,749);ctx.fillStyle = arrFillColor[10];ctx.fill();ctx.lineWidth = arrBorderWidth[10];ctx.strokeStyle = arrBorderColor[10];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(440,749);ctx.lineTo(440,671);ctx.lineTo(578,671);ctx.lineTo(578,749);ctx.lineTo(440,749);ctx.fillStyle = arrFillColor[11];ctx.fill();ctx.lineWidth = arrBorderWidth[11];ctx.strokeStyle = arrBorderColor[11];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(617,749);ctx.lineTo(617,671);ctx.lineTo(754,671);ctx.lineTo(754,749);ctx.lineTo(617,749);ctx.fillStyle = arrFillColor[12];ctx.fill();ctx.lineWidth = arrBorderWidth[12];ctx.strokeStyle = arrBorderColor[12];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(970,509);ctx.lineTo(970,431);ctx.lineTo(813,514);ctx.lineTo(813,592);ctx.lineTo(970,509);ctx.fillStyle = arrFillColor[13];ctx.fill();ctx.lineWidth = arrBorderWidth[13];ctx.strokeStyle = arrBorderColor[13];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(970,666);ctx.lineTo(970,588);ctx.lineTo(813,671);ctx.lineTo(813,749);ctx.lineTo(970,666);ctx.fillStyle = arrFillColor[14];ctx.fill();ctx.lineWidth = arrBorderWidth[14];ctx.strokeStyle = arrBorderColor[14];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(852,729);ctx.lineTo(852,650);ctx.lineTo(825,665);ctx.lineTo(825,743);ctx.lineTo(852,729);ctx.fillStyle = arrFillColor[15];ctx.fill();ctx.lineWidth = arrBorderWidth[15];ctx.strokeStyle = arrBorderColor[15];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(888,710);ctx.lineTo(888,631);ctx.lineTo(860,646);ctx.lineTo(860,725);ctx.lineTo(888,710);ctx.fillStyle = arrFillColor[16];ctx.fill();ctx.lineWidth = arrBorderWidth[16];ctx.strokeStyle = arrBorderColor[16];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(923,691);ctx.lineTo(923,613);ctx.lineTo(895,627);ctx.lineTo(895,706);ctx.lineTo(923,691);ctx.fillStyle = arrFillColor[17];ctx.fill();ctx.lineWidth = arrBorderWidth[17];ctx.strokeStyle = arrBorderColor[17];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(958,672);ctx.lineTo(958,594);ctx.lineTo(931,609);ctx.lineTo(931,687);ctx.lineTo(958,672);ctx.fillStyle = arrFillColor[18];ctx.fill();ctx.lineWidth = arrBorderWidth[18];ctx.strokeStyle = arrBorderColor[18];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(958,515);ctx.lineTo(958,437);ctx.lineTo(931,452);ctx.lineTo(931,530);ctx.lineTo(958,515);ctx.fillStyle = arrFillColor[19];ctx.fill();ctx.lineWidth = arrBorderWidth[19];ctx.strokeStyle = arrBorderColor[19];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(923,534);ctx.lineTo(923,456);ctx.lineTo(895,470);ctx.lineTo(895,549);ctx.lineTo(923,534);ctx.fillStyle = arrFillColor[20];ctx.fill();ctx.lineWidth = arrBorderWidth[20];ctx.strokeStyle = arrBorderColor[20];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(888,553);ctx.lineTo(888,474);ctx.lineTo(860,489);ctx.lineTo(860,567);ctx.lineTo(888,553);ctx.fillStyle = arrFillColor[21];ctx.fill();ctx.lineWidth = arrBorderWidth[21];ctx.strokeStyle = arrBorderColor[21];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(852,572);ctx.lineTo(852,493);ctx.lineTo(825,507);ctx.lineTo(825,586);ctx.lineTo(852,572);ctx.fillStyle = arrFillColor[22];ctx.fill();ctx.lineWidth = arrBorderWidth[22];ctx.strokeStyle = arrBorderColor[22];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(244,32);ctx.lineTo(254,28);ctx.lineTo(214,28);ctx.lineTo(205,32);ctx.lineTo(244,32);ctx.fillStyle = arrFillColor[23];ctx.fill();ctx.lineWidth = arrBorderWidth[23];ctx.strokeStyle = arrBorderColor[23];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(425,32);ctx.lineTo(435,28);ctx.lineTo(396,28);ctx.lineTo(386,32);ctx.lineTo(425,32);ctx.fillStyle = arrFillColor[24];ctx.fill();ctx.lineWidth = arrBorderWidth[24];ctx.strokeStyle = arrBorderColor[24];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(381,425);ctx.lineTo(386,32);ctx.lineTo(425,32);ctx.lineTo(430,425);ctx.lineTo(381,425);ctx.fillStyle = arrFillColor[25];ctx.fill();ctx.lineWidth = arrBorderWidth[25];ctx.strokeStyle = arrBorderColor[25];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(200,425);ctx.lineTo(205,32);ctx.lineTo(244,32);ctx.lineTo(249,425);ctx.lineTo(200,425);ctx.fillStyle = arrFillColor[26];ctx.fill();ctx.lineWidth = arrBorderWidth[26];ctx.strokeStyle = arrBorderColor[26];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(430,425);ctx.lineTo(425,32);ctx.lineTo(435,28);ctx.lineTo(445,415);ctx.lineTo(430,425);ctx.fillStyle = arrFillColor[27];ctx.fill();ctx.lineWidth = arrBorderWidth[27];ctx.strokeStyle = arrBorderColor[27];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(249,425);ctx.lineTo(244,32);ctx.lineTo(254,28);ctx.lineTo(263,415);ctx.lineTo(249,425);ctx.fillStyle = arrFillColor[28];ctx.fill();ctx.lineWidth = arrBorderWidth[28];ctx.strokeStyle = arrBorderColor[28];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,838));listpt.Add(new Point(28,445));listpt.Add(new Point(813,445));listpt.Add(new Point(813,838));listpt.Add(new Point(28,838));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(970,759));listpt.Add(new Point(970,366));listpt.Add(new Point(813,445));listpt.Add(new Point(813,838));listpt.Add(new Point(970,759));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,445));listpt.Add(new Point(126,396));listpt.Add(new Point(558,396));listpt.Add(new Point(617,366));listpt.Add(new Point(970,366));listpt.Add(new Point(813,445));listpt.Add(new Point(28,445));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,749));listpt.Add(new Point(28,671));listpt.Add(new Point(813,671));listpt.Add(new Point(813,749));listpt.Add(new Point(28,749));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,592));listpt.Add(new Point(28,514));listpt.Add(new Point(813,514));listpt.Add(new Point(813,592));listpt.Add(new Point(28,592));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(617,592));listpt.Add(new Point(617,514));listpt.Add(new Point(754,514));listpt.Add(new Point(754,592));listpt.Add(new Point(617,592));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(440,592));listpt.Add(new Point(440,514));listpt.Add(new Point(578,514));listpt.Add(new Point(578,592));listpt.Add(new Point(440,592));sb = new SolidBrush(_listfillcolor[6]);p = new Pen(Color.Black);p.Width = _listborderwidth[6];p.Color = _listbordercolor[6];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(264,592));listpt.Add(new Point(264,514));listpt.Add(new Point(401,514));listpt.Add(new Point(401,592));listpt.Add(new Point(264,592));sb = new SolidBrush(_listfillcolor[7]);p = new Pen(Color.Black);p.Width = _listborderwidth[7];p.Color = _listbordercolor[7];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(87,592));listpt.Add(new Point(87,514));listpt.Add(new Point(224,514));listpt.Add(new Point(224,592));listpt.Add(new Point(87,592));sb = new SolidBrush(_listfillcolor[8]);p = new Pen(Color.Black);p.Width = _listborderwidth[8];p.Color = _listbordercolor[8];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(87,749));listpt.Add(new Point(87,671));listpt.Add(new Point(224,671));listpt.Add(new Point(224,749));listpt.Add(new Point(87,749));sb = new SolidBrush(_listfillcolor[9]);p = new Pen(Color.Black);p.Width = _listborderwidth[9];p.Color = _listbordercolor[9];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(264,749));listpt.Add(new Point(264,671));listpt.Add(new Point(401,671));listpt.Add(new Point(401,749));listpt.Add(new Point(264,749));sb = new SolidBrush(_listfillcolor[10]);p = new Pen(Color.Black);p.Width = _listborderwidth[10];p.Color = _listbordercolor[10];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(440,749));listpt.Add(new Point(440,671));listpt.Add(new Point(578,671));listpt.Add(new Point(578,749));listpt.Add(new Point(440,749));sb = new SolidBrush(_listfillcolor[11]);p = new Pen(Color.Black);p.Width = _listborderwidth[11];p.Color = _listbordercolor[11];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(617,749));listpt.Add(new Point(617,671));listpt.Add(new Point(754,671));listpt.Add(new Point(754,749));listpt.Add(new Point(617,749));sb = new SolidBrush(_listfillcolor[12]);p = new Pen(Color.Black);p.Width = _listborderwidth[12];p.Color = _listbordercolor[12];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(970,509));listpt.Add(new Point(970,431));listpt.Add(new Point(813,514));listpt.Add(new Point(813,592));listpt.Add(new Point(970,509));sb = new SolidBrush(_listfillcolor[13]);p = new Pen(Color.Black);p.Width = _listborderwidth[13];p.Color = _listbordercolor[13];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(970,666));listpt.Add(new Point(970,588));listpt.Add(new Point(813,671));listpt.Add(new Point(813,749));listpt.Add(new Point(970,666));sb = new SolidBrush(_listfillcolor[14]);p = new Pen(Color.Black);p.Width = _listborderwidth[14];p.Color = _listbordercolor[14];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(852,729));listpt.Add(new Point(852,650));listpt.Add(new Point(825,665));listpt.Add(new Point(825,743));listpt.Add(new Point(852,729));sb = new SolidBrush(_listfillcolor[15]);p = new Pen(Color.Black);p.Width = _listborderwidth[15];p.Color = _listbordercolor[15];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(888,710));listpt.Add(new Point(888,631));listpt.Add(new Point(860,646));listpt.Add(new Point(860,725));listpt.Add(new Point(888,710));sb = new SolidBrush(_listfillcolor[16]);p = new Pen(Color.Black);p.Width = _listborderwidth[16];p.Color = _listbordercolor[16];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(923,691));listpt.Add(new Point(923,613));listpt.Add(new Point(895,627));listpt.Add(new Point(895,706));listpt.Add(new Point(923,691));sb = new SolidBrush(_listfillcolor[17]);p = new Pen(Color.Black);p.Width = _listborderwidth[17];p.Color = _listbordercolor[17];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(958,672));listpt.Add(new Point(958,594));listpt.Add(new Point(931,609));listpt.Add(new Point(931,687));listpt.Add(new Point(958,672));sb = new SolidBrush(_listfillcolor[18]);p = new Pen(Color.Black);p.Width = _listborderwidth[18];p.Color = _listbordercolor[18];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(958,515));listpt.Add(new Point(958,437));listpt.Add(new Point(931,452));listpt.Add(new Point(931,530));listpt.Add(new Point(958,515));sb = new SolidBrush(_listfillcolor[19]);p = new Pen(Color.Black);p.Width = _listborderwidth[19];p.Color = _listbordercolor[19];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(923,534));listpt.Add(new Point(923,456));listpt.Add(new Point(895,470));listpt.Add(new Point(895,549));listpt.Add(new Point(923,534));sb = new SolidBrush(_listfillcolor[20]);p = new Pen(Color.Black);p.Width = _listborderwidth[20];p.Color = _listbordercolor[20];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(888,553));listpt.Add(new Point(888,474));listpt.Add(new Point(860,489));listpt.Add(new Point(860,567));listpt.Add(new Point(888,553));sb = new SolidBrush(_listfillcolor[21]);p = new Pen(Color.Black);p.Width = _listborderwidth[21];p.Color = _listbordercolor[21];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(852,572));listpt.Add(new Point(852,493));listpt.Add(new Point(825,507));listpt.Add(new Point(825,586));listpt.Add(new Point(852,572));sb = new SolidBrush(_listfillcolor[22]);p = new Pen(Color.Black);p.Width = _listborderwidth[22];p.Color = _listbordercolor[22];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(244,32));listpt.Add(new Point(254,28));listpt.Add(new Point(214,28));listpt.Add(new Point(205,32));listpt.Add(new Point(244,32));sb = new SolidBrush(_listfillcolor[23]);p = new Pen(Color.Black);p.Width = _listborderwidth[23];p.Color = _listbordercolor[23];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(425,32));listpt.Add(new Point(435,28));listpt.Add(new Point(396,28));listpt.Add(new Point(386,32));listpt.Add(new Point(425,32));sb = new SolidBrush(_listfillcolor[24]);p = new Pen(Color.Black);p.Width = _listborderwidth[24];p.Color = _listbordercolor[24];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(381,425));listpt.Add(new Point(386,32));listpt.Add(new Point(425,32));listpt.Add(new Point(430,425));listpt.Add(new Point(381,425));sb = new SolidBrush(_listfillcolor[25]);p = new Pen(Color.Black);p.Width = _listborderwidth[25];p.Color = _listbordercolor[25];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(200,425));listpt.Add(new Point(205,32));listpt.Add(new Point(244,32));listpt.Add(new Point(249,425));listpt.Add(new Point(200,425));sb = new SolidBrush(_listfillcolor[26]);p = new Pen(Color.Black);p.Width = _listborderwidth[26];p.Color = _listbordercolor[26];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(430,425));listpt.Add(new Point(425,32));listpt.Add(new Point(435,28));listpt.Add(new Point(445,415));listpt.Add(new Point(430,425));sb = new SolidBrush(_listfillcolor[27]);p = new Pen(Color.Black);p.Width = _listborderwidth[27];p.Color = _listbordercolor[27];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(249,425));listpt.Add(new Point(244,32));listpt.Add(new Point(254,28));listpt.Add(new Point(263,415));listpt.Add(new Point(249,425));sb = new SolidBrush(_listfillcolor[28]);p = new Pen(Color.Black);p.Width = _listborderwidth[28];p.Color = _listbordercolor[28];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}