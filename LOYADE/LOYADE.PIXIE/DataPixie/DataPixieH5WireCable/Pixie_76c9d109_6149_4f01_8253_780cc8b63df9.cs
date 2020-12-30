using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WireCable
{
    public class PIXIE_76c9d109_6149_4f01_8253_780cc8b63df9 : Pixie
    {
        public PIXIE_76c9d109_6149_4f01_8253_780cc8b63df9()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 928f; _h = 884f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#7f7f7f'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* circle */ ctx.arc(542,435,386,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(263,521);ctx.lineTo(271,480);ctx.lineTo(294,444);ctx.lineTo(373,400);ctx.lineTo(413,392);ctx.lineTo(453,400);ctx.lineTo(490,423);ctx.lineTo(513,459);ctx.lineTo(520,499);ctx.lineTo(513,539);ctx.lineTo(490,575);ctx.lineTo(411,620);ctx.lineTo(370,628);ctx.lineTo(330,620);ctx.lineTo(294,597);ctx.lineTo(271,561);ctx.lineTo(263,521);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(370,521,107,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(370,520,64,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(413,499,385,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.DrawEllipse(p, 156f,49f,772f,772f);
listpt = new List<Point>();listpt.Add(new Point(263,521));listpt.Add(new Point(271,480));listpt.Add(new Point(294,444));listpt.Add(new Point(373,400));listpt.Add(new Point(413,392));listpt.Add(new Point(453,400));listpt.Add(new Point(490,423));listpt.Add(new Point(513,459));listpt.Add(new Point(520,499));listpt.Add(new Point(513,539));listpt.Add(new Point(490,575));listpt.Add(new Point(411,620));listpt.Add(new Point(370,628));listpt.Add(new Point(330,620));listpt.Add(new Point(294,597));listpt.Add(new Point(271,561));listpt.Add(new Point(263,521));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.DrawEllipse(p, 263f,414f,214f,214f);
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.DrawEllipse(p, 306f,456f,128f,128f);
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.DrawEllipse(p, 28f,114f,770f,770f);
        }
    }
}