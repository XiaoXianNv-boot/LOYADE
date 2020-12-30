using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Switch
{
    public class PIXIE_57febeba_5f49_4822_abde_3fc6bc344887 : Pixie
    {
        public PIXIE_57febeba_5f49_4822_abde_3fc6bc344887()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 971f; _h = 971f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#7f7f7f'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(499,27);ctx.lineTo(597,40);ctx.lineTo(689,70);ctx.lineTo(768,113);ctx.lineTo(842,174);ctx.lineTo(891,248);ctx.lineTo(940,327);ctx.lineTo(964,413);ctx.lineTo(971,499);ctx.lineTo(964,597);ctx.lineTo(940,689);ctx.lineTo(891,768);ctx.lineTo(842,836);ctx.lineTo(768,891);ctx.lineTo(689,940);ctx.lineTo(597,964);ctx.lineTo(499,971);ctx.lineTo(413,964);ctx.lineTo(322,940);ctx.lineTo(248,891);ctx.lineTo(174,836);ctx.lineTo(113,768);ctx.lineTo(70,689);ctx.lineTo(40,597);ctx.lineTo(27,499);ctx.lineTo(40,413);ctx.lineTo(70,327);ctx.lineTo(113,248);ctx.lineTo(174,174);ctx.lineTo(248,113);ctx.lineTo(322,70);ctx.lineTo(413,40);ctx.lineTo(499,27);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(499,27));listpt.Add(new Point(597,40));listpt.Add(new Point(689,70));listpt.Add(new Point(768,113));listpt.Add(new Point(842,174));listpt.Add(new Point(891,248));listpt.Add(new Point(940,327));listpt.Add(new Point(964,413));listpt.Add(new Point(971,499));listpt.Add(new Point(964,597));listpt.Add(new Point(940,689));listpt.Add(new Point(891,768));listpt.Add(new Point(842,836));listpt.Add(new Point(768,891));listpt.Add(new Point(689,940));listpt.Add(new Point(597,964));listpt.Add(new Point(499,971));listpt.Add(new Point(413,964));listpt.Add(new Point(322,940));listpt.Add(new Point(248,891));listpt.Add(new Point(174,836));listpt.Add(new Point(113,768));listpt.Add(new Point(70,689));listpt.Add(new Point(40,597));listpt.Add(new Point(27,499));listpt.Add(new Point(40,413));listpt.Add(new Point(70,327));listpt.Add(new Point(113,248));listpt.Add(new Point(174,174));listpt.Add(new Point(248,113));listpt.Add(new Point(322,70));listpt.Add(new Point(413,40));listpt.Add(new Point(499,27));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}