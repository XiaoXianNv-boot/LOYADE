using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Food
{
    public class PIXIE_532ea58f_9bde_4a50_a9b0_71ec9d05c08c : Pixie
    {
        public PIXIE_532ea58f_9bde_4a50_a9b0_71ec9d05c08c()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#cff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#cff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#cff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 593f; _h = 970f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#cff'; arrFillColor[1] = '#cff'; arrFillColor[2] = '#cff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(65,895);ctx.lineTo(28,857);ctx.lineTo(28,292);ctx.lineTo(65,254);ctx.lineTo(556,254);ctx.lineTo(593,292);ctx.lineTo(593,857);ctx.lineTo(556,895);ctx.lineTo(65,895);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(103,970);ctx.lineTo(65,933);ctx.lineTo(65,178);ctx.lineTo(103,141);ctx.lineTo(518,141);ctx.lineTo(556,178);ctx.lineTo(556,933);ctx.lineTo(518,970);ctx.lineTo(103,970);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(254,28);ctx.lineTo(367,28);ctx.lineTo(367,103);ctx.lineTo(254,103);ctx.lineTo(254,28);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(65,895));listpt.Add(new Point(28,857));listpt.Add(new Point(28,292));listpt.Add(new Point(65,254));listpt.Add(new Point(556,254));listpt.Add(new Point(593,292));listpt.Add(new Point(593,857));listpt.Add(new Point(556,895));listpt.Add(new Point(65,895));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(103,970));listpt.Add(new Point(65,933));listpt.Add(new Point(65,178));listpt.Add(new Point(103,141));listpt.Add(new Point(518,141));listpt.Add(new Point(556,178));listpt.Add(new Point(556,933));listpt.Add(new Point(518,970));listpt.Add(new Point(103,970));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(254,28));listpt.Add(new Point(367,28));listpt.Add(new Point(367,103));listpt.Add(new Point(254,103));listpt.Add(new Point(254,28));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}