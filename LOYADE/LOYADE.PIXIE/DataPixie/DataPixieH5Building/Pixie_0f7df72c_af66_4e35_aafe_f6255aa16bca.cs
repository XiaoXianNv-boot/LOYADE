using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Building
{
    public class PIXIE_0f7df72c_af66_4e35_aafe_f6255aa16bca : Pixie
    {
        public PIXIE_0f7df72c_af66_4e35_aafe_f6255aa16bca()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f2f2f2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f2f2f2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 694f;
_content = "var arrFillColor = new Array(8); var arrBorderColor = new Array(8); var arrBorderWidth = new Array(8); arrFillColor[0] = '#e5e5e5'; arrFillColor[1] = '#b2b2b2'; arrFillColor[2] = '#f2f2f2'; arrFillColor[3] = '#f2f2f2'; arrFillColor[4] = '#7f7f7f'; arrFillColor[5] = '#7f7f7f'; arrFillColor[6] = '#7f7f7f'; arrFillColor[7] = '#7f7f7f'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderColor[6] = '#000'; arrBorderColor[7] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; arrBorderWidth[6] = '2'; arrBorderWidth[7] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,248);ctx.lineTo(500,248);ctx.lineTo(500,694);ctx.lineTo(28,694);ctx.lineTo(28,248);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(968,30);ctx.lineTo(500,248);ctx.lineTo(500,694);ctx.lineTo(968,477);ctx.lineTo(968,30);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(279,314);ctx.lineTo(481,314);ctx.lineTo(481,676);ctx.lineTo(279,676);ctx.lineTo(279,314);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,247);ctx.lineTo(501,247);ctx.lineTo(970,28);ctx.lineTo(538,28);ctx.lineTo(28,247);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(921,115);ctx.lineTo(749,190);ctx.lineTo(749,361);ctx.lineTo(921,287);ctx.lineTo(921,115);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(720,203);ctx.lineTo(548,278);ctx.lineTo(548,450);ctx.lineTo(720,375);ctx.lineTo(720,203);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(460,343);ctx.lineTo(303,343);ctx.lineTo(303,499);ctx.lineTo(460,499);ctx.lineTo(460,343);ctx.fillStyle = arrFillColor[6];ctx.fill();ctx.lineWidth = arrBorderWidth[6];ctx.strokeStyle = arrBorderColor[6];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(256,309);ctx.lineTo(47,309);ctx.lineTo(47,562);ctx.lineTo(256,562);ctx.lineTo(256,309);ctx.fillStyle = arrFillColor[7];ctx.fill();ctx.lineWidth = arrBorderWidth[7];ctx.strokeStyle = arrBorderColor[7];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,248));listpt.Add(new Point(500,248));listpt.Add(new Point(500,694));listpt.Add(new Point(28,694));listpt.Add(new Point(28,248));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(968,30));listpt.Add(new Point(500,248));listpt.Add(new Point(500,694));listpt.Add(new Point(968,477));listpt.Add(new Point(968,30));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(279,314));listpt.Add(new Point(481,314));listpt.Add(new Point(481,676));listpt.Add(new Point(279,676));listpt.Add(new Point(279,314));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,247));listpt.Add(new Point(501,247));listpt.Add(new Point(970,28));listpt.Add(new Point(538,28));listpt.Add(new Point(28,247));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(921,115));listpt.Add(new Point(749,190));listpt.Add(new Point(749,361));listpt.Add(new Point(921,287));listpt.Add(new Point(921,115));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(720,203));listpt.Add(new Point(548,278));listpt.Add(new Point(548,450));listpt.Add(new Point(720,375));listpt.Add(new Point(720,203));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(460,343));listpt.Add(new Point(303,343));listpt.Add(new Point(303,499));listpt.Add(new Point(460,499));listpt.Add(new Point(460,343));sb = new SolidBrush(_listfillcolor[6]);p = new Pen(Color.Black);p.Width = _listborderwidth[6];p.Color = _listbordercolor[6];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(256,309));listpt.Add(new Point(47,309));listpt.Add(new Point(47,562));listpt.Add(new Point(256,562));listpt.Add(new Point(256,309));sb = new SolidBrush(_listfillcolor[7]);p = new Pen(Color.Black);p.Width = _listborderwidth[7];p.Color = _listbordercolor[7];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}