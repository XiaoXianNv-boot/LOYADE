using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorBelt
{
    public class PIXIE_114ed414_1058_42fd_b7be_5ec532be5070 : Pixie
    {
        public PIXIE_114ed414_1058_42fd_b7be_5ec532be5070()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#c0c0c0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 772f; _h = 772f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#c0c0c0'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(772,22);ctx.lineTo(398,22);ctx.lineTo(391,95);ctx.lineTo(369,166);ctx.lineTo(335,230);ctx.lineTo(288,288);ctx.lineTo(231,335);ctx.lineTo(166,369);ctx.lineTo(96,390);ctx.lineTo(22,398);ctx.lineTo(22,772);ctx.lineTo(170,756);ctx.lineTo(309,714);ctx.lineTo(439,646);ctx.lineTo(553,553);ctx.lineTo(646,437);ctx.lineTo(714,309);ctx.lineTo(758,168);ctx.lineTo(772,22);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(772,22));listpt.Add(new Point(398,22));listpt.Add(new Point(391,95));listpt.Add(new Point(369,166));listpt.Add(new Point(335,230));listpt.Add(new Point(288,288));listpt.Add(new Point(231,335));listpt.Add(new Point(166,369));listpt.Add(new Point(96,390));listpt.Add(new Point(22,398));listpt.Add(new Point(22,772));listpt.Add(new Point(170,756));listpt.Add(new Point(309,714));listpt.Add(new Point(439,646));listpt.Add(new Point(553,553));listpt.Add(new Point(646,437));listpt.Add(new Point(714,309));listpt.Add(new Point(758,168));listpt.Add(new Point(772,22));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}