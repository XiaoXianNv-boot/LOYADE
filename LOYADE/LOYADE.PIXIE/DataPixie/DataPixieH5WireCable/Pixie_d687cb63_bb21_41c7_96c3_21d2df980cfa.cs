using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WireCable
{
    public class PIXIE_d687cb63_bb21_41c7_96c3_21d2df980cfa : Pixie
    {
        public PIXIE_d687cb63_bb21_41c7_96c3_21d2df980cfa()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#666"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#666"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 530f; _h = 214f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#666'; arrFillColor[1] = '#666'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(519,174);ctx.lineTo(524,170);ctx.lineTo(530,174);ctx.lineTo(530,210);ctx.lineTo(524,214);ctx.lineTo(519,210);ctx.lineTo(519,174);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(468,174);ctx.lineTo(474,170);ctx.lineTo(480,174);ctx.lineTo(480,210);ctx.lineTo(474,214);ctx.lineTo(468,210);ctx.lineTo(468,174);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(519,174));listpt.Add(new Point(524,170));listpt.Add(new Point(530,174));listpt.Add(new Point(530,210));listpt.Add(new Point(524,214));listpt.Add(new Point(519,210));listpt.Add(new Point(519,174));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(468,174));listpt.Add(new Point(474,170));listpt.Add(new Point(480,174));listpt.Add(new Point(480,210));listpt.Add(new Point(474,214));listpt.Add(new Point(468,210));listpt.Add(new Point(468,174));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}