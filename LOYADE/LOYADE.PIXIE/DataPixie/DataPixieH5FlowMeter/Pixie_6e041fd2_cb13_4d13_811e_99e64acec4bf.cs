using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5FlowMeter
{
    public class PIXIE_6e041fd2_cb13_4d13_811e_99e64acec4bf : Pixie
    {
        public PIXIE_6e041fd2_cb13_4d13_811e_99e64acec4bf()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#333"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#666"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 852f; _h = 970f;
_content = "var arrFillColor = new Array(11); var arrBorderColor = new Array(14); var arrBorderWidth = new Array(14); arrFillColor[0] = '#7f7f7f'; arrFillColor[1] = '#7f7f7f'; arrFillColor[2] = '#7f7f7f'; arrFillColor[3] = '#7f7f7f'; arrFillColor[4] = '#7f7f7f'; arrFillColor[5] = '#000'; arrFillColor[6] = '#7f7f7f'; arrFillColor[7] = '#7f7f7f'; arrFillColor[8] = '#333'; arrFillColor[9] = '#ccc'; arrFillColor[10] = '#666'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderColor[6] = '#000'; arrBorderColor[7] = '#000'; arrBorderColor[8] = '#000'; arrBorderColor[9] = '#000'; arrBorderColor[10] = '#000'; arrBorderColor[11] = '#000'; arrBorderColor[12] = '#000'; arrBorderColor[13] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; arrBorderWidth[6] = '2'; arrBorderWidth[7] = '2'; arrBorderWidth[8] = '2'; arrBorderWidth[9] = '2'; arrBorderWidth[10] = '2'; arrBorderWidth[11] = '2'; arrBorderWidth[12] = '2'; arrBorderWidth[13] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(852,705);ctx.lineTo(28,705);ctx.lineTo(28,882);ctx.lineTo(852,882);ctx.lineTo(852,705);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(146,28);ctx.lineTo(735,28);ctx.lineTo(735,322);ctx.lineTo(146,322);ctx.lineTo(146,28);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(234,926);ctx.lineTo(146,911);ctx.lineTo(146,676);ctx.lineTo(234,661);ctx.lineTo(234,926);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(234,617);ctx.lineTo(646,617);ctx.lineTo(646,970);ctx.lineTo(234,970);ctx.lineTo(234,617);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(646,926);ctx.lineTo(735,911);ctx.lineTo(734,676);ctx.lineTo(646,661);ctx.lineTo(646,926);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(263,528);ctx.lineTo(617,528);ctx.lineTo(617,410);ctx.lineTo(263,410);ctx.lineTo(263,528);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(352,410);ctx.lineTo(529,410);ctx.lineTo(529,322);ctx.lineTo(352,322);ctx.lineTo(352,410);ctx.fillStyle = arrFillColor[6];ctx.fill();ctx.lineWidth = arrBorderWidth[6];ctx.strokeStyle = arrBorderColor[6];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(322,617);ctx.lineTo(558,617);ctx.lineTo(558,528);ctx.lineTo(322,528);ctx.lineTo(322,617);ctx.fillStyle = arrFillColor[7];ctx.fill();ctx.lineWidth = arrBorderWidth[7];ctx.strokeStyle = arrBorderColor[7];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(204,57);ctx.lineTo(676,57);ctx.lineTo(676,293);ctx.lineTo(204,293);ctx.lineTo(204,57);ctx.fillStyle = arrFillColor[8];ctx.fill();ctx.lineWidth = arrBorderWidth[8];ctx.strokeStyle = arrBorderColor[8];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(337,617);ctx.lineTo(337,602);ctx.lineTo(381,543);ctx.lineTo(499,543);ctx.lineTo(543,602);ctx.lineTo(543,617);ctx.lineTo(337,617);ctx.fillStyle = arrFillColor[9];ctx.fill();ctx.lineWidth = arrBorderWidth[9];ctx.strokeStyle = arrBorderColor[9];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(705,57,15,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[10];ctx.fill();ctx.lineWidth = arrBorderWidth[10];ctx.strokeStyle = arrBorderColor[10];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(705,293,15,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[11];ctx.strokeStyle = arrBorderColor[11];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(175,57,14,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[12];ctx.strokeStyle = arrBorderColor[12];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(175,293,14,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[13];ctx.strokeStyle = arrBorderColor[13];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(852,705));listpt.Add(new Point(28,705));listpt.Add(new Point(28,882));listpt.Add(new Point(852,882));listpt.Add(new Point(852,705));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(146,28));listpt.Add(new Point(735,28));listpt.Add(new Point(735,322));listpt.Add(new Point(146,322));listpt.Add(new Point(146,28));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(234,926));listpt.Add(new Point(146,911));listpt.Add(new Point(146,676));listpt.Add(new Point(234,661));listpt.Add(new Point(234,926));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(234,617));listpt.Add(new Point(646,617));listpt.Add(new Point(646,970));listpt.Add(new Point(234,970));listpt.Add(new Point(234,617));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(646,926));listpt.Add(new Point(735,911));listpt.Add(new Point(734,676));listpt.Add(new Point(646,661));listpt.Add(new Point(646,926));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(263,528));listpt.Add(new Point(617,528));listpt.Add(new Point(617,410));listpt.Add(new Point(263,410));listpt.Add(new Point(263,528));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(352,410));listpt.Add(new Point(529,410));listpt.Add(new Point(529,322));listpt.Add(new Point(352,322));listpt.Add(new Point(352,410));sb = new SolidBrush(_listfillcolor[6]);p = new Pen(Color.Black);p.Width = _listborderwidth[6];p.Color = _listbordercolor[6];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(322,617));listpt.Add(new Point(558,617));listpt.Add(new Point(558,528));listpt.Add(new Point(322,528));listpt.Add(new Point(322,617));sb = new SolidBrush(_listfillcolor[7]);p = new Pen(Color.Black);p.Width = _listborderwidth[7];p.Color = _listbordercolor[7];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(204,57));listpt.Add(new Point(676,57));listpt.Add(new Point(676,293));listpt.Add(new Point(204,293));listpt.Add(new Point(204,57));sb = new SolidBrush(_listfillcolor[8]);p = new Pen(Color.Black);p.Width = _listborderwidth[8];p.Color = _listbordercolor[8];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(337,617));listpt.Add(new Point(337,602));listpt.Add(new Point(381,543));listpt.Add(new Point(499,543));listpt.Add(new Point(543,602));listpt.Add(new Point(543,617));listpt.Add(new Point(337,617));sb = new SolidBrush(_listfillcolor[9]);p = new Pen(Color.Black);p.Width = _listborderwidth[9];p.Color = _listbordercolor[9];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[10]);p = new Pen(Color.Black);p.Width = _listborderwidth[10];p.Color = _listbordercolor[10];g.FillEllipse(sb, 690f,42f,30f,30f);g.DrawEllipse(p, 690f,42f,30f,30f);
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[11];p.Color = _listbordercolor[11];g.DrawEllipse(p, 690f,278f,30f,30f);
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[12];p.Color = _listbordercolor[12];g.DrawEllipse(p, 161f,43f,28f,28f);
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[13];p.Color = _listbordercolor[13];g.DrawEllipse(p, 161f,279f,28f,28f);
        }
    }
}