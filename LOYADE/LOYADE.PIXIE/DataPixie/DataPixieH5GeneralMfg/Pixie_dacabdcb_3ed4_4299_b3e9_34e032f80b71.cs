using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_dacabdcb_3ed4_4299_b3e9_34e032f80b71 : Pixie
    {
        public PIXIE_dacabdcb_3ed4_4299_b3e9_34e032f80b71()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 163f; _h = 257f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrFillColor[2] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(54,183);ctx.lineTo(54,188);ctx.lineTo(54,226);ctx.lineTo(55,232);ctx.lineTo(57,237);ctx.lineTo(60,242);ctx.lineTo(64,247);ctx.lineTo(69,251);ctx.lineTo(74,254);ctx.lineTo(79,256);ctx.lineTo(85,257);ctx.lineTo(163,257);ctx.lineTo(163,226);ctx.lineTo(101,226);ctx.lineTo(95,225);ctx.lineTo(90,221);ctx.lineTo(86,216);ctx.lineTo(85,210);ctx.lineTo(85,183);ctx.lineTo(54,183);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(7,54);ctx.lineTo(7,148);ctx.lineTo(23,179);ctx.lineTo(116,179);ctx.lineTo(132,148);ctx.lineTo(132,54);ctx.lineTo(7,54);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(69,116,19,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(54,183));listpt.Add(new Point(54,188));listpt.Add(new Point(54,226));listpt.Add(new Point(55,232));listpt.Add(new Point(57,237));listpt.Add(new Point(60,242));listpt.Add(new Point(64,247));listpt.Add(new Point(69,251));listpt.Add(new Point(74,254));listpt.Add(new Point(79,256));listpt.Add(new Point(85,257));listpt.Add(new Point(163,257));listpt.Add(new Point(163,226));listpt.Add(new Point(101,226));listpt.Add(new Point(95,225));listpt.Add(new Point(90,221));listpt.Add(new Point(86,216));listpt.Add(new Point(85,210));listpt.Add(new Point(85,183));listpt.Add(new Point(54,183));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(7,54));listpt.Add(new Point(7,148));listpt.Add(new Point(23,179));listpt.Add(new Point(116,179));listpt.Add(new Point(132,148));listpt.Add(new Point(132,54));listpt.Add(new Point(7,54));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillEllipse(sb, 50f,97f,38f,38f);g.DrawEllipse(p, 50f,97f,38f,38f);
        }
    }
}