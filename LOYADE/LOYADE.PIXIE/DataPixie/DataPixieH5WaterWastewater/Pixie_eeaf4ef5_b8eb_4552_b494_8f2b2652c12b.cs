using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WaterWastewater
{
    public class PIXIE_eeaf4ef5_b8eb_4552_b494_8f2b2652c12b : Pixie
    {
        public PIXIE_eeaf4ef5_b8eb_4552_b494_8f2b2652c12b()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 735f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#7f7f7f'; arrFillColor[1] = '#ccc'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(970,664);ctx.lineTo(970,130);ctx.lineTo(970,128);ctx.lineTo(942,118);ctx.lineTo(913,113);ctx.lineTo(876,109);ctx.lineTo(847,106);ctx.lineTo(816,104);ctx.lineTo(780,102);ctx.lineTo(743,100);ctx.lineTo(703,98);ctx.lineTo(661,97);ctx.lineTo(616,96);ctx.lineTo(571,95);ctx.lineTo(547,95);ctx.lineTo(523,95);ctx.lineTo(499,95);ctx.lineTo(451,95);ctx.lineTo(404,95);ctx.lineTo(359,96);ctx.lineTo(316,98);ctx.lineTo(275,99);ctx.lineTo(236,101);ctx.lineTo(200,103);ctx.lineTo(166,105);ctx.lineTo(136,108);ctx.lineTo(109,110);ctx.lineTo(74,115);ctx.lineTo(43,121);ctx.lineTo(28,128);ctx.lineTo(28,130);ctx.lineTo(28,664);ctx.lineTo(49,685);ctx.lineTo(74,694);ctx.lineTo(109,703);ctx.lineTo(136,709);ctx.lineTo(166,714);ctx.lineTo(200,718);ctx.lineTo(236,722);ctx.lineTo(275,726);ctx.lineTo(316,729);ctx.lineTo(359,731);ctx.lineTo(404,733);ctx.lineTo(451,734);ctx.lineTo(475,735);ctx.lineTo(499,735);ctx.lineTo(547,734);ctx.lineTo(594,733);ctx.lineTo(639,731);ctx.lineTo(682,729);ctx.lineTo(723,726);ctx.lineTo(762,722);ctx.lineTo(798,718);ctx.lineTo(832,714);ctx.lineTo(862,709);ctx.lineTo(889,703);ctx.lineTo(924,694);ctx.lineTo(949,685);ctx.lineTo(970,667);ctx.lineTo(970,664);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(13.45714,1);ctx.arc(37.08068,130,35,0,Math.PI*2,true);ctx.scale(0.07430998,1);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(970,664));listpt.Add(new Point(970,130));listpt.Add(new Point(970,128));listpt.Add(new Point(942,118));listpt.Add(new Point(913,113));listpt.Add(new Point(876,109));listpt.Add(new Point(847,106));listpt.Add(new Point(816,104));listpt.Add(new Point(780,102));listpt.Add(new Point(743,100));listpt.Add(new Point(703,98));listpt.Add(new Point(661,97));listpt.Add(new Point(616,96));listpt.Add(new Point(571,95));listpt.Add(new Point(547,95));listpt.Add(new Point(523,95));listpt.Add(new Point(499,95));listpt.Add(new Point(451,95));listpt.Add(new Point(404,95));listpt.Add(new Point(359,96));listpt.Add(new Point(316,98));listpt.Add(new Point(275,99));listpt.Add(new Point(236,101));listpt.Add(new Point(200,103));listpt.Add(new Point(166,105));listpt.Add(new Point(136,108));listpt.Add(new Point(109,110));listpt.Add(new Point(74,115));listpt.Add(new Point(43,121));listpt.Add(new Point(28,128));listpt.Add(new Point(28,130));listpt.Add(new Point(28,664));listpt.Add(new Point(49,685));listpt.Add(new Point(74,694));listpt.Add(new Point(109,703));listpt.Add(new Point(136,709));listpt.Add(new Point(166,714));listpt.Add(new Point(200,718));listpt.Add(new Point(236,722));listpt.Add(new Point(275,726));listpt.Add(new Point(316,729));listpt.Add(new Point(359,731));listpt.Add(new Point(404,733));listpt.Add(new Point(451,734));listpt.Add(new Point(475,735));listpt.Add(new Point(499,735));listpt.Add(new Point(547,734));listpt.Add(new Point(594,733));listpt.Add(new Point(639,731));listpt.Add(new Point(682,729));listpt.Add(new Point(723,726));listpt.Add(new Point(762,722));listpt.Add(new Point(798,718));listpt.Add(new Point(832,714));listpt.Add(new Point(862,709));listpt.Add(new Point(889,703));listpt.Add(new Point(924,694));listpt.Add(new Point(949,685));listpt.Add(new Point(970,667));listpt.Add(new Point(970,664));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 2.080681f,95f,70f,70f);g.DrawEllipse(p, 2.080681f,95f,70f,70f);
        }
    }
}