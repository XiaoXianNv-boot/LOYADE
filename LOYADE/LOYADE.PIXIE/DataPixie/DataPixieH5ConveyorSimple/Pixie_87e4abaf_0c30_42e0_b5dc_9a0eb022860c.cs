using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorSimple
{
    public class PIXIE_87e4abaf_0c30_42e0_b5dc_9a0eb022860c : Pixie
    {
        public PIXIE_87e4abaf_0c30_42e0_b5dc_9a0eb022860c()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 545f; _h = 500f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(15,236);ctx.lineTo(279,500);ctx.lineTo(336,454);ctx.lineTo(402,419);ctx.lineTo(471,398);ctx.lineTo(545,390);ctx.lineTo(545,15);ctx.lineTo(397,32);ctx.lineTo(259,74);ctx.lineTo(128,143);ctx.lineTo(15,236);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(15,236));listpt.Add(new Point(279,500));listpt.Add(new Point(336,454));listpt.Add(new Point(402,419));listpt.Add(new Point(471,398));listpt.Add(new Point(545,390));listpt.Add(new Point(545,15));listpt.Add(new Point(397,32));listpt.Add(new Point(259,74));listpt.Add(new Point(128,143));listpt.Add(new Point(15,236));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}