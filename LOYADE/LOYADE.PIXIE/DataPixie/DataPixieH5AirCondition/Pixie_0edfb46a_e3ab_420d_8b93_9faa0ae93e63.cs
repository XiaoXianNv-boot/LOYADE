using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5AirCondition
{
    public class PIXIE_0edfb46a_e3ab_420d_8b93_9faa0ae93e63 : Pixie
    {
        public PIXIE_0edfb46a_e3ab_420d_8b93_9faa0ae93e63()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 137f; _h = 107f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* circle */ ctx.arc(118,88,19,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillEllipse(sb, 99f,69f,38f,38f);g.DrawEllipse(p, 99f,69f,38f,38f);
        }
    }
}