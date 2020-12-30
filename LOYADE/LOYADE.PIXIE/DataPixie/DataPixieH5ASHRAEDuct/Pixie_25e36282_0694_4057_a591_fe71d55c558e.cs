using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEDuct
{
    public class PIXIE_25e36282_0694_4057_a591_fe71d55c558e : Pixie
    {
        public PIXIE_25e36282_0694_4057_a591_fe71d55c558e()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 564f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(970,342);ctx.lineTo(970,28);ctx.lineTo(28,28);ctx.lineTo(28,342);ctx.lineTo(970,342);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(342,342);ctx.lineTo(656,342);ctx.lineTo(655,373);ctx.lineTo(650,403);ctx.lineTo(642,433);ctx.lineTo(632,462);ctx.lineTo(619,490);ctx.lineTo(603,517);ctx.lineTo(584,541);ctx.lineTo(564,564);ctx.lineTo(342,342);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(970,342));listpt.Add(new Point(970,28));listpt.Add(new Point(28,28));listpt.Add(new Point(28,342));listpt.Add(new Point(970,342));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(342,342));listpt.Add(new Point(656,342));listpt.Add(new Point(655,373));listpt.Add(new Point(650,403));listpt.Add(new Point(642,433));listpt.Add(new Point(632,462));listpt.Add(new Point(619,490));listpt.Add(new Point(603,517));listpt.Add(new Point(584,541));listpt.Add(new Point(564,564));listpt.Add(new Point(342,342));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}