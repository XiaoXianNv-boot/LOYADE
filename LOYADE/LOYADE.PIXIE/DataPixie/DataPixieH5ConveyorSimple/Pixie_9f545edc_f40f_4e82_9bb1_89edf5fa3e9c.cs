using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorSimple
{
    public class PIXIE_9f545edc_f40f_4e82_9bb1_89edf5fa3e9c : Pixie
    {
        public PIXIE_9f545edc_f40f_4e82_9bb1_89edf5fa3e9c()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 971f; _h = 765f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(479,519);ctx.lineTo(435,571);ctx.lineTo(402,633);ctx.lineTo(383,697);ctx.lineTo(376,765);ctx.lineTo(27,765);ctx.lineTo(43,628);ctx.lineTo(82,500);ctx.lineTo(146,378);ctx.lineTo(233,273);ctx.lineTo(478,28);ctx.lineTo(971,27);ctx.lineTo(479,519);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(479,519));listpt.Add(new Point(435,571));listpt.Add(new Point(402,633));listpt.Add(new Point(383,697));listpt.Add(new Point(376,765));listpt.Add(new Point(27,765));listpt.Add(new Point(43,628));listpt.Add(new Point(82,500));listpt.Add(new Point(146,378));listpt.Add(new Point(233,273));listpt.Add(new Point(478,28));listpt.Add(new Point(971,27));listpt.Add(new Point(479,519));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}