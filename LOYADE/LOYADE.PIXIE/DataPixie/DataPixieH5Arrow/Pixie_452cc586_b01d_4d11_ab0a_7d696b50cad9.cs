using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_452cc586_b01d_4d11_ab0a_7d696b50cad9 : Pixie
    {
        public PIXIE_452cc586_b01d_4d11_ab0a_7d696b50cad9()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 970f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(451,547);ctx.lineTo(232,547);ctx.lineTo(232,687);ctx.lineTo(28,499);ctx.lineTo(232,311);ctx.lineTo(232,451);ctx.lineTo(451,451);ctx.lineTo(451,232);ctx.lineTo(311,232);ctx.lineTo(499,28);ctx.lineTo(687,232);ctx.lineTo(547,232);ctx.lineTo(547,451);ctx.lineTo(766,451);ctx.lineTo(766,311);ctx.lineTo(970,499);ctx.lineTo(766,687);ctx.lineTo(766,547);ctx.lineTo(547,547);ctx.lineTo(547,766);ctx.lineTo(687,766);ctx.lineTo(499,970);ctx.lineTo(311,766);ctx.lineTo(451,766);ctx.lineTo(451,547);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(451,547));listpt.Add(new Point(232,547));listpt.Add(new Point(232,687));listpt.Add(new Point(28,499));listpt.Add(new Point(232,311));listpt.Add(new Point(232,451));listpt.Add(new Point(451,451));listpt.Add(new Point(451,232));listpt.Add(new Point(311,232));listpt.Add(new Point(499,28));listpt.Add(new Point(687,232));listpt.Add(new Point(547,232));listpt.Add(new Point(547,451));listpt.Add(new Point(766,451));listpt.Add(new Point(766,311));listpt.Add(new Point(970,499));listpt.Add(new Point(766,687));listpt.Add(new Point(766,547));listpt.Add(new Point(547,547));listpt.Add(new Point(547,766));listpt.Add(new Point(687,766));listpt.Add(new Point(499,970));listpt.Add(new Point(311,766));listpt.Add(new Point(451,766));listpt.Add(new Point(451,547));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}