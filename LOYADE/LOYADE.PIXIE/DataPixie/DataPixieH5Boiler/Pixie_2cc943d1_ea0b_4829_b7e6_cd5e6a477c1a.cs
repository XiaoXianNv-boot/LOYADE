using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Boiler
{
    public class PIXIE_2cc943d1_ea0b_4829_b7e6_cd5e6a477c1a : Pixie
    {
        public PIXIE_2cc943d1_ea0b_4829_b7e6_cd5e6a477c1a()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#333"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#324c7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#191919"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#191919"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#191919"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#333"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 683f;
_content = "var arrFillColor = new Array(6); var arrBorderColor = new Array(6); var arrBorderWidth = new Array(6); arrFillColor[0] = '#333'; arrFillColor[1] = '#324c7f'; arrFillColor[2] = '#191919'; arrFillColor[3] = '#191919'; arrFillColor[4] = '#191919'; arrFillColor[5] = '#333'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(738,160);ctx.lineTo(760,160);ctx.lineTo(760,331);ctx.lineTo(738,331);ctx.lineTo(738,160);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(732,527);ctx.lineTo(872,527);ctx.lineTo(880,499);ctx.lineTo(908,493);ctx.lineTo(908,387);ctx.lineTo(851,359);ctx.lineTo(813,359);ctx.lineTo(789,380);ctx.lineTo(732,380);ctx.lineTo(732,527);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(359,28);ctx.lineTo(401,28);ctx.lineTo(401,35);ctx.lineTo(359,35);ctx.lineTo(359,28);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(647,28);ctx.lineTo(690,28);ctx.lineTo(690,35);ctx.lineTo(647,35);ctx.lineTo(647,28);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,683);ctx.lineTo(970,683);ctx.lineTo(970,654);ctx.lineTo(28,654);ctx.lineTo(28,683);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(738,455);ctx.lineTo(760,455);ctx.lineTo(802,626);ctx.lineTo(738,626);ctx.lineTo(738,455);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(738,160));listpt.Add(new Point(760,160));listpt.Add(new Point(760,331));listpt.Add(new Point(738,331));listpt.Add(new Point(738,160));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(732,527));listpt.Add(new Point(872,527));listpt.Add(new Point(880,499));listpt.Add(new Point(908,493));listpt.Add(new Point(908,387));listpt.Add(new Point(851,359));listpt.Add(new Point(813,359));listpt.Add(new Point(789,380));listpt.Add(new Point(732,380));listpt.Add(new Point(732,527));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(359,28));listpt.Add(new Point(401,28));listpt.Add(new Point(401,35));listpt.Add(new Point(359,35));listpt.Add(new Point(359,28));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(647,28));listpt.Add(new Point(690,28));listpt.Add(new Point(690,35));listpt.Add(new Point(647,35));listpt.Add(new Point(647,28));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,683));listpt.Add(new Point(970,683));listpt.Add(new Point(970,654));listpt.Add(new Point(28,654));listpt.Add(new Point(28,683));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(738,455));listpt.Add(new Point(760,455));listpt.Add(new Point(802,626));listpt.Add(new Point(738,626));listpt.Add(new Point(738,455));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}