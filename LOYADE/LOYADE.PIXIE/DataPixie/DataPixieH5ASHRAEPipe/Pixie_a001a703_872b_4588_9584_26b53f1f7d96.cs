using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEPipe
{
    public class PIXIE_a001a703_872b_4588_9584_26b53f1f7d96 : Pixie
    {
        public PIXIE_a001a703_872b_4588_9584_26b53f1f7d96()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 813f; _h = 381f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(185,28);ctx.lineTo(185,106);ctx.lineTo(460,106);ctx.lineTo(460,381);ctx.lineTo(538,381);ctx.lineTo(538,106);ctx.lineTo(813,106);ctx.lineTo(813,28);ctx.lineTo(185,28);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(185,28));listpt.Add(new Point(185,106));listpt.Add(new Point(460,106));listpt.Add(new Point(460,381));listpt.Add(new Point(538,381));listpt.Add(new Point(538,106));listpt.Add(new Point(813,106));listpt.Add(new Point(813,28));listpt.Add(new Point(185,28));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}