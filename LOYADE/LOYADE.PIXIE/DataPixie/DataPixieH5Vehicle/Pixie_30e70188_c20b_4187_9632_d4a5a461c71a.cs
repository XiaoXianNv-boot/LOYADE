using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Vehicle
{
    public class PIXIE_30e70188_c20b_4187_9632_d4a5a461c71a : Pixie
    {
        public PIXIE_30e70188_c20b_4187_9632_d4a5a461c71a()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 299f; _h = 111f;
_content = "var arrFillColor = new Array(0); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* circle */ ctx.arc(278,90,21,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.DrawEllipse(p, 257f,69f,42f,42f);
        }
    }
}