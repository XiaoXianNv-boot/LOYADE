using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Vehicle
{
    public class PIXIE_97ea6039_0f97_4793_ac65_4ade6683c99c : Pixie
    {
        public PIXIE_97ea6039_0f97_4793_ac65_4ade6683c99c()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#666"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#666"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#333"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#333"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 928f; _h = 971f;
_content = "var arrFillColor = new Array(7); var arrBorderColor = new Array(7); var arrBorderWidth = new Array(7); arrFillColor[0] = '#666'; arrFillColor[1] = '#666'; arrFillColor[2] = '#ccc'; arrFillColor[3] = '#333'; arrFillColor[4] = '#999'; arrFillColor[5] = '#333'; arrFillColor[6] = '#999'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderColor[6] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; arrBorderWidth[6] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(77,232);ctx.lineTo(77,806);ctx.lineTo(58,806);ctx.lineTo(58,232);ctx.lineTo(77,232);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(56,37);ctx.lineTo(77,232);ctx.lineTo(58,232);ctx.lineTo(37,37);ctx.lineTo(56,37);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(68,766);ctx.lineTo(928,766);ctx.lineTo(928,806);ctx.lineTo(68,806);ctx.lineTo(68,766);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(175,965);ctx.lineTo(154,971);ctx.lineTo(135,971);ctx.lineTo(116,965);ctx.lineTo(96,955);ctx.lineTo(83,940);ctx.lineTo(74,923);ctx.lineTo(68,903);ctx.lineTo(68,882);ctx.lineTo(74,863);ctx.lineTo(83,846);ctx.lineTo(96,832);ctx.lineTo(116,821);ctx.lineTo(135,817);ctx.lineTo(154,817);ctx.lineTo(175,821);ctx.lineTo(192,832);ctx.lineTo(206,846);ctx.lineTo(217,863);ctx.lineTo(221,882);ctx.lineTo(221,903);ctx.lineTo(217,923);ctx.lineTo(206,940);ctx.lineTo(192,955);ctx.lineTo(175,965);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(154,894);ctx.lineTo(144,913);ctx.lineTo(135,894);ctx.lineTo(135,806);ctx.lineTo(154,806);ctx.lineTo(154,894);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(851,894,76,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(861,894);ctx.lineTo(852,913);ctx.lineTo(842,894);ctx.lineTo(842,806);ctx.lineTo(861,806);ctx.lineTo(861,894);ctx.fillStyle = arrFillColor[6];ctx.fill();ctx.lineWidth = arrBorderWidth[6];ctx.strokeStyle = arrBorderColor[6];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(77,232));listpt.Add(new Point(77,806));listpt.Add(new Point(58,806));listpt.Add(new Point(58,232));listpt.Add(new Point(77,232));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(56,37));listpt.Add(new Point(77,232));listpt.Add(new Point(58,232));listpt.Add(new Point(37,37));listpt.Add(new Point(56,37));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(68,766));listpt.Add(new Point(928,766));listpt.Add(new Point(928,806));listpt.Add(new Point(68,806));listpt.Add(new Point(68,766));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(175,965));listpt.Add(new Point(154,971));listpt.Add(new Point(135,971));listpt.Add(new Point(116,965));listpt.Add(new Point(96,955));listpt.Add(new Point(83,940));listpt.Add(new Point(74,923));listpt.Add(new Point(68,903));listpt.Add(new Point(68,882));listpt.Add(new Point(74,863));listpt.Add(new Point(83,846));listpt.Add(new Point(96,832));listpt.Add(new Point(116,821));listpt.Add(new Point(135,817));listpt.Add(new Point(154,817));listpt.Add(new Point(175,821));listpt.Add(new Point(192,832));listpt.Add(new Point(206,846));listpt.Add(new Point(217,863));listpt.Add(new Point(221,882));listpt.Add(new Point(221,903));listpt.Add(new Point(217,923));listpt.Add(new Point(206,940));listpt.Add(new Point(192,955));listpt.Add(new Point(175,965));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(154,894));listpt.Add(new Point(144,913));listpt.Add(new Point(135,894));listpt.Add(new Point(135,806));listpt.Add(new Point(154,806));listpt.Add(new Point(154,894));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillEllipse(sb, 775f,818f,152f,152f);g.DrawEllipse(p, 775f,818f,152f,152f);
listpt = new List<Point>();listpt.Add(new Point(861,894));listpt.Add(new Point(852,913));listpt.Add(new Point(842,894));listpt.Add(new Point(842,806));listpt.Add(new Point(861,806));listpt.Add(new Point(861,894));sb = new SolidBrush(_listfillcolor[6]);p = new Pen(Color.Black);p.Width = _listborderwidth[6];p.Color = _listbordercolor[6];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}