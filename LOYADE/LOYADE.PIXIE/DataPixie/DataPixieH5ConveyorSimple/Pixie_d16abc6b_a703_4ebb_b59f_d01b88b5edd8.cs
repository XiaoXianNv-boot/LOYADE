using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorSimple
{
    public class PIXIE_d16abc6b_a703_4ebb_b59f_d01b88b5edd8 : Pixie
    {
        public PIXIE_d16abc6b_a703_4ebb_b59f_d01b88b5edd8()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 398f; _h = 772f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(398,22);ctx.lineTo(391,95);ctx.lineTo(369,166);ctx.lineTo(335,230);ctx.lineTo(288,288);ctx.lineTo(231,335);ctx.lineTo(166,369);ctx.lineTo(96,390);ctx.lineTo(22,398);ctx.lineTo(22,772);ctx.lineTo(170,756);ctx.lineTo(309,714);ctx.lineTo(397,668);ctx.lineTo(398,22);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(398,22));listpt.Add(new Point(391,95));listpt.Add(new Point(369,166));listpt.Add(new Point(335,230));listpt.Add(new Point(288,288));listpt.Add(new Point(231,335));listpt.Add(new Point(166,369));listpt.Add(new Point(96,390));listpt.Add(new Point(22,398));listpt.Add(new Point(22,772));listpt.Add(new Point(170,756));listpt.Add(new Point(309,714));listpt.Add(new Point(397,668));listpt.Add(new Point(398,22));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}