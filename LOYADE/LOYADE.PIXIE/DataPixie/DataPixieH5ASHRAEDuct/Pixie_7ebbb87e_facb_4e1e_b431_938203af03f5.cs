using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEDuct
{
    public class PIXIE_7ebbb87e_facb_4e1e_b431_938203af03f5 : Pixie
    {
        public PIXIE_7ebbb87e_facb_4e1e_b431_938203af03f5()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 542f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(199,542);ctx.lineTo(199,370);ctx.lineTo(28,370);ctx.lineTo(28,199);ctx.lineTo(199,199);ctx.lineTo(199,28);ctx.lineTo(799,28);ctx.lineTo(799,199);ctx.lineTo(970,199);ctx.lineTo(970,370);ctx.lineTo(799,370);ctx.lineTo(799,542);ctx.lineTo(199,542);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(199,542));listpt.Add(new Point(199,370));listpt.Add(new Point(28,370));listpt.Add(new Point(28,199));listpt.Add(new Point(199,199));listpt.Add(new Point(199,28));listpt.Add(new Point(799,28));listpt.Add(new Point(799,199));listpt.Add(new Point(970,199));listpt.Add(new Point(970,370));listpt.Add(new Point(799,370));listpt.Add(new Point(799,542));listpt.Add(new Point(199,542));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}