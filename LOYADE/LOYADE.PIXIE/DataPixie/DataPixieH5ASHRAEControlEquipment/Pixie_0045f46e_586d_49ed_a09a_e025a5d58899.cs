using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEControlEquipment
{
    public class PIXIE_0045f46e_586d_49ed_a09a_e025a5d58899 : Pixie
    {
        public PIXIE_0045f46e_586d_49ed_a09a_e025a5d58899()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 656f; _h = 970f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrFillColor[2] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(322,342);ctx.lineTo(656,342);ctx.lineTo(656,656);ctx.lineTo(322,656);ctx.lineTo(322,342);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,175);ctx.lineTo(38,120);ctx.lineTo(70,70);ctx.lineTo(120,38);ctx.lineTo(175,28);ctx.lineTo(230,38);ctx.lineTo(280,70);ctx.lineTo(312,120);ctx.lineTo(322,175);ctx.lineTo(175,499);ctx.lineTo(28,175);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(322,823);ctx.lineTo(312,878);ctx.lineTo(280,928);ctx.lineTo(230,960);ctx.lineTo(175,970);ctx.lineTo(120,960);ctx.lineTo(70,928);ctx.lineTo(38,878);ctx.lineTo(28,823);ctx.lineTo(175,499);ctx.lineTo(322,823);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(322,342));listpt.Add(new Point(656,342));listpt.Add(new Point(656,656));listpt.Add(new Point(322,656));listpt.Add(new Point(322,342));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,175));listpt.Add(new Point(38,120));listpt.Add(new Point(70,70));listpt.Add(new Point(120,38));listpt.Add(new Point(175,28));listpt.Add(new Point(230,38));listpt.Add(new Point(280,70));listpt.Add(new Point(312,120));listpt.Add(new Point(322,175));listpt.Add(new Point(175,499));listpt.Add(new Point(28,175));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(322,823));listpt.Add(new Point(312,878));listpt.Add(new Point(280,928));listpt.Add(new Point(230,960));listpt.Add(new Point(175,970));listpt.Add(new Point(120,960));listpt.Add(new Point(70,928));listpt.Add(new Point(38,878));listpt.Add(new Point(28,823));listpt.Add(new Point(175,499));listpt.Add(new Point(322,823));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}