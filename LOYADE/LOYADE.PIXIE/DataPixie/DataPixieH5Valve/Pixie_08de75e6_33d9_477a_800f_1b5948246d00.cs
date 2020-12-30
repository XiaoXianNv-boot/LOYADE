using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Valve
{
    public class PIXIE_08de75e6_33d9_477a_800f_1b5948246d00 : Pixie
    {
        public PIXIE_08de75e6_33d9_477a_800f_1b5948246d00()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 159.1367f; _h = 155f;
_content = "var arrFillColor = new Array(0); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* ellipse */ ctx.scale(1.985714,1);ctx.arc(89.13669,85,70,0,Math.PI*2,true);ctx.scale(0.5035971,1);ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.DrawEllipse(p, 19.13669f,15f,140f,140f);
        }
    }
}