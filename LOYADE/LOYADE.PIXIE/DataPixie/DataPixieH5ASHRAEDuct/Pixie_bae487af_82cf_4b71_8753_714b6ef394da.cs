using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEDuct
{
    public class PIXIE_bae487af_82cf_4b71_8753_714b6ef394da : Pixie
    {
        public PIXIE_bae487af_82cf_4b71_8753_714b6ef394da()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 656f; _h = 250f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(342,28);ctx.lineTo(656,28);ctx.lineTo(655,59);ctx.lineTo(650,89);ctx.lineTo(642,119);ctx.lineTo(632,148);ctx.lineTo(619,176);ctx.lineTo(603,202);ctx.lineTo(584,227);ctx.lineTo(564,250);ctx.lineTo(342,28);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(342,28));listpt.Add(new Point(656,28));listpt.Add(new Point(655,59));listpt.Add(new Point(650,89));listpt.Add(new Point(642,119));listpt.Add(new Point(632,148));listpt.Add(new Point(619,176));listpt.Add(new Point(603,202));listpt.Add(new Point(584,227));listpt.Add(new Point(564,250));listpt.Add(new Point(342,28));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}