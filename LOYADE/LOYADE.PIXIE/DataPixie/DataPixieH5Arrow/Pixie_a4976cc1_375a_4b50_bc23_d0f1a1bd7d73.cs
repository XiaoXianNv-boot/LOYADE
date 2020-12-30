using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_a4976cc1_375a_4b50_bc23_d0f1a1bd7d73 : Pixie
    {
        public PIXIE_a4976cc1_375a_4b50_bc23_d0f1a1bd7d73()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 656f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrFillColor[2] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,342);ctx.lineTo(280,28);ctx.lineTo(452,28);ctx.lineTo(192,342);ctx.lineTo(452,656);ctx.lineTo(280,656);ctx.lineTo(28,342);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(287,342);ctx.lineTo(539,28);ctx.lineTo(711,28);ctx.lineTo(452,342);ctx.lineTo(711,656);ctx.lineTo(539,656);ctx.lineTo(287,342);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(546,342);ctx.lineTo(798,28);ctx.lineTo(970,28);ctx.lineTo(711,342);ctx.lineTo(970,656);ctx.lineTo(798,656);ctx.lineTo(546,342);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,342));listpt.Add(new Point(280,28));listpt.Add(new Point(452,28));listpt.Add(new Point(192,342));listpt.Add(new Point(452,656));listpt.Add(new Point(280,656));listpt.Add(new Point(28,342));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(287,342));listpt.Add(new Point(539,28));listpt.Add(new Point(711,28));listpt.Add(new Point(452,342));listpt.Add(new Point(711,656));listpt.Add(new Point(539,656));listpt.Add(new Point(287,342));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(546,342));listpt.Add(new Point(798,28));listpt.Add(new Point(970,28));listpt.Add(new Point(711,342));listpt.Add(new Point(970,656));listpt.Add(new Point(798,656));listpt.Add(new Point(546,342));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}