using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_d5153d02_2e9e_41b0_a19d_046a47f1061d : Pixie
    {
        public PIXIE_d5153d02_2e9e_41b0_a19d_046a47f1061d()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 386f; _h = 100f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(203,100);ctx.lineTo(250,11);ctx.lineTo(284,66);ctx.lineTo(386,66);ctx.lineTo(386,92);ctx.lineTo(271,92);ctx.lineTo(250,58);ctx.lineTo(228,100);ctx.lineTo(203,100);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(169,100);ctx.lineTo(147,58);ctx.lineTo(126,92);ctx.lineTo(11,92);ctx.lineTo(11,66);ctx.lineTo(113,66);ctx.lineTo(147,11);ctx.lineTo(194,100);ctx.lineTo(169,100);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(203,100));listpt.Add(new Point(250,11));listpt.Add(new Point(284,66));listpt.Add(new Point(386,66));listpt.Add(new Point(386,92));listpt.Add(new Point(271,92));listpt.Add(new Point(250,58));listpt.Add(new Point(228,100));listpt.Add(new Point(203,100));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(169,100));listpt.Add(new Point(147,58));listpt.Add(new Point(126,92));listpt.Add(new Point(11,92));listpt.Add(new Point(11,66));listpt.Add(new Point(113,66));listpt.Add(new Point(147,11));listpt.Add(new Point(194,100));listpt.Add(new Point(169,100));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}