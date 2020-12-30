using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorSimple
{
    public class PIXIE_faf29578_2d92_443a_8899_ed76330b67e9 : Pixie
    {
        public PIXIE_faf29578_2d92_443a_8899_ed76330b67e9()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 500f; _h = 545f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(279,15);ctx.lineTo(15,279);ctx.lineTo(61,336);ctx.lineTo(96,402);ctx.lineTo(117,471);ctx.lineTo(125,545);ctx.lineTo(500,545);ctx.lineTo(483,397);ctx.lineTo(441,259);ctx.lineTo(372,128);ctx.lineTo(279,15);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(279,15));listpt.Add(new Point(15,279));listpt.Add(new Point(61,336));listpt.Add(new Point(96,402));listpt.Add(new Point(117,471));listpt.Add(new Point(125,545));listpt.Add(new Point(500,545));listpt.Add(new Point(483,397));listpt.Add(new Point(441,259));listpt.Add(new Point(372,128));listpt.Add(new Point(279,15));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}