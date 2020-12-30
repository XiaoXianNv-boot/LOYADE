using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Container
{
    public class PIXIE_2023a39c_439e_436b_8bbd_31830e6e5934 : Pixie
    {
        public PIXIE_2023a39c_439e_436b_8bbd_31830e6e5934()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 107f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#999'; arrFillColor[1] = '#7f7f7f'; arrFillColor[2] = '#7f7f7f'; arrFillColor[3] = '#7f7f7f'; arrFillColor[4] = '#999'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,77);ctx.lineTo(107,77);ctx.lineTo(107,86);ctx.lineTo(460,86);ctx.lineTo(460,77);ctx.lineTo(539,77);ctx.lineTo(539,86);ctx.lineTo(893,86);ctx.lineTo(893,77);ctx.lineTo(970,77);ctx.lineTo(970,107);ctx.lineTo(28,107);ctx.lineTo(28,77);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,58);ctx.lineTo(107,58);ctx.lineTo(96,67);ctx.lineTo(107,77);ctx.lineTo(28,77);ctx.lineTo(37,67);ctx.lineTo(28,58);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(460,58);ctx.lineTo(539,58);ctx.lineTo(529,67);ctx.lineTo(539,77);ctx.lineTo(460,77);ctx.lineTo(469,67);ctx.lineTo(460,58);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(891,58);ctx.lineTo(970,58);ctx.lineTo(961,67);ctx.lineTo(970,77);ctx.lineTo(891,77);ctx.lineTo(901,67);ctx.lineTo(891,58);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(970,58);ctx.lineTo(891,58);ctx.lineTo(891,49);ctx.lineTo(539,49);ctx.lineTo(539,58);ctx.lineTo(460,58);ctx.lineTo(460,49);ctx.lineTo(105,49);ctx.lineTo(105,58);ctx.lineTo(28,58);ctx.lineTo(28,28);ctx.lineTo(970,28);ctx.lineTo(970,58);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,77));listpt.Add(new Point(107,77));listpt.Add(new Point(107,86));listpt.Add(new Point(460,86));listpt.Add(new Point(460,77));listpt.Add(new Point(539,77));listpt.Add(new Point(539,86));listpt.Add(new Point(893,86));listpt.Add(new Point(893,77));listpt.Add(new Point(970,77));listpt.Add(new Point(970,107));listpt.Add(new Point(28,107));listpt.Add(new Point(28,77));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,58));listpt.Add(new Point(107,58));listpt.Add(new Point(96,67));listpt.Add(new Point(107,77));listpt.Add(new Point(28,77));listpt.Add(new Point(37,67));listpt.Add(new Point(28,58));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(460,58));listpt.Add(new Point(539,58));listpt.Add(new Point(529,67));listpt.Add(new Point(539,77));listpt.Add(new Point(460,77));listpt.Add(new Point(469,67));listpt.Add(new Point(460,58));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(891,58));listpt.Add(new Point(970,58));listpt.Add(new Point(961,67));listpt.Add(new Point(970,77));listpt.Add(new Point(891,77));listpt.Add(new Point(901,67));listpt.Add(new Point(891,58));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(970,58));listpt.Add(new Point(891,58));listpt.Add(new Point(891,49));listpt.Add(new Point(539,49));listpt.Add(new Point(539,58));listpt.Add(new Point(460,58));listpt.Add(new Point(460,49));listpt.Add(new Point(105,49));listpt.Add(new Point(105,58));listpt.Add(new Point(28,58));listpt.Add(new Point(28,28));listpt.Add(new Point(970,28));listpt.Add(new Point(970,58));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}