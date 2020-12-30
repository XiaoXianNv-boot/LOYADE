using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_700a2fbf_54eb_4651_a060_7919edb4b51d : Pixie
    {
        public PIXIE_700a2fbf_54eb_4651_a060_7919edb4b51d()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 405f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(232,169);ctx.lineTo(766,169);ctx.lineTo(766,28);ctx.lineTo(970,217);ctx.lineTo(766,405);ctx.lineTo(766,263);ctx.lineTo(232,263);ctx.lineTo(232,405);ctx.lineTo(28,217);ctx.lineTo(232,28);ctx.lineTo(232,169);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(232,169));listpt.Add(new Point(766,169));listpt.Add(new Point(766,28));listpt.Add(new Point(970,217));listpt.Add(new Point(766,405));listpt.Add(new Point(766,263));listpt.Add(new Point(232,263));listpt.Add(new Point(232,405));listpt.Add(new Point(28,217));listpt.Add(new Point(232,28));listpt.Add(new Point(232,169));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}