using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5FlowMeter
{
    public class PIXIE_b91deae2_d487_4741_a790_8e51663438b0 : Pixie
    {
        public PIXIE_b91deae2_d487_4741_a790_8e51663438b0()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 715f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(48,715);ctx.lineTo(48,597);ctx.lineTo(28,578);ctx.lineTo(28,362);ctx.lineTo(48,342);ctx.lineTo(48,244);ctx.lineTo(106,244);ctx.lineTo(106,342);ctx.lineTo(165,322);ctx.lineTo(165,283);ctx.lineTo(178,281);ctx.lineTo(173,259);ctx.lineTo(247,245);ctx.lineTo(251,266);ctx.lineTo(263,263);ctx.lineTo(283,303);ctx.lineTo(322,303);ctx.lineTo(322,283);ctx.lineTo(293,283);ctx.lineTo(293,263);ctx.lineTo(303,263);ctx.lineTo(303,205);ctx.lineTo(312,195);ctx.lineTo(371,195);ctx.lineTo(381,205);ctx.lineTo(381,165);ctx.lineTo(401,146);ctx.lineTo(401,48);ctx.lineTo(420,28);ctx.lineTo(578,28);ctx.lineTo(597,48);ctx.lineTo(597,146);ctx.lineTo(617,165);ctx.lineTo(617,205);ctx.lineTo(627,195);ctx.lineTo(686,195);ctx.lineTo(695,205);ctx.lineTo(695,263);ctx.lineTo(705,263);ctx.lineTo(705,283);ctx.lineTo(676,283);ctx.lineTo(676,303);ctx.lineTo(852,381);ctx.lineTo(892,362);ctx.lineTo(892,244);ctx.lineTo(951,244);ctx.lineTo(951,342);ctx.lineTo(970,362);ctx.lineTo(970,578);ctx.lineTo(951,597);ctx.lineTo(951,715);ctx.lineTo(892,715);ctx.lineTo(892,637);ctx.lineTo(833,578);ctx.lineTo(656,578);ctx.lineTo(617,597);ctx.lineTo(578,676);ctx.lineTo(420,676);ctx.lineTo(401,637);ctx.lineTo(146,578);ctx.lineTo(106,597);ctx.lineTo(106,715);ctx.lineTo(48,715);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(204,460,58,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(793,460,58,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(48,715));listpt.Add(new Point(48,597));listpt.Add(new Point(28,578));listpt.Add(new Point(28,362));listpt.Add(new Point(48,342));listpt.Add(new Point(48,244));listpt.Add(new Point(106,244));listpt.Add(new Point(106,342));listpt.Add(new Point(165,322));listpt.Add(new Point(165,283));listpt.Add(new Point(178,281));listpt.Add(new Point(173,259));listpt.Add(new Point(247,245));listpt.Add(new Point(251,266));listpt.Add(new Point(263,263));listpt.Add(new Point(283,303));listpt.Add(new Point(322,303));listpt.Add(new Point(322,283));listpt.Add(new Point(293,283));listpt.Add(new Point(293,263));listpt.Add(new Point(303,263));listpt.Add(new Point(303,205));listpt.Add(new Point(312,195));listpt.Add(new Point(371,195));listpt.Add(new Point(381,205));listpt.Add(new Point(381,165));listpt.Add(new Point(401,146));listpt.Add(new Point(401,48));listpt.Add(new Point(420,28));listpt.Add(new Point(578,28));listpt.Add(new Point(597,48));listpt.Add(new Point(597,146));listpt.Add(new Point(617,165));listpt.Add(new Point(617,205));listpt.Add(new Point(627,195));listpt.Add(new Point(686,195));listpt.Add(new Point(695,205));listpt.Add(new Point(695,263));listpt.Add(new Point(705,263));listpt.Add(new Point(705,283));listpt.Add(new Point(676,283));listpt.Add(new Point(676,303));listpt.Add(new Point(852,381));listpt.Add(new Point(892,362));listpt.Add(new Point(892,244));listpt.Add(new Point(951,244));listpt.Add(new Point(951,342));listpt.Add(new Point(970,362));listpt.Add(new Point(970,578));listpt.Add(new Point(951,597));listpt.Add(new Point(951,715));listpt.Add(new Point(892,715));listpt.Add(new Point(892,637));listpt.Add(new Point(833,578));listpt.Add(new Point(656,578));listpt.Add(new Point(617,597));listpt.Add(new Point(578,676));listpt.Add(new Point(420,676));listpt.Add(new Point(401,637));listpt.Add(new Point(146,578));listpt.Add(new Point(106,597));listpt.Add(new Point(106,715));listpt.Add(new Point(48,715));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.DrawEllipse(p, 146f,402f,116f,116f);
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.DrawEllipse(p, 735f,402f,116f,116f);
        }
    }
}