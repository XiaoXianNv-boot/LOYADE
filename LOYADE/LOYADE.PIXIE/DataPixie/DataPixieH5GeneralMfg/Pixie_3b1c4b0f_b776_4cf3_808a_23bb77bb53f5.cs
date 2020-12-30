using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_3b1c4b0f_b776_4cf3_808a_23bb77bb53f5 : Pixie
    {
        public PIXIE_3b1c4b0f_b776_4cf3_808a_23bb77bb53f5()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 386f; _h = 261f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(269,58);ctx.lineTo(267,49);ctx.lineTo(262,41);ctx.lineTo(254,36);ctx.lineTo(245,34);ctx.lineTo(236,36);ctx.lineTo(229,41);ctx.lineTo(224,49);ctx.lineTo(222,58);ctx.lineTo(222,89);ctx.lineTo(238,261);ctx.lineTo(167,261);ctx.lineTo(175,89);ctx.lineTo(175,58);ctx.lineTo(173,49);ctx.lineTo(168,41);ctx.lineTo(161,36);ctx.lineTo(152,34);ctx.lineTo(143,36);ctx.lineTo(135,41);ctx.lineTo(130,49);ctx.lineTo(128,58);ctx.lineTo(128,89);ctx.lineTo(81,261);ctx.lineTo(11,261);ctx.lineTo(11,89);ctx.lineTo(89,89);ctx.lineTo(89,11);ctx.lineTo(308,11);ctx.lineTo(308,89);ctx.lineTo(386,89);ctx.lineTo(386,261);ctx.lineTo(316,261);ctx.lineTo(269,89);ctx.lineTo(269,58);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(269,58));listpt.Add(new Point(267,49));listpt.Add(new Point(262,41));listpt.Add(new Point(254,36));listpt.Add(new Point(245,34));listpt.Add(new Point(236,36));listpt.Add(new Point(229,41));listpt.Add(new Point(224,49));listpt.Add(new Point(222,58));listpt.Add(new Point(222,89));listpt.Add(new Point(238,261));listpt.Add(new Point(167,261));listpt.Add(new Point(175,89));listpt.Add(new Point(175,58));listpt.Add(new Point(173,49));listpt.Add(new Point(168,41));listpt.Add(new Point(161,36));listpt.Add(new Point(152,34));listpt.Add(new Point(143,36));listpt.Add(new Point(135,41));listpt.Add(new Point(130,49));listpt.Add(new Point(128,58));listpt.Add(new Point(128,89));listpt.Add(new Point(81,261));listpt.Add(new Point(11,261));listpt.Add(new Point(11,89));listpt.Add(new Point(89,89));listpt.Add(new Point(89,11));listpt.Add(new Point(308,11));listpt.Add(new Point(308,89));listpt.Add(new Point(386,89));listpt.Add(new Point(386,261));listpt.Add(new Point(316,261));listpt.Add(new Point(269,89));listpt.Add(new Point(269,58));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}