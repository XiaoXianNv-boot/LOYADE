using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5WireCable
{
    public class PIXIE_5461147d_a393_4e61_ba66_2b827313e8d2 : Pixie
    {
        public PIXIE_5461147d_a393_4e61_ba66_2b827313e8d2()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 969f; _h = 970f;
_content = "var arrFillColor = new Array(7); var arrBorderColor = new Array(8); var arrBorderWidth = new Array(8); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrFillColor[2] = '#0ff'; arrFillColor[3] = '#0ff'; arrFillColor[4] = '#0ff'; arrFillColor[5] = '#0ff'; arrFillColor[6] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderColor[6] = '#000'; arrBorderColor[7] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; arrBorderWidth[6] = '2'; arrBorderWidth[7] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(99,528);ctx.lineTo(107,508);ctx.lineTo(128,499);ctx.lineTo(148,508);ctx.lineTo(157,528);ctx.lineTo(148,549);ctx.lineTo(128,557);ctx.lineTo(107,549);ctx.lineTo(99,528);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(593,970);ctx.lineTo(593,522);ctx.lineTo(169,522);ctx.lineTo(28,664);ctx.lineTo(28,970);ctx.lineTo(593,970);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(593,605);ctx.lineTo(876,605);ctx.lineTo(876,381);ctx.lineTo(593,381);ctx.lineTo(593,405);ctx.lineTo(476,405);ctx.lineTo(476,287);ctx.lineTo(593,287);ctx.lineTo(593,311);ctx.lineTo(947,311);ctx.lineTo(947,675);ctx.lineTo(593,675);ctx.lineTo(593,605);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(534,345,58,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(687,28);ctx.lineTo(782,28);ctx.lineTo(782,970);ctx.lineTo(687,970);ctx.lineTo(687,28);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(911,569,58,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(734,169,82,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[6];ctx.strokeStyle = arrBorderColor[6];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(734,828,82,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[6];ctx.fill();ctx.lineWidth = arrBorderWidth[7];ctx.strokeStyle = arrBorderColor[7];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(99,528));listpt.Add(new Point(107,508));listpt.Add(new Point(128,499));listpt.Add(new Point(148,508));listpt.Add(new Point(157,528));listpt.Add(new Point(148,549));listpt.Add(new Point(128,557));listpt.Add(new Point(107,549));listpt.Add(new Point(99,528));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(593,970));listpt.Add(new Point(593,522));listpt.Add(new Point(169,522));listpt.Add(new Point(28,664));listpt.Add(new Point(28,970));listpt.Add(new Point(593,970));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(593,605));listpt.Add(new Point(876,605));listpt.Add(new Point(876,381));listpt.Add(new Point(593,381));listpt.Add(new Point(593,405));listpt.Add(new Point(476,405));listpt.Add(new Point(476,287));listpt.Add(new Point(593,287));listpt.Add(new Point(593,311));listpt.Add(new Point(947,311));listpt.Add(new Point(947,675));listpt.Add(new Point(593,675));listpt.Add(new Point(593,605));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.DrawEllipse(p, 476f,287f,116f,116f);
listpt = new List<Point>();listpt.Add(new Point(687,28));listpt.Add(new Point(782,28));listpt.Add(new Point(782,970));listpt.Add(new Point(687,970));listpt.Add(new Point(687,28));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillEllipse(sb, 853f,511f,116f,116f);g.DrawEllipse(p, 853f,511f,116f,116f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[6];p.Color = _listbordercolor[6];g.FillEllipse(sb, 652f,87f,164f,164f);g.DrawEllipse(p, 652f,87f,164f,164f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[6]);p = new Pen(Color.Black);p.Width = _listborderwidth[7];p.Color = _listbordercolor[7];g.FillEllipse(sb, 652f,746f,164f,164f);g.DrawEllipse(p, 652f,746f,164f,164f);
        }
    }
}