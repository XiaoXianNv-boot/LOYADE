using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Food
{
    public class PIXIE_67296816_93ea_4603_9fab_4308ee0780bd : Pixie
    {
        public PIXIE_67296816_93ea_4603_9fab_4308ee0780bd()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#cff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 801f; _h = 970f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#cff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,970);ctx.lineTo(28,801);ctx.lineTo(124,343);ctx.lineTo(28,343);ctx.lineTo(28,173);ctx.lineTo(173,28);ctx.lineTo(655,28);ctx.lineTo(801,173);ctx.lineTo(801,343);ctx.lineTo(704,343);ctx.lineTo(801,801);ctx.lineTo(801,970);ctx.lineTo(28,970);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,970));listpt.Add(new Point(28,801));listpt.Add(new Point(124,343));listpt.Add(new Point(28,343));listpt.Add(new Point(28,173));listpt.Add(new Point(173,28));listpt.Add(new Point(655,28));listpt.Add(new Point(801,173));listpt.Add(new Point(801,343));listpt.Add(new Point(704,343));listpt.Add(new Point(801,801));listpt.Add(new Point(801,970));listpt.Add(new Point(28,970));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}