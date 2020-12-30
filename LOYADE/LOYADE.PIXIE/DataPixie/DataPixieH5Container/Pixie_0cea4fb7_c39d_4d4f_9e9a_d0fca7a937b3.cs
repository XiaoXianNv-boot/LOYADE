using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Container
{
    public class PIXIE_0cea4fb7_c39d_4d4f_9e9a_d0fca7a937b3 : Pixie
    {
        public PIXIE_0cea4fb7_c39d_4d4f_9e9a_d0fca7a937b3()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 146f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#7f7f7f'; arrFillColor[1] = '#7f7f7f'; arrFillColor[2] = '#7f7f7f'; arrFillColor[3] = '#999'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,48);ctx.lineTo(28,73);ctx.lineTo(31,73);ctx.lineTo(31,90);ctx.lineTo(35,90);ctx.lineTo(35,146);ctx.lineTo(97,146);ctx.lineTo(97,90);ctx.lineTo(103,90);ctx.lineTo(103,73);ctx.lineTo(107,73);ctx.lineTo(107,48);ctx.lineTo(28,48);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(459,48);ctx.lineTo(459,73);ctx.lineTo(463,73);ctx.lineTo(463,90);ctx.lineTo(467,90);ctx.lineTo(467,146);ctx.lineTo(531,146);ctx.lineTo(531,90);ctx.lineTo(535,90);ctx.lineTo(535,73);ctx.lineTo(539,73);ctx.lineTo(539,48);ctx.lineTo(459,48);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(891,48);ctx.lineTo(891,73);ctx.lineTo(895,73);ctx.lineTo(895,90);ctx.lineTo(899,90);ctx.lineTo(899,146);ctx.lineTo(963,146);ctx.lineTo(963,90);ctx.lineTo(967,90);ctx.lineTo(967,73);ctx.lineTo(970,73);ctx.lineTo(970,48);ctx.lineTo(891,48);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,28);ctx.lineTo(970,28);ctx.lineTo(970,58);ctx.lineTo(28,58);ctx.lineTo(28,28);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,48));listpt.Add(new Point(28,73));listpt.Add(new Point(31,73));listpt.Add(new Point(31,90));listpt.Add(new Point(35,90));listpt.Add(new Point(35,146));listpt.Add(new Point(97,146));listpt.Add(new Point(97,90));listpt.Add(new Point(103,90));listpt.Add(new Point(103,73));listpt.Add(new Point(107,73));listpt.Add(new Point(107,48));listpt.Add(new Point(28,48));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(459,48));listpt.Add(new Point(459,73));listpt.Add(new Point(463,73));listpt.Add(new Point(463,90));listpt.Add(new Point(467,90));listpt.Add(new Point(467,146));listpt.Add(new Point(531,146));listpt.Add(new Point(531,90));listpt.Add(new Point(535,90));listpt.Add(new Point(535,73));listpt.Add(new Point(539,73));listpt.Add(new Point(539,48));listpt.Add(new Point(459,48));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(891,48));listpt.Add(new Point(891,73));listpt.Add(new Point(895,73));listpt.Add(new Point(895,90));listpt.Add(new Point(899,90));listpt.Add(new Point(899,146));listpt.Add(new Point(963,146));listpt.Add(new Point(963,90));listpt.Add(new Point(967,90));listpt.Add(new Point(967,73));listpt.Add(new Point(970,73));listpt.Add(new Point(970,48));listpt.Add(new Point(891,48));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,28));listpt.Add(new Point(970,28));listpt.Add(new Point(970,58));listpt.Add(new Point(28,58));listpt.Add(new Point(28,28));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}