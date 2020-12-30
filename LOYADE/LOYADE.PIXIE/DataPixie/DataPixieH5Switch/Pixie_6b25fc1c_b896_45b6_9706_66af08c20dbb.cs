using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Switch
{
    public class PIXIE_6b25fc1c_b896_45b6_9706_66af08c20dbb : Pixie
    {
        public PIXIE_6b25fc1c_b896_45b6_9706_66af08c20dbb()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));
_w = 790f; _h = 944f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#e5e5e5'; arrFillColor[1] = '#7f7f7f'; arrFillColor[2] = '#b2b2b2'; arrFillColor[3] = '#000'; arrFillColor[4] = '#e5e5e5'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#7f7f7f'; arrBorderColor[4] = '#7f7f7f'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(625,257);ctx.lineTo(785,415);ctx.lineTo(790,430);ctx.lineTo(790,653);ctx.lineTo(785,668);ctx.lineTo(625,828);ctx.lineTo(609,832);ctx.lineTo(389,832);ctx.lineTo(373,828);ctx.lineTo(213,668);ctx.lineTo(208,653);ctx.lineTo(208,430);ctx.lineTo(213,415);ctx.lineTo(373,257);ctx.lineTo(389,251);ctx.lineTo(609,251);ctx.lineTo(625,257);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(498,542,273,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(459,232);ctx.lineTo(459,290);ctx.lineTo(406,304);ctx.lineTo(356,331);ctx.lineTo(312,368);ctx.lineTo(279,413);ctx.lineTo(257,464);ctx.lineTo(246,519);ctx.lineTo(247,576);ctx.lineTo(260,630);ctx.lineTo(285,680);ctx.lineTo(321,724);ctx.lineTo(364,758);ctx.lineTo(417,783);ctx.lineTo(470,794);ctx.lineTo(528,794);ctx.lineTo(581,783);ctx.lineTo(633,758);ctx.lineTo(677,724);ctx.lineTo(713,680);ctx.lineTo(738,630);ctx.lineTo(751,576);ctx.lineTo(753,519);ctx.lineTo(742,464);ctx.lineTo(719,413);ctx.lineTo(686,368);ctx.lineTo(644,331);ctx.lineTo(592,304);ctx.lineTo(537,290);ctx.lineTo(537,232);ctx.lineTo(459,232);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(663,496);ctx.lineTo(536,369);ctx.lineTo(85,833);ctx.lineTo(195,944);ctx.lineTo(663,496);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(580,452);ctx.lineTo(526,462);ctx.lineTo(539,473);ctx.lineTo(480,531);ctx.lineTo(500,551);ctx.lineTo(558,494);ctx.lineTo(570,506);ctx.lineTo(580,452);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(625,257));listpt.Add(new Point(785,415));listpt.Add(new Point(790,430));listpt.Add(new Point(790,653));listpt.Add(new Point(785,668));listpt.Add(new Point(625,828));listpt.Add(new Point(609,832));listpt.Add(new Point(389,832));listpt.Add(new Point(373,828));listpt.Add(new Point(213,668));listpt.Add(new Point(208,653));listpt.Add(new Point(208,430));listpt.Add(new Point(213,415));listpt.Add(new Point(373,257));listpt.Add(new Point(389,251));listpt.Add(new Point(609,251));listpt.Add(new Point(625,257));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 225f,269f,546f,546f);g.DrawEllipse(p, 225f,269f,546f,546f);
listpt = new List<Point>();listpt.Add(new Point(459,232));listpt.Add(new Point(459,290));listpt.Add(new Point(406,304));listpt.Add(new Point(356,331));listpt.Add(new Point(312,368));listpt.Add(new Point(279,413));listpt.Add(new Point(257,464));listpt.Add(new Point(246,519));listpt.Add(new Point(247,576));listpt.Add(new Point(260,630));listpt.Add(new Point(285,680));listpt.Add(new Point(321,724));listpt.Add(new Point(364,758));listpt.Add(new Point(417,783));listpt.Add(new Point(470,794));listpt.Add(new Point(528,794));listpt.Add(new Point(581,783));listpt.Add(new Point(633,758));listpt.Add(new Point(677,724));listpt.Add(new Point(713,680));listpt.Add(new Point(738,630));listpt.Add(new Point(751,576));listpt.Add(new Point(753,519));listpt.Add(new Point(742,464));listpt.Add(new Point(719,413));listpt.Add(new Point(686,368));listpt.Add(new Point(644,331));listpt.Add(new Point(592,304));listpt.Add(new Point(537,290));listpt.Add(new Point(537,232));listpt.Add(new Point(459,232));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(663,496));listpt.Add(new Point(536,369));listpt.Add(new Point(85,833));listpt.Add(new Point(195,944));listpt.Add(new Point(663,496));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(580,452));listpt.Add(new Point(526,462));listpt.Add(new Point(539,473));listpt.Add(new Point(480,531));listpt.Add(new Point(500,551));listpt.Add(new Point(558,494));listpt.Add(new Point(570,506));listpt.Add(new Point(580,452));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}