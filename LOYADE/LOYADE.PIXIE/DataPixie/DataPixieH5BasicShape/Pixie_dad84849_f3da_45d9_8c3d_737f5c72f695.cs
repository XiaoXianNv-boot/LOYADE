using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_dad84849_f3da_45d9_8c3d_737f5c72f695 : Pixie
    {
        public PIXIE_dad84849_f3da_45d9_8c3d_737f5c72f695()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 463f; _h = 312f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(13,275);ctx.lineTo(13,50);ctx.lineTo(35,65);ctx.lineTo(60,76);ctx.lineTo(85,83);ctx.lineTo(112,87);ctx.lineTo(139,87);ctx.lineTo(165,83);ctx.lineTo(191,76);ctx.lineTo(215,65);ctx.lineTo(238,50);ctx.lineTo(260,36);ctx.lineTo(285,25);ctx.lineTo(310,17);ctx.lineTo(337,13);ctx.lineTo(364,13);ctx.lineTo(390,17);ctx.lineTo(416,25);ctx.lineTo(440,36);ctx.lineTo(463,50);ctx.lineTo(463,275);ctx.lineTo(440,261);ctx.lineTo(416,250);ctx.lineTo(390,242);ctx.lineTo(364,238);ctx.lineTo(337,238);ctx.lineTo(310,242);ctx.lineTo(285,250);ctx.lineTo(260,261);ctx.lineTo(238,275);ctx.lineTo(215,290);ctx.lineTo(191,301);ctx.lineTo(165,308);ctx.lineTo(139,312);ctx.lineTo(112,312);ctx.lineTo(85,308);ctx.lineTo(60,301);ctx.lineTo(35,290);ctx.lineTo(13,275);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(13,275));listpt.Add(new Point(13,50));listpt.Add(new Point(35,65));listpt.Add(new Point(60,76));listpt.Add(new Point(85,83));listpt.Add(new Point(112,87));listpt.Add(new Point(139,87));listpt.Add(new Point(165,83));listpt.Add(new Point(191,76));listpt.Add(new Point(215,65));listpt.Add(new Point(238,50));listpt.Add(new Point(260,36));listpt.Add(new Point(285,25));listpt.Add(new Point(310,17));listpt.Add(new Point(337,13));listpt.Add(new Point(364,13));listpt.Add(new Point(390,17));listpt.Add(new Point(416,25));listpt.Add(new Point(440,36));listpt.Add(new Point(463,50));listpt.Add(new Point(463,275));listpt.Add(new Point(440,261));listpt.Add(new Point(416,250));listpt.Add(new Point(390,242));listpt.Add(new Point(364,238));listpt.Add(new Point(337,238));listpt.Add(new Point(310,242));listpt.Add(new Point(285,250));listpt.Add(new Point(260,261));listpt.Add(new Point(238,275));listpt.Add(new Point(215,290));listpt.Add(new Point(191,301));listpt.Add(new Point(165,308));listpt.Add(new Point(139,312));listpt.Add(new Point(112,312));listpt.Add(new Point(85,308));listpt.Add(new Point(60,301));listpt.Add(new Point(35,290));listpt.Add(new Point(13,275));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}