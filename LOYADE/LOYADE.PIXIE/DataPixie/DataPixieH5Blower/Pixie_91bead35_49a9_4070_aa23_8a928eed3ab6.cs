using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Blower
{
    public class PIXIE_91bead35_49a9_4070_aa23_8a928eed3ab6 : Pixie
    {
        public PIXIE_91bead35_49a9_4070_aa23_8a928eed3ab6()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 320f; _h = 970f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#000'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(291,967);ctx.lineTo(278,970);ctx.lineTo(235,970);ctx.lineTo(224,967);ctx.lineTo(212,961);ctx.lineTo(203,952);ctx.lineTo(197,940);ctx.lineTo(194,927);ctx.lineTo(194,823);ctx.lineTo(320,823);ctx.lineTo(320,927);ctx.lineTo(316,940);ctx.lineTo(311,952);ctx.lineTo(301,961);ctx.lineTo(291,967);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(291,967));listpt.Add(new Point(278,970));listpt.Add(new Point(235,970));listpt.Add(new Point(224,967));listpt.Add(new Point(212,961));listpt.Add(new Point(203,952));listpt.Add(new Point(197,940));listpt.Add(new Point(194,927));listpt.Add(new Point(194,823));listpt.Add(new Point(320,823));listpt.Add(new Point(320,927));listpt.Add(new Point(316,940));listpt.Add(new Point(311,952));listpt.Add(new Point(301,961));listpt.Add(new Point(291,967));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}