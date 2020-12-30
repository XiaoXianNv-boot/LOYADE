using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorSimple
{
    public class PIXIE_4e129070_9665_42b2_96d9_91e39e8756e5 : Pixie
    {
        public PIXIE_4e129070_9665_42b2_96d9_91e39e8756e5()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 765f; _h = 971f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(519,479);ctx.lineTo(571,435);ctx.lineTo(633,402);ctx.lineTo(697,383);ctx.lineTo(765,376);ctx.lineTo(765,27);ctx.lineTo(628,43);ctx.lineTo(500,82);ctx.lineTo(378,146);ctx.lineTo(273,233);ctx.lineTo(28,478);ctx.lineTo(27,971);ctx.lineTo(519,479);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(519,479));listpt.Add(new Point(571,435));listpt.Add(new Point(633,402));listpt.Add(new Point(697,383));listpt.Add(new Point(765,376));listpt.Add(new Point(765,27));listpt.Add(new Point(628,43));listpt.Add(new Point(500,82));listpt.Add(new Point(378,146));listpt.Add(new Point(273,233));listpt.Add(new Point(28,478));listpt.Add(new Point(27,971));listpt.Add(new Point(519,479));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}