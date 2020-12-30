using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Container
{
    public class PIXIE_1194c316_0cb5_4438_a345_1cc37974d58d : Pixie
    {
        public PIXIE_1194c316_0cb5_4438_a345_1cc37974d58d()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#c2a385"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#a37547"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 970f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#c2a385'; arrFillColor[1] = '#a37547'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,734);ctx.lineTo(28,264);ctx.lineTo(264,264);ctx.lineTo(264,28);ctx.lineTo(734,28);ctx.lineTo(734,264);ctx.lineTo(970,264);ctx.lineTo(970,734);ctx.lineTo(734,734);ctx.lineTo(734,970);ctx.lineTo(264,970);ctx.lineTo(264,734);ctx.lineTo(28,734);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(263,263);ctx.lineTo(735,263);ctx.lineTo(735,735);ctx.lineTo(263,735);ctx.lineTo(263,263);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,734));listpt.Add(new Point(28,264));listpt.Add(new Point(264,264));listpt.Add(new Point(264,28));listpt.Add(new Point(734,28));listpt.Add(new Point(734,264));listpt.Add(new Point(970,264));listpt.Add(new Point(970,734));listpt.Add(new Point(734,734));listpt.Add(new Point(734,970));listpt.Add(new Point(264,970));listpt.Add(new Point(264,734));listpt.Add(new Point(28,734));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(263,263));listpt.Add(new Point(735,263));listpt.Add(new Point(735,735));listpt.Add(new Point(263,735));listpt.Add(new Point(263,263));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}