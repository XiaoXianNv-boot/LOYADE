using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5FlowMeter
{
    public class PIXIE_d7f8f30b_8de1_4125_9019_0e497cc15182 : Pixie
    {
        public PIXIE_d7f8f30b_8de1_4125_9019_0e497cc15182()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 467f; _h = 519f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#7f7f7f'; arrFillColor[1] = '#b2b2b2'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(467,360);ctx.lineTo(467,144);ctx.lineTo(448,144);ctx.lineTo(428,145);ctx.lineTo(407,146);ctx.lineTo(388,146);ctx.lineTo(362,145);ctx.lineTo(336,144);ctx.lineTo(310,141);ctx.lineTo(285,137);ctx.lineTo(260,132);ctx.lineTo(236,126);ctx.lineTo(213,119);ctx.lineTo(190,110);ctx.lineTo(168,102);ctx.lineTo(147,92);ctx.lineTo(127,81);ctx.lineTo(108,69);ctx.lineTo(90,57);ctx.lineTo(74,44);ctx.lineTo(59,30);ctx.lineTo(45,15);ctx.lineTo(15,41);ctx.lineTo(36,92);ctx.lineTo(59,138);ctx.lineTo(83,179);ctx.lineTo(108,216);ctx.lineTo(134,248);ctx.lineTo(160,277);ctx.lineTo(188,301);ctx.lineTo(215,322);ctx.lineTo(243,340);ctx.lineTo(271,355);ctx.lineTo(300,366);ctx.lineTo(328,376);ctx.lineTo(356,382);ctx.lineTo(384,387);ctx.lineTo(411,389);ctx.lineTo(438,390);ctx.lineTo(447,380);ctx.lineTo(458,369);ctx.lineTo(467,360);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(437,390);ctx.lineTo(437,174);ctx.lineTo(418,174);ctx.lineTo(398,175);ctx.lineTo(377,176);ctx.lineTo(358,176);ctx.lineTo(332,175);ctx.lineTo(306,174);ctx.lineTo(280,171);ctx.lineTo(255,167);ctx.lineTo(230,162);ctx.lineTo(206,155);ctx.lineTo(183,148);ctx.lineTo(160,140);ctx.lineTo(138,131);ctx.lineTo(117,121);ctx.lineTo(97,110);ctx.lineTo(78,99);ctx.lineTo(60,86);ctx.lineTo(44,73);ctx.lineTo(29,59);ctx.lineTo(15,45);ctx.lineTo(16,519);ctx.lineTo(30,504);ctx.lineTo(45,490);ctx.lineTo(62,477);ctx.lineTo(79,465);ctx.lineTo(98,453);ctx.lineTo(118,442);ctx.lineTo(139,432);ctx.lineTo(161,423);ctx.lineTo(183,415);ctx.lineTo(207,408);ctx.lineTo(231,402);ctx.lineTo(255,396);ctx.lineTo(280,392);ctx.lineTo(306,389);ctx.lineTo(332,388);ctx.lineTo(358,387);ctx.lineTo(377,387);ctx.lineTo(398,388);ctx.lineTo(418,389);ctx.lineTo(437,390);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(467,360));listpt.Add(new Point(467,144));listpt.Add(new Point(448,144));listpt.Add(new Point(428,145));listpt.Add(new Point(407,146));listpt.Add(new Point(388,146));listpt.Add(new Point(362,145));listpt.Add(new Point(336,144));listpt.Add(new Point(310,141));listpt.Add(new Point(285,137));listpt.Add(new Point(260,132));listpt.Add(new Point(236,126));listpt.Add(new Point(213,119));listpt.Add(new Point(190,110));listpt.Add(new Point(168,102));listpt.Add(new Point(147,92));listpt.Add(new Point(127,81));listpt.Add(new Point(108,69));listpt.Add(new Point(90,57));listpt.Add(new Point(74,44));listpt.Add(new Point(59,30));listpt.Add(new Point(45,15));listpt.Add(new Point(15,41));listpt.Add(new Point(36,92));listpt.Add(new Point(59,138));listpt.Add(new Point(83,179));listpt.Add(new Point(108,216));listpt.Add(new Point(134,248));listpt.Add(new Point(160,277));listpt.Add(new Point(188,301));listpt.Add(new Point(215,322));listpt.Add(new Point(243,340));listpt.Add(new Point(271,355));listpt.Add(new Point(300,366));listpt.Add(new Point(328,376));listpt.Add(new Point(356,382));listpt.Add(new Point(384,387));listpt.Add(new Point(411,389));listpt.Add(new Point(438,390));listpt.Add(new Point(447,380));listpt.Add(new Point(458,369));listpt.Add(new Point(467,360));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(437,390));listpt.Add(new Point(437,174));listpt.Add(new Point(418,174));listpt.Add(new Point(398,175));listpt.Add(new Point(377,176));listpt.Add(new Point(358,176));listpt.Add(new Point(332,175));listpt.Add(new Point(306,174));listpt.Add(new Point(280,171));listpt.Add(new Point(255,167));listpt.Add(new Point(230,162));listpt.Add(new Point(206,155));listpt.Add(new Point(183,148));listpt.Add(new Point(160,140));listpt.Add(new Point(138,131));listpt.Add(new Point(117,121));listpt.Add(new Point(97,110));listpt.Add(new Point(78,99));listpt.Add(new Point(60,86));listpt.Add(new Point(44,73));listpt.Add(new Point(29,59));listpt.Add(new Point(15,45));listpt.Add(new Point(16,519));listpt.Add(new Point(30,504));listpt.Add(new Point(45,490));listpt.Add(new Point(62,477));listpt.Add(new Point(79,465));listpt.Add(new Point(98,453));listpt.Add(new Point(118,442));listpt.Add(new Point(139,432));listpt.Add(new Point(161,423));listpt.Add(new Point(183,415));listpt.Add(new Point(207,408));listpt.Add(new Point(231,402));listpt.Add(new Point(255,396));listpt.Add(new Point(280,392));listpt.Add(new Point(306,389));listpt.Add(new Point(332,388));listpt.Add(new Point(358,387));listpt.Add(new Point(377,387));listpt.Add(new Point(398,388));listpt.Add(new Point(418,389));listpt.Add(new Point(437,390));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}