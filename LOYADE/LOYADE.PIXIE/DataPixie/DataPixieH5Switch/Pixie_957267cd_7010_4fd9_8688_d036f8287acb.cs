using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Switch
{
    public class PIXIE_957267cd_7010_4fd9_8688_d036f8287acb : Pixie
    {
        public PIXIE_957267cd_7010_4fd9_8688_d036f8287acb()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));
_w = 515f; _h = 348f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#000'; arrFillColor[1] = '#ccc'; arrFillColor[2] = '#7f7f7f'; arrFillColor[3] = '#e5e5e5'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#7f7f7f'; arrBorderColor[2] = '#7f7f7f'; arrBorderColor[3] = '#7f7f7f'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(15,15);ctx.lineTo(515,15);ctx.lineTo(515,348);ctx.lineTo(15,348);ctx.lineTo(15,15);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(26,338);ctx.lineTo(98,307);ctx.lineTo(432,57);ctx.lineTo(504,26);ctx.lineTo(26,26);ctx.lineTo(26,338);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(504,26);ctx.lineTo(432,57);ctx.lineTo(98,307);ctx.lineTo(26,338);ctx.lineTo(504,338);ctx.lineTo(504,26);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(98,56);ctx.lineTo(432,56);ctx.lineTo(432,307);ctx.lineTo(98,307);ctx.lineTo(98,56);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(15,15));listpt.Add(new Point(515,15));listpt.Add(new Point(515,348));listpt.Add(new Point(15,348));listpt.Add(new Point(15,15));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(26,338));listpt.Add(new Point(98,307));listpt.Add(new Point(432,57));listpt.Add(new Point(504,26));listpt.Add(new Point(26,26));listpt.Add(new Point(26,338));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(504,26));listpt.Add(new Point(432,57));listpt.Add(new Point(98,307));listpt.Add(new Point(26,338));listpt.Add(new Point(504,338));listpt.Add(new Point(504,26));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(98,56));listpt.Add(new Point(432,56));listpt.Add(new Point(432,307));listpt.Add(new Point(98,307));listpt.Add(new Point(98,56));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}