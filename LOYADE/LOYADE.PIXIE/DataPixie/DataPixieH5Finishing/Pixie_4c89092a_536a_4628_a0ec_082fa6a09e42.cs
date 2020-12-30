using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Finishing
{
    public class PIXIE_4c89092a_536a_4628_a0ec_082fa6a09e42 : Pixie
    {
        public PIXIE_4c89092a_536a_4628_a0ec_082fa6a09e42()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#994c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 969f; _h = 969f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#ccc'; arrFillColor[1] = '#fff'; arrFillColor[2] = '#994c4c'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(969,969);ctx.lineTo(27,969);ctx.lineTo(27,27);ctx.lineTo(969,27);ctx.lineTo(969,969);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(554,555);ctx.lineTo(554,390);ctx.lineTo(386,360);ctx.lineTo(277,360);ctx.lineTo(277,416);ctx.lineTo(165,416);ctx.lineTo(165,528);ctx.lineTo(277,528);ctx.lineTo(277,581);ctx.lineTo(386,581);ctx.lineTo(554,555);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(166,527);ctx.lineTo(27,527);ctx.lineTo(27,416);ctx.lineTo(166,416);ctx.lineTo(166,527);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(969,969));listpt.Add(new Point(27,969));listpt.Add(new Point(27,27));listpt.Add(new Point(969,27));listpt.Add(new Point(969,969));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(554,555));listpt.Add(new Point(554,390));listpt.Add(new Point(386,360));listpt.Add(new Point(277,360));listpt.Add(new Point(277,416));listpt.Add(new Point(165,416));listpt.Add(new Point(165,528));listpt.Add(new Point(277,528));listpt.Add(new Point(277,581));listpt.Add(new Point(386,581));listpt.Add(new Point(554,555));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(166,527));listpt.Add(new Point(27,527));listpt.Add(new Point(27,416));listpt.Add(new Point(166,416));listpt.Add(new Point(166,527));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}