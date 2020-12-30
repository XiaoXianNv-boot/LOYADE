using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_56fc62ab_9b61_477a_b2dc_8b8967efe7ef : Pixie
    {
        public PIXIE_56fc62ab_9b61_477a_b2dc_8b8967efe7ef()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 402f; _h = 970f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(166,28);ctx.lineTo(166,288);ctx.lineTo(402,288);ctx.lineTo(402,551);ctx.lineTo(166,551);ctx.lineTo(166,778);ctx.lineTo(283,669);ctx.lineTo(157,970);ctx.lineTo(28,669);ctx.lineTo(148,778);ctx.lineTo(148,530);ctx.lineTo(386,530);ctx.lineTo(386,305);ctx.lineTo(148,305);ctx.lineTo(148,28);ctx.lineTo(149,28);ctx.lineTo(151,28);ctx.lineTo(154,28);ctx.lineTo(157,28);ctx.lineTo(160,28);ctx.lineTo(163,28);ctx.lineTo(165,28);ctx.lineTo(166,28);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(166,28));listpt.Add(new Point(166,288));listpt.Add(new Point(402,288));listpt.Add(new Point(402,551));listpt.Add(new Point(166,551));listpt.Add(new Point(166,778));listpt.Add(new Point(283,669));listpt.Add(new Point(157,970));listpt.Add(new Point(28,669));listpt.Add(new Point(148,778));listpt.Add(new Point(148,530));listpt.Add(new Point(386,530));listpt.Add(new Point(386,305));listpt.Add(new Point(148,305));listpt.Add(new Point(148,28));listpt.Add(new Point(149,28));listpt.Add(new Point(151,28));listpt.Add(new Point(154,28));listpt.Add(new Point(157,28));listpt.Add(new Point(160,28));listpt.Add(new Point(163,28));listpt.Add(new Point(165,28));listpt.Add(new Point(166,28));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}