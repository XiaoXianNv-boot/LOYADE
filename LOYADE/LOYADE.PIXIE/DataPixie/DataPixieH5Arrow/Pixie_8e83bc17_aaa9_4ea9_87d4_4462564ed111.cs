using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_8e83bc17_aaa9_4ea9_87d4_4462564ed111 : Pixie
    {
        public PIXIE_8e83bc17_aaa9_4ea9_87d4_4462564ed111()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 289f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrFillColor[2] = '#0ff'; arrFillColor[3] = '#0ff'; arrFillColor[4] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(839,289);ctx.lineTo(839,223);ctx.lineTo(650,223);ctx.lineTo(650,94);ctx.lineTo(839,94);ctx.lineTo(839,28);ctx.lineTo(970,161);ctx.lineTo(839,289);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(398,223);ctx.lineTo(398,94);ctx.lineTo(593,94);ctx.lineTo(593,223);ctx.lineTo(398,223);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(208,223);ctx.lineTo(208,94);ctx.lineTo(341,94);ctx.lineTo(341,223);ctx.lineTo(208,223);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(83,223);ctx.lineTo(83,94);ctx.lineTo(151,94);ctx.lineTo(151,223);ctx.lineTo(83,223);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,223);ctx.lineTo(28,94);ctx.lineTo(35,94);ctx.lineTo(35,223);ctx.lineTo(28,223);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(839,289));listpt.Add(new Point(839,223));listpt.Add(new Point(650,223));listpt.Add(new Point(650,94));listpt.Add(new Point(839,94));listpt.Add(new Point(839,28));listpt.Add(new Point(970,161));listpt.Add(new Point(839,289));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(398,223));listpt.Add(new Point(398,94));listpt.Add(new Point(593,94));listpt.Add(new Point(593,223));listpt.Add(new Point(398,223));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(208,223));listpt.Add(new Point(208,94));listpt.Add(new Point(341,94));listpt.Add(new Point(341,223));listpt.Add(new Point(208,223));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(83,223));listpt.Add(new Point(83,94));listpt.Add(new Point(151,94));listpt.Add(new Point(151,223));listpt.Add(new Point(83,223));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,223));listpt.Add(new Point(28,94));listpt.Add(new Point(35,94));listpt.Add(new Point(35,223));listpt.Add(new Point(28,223));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}