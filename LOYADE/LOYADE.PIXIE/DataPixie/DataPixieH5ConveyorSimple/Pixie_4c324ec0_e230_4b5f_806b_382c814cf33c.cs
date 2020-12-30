using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorSimple
{
    public class PIXIE_4c324ec0_e230_4b5f_806b_382c814cf33c : Pixie
    {
        public PIXIE_4c324ec0_e230_4b5f_806b_382c814cf33c()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 765f; _h = 971f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(273,479);ctx.lineTo(221,435);ctx.lineTo(160,402);ctx.lineTo(96,383);ctx.lineTo(27,376);ctx.lineTo(27,27);ctx.lineTo(165,43);ctx.lineTo(293,82);ctx.lineTo(415,146);ctx.lineTo(519,233);ctx.lineTo(765,478);ctx.lineTo(765,971);ctx.lineTo(273,479);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(273,479));listpt.Add(new Point(221,435));listpt.Add(new Point(160,402));listpt.Add(new Point(96,383));listpt.Add(new Point(27,376));listpt.Add(new Point(27,27));listpt.Add(new Point(165,43));listpt.Add(new Point(293,82));listpt.Add(new Point(415,146));listpt.Add(new Point(519,233));listpt.Add(new Point(765,478));listpt.Add(new Point(765,971));listpt.Add(new Point(273,479));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}