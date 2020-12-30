using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Architectural
{
    public class PIXIE_ee639e1c_8038_4e51_8b5d_598dd5f24a60 : Pixie
    {
        public PIXIE_ee639e1c_8038_4e51_8b5d_598dd5f24a60()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#00f"));
_w = 970f; _h = 696f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#fff'; arrBorderColor[0] = '#00f'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(877,28);ctx.lineTo(92,150);ctx.lineTo(64,163);ctx.lineTo(44,187);ctx.lineTo(32,217);ctx.lineTo(28,251);ctx.lineTo(34,284);ctx.lineTo(51,317);ctx.lineTo(72,344);ctx.lineTo(95,361);ctx.lineTo(140,381);ctx.lineTo(164,390);ctx.lineTo(210,408);ctx.lineTo(249,433);ctx.lineTo(264,452);ctx.lineTo(281,483);ctx.lineTo(295,516);ctx.lineTo(308,550);ctx.lineTo(323,585);ctx.lineTo(341,618);ctx.lineTo(364,648);ctx.lineTo(395,674);ctx.lineTo(435,696);ctx.lineTo(970,121);ctx.lineTo(920,114);ctx.lineTo(935,100);ctx.lineTo(938,66);ctx.lineTo(925,43);ctx.lineTo(894,29);ctx.lineTo(877,28);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(877,28));listpt.Add(new Point(92,150));listpt.Add(new Point(64,163));listpt.Add(new Point(44,187));listpt.Add(new Point(32,217));listpt.Add(new Point(28,251));listpt.Add(new Point(34,284));listpt.Add(new Point(51,317));listpt.Add(new Point(72,344));listpt.Add(new Point(95,361));listpt.Add(new Point(140,381));listpt.Add(new Point(164,390));listpt.Add(new Point(210,408));listpt.Add(new Point(249,433));listpt.Add(new Point(264,452));listpt.Add(new Point(281,483));listpt.Add(new Point(295,516));listpt.Add(new Point(308,550));listpt.Add(new Point(323,585));listpt.Add(new Point(341,618));listpt.Add(new Point(364,648));listpt.Add(new Point(395,674));listpt.Add(new Point(435,696));listpt.Add(new Point(970,121));listpt.Add(new Point(920,114));listpt.Add(new Point(935,100));listpt.Add(new Point(938,66));listpt.Add(new Point(925,43));listpt.Add(new Point(894,29));listpt.Add(new Point(877,28));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}