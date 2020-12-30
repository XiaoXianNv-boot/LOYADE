using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Blower
{
    public class PIXIE_85ad7a85_165a_4846_81be_bc4253556751 : Pixie
    {
        public PIXIE_85ad7a85_165a_4846_81be_bc4253556751()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#7a9999"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#bdcccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#9bb2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#597f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#597f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 756f; _h = 520f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#7a9999'; arrFillColor[1] = '#bdcccc'; arrFillColor[2] = '#9bb2b2'; arrFillColor[3] = '#597f7f'; arrFillColor[4] = '#597f7f'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(242,91);ctx.lineTo(756,91);ctx.lineTo(756,392);ctx.lineTo(242,392);ctx.lineTo(242,91);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(242,113);ctx.lineTo(756,113);ctx.lineTo(756,370);ctx.lineTo(242,370);ctx.lineTo(242,113);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(713,92);ctx.lineTo(628,28);ctx.lineTo(370,28);ctx.lineTo(285,92);ctx.lineTo(713,92);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(606,520);ctx.lineTo(606,499);ctx.lineTo(628,499);ctx.lineTo(628,392);ctx.lineTo(670,392);ctx.lineTo(670,499);ctx.lineTo(692,499);ctx.lineTo(692,520);ctx.lineTo(606,520);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(306,520);ctx.lineTo(306,499);ctx.lineTo(328,499);ctx.lineTo(328,392);ctx.lineTo(370,392);ctx.lineTo(370,499);ctx.lineTo(392,499);ctx.lineTo(392,520);ctx.lineTo(306,520);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(242,91));listpt.Add(new Point(756,91));listpt.Add(new Point(756,392));listpt.Add(new Point(242,392));listpt.Add(new Point(242,91));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(242,113));listpt.Add(new Point(756,113));listpt.Add(new Point(756,370));listpt.Add(new Point(242,370));listpt.Add(new Point(242,113));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(713,92));listpt.Add(new Point(628,28));listpt.Add(new Point(370,28));listpt.Add(new Point(285,92));listpt.Add(new Point(713,92));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(606,520));listpt.Add(new Point(606,499));listpt.Add(new Point(628,499));listpt.Add(new Point(628,392));listpt.Add(new Point(670,392));listpt.Add(new Point(670,499));listpt.Add(new Point(692,499));listpt.Add(new Point(692,520));listpt.Add(new Point(606,520));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(306,520));listpt.Add(new Point(306,499));listpt.Add(new Point(328,499));listpt.Add(new Point(328,392));listpt.Add(new Point(370,392));listpt.Add(new Point(370,499));listpt.Add(new Point(392,499));listpt.Add(new Point(392,520));listpt.Add(new Point(306,520));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}