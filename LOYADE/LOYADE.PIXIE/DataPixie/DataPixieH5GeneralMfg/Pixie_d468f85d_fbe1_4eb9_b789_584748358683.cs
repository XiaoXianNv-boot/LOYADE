using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_d468f85d_fbe1_4eb9_b789_584748358683 : Pixie
    {
        public PIXIE_d468f85d_fbe1_4eb9_b789_584748358683()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 320f; _h = 259f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(41,231);ctx.lineTo(35,224);ctx.lineTo(31,218);ctx.lineTo(29,211);ctx.lineTo(27,204);ctx.lineTo(25,211);ctx.lineTo(23,218);ctx.lineTo(19,224);ctx.lineTo(13,231);ctx.lineTo(11,233);ctx.lineTo(10,236);ctx.lineTo(9,239);ctx.lineTo(9,241);ctx.lineTo(10,248);ctx.lineTo(14,254);ctx.lineTo(20,258);ctx.lineTo(27,259);ctx.lineTo(33,258);ctx.lineTo(39,254);ctx.lineTo(43,248);ctx.lineTo(44,241);ctx.lineTo(44,239);ctx.lineTo(43,236);ctx.lineTo(42,234);ctx.lineTo(41,231);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(298,134);ctx.lineTo(301,126);ctx.lineTo(303,118);ctx.lineTo(304,107);ctx.lineTo(304,103);ctx.lineTo(302,87);ctx.lineTo(298,73);ctx.lineTo(291,59);ctx.lineTo(281,47);ctx.lineTo(270,38);ctx.lineTo(256,30);ctx.lineTo(242,26);ctx.lineTo(226,24);ctx.lineTo(210,26);ctx.lineTo(196,30);ctx.lineTo(182,38);ctx.lineTo(171,47);ctx.lineTo(161,59);ctx.lineTo(154,73);ctx.lineTo(150,87);ctx.lineTo(148,103);ctx.lineTo(149,112);ctx.lineTo(150,122);ctx.lineTo(15,158);ctx.lineTo(11,143);ctx.lineTo(132,110);ctx.lineTo(132,103);ctx.lineTo(134,84);ctx.lineTo(139,66);ctx.lineTo(148,50);ctx.lineTo(160,36);ctx.lineTo(173,25);ctx.lineTo(189,16);ctx.lineTo(207,11);ctx.lineTo(226,9);ctx.lineTo(245,11);ctx.lineTo(263,16);ctx.lineTo(279,25);ctx.lineTo(293,36);ctx.lineTo(304,50);ctx.lineTo(313,66);ctx.lineTo(318,84);ctx.lineTo(320,103);ctx.lineTo(318,122);ctx.lineTo(313,139);ctx.lineTo(304,155);ctx.lineTo(293,169);ctx.lineTo(279,180);ctx.lineTo(263,189);ctx.lineTo(245,194);ctx.lineTo(226,196);ctx.lineTo(216,195);ctx.lineTo(207,194);ctx.lineTo(197,192);ctx.lineTo(188,188);ctx.lineTo(179,184);ctx.lineTo(171,179);ctx.lineTo(163,173);ctx.lineTo(156,166);ctx.lineTo(27,203);ctx.lineTo(23,188);ctx.lineTo(154,134);ctx.lineTo(298,134);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(41,231));listpt.Add(new Point(35,224));listpt.Add(new Point(31,218));listpt.Add(new Point(29,211));listpt.Add(new Point(27,204));listpt.Add(new Point(25,211));listpt.Add(new Point(23,218));listpt.Add(new Point(19,224));listpt.Add(new Point(13,231));listpt.Add(new Point(11,233));listpt.Add(new Point(10,236));listpt.Add(new Point(9,239));listpt.Add(new Point(9,241));listpt.Add(new Point(10,248));listpt.Add(new Point(14,254));listpt.Add(new Point(20,258));listpt.Add(new Point(27,259));listpt.Add(new Point(33,258));listpt.Add(new Point(39,254));listpt.Add(new Point(43,248));listpt.Add(new Point(44,241));listpt.Add(new Point(44,239));listpt.Add(new Point(43,236));listpt.Add(new Point(42,234));listpt.Add(new Point(41,231));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(298,134));listpt.Add(new Point(301,126));listpt.Add(new Point(303,118));listpt.Add(new Point(304,107));listpt.Add(new Point(304,103));listpt.Add(new Point(302,87));listpt.Add(new Point(298,73));listpt.Add(new Point(291,59));listpt.Add(new Point(281,47));listpt.Add(new Point(270,38));listpt.Add(new Point(256,30));listpt.Add(new Point(242,26));listpt.Add(new Point(226,24));listpt.Add(new Point(210,26));listpt.Add(new Point(196,30));listpt.Add(new Point(182,38));listpt.Add(new Point(171,47));listpt.Add(new Point(161,59));listpt.Add(new Point(154,73));listpt.Add(new Point(150,87));listpt.Add(new Point(148,103));listpt.Add(new Point(149,112));listpt.Add(new Point(150,122));listpt.Add(new Point(15,158));listpt.Add(new Point(11,143));listpt.Add(new Point(132,110));listpt.Add(new Point(132,103));listpt.Add(new Point(134,84));listpt.Add(new Point(139,66));listpt.Add(new Point(148,50));listpt.Add(new Point(160,36));listpt.Add(new Point(173,25));listpt.Add(new Point(189,16));listpt.Add(new Point(207,11));listpt.Add(new Point(226,9));listpt.Add(new Point(245,11));listpt.Add(new Point(263,16));listpt.Add(new Point(279,25));listpt.Add(new Point(293,36));listpt.Add(new Point(304,50));listpt.Add(new Point(313,66));listpt.Add(new Point(318,84));listpt.Add(new Point(320,103));listpt.Add(new Point(318,122));listpt.Add(new Point(313,139));listpt.Add(new Point(304,155));listpt.Add(new Point(293,169));listpt.Add(new Point(279,180));listpt.Add(new Point(263,189));listpt.Add(new Point(245,194));listpt.Add(new Point(226,196));listpt.Add(new Point(216,195));listpt.Add(new Point(207,194));listpt.Add(new Point(197,192));listpt.Add(new Point(188,188));listpt.Add(new Point(179,184));listpt.Add(new Point(171,179));listpt.Add(new Point(163,173));listpt.Add(new Point(156,166));listpt.Add(new Point(27,203));listpt.Add(new Point(23,188));listpt.Add(new Point(154,134));listpt.Add(new Point(298,134));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}