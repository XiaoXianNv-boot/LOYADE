using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WaterWastewater
{
    public class PIXIE_6b2e4350_cfba_46ef_884e_8a6b632ee0a7 : Pixie
    {
        public PIXIE_6b2e4350_cfba_46ef_884e_8a6b632ee0a7()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 558f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#ccc'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,499);ctx.lineTo(28,28);ctx.lineTo(106,28);ctx.lineTo(106,67);ctx.lineTo(48,67);ctx.lineTo(48,460);ctx.lineTo(484,518);ctx.lineTo(484,48);ctx.lineTo(460,48);ctx.lineTo(460,28);ctx.lineTo(538,28);ctx.lineTo(538,48);ctx.lineTo(514,48);ctx.lineTo(514,518);ctx.lineTo(637,499);ctx.lineTo(637,558);ctx.lineTo(676,558);ctx.lineTo(676,494);ctx.lineTo(951,460);ctx.lineTo(951,67);ctx.lineTo(892,67);ctx.lineTo(892,28);ctx.lineTo(970,28);ctx.lineTo(970,499);ctx.lineTo(690,531);ctx.lineTo(690,558);ctx.lineTo(622,558);ctx.lineTo(622,540);ctx.lineTo(499,558);ctx.lineTo(28,499);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,499));listpt.Add(new Point(28,28));listpt.Add(new Point(106,28));listpt.Add(new Point(106,67));listpt.Add(new Point(48,67));listpt.Add(new Point(48,460));listpt.Add(new Point(484,518));listpt.Add(new Point(484,48));listpt.Add(new Point(460,48));listpt.Add(new Point(460,28));listpt.Add(new Point(538,28));listpt.Add(new Point(538,48));listpt.Add(new Point(514,48));listpt.Add(new Point(514,518));listpt.Add(new Point(637,499));listpt.Add(new Point(637,558));listpt.Add(new Point(676,558));listpt.Add(new Point(676,494));listpt.Add(new Point(951,460));listpt.Add(new Point(951,67));listpt.Add(new Point(892,67));listpt.Add(new Point(892,28));listpt.Add(new Point(970,28));listpt.Add(new Point(970,499));listpt.Add(new Point(690,531));listpt.Add(new Point(690,558));listpt.Add(new Point(622,558));listpt.Add(new Point(622,540));listpt.Add(new Point(499,558));listpt.Add(new Point(28,499));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}