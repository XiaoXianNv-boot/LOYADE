using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_af8dfa2c_52a6_4ebd_b787_09ac341a7537 : Pixie
    {
        public PIXIE_af8dfa2c_52a6_4ebd_b787_09ac341a7537()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 512f; _h = 676f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(19,348);ctx.lineTo(101,132);ctx.lineTo(214,19);ctx.lineTo(327,19);ctx.lineTo(430,122);ctx.lineTo(512,348);ctx.lineTo(512,511);ctx.lineTo(348,676);ctx.lineTo(183,676);ctx.lineTo(19,511);ctx.lineTo(19,348);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(19,348));listpt.Add(new Point(101,132));listpt.Add(new Point(214,19));listpt.Add(new Point(327,19));listpt.Add(new Point(430,122));listpt.Add(new Point(512,348));listpt.Add(new Point(512,511));listpt.Add(new Point(348,676));listpt.Add(new Point(183,676));listpt.Add(new Point(19,511));listpt.Add(new Point(19,348));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}