using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_ed542139_6071_46c2_96e9_f995c53bb0df : Pixie
    {
        public PIXIE_ed542139_6071_46c2_96e9_f995c53bb0df()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 965f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(303,125);ctx.lineTo(970,28);ctx.lineTo(871,695);ctx.lineTo(768,592);ctx.lineTo(816,267);ctx.lineTo(120,965);ctx.lineTo(28,872);ctx.lineTo(726,176);ctx.lineTo(400,224);ctx.lineTo(303,125);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(303,125));listpt.Add(new Point(970,28));listpt.Add(new Point(871,695));listpt.Add(new Point(768,592));listpt.Add(new Point(816,267));listpt.Add(new Point(120,965));listpt.Add(new Point(28,872));listpt.Add(new Point(726,176));listpt.Add(new Point(400,224));listpt.Add(new Point(303,125));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}