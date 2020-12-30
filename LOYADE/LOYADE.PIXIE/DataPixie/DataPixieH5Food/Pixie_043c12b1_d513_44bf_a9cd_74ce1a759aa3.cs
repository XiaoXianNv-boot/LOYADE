using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Food
{
    public class PIXIE_043c12b1_d513_44bf_a9cd_74ce1a759aa3 : Pixie
    {
        public PIXIE_043c12b1_d513_44bf_a9cd_74ce1a759aa3()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#c7c7cc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 523f; _h = 729f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#4c4c4c'; arrFillColor[1] = '#c7c7cc'; arrBorderColor[0] = '#7f7f7f'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* circle */ ctx.arc(378,261,39,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(297,691);ctx.lineTo(273,657);ctx.lineTo(261,618);ctx.lineTo(260,575);ctx.lineTo(273,535);ctx.lineTo(297,501);ctx.lineTo(331,476);ctx.lineTo(371,463);ctx.lineTo(412,463);ctx.lineTo(452,475);ctx.lineTo(486,501);ctx.lineTo(510,535);ctx.lineTo(523,575);ctx.lineTo(523,618);ctx.lineTo(510,657);ctx.lineTo(486,691);ctx.lineTo(452,718);ctx.lineTo(412,729);ctx.lineTo(371,729);ctx.lineTo(331,716);ctx.lineTo(297,691);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(391,596,49,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.DrawEllipse(p, 339f,222f,78f,78f);
listpt = new List<Point>();listpt.Add(new Point(297,691));listpt.Add(new Point(273,657));listpt.Add(new Point(261,618));listpt.Add(new Point(260,575));listpt.Add(new Point(273,535));listpt.Add(new Point(297,501));listpt.Add(new Point(331,476));listpt.Add(new Point(371,463));listpt.Add(new Point(412,463));listpt.Add(new Point(452,475));listpt.Add(new Point(486,501));listpt.Add(new Point(510,535));listpt.Add(new Point(523,575));listpt.Add(new Point(523,618));listpt.Add(new Point(510,657));listpt.Add(new Point(486,691));listpt.Add(new Point(452,718));listpt.Add(new Point(412,729));listpt.Add(new Point(371,729));listpt.Add(new Point(331,716));listpt.Add(new Point(297,691));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillEllipse(sb, 342f,547f,98f,98f);g.DrawEllipse(p, 342f,547f,98f,98f);
        }
    }
}