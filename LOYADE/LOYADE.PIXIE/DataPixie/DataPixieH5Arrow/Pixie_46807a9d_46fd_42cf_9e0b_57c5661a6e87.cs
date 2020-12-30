using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_46807a9d_46fd_42cf_9e0b_57c5661a6e87 : Pixie
    {
        public PIXIE_46807a9d_46fd_42cf_9e0b_57c5661a6e87()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 971f; _h = 590f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(971,310);ctx.lineTo(579,590);ctx.lineTo(579,471);ctx.lineTo(727,366);ctx.lineTo(27,366);ctx.lineTo(27,310);ctx.lineTo(27,253);ctx.lineTo(727,253);ctx.lineTo(579,146);ctx.lineTo(579,27);ctx.lineTo(971,310);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(971,310));listpt.Add(new Point(579,590));listpt.Add(new Point(579,471));listpt.Add(new Point(727,366));listpt.Add(new Point(27,366));listpt.Add(new Point(27,310));listpt.Add(new Point(27,253));listpt.Add(new Point(727,253));listpt.Add(new Point(579,146));listpt.Add(new Point(579,27));listpt.Add(new Point(971,310));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}