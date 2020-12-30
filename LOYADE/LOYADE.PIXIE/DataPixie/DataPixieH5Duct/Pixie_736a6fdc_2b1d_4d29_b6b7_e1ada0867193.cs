using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Duct
{
    public class PIXIE_736a6fdc_2b1d_4d29_b6b7_e1ada0867193 : Pixie
    {
        public PIXIE_736a6fdc_2b1d_4d29_b6b7_e1ada0867193()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 740f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#ccc'; arrFillColor[1] = '#4c4c4c'; arrFillColor[2] = '#4c4c4c'; arrFillColor[3] = '#b2b2b2'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(727,136);ctx.lineTo(906,313);ctx.lineTo(541,678);ctx.lineTo(469,605);ctx.lineTo(394,678);ctx.lineTo(28,313);ctx.lineTo(102,239);ctx.lineTo(212,136);ctx.lineTo(212,28);ctx.lineTo(727,30);ctx.lineTo(727,136);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(562,729);ctx.lineTo(507,674);ctx.lineTo(495,685);ctx.lineTo(550,740);ctx.lineTo(562,729);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(970,322);ctx.lineTo(915,267);ctx.lineTo(902,279);ctx.lineTo(959,334);ctx.lineTo(970,322);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(522,733);ctx.lineTo(505,714);ctx.lineTo(942,277);ctx.lineTo(961,294);ctx.lineTo(522,733);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(727,136));listpt.Add(new Point(906,313));listpt.Add(new Point(541,678));listpt.Add(new Point(469,605));listpt.Add(new Point(394,678));listpt.Add(new Point(28,313));listpt.Add(new Point(102,239));listpt.Add(new Point(212,136));listpt.Add(new Point(212,28));listpt.Add(new Point(727,30));listpt.Add(new Point(727,136));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(562,729));listpt.Add(new Point(507,674));listpt.Add(new Point(495,685));listpt.Add(new Point(550,740));listpt.Add(new Point(562,729));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(970,322));listpt.Add(new Point(915,267));listpt.Add(new Point(902,279));listpt.Add(new Point(959,334));listpt.Add(new Point(970,322));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(522,733));listpt.Add(new Point(505,714));listpt.Add(new Point(942,277));listpt.Add(new Point(961,294));listpt.Add(new Point(522,733));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}