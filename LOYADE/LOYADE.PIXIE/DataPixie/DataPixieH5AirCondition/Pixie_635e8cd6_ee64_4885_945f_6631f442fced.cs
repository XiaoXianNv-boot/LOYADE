using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5AirCondition
{
    public class PIXIE_635e8cd6_ee64_4885_945f_6631f442fced : Pixie
    {
        public PIXIE_635e8cd6_ee64_4885_945f_6631f442fced()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 242f; _h = 257f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrFillColor[2] = '#0ff'; arrFillColor[3] = '#0ff'; arrFillColor[4] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(7,7);ctx.lineTo(164,7);ctx.lineTo(164,135);ctx.lineTo(7,135);ctx.lineTo(7,7);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(7,135);ctx.lineTo(164,135);ctx.lineTo(164,164);ctx.lineTo(7,164);ctx.lineTo(7,135);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(164,164);ctx.lineTo(242,164);ctx.lineTo(242,7);ctx.lineTo(164,7);ctx.lineTo(164,164);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(95,213,44,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(124,181);ctx.lineTo(118,178);ctx.lineTo(112,175);ctx.lineTo(106,174);ctx.lineTo(100,173);ctx.lineTo(91,174);ctx.lineTo(83,176);ctx.lineTo(76,181);ctx.lineTo(69,186);ctx.lineTo(64,193);ctx.lineTo(60,200);ctx.lineTo(57,208);ctx.lineTo(56,217);ctx.lineTo(56,223);ctx.lineTo(57,229);ctx.lineTo(59,236);ctx.lineTo(63,243);ctx.lineTo(60,240);ctx.lineTo(58,237);ctx.lineTo(56,234);ctx.lineTo(54,230);ctx.lineTo(53,226);ctx.lineTo(52,222);ctx.lineTo(51,217);ctx.lineTo(51,213);ctx.lineTo(52,204);ctx.lineTo(54,196);ctx.lineTo(59,189);ctx.lineTo(64,182);ctx.lineTo(70,177);ctx.lineTo(78,172);ctx.lineTo(86,170);ctx.lineTo(94,169);ctx.lineTo(98,169);ctx.lineTo(103,170);ctx.lineTo(107,171);ctx.lineTo(111,173);ctx.lineTo(115,175);ctx.lineTo(118,177);ctx.lineTo(121,179);ctx.lineTo(124,181);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(7,7));listpt.Add(new Point(164,7));listpt.Add(new Point(164,135));listpt.Add(new Point(7,135));listpt.Add(new Point(7,7));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(7,135));listpt.Add(new Point(164,135));listpt.Add(new Point(164,164));listpt.Add(new Point(7,164));listpt.Add(new Point(7,135));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(164,164));listpt.Add(new Point(242,164));listpt.Add(new Point(242,7));listpt.Add(new Point(164,7));listpt.Add(new Point(164,164));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillEllipse(sb, 51f,169f,88f,88f);g.DrawEllipse(p, 51f,169f,88f,88f);
listpt = new List<Point>();listpt.Add(new Point(124,181));listpt.Add(new Point(118,178));listpt.Add(new Point(112,175));listpt.Add(new Point(106,174));listpt.Add(new Point(100,173));listpt.Add(new Point(91,174));listpt.Add(new Point(83,176));listpt.Add(new Point(76,181));listpt.Add(new Point(69,186));listpt.Add(new Point(64,193));listpt.Add(new Point(60,200));listpt.Add(new Point(57,208));listpt.Add(new Point(56,217));listpt.Add(new Point(56,223));listpt.Add(new Point(57,229));listpt.Add(new Point(59,236));listpt.Add(new Point(63,243));listpt.Add(new Point(60,240));listpt.Add(new Point(58,237));listpt.Add(new Point(56,234));listpt.Add(new Point(54,230));listpt.Add(new Point(53,226));listpt.Add(new Point(52,222));listpt.Add(new Point(51,217));listpt.Add(new Point(51,213));listpt.Add(new Point(52,204));listpt.Add(new Point(54,196));listpt.Add(new Point(59,189));listpt.Add(new Point(64,182));listpt.Add(new Point(70,177));listpt.Add(new Point(78,172));listpt.Add(new Point(86,170));listpt.Add(new Point(94,169));listpt.Add(new Point(98,169));listpt.Add(new Point(103,170));listpt.Add(new Point(107,171));listpt.Add(new Point(111,173));listpt.Add(new Point(115,175));listpt.Add(new Point(118,177));listpt.Add(new Point(121,179));listpt.Add(new Point(124,181));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}