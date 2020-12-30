using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorBelt
{
    public class PIXIE_152d9f2a_cd27_4d1b_bd1e_1e00dc490e76 : Pixie
    {
        public PIXIE_152d9f2a_cd27_4d1b_bd1e_1e00dc490e76()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#c0c0c0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 772f; _h = 772f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#c0c0c0'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(772,772);ctx.lineTo(772,398);ctx.lineTo(699,391);ctx.lineTo(628,369);ctx.lineTo(564,335);ctx.lineTo(506,288);ctx.lineTo(459,231);ctx.lineTo(425,166);ctx.lineTo(404,96);ctx.lineTo(396,22);ctx.lineTo(22,22);ctx.lineTo(38,170);ctx.lineTo(80,309);ctx.lineTo(148,439);ctx.lineTo(241,553);ctx.lineTo(357,646);ctx.lineTo(485,714);ctx.lineTo(626,758);ctx.lineTo(772,772);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(772,772));listpt.Add(new Point(772,398));listpt.Add(new Point(699,391));listpt.Add(new Point(628,369));listpt.Add(new Point(564,335));listpt.Add(new Point(506,288));listpt.Add(new Point(459,231));listpt.Add(new Point(425,166));listpt.Add(new Point(404,96));listpt.Add(new Point(396,22));listpt.Add(new Point(22,22));listpt.Add(new Point(38,170));listpt.Add(new Point(80,309));listpt.Add(new Point(148,439));listpt.Add(new Point(241,553));listpt.Add(new Point(357,646));listpt.Add(new Point(485,714));listpt.Add(new Point(626,758));listpt.Add(new Point(772,772));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}