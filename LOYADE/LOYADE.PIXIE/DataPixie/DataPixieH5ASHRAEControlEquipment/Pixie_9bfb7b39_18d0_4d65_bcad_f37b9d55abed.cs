using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEControlEquipment
{
    public class PIXIE_9bfb7b39_18d0_4d65_bcad_f37b9d55abed : Pixie
    {
        public PIXIE_9bfb7b39_18d0_4d65_bcad_f37b9d55abed()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 852f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,87);ctx.lineTo(322,87);ctx.lineTo(322,28);ctx.lineTo(676,28);ctx.lineTo(676,87);ctx.lineTo(970,87);ctx.lineTo(970,794);ctx.lineTo(676,794);ctx.lineTo(676,852);ctx.lineTo(322,852);ctx.lineTo(322,794);ctx.lineTo(28,794);ctx.lineTo(28,87);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,87));listpt.Add(new Point(322,87));listpt.Add(new Point(322,28));listpt.Add(new Point(676,28));listpt.Add(new Point(676,87));listpt.Add(new Point(970,87));listpt.Add(new Point(970,794));listpt.Add(new Point(676,794));listpt.Add(new Point(676,852));listpt.Add(new Point(322,852));listpt.Add(new Point(322,794));listpt.Add(new Point(28,794));listpt.Add(new Point(28,87));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}