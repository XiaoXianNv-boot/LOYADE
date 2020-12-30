using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Architectural
{
    public class PIXIE_60da0cfb_e1df_4864_9147_88fb7367a89f : Pixie
    {
        public PIXIE_60da0cfb_e1df_4864_9147_88fb7367a89f()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#ababab"));_listfillcolor.Add(ColorTranslator.FromHtml("#c24545"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 476f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#000'; arrFillColor[1] = '#c24545'; arrBorderColor[0] = '#ababab'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(934,473);ctx.lineTo(758,476);ctx.lineTo(727,468);ctx.lineTo(727,414);ctx.lineTo(700,444);ctx.lineTo(591,442);ctx.lineTo(490,412);ctx.lineTo(490,372);ctx.lineTo(520,326);ctx.lineTo(454,364);ctx.lineTo(366,375);ctx.lineTo(339,372);ctx.lineTo(291,393);ctx.lineTo(227,380);ctx.lineTo(180,390);ctx.lineTo(76,372);ctx.lineTo(28,348);ctx.lineTo(135,289);ctx.lineTo(570,236);ctx.lineTo(934,473);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(56,139);ctx.lineTo(344,28);ctx.lineTo(454,44);ctx.lineTo(454,117);ctx.lineTo(560,61);ctx.lineTo(667,75);ctx.lineTo(667,140);ctx.lineTo(702,145);ctx.lineTo(702,177);ctx.lineTo(908,135);ctx.lineTo(970,179);ctx.lineTo(970,297);ctx.lineTo(938,469);ctx.lineTo(774,467);ctx.lineTo(774,390);ctx.lineTo(822,293);ctx.lineTo(812,297);ctx.lineTo(699,446);ctx.lineTo(544,410);ctx.lineTo(544,337);ctx.lineTo(575,302);ctx.lineTo(562,291);ctx.lineTo(454,369);ctx.lineTo(320,341);ctx.lineTo(320,274);ctx.lineTo(241,348);ctx.lineTo(93,332);ctx.lineTo(93,253);ctx.lineTo(119,235);ctx.lineTo(56,223);ctx.lineTo(56,139);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(934,473));listpt.Add(new Point(758,476));listpt.Add(new Point(727,468));listpt.Add(new Point(727,414));listpt.Add(new Point(700,444));listpt.Add(new Point(591,442));listpt.Add(new Point(490,412));listpt.Add(new Point(490,372));listpt.Add(new Point(520,326));listpt.Add(new Point(454,364));listpt.Add(new Point(366,375));listpt.Add(new Point(339,372));listpt.Add(new Point(291,393));listpt.Add(new Point(227,380));listpt.Add(new Point(180,390));listpt.Add(new Point(76,372));listpt.Add(new Point(28,348));listpt.Add(new Point(135,289));listpt.Add(new Point(570,236));listpt.Add(new Point(934,473));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(56,139));listpt.Add(new Point(344,28));listpt.Add(new Point(454,44));listpt.Add(new Point(454,117));listpt.Add(new Point(560,61));listpt.Add(new Point(667,75));listpt.Add(new Point(667,140));listpt.Add(new Point(702,145));listpt.Add(new Point(702,177));listpt.Add(new Point(908,135));listpt.Add(new Point(970,179));listpt.Add(new Point(970,297));listpt.Add(new Point(938,469));listpt.Add(new Point(774,467));listpt.Add(new Point(774,390));listpt.Add(new Point(822,293));listpt.Add(new Point(812,297));listpt.Add(new Point(699,446));listpt.Add(new Point(544,410));listpt.Add(new Point(544,337));listpt.Add(new Point(575,302));listpt.Add(new Point(562,291));listpt.Add(new Point(454,369));listpt.Add(new Point(320,341));listpt.Add(new Point(320,274));listpt.Add(new Point(241,348));listpt.Add(new Point(93,332));listpt.Add(new Point(93,253));listpt.Add(new Point(119,235));listpt.Add(new Point(56,223));listpt.Add(new Point(56,139));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}