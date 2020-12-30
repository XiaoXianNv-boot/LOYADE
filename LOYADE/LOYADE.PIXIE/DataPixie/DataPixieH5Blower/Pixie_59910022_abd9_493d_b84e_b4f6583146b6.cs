using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Blower
{
    public class PIXIE_59910022_abd9_493d_b84e_b4f6583146b6 : Pixie
    {
        public PIXIE_59910022_abd9_493d_b84e_b4f6583146b6()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#002659"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#369"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#66f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 480f; _h = 459f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#002659'; arrFillColor[1] = '#369'; arrFillColor[2] = '#66f'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(382,450);ctx.lineTo(343,459);ctx.lineTo(301,459);ctx.lineTo(261,450);ctx.lineTo(226,429);ctx.lineTo(197,399);ctx.lineTo(177,363);ctx.lineTo(165,323);ctx.lineTo(165,282);ctx.lineTo(177,242);ctx.lineTo(197,207);ctx.lineTo(226,179);ctx.lineTo(261,158);ctx.lineTo(301,146);ctx.lineTo(343,146);ctx.lineTo(382,158);ctx.lineTo(420,179);ctx.lineTo(448,207);ctx.lineTo(469,242);ctx.lineTo(480,282);ctx.lineTo(480,323);ctx.lineTo(469,363);ctx.lineTo(448,399);ctx.lineTo(418,429);ctx.lineTo(382,450);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(27,186);ctx.lineTo(107,186);ctx.lineTo(107,422);ctx.lineTo(27,422);ctx.lineTo(27,186);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(107,410);ctx.lineTo(125,401);ctx.lineTo(125,309);ctx.lineTo(144,309);ctx.lineTo(144,297);ctx.lineTo(116,297);ctx.lineTo(116,392);ctx.lineTo(107,397);ctx.lineTo(107,410);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(382,450));listpt.Add(new Point(343,459));listpt.Add(new Point(301,459));listpt.Add(new Point(261,450));listpt.Add(new Point(226,429));listpt.Add(new Point(197,399));listpt.Add(new Point(177,363));listpt.Add(new Point(165,323));listpt.Add(new Point(165,282));listpt.Add(new Point(177,242));listpt.Add(new Point(197,207));listpt.Add(new Point(226,179));listpt.Add(new Point(261,158));listpt.Add(new Point(301,146));listpt.Add(new Point(343,146));listpt.Add(new Point(382,158));listpt.Add(new Point(420,179));listpt.Add(new Point(448,207));listpt.Add(new Point(469,242));listpt.Add(new Point(480,282));listpt.Add(new Point(480,323));listpt.Add(new Point(469,363));listpt.Add(new Point(448,399));listpt.Add(new Point(418,429));listpt.Add(new Point(382,450));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(27,186));listpt.Add(new Point(107,186));listpt.Add(new Point(107,422));listpt.Add(new Point(27,422));listpt.Add(new Point(27,186));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(107,410));listpt.Add(new Point(125,401));listpt.Add(new Point(125,309));listpt.Add(new Point(144,309));listpt.Add(new Point(144,297));listpt.Add(new Point(116,297));listpt.Add(new Point(116,392));listpt.Add(new Point(107,397));listpt.Add(new Point(107,410));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}