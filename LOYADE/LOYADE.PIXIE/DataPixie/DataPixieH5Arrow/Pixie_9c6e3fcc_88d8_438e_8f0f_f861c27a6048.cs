using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_9c6e3fcc_88d8_438e_8f0f_f861c27a6048 : Pixie
    {
        public PIXIE_9c6e3fcc_88d8_438e_8f0f_f861c27a6048()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 475f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(235,229);ctx.lineTo(296,231);ctx.lineTo(186,28);ctx.lineTo(210,28);ctx.lineTo(320,232);ctx.lineTo(381,235);ctx.lineTo(267,28);ctx.lineTo(292,28);ctx.lineTo(402,235);ctx.lineTo(803,248);ctx.lineTo(801,245);ctx.lineTo(803,246);ctx.lineTo(804,246);ctx.lineTo(777,235);ctx.lineTo(754,224);ctx.lineTo(727,206);ctx.lineTo(705,189);ctx.lineTo(681,167);ctx.lineTo(662,144);ctx.lineTo(650,122);ctx.lineTo(639,94);ctx.lineTo(631,67);ctx.lineTo(625,41);ctx.lineTo(625,28);ctx.lineTo(970,248);ctx.lineTo(970,254);ctx.lineTo(625,471);ctx.lineTo(628,444);ctx.lineTo(635,417);ctx.lineTo(649,389);ctx.lineTo(666,365);ctx.lineTo(687,339);ctx.lineTo(709,317);ctx.lineTo(732,298);ctx.lineTo(756,283);ctx.lineTo(784,269);ctx.lineTo(803,260);ctx.lineTo(402,271);ctx.lineTo(292,475);ctx.lineTo(267,475);ctx.lineTo(377,271);ctx.lineTo(320,273);ctx.lineTo(210,475);ctx.lineTo(186,475);ctx.lineTo(296,273);ctx.lineTo(243,275);ctx.lineTo(133,475);ctx.lineTo(109,475);ctx.lineTo(219,275);ctx.lineTo(162,277);ctx.lineTo(52,475);ctx.lineTo(28,475);ctx.lineTo(137,277);ctx.lineTo(52,280);ctx.lineTo(33,275);ctx.lineTo(28,246);ctx.lineTo(33,227);ctx.lineTo(51,223);ctx.lineTo(137,226);ctx.lineTo(28,28);ctx.lineTo(52,28);ctx.lineTo(162,226);ctx.lineTo(219,230);ctx.lineTo(109,28);ctx.lineTo(133,28);ctx.lineTo(235,229);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(235,229));listpt.Add(new Point(296,231));listpt.Add(new Point(186,28));listpt.Add(new Point(210,28));listpt.Add(new Point(320,232));listpt.Add(new Point(381,235));listpt.Add(new Point(267,28));listpt.Add(new Point(292,28));listpt.Add(new Point(402,235));listpt.Add(new Point(803,248));listpt.Add(new Point(801,245));listpt.Add(new Point(803,246));listpt.Add(new Point(804,246));listpt.Add(new Point(777,235));listpt.Add(new Point(754,224));listpt.Add(new Point(727,206));listpt.Add(new Point(705,189));listpt.Add(new Point(681,167));listpt.Add(new Point(662,144));listpt.Add(new Point(650,122));listpt.Add(new Point(639,94));listpt.Add(new Point(631,67));listpt.Add(new Point(625,41));listpt.Add(new Point(625,28));listpt.Add(new Point(970,248));listpt.Add(new Point(970,254));listpt.Add(new Point(625,471));listpt.Add(new Point(628,444));listpt.Add(new Point(635,417));listpt.Add(new Point(649,389));listpt.Add(new Point(666,365));listpt.Add(new Point(687,339));listpt.Add(new Point(709,317));listpt.Add(new Point(732,298));listpt.Add(new Point(756,283));listpt.Add(new Point(784,269));listpt.Add(new Point(803,260));listpt.Add(new Point(402,271));listpt.Add(new Point(292,475));listpt.Add(new Point(267,475));listpt.Add(new Point(377,271));listpt.Add(new Point(320,273));listpt.Add(new Point(210,475));listpt.Add(new Point(186,475));listpt.Add(new Point(296,273));listpt.Add(new Point(243,275));listpt.Add(new Point(133,475));listpt.Add(new Point(109,475));listpt.Add(new Point(219,275));listpt.Add(new Point(162,277));listpt.Add(new Point(52,475));listpt.Add(new Point(28,475));listpt.Add(new Point(137,277));listpt.Add(new Point(52,280));listpt.Add(new Point(33,275));listpt.Add(new Point(28,246));listpt.Add(new Point(33,227));listpt.Add(new Point(51,223));listpt.Add(new Point(137,226));listpt.Add(new Point(28,28));listpt.Add(new Point(52,28));listpt.Add(new Point(162,226));listpt.Add(new Point(219,230));listpt.Add(new Point(109,28));listpt.Add(new Point(133,28));listpt.Add(new Point(235,229));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}