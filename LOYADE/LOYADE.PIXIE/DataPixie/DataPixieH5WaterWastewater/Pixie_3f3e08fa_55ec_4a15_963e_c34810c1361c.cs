using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WaterWastewater
{
    public class PIXIE_3f3e08fa_55ec_4a15_963e_c34810c1361c : Pixie
    {
        public PIXIE_3f3e08fa_55ec_4a15_963e_c34810c1361c()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#ff7f00"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 381f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#ff7f00'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(224,28);ctx.lineTo(970,28);ctx.lineTo(970,381);ctx.lineTo(224,381);ctx.lineTo(224,361);ctx.lineTo(28,361);ctx.lineTo(28,47);ctx.lineTo(224,47);ctx.lineTo(224,28);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(224,28));listpt.Add(new Point(970,28));listpt.Add(new Point(970,381));listpt.Add(new Point(224,381));listpt.Add(new Point(224,361));listpt.Add(new Point(28,361));listpt.Add(new Point(28,47));listpt.Add(new Point(224,47));listpt.Add(new Point(224,28));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}