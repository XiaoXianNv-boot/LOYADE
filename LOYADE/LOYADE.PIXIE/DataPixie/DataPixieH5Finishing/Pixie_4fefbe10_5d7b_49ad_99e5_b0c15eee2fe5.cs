using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Finishing
{
    public class PIXIE_4fefbe10_5d7b_49ad_99e5_b0c15eee2fe5 : Pixie
    {
        public PIXIE_4fefbe10_5d7b_49ad_99e5_b0c15eee2fe5()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f0f0f0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f0f0f0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e0e0e0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e0e0e0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f0f0f0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f0f0f0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f0f0f0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f00"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f00"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0f0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f0f0f0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f0f0f0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 971f; _h = 763f;
_content = "var arrFillColor = new Array(25); var arrBorderColor = new Array(25); var arrBorderWidth = new Array(25); arrFillColor[0] = '#7f7f7f'; arrFillColor[1] = '#000'; arrFillColor[2] = '#000'; arrFillColor[3] = '#f0f0f0'; arrFillColor[4] = '#f0f0f0'; arrFillColor[5] = '#b2b2b2'; arrFillColor[6] = '#e0e0e0'; arrFillColor[7] = '#e0e0e0'; arrFillColor[8] = '#ccc'; arrFillColor[9] = '#ccc'; arrFillColor[10] = '#ccc'; arrFillColor[11] = '#ccc'; arrFillColor[12] = '#fff'; arrFillColor[13] = '#f0f0f0'; arrFillColor[14] = '#f0f0f0'; arrFillColor[15] = '#f0f0f0'; arrFillColor[16] = '#f00'; arrFillColor[17] = '#f00'; arrFillColor[18] = '#0f0'; arrFillColor[19] = '#b2b2b2'; arrFillColor[20] = '#f0f0f0'; arrFillColor[21] = '#7f7f7f'; arrFillColor[22] = '#000'; arrFillColor[23] = '#f0f0f0'; arrFillColor[24] = '#7f7f7f'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderColor[6] = '#000'; arrBorderColor[7] = '#000'; arrBorderColor[8] = '#000'; arrBorderColor[9] = '#000'; arrBorderColor[10] = '#000'; arrBorderColor[11] = '#000'; arrBorderColor[12] = '#000'; arrBorderColor[13] = '#000'; arrBorderColor[14] = '#000'; arrBorderColor[15] = '#000'; arrBorderColor[16] = '#000'; arrBorderColor[17] = '#000'; arrBorderColor[18] = '#000'; arrBorderColor[19] = '#000'; arrBorderColor[20] = '#000'; arrBorderColor[21] = '#000'; arrBorderColor[22] = '#000'; arrBorderColor[23] = '#000'; arrBorderColor[24] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; arrBorderWidth[6] = '2'; arrBorderWidth[7] = '2'; arrBorderWidth[8] = '2'; arrBorderWidth[9] = '2'; arrBorderWidth[10] = '2'; arrBorderWidth[11] = '2'; arrBorderWidth[12] = '2'; arrBorderWidth[13] = '2'; arrBorderWidth[14] = '2'; arrBorderWidth[15] = '2'; arrBorderWidth[16] = '2'; arrBorderWidth[17] = '2'; arrBorderWidth[18] = '2'; arrBorderWidth[19] = '2'; arrBorderWidth[20] = '2'; arrBorderWidth[21] = '2'; arrBorderWidth[22] = '2'; arrBorderWidth[23] = '2'; arrBorderWidth[24] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(186,500);ctx.lineTo(735,500);ctx.lineTo(735,763);ctx.lineTo(186,763);ctx.lineTo(186,500);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(186,500);ctx.lineTo(735,500);ctx.lineTo(888,349);ctx.lineTo(337,349);ctx.lineTo(186,500);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(888,349);ctx.lineTo(735,500);ctx.lineTo(735,763);ctx.lineTo(888,610);ctx.lineTo(888,349);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(27,417);ctx.lineTo(892,417);ctx.lineTo(892,494);ctx.lineTo(676,506);ctx.lineTo(243,506);ctx.lineTo(27,494);ctx.lineTo(27,417);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(27,417);ctx.lineTo(892,417);ctx.lineTo(971,339);ctx.lineTo(108,339);ctx.lineTo(27,417);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(892,494);ctx.lineTo(971,415);ctx.lineTo(971,339);ctx.lineTo(892,417);ctx.lineTo(892,494);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(199,180);ctx.lineTo(750,180);ctx.lineTo(750,441);ctx.lineTo(199,441);ctx.lineTo(199,180);ctx.fillStyle = arrFillColor[6];ctx.fill();ctx.lineWidth = arrBorderWidth[6];ctx.strokeStyle = arrBorderColor[6];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(199,180);ctx.lineTo(750,180);ctx.lineTo(901,27);ctx.lineTo(352,27);ctx.lineTo(199,180);ctx.fillStyle = arrFillColor[7];ctx.fill();ctx.lineWidth = arrBorderWidth[7];ctx.strokeStyle = arrBorderColor[7];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(901,29);ctx.lineTo(750,180);ctx.lineTo(750,441);ctx.lineTo(901,290);ctx.lineTo(901,29);ctx.fillStyle = arrFillColor[8];ctx.fill();ctx.lineWidth = arrBorderWidth[8];ctx.strokeStyle = arrBorderColor[8];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(178,197);ctx.lineTo(330,197);ctx.lineTo(330,509);ctx.lineTo(178,509);ctx.lineTo(178,197);ctx.fillStyle = arrFillColor[9];ctx.fill();ctx.lineWidth = arrBorderWidth[9];ctx.strokeStyle = arrBorderColor[9];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(178,197);ctx.lineTo(330,197);ctx.lineTo(352,176);ctx.lineTo(199,176);ctx.lineTo(178,197);ctx.fillStyle = arrFillColor[10];ctx.fill();ctx.lineWidth = arrBorderWidth[10];ctx.strokeStyle = arrBorderColor[10];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(352,176);ctx.lineTo(330,197);ctx.lineTo(330,509);ctx.lineTo(352,485);ctx.lineTo(352,176);ctx.fillStyle = arrFillColor[11];ctx.fill();ctx.lineWidth = arrBorderWidth[11];ctx.strokeStyle = arrBorderColor[11];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(252,311);ctx.lineTo(307,311);ctx.lineTo(303,333);ctx.lineTo(258,333);ctx.lineTo(252,311);ctx.fillStyle = arrFillColor[12];ctx.fill();ctx.lineWidth = arrBorderWidth[12];ctx.strokeStyle = arrBorderColor[12];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(383,222);ctx.lineTo(689,222);ctx.lineTo(689,519);ctx.lineTo(383,519);ctx.lineTo(383,222);ctx.fillStyle = arrFillColor[13];ctx.fill();ctx.lineWidth = arrBorderWidth[13];ctx.strokeStyle = arrBorderColor[13];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(383,222);ctx.lineTo(689,222);ctx.lineTo(706,207);ctx.lineTo(398,207);ctx.lineTo(383,222);ctx.fillStyle = arrFillColor[14];ctx.fill();ctx.lineWidth = arrBorderWidth[14];ctx.strokeStyle = arrBorderColor[14];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(706,207);ctx.lineTo(689,222);ctx.lineTo(689,519);ctx.lineTo(706,502);ctx.lineTo(706,207);ctx.fillStyle = arrFillColor[15];ctx.fill();ctx.lineWidth = arrBorderWidth[15];ctx.strokeStyle = arrBorderColor[15];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(534,256);ctx.lineTo(553,263);ctx.lineTo(562,282);ctx.lineTo(553,301);ctx.lineTo(534,307);ctx.lineTo(517,301);ctx.lineTo(509,282);ctx.lineTo(517,263);ctx.lineTo(534,256);ctx.fillStyle = arrFillColor[16];ctx.fill();ctx.lineWidth = arrBorderWidth[16];ctx.strokeStyle = arrBorderColor[16];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(695,258);ctx.lineTo(702,258);ctx.lineTo(702,273);ctx.lineTo(695,273);ctx.lineTo(695,258);ctx.fillStyle = arrFillColor[17];ctx.fill();ctx.lineWidth = arrBorderWidth[17];ctx.strokeStyle = arrBorderColor[17];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(695,286);ctx.lineTo(702,286);ctx.lineTo(702,301);ctx.lineTo(695,301);ctx.lineTo(695,286);ctx.fillStyle = arrFillColor[18];ctx.fill();ctx.lineWidth = arrBorderWidth[18];ctx.strokeStyle = arrBorderColor[18];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(188,528);ctx.lineTo(267,528);ctx.lineTo(267,598);ctx.lineTo(263,602);ctx.lineTo(184,532);ctx.lineTo(188,528);ctx.fillStyle = arrFillColor[19];ctx.fill();ctx.lineWidth = arrBorderWidth[19];ctx.strokeStyle = arrBorderColor[19];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(184,532);ctx.lineTo(263,532);ctx.lineTo(263,602);ctx.lineTo(184,602);ctx.lineTo(184,532);ctx.fillStyle = arrFillColor[20];ctx.fill();ctx.lineWidth = arrBorderWidth[20];ctx.strokeStyle = arrBorderColor[20];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(218,530);ctx.lineTo(233,530);ctx.lineTo(233,526);ctx.lineTo(218,526);ctx.lineTo(218,530);ctx.fillStyle = arrFillColor[21];ctx.fill();ctx.lineWidth = arrBorderWidth[21];ctx.strokeStyle = arrBorderColor[21];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(220,511);ctx.lineTo(231,511);ctx.lineTo(231,526);ctx.lineTo(220,526);ctx.lineTo(220,511);ctx.fillStyle = arrFillColor[22];ctx.fill();ctx.lineWidth = arrBorderWidth[22];ctx.strokeStyle = arrBorderColor[22];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(767,294);ctx.lineTo(884,178);ctx.lineTo(924,178);ctx.lineTo(810,419);ctx.lineTo(767,419);ctx.lineTo(767,294);ctx.fillStyle = arrFillColor[23];ctx.fill();ctx.lineWidth = arrBorderWidth[23];ctx.strokeStyle = arrBorderColor[23];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(808,294);ctx.lineTo(924,178);ctx.lineTo(924,305);ctx.lineTo(808,419);ctx.lineTo(808,294);ctx.fillStyle = arrFillColor[24];ctx.fill();ctx.lineWidth = arrBorderWidth[24];ctx.strokeStyle = arrBorderColor[24];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(186,500));listpt.Add(new Point(735,500));listpt.Add(new Point(735,763));listpt.Add(new Point(186,763));listpt.Add(new Point(186,500));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(186,500));listpt.Add(new Point(735,500));listpt.Add(new Point(888,349));listpt.Add(new Point(337,349));listpt.Add(new Point(186,500));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(888,349));listpt.Add(new Point(735,500));listpt.Add(new Point(735,763));listpt.Add(new Point(888,610));listpt.Add(new Point(888,349));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(27,417));listpt.Add(new Point(892,417));listpt.Add(new Point(892,494));listpt.Add(new Point(676,506));listpt.Add(new Point(243,506));listpt.Add(new Point(27,494));listpt.Add(new Point(27,417));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(27,417));listpt.Add(new Point(892,417));listpt.Add(new Point(971,339));listpt.Add(new Point(108,339));listpt.Add(new Point(27,417));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(892,494));listpt.Add(new Point(971,415));listpt.Add(new Point(971,339));listpt.Add(new Point(892,417));listpt.Add(new Point(892,494));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(199,180));listpt.Add(new Point(750,180));listpt.Add(new Point(750,441));listpt.Add(new Point(199,441));listpt.Add(new Point(199,180));sb = new SolidBrush(_listfillcolor[6]);p = new Pen(Color.Black);p.Width = _listborderwidth[6];p.Color = _listbordercolor[6];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(199,180));listpt.Add(new Point(750,180));listpt.Add(new Point(901,27));listpt.Add(new Point(352,27));listpt.Add(new Point(199,180));sb = new SolidBrush(_listfillcolor[7]);p = new Pen(Color.Black);p.Width = _listborderwidth[7];p.Color = _listbordercolor[7];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(901,29));listpt.Add(new Point(750,180));listpt.Add(new Point(750,441));listpt.Add(new Point(901,290));listpt.Add(new Point(901,29));sb = new SolidBrush(_listfillcolor[8]);p = new Pen(Color.Black);p.Width = _listborderwidth[8];p.Color = _listbordercolor[8];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(178,197));listpt.Add(new Point(330,197));listpt.Add(new Point(330,509));listpt.Add(new Point(178,509));listpt.Add(new Point(178,197));sb = new SolidBrush(_listfillcolor[9]);p = new Pen(Color.Black);p.Width = _listborderwidth[9];p.Color = _listbordercolor[9];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(178,197));listpt.Add(new Point(330,197));listpt.Add(new Point(352,176));listpt.Add(new Point(199,176));listpt.Add(new Point(178,197));sb = new SolidBrush(_listfillcolor[10]);p = new Pen(Color.Black);p.Width = _listborderwidth[10];p.Color = _listbordercolor[10];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(352,176));listpt.Add(new Point(330,197));listpt.Add(new Point(330,509));listpt.Add(new Point(352,485));listpt.Add(new Point(352,176));sb = new SolidBrush(_listfillcolor[11]);p = new Pen(Color.Black);p.Width = _listborderwidth[11];p.Color = _listbordercolor[11];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(252,311));listpt.Add(new Point(307,311));listpt.Add(new Point(303,333));listpt.Add(new Point(258,333));listpt.Add(new Point(252,311));sb = new SolidBrush(_listfillcolor[12]);p = new Pen(Color.Black);p.Width = _listborderwidth[12];p.Color = _listbordercolor[12];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(383,222));listpt.Add(new Point(689,222));listpt.Add(new Point(689,519));listpt.Add(new Point(383,519));listpt.Add(new Point(383,222));sb = new SolidBrush(_listfillcolor[13]);p = new Pen(Color.Black);p.Width = _listborderwidth[13];p.Color = _listbordercolor[13];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(383,222));listpt.Add(new Point(689,222));listpt.Add(new Point(706,207));listpt.Add(new Point(398,207));listpt.Add(new Point(383,222));sb = new SolidBrush(_listfillcolor[14]);p = new Pen(Color.Black);p.Width = _listborderwidth[14];p.Color = _listbordercolor[14];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(706,207));listpt.Add(new Point(689,222));listpt.Add(new Point(689,519));listpt.Add(new Point(706,502));listpt.Add(new Point(706,207));sb = new SolidBrush(_listfillcolor[15]);p = new Pen(Color.Black);p.Width = _listborderwidth[15];p.Color = _listbordercolor[15];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(534,256));listpt.Add(new Point(553,263));listpt.Add(new Point(562,282));listpt.Add(new Point(553,301));listpt.Add(new Point(534,307));listpt.Add(new Point(517,301));listpt.Add(new Point(509,282));listpt.Add(new Point(517,263));listpt.Add(new Point(534,256));sb = new SolidBrush(_listfillcolor[16]);p = new Pen(Color.Black);p.Width = _listborderwidth[16];p.Color = _listbordercolor[16];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(695,258));listpt.Add(new Point(702,258));listpt.Add(new Point(702,273));listpt.Add(new Point(695,273));listpt.Add(new Point(695,258));sb = new SolidBrush(_listfillcolor[17]);p = new Pen(Color.Black);p.Width = _listborderwidth[17];p.Color = _listbordercolor[17];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(695,286));listpt.Add(new Point(702,286));listpt.Add(new Point(702,301));listpt.Add(new Point(695,301));listpt.Add(new Point(695,286));sb = new SolidBrush(_listfillcolor[18]);p = new Pen(Color.Black);p.Width = _listborderwidth[18];p.Color = _listbordercolor[18];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(188,528));listpt.Add(new Point(267,528));listpt.Add(new Point(267,598));listpt.Add(new Point(263,602));listpt.Add(new Point(184,532));listpt.Add(new Point(188,528));sb = new SolidBrush(_listfillcolor[19]);p = new Pen(Color.Black);p.Width = _listborderwidth[19];p.Color = _listbordercolor[19];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(184,532));listpt.Add(new Point(263,532));listpt.Add(new Point(263,602));listpt.Add(new Point(184,602));listpt.Add(new Point(184,532));sb = new SolidBrush(_listfillcolor[20]);p = new Pen(Color.Black);p.Width = _listborderwidth[20];p.Color = _listbordercolor[20];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(218,530));listpt.Add(new Point(233,530));listpt.Add(new Point(233,526));listpt.Add(new Point(218,526));listpt.Add(new Point(218,530));sb = new SolidBrush(_listfillcolor[21]);p = new Pen(Color.Black);p.Width = _listborderwidth[21];p.Color = _listbordercolor[21];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(220,511));listpt.Add(new Point(231,511));listpt.Add(new Point(231,526));listpt.Add(new Point(220,526));listpt.Add(new Point(220,511));sb = new SolidBrush(_listfillcolor[22]);p = new Pen(Color.Black);p.Width = _listborderwidth[22];p.Color = _listbordercolor[22];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(767,294));listpt.Add(new Point(884,178));listpt.Add(new Point(924,178));listpt.Add(new Point(810,419));listpt.Add(new Point(767,419));listpt.Add(new Point(767,294));sb = new SolidBrush(_listfillcolor[23]);p = new Pen(Color.Black);p.Width = _listborderwidth[23];p.Color = _listbordercolor[23];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(808,294));listpt.Add(new Point(924,178));listpt.Add(new Point(924,305));listpt.Add(new Point(808,419));listpt.Add(new Point(808,294));sb = new SolidBrush(_listfillcolor[24]);p = new Pen(Color.Black);p.Width = _listborderwidth[24];p.Color = _listbordercolor[24];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}