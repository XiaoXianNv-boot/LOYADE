using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Valve
{
    public class PIXIE_e7395d8e_a225_4c56_afef_b8c6d7c581cd : Pixie
    {
        public PIXIE_e7395d8e_a225_4c56_afef_b8c6d7c581cd()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 299f; _h = 177f;
_content = "var arrFillColor = new Array(0); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* circle */ ctx.arc(245,123,54,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.DrawEllipse(p, 191f,69f,108f,108f);
        }
    }
}