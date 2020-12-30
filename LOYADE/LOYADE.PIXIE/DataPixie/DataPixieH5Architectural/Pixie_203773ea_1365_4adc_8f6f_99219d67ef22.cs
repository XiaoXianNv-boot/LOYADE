using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Architectural
{
    public class PIXIE_203773ea_1365_4adc_8f6f_99219d67ef22 : Pixie
    {
        public PIXIE_203773ea_1365_4adc_8f6f_99219d67ef22()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#597f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#bdcccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#bdcccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#386666"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 970f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#597f7f'; arrFillColor[1] = '#bdcccc'; arrFillColor[2] = '#bdcccc'; arrFillColor[3] = '#386666'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(950,106);ctx.lineTo(950,165);ctx.lineTo(48,165);ctx.lineTo(48,106);ctx.lineTo(950,106);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(950,106);ctx.lineTo(950,970);ctx.lineTo(970,970);ctx.lineTo(970,106);ctx.lineTo(950,106);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,106);ctx.lineTo(28,970);ctx.lineTo(48,970);ctx.lineTo(48,106);ctx.lineTo(28,106);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(48,970);ctx.lineTo(87,931);ctx.lineTo(87,185);ctx.lineTo(911,185);ctx.lineTo(911,931);ctx.lineTo(950,970);ctx.lineTo(950,165);ctx.lineTo(48,165);ctx.lineTo(48,970);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(950,106));listpt.Add(new Point(950,165));listpt.Add(new Point(48,165));listpt.Add(new Point(48,106));listpt.Add(new Point(950,106));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(950,106));listpt.Add(new Point(950,970));listpt.Add(new Point(970,970));listpt.Add(new Point(970,106));listpt.Add(new Point(950,106));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,106));listpt.Add(new Point(28,970));listpt.Add(new Point(48,970));listpt.Add(new Point(48,106));listpt.Add(new Point(28,106));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(48,970));listpt.Add(new Point(87,931));listpt.Add(new Point(87,185));listpt.Add(new Point(911,185));listpt.Add(new Point(911,931));listpt.Add(new Point(950,970));listpt.Add(new Point(950,165));listpt.Add(new Point(48,165));listpt.Add(new Point(48,970));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}