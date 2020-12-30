using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Switch
{
    public class PIXIE_27295608_1bc7_4b22_b9a8_98b349f04590 : Pixie
    {
        public PIXIE_27295608_1bc7_4b22_b9a8_98b349f04590()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 721f; _h = 970f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#000'; arrFillColor[1] = '#b2b2b2'; arrFillColor[2] = '#7f7f7f'; arrFillColor[3] = '#ccc'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(222,28);ctx.lineTo(721,28);ctx.lineTo(721,970);ctx.lineTo(222,970);ctx.lineTo(222,28);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(250,499);ctx.lineTo(693,499);ctx.lineTo(693,942);ctx.lineTo(250,942);ctx.lineTo(250,499);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(250,499);ctx.lineTo(28,111);ctx.lineTo(471,111);ctx.lineTo(693,499);ctx.lineTo(250,499);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(471,56);ctx.lineTo(426,56);ctx.lineTo(382,57);ctx.lineTo(339,59);ctx.lineTo(299,60);ctx.lineTo(260,63);ctx.lineTo(224,65);ctx.lineTo(190,69);ctx.lineTo(158,72);ctx.lineTo(130,76);ctx.lineTo(92,82);ctx.lineTo(63,89);ctx.lineTo(37,100);ctx.lineTo(28,108);ctx.lineTo(28,111);ctx.lineTo(471,111);ctx.lineTo(494,93);ctx.lineTo(523,85);ctx.lineTo(553,79);ctx.lineTo(580,74);ctx.lineTo(610,70);ctx.lineTo(644,66);ctx.lineTo(680,63);ctx.lineTo(693,62);ctx.lineTo(693,56);ctx.lineTo(471,56);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(222,28));listpt.Add(new Point(721,28));listpt.Add(new Point(721,970));listpt.Add(new Point(222,970));listpt.Add(new Point(222,28));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(250,499));listpt.Add(new Point(693,499));listpt.Add(new Point(693,942));listpt.Add(new Point(250,942));listpt.Add(new Point(250,499));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(250,499));listpt.Add(new Point(28,111));listpt.Add(new Point(471,111));listpt.Add(new Point(693,499));listpt.Add(new Point(250,499));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(471,56));listpt.Add(new Point(426,56));listpt.Add(new Point(382,57));listpt.Add(new Point(339,59));listpt.Add(new Point(299,60));listpt.Add(new Point(260,63));listpt.Add(new Point(224,65));listpt.Add(new Point(190,69));listpt.Add(new Point(158,72));listpt.Add(new Point(130,76));listpt.Add(new Point(92,82));listpt.Add(new Point(63,89));listpt.Add(new Point(37,100));listpt.Add(new Point(28,108));listpt.Add(new Point(28,111));listpt.Add(new Point(471,111));listpt.Add(new Point(494,93));listpt.Add(new Point(523,85));listpt.Add(new Point(553,79));listpt.Add(new Point(580,74));listpt.Add(new Point(610,70));listpt.Add(new Point(644,66));listpt.Add(new Point(680,63));listpt.Add(new Point(693,62));listpt.Add(new Point(693,56));listpt.Add(new Point(471,56));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}