using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Electrical
{
    public class PIXIE_3b3751f9_3495_4730_abb1_6caf6f67fbfc : Pixie
    {
        public PIXIE_3b3751f9_3495_4730_abb1_6caf6f67fbfc()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 396f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(499,396);ctx.lineTo(342,396);ctx.lineTo(345,365);ctx.lineTo(354,335);ctx.lineTo(369,309);ctx.lineTo(388,285);ctx.lineTo(411,266);ctx.lineTo(438,251);ctx.lineTo(467,242);ctx.lineTo(491,239);ctx.lineTo(499,239);ctx.lineTo(507,239);ctx.lineTo(538,244);ctx.lineTo(567,255);ctx.lineTo(593,270);ctx.lineTo(615,291);ctx.lineTo(633,315);ctx.lineTo(647,342);ctx.lineTo(654,372);ctx.lineTo(656,388);ctx.lineTo(656,396);ctx.lineTo(499,396);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(922,84,48,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(76,83,48,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(499,396));listpt.Add(new Point(342,396));listpt.Add(new Point(345,365));listpt.Add(new Point(354,335));listpt.Add(new Point(369,309));listpt.Add(new Point(388,285));listpt.Add(new Point(411,266));listpt.Add(new Point(438,251));listpt.Add(new Point(467,242));listpt.Add(new Point(491,239));listpt.Add(new Point(499,239));listpt.Add(new Point(507,239));listpt.Add(new Point(538,244));listpt.Add(new Point(567,255));listpt.Add(new Point(593,270));listpt.Add(new Point(615,291));listpt.Add(new Point(633,315));listpt.Add(new Point(647,342));listpt.Add(new Point(654,372));listpt.Add(new Point(656,388));listpt.Add(new Point(656,396));listpt.Add(new Point(499,396));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.DrawEllipse(p, 874f,36f,96f,96f);
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.DrawEllipse(p, 28f,35f,96f,96f);
        }
    }
}