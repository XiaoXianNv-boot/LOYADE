using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Blower
{
    public class PIXIE_4e1b8113_3e25_4c05_8e29_29355c46fcd4 : Pixie
    {
        public PIXIE_4e1b8113_3e25_4c05_8e29_29355c46fcd4()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#666"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 931f; _h = 931f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#7f7f7f'; arrFillColor[1] = '#666'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(665,901);ctx.lineTo(556,931);ctx.lineTo(442,931);ctx.lineTo(333,901);ctx.lineTo(235,844);ctx.lineTo(154,765);ctx.lineTo(96,665);ctx.lineTo(67,556);ctx.lineTo(67,442);ctx.lineTo(97,331);ctx.lineTo(154,233);ctx.lineTo(233,154);ctx.lineTo(333,96);ctx.lineTo(442,67);ctx.lineTo(556,67);ctx.lineTo(667,96);ctx.lineTo(765,154);ctx.lineTo(844,233);ctx.lineTo(902,331);ctx.lineTo(931,442);ctx.lineTo(931,556);ctx.lineTo(902,665);ctx.lineTo(844,765);ctx.lineTo(765,844);ctx.lineTo(665,901);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(499,499,115,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(665,901));listpt.Add(new Point(556,931));listpt.Add(new Point(442,931));listpt.Add(new Point(333,901));listpt.Add(new Point(235,844));listpt.Add(new Point(154,765));listpt.Add(new Point(96,665));listpt.Add(new Point(67,556));listpt.Add(new Point(67,442));listpt.Add(new Point(97,331));listpt.Add(new Point(154,233));listpt.Add(new Point(233,154));listpt.Add(new Point(333,96));listpt.Add(new Point(442,67));listpt.Add(new Point(556,67));listpt.Add(new Point(667,96));listpt.Add(new Point(765,154));listpt.Add(new Point(844,233));listpt.Add(new Point(902,331));listpt.Add(new Point(931,442));listpt.Add(new Point(931,556));listpt.Add(new Point(902,665));listpt.Add(new Point(844,765));listpt.Add(new Point(765,844));listpt.Add(new Point(665,901));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 384f,384f,230f,230f);g.DrawEllipse(p, 384f,384f,230f,230f);
        }
    }
}