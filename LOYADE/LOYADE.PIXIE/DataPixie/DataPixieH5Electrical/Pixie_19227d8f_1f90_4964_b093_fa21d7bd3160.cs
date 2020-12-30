using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Electrical
{
    public class PIXIE_19227d8f_1f90_4964_b093_fa21d7bd3160 : Pixie
    {
        public PIXIE_19227d8f_1f90_4964_b093_fa21d7bd3160()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 576.6115f; _h = 304f;
_content = "var arrFillColor = new Array(0); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* ellipse */ ctx.scale(1.137681,1);ctx.arc(438.6115,166,138,0,Math.PI*2,true);ctx.scale(0.8789809,1);ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.DrawEllipse(p, 300.6115f,28f,276f,276f);
        }
    }
}