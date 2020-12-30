using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Duct
{
    public class PIXIE_e3e0c240_8e8f_4f23_864b_843188f921ca : Pixie
    {
        public PIXIE_e3e0c240_8e8f_4f23_864b_843188f921ca()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 969f; _h = 970f;
_content = "var arrFillColor = new Array(7); var arrBorderColor = new Array(7); var arrBorderWidth = new Array(7); arrFillColor[0] = '#ccc'; arrFillColor[1] = '#4c4c4c'; arrFillColor[2] = '#4c4c4c'; arrFillColor[3] = '#b2b2b2'; arrFillColor[4] = '#4c4c4c'; arrFillColor[5] = '#4c4c4c'; arrFillColor[6] = '#b2b2b2'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderColor[6] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; arrBorderWidth[6] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,152);ctx.lineTo(152,154);ctx.lineTo(152,28);ctx.lineTo(778,28);ctx.lineTo(780,154);ctx.lineTo(906,152);ctx.lineTo(906,780);ctx.lineTo(780,780);ctx.lineTo(780,906);ctx.lineTo(152,906);ctx.lineTo(152,780);ctx.lineTo(28,780);ctx.lineTo(28,152);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(969,806);ctx.lineTo(874,806);ctx.lineTo(874,827);ctx.lineTo(969,827);ctx.lineTo(969,806);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(969,105);ctx.lineTo(874,105);ctx.lineTo(874,126);ctx.lineTo(969,126);ctx.lineTo(969,105);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(936,844);ctx.lineTo(906,844);ctx.lineTo(906,90);ctx.lineTo(936,90);ctx.lineTo(936,844);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(806,876);ctx.lineTo(806,970);ctx.lineTo(825,970);ctx.lineTo(825,876);ctx.lineTo(806,876);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(105,876);ctx.lineTo(105,970);ctx.lineTo(126,970);ctx.lineTo(126,876);ctx.lineTo(105,876);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(842,906);ctx.lineTo(842,938);ctx.lineTo(90,938);ctx.lineTo(90,906);ctx.lineTo(842,906);ctx.fillStyle = arrFillColor[6];ctx.fill();ctx.lineWidth = arrBorderWidth[6];ctx.strokeStyle = arrBorderColor[6];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,152));listpt.Add(new Point(152,154));listpt.Add(new Point(152,28));listpt.Add(new Point(778,28));listpt.Add(new Point(780,154));listpt.Add(new Point(906,152));listpt.Add(new Point(906,780));listpt.Add(new Point(780,780));listpt.Add(new Point(780,906));listpt.Add(new Point(152,906));listpt.Add(new Point(152,780));listpt.Add(new Point(28,780));listpt.Add(new Point(28,152));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(969,806));listpt.Add(new Point(874,806));listpt.Add(new Point(874,827));listpt.Add(new Point(969,827));listpt.Add(new Point(969,806));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(969,105));listpt.Add(new Point(874,105));listpt.Add(new Point(874,126));listpt.Add(new Point(969,126));listpt.Add(new Point(969,105));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(936,844));listpt.Add(new Point(906,844));listpt.Add(new Point(906,90));listpt.Add(new Point(936,90));listpt.Add(new Point(936,844));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(806,876));listpt.Add(new Point(806,970));listpt.Add(new Point(825,970));listpt.Add(new Point(825,876));listpt.Add(new Point(806,876));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(105,876));listpt.Add(new Point(105,970));listpt.Add(new Point(126,970));listpt.Add(new Point(126,876));listpt.Add(new Point(105,876));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(842,906));listpt.Add(new Point(842,938));listpt.Add(new Point(90,938));listpt.Add(new Point(90,906));listpt.Add(new Point(842,906));sb = new SolidBrush(_listfillcolor[6]);p = new Pen(Color.Black);p.Width = _listborderwidth[6];p.Color = _listbordercolor[6];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}