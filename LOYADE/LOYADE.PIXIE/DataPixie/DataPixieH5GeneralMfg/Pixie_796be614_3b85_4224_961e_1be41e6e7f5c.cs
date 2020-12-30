using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_796be614_3b85_4224_961e_1be41e6e7f5c : Pixie
    {
        public PIXIE_796be614_3b85_4224_961e_1be41e6e7f5c()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#161717"));
_w = 386f; _h = 260f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#161717'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(81,50);ctx.lineTo(97,50);ctx.lineTo(81,11);ctx.lineTo(42,11);ctx.lineTo(42,104);ctx.lineTo(11,104);ctx.lineTo(11,167);ctx.lineTo(42,167);ctx.lineTo(42,260);ctx.lineTo(354,260);ctx.lineTo(354,167);ctx.lineTo(386,167);ctx.lineTo(386,104);ctx.lineTo(354,104);ctx.lineTo(354,11);ctx.lineTo(214,11);ctx.lineTo(198,50);ctx.lineTo(315,50);ctx.lineTo(315,120);ctx.lineTo(284,167);ctx.lineTo(284,214);ctx.lineTo(167,214);ctx.lineTo(144,167);ctx.lineTo(81,167);ctx.lineTo(81,50);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(81,50));listpt.Add(new Point(97,50));listpt.Add(new Point(81,11));listpt.Add(new Point(42,11));listpt.Add(new Point(42,104));listpt.Add(new Point(11,104));listpt.Add(new Point(11,167));listpt.Add(new Point(42,167));listpt.Add(new Point(42,260));listpt.Add(new Point(354,260));listpt.Add(new Point(354,167));listpt.Add(new Point(386,167));listpt.Add(new Point(386,104));listpt.Add(new Point(354,104));listpt.Add(new Point(354,11));listpt.Add(new Point(214,11));listpt.Add(new Point(198,50));listpt.Add(new Point(315,50));listpt.Add(new Point(315,120));listpt.Add(new Point(284,167));listpt.Add(new Point(284,214));listpt.Add(new Point(167,214));listpt.Add(new Point(144,167));listpt.Add(new Point(81,167));listpt.Add(new Point(81,50));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}