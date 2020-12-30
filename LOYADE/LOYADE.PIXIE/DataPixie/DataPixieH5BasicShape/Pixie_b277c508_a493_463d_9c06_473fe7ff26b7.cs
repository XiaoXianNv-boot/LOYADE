using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_b277c508_a493_463d_9c06_473fe7ff26b7 : Pixie
    {
        public PIXIE_b277c508_a493_463d_9c06_473fe7ff26b7()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 538f; _h = 637f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(18,412);ctx.lineTo(123,152);ctx.lineTo(201,18);ctx.lineTo(362,18);ctx.lineTo(439,152);ctx.lineTo(538,412);ctx.lineTo(405,637);ctx.lineTo(151,637);ctx.lineTo(18,412);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(18,412));listpt.Add(new Point(123,152));listpt.Add(new Point(201,18));listpt.Add(new Point(362,18));listpt.Add(new Point(439,152));listpt.Add(new Point(538,412));listpt.Add(new Point(405,637));listpt.Add(new Point(151,637));listpt.Add(new Point(18,412));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}