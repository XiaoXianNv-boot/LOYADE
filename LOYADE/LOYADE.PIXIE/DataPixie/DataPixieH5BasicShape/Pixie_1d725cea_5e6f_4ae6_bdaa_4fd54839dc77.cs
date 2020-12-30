using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_1d725cea_5e6f_4ae6_bdaa_4fd54839dc77 : Pixie
    {
        public PIXIE_1d725cea_5e6f_4ae6_bdaa_4fd54839dc77()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 650f; _h = 580f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(18,356);ctx.lineTo(152,131);ctx.lineTo(264,18);ctx.lineTo(517,18);ctx.lineTo(650,243);ctx.lineTo(517,468);ctx.lineTo(405,580);ctx.lineTo(152,580);ctx.lineTo(18,356);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(18,356));listpt.Add(new Point(152,131));listpt.Add(new Point(264,18));listpt.Add(new Point(517,18));listpt.Add(new Point(650,243));listpt.Add(new Point(517,468));listpt.Add(new Point(405,580));listpt.Add(new Point(152,580));listpt.Add(new Point(18,356));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}