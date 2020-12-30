using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorBelt
{
    public class PIXIE_e5bcf02a_bbff_4a35_9880_da383ea83a89 : Pixie
    {
        public PIXIE_e5bcf02a_bbff_4a35_9880_da383ea83a89()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#c0c0c0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 499f; _h = 546f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#c0c0c0'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(15,546);ctx.lineTo(389,546);ctx.lineTo(396,473);ctx.lineTo(418,402);ctx.lineTo(452,338);ctx.lineTo(499,280);ctx.lineTo(234,15);ctx.lineTo(141,131);ctx.lineTo(73,259);ctx.lineTo(29,400);ctx.lineTo(15,546);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(15,546));listpt.Add(new Point(389,546));listpt.Add(new Point(396,473));listpt.Add(new Point(418,402));listpt.Add(new Point(452,338));listpt.Add(new Point(499,280));listpt.Add(new Point(234,15));listpt.Add(new Point(141,131));listpt.Add(new Point(73,259));listpt.Add(new Point(29,400));listpt.Add(new Point(15,546));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}