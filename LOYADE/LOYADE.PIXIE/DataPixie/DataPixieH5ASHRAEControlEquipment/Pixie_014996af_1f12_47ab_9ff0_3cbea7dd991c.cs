using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEControlEquipment
{
    public class PIXIE_014996af_1f12_47ab_9ff0_3cbea7dd991c : Pixie
    {
        public PIXIE_014996af_1f12_47ab_9ff0_3cbea7dd991c()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 951f; _h = 740f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(913,47);ctx.lineTo(927,50);ctx.lineTo(940,58);ctx.lineTo(948,71);ctx.lineTo(951,85);ctx.lineTo(948,100);ctx.lineTo(940,113);ctx.lineTo(927,121);ctx.lineTo(913,124);ctx.lineTo(643,124);ctx.lineTo(629,121);ctx.lineTo(616,113);ctx.lineTo(608,100);ctx.lineTo(605,85);ctx.lineTo(608,71);ctx.lineTo(616,58);ctx.lineTo(629,50);ctx.lineTo(643,47);ctx.lineTo(913,47);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,278);ctx.lineTo(489,278);ctx.lineTo(489,740);ctx.lineTo(28,740);ctx.lineTo(28,278);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(258,670,46,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(913,47));listpt.Add(new Point(927,50));listpt.Add(new Point(940,58));listpt.Add(new Point(948,71));listpt.Add(new Point(951,85));listpt.Add(new Point(948,100));listpt.Add(new Point(940,113));listpt.Add(new Point(927,121));listpt.Add(new Point(913,124));listpt.Add(new Point(643,124));listpt.Add(new Point(629,121));listpt.Add(new Point(616,113));listpt.Add(new Point(608,100));listpt.Add(new Point(605,85));listpt.Add(new Point(608,71));listpt.Add(new Point(616,58));listpt.Add(new Point(629,50));listpt.Add(new Point(643,47));listpt.Add(new Point(913,47));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,278));listpt.Add(new Point(489,278));listpt.Add(new Point(489,740));listpt.Add(new Point(28,740));listpt.Add(new Point(28,278));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.DrawEllipse(p, 212f,624f,92f,92f);
        }
    }
}