using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEPipe
{
    public class PIXIE_a8b05966_2b12_4675_a9d1_3fd2e94d33fc : Pixie
    {
        public PIXIE_a8b05966_2b12_4675_a9d1_3fd2e94d33fc()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 852f; _h = 705f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(646,705);ctx.lineTo(146,204);ctx.lineTo(146,87);ctx.lineTo(852,87);ctx.lineTo(852,204);ctx.lineTo(322,204);ctx.lineTo(727,624);ctx.lineTo(646,705);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(646,705));listpt.Add(new Point(146,204));listpt.Add(new Point(146,87));listpt.Add(new Point(852,87));listpt.Add(new Point(852,204));listpt.Add(new Point(322,204));listpt.Add(new Point(727,624));listpt.Add(new Point(646,705));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}