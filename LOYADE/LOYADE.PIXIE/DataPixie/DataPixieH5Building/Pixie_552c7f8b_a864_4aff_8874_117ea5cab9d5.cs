using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Building
{
    public class PIXIE_552c7f8b_a864_4aff_8874_117ea5cab9d5 : Pixie
    {
        public PIXIE_552c7f8b_a864_4aff_8874_117ea5cab9d5()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 687f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#ccc'; arrFillColor[1] = '#999'; arrFillColor[2] = '#e5e5e5'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,122);ctx.lineTo(782,122);ctx.lineTo(782,687);ctx.lineTo(28,687);ctx.lineTo(28,122);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(782,687);ctx.lineTo(970,593);ctx.lineTo(970,28);ctx.lineTo(782,122);ctx.lineTo(782,687);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,122);ctx.lineTo(216,28);ctx.lineTo(970,28);ctx.lineTo(782,122);ctx.lineTo(28,122);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,122));listpt.Add(new Point(782,122));listpt.Add(new Point(782,687));listpt.Add(new Point(28,687));listpt.Add(new Point(28,122));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(782,687));listpt.Add(new Point(970,593));listpt.Add(new Point(970,28));listpt.Add(new Point(782,122));listpt.Add(new Point(782,687));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,122));listpt.Add(new Point(216,28));listpt.Add(new Point(970,28));listpt.Add(new Point(782,122));listpt.Add(new Point(28,122));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}