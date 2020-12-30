using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Blower
{
    public class PIXIE_ddb5a5f2_8159_478c_8572_c58714933168 : Pixie
    {
        public PIXIE_ddb5a5f2_8159_478c_8572_c58714933168()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#808080"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 642f; _h = 486f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#808080'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(472,174);ctx.lineTo(478,193);ctx.lineTo(482,212);ctx.lineTo(485,232);ctx.lineTo(486,251);ctx.lineTo(485,275);ctx.lineTo(481,298);ctx.lineTo(475,321);ctx.lineTo(467,342);ctx.lineTo(458,363);ctx.lineTo(446,382);ctx.lineTo(432,400);ctx.lineTo(417,417);ctx.lineTo(400,432);ctx.lineTo(382,446);ctx.lineTo(363,457);ctx.lineTo(343,467);ctx.lineTo(321,475);ctx.lineTo(299,481);ctx.lineTo(276,485);ctx.lineTo(252,486);ctx.lineTo(228,485);ctx.lineTo(205,481);ctx.lineTo(183,475);ctx.lineTo(161,467);ctx.lineTo(141,457);ctx.lineTo(121,446);ctx.lineTo(103,432);ctx.lineTo(87,417);ctx.lineTo(72,400);ctx.lineTo(58,382);ctx.lineTo(46,363);ctx.lineTo(36,342);ctx.lineTo(29,321);ctx.lineTo(23,298);ctx.lineTo(19,275);ctx.lineTo(18,251);ctx.lineTo(19,227);ctx.lineTo(23,204);ctx.lineTo(29,182);ctx.lineTo(36,161);ctx.lineTo(46,140);ctx.lineTo(58,121);ctx.lineTo(72,103);ctx.lineTo(87,86);ctx.lineTo(103,71);ctx.lineTo(121,58);ctx.lineTo(141,46);ctx.lineTo(161,36);ctx.lineTo(183,29);ctx.lineTo(205,23);ctx.lineTo(228,19);ctx.lineTo(252,18);ctx.lineTo(642,18);ctx.lineTo(642,174);ctx.lineTo(472,174);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(472,174));listpt.Add(new Point(478,193));listpt.Add(new Point(482,212));listpt.Add(new Point(485,232));listpt.Add(new Point(486,251));listpt.Add(new Point(485,275));listpt.Add(new Point(481,298));listpt.Add(new Point(475,321));listpt.Add(new Point(467,342));listpt.Add(new Point(458,363));listpt.Add(new Point(446,382));listpt.Add(new Point(432,400));listpt.Add(new Point(417,417));listpt.Add(new Point(400,432));listpt.Add(new Point(382,446));listpt.Add(new Point(363,457));listpt.Add(new Point(343,467));listpt.Add(new Point(321,475));listpt.Add(new Point(299,481));listpt.Add(new Point(276,485));listpt.Add(new Point(252,486));listpt.Add(new Point(228,485));listpt.Add(new Point(205,481));listpt.Add(new Point(183,475));listpt.Add(new Point(161,467));listpt.Add(new Point(141,457));listpt.Add(new Point(121,446));listpt.Add(new Point(103,432));listpt.Add(new Point(87,417));listpt.Add(new Point(72,400));listpt.Add(new Point(58,382));listpt.Add(new Point(46,363));listpt.Add(new Point(36,342));listpt.Add(new Point(29,321));listpt.Add(new Point(23,298));listpt.Add(new Point(19,275));listpt.Add(new Point(18,251));listpt.Add(new Point(19,227));listpt.Add(new Point(23,204));listpt.Add(new Point(29,182));listpt.Add(new Point(36,161));listpt.Add(new Point(46,140));listpt.Add(new Point(58,121));listpt.Add(new Point(72,103));listpt.Add(new Point(87,86));listpt.Add(new Point(103,71));listpt.Add(new Point(121,58));listpt.Add(new Point(141,46));listpt.Add(new Point(161,36));listpt.Add(new Point(183,29));listpt.Add(new Point(205,23));listpt.Add(new Point(228,19));listpt.Add(new Point(252,18));listpt.Add(new Point(642,18));listpt.Add(new Point(642,174));listpt.Add(new Point(472,174));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}