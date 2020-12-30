using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_dbd2a5ee_690a_4ada_b67a_dacf8c109af3 : Pixie
    {
        public PIXIE_dbd2a5ee_690a_4ada_b67a_dacf8c109af3()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 322f; _h = 259f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrFillColor[2] = '#0ff'; arrFillColor[3] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(103,9);ctx.lineTo(84,11);ctx.lineTo(66,16);ctx.lineTo(50,25);ctx.lineTo(37,36);ctx.lineTo(25,50);ctx.lineTo(16,66);ctx.lineTo(11,83);ctx.lineTo(9,102);ctx.lineTo(10,112);ctx.lineTo(11,122);ctx.lineTo(14,132);ctx.lineTo(17,141);ctx.lineTo(72,259);ctx.lineTo(197,259);ctx.lineTo(142,141);ctx.lineTo(139,132);ctx.lineTo(136,122);ctx.lineTo(135,112);ctx.lineTo(134,102);ctx.lineTo(136,83);ctx.lineTo(141,66);ctx.lineTo(150,50);ctx.lineTo(162,36);ctx.lineTo(175,25);ctx.lineTo(191,16);ctx.lineTo(209,11);ctx.lineTo(228,9);ctx.lineTo(103,9);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(228,102,94,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(228,102,62,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(228,102,31,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(103,9));listpt.Add(new Point(84,11));listpt.Add(new Point(66,16));listpt.Add(new Point(50,25));listpt.Add(new Point(37,36));listpt.Add(new Point(25,50));listpt.Add(new Point(16,66));listpt.Add(new Point(11,83));listpt.Add(new Point(9,102));listpt.Add(new Point(10,112));listpt.Add(new Point(11,122));listpt.Add(new Point(14,132));listpt.Add(new Point(17,141));listpt.Add(new Point(72,259));listpt.Add(new Point(197,259));listpt.Add(new Point(142,141));listpt.Add(new Point(139,132));listpt.Add(new Point(136,122));listpt.Add(new Point(135,112));listpt.Add(new Point(134,102));listpt.Add(new Point(136,83));listpt.Add(new Point(141,66));listpt.Add(new Point(150,50));listpt.Add(new Point(162,36));listpt.Add(new Point(175,25));listpt.Add(new Point(191,16));listpt.Add(new Point(209,11));listpt.Add(new Point(228,9));listpt.Add(new Point(103,9));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 134f,8f,188f,188f);g.DrawEllipse(p, 134f,8f,188f,188f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillEllipse(sb, 166f,40f,124f,124f);g.DrawEllipse(p, 166f,40f,124f,124f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillEllipse(sb, 197f,71f,62f,62f);g.DrawEllipse(p, 197f,71f,62f,62f);
        }
    }
}