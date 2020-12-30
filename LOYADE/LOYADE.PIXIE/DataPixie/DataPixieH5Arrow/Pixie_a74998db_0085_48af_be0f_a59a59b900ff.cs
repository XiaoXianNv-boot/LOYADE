using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_a74998db_0085_48af_be0f_a59a59b900ff : Pixie
    {
        public PIXIE_a74998db_0085_48af_be0f_a59a59b900ff()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 852f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(970,196);ctx.lineTo(688,377);ctx.lineTo(688,271);ctx.lineTo(269,271);ctx.lineTo(269,567);ctx.lineTo(372,567);ctx.lineTo(201,852);ctx.lineTo(28,571);ctx.lineTo(146,571);ctx.lineTo(146,147);ctx.lineTo(679,147);ctx.lineTo(679,28);ctx.lineTo(970,196);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(970,196));listpt.Add(new Point(688,377));listpt.Add(new Point(688,271));listpt.Add(new Point(269,271));listpt.Add(new Point(269,567));listpt.Add(new Point(372,567));listpt.Add(new Point(201,852));listpt.Add(new Point(28,571));listpt.Add(new Point(146,571));listpt.Add(new Point(146,147));listpt.Add(new Point(679,147));listpt.Add(new Point(679,28));listpt.Add(new Point(970,196));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}