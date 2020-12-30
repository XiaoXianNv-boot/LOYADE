using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Blower
{
    public class PIXIE_c15e4335_aec0_43bb_82f2_e747b2275cc1 : Pixie
    {
        public PIXIE_c15e4335_aec0_43bb_82f2_e747b2275cc1()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#e5cb98"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5cb98"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5cb98"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#d9b366"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#d9b366"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f2e5cc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#d9b366"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 892f;
_content = "var arrFillColor = new Array(7); var arrBorderColor = new Array(7); var arrBorderWidth = new Array(7); arrFillColor[0] = '#e5cb98'; arrFillColor[1] = '#e5cb98'; arrFillColor[2] = '#e5cb98'; arrFillColor[3] = '#d9b366'; arrFillColor[4] = '#d9b366'; arrFillColor[5] = '#f2e5cc'; arrFillColor[6] = '#d9b366'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderColor[6] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; arrBorderWidth[6] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(948,352);ctx.lineTo(970,352);ctx.lineTo(970,892);ctx.lineTo(948,892);ctx.lineTo(948,352);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(50,375);ctx.lineTo(948,375);ctx.lineTo(948,869);ctx.lineTo(50,869);ctx.lineTo(50,375);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,352);ctx.lineTo(50,352);ctx.lineTo(50,892);ctx.lineTo(28,892);ctx.lineTo(28,352);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(510,330);ctx.lineTo(510,319);ctx.lineTo(516,319);ctx.lineTo(516,220);ctx.lineTo(510,220);ctx.lineTo(510,186);ctx.lineTo(533,186);ctx.lineTo(533,220);ctx.lineTo(527,220);ctx.lineTo(527,319);ctx.lineTo(533,319);ctx.lineTo(533,330);ctx.lineTo(510,330);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(240,330);ctx.lineTo(240,319);ctx.lineTo(246,319);ctx.lineTo(246,220);ctx.lineTo(240,220);ctx.lineTo(240,186);ctx.lineTo(262,186);ctx.lineTo(262,220);ctx.lineTo(257,220);ctx.lineTo(257,319);ctx.lineTo(262,319);ctx.lineTo(262,330);ctx.lineTo(240,330);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(229,197);ctx.lineTo(544,197);ctx.lineTo(544,208);ctx.lineTo(229,208);ctx.lineTo(229,197);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(219,140);ctx.lineTo(229,140);ctx.lineTo(229,409);ctx.lineTo(219,409);ctx.lineTo(219,140);ctx.fillStyle = arrFillColor[6];ctx.fill();ctx.lineWidth = arrBorderWidth[6];ctx.strokeStyle = arrBorderColor[6];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(948,352));listpt.Add(new Point(970,352));listpt.Add(new Point(970,892));listpt.Add(new Point(948,892));listpt.Add(new Point(948,352));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(50,375));listpt.Add(new Point(948,375));listpt.Add(new Point(948,869));listpt.Add(new Point(50,869));listpt.Add(new Point(50,375));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,352));listpt.Add(new Point(50,352));listpt.Add(new Point(50,892));listpt.Add(new Point(28,892));listpt.Add(new Point(28,352));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(510,330));listpt.Add(new Point(510,319));listpt.Add(new Point(516,319));listpt.Add(new Point(516,220));listpt.Add(new Point(510,220));listpt.Add(new Point(510,186));listpt.Add(new Point(533,186));listpt.Add(new Point(533,220));listpt.Add(new Point(527,220));listpt.Add(new Point(527,319));listpt.Add(new Point(533,319));listpt.Add(new Point(533,330));listpt.Add(new Point(510,330));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(240,330));listpt.Add(new Point(240,319));listpt.Add(new Point(246,319));listpt.Add(new Point(246,220));listpt.Add(new Point(240,220));listpt.Add(new Point(240,186));listpt.Add(new Point(262,186));listpt.Add(new Point(262,220));listpt.Add(new Point(257,220));listpt.Add(new Point(257,319));listpt.Add(new Point(262,319));listpt.Add(new Point(262,330));listpt.Add(new Point(240,330));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(229,197));listpt.Add(new Point(544,197));listpt.Add(new Point(544,208));listpt.Add(new Point(229,208));listpt.Add(new Point(229,197));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(219,140));listpt.Add(new Point(229,140));listpt.Add(new Point(229,409));listpt.Add(new Point(219,409));listpt.Add(new Point(219,140));sb = new SolidBrush(_listfillcolor[6]);p = new Pen(Color.Black);p.Width = _listborderwidth[6];p.Color = _listbordercolor[6];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}