using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5AirCondition
{
    public class PIXIE_80caa95b_c298_4df0_8824_8afcf4979408 : Pixie
    {
        public PIXIE_80caa95b_c298_4df0_8824_8afcf4979408()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 290f; _h = 189f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(259,63);ctx.lineTo(290,63);ctx.lineTo(290,189);ctx.lineTo(181,189);ctx.lineTo(259,63);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(40,133);ctx.lineTo(8,133);ctx.lineTo(8,8);ctx.lineTo(118,8);ctx.lineTo(40,133);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(259,63));listpt.Add(new Point(290,63));listpt.Add(new Point(290,189));listpt.Add(new Point(181,189));listpt.Add(new Point(259,63));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(40,133));listpt.Add(new Point(8,133));listpt.Add(new Point(8,8));listpt.Add(new Point(118,8));listpt.Add(new Point(40,133));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}