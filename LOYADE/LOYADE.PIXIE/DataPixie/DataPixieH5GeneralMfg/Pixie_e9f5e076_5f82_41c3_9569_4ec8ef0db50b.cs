using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_e9f5e076_5f82_41c3_9569_4ec8ef0db50b : Pixie
    {
        public PIXIE_e9f5e076_5f82_41c3_9569_4ec8ef0db50b()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#161717"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#161717"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#161717"));
_w = 386f; _h = 261f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrFillColor[2] = '#0ff'; arrBorderColor[0] = '#161717'; arrBorderColor[1] = '#161717'; arrBorderColor[2] = '#161717'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(11,66);ctx.lineTo(73,66);ctx.lineTo(120,160);ctx.lineTo(277,160);ctx.lineTo(323,66);ctx.lineTo(386,66);ctx.lineTo(386,35);ctx.lineTo(300,35);ctx.lineTo(253,128);ctx.lineTo(144,128);ctx.lineTo(97,35);ctx.lineTo(11,35);ctx.lineTo(11,66);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(191,174);ctx.lineTo(210,174);ctx.lineTo(210,232);ctx.lineTo(228,224);ctx.lineTo(200,261);ctx.lineTo(173,224);ctx.lineTo(191,232);ctx.lineTo(191,174);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(191,11);ctx.lineTo(210,11);ctx.lineTo(210,70);ctx.lineTo(228,62);ctx.lineTo(200,99);ctx.lineTo(173,62);ctx.lineTo(191,70);ctx.lineTo(191,11);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(11,66));listpt.Add(new Point(73,66));listpt.Add(new Point(120,160));listpt.Add(new Point(277,160));listpt.Add(new Point(323,66));listpt.Add(new Point(386,66));listpt.Add(new Point(386,35));listpt.Add(new Point(300,35));listpt.Add(new Point(253,128));listpt.Add(new Point(144,128));listpt.Add(new Point(97,35));listpt.Add(new Point(11,35));listpt.Add(new Point(11,66));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(191,174));listpt.Add(new Point(210,174));listpt.Add(new Point(210,232));listpt.Add(new Point(228,224));listpt.Add(new Point(200,261));listpt.Add(new Point(173,224));listpt.Add(new Point(191,232));listpt.Add(new Point(191,174));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(191,11));listpt.Add(new Point(210,11));listpt.Add(new Point(210,70));listpt.Add(new Point(228,62));listpt.Add(new Point(200,99));listpt.Add(new Point(173,62));listpt.Add(new Point(191,70));listpt.Add(new Point(191,11));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}