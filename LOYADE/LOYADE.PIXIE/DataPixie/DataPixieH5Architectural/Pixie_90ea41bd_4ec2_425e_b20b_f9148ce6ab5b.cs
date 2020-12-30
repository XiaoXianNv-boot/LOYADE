using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Architectural
{
    public class PIXIE_90ea41bd_4ec2_425e_b20b_f9148ce6ab5b : Pixie
    {
        public PIXIE_90ea41bd_4ec2_425e_b20b_f9148ce6ab5b()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#666"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#666"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 245f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#666'; arrFillColor[1] = '#666'; arrFillColor[2] = '#ccc'; arrFillColor[3] = '#e5e5e5'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(689,154);ctx.lineTo(689,168);ctx.lineTo(780,168);ctx.lineTo(780,154);ctx.lineTo(689,154);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(218,154);ctx.lineTo(218,168);ctx.lineTo(309,168);ctx.lineTo(309,154);ctx.lineTo(218,154);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(970,136);ctx.lineTo(928,135);ctx.lineTo(887,128);ctx.lineTo(850,118);ctx.lineTo(816,105);ctx.lineTo(789,88);ctx.lineTo(769,69);ctx.lineTo(757,49);ctx.lineTo(753,28);ctx.lineTo(717,28);ctx.lineTo(713,49);ctx.lineTo(700,69);ctx.lineTo(680,88);ctx.lineTo(653,105);ctx.lineTo(620,118);ctx.lineTo(582,128);ctx.lineTo(542,134);ctx.lineTo(499,136);ctx.lineTo(457,135);ctx.lineTo(416,128);ctx.lineTo(378,118);ctx.lineTo(345,105);ctx.lineTo(318,88);ctx.lineTo(298,69);ctx.lineTo(286,49);ctx.lineTo(281,28);ctx.lineTo(245,28);ctx.lineTo(241,49);ctx.lineTo(229,69);ctx.lineTo(209,88);ctx.lineTo(182,105);ctx.lineTo(149,118);ctx.lineTo(111,128);ctx.lineTo(70,134);ctx.lineTo(28,136);ctx.lineTo(970,136);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,136);ctx.lineTo(245,136);ctx.lineTo(245,28);ctx.lineTo(281,28);ctx.lineTo(281,136);ctx.lineTo(717,136);ctx.lineTo(717,28);ctx.lineTo(753,28);ctx.lineTo(753,136);ctx.lineTo(970,136);ctx.lineTo(970,154);ctx.lineTo(757,154);ctx.lineTo(757,245);ctx.lineTo(712,245);ctx.lineTo(712,154);ctx.lineTo(286,154);ctx.lineTo(286,245);ctx.lineTo(241,245);ctx.lineTo(241,154);ctx.lineTo(28,154);ctx.lineTo(28,136);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(689,154));listpt.Add(new Point(689,168));listpt.Add(new Point(780,168));listpt.Add(new Point(780,154));listpt.Add(new Point(689,154));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(218,154));listpt.Add(new Point(218,168));listpt.Add(new Point(309,168));listpt.Add(new Point(309,154));listpt.Add(new Point(218,154));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(970,136));listpt.Add(new Point(928,135));listpt.Add(new Point(887,128));listpt.Add(new Point(850,118));listpt.Add(new Point(816,105));listpt.Add(new Point(789,88));listpt.Add(new Point(769,69));listpt.Add(new Point(757,49));listpt.Add(new Point(753,28));listpt.Add(new Point(717,28));listpt.Add(new Point(713,49));listpt.Add(new Point(700,69));listpt.Add(new Point(680,88));listpt.Add(new Point(653,105));listpt.Add(new Point(620,118));listpt.Add(new Point(582,128));listpt.Add(new Point(542,134));listpt.Add(new Point(499,136));listpt.Add(new Point(457,135));listpt.Add(new Point(416,128));listpt.Add(new Point(378,118));listpt.Add(new Point(345,105));listpt.Add(new Point(318,88));listpt.Add(new Point(298,69));listpt.Add(new Point(286,49));listpt.Add(new Point(281,28));listpt.Add(new Point(245,28));listpt.Add(new Point(241,49));listpt.Add(new Point(229,69));listpt.Add(new Point(209,88));listpt.Add(new Point(182,105));listpt.Add(new Point(149,118));listpt.Add(new Point(111,128));listpt.Add(new Point(70,134));listpt.Add(new Point(28,136));listpt.Add(new Point(970,136));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,136));listpt.Add(new Point(245,136));listpt.Add(new Point(245,28));listpt.Add(new Point(281,28));listpt.Add(new Point(281,136));listpt.Add(new Point(717,136));listpt.Add(new Point(717,28));listpt.Add(new Point(753,28));listpt.Add(new Point(753,136));listpt.Add(new Point(970,136));listpt.Add(new Point(970,154));listpt.Add(new Point(757,154));listpt.Add(new Point(757,245));listpt.Add(new Point(712,245));listpt.Add(new Point(712,154));listpt.Add(new Point(286,154));listpt.Add(new Point(286,245));listpt.Add(new Point(241,245));listpt.Add(new Point(241,154));listpt.Add(new Point(28,154));listpt.Add(new Point(28,136));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}