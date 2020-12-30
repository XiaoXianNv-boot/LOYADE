using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_f403a4c4_fb2e_4d32_a499_ad9167436381 : Pixie
    {
        public PIXIE_f403a4c4_fb2e_4d32_a499_ad9167436381()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 221f; _h = 257f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrFillColor[2] = '#0ff'; arrFillColor[3] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(110,10);ctx.lineTo(110,183);ctx.lineTo(98,185);ctx.lineTo(98,257);ctx.lineTo(130,257);ctx.lineTo(130,185);ctx.lineTo(118,183);ctx.lineTo(118,10);ctx.lineTo(110,10);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(63,62);ctx.lineTo(78,7);ctx.lineTo(150,7);ctx.lineTo(165,62);ctx.lineTo(154,62);ctx.lineTo(118,15);ctx.lineTo(122,15);ctx.lineTo(150,50);ctx.lineTo(138,15);ctx.lineTo(90,15);ctx.lineTo(78,50);ctx.lineTo(106,15);ctx.lineTo(110,15);ctx.lineTo(74,62);ctx.lineTo(63,62);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(40,142);ctx.lineTo(63,62);ctx.lineTo(165,62);ctx.lineTo(188,142);ctx.lineTo(171,142);ctx.lineTo(120,73);ctx.lineTo(125,73);ctx.lineTo(165,125);ctx.lineTo(148,73);ctx.lineTo(80,73);ctx.lineTo(63,125);ctx.lineTo(103,73);ctx.lineTo(108,73);ctx.lineTo(57,142);ctx.lineTo(40,142);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(7,257);ctx.lineTo(40,142);ctx.lineTo(188,142);ctx.lineTo(221,257);ctx.lineTo(196,257);ctx.lineTo(122,158);ctx.lineTo(130,158);ctx.lineTo(188,232);ctx.lineTo(163,158);ctx.lineTo(65,158);ctx.lineTo(40,232);ctx.lineTo(97,158);ctx.lineTo(106,158);ctx.lineTo(32,257);ctx.lineTo(7,257);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(110,10));listpt.Add(new Point(110,183));listpt.Add(new Point(98,185));listpt.Add(new Point(98,257));listpt.Add(new Point(130,257));listpt.Add(new Point(130,185));listpt.Add(new Point(118,183));listpt.Add(new Point(118,10));listpt.Add(new Point(110,10));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(63,62));listpt.Add(new Point(78,7));listpt.Add(new Point(150,7));listpt.Add(new Point(165,62));listpt.Add(new Point(154,62));listpt.Add(new Point(118,15));listpt.Add(new Point(122,15));listpt.Add(new Point(150,50));listpt.Add(new Point(138,15));listpt.Add(new Point(90,15));listpt.Add(new Point(78,50));listpt.Add(new Point(106,15));listpt.Add(new Point(110,15));listpt.Add(new Point(74,62));listpt.Add(new Point(63,62));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(40,142));listpt.Add(new Point(63,62));listpt.Add(new Point(165,62));listpt.Add(new Point(188,142));listpt.Add(new Point(171,142));listpt.Add(new Point(120,73));listpt.Add(new Point(125,73));listpt.Add(new Point(165,125));listpt.Add(new Point(148,73));listpt.Add(new Point(80,73));listpt.Add(new Point(63,125));listpt.Add(new Point(103,73));listpt.Add(new Point(108,73));listpt.Add(new Point(57,142));listpt.Add(new Point(40,142));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(7,257));listpt.Add(new Point(40,142));listpt.Add(new Point(188,142));listpt.Add(new Point(221,257));listpt.Add(new Point(196,257));listpt.Add(new Point(122,158));listpt.Add(new Point(130,158));listpt.Add(new Point(188,232));listpt.Add(new Point(163,158));listpt.Add(new Point(65,158));listpt.Add(new Point(40,232));listpt.Add(new Point(97,158));listpt.Add(new Point(106,158));listpt.Add(new Point(32,257));listpt.Add(new Point(7,257));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}