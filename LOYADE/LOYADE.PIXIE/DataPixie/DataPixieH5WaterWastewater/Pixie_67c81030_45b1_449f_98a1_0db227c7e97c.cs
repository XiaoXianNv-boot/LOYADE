using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WaterWastewater
{
    public class PIXIE_67c81030_45b1_449f_98a1_0db227c7e97c : Pixie
    {
        public PIXIE_67c81030_45b1_449f_98a1_0db227c7e97c()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#ccc"));
_w = 289.6218f; _h = 245f;
_content = "var arrFillColor = new Array(0); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrBorderColor[0] = '#000'; arrBorderColor[1] = '#ccc'; arrBorderColor[2] = '#ccc'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* ellipse */ ctx.scale(1.522124,1);ctx.arc(122.8546,132,113,0,Math.PI*2,true);ctx.scale(0.6569767,1);ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(1.053097,1);ctx.arc(176.6218,132,113,0,Math.PI*2,true);ctx.scale(0.9495798,1);ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(1,2.306123);ctx.arc(187,57.23894,49,0,Math.PI*2,true);ctx.scale(1,0.4336283);ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.DrawEllipse(p, 9.854599f,19f,226f,226f);
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.DrawEllipse(p, 63.6218f,19f,226f,226f);
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.DrawEllipse(p, 138f,-55.76109f,98f,226.0001f);
        }
    }
}