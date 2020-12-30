using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorSimple
{
    public class PIXIE_93d5bc2a_3c57_4d43_907f_6eeb4641cf14 : Pixie
    {
        public PIXIE_93d5bc2a_3c57_4d43_907f_6eeb4641cf14()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 772f; _h = 398f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(772,22);ctx.lineTo(699,29);ctx.lineTo(628,51);ctx.lineTo(564,85);ctx.lineTo(506,132);ctx.lineTo(459,189);ctx.lineTo(425,254);ctx.lineTo(404,324);ctx.lineTo(396,398);ctx.lineTo(22,398);ctx.lineTo(38,250);ctx.lineTo(80,111);ctx.lineTo(126,23);ctx.lineTo(772,22);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(772,22));listpt.Add(new Point(699,29));listpt.Add(new Point(628,51));listpt.Add(new Point(564,85));listpt.Add(new Point(506,132));listpt.Add(new Point(459,189));listpt.Add(new Point(425,254));listpt.Add(new Point(404,324));listpt.Add(new Point(396,398));listpt.Add(new Point(22,398));listpt.Add(new Point(38,250));listpt.Add(new Point(80,111));listpt.Add(new Point(126,23));listpt.Add(new Point(772,22));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}