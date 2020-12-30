using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEDuct
{
    public class PIXIE_52f8bd51_7ca1_4805_ab67_a5de16248acd : Pixie
    {
        public PIXIE_52f8bd51_7ca1_4805_ab67_a5de16248acd()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 807f; _h = 971f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(583,971);ctx.lineTo(583,933);ctx.lineTo(586,895);ctx.lineTo(591,857);ctx.lineTo(598,819);ctx.lineTo(607,782);ctx.lineTo(617,745);ctx.lineTo(629,709);ctx.lineTo(643,673);ctx.lineTo(658,638);ctx.lineTo(675,603);ctx.lineTo(694,570);ctx.lineTo(713,537);ctx.lineTo(735,506);ctx.lineTo(758,475);ctx.lineTo(782,446);ctx.lineTo(807,418);ctx.lineTo(416,27);ctx.lineTo(394,50);ctx.lineTo(372,74);ctx.lineTo(351,99);ctx.lineTo(330,124);ctx.lineTo(310,150);ctx.lineTo(290,175);ctx.lineTo(271,202);ctx.lineTo(253,230);ctx.lineTo(235,256);ctx.lineTo(218,285);ctx.lineTo(202,313);ctx.lineTo(186,342);ctx.lineTo(171,371);ctx.lineTo(157,400);ctx.lineTo(143,431);ctx.lineTo(130,460);ctx.lineTo(119,491);ctx.lineTo(107,521);ctx.lineTo(96,552);ctx.lineTo(86,583);ctx.lineTo(77,615);ctx.lineTo(68,647);ctx.lineTo(61,679);ctx.lineTo(54,711);ctx.lineTo(47,743);ctx.lineTo(42,775);ctx.lineTo(38,807);ctx.lineTo(34,840);ctx.lineTo(31,873);ctx.lineTo(29,905);ctx.lineTo(27,938);ctx.lineTo(27,971);ctx.lineTo(583,971);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(583,971));listpt.Add(new Point(583,933));listpt.Add(new Point(586,895));listpt.Add(new Point(591,857));listpt.Add(new Point(598,819));listpt.Add(new Point(607,782));listpt.Add(new Point(617,745));listpt.Add(new Point(629,709));listpt.Add(new Point(643,673));listpt.Add(new Point(658,638));listpt.Add(new Point(675,603));listpt.Add(new Point(694,570));listpt.Add(new Point(713,537));listpt.Add(new Point(735,506));listpt.Add(new Point(758,475));listpt.Add(new Point(782,446));listpt.Add(new Point(807,418));listpt.Add(new Point(416,27));listpt.Add(new Point(394,50));listpt.Add(new Point(372,74));listpt.Add(new Point(351,99));listpt.Add(new Point(330,124));listpt.Add(new Point(310,150));listpt.Add(new Point(290,175));listpt.Add(new Point(271,202));listpt.Add(new Point(253,230));listpt.Add(new Point(235,256));listpt.Add(new Point(218,285));listpt.Add(new Point(202,313));listpt.Add(new Point(186,342));listpt.Add(new Point(171,371));listpt.Add(new Point(157,400));listpt.Add(new Point(143,431));listpt.Add(new Point(130,460));listpt.Add(new Point(119,491));listpt.Add(new Point(107,521));listpt.Add(new Point(96,552));listpt.Add(new Point(86,583));listpt.Add(new Point(77,615));listpt.Add(new Point(68,647));listpt.Add(new Point(61,679));listpt.Add(new Point(54,711));listpt.Add(new Point(47,743));listpt.Add(new Point(42,775));listpt.Add(new Point(38,807));listpt.Add(new Point(34,840));listpt.Add(new Point(31,873));listpt.Add(new Point(29,905));listpt.Add(new Point(27,938));listpt.Add(new Point(27,971));listpt.Add(new Point(583,971));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}