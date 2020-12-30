using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_1e65fdbc_0bb2_4585_b68b_8eac38291a9d : Pixie
    {
        public PIXIE_1e65fdbc_0bb2_4585_b68b_8eac38291a9d()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 690f; _h = 690f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(20,522);ctx.lineTo(20,355);ctx.lineTo(355,20);ctx.lineTo(523,20);ctx.lineTo(690,187);ctx.lineTo(690,355);ctx.lineTo(355,690);ctx.lineTo(188,690);ctx.lineTo(20,522);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(20,522));listpt.Add(new Point(20,355));listpt.Add(new Point(355,20));listpt.Add(new Point(523,20));listpt.Add(new Point(690,187));listpt.Add(new Point(690,355));listpt.Add(new Point(355,690));listpt.Add(new Point(188,690));listpt.Add(new Point(20,522));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}