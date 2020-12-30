using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_da4c23cf_99ee_415c_989d_3d4c9c25a226 : Pixie
    {
        public PIXIE_da4c23cf_99ee_415c_989d_3d4c9c25a226()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 499f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(499,499);ctx.lineTo(970,499);ctx.lineTo(968,451);ctx.lineTo(961,404);ctx.lineTo(949,359);ctx.lineTo(933,316);ctx.lineTo(913,275);ctx.lineTo(890,236);ctx.lineTo(862,199);ctx.lineTo(832,166);ctx.lineTo(799,136);ctx.lineTo(762,108);ctx.lineTo(723,85);ctx.lineTo(682,65);ctx.lineTo(639,49);ctx.lineTo(594,37);ctx.lineTo(547,30);ctx.lineTo(523,28);ctx.lineTo(499,28);ctx.lineTo(475,28);ctx.lineTo(427,33);ctx.lineTo(381,43);ctx.lineTo(337,56);ctx.lineTo(295,74);ctx.lineTo(255,96);ctx.lineTo(217,122);ctx.lineTo(182,150);ctx.lineTo(150,182);ctx.lineTo(122,217);ctx.lineTo(96,255);ctx.lineTo(74,295);ctx.lineTo(56,337);ctx.lineTo(43,381);ctx.lineTo(33,427);ctx.lineTo(28,475);ctx.lineTo(28,499);ctx.lineTo(499,499);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(499,499));listpt.Add(new Point(970,499));listpt.Add(new Point(968,451));listpt.Add(new Point(961,404));listpt.Add(new Point(949,359));listpt.Add(new Point(933,316));listpt.Add(new Point(913,275));listpt.Add(new Point(890,236));listpt.Add(new Point(862,199));listpt.Add(new Point(832,166));listpt.Add(new Point(799,136));listpt.Add(new Point(762,108));listpt.Add(new Point(723,85));listpt.Add(new Point(682,65));listpt.Add(new Point(639,49));listpt.Add(new Point(594,37));listpt.Add(new Point(547,30));listpt.Add(new Point(523,28));listpt.Add(new Point(499,28));listpt.Add(new Point(475,28));listpt.Add(new Point(427,33));listpt.Add(new Point(381,43));listpt.Add(new Point(337,56));listpt.Add(new Point(295,74));listpt.Add(new Point(255,96));listpt.Add(new Point(217,122));listpt.Add(new Point(182,150));listpt.Add(new Point(150,182));listpt.Add(new Point(122,217));listpt.Add(new Point(96,255));listpt.Add(new Point(74,295));listpt.Add(new Point(56,337));listpt.Add(new Point(43,381));listpt.Add(new Point(33,427));listpt.Add(new Point(28,475));listpt.Add(new Point(28,499));listpt.Add(new Point(499,499));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}