using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Electrical
{
    public class PIXIE_bf26afde_7d31_4eb0_a215_e93e6db9d76d : Pixie
    {
        public PIXIE_bf26afde_7d31_4eb0_a215_e93e6db9d76d()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 969f; _h = 390f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(499,390);ctx.lineTo(342,390);ctx.lineTo(345,358);ctx.lineTo(354,329);ctx.lineTo(369,302);ctx.lineTo(388,279);ctx.lineTo(411,259);ctx.lineTo(438,245);ctx.lineTo(467,236);ctx.lineTo(491,233);ctx.lineTo(499,233);ctx.lineTo(507,233);ctx.lineTo(538,237);ctx.lineTo(567,248);ctx.lineTo(593,264);ctx.lineTo(615,284);ctx.lineTo(633,308);ctx.lineTo(646,336);ctx.lineTo(654,366);ctx.lineTo(656,382);ctx.lineTo(656,390);ctx.lineTo(499,390);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(921,77,48,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(76,76,48,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(499,390));listpt.Add(new Point(342,390));listpt.Add(new Point(345,358));listpt.Add(new Point(354,329));listpt.Add(new Point(369,302));listpt.Add(new Point(388,279));listpt.Add(new Point(411,259));listpt.Add(new Point(438,245));listpt.Add(new Point(467,236));listpt.Add(new Point(491,233));listpt.Add(new Point(499,233));listpt.Add(new Point(507,233));listpt.Add(new Point(538,237));listpt.Add(new Point(567,248));listpt.Add(new Point(593,264));listpt.Add(new Point(615,284));listpt.Add(new Point(633,308));listpt.Add(new Point(646,336));listpt.Add(new Point(654,366));listpt.Add(new Point(656,382));listpt.Add(new Point(656,390));listpt.Add(new Point(499,390));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.DrawEllipse(p, 873f,29f,96f,96f);
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.DrawEllipse(p, 28f,28f,96f,96f);
        }
    }
}