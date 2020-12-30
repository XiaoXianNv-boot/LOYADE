using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_6fce6f3a_7768_405a_9da8_fae22912a14a : Pixie
    {
        public PIXIE_6fce6f3a_7768_405a_9da8_fae22912a14a()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 971f; _h = 665f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(105,27);ctx.lineTo(971,27);ctx.lineTo(939,93);ctx.lineTo(916,164);ctx.lineTo(899,236);ctx.lineTo(893,308);ctx.lineTo(893,383);ctx.lineTo(899,457);ctx.lineTo(916,527);ctx.lineTo(939,597);ctx.lineTo(971,665);ctx.lineTo(105,665);ctx.lineTo(76,597);ctx.lineTo(51,527);ctx.lineTo(36,457);ctx.lineTo(27,383);ctx.lineTo(27,308);ctx.lineTo(36,236);ctx.lineTo(51,164);ctx.lineTo(76,93);ctx.lineTo(105,27);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(105,27));listpt.Add(new Point(971,27));listpt.Add(new Point(939,93));listpt.Add(new Point(916,164));listpt.Add(new Point(899,236));listpt.Add(new Point(893,308));listpt.Add(new Point(893,383));listpt.Add(new Point(899,457));listpt.Add(new Point(916,527));listpt.Add(new Point(939,597));listpt.Add(new Point(971,665));listpt.Add(new Point(105,665));listpt.Add(new Point(76,597));listpt.Add(new Point(51,527));listpt.Add(new Point(36,457));listpt.Add(new Point(27,383));listpt.Add(new Point(27,308));listpt.Add(new Point(36,236));listpt.Add(new Point(51,164));listpt.Add(new Point(76,93));listpt.Add(new Point(105,27));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}