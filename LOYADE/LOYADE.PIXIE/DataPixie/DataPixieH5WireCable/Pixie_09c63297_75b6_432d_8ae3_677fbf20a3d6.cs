using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WireCable
{
    public class PIXIE_09c63297_75b6_432d_8ae3_677fbf20a3d6 : Pixie
    {
        public PIXIE_09c63297_75b6_432d_8ae3_677fbf20a3d6()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#997a7a"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#997a7a"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f5959"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b29b9b"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b29b9b"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b29b9b"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 585f;
_content = "var arrFillColor = new Array(6); var arrBorderColor = new Array(6); var arrBorderWidth = new Array(6); arrFillColor[0] = '#997a7a'; arrFillColor[1] = '#997a7a'; arrFillColor[2] = '#7f5959'; arrFillColor[3] = '#b29b9b'; arrFillColor[4] = '#b29b9b'; arrFillColor[5] = '#b29b9b'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(542,435);ctx.lineTo(563,456);ctx.lineTo(970,456);ctx.lineTo(970,285);ctx.lineTo(563,285);ctx.lineTo(542,306);ctx.lineTo(542,435);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(285,477);ctx.lineTo(842,477);ctx.lineTo(842,563);ctx.lineTo(285,563);ctx.lineTo(285,477);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(306,563);ctx.lineTo(842,563);ctx.lineTo(842,585);ctx.lineTo(306,585);ctx.lineTo(306,563);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(135,563);ctx.lineTo(306,563);ctx.lineTo(306,585);ctx.lineTo(135,585);ctx.lineTo(135,563);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(156,263);ctx.lineTo(178,242);ctx.lineTo(263,242);ctx.lineTo(285,263);ctx.lineTo(156,263);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(92,392);ctx.lineTo(92,349);ctx.lineTo(156,349);ctx.lineTo(156,392);ctx.lineTo(92,392);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(542,435));listpt.Add(new Point(563,456));listpt.Add(new Point(970,456));listpt.Add(new Point(970,285));listpt.Add(new Point(563,285));listpt.Add(new Point(542,306));listpt.Add(new Point(542,435));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(285,477));listpt.Add(new Point(842,477));listpt.Add(new Point(842,563));listpt.Add(new Point(285,563));listpt.Add(new Point(285,477));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(306,563));listpt.Add(new Point(842,563));listpt.Add(new Point(842,585));listpt.Add(new Point(306,585));listpt.Add(new Point(306,563));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(135,563));listpt.Add(new Point(306,563));listpt.Add(new Point(306,585));listpt.Add(new Point(135,585));listpt.Add(new Point(135,563));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(156,263));listpt.Add(new Point(178,242));listpt.Add(new Point(263,242));listpt.Add(new Point(285,263));listpt.Add(new Point(156,263));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(92,392));listpt.Add(new Point(92,349));listpt.Add(new Point(156,349));listpt.Add(new Point(156,392));listpt.Add(new Point(92,392));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}