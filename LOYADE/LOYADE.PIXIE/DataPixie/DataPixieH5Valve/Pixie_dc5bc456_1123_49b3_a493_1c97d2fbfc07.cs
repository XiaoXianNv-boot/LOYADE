using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Valve
{
    public class PIXIE_dc5bc456_1123_49b3_a493_1c97d2fbfc07 : Pixie
    {
        public PIXIE_dc5bc456_1123_49b3_a493_1c97d2fbfc07()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 362f; _h = 911f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#7f7f7f'; arrFillColor[1] = '#7f7f7f'; arrFillColor[2] = '#4c4c4c'; arrFillColor[3] = '#4c4c4c'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(185,420);ctx.lineTo(165,440);ctx.lineTo(165,735);ctx.lineTo(175,744);ctx.lineTo(185,735);ctx.lineTo(342,735);ctx.lineTo(342,440);ctx.lineTo(352,431);ctx.lineTo(342,420);ctx.lineTo(185,420);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(224,754);ctx.lineTo(205,774);ctx.lineTo(205,892);ctx.lineTo(214,901);ctx.lineTo(224,892);ctx.lineTo(303,892);ctx.lineTo(303,774);ctx.lineTo(312,764);ctx.lineTo(303,754);ctx.lineTo(224,754);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(342,735);ctx.lineTo(185,735);ctx.lineTo(175,744);ctx.lineTo(185,754);ctx.lineTo(342,754);ctx.lineTo(362,735);ctx.lineTo(362,440);ctx.lineTo(352,430);ctx.lineTo(342,440);ctx.lineTo(342,735);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(303,892);ctx.lineTo(224,892);ctx.lineTo(214,901);ctx.lineTo(224,911);ctx.lineTo(303,911);ctx.lineTo(322,892);ctx.lineTo(322,774);ctx.lineTo(312,764);ctx.lineTo(303,774);ctx.lineTo(303,892);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(185,420));listpt.Add(new Point(165,440));listpt.Add(new Point(165,735));listpt.Add(new Point(175,744));listpt.Add(new Point(185,735));listpt.Add(new Point(342,735));listpt.Add(new Point(342,440));listpt.Add(new Point(352,431));listpt.Add(new Point(342,420));listpt.Add(new Point(185,420));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(224,754));listpt.Add(new Point(205,774));listpt.Add(new Point(205,892));listpt.Add(new Point(214,901));listpt.Add(new Point(224,892));listpt.Add(new Point(303,892));listpt.Add(new Point(303,774));listpt.Add(new Point(312,764));listpt.Add(new Point(303,754));listpt.Add(new Point(224,754));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(342,735));listpt.Add(new Point(185,735));listpt.Add(new Point(175,744));listpt.Add(new Point(185,754));listpt.Add(new Point(342,754));listpt.Add(new Point(362,735));listpt.Add(new Point(362,440));listpt.Add(new Point(352,430));listpt.Add(new Point(342,440));listpt.Add(new Point(342,735));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(303,892));listpt.Add(new Point(224,892));listpt.Add(new Point(214,901));listpt.Add(new Point(224,911));listpt.Add(new Point(303,911));listpt.Add(new Point(322,892));listpt.Add(new Point(322,774));listpt.Add(new Point(312,764));listpt.Add(new Point(303,774));listpt.Add(new Point(303,892));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}