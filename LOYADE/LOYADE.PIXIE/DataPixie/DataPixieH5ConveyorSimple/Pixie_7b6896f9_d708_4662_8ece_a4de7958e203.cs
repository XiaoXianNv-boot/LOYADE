using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorSimple
{
    public class PIXIE_7b6896f9_d708_4662_8ece_a4de7958e203 : Pixie
    {
        public PIXIE_7b6896f9_d708_4662_8ece_a4de7958e203()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 772f; _h = 398f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(22,398);ctx.lineTo(95,391);ctx.lineTo(166,369);ctx.lineTo(230,335);ctx.lineTo(288,288);ctx.lineTo(335,231);ctx.lineTo(369,166);ctx.lineTo(390,96);ctx.lineTo(398,22);ctx.lineTo(772,22);ctx.lineTo(756,170);ctx.lineTo(714,309);ctx.lineTo(668,397);ctx.lineTo(22,398);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(22,398));listpt.Add(new Point(95,391));listpt.Add(new Point(166,369));listpt.Add(new Point(230,335));listpt.Add(new Point(288,288));listpt.Add(new Point(335,231));listpt.Add(new Point(369,166));listpt.Add(new Point(390,96));listpt.Add(new Point(398,22));listpt.Add(new Point(772,22));listpt.Add(new Point(756,170));listpt.Add(new Point(714,309));listpt.Add(new Point(668,397));listpt.Add(new Point(22,398));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}