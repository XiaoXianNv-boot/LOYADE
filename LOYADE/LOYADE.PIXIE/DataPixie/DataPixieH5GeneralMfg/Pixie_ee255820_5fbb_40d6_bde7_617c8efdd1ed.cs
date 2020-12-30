using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_ee255820_5fbb_40d6_bde7_617c8efdd1ed : Pixie
    {
        public PIXIE_ee255820_5fbb_40d6_bde7_617c8efdd1ed()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#161717"));
_w = 386f; _h = 261f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#161717'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(11,261);ctx.lineTo(11,11);ctx.lineTo(175,230);ctx.lineTo(175,11);ctx.lineTo(339,230);ctx.lineTo(347,11);ctx.lineTo(378,11);ctx.lineTo(386,261);ctx.lineTo(11,261);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(11,261));listpt.Add(new Point(11,11));listpt.Add(new Point(175,230));listpt.Add(new Point(175,11));listpt.Add(new Point(339,230));listpt.Add(new Point(347,11));listpt.Add(new Point(378,11));listpt.Add(new Point(386,261));listpt.Add(new Point(11,261));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}