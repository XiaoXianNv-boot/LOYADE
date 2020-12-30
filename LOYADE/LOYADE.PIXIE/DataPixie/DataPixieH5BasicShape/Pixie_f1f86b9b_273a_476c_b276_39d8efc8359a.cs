using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_f1f86b9b_273a_476c_b276_39d8efc8359a : Pixie
    {
        public PIXIE_f1f86b9b_273a_476c_b276_39d8efc8359a()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 503f; _h = 685f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(19,383);ctx.lineTo(140,109);ctx.lineTo(262,19);ctx.lineTo(383,109);ctx.lineTo(503,383);ctx.lineTo(398,685);ctx.lineTo(126,685);ctx.lineTo(19,383);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(19,383));listpt.Add(new Point(140,109));listpt.Add(new Point(262,19));listpt.Add(new Point(383,109));listpt.Add(new Point(503,383));listpt.Add(new Point(398,685));listpt.Add(new Point(126,685));listpt.Add(new Point(19,383));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}