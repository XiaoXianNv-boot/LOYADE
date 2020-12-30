using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_8607d8d2_2dbd_4d7b_bf81_f1cfbda261ff : Pixie
    {
        public PIXIE_8607d8d2_2dbd_4d7b_bf81_f1cfbda261ff()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 960f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(378,120);ctx.lineTo(378,55);ctx.lineTo(392,33);ctx.lineTo(404,28);ctx.lineTo(407,28);ctx.lineTo(411,28);ctx.lineTo(594,28);ctx.lineTo(615,38);ctx.lineTo(622,56);ctx.lineTo(622,120);ctx.lineTo(904,120);ctx.lineTo(933,126);ctx.lineTo(954,145);ctx.lineTo(964,170);ctx.lineTo(969,200);ctx.lineTo(970,222);ctx.lineTo(970,230);ctx.lineTo(970,238);ctx.lineTo(969,269);ctx.lineTo(968,298);ctx.lineTo(966,328);ctx.lineTo(961,357);ctx.lineTo(953,387);ctx.lineTo(943,417);ctx.lineTo(931,450);ctx.lineTo(916,483);ctx.lineTo(898,516);ctx.lineTo(886,538);ctx.lineTo(873,560);ctx.lineTo(860,582);ctx.lineTo(846,604);ctx.lineTo(832,626);ctx.lineTo(817,647);ctx.lineTo(801,669);ctx.lineTo(786,690);ctx.lineTo(770,711);ctx.lineTo(754,731);ctx.lineTo(730,761);ctx.lineTo(705,789);ctx.lineTo(681,817);ctx.lineTo(657,843);ctx.lineTo(634,868);ctx.lineTo(612,891);ctx.lineTo(590,911);ctx.lineTo(571,930);ctx.lineTo(549,946);ctx.lineTo(525,957);ctx.lineTo(507,959);ctx.lineTo(498,960);ctx.lineTo(495,960);ctx.lineTo(468,951);ctx.lineTo(445,940);ctx.lineTo(424,924);ctx.lineTo(395,898);ctx.lineTo(376,879);ctx.lineTo(354,857);ctx.lineTo(333,834);ctx.lineTo(311,809);ctx.lineTo(287,782);ctx.lineTo(263,753);ctx.lineTo(240,724);ctx.lineTo(217,694);ctx.lineTo(195,663);ctx.lineTo(173,632);ctx.lineTo(153,600);ctx.lineTo(133,568);ctx.lineTo(115,536);ctx.lineTo(97,503);ctx.lineTo(81,471);ctx.lineTo(67,439);ctx.lineTo(55,409);ctx.lineTo(45,379);ctx.lineTo(38,351);ctx.lineTo(32,324);ctx.lineTo(29,298);ctx.lineTo(28,285);ctx.lineTo(28,273);ctx.lineTo(28,264);ctx.lineTo(29,234);ctx.lineTo(31,201);ctx.lineTo(36,172);ctx.lineTo(45,145);ctx.lineTo(66,125);ctx.lineTo(93,120);ctx.lineTo(378,120);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(378,120));listpt.Add(new Point(378,55));listpt.Add(new Point(392,33));listpt.Add(new Point(404,28));listpt.Add(new Point(407,28));listpt.Add(new Point(411,28));listpt.Add(new Point(594,28));listpt.Add(new Point(615,38));listpt.Add(new Point(622,56));listpt.Add(new Point(622,120));listpt.Add(new Point(904,120));listpt.Add(new Point(933,126));listpt.Add(new Point(954,145));listpt.Add(new Point(964,170));listpt.Add(new Point(969,200));listpt.Add(new Point(970,222));listpt.Add(new Point(970,230));listpt.Add(new Point(970,238));listpt.Add(new Point(969,269));listpt.Add(new Point(968,298));listpt.Add(new Point(966,328));listpt.Add(new Point(961,357));listpt.Add(new Point(953,387));listpt.Add(new Point(943,417));listpt.Add(new Point(931,450));listpt.Add(new Point(916,483));listpt.Add(new Point(898,516));listpt.Add(new Point(886,538));listpt.Add(new Point(873,560));listpt.Add(new Point(860,582));listpt.Add(new Point(846,604));listpt.Add(new Point(832,626));listpt.Add(new Point(817,647));listpt.Add(new Point(801,669));listpt.Add(new Point(786,690));listpt.Add(new Point(770,711));listpt.Add(new Point(754,731));listpt.Add(new Point(730,761));listpt.Add(new Point(705,789));listpt.Add(new Point(681,817));listpt.Add(new Point(657,843));listpt.Add(new Point(634,868));listpt.Add(new Point(612,891));listpt.Add(new Point(590,911));listpt.Add(new Point(571,930));listpt.Add(new Point(549,946));listpt.Add(new Point(525,957));listpt.Add(new Point(507,959));listpt.Add(new Point(498,960));listpt.Add(new Point(495,960));listpt.Add(new Point(468,951));listpt.Add(new Point(445,940));listpt.Add(new Point(424,924));listpt.Add(new Point(395,898));listpt.Add(new Point(376,879));listpt.Add(new Point(354,857));listpt.Add(new Point(333,834));listpt.Add(new Point(311,809));listpt.Add(new Point(287,782));listpt.Add(new Point(263,753));listpt.Add(new Point(240,724));listpt.Add(new Point(217,694));listpt.Add(new Point(195,663));listpt.Add(new Point(173,632));listpt.Add(new Point(153,600));listpt.Add(new Point(133,568));listpt.Add(new Point(115,536));listpt.Add(new Point(97,503));listpt.Add(new Point(81,471));listpt.Add(new Point(67,439));listpt.Add(new Point(55,409));listpt.Add(new Point(45,379));listpt.Add(new Point(38,351));listpt.Add(new Point(32,324));listpt.Add(new Point(29,298));listpt.Add(new Point(28,285));listpt.Add(new Point(28,273));listpt.Add(new Point(28,264));listpt.Add(new Point(29,234));listpt.Add(new Point(31,201));listpt.Add(new Point(36,172));listpt.Add(new Point(45,145));listpt.Add(new Point(66,125));listpt.Add(new Point(93,120));listpt.Add(new Point(378,120));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}