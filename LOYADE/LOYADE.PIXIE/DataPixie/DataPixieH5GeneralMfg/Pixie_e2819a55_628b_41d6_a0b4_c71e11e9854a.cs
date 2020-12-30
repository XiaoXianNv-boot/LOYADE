using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_e2819a55_628b_41d6_a0b4_c71e11e9854a : Pixie
    {
        public PIXIE_e2819a55_628b_41d6_a0b4_c71e11e9854a()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#161717"));
_w = 98f; _h = 255f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#161717'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(37,28);ctx.lineTo(37,81);ctx.lineTo(33,86);ctx.lineTo(29,90);ctx.lineTo(25,95);ctx.lineTo(21,99);ctx.lineTo(17,104);ctx.lineTo(13,109);ctx.lineTo(10,114);ctx.lineTo(7,119);ctx.lineTo(7,136);ctx.lineTo(7,238);ctx.lineTo(7,255);ctx.lineTo(18,255);ctx.lineTo(86,255);ctx.lineTo(98,255);ctx.lineTo(98,238);ctx.lineTo(98,119);ctx.lineTo(95,114);ctx.lineTo(91,109);ctx.lineTo(87,104);ctx.lineTo(83,99);ctx.lineTo(79,95);ctx.lineTo(75,90);ctx.lineTo(71,86);ctx.lineTo(67,81);ctx.lineTo(67,28);ctx.lineTo(75,28);ctx.lineTo(75,13);ctx.lineTo(69,10);ctx.lineTo(64,8);ctx.lineTo(58,7);ctx.lineTo(53,7);ctx.lineTo(47,7);ctx.lineTo(41,8);ctx.lineTo(36,10);ctx.lineTo(30,13);ctx.lineTo(30,24);ctx.lineTo(29,28);ctx.lineTo(37,28);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(37,28));listpt.Add(new Point(37,81));listpt.Add(new Point(33,86));listpt.Add(new Point(29,90));listpt.Add(new Point(25,95));listpt.Add(new Point(21,99));listpt.Add(new Point(17,104));listpt.Add(new Point(13,109));listpt.Add(new Point(10,114));listpt.Add(new Point(7,119));listpt.Add(new Point(7,136));listpt.Add(new Point(7,238));listpt.Add(new Point(7,255));listpt.Add(new Point(18,255));listpt.Add(new Point(86,255));listpt.Add(new Point(98,255));listpt.Add(new Point(98,238));listpt.Add(new Point(98,119));listpt.Add(new Point(95,114));listpt.Add(new Point(91,109));listpt.Add(new Point(87,104));listpt.Add(new Point(83,99));listpt.Add(new Point(79,95));listpt.Add(new Point(75,90));listpt.Add(new Point(71,86));listpt.Add(new Point(67,81));listpt.Add(new Point(67,28));listpt.Add(new Point(75,28));listpt.Add(new Point(75,13));listpt.Add(new Point(69,10));listpt.Add(new Point(64,8));listpt.Add(new Point(58,7));listpt.Add(new Point(53,7));listpt.Add(new Point(47,7));listpt.Add(new Point(41,8));listpt.Add(new Point(36,10));listpt.Add(new Point(30,13));listpt.Add(new Point(30,24));listpt.Add(new Point(29,28));listpt.Add(new Point(37,28));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}