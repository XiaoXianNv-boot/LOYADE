using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_5612df99_ea97_4a3b_83f9_388ba12fbf3e : Pixie
    {
        public PIXIE_5612df99_ea97_4a3b_83f9_388ba12fbf3e()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#161717"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#161717"));
_w = 386f; _h = 198f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#161717'; arrBorderColor[1] = '#161717'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* circle */ ctx.arc(292,104,94,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(291,104,62,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.DrawEllipse(p, 198f,10f,188f,188f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 229f,42f,124f,124f);g.DrawEllipse(p, 229f,42f,124f,124f);
        }
    }
}