using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_6e1623a3_4376_472d_8070_ccf83ae329cf : Pixie
    {
        public PIXIE_6e1623a3_4376_472d_8070_ccf83ae329cf()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 257f; _h = 257f;
_content = "var arrFillColor = new Array(7); var arrBorderColor = new Array(7); var arrBorderWidth = new Array(7); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrFillColor[2] = '#0ff'; arrFillColor[3] = '#0ff'; arrFillColor[4] = '#0ff'; arrFillColor[5] = '#0ff'; arrFillColor[6] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderColor[6] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; arrBorderWidth[6] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(105,15);ctx.lineTo(112,7);ctx.lineTo(151,7);ctx.lineTo(159,15);ctx.lineTo(105,15);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(194,124);ctx.lineTo(194,23);ctx.lineTo(257,23);ctx.lineTo(257,34);ctx.lineTo(257,44);ctx.lineTo(257,55);ctx.lineTo(257,66);ctx.lineTo(257,76);ctx.lineTo(257,87);ctx.lineTo(257,98);ctx.lineTo(257,109);ctx.lineTo(256,114);ctx.lineTo(252,119);ctx.lineTo(247,123);ctx.lineTo(241,124);ctx.lineTo(194,124);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(69,124);ctx.lineTo(69,23);ctx.lineTo(7,23);ctx.lineTo(7,34);ctx.lineTo(7,44);ctx.lineTo(7,55);ctx.lineTo(7,66);ctx.lineTo(7,76);ctx.lineTo(7,87);ctx.lineTo(7,98);ctx.lineTo(7,109);ctx.lineTo(8,114);ctx.lineTo(12,119);ctx.lineTo(17,123);ctx.lineTo(23,124);ctx.lineTo(69,124);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(69,140);ctx.lineTo(69,257);ctx.lineTo(46,257);ctx.lineTo(69,140);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(77,23);ctx.lineTo(128,23);ctx.lineTo(128,257);ctx.lineTo(77,257);ctx.lineTo(77,23);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(136,23);ctx.lineTo(187,23);ctx.lineTo(187,257);ctx.lineTo(136,257);ctx.lineTo(136,23);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(195,140);ctx.lineTo(195,257);ctx.lineTo(218,257);ctx.lineTo(195,140);ctx.fillStyle = arrFillColor[6];ctx.fill();ctx.lineWidth = arrBorderWidth[6];ctx.strokeStyle = arrBorderColor[6];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(105,15));listpt.Add(new Point(112,7));listpt.Add(new Point(151,7));listpt.Add(new Point(159,15));listpt.Add(new Point(105,15));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(194,124));listpt.Add(new Point(194,23));listpt.Add(new Point(257,23));listpt.Add(new Point(257,34));listpt.Add(new Point(257,44));listpt.Add(new Point(257,55));listpt.Add(new Point(257,66));listpt.Add(new Point(257,76));listpt.Add(new Point(257,87));listpt.Add(new Point(257,98));listpt.Add(new Point(257,109));listpt.Add(new Point(256,114));listpt.Add(new Point(252,119));listpt.Add(new Point(247,123));listpt.Add(new Point(241,124));listpt.Add(new Point(194,124));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(69,124));listpt.Add(new Point(69,23));listpt.Add(new Point(7,23));listpt.Add(new Point(7,34));listpt.Add(new Point(7,44));listpt.Add(new Point(7,55));listpt.Add(new Point(7,66));listpt.Add(new Point(7,76));listpt.Add(new Point(7,87));listpt.Add(new Point(7,98));listpt.Add(new Point(7,109));listpt.Add(new Point(8,114));listpt.Add(new Point(12,119));listpt.Add(new Point(17,123));listpt.Add(new Point(23,124));listpt.Add(new Point(69,124));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(69,140));listpt.Add(new Point(69,257));listpt.Add(new Point(46,257));listpt.Add(new Point(69,140));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(77,23));listpt.Add(new Point(128,23));listpt.Add(new Point(128,257));listpt.Add(new Point(77,257));listpt.Add(new Point(77,23));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(136,23));listpt.Add(new Point(187,23));listpt.Add(new Point(187,257));listpt.Add(new Point(136,257));listpt.Add(new Point(136,23));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(195,140));listpt.Add(new Point(195,257));listpt.Add(new Point(218,257));listpt.Add(new Point(195,140));sb = new SolidBrush(_listfillcolor[6]);p = new Pen(Color.Black);p.Width = _listborderwidth[6];p.Color = _listbordercolor[6];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}