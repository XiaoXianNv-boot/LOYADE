using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Finishing
{
    public class PIXIE_4464c968_b047_4b88_a4ae_9bbc651b28ee : Pixie
    {
        public PIXIE_4464c968_b047_4b88_a4ae_9bbc651b28ee()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#00f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#00f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#00f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#00f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0000ad"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0000ad"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listfillcolor.Add(ColorTranslator.FromHtml("#66f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#70707f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#00f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listfillcolor.Add(ColorTranslator.FromHtml("#e0e0e0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f0f0f0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0000e0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0000e0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 755f;
_content = "var arrFillColor = new Array(26); var arrBorderColor = new Array(26); var arrBorderWidth = new Array(26); arrFillColor[0] = '#00f'; arrFillColor[1] = '#00f'; arrFillColor[2] = '#00f'; arrFillColor[3] = '#00f'; arrFillColor[4] = '#0000ad'; arrFillColor[5] = '#0000ad'; arrFillColor[6] = '#66f'; arrFillColor[7] = '#70707f'; arrFillColor[8] = '#000'; arrFillColor[9] = '#00f'; arrFillColor[10] = '#b2b2b2'; arrFillColor[11] = '#b2b2b2'; arrFillColor[12] = '#b2b2b2'; arrFillColor[13] = '#b2b2b2'; arrFillColor[14] = '#b2b2b2'; arrFillColor[15] = '#e0e0e0'; arrFillColor[16] = '#f0f0f0'; arrFillColor[17] = '#000'; arrFillColor[18] = '#000'; arrFillColor[19] = '#000'; arrFillColor[20] = '#000'; arrFillColor[21] = '#000'; arrFillColor[22] = '#000'; arrFillColor[23] = '#fff'; arrFillColor[24] = '#0000e0'; arrFillColor[25] = '#0000e0'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#7f7f7f'; arrBorderColor[6] = '#000'; arrBorderColor[7] = '#000'; arrBorderColor[8] = '#000'; arrBorderColor[9] = '#000'; arrBorderColor[10] = '#7f7f7f'; arrBorderColor[11] = '#7f7f7f'; arrBorderColor[12] = '#7f7f7f'; arrBorderColor[13] = '#7f7f7f'; arrBorderColor[14] = '#7f7f7f'; arrBorderColor[15] = '#000'; arrBorderColor[16] = '#000'; arrBorderColor[17] = '#000'; arrBorderColor[18] = '#000'; arrBorderColor[19] = '#000'; arrBorderColor[20] = '#000'; arrBorderColor[21] = '#000'; arrBorderColor[22] = '#000'; arrBorderColor[23] = '#000'; arrBorderColor[24] = '#000'; arrBorderColor[25] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; arrBorderWidth[6] = '2'; arrBorderWidth[7] = '2'; arrBorderWidth[8] = '2'; arrBorderWidth[9] = '2'; arrBorderWidth[10] = '2'; arrBorderWidth[11] = '2'; arrBorderWidth[12] = '2'; arrBorderWidth[13] = '2'; arrBorderWidth[14] = '2'; arrBorderWidth[15] = '2'; arrBorderWidth[16] = '2'; arrBorderWidth[17] = '2'; arrBorderWidth[18] = '2'; arrBorderWidth[19] = '2'; arrBorderWidth[20] = '2'; arrBorderWidth[21] = '2'; arrBorderWidth[22] = '2'; arrBorderWidth[23] = '2'; arrBorderWidth[24] = '2'; arrBorderWidth[25] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(923,712);ctx.lineTo(917,718);ctx.lineTo(917,755);ctx.lineTo(923,749);ctx.lineTo(923,712);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(75,670);ctx.lineTo(964,670);ctx.lineTo(964,708);ctx.lineTo(75,708);ctx.lineTo(75,670);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(964,670);ctx.lineTo(970,664);ctx.lineTo(970,701);ctx.lineTo(964,708);ctx.lineTo(964,670);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,718);ctx.lineTo(917,718);ctx.lineTo(917,755);ctx.lineTo(28,755);ctx.lineTo(28,718);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,718);ctx.lineTo(917,718);ctx.lineTo(970,664);ctx.lineTo(81,664);ctx.lineTo(28,718);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(666,445);ctx.lineTo(681,447);ctx.lineTo(751,447);ctx.lineTo(761,445);ctx.lineTo(765,445);ctx.lineTo(765,441);ctx.lineTo(757,437);ctx.lineTo(745,432);ctx.lineTo(736,432);ctx.lineTo(726,430);ctx.lineTo(705,430);ctx.lineTo(697,432);ctx.lineTo(689,432);ctx.lineTo(681,434);ctx.lineTo(670,438);ctx.lineTo(666,445);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(794,389);ctx.lineTo(788,391);ctx.lineTo(771,393);ctx.lineTo(746,395);ctx.lineTo(716,395);ctx.lineTo(685,395);ctx.lineTo(660,393);ctx.lineTo(644,391);ctx.lineTo(637,389);ctx.lineTo(637,383);ctx.lineTo(644,385);ctx.lineTo(660,387);ctx.lineTo(685,387);ctx.lineTo(716,389);ctx.lineTo(746,387);ctx.lineTo(771,387);ctx.lineTo(788,385);ctx.lineTo(794,383);ctx.lineTo(794,389);ctx.fillStyle = arrFillColor[6];ctx.fill();ctx.lineWidth = arrBorderWidth[6];ctx.strokeStyle = arrBorderColor[6];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(15.6,1);ctx.arc(45.83333,33,5,0,Math.PI*2,true);ctx.scale(0.06410256,1);ctx.fillStyle = arrFillColor[7];ctx.fill();ctx.lineWidth = arrBorderWidth[7];ctx.strokeStyle = arrBorderColor[7];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(10,1);ctx.arc(71.5,436,2,0,Math.PI*2,true);ctx.scale(0.1,1);ctx.fillStyle = arrFillColor[8];ctx.fill();ctx.lineWidth = arrBorderWidth[8];ctx.strokeStyle = arrBorderColor[8];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(617,57);ctx.lineTo(636,57);ctx.lineTo(636,699);ctx.lineTo(617,699);ctx.lineTo(617,57);ctx.fillStyle = arrFillColor[9];ctx.fill();ctx.lineWidth = arrBorderWidth[9];ctx.strokeStyle = arrBorderColor[9];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(679,586);ctx.lineTo(701,590);ctx.lineTo(720,603);ctx.lineTo(732,621);ctx.lineTo(738,644);ctx.lineTo(732,666);ctx.lineTo(716,689);ctx.lineTo(633,609);ctx.lineTo(658,590);ctx.lineTo(679,586);ctx.fillStyle = arrFillColor[10];ctx.fill();ctx.lineWidth = arrBorderWidth[10];ctx.strokeStyle = arrBorderColor[10];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(1,1.035088);ctx.arc(674,627,57,0,Math.PI*2,true);ctx.scale(1,0.9661017);ctx.fillStyle = arrFillColor[11];ctx.fill();ctx.lineWidth = arrBorderWidth[11];ctx.strokeStyle = arrBorderColor[11];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(674,649,41,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[12];ctx.fill();ctx.lineWidth = arrBorderWidth[12];ctx.strokeStyle = arrBorderColor[12];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(1,1.083333);ctx.arc(674,599.0769,24,0,Math.PI*2,true);ctx.scale(1,0.9230769);ctx.fillStyle = arrFillColor[13];ctx.fill();ctx.lineWidth = arrBorderWidth[13];ctx.strokeStyle = arrBorderColor[13];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(675,642);ctx.lineTo(679,644);ctx.lineTo(683,650);ctx.lineTo(679,654);ctx.lineTo(675,656);ctx.lineTo(669,654);ctx.lineTo(666,650);ctx.lineTo(669,644);ctx.lineTo(675,642);ctx.fillStyle = arrFillColor[14];ctx.fill();ctx.lineWidth = arrBorderWidth[14];ctx.strokeStyle = arrBorderColor[14];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(356,430);ctx.lineTo(313,475);ctx.lineTo(313,713);ctx.lineTo(356,669);ctx.lineTo(356,430);ctx.fillStyle = arrFillColor[15];ctx.fill();ctx.lineWidth = arrBorderWidth[15];ctx.strokeStyle = arrBorderColor[15];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(58,475);ctx.lineTo(313,475);ctx.lineTo(356,430);ctx.lineTo(104,430);ctx.lineTo(58,475);ctx.fillStyle = arrFillColor[16];ctx.fill();ctx.lineWidth = arrBorderWidth[16];ctx.strokeStyle = arrBorderColor[16];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(89,502);ctx.lineTo(100,506);ctx.lineTo(104,517);ctx.lineTo(100,527);ctx.lineTo(89,529);ctx.lineTo(79,527);ctx.lineTo(75,517);ctx.lineTo(79,506);ctx.lineTo(89,502);ctx.fillStyle = arrFillColor[17];ctx.fill();ctx.lineWidth = arrBorderWidth[17];ctx.strokeStyle = arrBorderColor[17];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(151,502);ctx.lineTo(161,506);ctx.lineTo(165,517);ctx.lineTo(161,527);ctx.lineTo(151,529);ctx.lineTo(141,527);ctx.lineTo(137,517);ctx.lineTo(141,506);ctx.lineTo(151,502);ctx.fillStyle = arrFillColor[18];ctx.fill();ctx.lineWidth = arrBorderWidth[18];ctx.strokeStyle = arrBorderColor[18];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(214,502);ctx.lineTo(225,506);ctx.lineTo(229,517);ctx.lineTo(225,527);ctx.lineTo(214,529);ctx.lineTo(206,527);ctx.lineTo(202,517);ctx.lineTo(206,506);ctx.lineTo(214,502);ctx.fillStyle = arrFillColor[19];ctx.fill();ctx.lineWidth = arrBorderWidth[19];ctx.strokeStyle = arrBorderColor[19];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(280,502);ctx.lineTo(270,506);ctx.lineTo(266,517);ctx.lineTo(270,527);ctx.lineTo(280,529);ctx.lineTo(289,527);ctx.lineTo(293,517);ctx.lineTo(289,506);ctx.lineTo(280,502);ctx.fillStyle = arrFillColor[20];ctx.fill();ctx.lineWidth = arrBorderWidth[20];ctx.strokeStyle = arrBorderColor[20];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(163,644);ctx.lineTo(155,648);ctx.lineTo(151,658);ctx.lineTo(155,666);ctx.lineTo(163,670);ctx.lineTo(173,666);ctx.lineTo(177,658);ctx.lineTo(173,648);ctx.lineTo(163,644);ctx.fillStyle = arrFillColor[21];ctx.fill();ctx.lineWidth = arrBorderWidth[21];ctx.strokeStyle = arrBorderColor[21];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(210,644);ctx.lineTo(200,648);ctx.lineTo(196,658);ctx.lineTo(200,666);ctx.lineTo(210,670);ctx.lineTo(221,666);ctx.lineTo(223,658);ctx.lineTo(221,648);ctx.lineTo(210,644);ctx.fillStyle = arrFillColor[22];ctx.fill();ctx.lineWidth = arrBorderWidth[22];ctx.strokeStyle = arrBorderColor[22];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(159,564);ctx.lineTo(213,564);ctx.lineTo(209,584);ctx.lineTo(167,584);ctx.lineTo(159,564);ctx.fillStyle = arrFillColor[23];ctx.fill();ctx.lineWidth = arrBorderWidth[23];ctx.strokeStyle = arrBorderColor[23];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(812,299);ctx.lineTo(841,299);ctx.lineTo(841,687);ctx.lineTo(812,687);ctx.lineTo(812,299);ctx.fillStyle = arrFillColor[24];ctx.fill();ctx.lineWidth = arrBorderWidth[24];ctx.strokeStyle = arrBorderColor[24];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(911,325);ctx.lineTo(913,332);ctx.lineTo(913,387);ctx.lineTo(909,395);ctx.lineTo(908,397);ctx.lineTo(902,399);ctx.lineTo(865,399);ctx.lineTo(857,395);ctx.lineTo(856,394);ctx.lineTo(855,387);ctx.lineTo(855,325);ctx.lineTo(841,325);ctx.lineTo(841,416);ctx.lineTo(927,416);ctx.lineTo(927,325);ctx.lineTo(911,325);ctx.fillStyle = arrFillColor[25];ctx.fill();ctx.lineWidth = arrBorderWidth[25];ctx.strokeStyle = arrBorderColor[25];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(923,712));listpt.Add(new Point(917,718));listpt.Add(new Point(917,755));listpt.Add(new Point(923,749));listpt.Add(new Point(923,712));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(75,670));listpt.Add(new Point(964,670));listpt.Add(new Point(964,708));listpt.Add(new Point(75,708));listpt.Add(new Point(75,670));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(964,670));listpt.Add(new Point(970,664));listpt.Add(new Point(970,701));listpt.Add(new Point(964,708));listpt.Add(new Point(964,670));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,718));listpt.Add(new Point(917,718));listpt.Add(new Point(917,755));listpt.Add(new Point(28,755));listpt.Add(new Point(28,718));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,718));listpt.Add(new Point(917,718));listpt.Add(new Point(970,664));listpt.Add(new Point(81,664));listpt.Add(new Point(28,718));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(666,445));listpt.Add(new Point(681,447));listpt.Add(new Point(751,447));listpt.Add(new Point(761,445));listpt.Add(new Point(765,445));listpt.Add(new Point(765,441));listpt.Add(new Point(757,437));listpt.Add(new Point(745,432));listpt.Add(new Point(736,432));listpt.Add(new Point(726,430));listpt.Add(new Point(705,430));listpt.Add(new Point(697,432));listpt.Add(new Point(689,432));listpt.Add(new Point(681,434));listpt.Add(new Point(670,438));listpt.Add(new Point(666,445));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(794,389));listpt.Add(new Point(788,391));listpt.Add(new Point(771,393));listpt.Add(new Point(746,395));listpt.Add(new Point(716,395));listpt.Add(new Point(685,395));listpt.Add(new Point(660,393));listpt.Add(new Point(644,391));listpt.Add(new Point(637,389));listpt.Add(new Point(637,383));listpt.Add(new Point(644,385));listpt.Add(new Point(660,387));listpt.Add(new Point(685,387));listpt.Add(new Point(716,389));listpt.Add(new Point(746,387));listpt.Add(new Point(771,387));listpt.Add(new Point(788,385));listpt.Add(new Point(794,383));listpt.Add(new Point(794,389));sb = new SolidBrush(_listfillcolor[6]);p = new Pen(Color.Black);p.Width = _listborderwidth[6];p.Color = _listbordercolor[6];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[7]);p = new Pen(Color.Black);p.Width = _listborderwidth[7];p.Color = _listbordercolor[7];g.FillEllipse(sb, 40.83333f,28f,10f,10f);g.DrawEllipse(p, 40.83333f,28f,10f,10f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[8]);p = new Pen(Color.Black);p.Width = _listborderwidth[8];p.Color = _listbordercolor[8];g.FillEllipse(sb, 69.5f,434f,4f,4f);g.DrawEllipse(p, 69.5f,434f,4f,4f);
listpt = new List<Point>();listpt.Add(new Point(617,57));listpt.Add(new Point(636,57));listpt.Add(new Point(636,699));listpt.Add(new Point(617,699));listpt.Add(new Point(617,57));sb = new SolidBrush(_listfillcolor[9]);p = new Pen(Color.Black);p.Width = _listborderwidth[9];p.Color = _listbordercolor[9];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(679,586));listpt.Add(new Point(701,590));listpt.Add(new Point(720,603));listpt.Add(new Point(732,621));listpt.Add(new Point(738,644));listpt.Add(new Point(732,666));listpt.Add(new Point(716,689));listpt.Add(new Point(633,609));listpt.Add(new Point(658,590));listpt.Add(new Point(679,586));sb = new SolidBrush(_listfillcolor[10]);p = new Pen(Color.Black);p.Width = _listborderwidth[10];p.Color = _listbordercolor[10];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[11]);p = new Pen(Color.Black);p.Width = _listborderwidth[11];p.Color = _listbordercolor[11];g.FillEllipse(sb, 617f,568f,114f,118f);g.DrawEllipse(p, 617f,568f,114f,118f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[12]);p = new Pen(Color.Black);p.Width = _listborderwidth[12];p.Color = _listbordercolor[12];g.FillEllipse(sb, 633f,608f,82f,82f);g.DrawEllipse(p, 633f,608f,82f,82f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[13]);p = new Pen(Color.Black);p.Width = _listborderwidth[13];p.Color = _listbordercolor[13];g.FillEllipse(sb, 650f,573.0769f,48f,51.99998f);g.DrawEllipse(p, 650f,573.0769f,48f,51.99998f);
listpt = new List<Point>();listpt.Add(new Point(675,642));listpt.Add(new Point(679,644));listpt.Add(new Point(683,650));listpt.Add(new Point(679,654));listpt.Add(new Point(675,656));listpt.Add(new Point(669,654));listpt.Add(new Point(666,650));listpt.Add(new Point(669,644));listpt.Add(new Point(675,642));sb = new SolidBrush(_listfillcolor[14]);p = new Pen(Color.Black);p.Width = _listborderwidth[14];p.Color = _listbordercolor[14];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(356,430));listpt.Add(new Point(313,475));listpt.Add(new Point(313,713));listpt.Add(new Point(356,669));listpt.Add(new Point(356,430));sb = new SolidBrush(_listfillcolor[15]);p = new Pen(Color.Black);p.Width = _listborderwidth[15];p.Color = _listbordercolor[15];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(58,475));listpt.Add(new Point(313,475));listpt.Add(new Point(356,430));listpt.Add(new Point(104,430));listpt.Add(new Point(58,475));sb = new SolidBrush(_listfillcolor[16]);p = new Pen(Color.Black);p.Width = _listborderwidth[16];p.Color = _listbordercolor[16];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(89,502));listpt.Add(new Point(100,506));listpt.Add(new Point(104,517));listpt.Add(new Point(100,527));listpt.Add(new Point(89,529));listpt.Add(new Point(79,527));listpt.Add(new Point(75,517));listpt.Add(new Point(79,506));listpt.Add(new Point(89,502));sb = new SolidBrush(_listfillcolor[17]);p = new Pen(Color.Black);p.Width = _listborderwidth[17];p.Color = _listbordercolor[17];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(151,502));listpt.Add(new Point(161,506));listpt.Add(new Point(165,517));listpt.Add(new Point(161,527));listpt.Add(new Point(151,529));listpt.Add(new Point(141,527));listpt.Add(new Point(137,517));listpt.Add(new Point(141,506));listpt.Add(new Point(151,502));sb = new SolidBrush(_listfillcolor[18]);p = new Pen(Color.Black);p.Width = _listborderwidth[18];p.Color = _listbordercolor[18];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(214,502));listpt.Add(new Point(225,506));listpt.Add(new Point(229,517));listpt.Add(new Point(225,527));listpt.Add(new Point(214,529));listpt.Add(new Point(206,527));listpt.Add(new Point(202,517));listpt.Add(new Point(206,506));listpt.Add(new Point(214,502));sb = new SolidBrush(_listfillcolor[19]);p = new Pen(Color.Black);p.Width = _listborderwidth[19];p.Color = _listbordercolor[19];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(280,502));listpt.Add(new Point(270,506));listpt.Add(new Point(266,517));listpt.Add(new Point(270,527));listpt.Add(new Point(280,529));listpt.Add(new Point(289,527));listpt.Add(new Point(293,517));listpt.Add(new Point(289,506));listpt.Add(new Point(280,502));sb = new SolidBrush(_listfillcolor[20]);p = new Pen(Color.Black);p.Width = _listborderwidth[20];p.Color = _listbordercolor[20];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(163,644));listpt.Add(new Point(155,648));listpt.Add(new Point(151,658));listpt.Add(new Point(155,666));listpt.Add(new Point(163,670));listpt.Add(new Point(173,666));listpt.Add(new Point(177,658));listpt.Add(new Point(173,648));listpt.Add(new Point(163,644));sb = new SolidBrush(_listfillcolor[21]);p = new Pen(Color.Black);p.Width = _listborderwidth[21];p.Color = _listbordercolor[21];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(210,644));listpt.Add(new Point(200,648));listpt.Add(new Point(196,658));listpt.Add(new Point(200,666));listpt.Add(new Point(210,670));listpt.Add(new Point(221,666));listpt.Add(new Point(223,658));listpt.Add(new Point(221,648));listpt.Add(new Point(210,644));sb = new SolidBrush(_listfillcolor[22]);p = new Pen(Color.Black);p.Width = _listborderwidth[22];p.Color = _listbordercolor[22];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(159,564));listpt.Add(new Point(213,564));listpt.Add(new Point(209,584));listpt.Add(new Point(167,584));listpt.Add(new Point(159,564));sb = new SolidBrush(_listfillcolor[23]);p = new Pen(Color.Black);p.Width = _listborderwidth[23];p.Color = _listbordercolor[23];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(812,299));listpt.Add(new Point(841,299));listpt.Add(new Point(841,687));listpt.Add(new Point(812,687));listpt.Add(new Point(812,299));sb = new SolidBrush(_listfillcolor[24]);p = new Pen(Color.Black);p.Width = _listborderwidth[24];p.Color = _listbordercolor[24];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(911,325));listpt.Add(new Point(913,332));listpt.Add(new Point(913,387));listpt.Add(new Point(909,395));listpt.Add(new Point(908,397));listpt.Add(new Point(902,399));listpt.Add(new Point(865,399));listpt.Add(new Point(857,395));listpt.Add(new Point(856,394));listpt.Add(new Point(855,387));listpt.Add(new Point(855,325));listpt.Add(new Point(841,325));listpt.Add(new Point(841,416));listpt.Add(new Point(927,416));listpt.Add(new Point(927,325));listpt.Add(new Point(911,325));sb = new SolidBrush(_listfillcolor[25]);p = new Pen(Color.Black);p.Width = _listborderwidth[25];p.Color = _listbordercolor[25];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}