using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Switch
{
    public class PIXIE_9bcb605f_5b81_45d7_87ce_39ef0d7a285e : Pixie
    {
        public PIXIE_9bcb605f_5b81_45d7_87ce_39ef0d7a285e()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 720f; _h = 970f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#000'; arrFillColor[1] = '#7f7f7f'; arrFillColor[2] = '#b2b2b2'; arrFillColor[3] = '#7f7f7f'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(220,970);ctx.lineTo(720,970);ctx.lineTo(720,28);ctx.lineTo(220,28);ctx.lineTo(220,970);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(248,499);ctx.lineTo(691,499);ctx.lineTo(691,56);ctx.lineTo(248,56);ctx.lineTo(248,499);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(248,499);ctx.lineTo(28,887);ctx.lineTo(471,887);ctx.lineTo(691,499);ctx.lineTo(248,499);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(471,942);ctx.lineTo(425,942);ctx.lineTo(381,941);ctx.lineTo(339,939);ctx.lineTo(298,938);ctx.lineTo(259,935);ctx.lineTo(223,933);ctx.lineTo(189,929);ctx.lineTo(158,926);ctx.lineTo(129,922);ctx.lineTo(92,916);ctx.lineTo(63,909);ctx.lineTo(37,898);ctx.lineTo(28,890);ctx.lineTo(28,887);ctx.lineTo(471,887);ctx.lineTo(494,905);ctx.lineTo(523,913);ctx.lineTo(552,919);ctx.lineTo(579,924);ctx.lineTo(609,928);ctx.lineTo(642,932);ctx.lineTo(678,935);ctx.lineTo(691,936);ctx.lineTo(691,942);ctx.lineTo(471,942);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(220,970));listpt.Add(new Point(720,970));listpt.Add(new Point(720,28));listpt.Add(new Point(220,28));listpt.Add(new Point(220,970));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(248,499));listpt.Add(new Point(691,499));listpt.Add(new Point(691,56));listpt.Add(new Point(248,56));listpt.Add(new Point(248,499));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(248,499));listpt.Add(new Point(28,887));listpt.Add(new Point(471,887));listpt.Add(new Point(691,499));listpt.Add(new Point(248,499));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(471,942));listpt.Add(new Point(425,942));listpt.Add(new Point(381,941));listpt.Add(new Point(339,939));listpt.Add(new Point(298,938));listpt.Add(new Point(259,935));listpt.Add(new Point(223,933));listpt.Add(new Point(189,929));listpt.Add(new Point(158,926));listpt.Add(new Point(129,922));listpt.Add(new Point(92,916));listpt.Add(new Point(63,909));listpt.Add(new Point(37,898));listpt.Add(new Point(28,890));listpt.Add(new Point(28,887));listpt.Add(new Point(471,887));listpt.Add(new Point(494,905));listpt.Add(new Point(523,913));listpt.Add(new Point(552,919));listpt.Add(new Point(579,924));listpt.Add(new Point(609,928));listpt.Add(new Point(642,932));listpt.Add(new Point(678,935));listpt.Add(new Point(691,936));listpt.Add(new Point(691,942));listpt.Add(new Point(471,942));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}