using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_cc844b9c_8335_422a_ac1a_a26981b35761 : Pixie
    {
        public PIXIE_cc844b9c_8335_422a_ac1a_a26981b35761()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 941f; _h = 970f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(941,28);ctx.lineTo(912,357);ctx.lineTo(825,269);ctx.lineTo(248,835);ctx.lineTo(348,928);ctx.lineTo(28,970);ctx.lineTo(60,663);ctx.lineTo(151,744);ctx.lineTo(725,177);ctx.lineTo(622,83);ctx.lineTo(941,28);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(941,28));listpt.Add(new Point(912,357));listpt.Add(new Point(825,269));listpt.Add(new Point(248,835));listpt.Add(new Point(348,928));listpt.Add(new Point(28,970));listpt.Add(new Point(60,663));listpt.Add(new Point(151,744));listpt.Add(new Point(725,177));listpt.Add(new Point(622,83));listpt.Add(new Point(941,28));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}