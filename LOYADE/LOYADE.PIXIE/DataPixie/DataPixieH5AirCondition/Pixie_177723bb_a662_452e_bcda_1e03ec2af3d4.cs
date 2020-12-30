using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5AirCondition
{
    public class PIXIE_177723bb_a662_452e_bcda_1e03ec2af3d4 : Pixie
    {
        public PIXIE_177723bb_a662_452e_bcda_1e03ec2af3d4()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 257f; _h = 257f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* circle */ ctx.arc(132,132,125,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(164,12);ctx.lineTo(132,43);ctx.lineTo(100,12);ctx.lineTo(84,17);ctx.lineTo(70,24);ctx.lineTo(56,34);ctx.lineTo(44,44);ctx.lineTo(33,57);ctx.lineTo(24,70);ctx.lineTo(16,85);ctx.lineTo(11,101);ctx.lineTo(42,132);ctx.lineTo(11,164);ctx.lineTo(16,180);ctx.lineTo(24,194);ctx.lineTo(33,208);ctx.lineTo(44,220);ctx.lineTo(56,231);ctx.lineTo(70,240);ctx.lineTo(84,248);ctx.lineTo(100,253);ctx.lineTo(132,222);ctx.lineTo(164,253);ctx.lineTo(180,248);ctx.lineTo(194,240);ctx.lineTo(208,231);ctx.lineTo(220,220);ctx.lineTo(231,208);ctx.lineTo(240,194);ctx.lineTo(247,180);ctx.lineTo(253,164);ctx.lineTo(222,132);ctx.lineTo(253,101);ctx.lineTo(247,85);ctx.lineTo(240,70);ctx.lineTo(231,57);ctx.lineTo(220,44);ctx.lineTo(208,34);ctx.lineTo(194,24);ctx.lineTo(180,17);ctx.lineTo(164,12);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillEllipse(sb, 7f,7f,250f,250f);g.DrawEllipse(p, 7f,7f,250f,250f);
listpt = new List<Point>();listpt.Add(new Point(164,12));listpt.Add(new Point(132,43));listpt.Add(new Point(100,12));listpt.Add(new Point(84,17));listpt.Add(new Point(70,24));listpt.Add(new Point(56,34));listpt.Add(new Point(44,44));listpt.Add(new Point(33,57));listpt.Add(new Point(24,70));listpt.Add(new Point(16,85));listpt.Add(new Point(11,101));listpt.Add(new Point(42,132));listpt.Add(new Point(11,164));listpt.Add(new Point(16,180));listpt.Add(new Point(24,194));listpt.Add(new Point(33,208));listpt.Add(new Point(44,220));listpt.Add(new Point(56,231));listpt.Add(new Point(70,240));listpt.Add(new Point(84,248));listpt.Add(new Point(100,253));listpt.Add(new Point(132,222));listpt.Add(new Point(164,253));listpt.Add(new Point(180,248));listpt.Add(new Point(194,240));listpt.Add(new Point(208,231));listpt.Add(new Point(220,220));listpt.Add(new Point(231,208));listpt.Add(new Point(240,194));listpt.Add(new Point(247,180));listpt.Add(new Point(253,164));listpt.Add(new Point(222,132));listpt.Add(new Point(253,101));listpt.Add(new Point(247,85));listpt.Add(new Point(240,70));listpt.Add(new Point(231,57));listpt.Add(new Point(220,44));listpt.Add(new Point(208,34));listpt.Add(new Point(194,24));listpt.Add(new Point(180,17));listpt.Add(new Point(164,12));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}