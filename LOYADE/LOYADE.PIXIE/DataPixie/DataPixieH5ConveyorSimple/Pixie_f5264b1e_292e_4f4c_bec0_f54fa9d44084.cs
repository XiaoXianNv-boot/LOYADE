using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorSimple
{
    public class PIXIE_f5264b1e_292e_4f4c_bec0_f54fa9d44084 : Pixie
    {
        public PIXIE_f5264b1e_292e_4f4c_bec0_f54fa9d44084()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 398f; _h = 772f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(22,772);ctx.lineTo(29,699);ctx.lineTo(51,628);ctx.lineTo(85,564);ctx.lineTo(132,506);ctx.lineTo(189,459);ctx.lineTo(254,425);ctx.lineTo(324,404);ctx.lineTo(398,396);ctx.lineTo(398,22);ctx.lineTo(250,38);ctx.lineTo(111,80);ctx.lineTo(23,126);ctx.lineTo(22,772);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(22,772));listpt.Add(new Point(29,699));listpt.Add(new Point(51,628));listpt.Add(new Point(85,564));listpt.Add(new Point(132,506));listpt.Add(new Point(189,459));listpt.Add(new Point(254,425));listpt.Add(new Point(324,404));listpt.Add(new Point(398,396));listpt.Add(new Point(398,22));listpt.Add(new Point(250,38));listpt.Add(new Point(111,80));listpt.Add(new Point(23,126));listpt.Add(new Point(22,772));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}