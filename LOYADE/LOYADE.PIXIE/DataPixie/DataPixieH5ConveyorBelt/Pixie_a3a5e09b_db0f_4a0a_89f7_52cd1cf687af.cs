using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorBelt
{
    public class PIXIE_a3a5e09b_db0f_4a0a_89f7_52cd1cf687af : Pixie
    {
        public PIXIE_a3a5e09b_db0f_4a0a_89f7_52cd1cf687af()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#c0c0c0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 772f; _h = 772f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#c0c0c0'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(22,772);ctx.lineTo(396,772);ctx.lineTo(403,699);ctx.lineTo(425,628);ctx.lineTo(459,564);ctx.lineTo(506,506);ctx.lineTo(563,459);ctx.lineTo(628,425);ctx.lineTo(698,404);ctx.lineTo(772,396);ctx.lineTo(772,22);ctx.lineTo(624,38);ctx.lineTo(485,80);ctx.lineTo(355,148);ctx.lineTo(241,241);ctx.lineTo(148,357);ctx.lineTo(80,485);ctx.lineTo(36,626);ctx.lineTo(22,772);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(22,772));listpt.Add(new Point(396,772));listpt.Add(new Point(403,699));listpt.Add(new Point(425,628));listpt.Add(new Point(459,564));listpt.Add(new Point(506,506));listpt.Add(new Point(563,459));listpt.Add(new Point(628,425));listpt.Add(new Point(698,404));listpt.Add(new Point(772,396));listpt.Add(new Point(772,22));listpt.Add(new Point(624,38));listpt.Add(new Point(485,80));listpt.Add(new Point(355,148));listpt.Add(new Point(241,241));listpt.Add(new Point(148,357));listpt.Add(new Point(80,485));listpt.Add(new Point(36,626));listpt.Add(new Point(22,772));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}