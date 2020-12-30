using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorSimple
{
    public class PIXIE_a7d2c368_cf06_4162_b900_c2ae95de269a : Pixie
    {
        public PIXIE_a7d2c368_cf06_4162_b900_c2ae95de269a()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 398f; _h = 772f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(398,772);ctx.lineTo(391,699);ctx.lineTo(369,628);ctx.lineTo(335,564);ctx.lineTo(288,506);ctx.lineTo(231,459);ctx.lineTo(166,425);ctx.lineTo(96,404);ctx.lineTo(22,396);ctx.lineTo(22,22);ctx.lineTo(170,38);ctx.lineTo(309,80);ctx.lineTo(397,126);ctx.lineTo(398,772);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(398,772));listpt.Add(new Point(391,699));listpt.Add(new Point(369,628));listpt.Add(new Point(335,564));listpt.Add(new Point(288,506));listpt.Add(new Point(231,459));listpt.Add(new Point(166,425));listpt.Add(new Point(96,404));listpt.Add(new Point(22,396));listpt.Add(new Point(22,22));listpt.Add(new Point(170,38));listpt.Add(new Point(309,80));listpt.Add(new Point(397,126));listpt.Add(new Point(398,772));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}