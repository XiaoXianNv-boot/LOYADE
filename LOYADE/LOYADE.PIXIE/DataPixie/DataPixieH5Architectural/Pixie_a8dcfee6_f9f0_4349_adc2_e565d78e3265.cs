using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Architectural
{
    public class PIXIE_a8dcfee6_f9f0_4349_adc2_e565d78e3265 : Pixie
    {
        public PIXIE_a8dcfee6_f9f0_4349_adc2_e565d78e3265()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#854002"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ababab"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 610f; _h = 914f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#854002'; arrFillColor[1] = '#ababab'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(39,142);ctx.lineTo(48,134);ctx.lineTo(85,116);ctx.lineTo(125,110);ctx.lineTo(154,104);ctx.lineTo(178,100);ctx.lineTo(206,94);ctx.lineTo(238,68);ctx.lineTo(266,44);ctx.lineTo(282,32);ctx.lineTo(312,28);ctx.lineTo(351,32);ctx.lineTo(358,32);ctx.lineTo(374,44);ctx.lineTo(402,68);ctx.lineTo(437,94);ctx.lineTo(460,100);ctx.lineTo(488,104);ctx.lineTo(515,110);ctx.lineTo(554,116);ctx.lineTo(591,134);ctx.lineTo(603,142);ctx.lineTo(610,154);ctx.lineTo(610,167);ctx.lineTo(28,167);ctx.lineTo(39,142);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(261,134);ctx.lineTo(360,134);ctx.lineTo(360,914);ctx.lineTo(261,914);ctx.lineTo(261,134);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(39,142));listpt.Add(new Point(48,134));listpt.Add(new Point(85,116));listpt.Add(new Point(125,110));listpt.Add(new Point(154,104));listpt.Add(new Point(178,100));listpt.Add(new Point(206,94));listpt.Add(new Point(238,68));listpt.Add(new Point(266,44));listpt.Add(new Point(282,32));listpt.Add(new Point(312,28));listpt.Add(new Point(351,32));listpt.Add(new Point(358,32));listpt.Add(new Point(374,44));listpt.Add(new Point(402,68));listpt.Add(new Point(437,94));listpt.Add(new Point(460,100));listpt.Add(new Point(488,104));listpt.Add(new Point(515,110));listpt.Add(new Point(554,116));listpt.Add(new Point(591,134));listpt.Add(new Point(603,142));listpt.Add(new Point(610,154));listpt.Add(new Point(610,167));listpt.Add(new Point(28,167));listpt.Add(new Point(39,142));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(261,134));listpt.Add(new Point(360,134));listpt.Add(new Point(360,914));listpt.Add(new Point(261,914));listpt.Add(new Point(261,134));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}