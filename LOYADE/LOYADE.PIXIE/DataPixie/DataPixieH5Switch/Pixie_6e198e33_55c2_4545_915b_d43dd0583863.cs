using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Switch
{
    public class PIXIE_6e198e33_55c2_4545_915b_d43dd0583863 : Pixie
    {
        public PIXIE_6e198e33_55c2_4545_915b_d43dd0583863()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f00"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 971f; _h = 579f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#7f7f7f'; arrFillColor[1] = '#7f7f7f'; arrFillColor[2] = '#7f7f7f'; arrFillColor[3] = '#f00'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(381,185);ctx.lineTo(381,27);ctx.lineTo(971,27);ctx.lineTo(971,185);ctx.lineTo(381,185);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(381,579);ctx.lineTo(381,421);ctx.lineTo(971,421);ctx.lineTo(971,579);ctx.lineTo(381,579);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(341,264);ctx.lineTo(341,67);ctx.lineTo(675,67);ctx.lineTo(675,146);ctx.lineTo(420,146);ctx.lineTo(420,460);ctx.lineTo(675,460);ctx.lineTo(675,539);ctx.lineTo(341,539);ctx.lineTo(341,343);ctx.lineTo(140,343);ctx.lineTo(140,264);ctx.lineTo(341,264);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(96,304,69,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(381,185));listpt.Add(new Point(381,27));listpt.Add(new Point(971,27));listpt.Add(new Point(971,185));listpt.Add(new Point(381,185));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(381,579));listpt.Add(new Point(381,421));listpt.Add(new Point(971,421));listpt.Add(new Point(971,579));listpt.Add(new Point(381,579));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(341,264));listpt.Add(new Point(341,67));listpt.Add(new Point(675,67));listpt.Add(new Point(675,146));listpt.Add(new Point(420,146));listpt.Add(new Point(420,460));listpt.Add(new Point(675,460));listpt.Add(new Point(675,539));listpt.Add(new Point(341,539));listpt.Add(new Point(341,343));listpt.Add(new Point(140,343));listpt.Add(new Point(140,264));listpt.Add(new Point(341,264));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillEllipse(sb, 27f,235f,138f,138f);g.DrawEllipse(p, 27f,235f,138f,138f);
        }
    }
}