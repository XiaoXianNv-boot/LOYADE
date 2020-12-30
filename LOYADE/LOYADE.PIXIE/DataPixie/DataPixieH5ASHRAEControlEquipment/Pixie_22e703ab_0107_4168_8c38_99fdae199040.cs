using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEControlEquipment
{
    public class PIXIE_22e703ab_0107_4168_8c38_99fdae199040 : Pixie
    {
        public PIXIE_22e703ab_0107_4168_8c38_99fdae199040()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 969f; _h = 736f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* circle */ ctx.arc(891,657,78,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,382);ctx.lineTo(53,250);ctx.lineTo(129,130);ctx.lineTo(249,54);ctx.lineTo(381,29);ctx.lineTo(514,54);ctx.lineTo(633,130);ctx.lineTo(709,250);ctx.lineTo(735,382);ctx.lineTo(709,515);ctx.lineTo(633,634);ctx.lineTo(514,710);ctx.lineTo(381,736);ctx.lineTo(249,710);ctx.lineTo(129,634);ctx.lineTo(53,515);ctx.lineTo(28,382);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillEllipse(sb, 813f,579f,156f,156f);g.DrawEllipse(p, 813f,579f,156f,156f);
listpt = new List<Point>();listpt.Add(new Point(28,382));listpt.Add(new Point(53,250));listpt.Add(new Point(129,130));listpt.Add(new Point(249,54));listpt.Add(new Point(381,29));listpt.Add(new Point(514,54));listpt.Add(new Point(633,130));listpt.Add(new Point(709,250));listpt.Add(new Point(735,382));listpt.Add(new Point(709,515));listpt.Add(new Point(633,634));listpt.Add(new Point(514,710));listpt.Add(new Point(381,736));listpt.Add(new Point(249,710));listpt.Add(new Point(129,634));listpt.Add(new Point(53,515));listpt.Add(new Point(28,382));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}