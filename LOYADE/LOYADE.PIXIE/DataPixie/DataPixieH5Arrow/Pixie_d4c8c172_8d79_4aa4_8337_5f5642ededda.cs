using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_d4c8c172_8d79_4aa4_8337_5f5642ededda : Pixie
    {
        public PIXIE_d4c8c172_8d79_4aa4_8337_5f5642ededda()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 441f; _h = 970f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(234,28);ctx.lineTo(441,387);ctx.lineTo(302,387);ctx.lineTo(387,970);ctx.lineTo(234,867);ctx.lineTo(78,970);ctx.lineTo(164,387);ctx.lineTo(28,387);ctx.lineTo(234,28);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(234,28));listpt.Add(new Point(441,387));listpt.Add(new Point(302,387));listpt.Add(new Point(387,970));listpt.Add(new Point(234,867));listpt.Add(new Point(78,970));listpt.Add(new Point(164,387));listpt.Add(new Point(28,387));listpt.Add(new Point(234,28));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}