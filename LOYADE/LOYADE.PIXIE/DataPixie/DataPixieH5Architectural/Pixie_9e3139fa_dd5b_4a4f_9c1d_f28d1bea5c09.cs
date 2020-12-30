using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Architectural
{
    public class PIXIE_9e3139fa_dd5b_4a4f_9c1d_f28d1bea5c09 : Pixie
    {
        public PIXIE_9e3139fa_dd5b_4a4f_9c1d_f28d1bea5c09()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#98b2e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 448f; _h = 320f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#98b2e5'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(329,320);ctx.lineTo(307,299);ctx.lineTo(282,280);ctx.lineTo(256,262);ctx.lineTo(229,247);ctx.lineTo(200,233);ctx.lineTo(171,221);ctx.lineTo(141,211);ctx.lineTo(110,204);ctx.lineTo(79,199);ctx.lineTo(48,196);ctx.lineTo(38,196);ctx.lineTo(28,196);ctx.lineTo(28,193);ctx.lineTo(28,30);ctx.lineTo(28,28);ctx.lineTo(42,28);ctx.lineTo(71,29);ctx.lineTo(100,32);ctx.lineTo(128,37);ctx.lineTo(157,43);ctx.lineTo(185,50);ctx.lineTo(213,58);ctx.lineTo(240,68);ctx.lineTo(267,79);ctx.lineTo(294,91);ctx.lineTo(320,105);ctx.lineTo(345,120);ctx.lineTo(370,136);ctx.lineTo(394,153);ctx.lineTo(416,172);ctx.lineTo(438,191);ctx.lineTo(448,201);ctx.lineTo(329,320);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(329,320));listpt.Add(new Point(307,299));listpt.Add(new Point(282,280));listpt.Add(new Point(256,262));listpt.Add(new Point(229,247));listpt.Add(new Point(200,233));listpt.Add(new Point(171,221));listpt.Add(new Point(141,211));listpt.Add(new Point(110,204));listpt.Add(new Point(79,199));listpt.Add(new Point(48,196));listpt.Add(new Point(38,196));listpt.Add(new Point(28,196));listpt.Add(new Point(28,193));listpt.Add(new Point(28,30));listpt.Add(new Point(28,28));listpt.Add(new Point(42,28));listpt.Add(new Point(71,29));listpt.Add(new Point(100,32));listpt.Add(new Point(128,37));listpt.Add(new Point(157,43));listpt.Add(new Point(185,50));listpt.Add(new Point(213,58));listpt.Add(new Point(240,68));listpt.Add(new Point(267,79));listpt.Add(new Point(294,91));listpt.Add(new Point(320,105));listpt.Add(new Point(345,120));listpt.Add(new Point(370,136));listpt.Add(new Point(394,153));listpt.Add(new Point(416,172));listpt.Add(new Point(438,191));listpt.Add(new Point(448,201));listpt.Add(new Point(329,320));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}