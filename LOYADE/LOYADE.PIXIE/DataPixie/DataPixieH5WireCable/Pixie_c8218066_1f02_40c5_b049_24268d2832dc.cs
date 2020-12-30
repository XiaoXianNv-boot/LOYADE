using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WireCable
{
    public class PIXIE_c8218066_1f02_40c5_b049_24268d2832dc : Pixie
    {
        public PIXIE_c8218066_1f02_40c5_b049_24268d2832dc()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 438f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(192,438);ctx.lineTo(192,397);ctx.lineTo(171,397);ctx.lineTo(151,417);ctx.lineTo(48,417);ctx.lineTo(28,397);ctx.lineTo(28,315);ctx.lineTo(48,294);ctx.lineTo(151,294);ctx.lineTo(171,315);ctx.lineTo(192,315);ctx.lineTo(192,274);ctx.lineTo(274,274);ctx.lineTo(274,233);ctx.lineTo(151,28);ctx.lineTo(479,28);ctx.lineTo(356,233);ctx.lineTo(356,274);ctx.lineTo(601,274);ctx.lineTo(560,192);ctx.lineTo(704,192);ctx.lineTo(663,274);ctx.lineTo(970,274);ctx.lineTo(970,438);ctx.lineTo(192,438);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(192,438));listpt.Add(new Point(192,397));listpt.Add(new Point(171,397));listpt.Add(new Point(151,417));listpt.Add(new Point(48,417));listpt.Add(new Point(28,397));listpt.Add(new Point(28,315));listpt.Add(new Point(48,294));listpt.Add(new Point(151,294));listpt.Add(new Point(171,315));listpt.Add(new Point(192,315));listpt.Add(new Point(192,274));listpt.Add(new Point(274,274));listpt.Add(new Point(274,233));listpt.Add(new Point(151,28));listpt.Add(new Point(479,28));listpt.Add(new Point(356,233));listpt.Add(new Point(356,274));listpt.Add(new Point(601,274));listpt.Add(new Point(560,192));listpt.Add(new Point(704,192));listpt.Add(new Point(663,274));listpt.Add(new Point(970,274));listpt.Add(new Point(970,438));listpt.Add(new Point(192,438));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}