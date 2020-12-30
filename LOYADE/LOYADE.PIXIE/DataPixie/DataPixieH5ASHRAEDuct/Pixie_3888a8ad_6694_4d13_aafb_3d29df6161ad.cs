using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEDuct
{
    public class PIXIE_3888a8ad_6694_4d13_aafb_3d29df6161ad : Pixie
    {
        public PIXIE_3888a8ad_6694_4d13_aafb_3d29df6161ad()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 853f; _h = 970f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(853,263);ctx.lineTo(578,263);ctx.lineTo(440,28);ctx.lineTo(28,263);ctx.lineTo(165,499);ctx.lineTo(28,735);ctx.lineTo(440,970);ctx.lineTo(578,735);ctx.lineTo(853,735);ctx.lineTo(853,263);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(853,263));listpt.Add(new Point(578,263));listpt.Add(new Point(440,28));listpt.Add(new Point(28,263));listpt.Add(new Point(165,499));listpt.Add(new Point(28,735));listpt.Add(new Point(440,970));listpt.Add(new Point(578,735));listpt.Add(new Point(853,735));listpt.Add(new Point(853,263));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}