using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Electrical
{
    public class PIXIE_05c69ab5_31c1_4a65_81ac_2b41a4887d9a : Pixie
    {
        public PIXIE_05c69ab5_31c1_4a65_81ac_2b41a4887d9a()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 263f;
_content = "var arrFillColor = new Array(0); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* circle */ ctx.arc(87,204,59,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(911,204,59,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.DrawEllipse(p, 28f,145f,118f,118f);
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.DrawEllipse(p, 852f,145f,118f,118f);
        }
    }
}