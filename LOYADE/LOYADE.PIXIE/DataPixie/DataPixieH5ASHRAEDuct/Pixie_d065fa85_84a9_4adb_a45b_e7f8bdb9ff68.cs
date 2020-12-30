using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEDuct
{
    public class PIXIE_d065fa85_84a9_4adb_a45b_e7f8bdb9ff68 : Pixie
    {
        public PIXIE_d065fa85_84a9_4adb_a45b_e7f8bdb9ff68()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 971f; _h = 807f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(971,583);ctx.lineTo(933,583);ctx.lineTo(895,586);ctx.lineTo(857,591);ctx.lineTo(819,598);ctx.lineTo(782,607);ctx.lineTo(745,617);ctx.lineTo(709,629);ctx.lineTo(673,643);ctx.lineTo(638,658);ctx.lineTo(603,675);ctx.lineTo(570,694);ctx.lineTo(537,713);ctx.lineTo(506,735);ctx.lineTo(475,758);ctx.lineTo(446,782);ctx.lineTo(418,807);ctx.lineTo(27,416);ctx.lineTo(50,394);ctx.lineTo(74,372);ctx.lineTo(99,351);ctx.lineTo(124,330);ctx.lineTo(150,310);ctx.lineTo(175,290);ctx.lineTo(202,271);ctx.lineTo(230,253);ctx.lineTo(256,235);ctx.lineTo(285,218);ctx.lineTo(313,202);ctx.lineTo(342,186);ctx.lineTo(371,171);ctx.lineTo(400,157);ctx.lineTo(431,143);ctx.lineTo(461,130);ctx.lineTo(491,119);ctx.lineTo(521,107);ctx.lineTo(552,96);ctx.lineTo(583,86);ctx.lineTo(615,77);ctx.lineTo(647,68);ctx.lineTo(679,61);ctx.lineTo(711,54);ctx.lineTo(743,47);ctx.lineTo(775,42);ctx.lineTo(807,38);ctx.lineTo(840,34);ctx.lineTo(873,31);ctx.lineTo(905,29);ctx.lineTo(938,27);ctx.lineTo(971,27);ctx.lineTo(971,583);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(971,583));listpt.Add(new Point(933,583));listpt.Add(new Point(895,586));listpt.Add(new Point(857,591));listpt.Add(new Point(819,598));listpt.Add(new Point(782,607));listpt.Add(new Point(745,617));listpt.Add(new Point(709,629));listpt.Add(new Point(673,643));listpt.Add(new Point(638,658));listpt.Add(new Point(603,675));listpt.Add(new Point(570,694));listpt.Add(new Point(537,713));listpt.Add(new Point(506,735));listpt.Add(new Point(475,758));listpt.Add(new Point(446,782));listpt.Add(new Point(418,807));listpt.Add(new Point(27,416));listpt.Add(new Point(50,394));listpt.Add(new Point(74,372));listpt.Add(new Point(99,351));listpt.Add(new Point(124,330));listpt.Add(new Point(150,310));listpt.Add(new Point(175,290));listpt.Add(new Point(202,271));listpt.Add(new Point(230,253));listpt.Add(new Point(256,235));listpt.Add(new Point(285,218));listpt.Add(new Point(313,202));listpt.Add(new Point(342,186));listpt.Add(new Point(371,171));listpt.Add(new Point(400,157));listpt.Add(new Point(431,143));listpt.Add(new Point(461,130));listpt.Add(new Point(491,119));listpt.Add(new Point(521,107));listpt.Add(new Point(552,96));listpt.Add(new Point(583,86));listpt.Add(new Point(615,77));listpt.Add(new Point(647,68));listpt.Add(new Point(679,61));listpt.Add(new Point(711,54));listpt.Add(new Point(743,47));listpt.Add(new Point(775,42));listpt.Add(new Point(807,38));listpt.Add(new Point(840,34));listpt.Add(new Point(873,31));listpt.Add(new Point(905,29));listpt.Add(new Point(938,27));listpt.Add(new Point(971,27));listpt.Add(new Point(971,583));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}