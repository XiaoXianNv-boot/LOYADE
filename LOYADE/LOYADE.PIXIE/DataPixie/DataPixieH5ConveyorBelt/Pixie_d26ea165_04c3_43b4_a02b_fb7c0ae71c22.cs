using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorBelt
{
    public class PIXIE_d26ea165_04c3_43b4_a02b_fb7c0ae71c22 : Pixie
    {
        public PIXIE_d26ea165_04c3_43b4_a02b_fb7c0ae71c22()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#c0c0c0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 818f; _h = 818f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#c0c0c0'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(23,553);ctx.lineTo(553,23);ctx.lineTo(818,288);ctx.lineTo(288,818);ctx.lineTo(23,553);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(23,553));listpt.Add(new Point(553,23));listpt.Add(new Point(818,288));listpt.Add(new Point(288,818));listpt.Add(new Point(23,553));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}