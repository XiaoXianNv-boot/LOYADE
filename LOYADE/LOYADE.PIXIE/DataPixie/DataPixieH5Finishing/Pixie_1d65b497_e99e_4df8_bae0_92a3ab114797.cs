using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Finishing
{
    public class PIXIE_1d65b497_e99e_4df8_bae0_92a3ab114797 : Pixie
    {
        public PIXIE_1d65b497_e99e_4df8_bae0_92a3ab114797()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#9cc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#699"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ff0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 914f; _h = 970f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#9cc'; arrFillColor[1] = '#699'; arrFillColor[2] = '#ff0'; arrFillColor[3] = '#7f7f7f'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,104);ctx.lineTo(838,104);ctx.lineTo(914,28);ctx.lineTo(104,28);ctx.lineTo(28,104);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(914,28);ctx.lineTo(838,104);ctx.lineTo(838,970);ctx.lineTo(914,894);ctx.lineTo(914,28);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(305,234);ctx.lineTo(327,204);ctx.lineTo(417,232);ctx.lineTo(403,247);ctx.lineTo(489,273);ctx.lineTo(479,285);ctx.lineTo(559,317);ctx.lineTo(453,303);ctx.lineTo(463,291);ctx.lineTo(365,265);ctx.lineTo(379,249);ctx.lineTo(305,234);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(851,395);ctx.lineTo(904,341);ctx.lineTo(904,733);ctx.lineTo(851,786);ctx.lineTo(851,395);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,104));listpt.Add(new Point(838,104));listpt.Add(new Point(914,28));listpt.Add(new Point(104,28));listpt.Add(new Point(28,104));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(914,28));listpt.Add(new Point(838,104));listpt.Add(new Point(838,970));listpt.Add(new Point(914,894));listpt.Add(new Point(914,28));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(305,234));listpt.Add(new Point(327,204));listpt.Add(new Point(417,232));listpt.Add(new Point(403,247));listpt.Add(new Point(489,273));listpt.Add(new Point(479,285));listpt.Add(new Point(559,317));listpt.Add(new Point(453,303));listpt.Add(new Point(463,291));listpt.Add(new Point(365,265));listpt.Add(new Point(379,249));listpt.Add(new Point(305,234));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(851,395));listpt.Add(new Point(904,341));listpt.Add(new Point(904,733));listpt.Add(new Point(851,786));listpt.Add(new Point(851,395));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}