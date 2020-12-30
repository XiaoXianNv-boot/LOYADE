using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_4a4f48da_5669_46c3_ab1a_66e6922685df : Pixie
    {
        public PIXIE_4a4f48da_5669_46c3_ab1a_66e6922685df()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 386f; _h = 261f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(11,261);ctx.lineTo(11,136);ctx.lineTo(74,11);ctx.lineTo(136,136);ctx.lineTo(199,11);ctx.lineTo(261,136);ctx.lineTo(324,11);ctx.lineTo(386,136);ctx.lineTo(386,261);ctx.lineTo(11,261);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(11,261));listpt.Add(new Point(11,136));listpt.Add(new Point(74,11));listpt.Add(new Point(136,136));listpt.Add(new Point(199,11));listpt.Add(new Point(261,136));listpt.Add(new Point(324,11));listpt.Add(new Point(386,136));listpt.Add(new Point(386,261));listpt.Add(new Point(11,261));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}