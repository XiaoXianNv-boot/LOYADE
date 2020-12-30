using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorSimple
{
    public class PIXIE_702eb77d_c55b_4a93_a292_9eaa8af7eb88 : Pixie
    {
        public PIXIE_702eb77d_c55b_4a93_a292_9eaa8af7eb88()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 500f; _h = 545f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(236,545);ctx.lineTo(500,281);ctx.lineTo(454,224);ctx.lineTo(419,158);ctx.lineTo(398,89);ctx.lineTo(390,15);ctx.lineTo(15,15);ctx.lineTo(32,163);ctx.lineTo(74,301);ctx.lineTo(143,432);ctx.lineTo(236,545);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(236,545));listpt.Add(new Point(500,281));listpt.Add(new Point(454,224));listpt.Add(new Point(419,158));listpt.Add(new Point(398,89));listpt.Add(new Point(390,15));listpt.Add(new Point(15,15));listpt.Add(new Point(32,163));listpt.Add(new Point(74,301));listpt.Add(new Point(143,432));listpt.Add(new Point(236,545));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}