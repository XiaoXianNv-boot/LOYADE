using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_30dca63a_c3ca_42ec_b40d_cca10e8df3c2 : Pixie
    {
        public PIXIE_30dca63a_c3ca_42ec_b40d_cca10e8df3c2()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 671f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,135);ctx.lineTo(58,133);ctx.lineTo(85,124);ctx.lineTo(107,105);ctx.lineTo(117,78);ctx.lineTo(122,49);ctx.lineTo(122,35);ctx.lineTo(122,28);ctx.lineTo(876,28);ctx.lineTo(878,62);ctx.lineTo(883,88);ctx.lineTo(896,112);ctx.lineTo(921,128);ctx.lineTo(952,134);ctx.lineTo(964,135);ctx.lineTo(970,135);ctx.lineTo(970,564);ctx.lineTo(940,566);ctx.lineTo(913,575);ctx.lineTo(891,594);ctx.lineTo(881,621);ctx.lineTo(876,650);ctx.lineTo(876,664);ctx.lineTo(876,671);ctx.lineTo(122,671);ctx.lineTo(120,637);ctx.lineTo(115,611);ctx.lineTo(102,588);ctx.lineTo(77,571);ctx.lineTo(46,565);ctx.lineTo(34,564);ctx.lineTo(28,564);ctx.lineTo(28,135);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,135));listpt.Add(new Point(58,133));listpt.Add(new Point(85,124));listpt.Add(new Point(107,105));listpt.Add(new Point(117,78));listpt.Add(new Point(122,49));listpt.Add(new Point(122,35));listpt.Add(new Point(122,28));listpt.Add(new Point(876,28));listpt.Add(new Point(878,62));listpt.Add(new Point(883,88));listpt.Add(new Point(896,112));listpt.Add(new Point(921,128));listpt.Add(new Point(952,134));listpt.Add(new Point(964,135));listpt.Add(new Point(970,135));listpt.Add(new Point(970,564));listpt.Add(new Point(940,566));listpt.Add(new Point(913,575));listpt.Add(new Point(891,594));listpt.Add(new Point(881,621));listpt.Add(new Point(876,650));listpt.Add(new Point(876,664));listpt.Add(new Point(876,671));listpt.Add(new Point(122,671));listpt.Add(new Point(120,637));listpt.Add(new Point(115,611));listpt.Add(new Point(102,588));listpt.Add(new Point(77,571));listpt.Add(new Point(46,565));listpt.Add(new Point(34,564));listpt.Add(new Point(28,564));listpt.Add(new Point(28,135));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}