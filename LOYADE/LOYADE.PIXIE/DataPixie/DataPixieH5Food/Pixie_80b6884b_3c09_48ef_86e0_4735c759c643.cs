using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Food
{
    public class PIXIE_80b6884b_3c09_48ef_86e0_4735c759c643 : Pixie
    {
        public PIXIE_80b6884b_3c09_48ef_86e0_4735c759c643()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#633"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#633"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b27f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 390f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#633'; arrFillColor[1] = '#633'; arrFillColor[2] = '#7f4c4c'; arrFillColor[3] = '#b27f7f'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(263,280);ctx.lineTo(173,371);ctx.lineTo(173,173);ctx.lineTo(263,173);ctx.lineTo(263,280);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(916,226);ctx.lineTo(770,371);ctx.lineTo(789,190);ctx.lineTo(825,173);ctx.lineTo(935,63);ctx.lineTo(916,226);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(789,190);ctx.lineTo(770,371);ctx.lineTo(753,390);ctx.lineTo(282,390);ctx.lineTo(263,371);ctx.lineTo(246,209);ctx.lineTo(228,190);ctx.lineTo(209,209);ctx.lineTo(173,371);ctx.lineTo(154,390);ctx.lineTo(101,390);ctx.lineTo(82,371);ctx.lineTo(63,190);ctx.lineTo(28,173);ctx.lineTo(825,173);ctx.lineTo(789,190);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(173,28);ctx.lineTo(970,28);ctx.lineTo(825,173);ctx.lineTo(28,173);ctx.lineTo(173,28);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(263,280));listpt.Add(new Point(173,371));listpt.Add(new Point(173,173));listpt.Add(new Point(263,173));listpt.Add(new Point(263,280));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(916,226));listpt.Add(new Point(770,371));listpt.Add(new Point(789,190));listpt.Add(new Point(825,173));listpt.Add(new Point(935,63));listpt.Add(new Point(916,226));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(789,190));listpt.Add(new Point(770,371));listpt.Add(new Point(753,390));listpt.Add(new Point(282,390));listpt.Add(new Point(263,371));listpt.Add(new Point(246,209));listpt.Add(new Point(228,190));listpt.Add(new Point(209,209));listpt.Add(new Point(173,371));listpt.Add(new Point(154,390));listpt.Add(new Point(101,390));listpt.Add(new Point(82,371));listpt.Add(new Point(63,190));listpt.Add(new Point(28,173));listpt.Add(new Point(825,173));listpt.Add(new Point(789,190));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(173,28));listpt.Add(new Point(970,28));listpt.Add(new Point(825,173));listpt.Add(new Point(28,173));listpt.Add(new Point(173,28));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}