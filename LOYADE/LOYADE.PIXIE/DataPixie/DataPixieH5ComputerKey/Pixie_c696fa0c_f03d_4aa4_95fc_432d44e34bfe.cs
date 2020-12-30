using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ComputerKey
{
    public class PIXIE_c696fa0c_f03d_4aa4_95fc_432d44e34bfe : Pixie
    {
        public PIXIE_c696fa0c_f03d_4aa4_95fc_432d44e34bfe()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#ebebe1"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#adad84"));
_w = 838f; _h = 882f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#ebebe1'; arrBorderColor[0] = '#adad84'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(160,101);ctx.lineTo(190,71);ctx.lineTo(808,71);ctx.lineTo(838,101);ctx.lineTo(838,852);ctx.lineTo(808,882);ctx.lineTo(190,882);ctx.lineTo(160,852);ctx.lineTo(160,101);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(160,101));listpt.Add(new Point(190,71));listpt.Add(new Point(808,71));listpt.Add(new Point(838,101));listpt.Add(new Point(838,852));listpt.Add(new Point(808,882));listpt.Add(new Point(190,882));listpt.Add(new Point(160,852));listpt.Add(new Point(160,101));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}