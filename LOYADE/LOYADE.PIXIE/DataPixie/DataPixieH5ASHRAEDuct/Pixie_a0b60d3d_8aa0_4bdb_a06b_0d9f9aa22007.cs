using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEDuct
{
    public class PIXIE_a0b60d3d_8aa0_4bdb_a06b_0d9f9aa22007 : Pixie
    {
        public PIXIE_a0b60d3d_8aa0_4bdb_a06b_0d9f9aa22007()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 807f; _h = 971f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(583,27);ctx.lineTo(583,65);ctx.lineTo(586,103);ctx.lineTo(591,141);ctx.lineTo(598,179);ctx.lineTo(607,216);ctx.lineTo(617,253);ctx.lineTo(629,289);ctx.lineTo(643,325);ctx.lineTo(658,360);ctx.lineTo(675,395);ctx.lineTo(694,428);ctx.lineTo(713,461);ctx.lineTo(735,492);ctx.lineTo(758,523);ctx.lineTo(782,552);ctx.lineTo(807,580);ctx.lineTo(416,971);ctx.lineTo(394,948);ctx.lineTo(372,924);ctx.lineTo(351,899);ctx.lineTo(330,874);ctx.lineTo(310,848);ctx.lineTo(290,823);ctx.lineTo(271,796);ctx.lineTo(253,768);ctx.lineTo(235,742);ctx.lineTo(218,713);ctx.lineTo(202,685);ctx.lineTo(186,656);ctx.lineTo(171,627);ctx.lineTo(157,598);ctx.lineTo(143,567);ctx.lineTo(130,537);ctx.lineTo(119,507);ctx.lineTo(107,477);ctx.lineTo(96,446);ctx.lineTo(86,415);ctx.lineTo(77,383);ctx.lineTo(68,351);ctx.lineTo(61,319);ctx.lineTo(54,287);ctx.lineTo(47,255);ctx.lineTo(42,223);ctx.lineTo(38,191);ctx.lineTo(34,158);ctx.lineTo(31,125);ctx.lineTo(29,93);ctx.lineTo(27,60);ctx.lineTo(27,27);ctx.lineTo(583,27);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(583,27));listpt.Add(new Point(583,65));listpt.Add(new Point(586,103));listpt.Add(new Point(591,141));listpt.Add(new Point(598,179));listpt.Add(new Point(607,216));listpt.Add(new Point(617,253));listpt.Add(new Point(629,289));listpt.Add(new Point(643,325));listpt.Add(new Point(658,360));listpt.Add(new Point(675,395));listpt.Add(new Point(694,428));listpt.Add(new Point(713,461));listpt.Add(new Point(735,492));listpt.Add(new Point(758,523));listpt.Add(new Point(782,552));listpt.Add(new Point(807,580));listpt.Add(new Point(416,971));listpt.Add(new Point(394,948));listpt.Add(new Point(372,924));listpt.Add(new Point(351,899));listpt.Add(new Point(330,874));listpt.Add(new Point(310,848));listpt.Add(new Point(290,823));listpt.Add(new Point(271,796));listpt.Add(new Point(253,768));listpt.Add(new Point(235,742));listpt.Add(new Point(218,713));listpt.Add(new Point(202,685));listpt.Add(new Point(186,656));listpt.Add(new Point(171,627));listpt.Add(new Point(157,598));listpt.Add(new Point(143,567));listpt.Add(new Point(130,537));listpt.Add(new Point(119,507));listpt.Add(new Point(107,477));listpt.Add(new Point(96,446));listpt.Add(new Point(86,415));listpt.Add(new Point(77,383));listpt.Add(new Point(68,351));listpt.Add(new Point(61,319));listpt.Add(new Point(54,287));listpt.Add(new Point(47,255));listpt.Add(new Point(42,223));listpt.Add(new Point(38,191));listpt.Add(new Point(34,158));listpt.Add(new Point(31,125));listpt.Add(new Point(29,93));listpt.Add(new Point(27,60));listpt.Add(new Point(27,27));listpt.Add(new Point(583,27));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}