using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_bbf633c1_f02c_4395_a587_ee137c1a260d : Pixie
    {
        public PIXIE_bbf633c1_f02c_4395_a587_ee137c1a260d()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 656f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,656);ctx.lineTo(47,635);ctx.lineTo(64,615);ctx.lineTo(85,589);ctx.lineTo(106,558);ctx.lineTo(121,535);ctx.lineTo(135,510);ctx.lineTo(148,484);ctx.lineTo(160,457);ctx.lineTo(170,429);ctx.lineTo(178,400);ctx.lineTo(183,371);ctx.lineTo(185,342);ctx.lineTo(183,312);ctx.lineTo(178,283);ctx.lineTo(170,254);ctx.lineTo(160,227);ctx.lineTo(148,200);ctx.lineTo(135,173);ctx.lineTo(121,149);ctx.lineTo(106,126);ctx.lineTo(92,105);ctx.lineTo(71,77);ctx.lineTo(52,55);ctx.lineTo(35,35);ctx.lineTo(28,28);ctx.lineTo(28,28);ctx.lineTo(970,342);ctx.lineTo(28,656);ctx.lineTo(28,656);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,656));listpt.Add(new Point(47,635));listpt.Add(new Point(64,615));listpt.Add(new Point(85,589));listpt.Add(new Point(106,558));listpt.Add(new Point(121,535));listpt.Add(new Point(135,510));listpt.Add(new Point(148,484));listpt.Add(new Point(160,457));listpt.Add(new Point(170,429));listpt.Add(new Point(178,400));listpt.Add(new Point(183,371));listpt.Add(new Point(185,342));listpt.Add(new Point(183,312));listpt.Add(new Point(178,283));listpt.Add(new Point(170,254));listpt.Add(new Point(160,227));listpt.Add(new Point(148,200));listpt.Add(new Point(135,173));listpt.Add(new Point(121,149));listpt.Add(new Point(106,126));listpt.Add(new Point(92,105));listpt.Add(new Point(71,77));listpt.Add(new Point(52,55));listpt.Add(new Point(35,35));listpt.Add(new Point(28,28));listpt.Add(new Point(28,28));listpt.Add(new Point(970,342));listpt.Add(new Point(28,656));listpt.Add(new Point(28,656));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}