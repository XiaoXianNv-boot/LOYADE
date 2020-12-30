using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_fb593968_b96c_49fb_b32a_5beb1d72592c : Pixie
    {
        public PIXIE_fb593968_b96c_49fb_b32a_5beb1d72592c()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 970f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,970);ctx.lineTo(970,970);ctx.lineTo(969,922);ctx.lineTo(965,874);ctx.lineTo(959,827);ctx.lineTo(951,781);ctx.lineTo(941,735);ctx.lineTo(928,691);ctx.lineTo(913,647);ctx.lineTo(896,604);ctx.lineTo(877,562);ctx.lineTo(856,521);ctx.lineTo(834,482);ctx.lineTo(809,444);ctx.lineTo(783,407);ctx.lineTo(755,371);ctx.lineTo(725,337);ctx.lineTo(694,304);ctx.lineTo(661,273);ctx.lineTo(627,243);ctx.lineTo(591,215);ctx.lineTo(554,189);ctx.lineTo(516,164);ctx.lineTo(477,142);ctx.lineTo(436,121);ctx.lineTo(394,102);ctx.lineTo(351,85);ctx.lineTo(307,70);ctx.lineTo(263,57);ctx.lineTo(217,47);ctx.lineTo(171,39);ctx.lineTo(124,33);ctx.lineTo(76,29);ctx.lineTo(28,28);ctx.lineTo(28,970);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,970));listpt.Add(new Point(970,970));listpt.Add(new Point(969,922));listpt.Add(new Point(965,874));listpt.Add(new Point(959,827));listpt.Add(new Point(951,781));listpt.Add(new Point(941,735));listpt.Add(new Point(928,691));listpt.Add(new Point(913,647));listpt.Add(new Point(896,604));listpt.Add(new Point(877,562));listpt.Add(new Point(856,521));listpt.Add(new Point(834,482));listpt.Add(new Point(809,444));listpt.Add(new Point(783,407));listpt.Add(new Point(755,371));listpt.Add(new Point(725,337));listpt.Add(new Point(694,304));listpt.Add(new Point(661,273));listpt.Add(new Point(627,243));listpt.Add(new Point(591,215));listpt.Add(new Point(554,189));listpt.Add(new Point(516,164));listpt.Add(new Point(477,142));listpt.Add(new Point(436,121));listpt.Add(new Point(394,102));listpt.Add(new Point(351,85));listpt.Add(new Point(307,70));listpt.Add(new Point(263,57));listpt.Add(new Point(217,47));listpt.Add(new Point(171,39));listpt.Add(new Point(124,33));listpt.Add(new Point(76,29));listpt.Add(new Point(28,28));listpt.Add(new Point(28,970));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}