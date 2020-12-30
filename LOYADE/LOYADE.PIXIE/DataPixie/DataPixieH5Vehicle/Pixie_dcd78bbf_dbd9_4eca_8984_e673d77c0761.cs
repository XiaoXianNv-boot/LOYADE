using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Vehicle
{
    public class PIXIE_dcd78bbf_dbd9_4eca_8984_e673d77c0761 : Pixie
    {
        public PIXIE_dcd78bbf_dbd9_4eca_8984_e673d77c0761()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#f2f2f2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f2f2f2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f2f2f2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 360f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#f2f2f2'; arrFillColor[1] = '#f2f2f2'; arrFillColor[2] = '#f2f2f2'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(204,289);ctx.lineTo(204,112);ctx.lineTo(87,112);ctx.lineTo(44,188);ctx.lineTo(36,263);ctx.lineTo(36,289);ctx.lineTo(204,289);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(144,360);ctx.lineTo(171,360);ctx.lineTo(171,289);ctx.lineTo(36,289);ctx.lineTo(28,301);ctx.lineTo(40,309);ctx.lineTo(47,304);ctx.lineTo(55,299);ctx.lineTo(64,296);ctx.lineTo(72,294);ctx.lineTo(82,293);ctx.lineTo(91,293);ctx.lineTo(103,295);ctx.lineTo(113,299);ctx.lineTo(123,305);ctx.lineTo(131,312);ctx.lineTo(138,320);ctx.lineTo(143,330);ctx.lineTo(145,340);ctx.lineTo(145,351);ctx.lineTo(144,360);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(247,28);ctx.lineTo(970,28);ctx.lineTo(970,289);ctx.lineTo(247,289);ctx.lineTo(247,28);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(204,289));listpt.Add(new Point(204,112));listpt.Add(new Point(87,112));listpt.Add(new Point(44,188));listpt.Add(new Point(36,263));listpt.Add(new Point(36,289));listpt.Add(new Point(204,289));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(144,360));listpt.Add(new Point(171,360));listpt.Add(new Point(171,289));listpt.Add(new Point(36,289));listpt.Add(new Point(28,301));listpt.Add(new Point(40,309));listpt.Add(new Point(47,304));listpt.Add(new Point(55,299));listpt.Add(new Point(64,296));listpt.Add(new Point(72,294));listpt.Add(new Point(82,293));listpt.Add(new Point(91,293));listpt.Add(new Point(103,295));listpt.Add(new Point(113,299));listpt.Add(new Point(123,305));listpt.Add(new Point(131,312));listpt.Add(new Point(138,320));listpt.Add(new Point(143,330));listpt.Add(new Point(145,340));listpt.Add(new Point(145,351));listpt.Add(new Point(144,360));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(247,28));listpt.Add(new Point(970,28));listpt.Add(new Point(970,289));listpt.Add(new Point(247,289));listpt.Add(new Point(247,28));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}