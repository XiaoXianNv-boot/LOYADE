using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Architectural
{
    public class PIXIE_6471dda4_1fb3_4546_8861_d26daf4bb98c : Pixie
    {
        public PIXIE_6471dda4_1fb3_4546_8861_d26daf4bb98c()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 869f; _h = 525f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#ccc'; arrFillColor[1] = '#7f7f7f'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(150,384);ctx.lineTo(259,291);ctx.lineTo(869,291);ctx.lineTo(775,384);ctx.lineTo(150,384);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(650,525);ctx.lineTo(869,306);ctx.lineTo(869,290);ctx.lineTo(796,363);ctx.lineTo(779,362);ctx.lineTo(779,132);ctx.lineTo(792,106);ctx.lineTo(869,41);ctx.lineTo(869,25);ctx.lineTo(650,212);ctx.lineTo(650,228);ctx.lineTo(744,150);ctx.lineTo(759,150);ctx.lineTo(760,384);ctx.lineTo(744,416);ctx.lineTo(650,509);ctx.lineTo(650,510);ctx.lineTo(650,525);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(150,384));listpt.Add(new Point(259,291));listpt.Add(new Point(869,291));listpt.Add(new Point(775,384));listpt.Add(new Point(150,384));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(650,525));listpt.Add(new Point(869,306));listpt.Add(new Point(869,290));listpt.Add(new Point(796,363));listpt.Add(new Point(779,362));listpt.Add(new Point(779,132));listpt.Add(new Point(792,106));listpt.Add(new Point(869,41));listpt.Add(new Point(869,25));listpt.Add(new Point(650,212));listpt.Add(new Point(650,228));listpt.Add(new Point(744,150));listpt.Add(new Point(759,150));listpt.Add(new Point(760,384));listpt.Add(new Point(744,416));listpt.Add(new Point(650,509));listpt.Add(new Point(650,510));listpt.Add(new Point(650,525));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}