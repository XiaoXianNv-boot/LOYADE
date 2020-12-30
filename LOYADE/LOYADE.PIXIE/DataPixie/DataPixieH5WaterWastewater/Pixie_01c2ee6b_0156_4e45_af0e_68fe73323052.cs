using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WaterWastewater
{
    public class PIXIE_01c2ee6b_0156_4e45_af0e_68fe73323052 : Pixie
    {
        public PIXIE_01c2ee6b_0156_4e45_af0e_68fe73323052()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 892f; _h = 901f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#ccc'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* circle */ ctx.arc(460,460,432,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(706,778);ctx.lineTo(709,765);ctx.lineTo(716,754);ctx.lineTo(727,747);ctx.lineTo(740,744);ctx.lineTo(753,747);ctx.lineTo(764,754);ctx.lineTo(772,765);ctx.lineTo(774,778);ctx.lineTo(774,868);ctx.lineTo(772,880);ctx.lineTo(764,892);ctx.lineTo(753,899);ctx.lineTo(740,901);ctx.lineTo(727,899);ctx.lineTo(716,892);ctx.lineTo(709,880);ctx.lineTo(706,868);ctx.lineTo(706,778);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.DrawEllipse(p, 28f,28f,864f,864f);
listpt = new List<Point>();listpt.Add(new Point(706,778));listpt.Add(new Point(709,765));listpt.Add(new Point(716,754));listpt.Add(new Point(727,747));listpt.Add(new Point(740,744));listpt.Add(new Point(753,747));listpt.Add(new Point(764,754));listpt.Add(new Point(772,765));listpt.Add(new Point(774,778));listpt.Add(new Point(774,868));listpt.Add(new Point(772,880));listpt.Add(new Point(764,892));listpt.Add(new Point(753,899));listpt.Add(new Point(740,901));listpt.Add(new Point(727,899));listpt.Add(new Point(716,892));listpt.Add(new Point(709,880));listpt.Add(new Point(706,868));listpt.Add(new Point(706,778));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}