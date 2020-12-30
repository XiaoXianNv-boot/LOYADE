using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorSimple
{
    public class PIXIE_79528b71_d989_4435_96af_5f76fb229f3e : Pixie
    {
        public PIXIE_79528b71_d989_4435_96af_5f76fb229f3e()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 499f; _h = 546f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(499,15);ctx.lineTo(125,15);ctx.lineTo(118,88);ctx.lineTo(96,159);ctx.lineTo(62,223);ctx.lineTo(15,281);ctx.lineTo(280,546);ctx.lineTo(373,430);ctx.lineTo(441,302);ctx.lineTo(485,161);ctx.lineTo(499,15);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(499,15));listpt.Add(new Point(125,15));listpt.Add(new Point(118,88));listpt.Add(new Point(96,159));listpt.Add(new Point(62,223));listpt.Add(new Point(15,281));listpt.Add(new Point(280,546));listpt.Add(new Point(373,430));listpt.Add(new Point(441,302));listpt.Add(new Point(485,161));listpt.Add(new Point(499,15));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}