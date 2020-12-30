using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Building
{
    public class PIXIE_282234a9_fe5b_4aee_a37b_1bb45d6a4ae2 : Pixie
    {
        public PIXIE_282234a9_fe5b_4aee_a37b_1bb45d6a4ae2()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 263f;
_content = "var arrFillColor = new Array(6); var arrBorderColor = new Array(6); var arrBorderWidth = new Array(6); arrFillColor[0] = '#ccc'; arrFillColor[1] = '#e5e5e5'; arrFillColor[2] = '#999'; arrFillColor[3] = '#999'; arrFillColor[4] = '#999'; arrFillColor[5] = '#999'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,263);ctx.lineTo(28,106);ctx.lineTo(852,106);ctx.lineTo(852,263);ctx.lineTo(28,263);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(852,106);ctx.lineTo(911,28);ctx.lineTo(126,28);ctx.lineTo(28,106);ctx.lineTo(852,106);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(617,263);ctx.lineTo(617,165);ctx.lineTo(735,165);ctx.lineTo(735,263);ctx.lineTo(617,263);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(381,263);ctx.lineTo(381,165);ctx.lineTo(499,165);ctx.lineTo(499,263);ctx.lineTo(381,263);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(146,263);ctx.lineTo(146,165);ctx.lineTo(263,165);ctx.lineTo(263,263);ctx.lineTo(146,263);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(852,263);ctx.lineTo(852,106);ctx.lineTo(911,28);ctx.lineTo(970,47);ctx.lineTo(970,204);ctx.lineTo(852,263);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,263));listpt.Add(new Point(28,106));listpt.Add(new Point(852,106));listpt.Add(new Point(852,263));listpt.Add(new Point(28,263));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(852,106));listpt.Add(new Point(911,28));listpt.Add(new Point(126,28));listpt.Add(new Point(28,106));listpt.Add(new Point(852,106));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(617,263));listpt.Add(new Point(617,165));listpt.Add(new Point(735,165));listpt.Add(new Point(735,263));listpt.Add(new Point(617,263));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(381,263));listpt.Add(new Point(381,165));listpt.Add(new Point(499,165));listpt.Add(new Point(499,263));listpt.Add(new Point(381,263));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(146,263));listpt.Add(new Point(146,165));listpt.Add(new Point(263,165));listpt.Add(new Point(263,263));listpt.Add(new Point(146,263));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(852,263));listpt.Add(new Point(852,106));listpt.Add(new Point(911,28));listpt.Add(new Point(970,47));listpt.Add(new Point(970,204));listpt.Add(new Point(852,263));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}