using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Valve
{
    public class PIXIE_e27e3417_dcba_4dba_bcd7_d89a4d9bbb58 : Pixie
    {
        public PIXIE_e27e3417_dcba_4dba_bcd7_d89a4d9bbb58()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 401f; _h = 337f;
_content = "var arrFillColor = new Array(6); var arrBorderColor = new Array(6); var arrBorderWidth = new Array(6); arrFillColor[0] = '#b2b2b2'; arrFillColor[1] = '#b2b2b2'; arrFillColor[2] = '#b2b2b2'; arrFillColor[3] = '#ccc'; arrFillColor[4] = '#e5e5e5'; arrFillColor[5] = '#e5e5e5'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(184,218);ctx.lineTo(401,218);ctx.lineTo(401,337);ctx.lineTo(184,337);ctx.lineTo(184,218);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(184,165);ctx.lineTo(184,120);ctx.lineTo(244,120);ctx.lineTo(259,117);ctx.lineTo(272,115);ctx.lineTo(284,114);ctx.lineTo(290,113);ctx.lineTo(296,113);ctx.lineTo(301,113);ctx.lineTo(313,114);ctx.lineTo(324,116);ctx.lineTo(336,118);ctx.lineTo(343,120);ctx.lineTo(343,123);ctx.lineTo(343,165);ctx.lineTo(330,168);ctx.lineTo(318,170);ctx.lineTo(307,172);ctx.lineTo(301,172);ctx.lineTo(296,172);ctx.lineTo(284,172);ctx.lineTo(272,170);ctx.lineTo(259,168);ctx.lineTo(244,165);ctx.lineTo(184,165);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(254,56);ctx.lineTo(333,56);ctx.lineTo(333,86);ctx.lineTo(254,86);ctx.lineTo(254,56);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(254,105);ctx.lineTo(333,105);ctx.lineTo(333,114);ctx.lineTo(254,114);ctx.lineTo(254,105);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(273,56);ctx.lineTo(312,56);ctx.lineTo(312,86);ctx.lineTo(273,86);ctx.lineTo(273,56);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(263,52);ctx.lineTo(322,52);ctx.lineTo(322,56);ctx.lineTo(263,56);ctx.lineTo(263,52);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(184,218));listpt.Add(new Point(401,218));listpt.Add(new Point(401,337));listpt.Add(new Point(184,337));listpt.Add(new Point(184,218));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(184,165));listpt.Add(new Point(184,120));listpt.Add(new Point(244,120));listpt.Add(new Point(259,117));listpt.Add(new Point(272,115));listpt.Add(new Point(284,114));listpt.Add(new Point(290,113));listpt.Add(new Point(296,113));listpt.Add(new Point(301,113));listpt.Add(new Point(313,114));listpt.Add(new Point(324,116));listpt.Add(new Point(336,118));listpt.Add(new Point(343,120));listpt.Add(new Point(343,123));listpt.Add(new Point(343,165));listpt.Add(new Point(330,168));listpt.Add(new Point(318,170));listpt.Add(new Point(307,172));listpt.Add(new Point(301,172));listpt.Add(new Point(296,172));listpt.Add(new Point(284,172));listpt.Add(new Point(272,170));listpt.Add(new Point(259,168));listpt.Add(new Point(244,165));listpt.Add(new Point(184,165));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(254,56));listpt.Add(new Point(333,56));listpt.Add(new Point(333,86));listpt.Add(new Point(254,86));listpt.Add(new Point(254,56));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(254,105));listpt.Add(new Point(333,105));listpt.Add(new Point(333,114));listpt.Add(new Point(254,114));listpt.Add(new Point(254,105));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(273,56));listpt.Add(new Point(312,56));listpt.Add(new Point(312,86));listpt.Add(new Point(273,86));listpt.Add(new Point(273,56));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(263,52));listpt.Add(new Point(322,52));listpt.Add(new Point(322,56));listpt.Add(new Point(263,56));listpt.Add(new Point(263,52));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}