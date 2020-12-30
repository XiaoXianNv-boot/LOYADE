using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Food
{
    public class PIXIE_f7dcd8ca_2b47_4462_86ae_321eece0bd8a : Pixie
    {
        public PIXIE_f7dcd8ca_2b47_4462_86ae_321eece0bd8a()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#657fb2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#333"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#333"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#999"));
_w = 934f; _h = 970f;
_content = "var arrFillColor = new Array(8); var arrBorderColor = new Array(9); var arrBorderWidth = new Array(9); arrFillColor[0] = '#657fb2'; arrFillColor[1] = '#e5e5e5'; arrFillColor[2] = '#ccc'; arrFillColor[3] = '#e5e5e5'; arrFillColor[4] = '#333'; arrFillColor[5] = '#000'; arrFillColor[6] = '#000'; arrFillColor[7] = '#333'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderColor[6] = '#000'; arrBorderColor[7] = '#000'; arrBorderColor[8] = '#999'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; arrBorderWidth[6] = '2'; arrBorderWidth[7] = '2'; arrBorderWidth[8] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(69,970);ctx.lineTo(28,848);ctx.lineTo(680,848);ctx.lineTo(638,970);ctx.lineTo(69,970);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,584);ctx.lineTo(90,441);ctx.lineTo(620,441);ctx.lineTo(680,584);ctx.lineTo(28,584);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(90,261);ctx.lineTo(90,441);ctx.lineTo(620,441);ctx.lineTo(620,261);ctx.lineTo(90,261);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(90,261);ctx.lineTo(109,190);ctx.lineTo(599,190);ctx.lineTo(620,261);ctx.lineTo(90,261);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(1,1.488372);ctx.arc(891,222.3906,43,0,Math.PI*2,true);ctx.scale(1,0.671875);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(1,2.56);ctx.arc(873,129.2969,25,0,Math.PI*2,true);ctx.scale(1,0.390625);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(672,331,64,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[6];ctx.fill();ctx.lineWidth = arrBorderWidth[6];ctx.strokeStyle = arrBorderColor[6];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(1,1.254902);ctx.arc(686,263.7656,51,0,Math.PI*2,true);ctx.scale(1,0.796875);ctx.fillStyle = arrFillColor[7];ctx.fill();ctx.lineWidth = arrBorderWidth[7];ctx.strokeStyle = arrBorderColor[7];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(1,1.269231);ctx.arc(685,260,26,0,Math.PI*2,true);ctx.scale(1,0.7878788);ctx.lineWidth = arrBorderWidth[8];ctx.strokeStyle = arrBorderColor[8];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(69,970));listpt.Add(new Point(28,848));listpt.Add(new Point(680,848));listpt.Add(new Point(638,970));listpt.Add(new Point(69,970));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,584));listpt.Add(new Point(90,441));listpt.Add(new Point(620,441));listpt.Add(new Point(680,584));listpt.Add(new Point(28,584));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(90,261));listpt.Add(new Point(90,441));listpt.Add(new Point(620,441));listpt.Add(new Point(620,261));listpt.Add(new Point(90,261));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(90,261));listpt.Add(new Point(109,190));listpt.Add(new Point(599,190));listpt.Add(new Point(620,261));listpt.Add(new Point(90,261));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillEllipse(sb, 848f,158.3906f,86f,128f);g.DrawEllipse(p, 848f,158.3906f,86f,128f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillEllipse(sb, 848f,65.29691f,50f,128f);g.DrawEllipse(p, 848f,65.29691f,50f,128f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[6]);p = new Pen(Color.Black);p.Width = _listborderwidth[6];p.Color = _listbordercolor[6];g.FillEllipse(sb, 608f,267f,128f,128f);g.DrawEllipse(p, 608f,267f,128f,128f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[7]);p = new Pen(Color.Black);p.Width = _listborderwidth[7];p.Color = _listbordercolor[7];g.FillEllipse(sb, 635f,199.7656f,102f,128f);g.DrawEllipse(p, 635f,199.7656f,102f,128f);
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[8];p.Color = _listbordercolor[8];g.DrawEllipse(p, 659f,227f,52f,66.00001f);
        }
    }
}