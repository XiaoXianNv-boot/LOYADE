using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Food
{
    public class PIXIE_4aafb718_0eff_453b_bf13_69ffa42f72df : Pixie
    {
        public PIXIE_4aafb718_0eff_453b_bf13_69ffa42f72df()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#7f3232"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f3232"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#994c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f2e5cc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f2e5cc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 832f; _h = 925f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#7f3232'; arrFillColor[1] = '#7f3232'; arrFillColor[2] = '#994c4c'; arrFillColor[3] = '#f2e5cc'; arrFillColor[4] = '#f2e5cc'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(647,96);ctx.lineTo(763,96);ctx.lineTo(763,73);ctx.lineTo(785,73);ctx.lineTo(785,256);ctx.lineTo(763,256);ctx.lineTo(763,234);ctx.lineTo(647,234);ctx.lineTo(647,96);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(73,625);ctx.lineTo(810,625);ctx.lineTo(763,855);ctx.lineTo(740,855);ctx.lineTo(740,810);ctx.lineTo(487,785);ctx.lineTo(372,785);ctx.lineTo(143,810);ctx.lineTo(143,855);ctx.lineTo(118,855);ctx.lineTo(73,625);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(585,804);ctx.lineTo(483,832);ctx.lineTo(377,832);ctx.lineTo(275,804);ctx.lineTo(182,751);ctx.lineTo(107,676);ctx.lineTo(54,585);ctx.lineTo(28,483);ctx.lineTo(28,377);ctx.lineTo(54,273);ctx.lineTo(109,182);ctx.lineTo(182,107);ctx.lineTo(275,54);ctx.lineTo(377,28);ctx.lineTo(483,28);ctx.lineTo(585,54);ctx.lineTo(678,107);ctx.lineTo(751,182);ctx.lineTo(804,273);ctx.lineTo(832,377);ctx.lineTo(832,483);ctx.lineTo(804,585);ctx.lineTo(751,676);ctx.lineTo(676,751);ctx.lineTo(585,804);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(154,925);ctx.lineTo(50,925);ctx.lineTo(50,900);ctx.lineTo(132,900);ctx.lineTo(143,889);ctx.lineTo(143,785);ctx.lineTo(166,785);ctx.lineTo(166,912);ctx.lineTo(154,925);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(729,925);ctx.lineTo(832,925);ctx.lineTo(832,900);ctx.lineTo(751,900);ctx.lineTo(740,889);ctx.lineTo(740,785);ctx.lineTo(717,785);ctx.lineTo(717,912);ctx.lineTo(729,925);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(647,96));listpt.Add(new Point(763,96));listpt.Add(new Point(763,73));listpt.Add(new Point(785,73));listpt.Add(new Point(785,256));listpt.Add(new Point(763,256));listpt.Add(new Point(763,234));listpt.Add(new Point(647,234));listpt.Add(new Point(647,96));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(73,625));listpt.Add(new Point(810,625));listpt.Add(new Point(763,855));listpt.Add(new Point(740,855));listpt.Add(new Point(740,810));listpt.Add(new Point(487,785));listpt.Add(new Point(372,785));listpt.Add(new Point(143,810));listpt.Add(new Point(143,855));listpt.Add(new Point(118,855));listpt.Add(new Point(73,625));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(585,804));listpt.Add(new Point(483,832));listpt.Add(new Point(377,832));listpt.Add(new Point(275,804));listpt.Add(new Point(182,751));listpt.Add(new Point(107,676));listpt.Add(new Point(54,585));listpt.Add(new Point(28,483));listpt.Add(new Point(28,377));listpt.Add(new Point(54,273));listpt.Add(new Point(109,182));listpt.Add(new Point(182,107));listpt.Add(new Point(275,54));listpt.Add(new Point(377,28));listpt.Add(new Point(483,28));listpt.Add(new Point(585,54));listpt.Add(new Point(678,107));listpt.Add(new Point(751,182));listpt.Add(new Point(804,273));listpt.Add(new Point(832,377));listpt.Add(new Point(832,483));listpt.Add(new Point(804,585));listpt.Add(new Point(751,676));listpt.Add(new Point(676,751));listpt.Add(new Point(585,804));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(154,925));listpt.Add(new Point(50,925));listpt.Add(new Point(50,900));listpt.Add(new Point(132,900));listpt.Add(new Point(143,889));listpt.Add(new Point(143,785));listpt.Add(new Point(166,785));listpt.Add(new Point(166,912));listpt.Add(new Point(154,925));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(729,925));listpt.Add(new Point(832,925));listpt.Add(new Point(832,900));listpt.Add(new Point(751,900));listpt.Add(new Point(740,889));listpt.Add(new Point(740,785));listpt.Add(new Point(717,785));listpt.Add(new Point(717,912));listpt.Add(new Point(729,925));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}