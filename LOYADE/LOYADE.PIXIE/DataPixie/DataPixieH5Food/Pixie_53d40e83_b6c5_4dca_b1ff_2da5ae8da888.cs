using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Food
{
    public class PIXIE_53d40e83_b6c5_4dca_b1ff_2da5ae8da888 : Pixie
    {
        public PIXIE_53d40e83_b6c5_4dca_b1ff_2da5ae8da888()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#666"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 589f; _h = 880f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#666'; arrFillColor[1] = '#7f7f7f'; arrFillColor[2] = '#b2b2b2'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(50,842);ctx.lineTo(589,842);ctx.lineTo(589,863);ctx.lineTo(50,863);ctx.lineTo(50,842);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(286,880);ctx.lineTo(275,752);ctx.lineTo(365,752);ctx.lineTo(352,880);ctx.lineTo(286,880);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(286,706);ctx.lineTo(275,752);ctx.lineTo(365,752);ctx.lineTo(352,706);ctx.lineTo(286,706);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(50,842));listpt.Add(new Point(589,842));listpt.Add(new Point(589,863));listpt.Add(new Point(50,863));listpt.Add(new Point(50,842));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(286,880));listpt.Add(new Point(275,752));listpt.Add(new Point(365,752));listpt.Add(new Point(352,880));listpt.Add(new Point(286,880));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(286,706));listpt.Add(new Point(275,752));listpt.Add(new Point(365,752));listpt.Add(new Point(352,706));listpt.Add(new Point(286,706));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}