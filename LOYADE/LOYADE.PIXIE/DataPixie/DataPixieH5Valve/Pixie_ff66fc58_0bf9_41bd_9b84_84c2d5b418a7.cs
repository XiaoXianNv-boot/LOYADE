using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Valve
{
    public class PIXIE_ff66fc58_0bf9_41bd_9b84_84c2d5b418a7 : Pixie
    {
        public PIXIE_ff66fc58_0bf9_41bd_9b84_84c2d5b418a7()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#b2e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 852f; _h = 970f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#b2e5e5'; arrFillColor[1] = '#b2e5e5'; arrFillColor[2] = '#b2e5e5'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(185,420);ctx.lineTo(342,420);ctx.lineTo(342,970);ctx.lineTo(185,970);ctx.lineTo(185,420);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(106,303);ctx.lineTo(28,224);ctx.lineTo(28,106);ctx.lineTo(106,28);ctx.lineTo(420,28);ctx.lineTo(499,106);ctx.lineTo(499,224);ctx.lineTo(420,303);ctx.lineTo(342,303);ctx.lineTo(342,420);ctx.lineTo(185,420);ctx.lineTo(185,303);ctx.lineTo(106,303);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(67,892);ctx.lineTo(28,892);ctx.lineTo(28,617);ctx.lineTo(67,617);ctx.lineTo(67,656);ctx.lineTo(735,656);ctx.lineTo(813,578);ctx.lineTo(852,578);ctx.lineTo(852,931);ctx.lineTo(813,931);ctx.lineTo(735,852);ctx.lineTo(67,852);ctx.lineTo(67,892);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(185,420));listpt.Add(new Point(342,420));listpt.Add(new Point(342,970));listpt.Add(new Point(185,970));listpt.Add(new Point(185,420));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(106,303));listpt.Add(new Point(28,224));listpt.Add(new Point(28,106));listpt.Add(new Point(106,28));listpt.Add(new Point(420,28));listpt.Add(new Point(499,106));listpt.Add(new Point(499,224));listpt.Add(new Point(420,303));listpt.Add(new Point(342,303));listpt.Add(new Point(342,420));listpt.Add(new Point(185,420));listpt.Add(new Point(185,303));listpt.Add(new Point(106,303));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(67,892));listpt.Add(new Point(28,892));listpt.Add(new Point(28,617));listpt.Add(new Point(67,617));listpt.Add(new Point(67,656));listpt.Add(new Point(735,656));listpt.Add(new Point(813,578));listpt.Add(new Point(852,578));listpt.Add(new Point(852,931));listpt.Add(new Point(813,931));listpt.Add(new Point(735,852));listpt.Add(new Point(67,852));listpt.Add(new Point(67,892));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}