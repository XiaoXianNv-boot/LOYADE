using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_c11affbf_ddda_4f37_9971_1c86c43b9016 : Pixie
    {
        public PIXIE_c11affbf_ddda_4f37_9971_1c86c43b9016()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 439f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,93);ctx.lineTo(179,93);ctx.lineTo(158,114);ctx.lineTo(266,114);ctx.lineTo(289,102);ctx.lineTo(318,86);ctx.lineTo(345,71);ctx.lineTo(369,58);ctx.lineTo(391,46);ctx.lineTo(418,35);ctx.lineTo(445,29);ctx.lineTo(450,28);ctx.lineTo(456,28);ctx.lineTo(461,28);ctx.lineTo(492,33);ctx.lineTo(519,43);ctx.lineTo(543,56);ctx.lineTo(565,68);ctx.lineTo(569,71);ctx.lineTo(873,71);ctx.lineTo(906,73);ctx.lineTo(932,79);ctx.lineTo(957,91);ctx.lineTo(970,110);ctx.lineTo(970,114);ctx.lineTo(970,118);ctx.lineTo(952,141);ctx.lineTo(924,152);ctx.lineTo(896,157);ctx.lineTo(863,158);ctx.lineTo(678,158);ctx.lineTo(705,174);ctx.lineTo(723,197);ctx.lineTo(716,223);ctx.lineTo(690,237);ctx.lineTo(657,243);ctx.lineTo(634,244);ctx.lineTo(658,262);ctx.lineTo(673,285);ctx.lineTo(658,309);ctx.lineTo(633,321);ctx.lineTo(604,329);ctx.lineTo(591,331);ctx.lineTo(617,354);ctx.lineTo(623,381);ctx.lineTo(600,403);ctx.lineTo(569,416);ctx.lineTo(542,423);ctx.lineTo(512,429);ctx.lineTo(479,432);ctx.lineTo(445,434);ctx.lineTo(408,435);ctx.lineTo(372,433);ctx.lineTo(335,430);ctx.lineTo(300,425);ctx.lineTo(266,418);ctx.lineTo(158,418);ctx.lineTo(179,439);ctx.lineTo(28,439);ctx.lineTo(28,93);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,93));listpt.Add(new Point(179,93));listpt.Add(new Point(158,114));listpt.Add(new Point(266,114));listpt.Add(new Point(289,102));listpt.Add(new Point(318,86));listpt.Add(new Point(345,71));listpt.Add(new Point(369,58));listpt.Add(new Point(391,46));listpt.Add(new Point(418,35));listpt.Add(new Point(445,29));listpt.Add(new Point(450,28));listpt.Add(new Point(456,28));listpt.Add(new Point(461,28));listpt.Add(new Point(492,33));listpt.Add(new Point(519,43));listpt.Add(new Point(543,56));listpt.Add(new Point(565,68));listpt.Add(new Point(569,71));listpt.Add(new Point(873,71));listpt.Add(new Point(906,73));listpt.Add(new Point(932,79));listpt.Add(new Point(957,91));listpt.Add(new Point(970,110));listpt.Add(new Point(970,114));listpt.Add(new Point(970,118));listpt.Add(new Point(952,141));listpt.Add(new Point(924,152));listpt.Add(new Point(896,157));listpt.Add(new Point(863,158));listpt.Add(new Point(678,158));listpt.Add(new Point(705,174));listpt.Add(new Point(723,197));listpt.Add(new Point(716,223));listpt.Add(new Point(690,237));listpt.Add(new Point(657,243));listpt.Add(new Point(634,244));listpt.Add(new Point(658,262));listpt.Add(new Point(673,285));listpt.Add(new Point(658,309));listpt.Add(new Point(633,321));listpt.Add(new Point(604,329));listpt.Add(new Point(591,331));listpt.Add(new Point(617,354));listpt.Add(new Point(623,381));listpt.Add(new Point(600,403));listpt.Add(new Point(569,416));listpt.Add(new Point(542,423));listpt.Add(new Point(512,429));listpt.Add(new Point(479,432));listpt.Add(new Point(445,434));listpt.Add(new Point(408,435));listpt.Add(new Point(372,433));listpt.Add(new Point(335,430));listpt.Add(new Point(300,425));listpt.Add(new Point(266,418));listpt.Add(new Point(158,418));listpt.Add(new Point(179,439));listpt.Add(new Point(28,439));listpt.Add(new Point(28,93));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}