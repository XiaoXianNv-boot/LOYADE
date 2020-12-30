using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorSimple
{
    public class PIXIE_263a4160_8be1_45ae_ab2f_b298a251ce94 : Pixie
    {
        public PIXIE_263a4160_8be1_45ae_ab2f_b298a251ce94()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 545f; _h = 500f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(545,279);ctx.lineTo(281,15);ctx.lineTo(224,61);ctx.lineTo(158,96);ctx.lineTo(89,117);ctx.lineTo(15,125);ctx.lineTo(15,500);ctx.lineTo(163,483);ctx.lineTo(301,441);ctx.lineTo(432,372);ctx.lineTo(545,279);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(545,279));listpt.Add(new Point(281,15));listpt.Add(new Point(224,61));listpt.Add(new Point(158,96));listpt.Add(new Point(89,117));listpt.Add(new Point(15,125));listpt.Add(new Point(15,500));listpt.Add(new Point(163,483));listpt.Add(new Point(301,441));listpt.Add(new Point(432,372));listpt.Add(new Point(545,279));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}