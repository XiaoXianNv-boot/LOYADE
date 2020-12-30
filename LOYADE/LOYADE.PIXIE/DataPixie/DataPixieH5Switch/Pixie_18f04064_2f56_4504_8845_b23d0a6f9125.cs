using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Switch
{
    public class PIXIE_18f04064_2f56_4504_8845_b23d0a6f9125 : Pixie
    {
        public PIXIE_18f04064_2f56_4504_8845_b23d0a6f9125()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 930f; _h = 970f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#4c4c4c'; arrFillColor[1] = '#000'; arrFillColor[2] = '#ccc'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(59,79);ctx.lineTo(28,451);ctx.lineTo(32,468);ctx.lineTo(44,478);ctx.lineTo(72,498);ctx.lineTo(76,509);ctx.lineTo(73,602);ctx.lineTo(92,693);ctx.lineTo(131,777);ctx.lineTo(187,851);ctx.lineTo(259,909);ctx.lineTo(342,949);ctx.lineTo(432,970);ctx.lineTo(525,970);ctx.lineTo(616,949);ctx.lineTo(699,909);ctx.lineTo(770,851);ctx.lineTo(827,777);ctx.lineTo(866,693);ctx.lineTo(885,602);ctx.lineTo(884,509);ctx.lineTo(886,498);ctx.lineTo(915,478);ctx.lineTo(928,468);ctx.lineTo(930,451);ctx.lineTo(900,79);ctx.lineTo(891,53);ctx.lineTo(871,34);ctx.lineTo(845,28);ctx.lineTo(113,28);ctx.lineTo(87,34);ctx.lineTo(68,53);ctx.lineTo(59,79);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(414,204);ctx.lineTo(545,204);ctx.lineTo(632,226);ctx.lineTo(711,270);ctx.lineTo(777,333);ctx.lineTo(824,410);ctx.lineTo(851,498);ctx.lineTo(867,464);ctx.lineTo(894,439);ctx.lineTo(865,82);ctx.lineTo(858,68);ctx.lineTo(845,62);ctx.lineTo(113,62);ctx.lineTo(101,68);ctx.lineTo(93,82);ctx.lineTo(63,436);ctx.lineTo(92,461);ctx.lineTo(108,495);ctx.lineTo(135,409);ctx.lineTo(181,332);ctx.lineTo(248,269);ctx.lineTo(326,226);ctx.lineTo(414,204);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(427,181);ctx.lineTo(427,230);ctx.lineTo(343,255);ctx.lineTo(268,299);ctx.lineTo(207,363);ctx.lineTo(165,440);ctx.lineTo(143,525);ctx.lineTo(145,613);ctx.lineTo(167,698);ctx.lineTo(212,773);ctx.lineTo(274,835);ctx.lineTo(351,878);ctx.lineTo(435,901);ctx.lineTo(523,901);ctx.lineTo(607,878);ctx.lineTo(684,835);ctx.lineTo(747,773);ctx.lineTo(791,698);ctx.lineTo(814,613);ctx.lineTo(816,525);ctx.lineTo(793,440);ctx.lineTo(750,363);ctx.lineTo(690,299);ctx.lineTo(615,255);ctx.lineTo(530,230);ctx.lineTo(530,181);ctx.lineTo(427,181);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(59,79));listpt.Add(new Point(28,451));listpt.Add(new Point(32,468));listpt.Add(new Point(44,478));listpt.Add(new Point(72,498));listpt.Add(new Point(76,509));listpt.Add(new Point(73,602));listpt.Add(new Point(92,693));listpt.Add(new Point(131,777));listpt.Add(new Point(187,851));listpt.Add(new Point(259,909));listpt.Add(new Point(342,949));listpt.Add(new Point(432,970));listpt.Add(new Point(525,970));listpt.Add(new Point(616,949));listpt.Add(new Point(699,909));listpt.Add(new Point(770,851));listpt.Add(new Point(827,777));listpt.Add(new Point(866,693));listpt.Add(new Point(885,602));listpt.Add(new Point(884,509));listpt.Add(new Point(886,498));listpt.Add(new Point(915,478));listpt.Add(new Point(928,468));listpt.Add(new Point(930,451));listpt.Add(new Point(900,79));listpt.Add(new Point(891,53));listpt.Add(new Point(871,34));listpt.Add(new Point(845,28));listpt.Add(new Point(113,28));listpt.Add(new Point(87,34));listpt.Add(new Point(68,53));listpt.Add(new Point(59,79));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(414,204));listpt.Add(new Point(545,204));listpt.Add(new Point(632,226));listpt.Add(new Point(711,270));listpt.Add(new Point(777,333));listpt.Add(new Point(824,410));listpt.Add(new Point(851,498));listpt.Add(new Point(867,464));listpt.Add(new Point(894,439));listpt.Add(new Point(865,82));listpt.Add(new Point(858,68));listpt.Add(new Point(845,62));listpt.Add(new Point(113,62));listpt.Add(new Point(101,68));listpt.Add(new Point(93,82));listpt.Add(new Point(63,436));listpt.Add(new Point(92,461));listpt.Add(new Point(108,495));listpt.Add(new Point(135,409));listpt.Add(new Point(181,332));listpt.Add(new Point(248,269));listpt.Add(new Point(326,226));listpt.Add(new Point(414,204));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(427,181));listpt.Add(new Point(427,230));listpt.Add(new Point(343,255));listpt.Add(new Point(268,299));listpt.Add(new Point(207,363));listpt.Add(new Point(165,440));listpt.Add(new Point(143,525));listpt.Add(new Point(145,613));listpt.Add(new Point(167,698));listpt.Add(new Point(212,773));listpt.Add(new Point(274,835));listpt.Add(new Point(351,878));listpt.Add(new Point(435,901));listpt.Add(new Point(523,901));listpt.Add(new Point(607,878));listpt.Add(new Point(684,835));listpt.Add(new Point(747,773));listpt.Add(new Point(791,698));listpt.Add(new Point(814,613));listpt.Add(new Point(816,525));listpt.Add(new Point(793,440));listpt.Add(new Point(750,363));listpt.Add(new Point(690,299));listpt.Add(new Point(615,255));listpt.Add(new Point(530,230));listpt.Add(new Point(530,181));listpt.Add(new Point(427,181));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}