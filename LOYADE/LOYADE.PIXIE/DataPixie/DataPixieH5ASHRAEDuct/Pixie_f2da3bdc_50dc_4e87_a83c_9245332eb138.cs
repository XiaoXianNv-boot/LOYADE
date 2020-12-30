using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEDuct
{
    public class PIXIE_f2da3bdc_50dc_4e87_a83c_9245332eb138 : Pixie
    {
        public PIXIE_f2da3bdc_50dc_4e87_a83c_9245332eb138()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 807f; _h = 971f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(252,27);ctx.lineTo(251,65);ctx.lineTo(248,103);ctx.lineTo(243,141);ctx.lineTo(237,179);ctx.lineTo(228,216);ctx.lineTo(217,253);ctx.lineTo(206,289);ctx.lineTo(191,325);ctx.lineTo(176,360);ctx.lineTo(159,395);ctx.lineTo(141,428);ctx.lineTo(121,461);ctx.lineTo(100,492);ctx.lineTo(77,523);ctx.lineTo(53,552);ctx.lineTo(27,580);ctx.lineTo(418,971);ctx.lineTo(440,948);ctx.lineTo(463,924);ctx.lineTo(484,899);ctx.lineTo(504,874);ctx.lineTo(525,848);ctx.lineTo(544,823);ctx.lineTo(563,796);ctx.lineTo(582,768);ctx.lineTo(599,742);ctx.lineTo(616,713);ctx.lineTo(632,685);ctx.lineTo(648,656);ctx.lineTo(663,627);ctx.lineTo(678,598);ctx.lineTo(691,567);ctx.lineTo(704,537);ctx.lineTo(716,507);ctx.lineTo(727,477);ctx.lineTo(738,446);ctx.lineTo(749,415);ctx.lineTo(758,383);ctx.lineTo(767,351);ctx.lineTo(774,319);ctx.lineTo(781,287);ctx.lineTo(787,255);ctx.lineTo(792,223);ctx.lineTo(797,191);ctx.lineTo(800,158);ctx.lineTo(804,125);ctx.lineTo(806,93);ctx.lineTo(807,60);ctx.lineTo(807,27);ctx.lineTo(252,27);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(252,27));listpt.Add(new Point(251,65));listpt.Add(new Point(248,103));listpt.Add(new Point(243,141));listpt.Add(new Point(237,179));listpt.Add(new Point(228,216));listpt.Add(new Point(217,253));listpt.Add(new Point(206,289));listpt.Add(new Point(191,325));listpt.Add(new Point(176,360));listpt.Add(new Point(159,395));listpt.Add(new Point(141,428));listpt.Add(new Point(121,461));listpt.Add(new Point(100,492));listpt.Add(new Point(77,523));listpt.Add(new Point(53,552));listpt.Add(new Point(27,580));listpt.Add(new Point(418,971));listpt.Add(new Point(440,948));listpt.Add(new Point(463,924));listpt.Add(new Point(484,899));listpt.Add(new Point(504,874));listpt.Add(new Point(525,848));listpt.Add(new Point(544,823));listpt.Add(new Point(563,796));listpt.Add(new Point(582,768));listpt.Add(new Point(599,742));listpt.Add(new Point(616,713));listpt.Add(new Point(632,685));listpt.Add(new Point(648,656));listpt.Add(new Point(663,627));listpt.Add(new Point(678,598));listpt.Add(new Point(691,567));listpt.Add(new Point(704,537));listpt.Add(new Point(716,507));listpt.Add(new Point(727,477));listpt.Add(new Point(738,446));listpt.Add(new Point(749,415));listpt.Add(new Point(758,383));listpt.Add(new Point(767,351));listpt.Add(new Point(774,319));listpt.Add(new Point(781,287));listpt.Add(new Point(787,255));listpt.Add(new Point(792,223));listpt.Add(new Point(797,191));listpt.Add(new Point(800,158));listpt.Add(new Point(804,125));listpt.Add(new Point(806,93));listpt.Add(new Point(807,60));listpt.Add(new Point(807,27));listpt.Add(new Point(252,27));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}