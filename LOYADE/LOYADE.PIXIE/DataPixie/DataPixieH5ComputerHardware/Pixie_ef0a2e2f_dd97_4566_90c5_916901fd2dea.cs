using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ComputerHardware
{
    public class PIXIE_ef0a2e2f_dd97_4566_90c5_916901fd2dea : Pixie
    {
        public PIXIE_ef0a2e2f_dd97_4566_90c5_916901fd2dea()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#808080"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#c0c0c0"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#c0c0c0"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#c0c0c0"));
_w = 937f; _h = 903f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#fff'; arrFillColor[1] = '#808080'; arrFillColor[2] = '#000'; arrFillColor[3] = '#000'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#c0c0c0'; arrBorderColor[2] = '#c0c0c0'; arrBorderColor[3] = '#c0c0c0'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(276,364);ctx.lineTo(263,347);ctx.lineTo(263,28);ctx.lineTo(768,28);ctx.lineTo(768,350);ctx.lineTo(752,364);ctx.lineTo(280,364);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(903,869);ctx.lineTo(937,869);ctx.lineTo(937,903);ctx.lineTo(903,903);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(61,869);ctx.lineTo(95,869);ctx.lineTo(95,903);ctx.lineTo(61,903);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(82,246);ctx.lineTo(57,246);ctx.lineTo(57,187);ctx.lineTo(44,187);ctx.lineTo(70,112);ctx.lineTo(95,187);ctx.lineTo(82,187);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(276,364));listpt.Add(new Point(263,347));listpt.Add(new Point(263,28));listpt.Add(new Point(768,28));listpt.Add(new Point(768,350));listpt.Add(new Point(752,364));listpt.Add(new Point(280,364));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(903,869));listpt.Add(new Point(937,869));listpt.Add(new Point(937,903));listpt.Add(new Point(903,903));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(61,869));listpt.Add(new Point(95,869));listpt.Add(new Point(95,903));listpt.Add(new Point(61,903));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(82,246));listpt.Add(new Point(57,246));listpt.Add(new Point(57,187));listpt.Add(new Point(44,187));listpt.Add(new Point(70,112));listpt.Add(new Point(95,187));listpt.Add(new Point(82,187));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}