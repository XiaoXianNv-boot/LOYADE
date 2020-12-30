using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEDuct
{
    public class PIXIE_230879d1_ec45_4501_8617_a56e4e6d190b : Pixie
    {
        public PIXIE_230879d1_ec45_4501_8617_a56e4e6d190b()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 500f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(188,500);ctx.lineTo(808,500);ctx.lineTo(898,444);ctx.lineTo(952,359);ctx.lineTo(970,264);ctx.lineTo(952,169);ctx.lineTo(898,83);ctx.lineTo(808,28);ctx.lineTo(188,28);ctx.lineTo(100,83);ctx.lineTo(46,169);ctx.lineTo(28,264);ctx.lineTo(46,359);ctx.lineTo(100,444);ctx.lineTo(188,500);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(188,500));listpt.Add(new Point(808,500));listpt.Add(new Point(898,444));listpt.Add(new Point(952,359));listpt.Add(new Point(970,264));listpt.Add(new Point(952,169));listpt.Add(new Point(898,83));listpt.Add(new Point(808,28));listpt.Add(new Point(188,28));listpt.Add(new Point(100,83));listpt.Add(new Point(46,169));listpt.Add(new Point(28,264));listpt.Add(new Point(46,359));listpt.Add(new Point(100,444));listpt.Add(new Point(188,500));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}