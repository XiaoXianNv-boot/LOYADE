using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorSimple
{
    public class PIXIE_91ce42e8_c2a6_48d5_a6a1_67c6f609cabd : Pixie
    {
        public PIXIE_91ce42e8_c2a6_48d5_a6a1_67c6f609cabd()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 772f; _h = 772f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(22,22);ctx.lineTo(22,396);ctx.lineTo(95,403);ctx.lineTo(166,425);ctx.lineTo(230,459);ctx.lineTo(288,506);ctx.lineTo(335,563);ctx.lineTo(369,628);ctx.lineTo(390,698);ctx.lineTo(398,772);ctx.lineTo(772,772);ctx.lineTo(756,624);ctx.lineTo(714,485);ctx.lineTo(646,355);ctx.lineTo(553,241);ctx.lineTo(437,148);ctx.lineTo(309,80);ctx.lineTo(168,36);ctx.lineTo(22,22);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(22,22));listpt.Add(new Point(22,396));listpt.Add(new Point(95,403));listpt.Add(new Point(166,425));listpt.Add(new Point(230,459));listpt.Add(new Point(288,506));listpt.Add(new Point(335,563));listpt.Add(new Point(369,628));listpt.Add(new Point(390,698));listpt.Add(new Point(398,772));listpt.Add(new Point(772,772));listpt.Add(new Point(756,624));listpt.Add(new Point(714,485));listpt.Add(new Point(646,355));listpt.Add(new Point(553,241));listpt.Add(new Point(437,148));listpt.Add(new Point(309,80));listpt.Add(new Point(168,36));listpt.Add(new Point(22,22));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}