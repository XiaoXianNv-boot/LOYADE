using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorSimple
{
    public class PIXIE_af82fdab_65f4_474c_a3ab_9504ac94373e : Pixie
    {
        public PIXIE_af82fdab_65f4_474c_a3ab_9504ac94373e()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 971f; _h = 765f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(479,273);ctx.lineTo(435,221);ctx.lineTo(402,160);ctx.lineTo(383,96);ctx.lineTo(376,27);ctx.lineTo(27,27);ctx.lineTo(43,165);ctx.lineTo(82,293);ctx.lineTo(146,415);ctx.lineTo(233,519);ctx.lineTo(478,765);ctx.lineTo(971,765);ctx.lineTo(479,273);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(479,273));listpt.Add(new Point(435,221));listpt.Add(new Point(402,160));listpt.Add(new Point(383,96));listpt.Add(new Point(376,27));listpt.Add(new Point(27,27));listpt.Add(new Point(43,165));listpt.Add(new Point(82,293));listpt.Add(new Point(146,415));listpt.Add(new Point(233,519));listpt.Add(new Point(478,765));listpt.Add(new Point(971,765));listpt.Add(new Point(479,273));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}