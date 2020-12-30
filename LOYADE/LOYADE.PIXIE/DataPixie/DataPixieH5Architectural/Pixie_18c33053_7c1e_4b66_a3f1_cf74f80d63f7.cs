using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Architectural
{
    public class PIXIE_18c33053_7c1e_4b66_a3f1_cf74f80d63f7 : Pixie
    {
        public PIXIE_18c33053_7c1e_4b66_a3f1_cf74f80d63f7()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#98b2e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 648f; _h = 755f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#98b2e5'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(574,209);ctx.lineTo(545,184);ctx.lineTo(524,170);ctx.lineTo(502,158);ctx.lineTo(478,148);ctx.lineTo(454,141);ctx.lineTo(416,134);ctx.lineTo(377,133);ctx.lineTo(338,138);ctx.lineTo(313,144);ctx.lineTo(289,153);ctx.lineTo(267,164);ctx.lineTo(245,177);ctx.lineTo(216,200);ctx.lineTo(190,227);ctx.lineTo(168,258);ctx.lineTo(156,280);ctx.lineTo(146,303);ctx.lineTo(138,327);ctx.lineTo(133,353);ctx.lineTo(130,392);ctx.lineTo(130,755);ctx.lineTo(28,755);ctx.lineTo(28,392);ctx.lineTo(29,355);ctx.lineTo(35,319);ctx.lineTo(44,284);ctx.lineTo(56,251);ctx.lineTo(71,219);ctx.lineTo(89,189);ctx.lineTo(110,161);ctx.lineTo(134,134);ctx.lineTo(160,111);ctx.lineTo(187,90);ctx.lineTo(217,72);ctx.lineTo(249,56);ctx.lineTo(282,44);ctx.lineTo(317,35);ctx.lineTo(353,29);ctx.lineTo(372,28);ctx.lineTo(390,28);ctx.lineTo(399,28);ctx.lineTo(435,30);ctx.lineTo(461,35);ctx.lineTo(487,41);ctx.lineTo(513,49);ctx.lineTo(538,60);ctx.lineTo(562,71);ctx.lineTo(585,85);ctx.lineTo(607,100);ctx.lineTo(628,116);ctx.lineTo(642,128);ctx.lineTo(648,134);ctx.lineTo(574,209);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(574,209));listpt.Add(new Point(545,184));listpt.Add(new Point(524,170));listpt.Add(new Point(502,158));listpt.Add(new Point(478,148));listpt.Add(new Point(454,141));listpt.Add(new Point(416,134));listpt.Add(new Point(377,133));listpt.Add(new Point(338,138));listpt.Add(new Point(313,144));listpt.Add(new Point(289,153));listpt.Add(new Point(267,164));listpt.Add(new Point(245,177));listpt.Add(new Point(216,200));listpt.Add(new Point(190,227));listpt.Add(new Point(168,258));listpt.Add(new Point(156,280));listpt.Add(new Point(146,303));listpt.Add(new Point(138,327));listpt.Add(new Point(133,353));listpt.Add(new Point(130,392));listpt.Add(new Point(130,755));listpt.Add(new Point(28,755));listpt.Add(new Point(28,392));listpt.Add(new Point(29,355));listpt.Add(new Point(35,319));listpt.Add(new Point(44,284));listpt.Add(new Point(56,251));listpt.Add(new Point(71,219));listpt.Add(new Point(89,189));listpt.Add(new Point(110,161));listpt.Add(new Point(134,134));listpt.Add(new Point(160,111));listpt.Add(new Point(187,90));listpt.Add(new Point(217,72));listpt.Add(new Point(249,56));listpt.Add(new Point(282,44));listpt.Add(new Point(317,35));listpt.Add(new Point(353,29));listpt.Add(new Point(372,28));listpt.Add(new Point(390,28));listpt.Add(new Point(399,28));listpt.Add(new Point(435,30));listpt.Add(new Point(461,35));listpt.Add(new Point(487,41));listpt.Add(new Point(513,49));listpt.Add(new Point(538,60));listpt.Add(new Point(562,71));listpt.Add(new Point(585,85));listpt.Add(new Point(607,100));listpt.Add(new Point(628,116));listpt.Add(new Point(642,128));listpt.Add(new Point(648,134));listpt.Add(new Point(574,209));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}