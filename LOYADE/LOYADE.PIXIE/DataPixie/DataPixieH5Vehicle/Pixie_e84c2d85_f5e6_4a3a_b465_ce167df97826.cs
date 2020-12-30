using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Vehicle
{
    public class PIXIE_e84c2d85_f5e6_4a3a_b465_ce167df97826 : Pixie
    {
        public PIXIE_e84c2d85_f5e6_4a3a_b465_ce167df97826()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#333"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#c90"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 948f; _h = 948f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#333'; arrFillColor[1] = '#c90'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(672,918);ctx.lineTo(557,948);ctx.lineTo(441,948);ctx.lineTo(326,918);ctx.lineTo(224,859);ctx.lineTo(139,774);ctx.lineTo(80,672);ctx.lineTo(50,557);ctx.lineTo(50,441);ctx.lineTo(80,326);ctx.lineTo(139,224);ctx.lineTo(224,139);ctx.lineTo(326,80);ctx.lineTo(441,50);ctx.lineTo(557,50);ctx.lineTo(672,80);ctx.lineTo(776,139);ctx.lineTo(859,224);ctx.lineTo(918,326);ctx.lineTo(948,441);ctx.lineTo(948,557);ctx.lineTo(918,672);ctx.lineTo(859,774);ctx.lineTo(774,859);ctx.lineTo(672,918);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(557,638);ctx.lineTo(518,648);ctx.lineTo(480,648);ctx.lineTo(441,638);ctx.lineTo(407,620);ctx.lineTo(378,591);ctx.lineTo(360,557);ctx.lineTo(350,518);ctx.lineTo(350,480);ctx.lineTo(360,441);ctx.lineTo(380,407);ctx.lineTo(407,378);ctx.lineTo(441,360);ctx.lineTo(480,350);ctx.lineTo(518,350);ctx.lineTo(557,360);ctx.lineTo(591,378);ctx.lineTo(618,407);ctx.lineTo(638,441);ctx.lineTo(648,480);ctx.lineTo(648,518);ctx.lineTo(638,557);ctx.lineTo(620,591);ctx.lineTo(591,620);ctx.lineTo(557,638);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(672,918));listpt.Add(new Point(557,948));listpt.Add(new Point(441,948));listpt.Add(new Point(326,918));listpt.Add(new Point(224,859));listpt.Add(new Point(139,774));listpt.Add(new Point(80,672));listpt.Add(new Point(50,557));listpt.Add(new Point(50,441));listpt.Add(new Point(80,326));listpt.Add(new Point(139,224));listpt.Add(new Point(224,139));listpt.Add(new Point(326,80));listpt.Add(new Point(441,50));listpt.Add(new Point(557,50));listpt.Add(new Point(672,80));listpt.Add(new Point(776,139));listpt.Add(new Point(859,224));listpt.Add(new Point(918,326));listpt.Add(new Point(948,441));listpt.Add(new Point(948,557));listpt.Add(new Point(918,672));listpt.Add(new Point(859,774));listpt.Add(new Point(774,859));listpt.Add(new Point(672,918));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(557,638));listpt.Add(new Point(518,648));listpt.Add(new Point(480,648));listpt.Add(new Point(441,638));listpt.Add(new Point(407,620));listpt.Add(new Point(378,591));listpt.Add(new Point(360,557));listpt.Add(new Point(350,518));listpt.Add(new Point(350,480));listpt.Add(new Point(360,441));listpt.Add(new Point(380,407));listpt.Add(new Point(407,378));listpt.Add(new Point(441,360));listpt.Add(new Point(480,350));listpt.Add(new Point(518,350));listpt.Add(new Point(557,360));listpt.Add(new Point(591,378));listpt.Add(new Point(618,407));listpt.Add(new Point(638,441));listpt.Add(new Point(648,480));listpt.Add(new Point(648,518));listpt.Add(new Point(638,557));listpt.Add(new Point(620,591));listpt.Add(new Point(591,620));listpt.Add(new Point(557,638));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}