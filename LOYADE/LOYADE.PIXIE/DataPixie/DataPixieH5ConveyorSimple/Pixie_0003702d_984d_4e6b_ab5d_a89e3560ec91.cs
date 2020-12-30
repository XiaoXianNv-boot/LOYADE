using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorSimple
{
    public class PIXIE_0003702d_984d_4e6b_ab5d_a89e3560ec91 : Pixie
    {
        public PIXIE_0003702d_984d_4e6b_ab5d_a89e3560ec91()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 398f; _h = 772f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(22,22);ctx.lineTo(29,95);ctx.lineTo(51,166);ctx.lineTo(85,230);ctx.lineTo(132,288);ctx.lineTo(189,335);ctx.lineTo(254,369);ctx.lineTo(324,390);ctx.lineTo(398,398);ctx.lineTo(398,772);ctx.lineTo(250,756);ctx.lineTo(111,714);ctx.lineTo(23,668);ctx.lineTo(22,22);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(22,22));listpt.Add(new Point(29,95));listpt.Add(new Point(51,166));listpt.Add(new Point(85,230));listpt.Add(new Point(132,288));listpt.Add(new Point(189,335));listpt.Add(new Point(254,369));listpt.Add(new Point(324,390));listpt.Add(new Point(398,398));listpt.Add(new Point(398,772));listpt.Add(new Point(250,756));listpt.Add(new Point(111,714));listpt.Add(new Point(23,668));listpt.Add(new Point(22,22));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}