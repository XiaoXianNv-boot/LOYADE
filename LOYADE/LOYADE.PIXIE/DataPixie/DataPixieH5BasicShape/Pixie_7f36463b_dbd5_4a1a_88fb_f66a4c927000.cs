using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_7f36463b_dbd5_4a1a_88fb_f66a4c927000 : Pixie
    {
        public PIXIE_7f36463b_dbd5_4a1a_88fb_f66a4c927000()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 583f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(39,292);ctx.lineTo(61,266);ctx.lineTo(85,241);ctx.lineTo(110,216);ctx.lineTo(134,191);ctx.lineTo(160,168);ctx.lineTo(188,145);ctx.lineTo(216,124);ctx.lineTo(245,105);ctx.lineTo(275,87);ctx.lineTo(306,71);ctx.lineTo(338,58);ctx.lineTo(372,46);ctx.lineTo(406,37);ctx.lineTo(443,31);ctx.lineTo(480,28);ctx.lineTo(499,28);ctx.lineTo(518,28);ctx.lineTo(555,31);ctx.lineTo(592,37);ctx.lineTo(626,46);ctx.lineTo(660,58);ctx.lineTo(692,71);ctx.lineTo(723,87);ctx.lineTo(753,105);ctx.lineTo(782,124);ctx.lineTo(810,145);ctx.lineTo(838,168);ctx.lineTo(864,191);ctx.lineTo(888,216);ctx.lineTo(913,241);ctx.lineTo(937,266);ctx.lineTo(959,292);ctx.lineTo(970,305);ctx.lineTo(959,318);ctx.lineTo(937,344);ctx.lineTo(913,370);ctx.lineTo(888,395);ctx.lineTo(864,419);ctx.lineTo(838,443);ctx.lineTo(810,465);ctx.lineTo(782,486);ctx.lineTo(753,506);ctx.lineTo(723,524);ctx.lineTo(692,540);ctx.lineTo(660,553);ctx.lineTo(626,564);ctx.lineTo(592,573);ctx.lineTo(555,580);ctx.lineTo(518,583);ctx.lineTo(499,583);ctx.lineTo(480,583);ctx.lineTo(443,580);ctx.lineTo(406,573);ctx.lineTo(372,564);ctx.lineTo(338,553);ctx.lineTo(306,540);ctx.lineTo(275,524);ctx.lineTo(245,506);ctx.lineTo(216,486);ctx.lineTo(188,465);ctx.lineTo(160,443);ctx.lineTo(134,419);ctx.lineTo(110,395);ctx.lineTo(85,370);ctx.lineTo(61,344);ctx.lineTo(39,318);ctx.lineTo(28,305);ctx.lineTo(39,292);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(39,292));listpt.Add(new Point(61,266));listpt.Add(new Point(85,241));listpt.Add(new Point(110,216));listpt.Add(new Point(134,191));listpt.Add(new Point(160,168));listpt.Add(new Point(188,145));listpt.Add(new Point(216,124));listpt.Add(new Point(245,105));listpt.Add(new Point(275,87));listpt.Add(new Point(306,71));listpt.Add(new Point(338,58));listpt.Add(new Point(372,46));listpt.Add(new Point(406,37));listpt.Add(new Point(443,31));listpt.Add(new Point(480,28));listpt.Add(new Point(499,28));listpt.Add(new Point(518,28));listpt.Add(new Point(555,31));listpt.Add(new Point(592,37));listpt.Add(new Point(626,46));listpt.Add(new Point(660,58));listpt.Add(new Point(692,71));listpt.Add(new Point(723,87));listpt.Add(new Point(753,105));listpt.Add(new Point(782,124));listpt.Add(new Point(810,145));listpt.Add(new Point(838,168));listpt.Add(new Point(864,191));listpt.Add(new Point(888,216));listpt.Add(new Point(913,241));listpt.Add(new Point(937,266));listpt.Add(new Point(959,292));listpt.Add(new Point(970,305));listpt.Add(new Point(959,318));listpt.Add(new Point(937,344));listpt.Add(new Point(913,370));listpt.Add(new Point(888,395));listpt.Add(new Point(864,419));listpt.Add(new Point(838,443));listpt.Add(new Point(810,465));listpt.Add(new Point(782,486));listpt.Add(new Point(753,506));listpt.Add(new Point(723,524));listpt.Add(new Point(692,540));listpt.Add(new Point(660,553));listpt.Add(new Point(626,564));listpt.Add(new Point(592,573));listpt.Add(new Point(555,580));listpt.Add(new Point(518,583));listpt.Add(new Point(499,583));listpt.Add(new Point(480,583));listpt.Add(new Point(443,580));listpt.Add(new Point(406,573));listpt.Add(new Point(372,564));listpt.Add(new Point(338,553));listpt.Add(new Point(306,540));listpt.Add(new Point(275,524));listpt.Add(new Point(245,506));listpt.Add(new Point(216,486));listpt.Add(new Point(188,465));listpt.Add(new Point(160,443));listpt.Add(new Point(134,419));listpt.Add(new Point(110,395));listpt.Add(new Point(85,370));listpt.Add(new Point(61,344));listpt.Add(new Point(39,318));listpt.Add(new Point(28,305));listpt.Add(new Point(39,292));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}