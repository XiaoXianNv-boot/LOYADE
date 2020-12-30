using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Switch
{
    public class PIXIE_3e09a5fa_4e76_42b6_8918_b81df04cc725 : Pixie
    {
        public PIXIE_3e09a5fa_4e76_42b6_8918_b81df04cc725()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 970f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#000'; arrFillColor[1] = '#e5e5e5'; arrFillColor[2] = '#000'; arrFillColor[3] = '#4c4c4c'; arrFillColor[4] = '#e5e5e5'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#7f7f7f'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(29,969);ctx.lineTo(29,29);ctx.lineTo(968,29);ctx.lineTo(968,969);ctx.lineTo(29,969);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(499,499,471,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(499,499,403,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(593,880);ctx.lineTo(608,871);ctx.lineTo(612,852);ctx.lineTo(593,618);ctx.lineTo(593,380);ctx.lineTo(612,145);ctx.lineTo(608,128);ctx.lineTo(591,116);ctx.lineTo(499,105);ctx.lineTo(405,116);ctx.lineTo(390,128);ctx.lineTo(386,145);ctx.lineTo(405,380);ctx.lineTo(405,618);ctx.lineTo(386,852);ctx.lineTo(390,871);ctx.lineTo(405,882);ctx.lineTo(499,893);ctx.lineTo(593,880);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(538,305);ctx.lineTo(538,137);ctx.lineTo(459,137);ctx.lineTo(459,305);ctx.lineTo(461,315);ctx.lineTo(463,320);ctx.lineTo(463,320);ctx.lineTo(464,323);ctx.lineTo(467,328);ctx.lineTo(474,335);ctx.lineTo(482,339);ctx.lineTo(491,342);ctx.lineTo(493,342);ctx.lineTo(493,343);ctx.lineTo(494,343);ctx.lineTo(504,342);ctx.lineTo(513,339);ctx.lineTo(519,338);ctx.lineTo(525,331);ctx.lineTo(532,325);ctx.lineTo(536,317);ctx.lineTo(538,310);ctx.lineTo(538,309);ctx.lineTo(538,308);ctx.lineTo(538,305);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(29,969));listpt.Add(new Point(29,29));listpt.Add(new Point(968,29));listpt.Add(new Point(968,969));listpt.Add(new Point(29,969));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 28f,28f,942f,942f);g.DrawEllipse(p, 28f,28f,942f,942f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillEllipse(sb, 96f,96f,806f,806f);g.DrawEllipse(p, 96f,96f,806f,806f);
listpt = new List<Point>();listpt.Add(new Point(593,880));listpt.Add(new Point(608,871));listpt.Add(new Point(612,852));listpt.Add(new Point(593,618));listpt.Add(new Point(593,380));listpt.Add(new Point(612,145));listpt.Add(new Point(608,128));listpt.Add(new Point(591,116));listpt.Add(new Point(499,105));listpt.Add(new Point(405,116));listpt.Add(new Point(390,128));listpt.Add(new Point(386,145));listpt.Add(new Point(405,380));listpt.Add(new Point(405,618));listpt.Add(new Point(386,852));listpt.Add(new Point(390,871));listpt.Add(new Point(405,882));listpt.Add(new Point(499,893));listpt.Add(new Point(593,880));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(538,305));listpt.Add(new Point(538,137));listpt.Add(new Point(459,137));listpt.Add(new Point(459,305));listpt.Add(new Point(461,315));listpt.Add(new Point(463,320));listpt.Add(new Point(463,320));listpt.Add(new Point(464,323));listpt.Add(new Point(467,328));listpt.Add(new Point(474,335));listpt.Add(new Point(482,339));listpt.Add(new Point(491,342));listpt.Add(new Point(493,342));listpt.Add(new Point(493,343));listpt.Add(new Point(494,343));listpt.Add(new Point(504,342));listpt.Add(new Point(513,339));listpt.Add(new Point(519,338));listpt.Add(new Point(525,331));listpt.Add(new Point(532,325));listpt.Add(new Point(536,317));listpt.Add(new Point(538,310));listpt.Add(new Point(538,309));listpt.Add(new Point(538,308));listpt.Add(new Point(538,305));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}