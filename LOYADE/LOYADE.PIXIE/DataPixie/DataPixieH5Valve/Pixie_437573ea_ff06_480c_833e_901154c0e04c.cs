using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Valve
{
    public class PIXIE_437573ea_ff06_480c_833e_901154c0e04c : Pixie
    {
        public PIXIE_437573ea_ff06_480c_833e_901154c0e04c()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 403f; _h = 349f;
_content = "var arrFillColor = new Array(7); var arrBorderColor = new Array(7); var arrBorderWidth = new Array(7); arrFillColor[0] = '#999'; arrFillColor[1] = '#999'; arrFillColor[2] = '#7f7f7f'; arrFillColor[3] = '#b2b2b2'; arrFillColor[4] = '#e5e5e5'; arrFillColor[5] = '#7f7f7f'; arrFillColor[6] = '#999'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderColor[6] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; arrBorderWidth[6] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(158,275);ctx.lineTo(138,255);ctx.lineTo(138,51);ctx.lineTo(158,30);ctx.lineTo(362,30);ctx.lineTo(383,51);ctx.lineTo(383,255);ctx.lineTo(362,275);ctx.lineTo(158,275);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(401,173);ctx.lineTo(120,173);ctx.lineTo(117,171);ctx.lineTo(117,135);ctx.lineTo(120,132);ctx.lineTo(401,132);ctx.lineTo(403,135);ctx.lineTo(403,171);ctx.lineTo(401,173);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(209,30);ctx.lineTo(206,15);ctx.lineTo(182,15);ctx.lineTo(179,30);ctx.lineTo(209,30);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(204,30);ctx.lineTo(202,15);ctx.lineTo(182,15);ctx.lineTo(179,30);ctx.lineTo(204,30);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(186,15);ctx.lineTo(182,15);ctx.lineTo(179,30);ctx.lineTo(184,30);ctx.lineTo(186,15);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(138,250);ctx.lineTo(122,250);ctx.lineTo(122,188);ctx.lineTo(138,188);ctx.lineTo(138,250);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(122,209);ctx.lineTo(36,209);ctx.lineTo(20,214);ctx.lineTo(15,229);ctx.lineTo(15,349);ctx.lineTo(36,349);ctx.lineTo(36,234);ctx.lineTo(41,229);ctx.lineTo(122,229);ctx.lineTo(122,209);ctx.fillStyle = arrFillColor[6];ctx.fill();ctx.lineWidth = arrBorderWidth[6];ctx.strokeStyle = arrBorderColor[6];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(158,275));listpt.Add(new Point(138,255));listpt.Add(new Point(138,51));listpt.Add(new Point(158,30));listpt.Add(new Point(362,30));listpt.Add(new Point(383,51));listpt.Add(new Point(383,255));listpt.Add(new Point(362,275));listpt.Add(new Point(158,275));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(401,173));listpt.Add(new Point(120,173));listpt.Add(new Point(117,171));listpt.Add(new Point(117,135));listpt.Add(new Point(120,132));listpt.Add(new Point(401,132));listpt.Add(new Point(403,135));listpt.Add(new Point(403,171));listpt.Add(new Point(401,173));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(209,30));listpt.Add(new Point(206,15));listpt.Add(new Point(182,15));listpt.Add(new Point(179,30));listpt.Add(new Point(209,30));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(204,30));listpt.Add(new Point(202,15));listpt.Add(new Point(182,15));listpt.Add(new Point(179,30));listpt.Add(new Point(204,30));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(186,15));listpt.Add(new Point(182,15));listpt.Add(new Point(179,30));listpt.Add(new Point(184,30));listpt.Add(new Point(186,15));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(138,250));listpt.Add(new Point(122,250));listpt.Add(new Point(122,188));listpt.Add(new Point(138,188));listpt.Add(new Point(138,250));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(122,209));listpt.Add(new Point(36,209));listpt.Add(new Point(20,214));listpt.Add(new Point(15,229));listpt.Add(new Point(15,349));listpt.Add(new Point(36,349));listpt.Add(new Point(36,234));listpt.Add(new Point(41,229));listpt.Add(new Point(122,229));listpt.Add(new Point(122,209));sb = new SolidBrush(_listfillcolor[6]);p = new Pen(Color.Black);p.Width = _listborderwidth[6];p.Color = _listbordercolor[6];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}