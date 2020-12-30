using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_7d7ac0de_c170_4604_8f79_b351f5afe82f : Pixie
    {
        public PIXIE_7d7ac0de_c170_4604_8f79_b351f5afe82f()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 681f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(434,32);ctx.lineTo(895,274);ctx.lineTo(923,290);ctx.lineTo(947,306);ctx.lineTo(965,328);ctx.lineTo(970,357);ctx.lineTo(963,386);ctx.lineTo(944,410);ctx.lineTo(918,428);ctx.lineTo(891,444);ctx.lineTo(455,673);ctx.lineTo(433,681);ctx.lineTo(397,676);ctx.lineTo(386,666);ctx.lineTo(381,652);ctx.lineTo(384,636);ctx.lineTo(396,620);ctx.lineTo(417,605);ctx.lineTo(782,408);ctx.lineTo(96,408);ctx.lineTo(66,404);ctx.lineTo(45,393);ctx.lineTo(31,379);ctx.lineTo(28,361);ctx.lineTo(31,345);ctx.lineTo(44,330);ctx.lineTo(66,320);ctx.lineTo(96,316);ctx.lineTo(782,316);ctx.lineTo(408,108);ctx.lineTo(378,78);ctx.lineTo(379,48);ctx.lineTo(388,36);ctx.lineTo(401,29);ctx.lineTo(416,28);ctx.lineTo(434,32);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(434,32));listpt.Add(new Point(895,274));listpt.Add(new Point(923,290));listpt.Add(new Point(947,306));listpt.Add(new Point(965,328));listpt.Add(new Point(970,357));listpt.Add(new Point(963,386));listpt.Add(new Point(944,410));listpt.Add(new Point(918,428));listpt.Add(new Point(891,444));listpt.Add(new Point(455,673));listpt.Add(new Point(433,681));listpt.Add(new Point(397,676));listpt.Add(new Point(386,666));listpt.Add(new Point(381,652));listpt.Add(new Point(384,636));listpt.Add(new Point(396,620));listpt.Add(new Point(417,605));listpt.Add(new Point(782,408));listpt.Add(new Point(96,408));listpt.Add(new Point(66,404));listpt.Add(new Point(45,393));listpt.Add(new Point(31,379));listpt.Add(new Point(28,361));listpt.Add(new Point(31,345));listpt.Add(new Point(44,330));listpt.Add(new Point(66,320));listpt.Add(new Point(96,316));listpt.Add(new Point(782,316));listpt.Add(new Point(408,108));listpt.Add(new Point(378,78));listpt.Add(new Point(379,48));listpt.Add(new Point(388,36));listpt.Add(new Point(401,29));listpt.Add(new Point(416,28));listpt.Add(new Point(434,32));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}