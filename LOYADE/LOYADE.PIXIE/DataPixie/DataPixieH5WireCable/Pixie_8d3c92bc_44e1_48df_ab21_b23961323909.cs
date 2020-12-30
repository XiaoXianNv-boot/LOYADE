using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WireCable
{
    public class PIXIE_8d3c92bc_44e1_48df_ab21_b23961323909 : Pixie
    {
        public PIXIE_8d3c92bc_44e1_48df_ab21_b23961323909()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 971f; _h = 696f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#b2b2b2'; arrFillColor[1] = '#b2b2b2'; arrFillColor[2] = '#b2b2b2'; arrFillColor[3] = '#7f7f7f'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(736,145);ctx.lineTo(775,145);ctx.lineTo(775,224);ctx.lineTo(736,224);ctx.lineTo(736,145);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(460,145);ctx.lineTo(463,130);ctx.lineTo(472,118);ctx.lineTo(484,109);ctx.lineTo(499,106);ctx.lineTo(676,106);ctx.lineTo(676,67);ctx.lineTo(499,67);ctx.lineTo(484,68);ctx.lineTo(469,73);ctx.lineTo(456,80);ctx.lineTo(444,90);ctx.lineTo(434,102);ctx.lineTo(427,115);ctx.lineTo(422,130);ctx.lineTo(421,145);ctx.lineTo(421,460);ctx.lineTo(460,460);ctx.lineTo(460,145);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(185,538);ctx.lineTo(185,499);ctx.lineTo(362,499);ctx.lineTo(362,538);ctx.lineTo(185,538);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(27,657);ctx.lineTo(971,657);ctx.lineTo(971,696);ctx.lineTo(27,696);ctx.lineTo(27,657);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(736,145));listpt.Add(new Point(775,145));listpt.Add(new Point(775,224));listpt.Add(new Point(736,224));listpt.Add(new Point(736,145));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(460,145));listpt.Add(new Point(463,130));listpt.Add(new Point(472,118));listpt.Add(new Point(484,109));listpt.Add(new Point(499,106));listpt.Add(new Point(676,106));listpt.Add(new Point(676,67));listpt.Add(new Point(499,67));listpt.Add(new Point(484,68));listpt.Add(new Point(469,73));listpt.Add(new Point(456,80));listpt.Add(new Point(444,90));listpt.Add(new Point(434,102));listpt.Add(new Point(427,115));listpt.Add(new Point(422,130));listpt.Add(new Point(421,145));listpt.Add(new Point(421,460));listpt.Add(new Point(460,460));listpt.Add(new Point(460,145));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(185,538));listpt.Add(new Point(185,499));listpt.Add(new Point(362,499));listpt.Add(new Point(362,538));listpt.Add(new Point(185,538));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(27,657));listpt.Add(new Point(971,657));listpt.Add(new Point(971,696));listpt.Add(new Point(27,696));listpt.Add(new Point(27,657));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}