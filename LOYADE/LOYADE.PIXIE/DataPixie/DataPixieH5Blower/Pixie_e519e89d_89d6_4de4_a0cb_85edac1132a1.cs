using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Blower
{
    public class PIXIE_e519e89d_89d6_4de4_a0cb_85edac1132a1 : Pixie
    {
        public PIXIE_e519e89d_89d6_4de4_a0cb_85edac1132a1()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0cc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 781f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0cc'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(260,755);ctx.lineTo(355,781);ctx.lineTo(455,781);ctx.lineTo(551,755);ctx.lineTo(636,706);ctx.lineTo(706,636);ctx.lineTo(757,549);ctx.lineTo(781,455);ctx.lineTo(781,362);ctx.lineTo(970,362);ctx.lineTo(970,28);ctx.lineTo(355,28);ctx.lineTo(258,52);ctx.lineTo(173,103);ctx.lineTo(103,173);ctx.lineTo(54,258);ctx.lineTo(28,355);ctx.lineTo(28,455);ctx.lineTo(52,549);ctx.lineTo(103,636);ctx.lineTo(173,706);ctx.lineTo(260,755);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(260,755));listpt.Add(new Point(355,781));listpt.Add(new Point(455,781));listpt.Add(new Point(551,755));listpt.Add(new Point(636,706));listpt.Add(new Point(706,636));listpt.Add(new Point(757,549));listpt.Add(new Point(781,455));listpt.Add(new Point(781,362));listpt.Add(new Point(970,362));listpt.Add(new Point(970,28));listpt.Add(new Point(355,28));listpt.Add(new Point(258,52));listpt.Add(new Point(173,103));listpt.Add(new Point(103,173));listpt.Add(new Point(54,258));listpt.Add(new Point(28,355));listpt.Add(new Point(28,455));listpt.Add(new Point(52,549));listpt.Add(new Point(103,636));listpt.Add(new Point(173,706));listpt.Add(new Point(260,755));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}