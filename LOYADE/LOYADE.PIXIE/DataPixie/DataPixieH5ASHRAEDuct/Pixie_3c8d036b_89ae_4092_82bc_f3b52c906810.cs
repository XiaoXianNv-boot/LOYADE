using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEDuct
{
    public class PIXIE_3c8d036b_89ae_4092_82bc_f3b52c906810 : Pixie
    {
        public PIXIE_3c8d036b_89ae_4092_82bc_f3b52c906810()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 807f; _h = 971f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(252,971);ctx.lineTo(251,933);ctx.lineTo(248,895);ctx.lineTo(243,857);ctx.lineTo(237,819);ctx.lineTo(228,782);ctx.lineTo(217,745);ctx.lineTo(206,709);ctx.lineTo(191,673);ctx.lineTo(176,638);ctx.lineTo(159,603);ctx.lineTo(141,570);ctx.lineTo(121,537);ctx.lineTo(100,506);ctx.lineTo(77,475);ctx.lineTo(53,446);ctx.lineTo(27,418);ctx.lineTo(418,27);ctx.lineTo(440,50);ctx.lineTo(463,74);ctx.lineTo(484,99);ctx.lineTo(504,124);ctx.lineTo(525,150);ctx.lineTo(544,175);ctx.lineTo(563,202);ctx.lineTo(582,230);ctx.lineTo(599,256);ctx.lineTo(616,285);ctx.lineTo(632,313);ctx.lineTo(648,342);ctx.lineTo(663,371);ctx.lineTo(678,400);ctx.lineTo(691,431);ctx.lineTo(704,460);ctx.lineTo(716,491);ctx.lineTo(727,521);ctx.lineTo(738,552);ctx.lineTo(749,583);ctx.lineTo(758,615);ctx.lineTo(767,647);ctx.lineTo(774,679);ctx.lineTo(781,711);ctx.lineTo(787,743);ctx.lineTo(792,775);ctx.lineTo(797,807);ctx.lineTo(800,840);ctx.lineTo(804,873);ctx.lineTo(806,905);ctx.lineTo(807,938);ctx.lineTo(807,971);ctx.lineTo(252,971);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(252,971));listpt.Add(new Point(251,933));listpt.Add(new Point(248,895));listpt.Add(new Point(243,857));listpt.Add(new Point(237,819));listpt.Add(new Point(228,782));listpt.Add(new Point(217,745));listpt.Add(new Point(206,709));listpt.Add(new Point(191,673));listpt.Add(new Point(176,638));listpt.Add(new Point(159,603));listpt.Add(new Point(141,570));listpt.Add(new Point(121,537));listpt.Add(new Point(100,506));listpt.Add(new Point(77,475));listpt.Add(new Point(53,446));listpt.Add(new Point(27,418));listpt.Add(new Point(418,27));listpt.Add(new Point(440,50));listpt.Add(new Point(463,74));listpt.Add(new Point(484,99));listpt.Add(new Point(504,124));listpt.Add(new Point(525,150));listpt.Add(new Point(544,175));listpt.Add(new Point(563,202));listpt.Add(new Point(582,230));listpt.Add(new Point(599,256));listpt.Add(new Point(616,285));listpt.Add(new Point(632,313));listpt.Add(new Point(648,342));listpt.Add(new Point(663,371));listpt.Add(new Point(678,400));listpt.Add(new Point(691,431));listpt.Add(new Point(704,460));listpt.Add(new Point(716,491));listpt.Add(new Point(727,521));listpt.Add(new Point(738,552));listpt.Add(new Point(749,583));listpt.Add(new Point(758,615));listpt.Add(new Point(767,647));listpt.Add(new Point(774,679));listpt.Add(new Point(781,711));listpt.Add(new Point(787,743));listpt.Add(new Point(792,775));listpt.Add(new Point(797,807));listpt.Add(new Point(800,840));listpt.Add(new Point(804,873));listpt.Add(new Point(806,905));listpt.Add(new Point(807,938));listpt.Add(new Point(807,971));listpt.Add(new Point(252,971));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}