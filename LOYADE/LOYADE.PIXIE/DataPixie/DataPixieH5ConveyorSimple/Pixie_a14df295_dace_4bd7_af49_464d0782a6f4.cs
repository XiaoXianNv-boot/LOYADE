using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorSimple
{
    public class PIXIE_a14df295_dace_4bd7_af49_464d0782a6f4 : Pixie
    {
        public PIXIE_a14df295_dace_4bd7_af49_464d0782a6f4()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 772f; _h = 398f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(22,22);ctx.lineTo(95,29);ctx.lineTo(166,51);ctx.lineTo(230,85);ctx.lineTo(288,132);ctx.lineTo(335,189);ctx.lineTo(369,254);ctx.lineTo(390,324);ctx.lineTo(398,398);ctx.lineTo(772,398);ctx.lineTo(756,250);ctx.lineTo(714,111);ctx.lineTo(668,23);ctx.lineTo(22,22);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(22,22));listpt.Add(new Point(95,29));listpt.Add(new Point(166,51));listpt.Add(new Point(230,85));listpt.Add(new Point(288,132));listpt.Add(new Point(335,189));listpt.Add(new Point(369,254));listpt.Add(new Point(390,324));listpt.Add(new Point(398,398));listpt.Add(new Point(772,398));listpt.Add(new Point(756,250));listpt.Add(new Point(714,111));listpt.Add(new Point(668,23));listpt.Add(new Point(22,22));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}