using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5AirCondition
{
    public class PIXIE_99590bed_6a5c_4675_9b8d_15513390db64 : Pixie
    {
        public PIXIE_99590bed_6a5c_4675_9b8d_15513390db64()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 234f; _h = 135f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(232,135);ctx.lineTo(6,135);ctx.lineTo(7,118);ctx.lineTo(8,102);ctx.lineTo(11,85);ctx.lineTo(15,69);ctx.lineTo(20,52);ctx.lineTo(26,36);ctx.lineTo(33,21);ctx.lineTo(40,6);ctx.lineTo(234,119);ctx.lineTo(234,123);ctx.lineTo(233,127);ctx.lineTo(232,131);ctx.lineTo(232,135);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(232,135));listpt.Add(new Point(6,135));listpt.Add(new Point(7,118));listpt.Add(new Point(8,102));listpt.Add(new Point(11,85));listpt.Add(new Point(15,69));listpt.Add(new Point(20,52));listpt.Add(new Point(26,36));listpt.Add(new Point(33,21));listpt.Add(new Point(40,6));listpt.Add(new Point(234,119));listpt.Add(new Point(234,123));listpt.Add(new Point(233,127));listpt.Add(new Point(232,131));listpt.Add(new Point(232,135));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}