using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_6171c2ff_7dbc_4c94_a2c2_7b1ff96f1fca : Pixie
    {
        public PIXIE_6171c2ff_7dbc_4c94_a2c2_7b1ff96f1fca()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 560f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(970,294);ctx.lineTo(568,560);ctx.lineTo(568,378);ctx.lineTo(28,378);ctx.lineTo(28,209);ctx.lineTo(568,209);ctx.lineTo(568,28);ctx.lineTo(970,294);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(616,257);ctx.lineTo(75,257);ctx.lineTo(75,330);ctx.lineTo(616,330);ctx.lineTo(616,472);ctx.lineTo(886,294);ctx.lineTo(616,116);ctx.lineTo(616,257);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(970,294));listpt.Add(new Point(568,560));listpt.Add(new Point(568,378));listpt.Add(new Point(28,378));listpt.Add(new Point(28,209));listpt.Add(new Point(568,209));listpt.Add(new Point(568,28));listpt.Add(new Point(970,294));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(616,257));listpt.Add(new Point(75,257));listpt.Add(new Point(75,330));listpt.Add(new Point(616,330));listpt.Add(new Point(616,472));listpt.Add(new Point(886,294));listpt.Add(new Point(616,116));listpt.Add(new Point(616,257));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}