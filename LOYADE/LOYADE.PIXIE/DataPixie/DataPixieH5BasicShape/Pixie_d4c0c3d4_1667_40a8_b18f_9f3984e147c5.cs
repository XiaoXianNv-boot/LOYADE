using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_d4c0c3d4_1667_40a8_b18f_9f3984e147c5 : Pixie
    {
        public PIXIE_d4c0c3d4_1667_40a8_b18f_9f3984e147c5()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 671f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,564);ctx.lineTo(28,135);ctx.lineTo(122,135);ctx.lineTo(122,28);ctx.lineTo(876,28);ctx.lineTo(876,135);ctx.lineTo(970,135);ctx.lineTo(970,564);ctx.lineTo(876,564);ctx.lineTo(876,671);ctx.lineTo(122,671);ctx.lineTo(122,564);ctx.lineTo(28,564);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,564));listpt.Add(new Point(28,135));listpt.Add(new Point(122,135));listpt.Add(new Point(122,28));listpt.Add(new Point(876,28));listpt.Add(new Point(876,135));listpt.Add(new Point(970,135));listpt.Add(new Point(970,564));listpt.Add(new Point(876,564));listpt.Add(new Point(876,671));listpt.Add(new Point(122,671));listpt.Add(new Point(122,564));listpt.Add(new Point(28,564));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}