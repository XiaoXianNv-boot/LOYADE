using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Blower
{
    public class PIXIE_a508e210_8d00_4fd5_8fc9_6b57b6e44ca3 : Pixie
    {
        public PIXIE_a508e210_8d00_4fd5_8fc9_6b57b6e44ca3()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#8ca0bf"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 799f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#8ca0bf'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(799,413);ctx.lineTo(797,453);ctx.lineTo(791,491);ctx.lineTo(781,528);ctx.lineTo(768,563);ctx.lineTo(752,597);ctx.lineTo(733,629);ctx.lineTo(711,658);ctx.lineTo(686,686);ctx.lineTo(658,711);ctx.lineTo(629,733);ctx.lineTo(597,752);ctx.lineTo(563,768);ctx.lineTo(528,781);ctx.lineTo(491,791);ctx.lineTo(453,797);ctx.lineTo(433,799);ctx.lineTo(413,799);ctx.lineTo(393,799);ctx.lineTo(355,795);ctx.lineTo(317,787);ctx.lineTo(281,776);ctx.lineTo(246,761);ctx.lineTo(213,743);ctx.lineTo(183,722);ctx.lineTo(154,699);ctx.lineTo(128,672);ctx.lineTo(104,644);ctx.lineTo(83,613);ctx.lineTo(66,580);ctx.lineTo(51,546);ctx.lineTo(40,510);ctx.lineTo(32,472);ctx.lineTo(28,433);ctx.lineTo(28,413);ctx.lineTo(28,393);ctx.lineTo(32,355);ctx.lineTo(40,317);ctx.lineTo(51,281);ctx.lineTo(66,246);ctx.lineTo(83,214);ctx.lineTo(104,183);ctx.lineTo(128,154);ctx.lineTo(154,128);ctx.lineTo(183,104);ctx.lineTo(213,83);ctx.lineTo(246,66);ctx.lineTo(281,51);ctx.lineTo(317,40);ctx.lineTo(355,32);ctx.lineTo(393,28);ctx.lineTo(413,28);ctx.lineTo(970,28);ctx.lineTo(970,413);ctx.lineTo(799,413);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(413,413,214,0,Math.PI*2,true);ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(799,413));listpt.Add(new Point(797,453));listpt.Add(new Point(791,491));listpt.Add(new Point(781,528));listpt.Add(new Point(768,563));listpt.Add(new Point(752,597));listpt.Add(new Point(733,629));listpt.Add(new Point(711,658));listpt.Add(new Point(686,686));listpt.Add(new Point(658,711));listpt.Add(new Point(629,733));listpt.Add(new Point(597,752));listpt.Add(new Point(563,768));listpt.Add(new Point(528,781));listpt.Add(new Point(491,791));listpt.Add(new Point(453,797));listpt.Add(new Point(433,799));listpt.Add(new Point(413,799));listpt.Add(new Point(393,799));listpt.Add(new Point(355,795));listpt.Add(new Point(317,787));listpt.Add(new Point(281,776));listpt.Add(new Point(246,761));listpt.Add(new Point(213,743));listpt.Add(new Point(183,722));listpt.Add(new Point(154,699));listpt.Add(new Point(128,672));listpt.Add(new Point(104,644));listpt.Add(new Point(83,613));listpt.Add(new Point(66,580));listpt.Add(new Point(51,546));listpt.Add(new Point(40,510));listpt.Add(new Point(32,472));listpt.Add(new Point(28,433));listpt.Add(new Point(28,413));listpt.Add(new Point(28,393));listpt.Add(new Point(32,355));listpt.Add(new Point(40,317));listpt.Add(new Point(51,281));listpt.Add(new Point(66,246));listpt.Add(new Point(83,214));listpt.Add(new Point(104,183));listpt.Add(new Point(128,154));listpt.Add(new Point(154,128));listpt.Add(new Point(183,104));listpt.Add(new Point(213,83));listpt.Add(new Point(246,66));listpt.Add(new Point(281,51));listpt.Add(new Point(317,40));listpt.Add(new Point(355,32));listpt.Add(new Point(393,28));listpt.Add(new Point(413,28));listpt.Add(new Point(970,28));listpt.Add(new Point(970,413));listpt.Add(new Point(799,413));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.DrawEllipse(p, 199f,199f,428f,428f);
        }
    }
}