using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Controller
{
    public class PIXIE_2ecb7f90_dbde_457c_ae80_f68d0326691b : Pixie
    {
        public PIXIE_2ecb7f90_dbde_457c_ae80_f68d0326691b()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#333"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#fc0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 813f; _h = 970f;
_content = "var arrFillColor = new Array(6); var arrBorderColor = new Array(6); var arrBorderWidth = new Array(6); arrFillColor[0] = '#b2b2b2'; arrFillColor[1] = '#ccc'; arrFillColor[2] = '#e5e5e5'; arrFillColor[3] = '#333'; arrFillColor[4] = '#fc0'; arrFillColor[5] = '#ccc'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,960);ctx.lineTo(813,960);ctx.lineTo(813,805);ctx.lineTo(774,805);ctx.lineTo(774,786);ctx.lineTo(813,786);ctx.lineTo(813,202);ctx.lineTo(774,202);ctx.lineTo(774,183);ctx.lineTo(813,183);ctx.lineTo(813,28);ctx.lineTo(28,28);ctx.lineTo(28,184);ctx.lineTo(67,184);ctx.lineTo(67,203);ctx.lineTo(28,203);ctx.lineTo(28,786);ctx.lineTo(67,786);ctx.lineTo(67,805);ctx.lineTo(28,805);ctx.lineTo(28,960);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(87,28);ctx.lineTo(754,28);ctx.lineTo(754,960);ctx.lineTo(87,960);ctx.lineTo(87,28);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(106,28);ctx.lineTo(735,28);ctx.lineTo(735,970);ctx.lineTo(263,970);ctx.lineTo(263,921);ctx.lineTo(165,921);ctx.lineTo(165,970);ctx.lineTo(106,970);ctx.lineTo(106,28);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(146,303);ctx.lineTo(263,303);ctx.lineTo(263,695);ctx.lineTo(146,695);ctx.lineTo(146,303);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(146,843);ctx.lineTo(234,843);ctx.lineTo(234,901);ctx.lineTo(146,901);ctx.lineTo(146,843);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(547,877);ctx.lineTo(547,749);ctx.lineTo(591,735);ctx.lineTo(591,892);ctx.lineTo(547,877);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,960));listpt.Add(new Point(813,960));listpt.Add(new Point(813,805));listpt.Add(new Point(774,805));listpt.Add(new Point(774,786));listpt.Add(new Point(813,786));listpt.Add(new Point(813,202));listpt.Add(new Point(774,202));listpt.Add(new Point(774,183));listpt.Add(new Point(813,183));listpt.Add(new Point(813,28));listpt.Add(new Point(28,28));listpt.Add(new Point(28,184));listpt.Add(new Point(67,184));listpt.Add(new Point(67,203));listpt.Add(new Point(28,203));listpt.Add(new Point(28,786));listpt.Add(new Point(67,786));listpt.Add(new Point(67,805));listpt.Add(new Point(28,805));listpt.Add(new Point(28,960));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(87,28));listpt.Add(new Point(754,28));listpt.Add(new Point(754,960));listpt.Add(new Point(87,960));listpt.Add(new Point(87,28));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(106,28));listpt.Add(new Point(735,28));listpt.Add(new Point(735,970));listpt.Add(new Point(263,970));listpt.Add(new Point(263,921));listpt.Add(new Point(165,921));listpt.Add(new Point(165,970));listpt.Add(new Point(106,970));listpt.Add(new Point(106,28));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(146,303));listpt.Add(new Point(263,303));listpt.Add(new Point(263,695));listpt.Add(new Point(146,695));listpt.Add(new Point(146,303));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(146,843));listpt.Add(new Point(234,843));listpt.Add(new Point(234,901));listpt.Add(new Point(146,901));listpt.Add(new Point(146,843));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(547,877));listpt.Add(new Point(547,749));listpt.Add(new Point(591,735));listpt.Add(new Point(591,892));listpt.Add(new Point(547,877));sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}