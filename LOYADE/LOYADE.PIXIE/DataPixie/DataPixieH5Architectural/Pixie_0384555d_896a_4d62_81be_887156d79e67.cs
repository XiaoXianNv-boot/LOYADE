using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Architectural
{
    public class PIXIE_0384555d_896a_4d62_81be_887156d79e67 : Pixie
    {
        public PIXIE_0384555d_896a_4d62_81be_887156d79e67()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 185f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#ccc'; arrFillColor[1] = '#7f7f7f'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(77,141);ctx.lineTo(111,111);ctx.lineTo(970,111);ctx.lineTo(941,141);ctx.lineTo(77,141);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(901,185);ctx.lineTo(970,116);ctx.lineTo(970,111);ctx.lineTo(947,134);ctx.lineTo(942,134);ctx.lineTo(942,61);ctx.lineTo(946,53);ctx.lineTo(970,33);ctx.lineTo(970,28);ctx.lineTo(901,87);ctx.lineTo(901,92);ctx.lineTo(931,67);ctx.lineTo(936,67);ctx.lineTo(936,141);ctx.lineTo(931,151);ctx.lineTo(901,180);ctx.lineTo(901,180);ctx.lineTo(901,185);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(77,141));listpt.Add(new Point(111,111));listpt.Add(new Point(970,111));listpt.Add(new Point(941,141));listpt.Add(new Point(77,141));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(901,185));listpt.Add(new Point(970,116));listpt.Add(new Point(970,111));listpt.Add(new Point(947,134));listpt.Add(new Point(942,134));listpt.Add(new Point(942,61));listpt.Add(new Point(946,53));listpt.Add(new Point(970,33));listpt.Add(new Point(970,28));listpt.Add(new Point(901,87));listpt.Add(new Point(901,92));listpt.Add(new Point(931,67));listpt.Add(new Point(936,67));listpt.Add(new Point(936,141));listpt.Add(new Point(931,151));listpt.Add(new Point(901,180));listpt.Add(new Point(901,180));listpt.Add(new Point(901,185));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}