using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorSimple
{
    public class PIXIE_7284f2a9_ec13_4290_9b66_1a730ebdf35d : Pixie
    {
        public PIXIE_7284f2a9_ec13_4290_9b66_1a730ebdf35d()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 546f; _h = 499f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(546,499);ctx.lineTo(546,125);ctx.lineTo(473,118);ctx.lineTo(402,96);ctx.lineTo(338,62);ctx.lineTo(280,15);ctx.lineTo(15,280);ctx.lineTo(131,373);ctx.lineTo(259,441);ctx.lineTo(400,485);ctx.lineTo(546,499);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(546,499));listpt.Add(new Point(546,125));listpt.Add(new Point(473,118));listpt.Add(new Point(402,96));listpt.Add(new Point(338,62));listpt.Add(new Point(280,15));listpt.Add(new Point(15,280));listpt.Add(new Point(131,373));listpt.Add(new Point(259,441));listpt.Add(new Point(400,485));listpt.Add(new Point(546,499));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}