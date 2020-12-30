using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Switch
{
    public class PIXIE_9495a371_f259_46ca_afda_303dedecbcd9 : Pixie
    {
        public PIXIE_9495a371_f259_46ca_afda_303dedecbcd9()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 970f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#000'; arrFillColor[1] = '#e5e5e5'; arrFillColor[2] = '#000'; arrFillColor[3] = '#4c4c4c'; arrFillColor[4] = '#e5e5e5'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#7f7f7f'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(30,968);ctx.lineTo(30,30);ctx.lineTo(968,30);ctx.lineTo(968,968);ctx.lineTo(30,968);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(499,499,471,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(499,499,403,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(880,405);ctx.lineTo(870,390);ctx.lineTo(851,386);ctx.lineTo(618,405);ctx.lineTo(380,405);ctx.lineTo(145,386);ctx.lineTo(128,390);ctx.lineTo(116,407);ctx.lineTo(105,499);ctx.lineTo(116,593);ctx.lineTo(128,608);ctx.lineTo(145,612);ctx.lineTo(380,593);ctx.lineTo(618,593);ctx.lineTo(851,612);ctx.lineTo(870,608);ctx.lineTo(882,593);ctx.lineTo(893,499);ctx.lineTo(880,405);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(305,459);ctx.lineTo(137,459);ctx.lineTo(137,539);ctx.lineTo(305,539);ctx.lineTo(315,537);ctx.lineTo(320,535);ctx.lineTo(320,535);ctx.lineTo(327,531);ctx.lineTo(335,524);ctx.lineTo(339,516);ctx.lineTo(342,507);ctx.lineTo(342,505);ctx.lineTo(343,505);ctx.lineTo(343,504);ctx.lineTo(342,494);ctx.lineTo(339,485);ctx.lineTo(337,477);ctx.lineTo(329,470);ctx.lineTo(322,464);ctx.lineTo(313,461);ctx.lineTo(310,460);ctx.lineTo(309,459);ctx.lineTo(308,459);ctx.lineTo(305,459);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(30,968));listpt.Add(new Point(30,30));listpt.Add(new Point(968,30));listpt.Add(new Point(968,968));listpt.Add(new Point(30,968));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 28f,28f,942f,942f);g.DrawEllipse(p, 28f,28f,942f,942f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillEllipse(sb, 96f,96f,806f,806f);g.DrawEllipse(p, 96f,96f,806f,806f);
listpt = new List<Point>();listpt.Add(new Point(880,405));listpt.Add(new Point(870,390));listpt.Add(new Point(851,386));listpt.Add(new Point(618,405));listpt.Add(new Point(380,405));listpt.Add(new Point(145,386));listpt.Add(new Point(128,390));listpt.Add(new Point(116,407));listpt.Add(new Point(105,499));listpt.Add(new Point(116,593));listpt.Add(new Point(128,608));listpt.Add(new Point(145,612));listpt.Add(new Point(380,593));listpt.Add(new Point(618,593));listpt.Add(new Point(851,612));listpt.Add(new Point(870,608));listpt.Add(new Point(882,593));listpt.Add(new Point(893,499));listpt.Add(new Point(880,405));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(305,459));listpt.Add(new Point(137,459));listpt.Add(new Point(137,539));listpt.Add(new Point(305,539));listpt.Add(new Point(315,537));listpt.Add(new Point(320,535));listpt.Add(new Point(320,535));listpt.Add(new Point(327,531));listpt.Add(new Point(335,524));listpt.Add(new Point(339,516));listpt.Add(new Point(342,507));listpt.Add(new Point(342,505));listpt.Add(new Point(343,505));listpt.Add(new Point(343,504));listpt.Add(new Point(342,494));listpt.Add(new Point(339,485));listpt.Add(new Point(337,477));listpt.Add(new Point(329,470));listpt.Add(new Point(322,464));listpt.Add(new Point(313,461));listpt.Add(new Point(310,460));listpt.Add(new Point(309,459));listpt.Add(new Point(308,459));listpt.Add(new Point(305,459));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}