using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Container
{
    public class PIXIE_f8bb25ba_66a2_4bdb_962a_71c17bdaaab7 : Pixie
    {
        public PIXIE_f8bb25ba_66a2_4bdb_962a_71c17bdaaab7()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#c2a385"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#963"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ad845b"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 892f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#c2a385'; arrFillColor[1] = '#963'; arrFillColor[2] = '#ad845b'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,106);ctx.lineTo(813,106);ctx.lineTo(813,892);ctx.lineTo(28,892);ctx.lineTo(28,106);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,106);ctx.lineTo(185,28);ctx.lineTo(970,28);ctx.lineTo(813,106);ctx.lineTo(28,106);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(813,892);ctx.lineTo(813,106);ctx.lineTo(970,28);ctx.lineTo(970,813);ctx.lineTo(813,892);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,106));listpt.Add(new Point(813,106));listpt.Add(new Point(813,892));listpt.Add(new Point(28,892));listpt.Add(new Point(28,106));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,106));listpt.Add(new Point(185,28));listpt.Add(new Point(970,28));listpt.Add(new Point(813,106));listpt.Add(new Point(28,106));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(813,892));listpt.Add(new Point(813,106));listpt.Add(new Point(970,28));listpt.Add(new Point(970,813));listpt.Add(new Point(813,892));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}