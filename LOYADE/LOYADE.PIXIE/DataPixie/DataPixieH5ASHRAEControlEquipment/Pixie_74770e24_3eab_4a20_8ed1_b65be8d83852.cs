using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEControlEquipment
{
    public class PIXIE_74770e24_3eab_4a20_8ed1_b65be8d83852 : Pixie
    {
        public PIXIE_74770e24_3eab_4a20_8ed1_b65be8d83852()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 578f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,578);ctx.lineTo(62,401);ctx.lineTo(163,241);ctx.lineTo(244,185);ctx.lineTo(244,28);ctx.lineTo(755,28);ctx.lineTo(754,185);ctx.lineTo(835,241);ctx.lineTo(937,401);ctx.lineTo(970,578);ctx.lineTo(28,578);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,578));listpt.Add(new Point(62,401));listpt.Add(new Point(163,241));listpt.Add(new Point(244,185));listpt.Add(new Point(244,28));listpt.Add(new Point(755,28));listpt.Add(new Point(754,185));listpt.Add(new Point(835,241));listpt.Add(new Point(937,401));listpt.Add(new Point(970,578));listpt.Add(new Point(28,578));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}