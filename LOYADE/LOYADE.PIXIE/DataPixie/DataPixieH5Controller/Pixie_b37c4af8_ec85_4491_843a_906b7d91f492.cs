using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Controller
{
    public class PIXIE_b37c4af8_ec85_4491_843a_906b7d91f492 : Pixie
    {
        public PIXIE_b37c4af8_ec85_4491_843a_906b7d91f492()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#c93"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#4c4c4c"));
_w = 970f; _h = 814f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#c93'; arrFillColor[1] = '#b2b2b2'; arrFillColor[2] = '#999'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#4c4c4c'; arrBorderColor[2] = '#4c4c4c'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(46,814);ctx.lineTo(28,793);ctx.lineTo(28,755);ctx.lineTo(46,755);ctx.lineTo(46,735);ctx.lineTo(28,735);ctx.lineTo(28,165);ctx.lineTo(46,165);ctx.lineTo(46,146);ctx.lineTo(28,146);ctx.lineTo(28,48);ctx.lineTo(46,28);ctx.lineTo(952,28);ctx.lineTo(970,48);ctx.lineTo(970,146);ctx.lineTo(952,146);ctx.lineTo(952,165);ctx.lineTo(970,165);ctx.lineTo(970,735);ctx.lineTo(952,735);ctx.lineTo(952,755);ctx.lineTo(970,755);ctx.lineTo(970,793);ctx.lineTo(952,814);ctx.lineTo(46,814);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(107,116);ctx.lineTo(107,28);ctx.lineTo(126,28);ctx.lineTo(126,48);ctx.lineTo(184,48);ctx.lineTo(184,116);ctx.lineTo(107,116);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(209,62);ctx.lineTo(263,62);ctx.lineTo(263,126);ctx.lineTo(209,126);ctx.lineTo(209,62);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(46,814));listpt.Add(new Point(28,793));listpt.Add(new Point(28,755));listpt.Add(new Point(46,755));listpt.Add(new Point(46,735));listpt.Add(new Point(28,735));listpt.Add(new Point(28,165));listpt.Add(new Point(46,165));listpt.Add(new Point(46,146));listpt.Add(new Point(28,146));listpt.Add(new Point(28,48));listpt.Add(new Point(46,28));listpt.Add(new Point(952,28));listpt.Add(new Point(970,48));listpt.Add(new Point(970,146));listpt.Add(new Point(952,146));listpt.Add(new Point(952,165));listpt.Add(new Point(970,165));listpt.Add(new Point(970,735));listpt.Add(new Point(952,735));listpt.Add(new Point(952,755));listpt.Add(new Point(970,755));listpt.Add(new Point(970,793));listpt.Add(new Point(952,814));listpt.Add(new Point(46,814));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(107,116));listpt.Add(new Point(107,28));listpt.Add(new Point(126,28));listpt.Add(new Point(126,48));listpt.Add(new Point(184,48));listpt.Add(new Point(184,116));listpt.Add(new Point(107,116));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(209,62));listpt.Add(new Point(263,62));listpt.Add(new Point(263,126));listpt.Add(new Point(209,126));listpt.Add(new Point(209,62));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}