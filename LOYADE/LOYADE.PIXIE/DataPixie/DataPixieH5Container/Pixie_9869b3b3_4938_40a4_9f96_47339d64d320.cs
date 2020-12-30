using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Container
{
    public class PIXIE_9869b3b3_4938_40a4_9f96_47339d64d320 : Pixie
    {
        public PIXIE_9869b3b3_4938_40a4_9f96_47339d64d320()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 55.06779f; _h = 66f;
_content = "var arrFillColor = new Array(0); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* ellipse */ ctx.scale(6.210526,1);ctx.arc(36.06779,47,19,0,Math.PI*2,true);ctx.scale(0.1610169,1);ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.DrawEllipse(p, 17.06779f,28f,38f,38f);
        }
    }
}