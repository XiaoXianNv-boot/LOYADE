using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_9f65e22c_93ac_4299_a403_fcd75ae628f1 : Pixie
    {
        public PIXIE_9f65e22c_93ac_4299_a403_fcd75ae628f1()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 802f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(307,188);ctx.lineTo(332,151);ctx.lineTo(357,119);ctx.lineTo(382,91);ctx.lineTo(406,69);ctx.lineTo(429,51);ctx.lineTo(452,38);ctx.lineTo(487,28);ctx.lineTo(499,28);ctx.lineTo(510,28);ctx.lineTo(545,37);ctx.lineTo(569,49);ctx.lineTo(592,67);ctx.lineTo(617,89);ctx.lineTo(642,117);ctx.lineTo(668,150);ctx.lineTo(695,188);ctx.lineTo(889,494);ctx.lineTo(915,536);ctx.lineTo(936,574);ctx.lineTo(951,608);ctx.lineTo(962,640);ctx.lineTo(969,668);ctx.lineTo(970,681);ctx.lineTo(970,693);ctx.lineTo(963,725);ctx.lineTo(944,751);ctx.lineTo(913,772);ctx.lineTo(886,782);ctx.lineTo(853,790);ctx.lineTo(815,796);ctx.lineTo(771,800);ctx.lineTo(722,802);ctx.lineTo(695,802);ctx.lineTo(305,802);ctx.lineTo(252,801);ctx.lineTo(205,798);ctx.lineTo(163,792);ctx.lineTo(128,784);ctx.lineTo(98,774);ctx.lineTo(73,762);ctx.lineTo(46,738);ctx.lineTo(31,708);ctx.lineTo(29,697);ctx.lineTo(28,685);ctx.lineTo(28,673);ctx.lineTo(32,645);ctx.lineTo(41,615);ctx.lineTo(55,583);ctx.lineTo(74,547);ctx.lineTo(97,508);ctx.lineTo(110,487);ctx.lineTo(307,188);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(307,188));listpt.Add(new Point(332,151));listpt.Add(new Point(357,119));listpt.Add(new Point(382,91));listpt.Add(new Point(406,69));listpt.Add(new Point(429,51));listpt.Add(new Point(452,38));listpt.Add(new Point(487,28));listpt.Add(new Point(499,28));listpt.Add(new Point(510,28));listpt.Add(new Point(545,37));listpt.Add(new Point(569,49));listpt.Add(new Point(592,67));listpt.Add(new Point(617,89));listpt.Add(new Point(642,117));listpt.Add(new Point(668,150));listpt.Add(new Point(695,188));listpt.Add(new Point(889,494));listpt.Add(new Point(915,536));listpt.Add(new Point(936,574));listpt.Add(new Point(951,608));listpt.Add(new Point(962,640));listpt.Add(new Point(969,668));listpt.Add(new Point(970,681));listpt.Add(new Point(970,693));listpt.Add(new Point(963,725));listpt.Add(new Point(944,751));listpt.Add(new Point(913,772));listpt.Add(new Point(886,782));listpt.Add(new Point(853,790));listpt.Add(new Point(815,796));listpt.Add(new Point(771,800));listpt.Add(new Point(722,802));listpt.Add(new Point(695,802));listpt.Add(new Point(305,802));listpt.Add(new Point(252,801));listpt.Add(new Point(205,798));listpt.Add(new Point(163,792));listpt.Add(new Point(128,784));listpt.Add(new Point(98,774));listpt.Add(new Point(73,762));listpt.Add(new Point(46,738));listpt.Add(new Point(31,708));listpt.Add(new Point(29,697));listpt.Add(new Point(28,685));listpt.Add(new Point(28,673));listpt.Add(new Point(32,645));listpt.Add(new Point(41,615));listpt.Add(new Point(55,583));listpt.Add(new Point(74,547));listpt.Add(new Point(97,508));listpt.Add(new Point(110,487));listpt.Add(new Point(307,188));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}