using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5AirCondition
{
    public class PIXIE_d9973db4_6654_47b6_8758_67104205d5b3 : Pixie
    {
        public PIXIE_d9973db4_6654_47b6_8758_67104205d5b3()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 133f; _h = 119f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* circle */ ctx.arc(98,84,35,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillEllipse(sb, 63f,49f,70f,70f);g.DrawEllipse(p, 63f,49f,70f,70f);
        }
    }
}