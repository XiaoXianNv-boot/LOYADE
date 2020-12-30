using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEControlEquipment
{
    public class PIXIE_fee40821_5914_45ea_afdd_9c81aa9fceeb : Pixie
    {
        public PIXIE_fee40821_5914_45ea_afdd_9c81aa9fceeb()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 970f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,499);ctx.lineTo(62,322);ctx.lineTo(162,162);ctx.lineTo(322,62);ctx.lineTo(499,28);ctx.lineTo(676,62);ctx.lineTo(836,162);ctx.lineTo(936,322);ctx.lineTo(970,499);ctx.lineTo(936,676);ctx.lineTo(836,836);ctx.lineTo(676,936);ctx.lineTo(499,970);ctx.lineTo(322,936);ctx.lineTo(162,836);ctx.lineTo(62,676);ctx.lineTo(28,499);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,499));listpt.Add(new Point(62,322));listpt.Add(new Point(162,162));listpt.Add(new Point(322,62));listpt.Add(new Point(499,28));listpt.Add(new Point(676,62));listpt.Add(new Point(836,162));listpt.Add(new Point(936,322));listpt.Add(new Point(970,499));listpt.Add(new Point(936,676));listpt.Add(new Point(836,836));listpt.Add(new Point(676,936));listpt.Add(new Point(499,970));listpt.Add(new Point(322,936));listpt.Add(new Point(162,836));listpt.Add(new Point(62,676));listpt.Add(new Point(28,499));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}