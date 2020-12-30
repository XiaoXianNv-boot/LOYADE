using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Switch
{
    public class PIXIE_04136f88_3976_49bb_93db_cbbeed95a580 : Pixie
    {
        public PIXIE_04136f88_3976_49bb_93db_cbbeed95a580()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 688f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#7f7f7f'; arrFillColor[1] = '#b2b2b2'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(970,28);ctx.lineTo(895,75);ctx.lineTo(877,100);ctx.lineTo(859,123);ctx.lineTo(839,140);ctx.lineTo(808,153);ctx.lineTo(782,162);ctx.lineTo(756,170);ctx.lineTo(728,177);ctx.lineTo(699,184);ctx.lineTo(669,189);ctx.lineTo(638,193);ctx.lineTo(606,197);ctx.lineTo(573,199);ctx.lineTo(539,199);ctx.lineTo(502,198);ctx.lineTo(466,196);ctx.lineTo(430,191);ctx.lineTo(395,186);ctx.lineTo(362,179);ctx.lineTo(330,171);ctx.lineTo(299,162);ctx.lineTo(269,151);ctx.lineTo(241,139);ctx.lineTo(216,126);ctx.lineTo(191,112);ctx.lineTo(169,97);ctx.lineTo(140,73);ctx.lineTo(117,46);ctx.lineTo(111,37);ctx.lineTo(105,28);ctx.lineTo(28,75);ctx.lineTo(461,688);ctx.lineTo(539,639);ctx.lineTo(970,28);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(893,77);ctx.lineTo(874,104);ctx.lineTo(849,130);ctx.lineTo(819,154);ctx.lineTo(796,168);ctx.lineTo(771,182);ctx.lineTo(744,194);ctx.lineTo(716,205);ctx.lineTo(686,215);ctx.lineTo(654,224);ctx.lineTo(621,231);ctx.lineTo(587,237);ctx.lineTo(552,241);ctx.lineTo(516,244);ctx.lineTo(480,246);ctx.lineTo(443,246);ctx.lineTo(406,244);ctx.lineTo(370,241);ctx.lineTo(335,237);ctx.lineTo(301,231);ctx.lineTo(268,224);ctx.lineTo(237,215);ctx.lineTo(206,205);ctx.lineTo(178,194);ctx.lineTo(151,182);ctx.lineTo(126,168);ctx.lineTo(103,154);ctx.lineTo(82,138);ctx.lineTo(55,113);ctx.lineTo(33,86);ctx.lineTo(28,77);ctx.lineTo(461,688);ctx.lineTo(893,77);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(970,28));listpt.Add(new Point(895,75));listpt.Add(new Point(877,100));listpt.Add(new Point(859,123));listpt.Add(new Point(839,140));listpt.Add(new Point(808,153));listpt.Add(new Point(782,162));listpt.Add(new Point(756,170));listpt.Add(new Point(728,177));listpt.Add(new Point(699,184));listpt.Add(new Point(669,189));listpt.Add(new Point(638,193));listpt.Add(new Point(606,197));listpt.Add(new Point(573,199));listpt.Add(new Point(539,199));listpt.Add(new Point(502,198));listpt.Add(new Point(466,196));listpt.Add(new Point(430,191));listpt.Add(new Point(395,186));listpt.Add(new Point(362,179));listpt.Add(new Point(330,171));listpt.Add(new Point(299,162));listpt.Add(new Point(269,151));listpt.Add(new Point(241,139));listpt.Add(new Point(216,126));listpt.Add(new Point(191,112));listpt.Add(new Point(169,97));listpt.Add(new Point(140,73));listpt.Add(new Point(117,46));listpt.Add(new Point(111,37));listpt.Add(new Point(105,28));listpt.Add(new Point(28,75));listpt.Add(new Point(461,688));listpt.Add(new Point(539,639));listpt.Add(new Point(970,28));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(893,77));listpt.Add(new Point(874,104));listpt.Add(new Point(849,130));listpt.Add(new Point(819,154));listpt.Add(new Point(796,168));listpt.Add(new Point(771,182));listpt.Add(new Point(744,194));listpt.Add(new Point(716,205));listpt.Add(new Point(686,215));listpt.Add(new Point(654,224));listpt.Add(new Point(621,231));listpt.Add(new Point(587,237));listpt.Add(new Point(552,241));listpt.Add(new Point(516,244));listpt.Add(new Point(480,246));listpt.Add(new Point(443,246));listpt.Add(new Point(406,244));listpt.Add(new Point(370,241));listpt.Add(new Point(335,237));listpt.Add(new Point(301,231));listpt.Add(new Point(268,224));listpt.Add(new Point(237,215));listpt.Add(new Point(206,205));listpt.Add(new Point(178,194));listpt.Add(new Point(151,182));listpt.Add(new Point(126,168));listpt.Add(new Point(103,154));listpt.Add(new Point(82,138));listpt.Add(new Point(55,113));listpt.Add(new Point(33,86));listpt.Add(new Point(28,77));listpt.Add(new Point(461,688));listpt.Add(new Point(893,77));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}