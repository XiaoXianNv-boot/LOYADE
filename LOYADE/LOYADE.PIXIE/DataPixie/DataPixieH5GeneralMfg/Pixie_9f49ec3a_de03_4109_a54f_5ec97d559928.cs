using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_9f49ec3a_de03_4109_a54f_5ec97d559928 : Pixie
    {
        public PIXIE_9f49ec3a_de03_4109_a54f_5ec97d559928()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 386f; _h = 218f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(11,93);ctx.lineTo(288,93);ctx.lineTo(230,11);ctx.lineTo(355,11);ctx.lineTo(296,93);ctx.lineTo(386,93);ctx.lineTo(386,218);ctx.lineTo(198,218);ctx.lineTo(198,136);ctx.lineTo(11,136);ctx.lineTo(11,93);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(11,93));listpt.Add(new Point(288,93));listpt.Add(new Point(230,11));listpt.Add(new Point(355,11));listpt.Add(new Point(296,93));listpt.Add(new Point(386,93));listpt.Add(new Point(386,218));listpt.Add(new Point(198,218));listpt.Add(new Point(198,136));listpt.Add(new Point(11,136));listpt.Add(new Point(11,93));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}