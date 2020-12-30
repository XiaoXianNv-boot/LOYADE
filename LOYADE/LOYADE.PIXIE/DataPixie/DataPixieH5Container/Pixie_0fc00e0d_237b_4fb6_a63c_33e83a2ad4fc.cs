using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Container
{
    public class PIXIE_0fc00e0d_237b_4fb6_a63c_33e83a2ad4fc : Pixie
    {
        public PIXIE_0fc00e0d_237b_4fb6_a63c_33e83a2ad4fc()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 99.77273f; _h = 94f;
_content = "var arrFillColor = new Array(0); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* ellipse */ ctx.scale(6.030303,1);ctx.arc(44.27638,61,33,0,Math.PI*2,true);ctx.scale(0.1658292,1);ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(4.4,1);ctx.arc(84.77273,63,15,0,Math.PI*2,true);ctx.scale(0.2272727,1);ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(4.6,1);ctx.arc(61.08696,63,10,0,Math.PI*2,true);ctx.scale(0.2173913,1);ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.DrawEllipse(p, 11.27638f,28f,66f,66f);
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.DrawEllipse(p, 69.77273f,48f,30f,30f);
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.DrawEllipse(p, 51.08696f,53f,20f,20f);
        }
    }
}