using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5AirCondition
{
    public class PIXIE_43617e48_5a2e_4d68_9080_ab5fe6b28113 : Pixie
    {
        public PIXIE_43617e48_5a2e_4d68_9080_ab5fe6b28113()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 249f; _h = 231f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(233,231);ctx.lineTo(7,231);ctx.lineTo(8,214);ctx.lineTo(9,197);ctx.lineTo(12,180);ctx.lineTo(16,164);ctx.lineTo(21,148);ctx.lineTo(27,132);ctx.lineTo(34,117);ctx.lineTo(42,102);ctx.lineTo(51,88);ctx.lineTo(61,74);ctx.lineTo(72,61);ctx.lineTo(83,49);ctx.lineTo(95,37);ctx.lineTo(108,26);ctx.lineTo(122,16);ctx.lineTo(136,7);ctx.lineTo(249,202);ctx.lineTo(242,208);ctx.lineTo(237,215);ctx.lineTo(234,223);ctx.lineTo(233,231);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(233,231));listpt.Add(new Point(7,231));listpt.Add(new Point(8,214));listpt.Add(new Point(9,197));listpt.Add(new Point(12,180));listpt.Add(new Point(16,164));listpt.Add(new Point(21,148));listpt.Add(new Point(27,132));listpt.Add(new Point(34,117));listpt.Add(new Point(42,102));listpt.Add(new Point(51,88));listpt.Add(new Point(61,74));listpt.Add(new Point(72,61));listpt.Add(new Point(83,49));listpt.Add(new Point(95,37));listpt.Add(new Point(108,26));listpt.Add(new Point(122,16));listpt.Add(new Point(136,7));listpt.Add(new Point(249,202));listpt.Add(new Point(242,208));listpt.Add(new Point(237,215));listpt.Add(new Point(234,223));listpt.Add(new Point(233,231));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}