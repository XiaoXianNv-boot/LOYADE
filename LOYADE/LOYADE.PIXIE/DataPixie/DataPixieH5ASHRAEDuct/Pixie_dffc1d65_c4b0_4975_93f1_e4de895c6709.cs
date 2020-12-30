using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEDuct
{
    public class PIXIE_dffc1d65_c4b0_4975_93f1_e4de895c6709 : Pixie
    {
        public PIXIE_dffc1d65_c4b0_4975_93f1_e4de895c6709()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 309f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(874,309);ctx.lineTo(927,276);ctx.lineTo(960,225);ctx.lineTo(970,168);ctx.lineTo(960,112);ctx.lineTo(927,61);ctx.lineTo(874,28);ctx.lineTo(28,28);ctx.lineTo(80,61);ctx.lineTo(112,112);ctx.lineTo(123,168);ctx.lineTo(112,225);ctx.lineTo(80,276);ctx.lineTo(28,309);ctx.lineTo(874,309);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(874,309));listpt.Add(new Point(927,276));listpt.Add(new Point(960,225));listpt.Add(new Point(970,168));listpt.Add(new Point(960,112));listpt.Add(new Point(927,61));listpt.Add(new Point(874,28));listpt.Add(new Point(28,28));listpt.Add(new Point(80,61));listpt.Add(new Point(112,112));listpt.Add(new Point(123,168));listpt.Add(new Point(112,225));listpt.Add(new Point(80,276));listpt.Add(new Point(28,309));listpt.Add(new Point(874,309));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}