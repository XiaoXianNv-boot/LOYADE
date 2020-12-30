using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorBelt
{
    public class PIXIE_0992dff8_d99c_43ce_b78c_a5ed91a0affb : Pixie
    {
        public PIXIE_0992dff8_d99c_43ce_b78c_a5ed91a0affb()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#c0c0c0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 499f; _h = 546f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#c0c0c0'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(499,546);ctx.lineTo(125,546);ctx.lineTo(118,473);ctx.lineTo(96,402);ctx.lineTo(62,338);ctx.lineTo(15,280);ctx.lineTo(280,15);ctx.lineTo(373,131);ctx.lineTo(441,259);ctx.lineTo(485,400);ctx.lineTo(499,546);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(499,546));listpt.Add(new Point(125,546));listpt.Add(new Point(118,473));listpt.Add(new Point(96,402));listpt.Add(new Point(62,338));listpt.Add(new Point(15,280));listpt.Add(new Point(280,15));listpt.Add(new Point(373,131));listpt.Add(new Point(441,259));listpt.Add(new Point(485,400));listpt.Add(new Point(499,546));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}