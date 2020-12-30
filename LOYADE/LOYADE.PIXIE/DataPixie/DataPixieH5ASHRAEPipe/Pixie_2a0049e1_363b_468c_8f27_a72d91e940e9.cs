using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEPipe
{
    public class PIXIE_2a0049e1_363b_468c_8f27_a72d91e940e9 : Pixie
    {
        public PIXIE_2a0049e1_363b_468c_8f27_a72d91e940e9()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 782f; _h = 782f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(452,216);ctx.lineTo(546,216);ctx.lineTo(546,452);ctx.lineTo(782,452);ctx.lineTo(782,546);ctx.lineTo(546,546);ctx.lineTo(546,782);ctx.lineTo(452,782);ctx.lineTo(452,546);ctx.lineTo(216,546);ctx.lineTo(216,452);ctx.lineTo(452,452);ctx.lineTo(452,216);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(452,216));listpt.Add(new Point(546,216));listpt.Add(new Point(546,452));listpt.Add(new Point(782,452));listpt.Add(new Point(782,546));listpt.Add(new Point(546,546));listpt.Add(new Point(546,782));listpt.Add(new Point(452,782));listpt.Add(new Point(452,546));listpt.Add(new Point(216,546));listpt.Add(new Point(216,452));listpt.Add(new Point(452,452));listpt.Add(new Point(452,216));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}