using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Controller
{
    public class PIXIE_61e16153_dcba_4d1c_83fe_3fcbb19cafb8 : Pixie
    {
        public PIXIE_61e16153_dcba_4d1c_83fe_3fcbb19cafb8()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 578f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(185,558);ctx.lineTo(28,558);ctx.lineTo(28,47);ctx.lineTo(185,47);ctx.lineTo(185,28);ctx.lineTo(813,28);ctx.lineTo(813,47);ctx.lineTo(970,47);ctx.lineTo(970,558);ctx.lineTo(813,558);ctx.lineTo(813,578);ctx.lineTo(185,578);ctx.lineTo(185,558);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(185,558));listpt.Add(new Point(28,558));listpt.Add(new Point(28,47));listpt.Add(new Point(185,47));listpt.Add(new Point(185,28));listpt.Add(new Point(813,28));listpt.Add(new Point(813,47));listpt.Add(new Point(970,47));listpt.Add(new Point(970,558));listpt.Add(new Point(813,558));listpt.Add(new Point(813,578));listpt.Add(new Point(185,578));listpt.Add(new Point(185,558));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}