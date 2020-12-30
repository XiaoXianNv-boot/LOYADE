using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Food
{
    public class PIXIE_9f7d8474_0a31_4546_a76a_c393e7dcfa5d : Pixie
    {
        public PIXIE_9f7d8474_0a31_4546_a76a_c393e7dcfa5d()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#cff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 297f; _h = 970f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#cff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(214,961);ctx.lineTo(180,970);ctx.lineTo(144,970);ctx.lineTo(111,961);ctx.lineTo(81,944);ctx.lineTo(56,918);ctx.lineTo(37,888);ctx.lineTo(28,857);ctx.lineTo(28,139);ctx.lineTo(37,110);ctx.lineTo(56,81);ctx.lineTo(81,54);ctx.lineTo(111,37);ctx.lineTo(144,28);ctx.lineTo(180,28);ctx.lineTo(214,37);ctx.lineTo(246,54);ctx.lineTo(271,81);ctx.lineTo(288,110);ctx.lineTo(297,139);ctx.lineTo(297,857);ctx.lineTo(288,888);ctx.lineTo(271,918);ctx.lineTo(246,944);ctx.lineTo(214,961);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(214,961));listpt.Add(new Point(180,970));listpt.Add(new Point(144,970));listpt.Add(new Point(111,961));listpt.Add(new Point(81,944));listpt.Add(new Point(56,918));listpt.Add(new Point(37,888));listpt.Add(new Point(28,857));listpt.Add(new Point(28,139));listpt.Add(new Point(37,110));listpt.Add(new Point(56,81));listpt.Add(new Point(81,54));listpt.Add(new Point(111,37));listpt.Add(new Point(144,28));listpt.Add(new Point(180,28));listpt.Add(new Point(214,37));listpt.Add(new Point(246,54));listpt.Add(new Point(271,81));listpt.Add(new Point(288,110));listpt.Add(new Point(297,139));listpt.Add(new Point(297,857));listpt.Add(new Point(288,888));listpt.Add(new Point(271,918));listpt.Add(new Point(246,944));listpt.Add(new Point(214,961));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}