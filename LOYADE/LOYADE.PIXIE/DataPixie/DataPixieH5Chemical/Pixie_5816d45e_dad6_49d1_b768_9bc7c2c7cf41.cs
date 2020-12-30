using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Chemical
{
    public class PIXIE_5816d45e_dad6_49d1_b768_9bc7c2c7cf41 : Pixie
    {
        public PIXIE_5816d45e_dad6_49d1_b768_9bc7c2c7cf41()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 214f; _h = 961f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#999'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(214,960);ctx.lineTo(214,29);ctx.lineTo(214,29);ctx.lineTo(214,28);ctx.lineTo(210,28);ctx.lineTo(195,28);ctx.lineTo(195,29);ctx.lineTo(195,29);ctx.lineTo(195,960);ctx.lineTo(195,960);ctx.lineTo(195,961);ctx.lineTo(199,961);ctx.lineTo(214,961);ctx.lineTo(214,960);ctx.lineTo(214,960);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(214,960));listpt.Add(new Point(214,29));listpt.Add(new Point(214,29));listpt.Add(new Point(214,28));listpt.Add(new Point(210,28));listpt.Add(new Point(195,28));listpt.Add(new Point(195,29));listpt.Add(new Point(195,29));listpt.Add(new Point(195,960));listpt.Add(new Point(195,960));listpt.Add(new Point(195,961));listpt.Add(new Point(199,961));listpt.Add(new Point(214,961));listpt.Add(new Point(214,960));listpt.Add(new Point(214,960));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}