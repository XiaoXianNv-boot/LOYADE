using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorSimple
{
    public class PIXIE_b890862d_3ed2_48c0_a631_30a74c43a26b : Pixie
    {
        public PIXIE_b890862d_3ed2_48c0_a631_30a74c43a26b()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 765f; _h = 971f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(273,519);ctx.lineTo(221,563);ctx.lineTo(160,596);ctx.lineTo(96,615);ctx.lineTo(27,622);ctx.lineTo(27,971);ctx.lineTo(165,955);ctx.lineTo(293,916);ctx.lineTo(415,852);ctx.lineTo(519,765);ctx.lineTo(765,520);ctx.lineTo(765,27);ctx.lineTo(273,519);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(273,519));listpt.Add(new Point(221,563));listpt.Add(new Point(160,596));listpt.Add(new Point(96,615));listpt.Add(new Point(27,622));listpt.Add(new Point(27,971));listpt.Add(new Point(165,955));listpt.Add(new Point(293,916));listpt.Add(new Point(415,852));listpt.Add(new Point(519,765));listpt.Add(new Point(765,520));listpt.Add(new Point(765,27));listpt.Add(new Point(273,519));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}