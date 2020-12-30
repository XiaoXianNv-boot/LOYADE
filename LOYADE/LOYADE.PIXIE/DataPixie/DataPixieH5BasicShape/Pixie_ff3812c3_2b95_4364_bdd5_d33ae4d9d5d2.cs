using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_ff3812c3_2b95_4364_bdd5_d33ae4d9d5d2 : Pixie
    {
        public PIXIE_ff3812c3_2b95_4364_bdd5_d33ae4d9d5d2()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 770f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(970,692);ctx.lineTo(970,103);ctx.lineTo(949,127);ctx.lineTo(924,138);ctx.lineTo(890,147);ctx.lineTo(863,154);ctx.lineTo(832,159);ctx.lineTo(799,164);ctx.lineTo(762,169);ctx.lineTo(723,172);ctx.lineTo(682,176);ctx.lineTo(639,178);ctx.lineTo(594,180);ctx.lineTo(547,182);ctx.lineTo(499,182);ctx.lineTo(451,182);ctx.lineTo(404,180);ctx.lineTo(359,178);ctx.lineTo(316,176);ctx.lineTo(275,172);ctx.lineTo(236,169);ctx.lineTo(199,164);ctx.lineTo(166,159);ctx.lineTo(135,154);ctx.lineTo(108,147);ctx.lineTo(74,138);ctx.lineTo(49,127);ctx.lineTo(28,108);ctx.lineTo(28,103);ctx.lineTo(28,694);ctx.lineTo(49,717);ctx.lineTo(74,727);ctx.lineTo(108,736);ctx.lineTo(135,742);ctx.lineTo(166,748);ctx.lineTo(199,752);ctx.lineTo(236,757);ctx.lineTo(275,761);ctx.lineTo(316,764);ctx.lineTo(359,767);ctx.lineTo(404,769);ctx.lineTo(451,770);ctx.lineTo(475,770);ctx.lineTo(499,770);ctx.lineTo(523,770);ctx.lineTo(570,769);ctx.lineTo(617,768);ctx.lineTo(661,765);ctx.lineTo(703,762);ctx.lineTo(743,759);ctx.lineTo(781,755);ctx.lineTo(816,750);ctx.lineTo(848,745);ctx.lineTo(876,739);ctx.lineTo(902,733);ctx.lineTo(933,723);ctx.lineTo(961,708);ctx.lineTo(970,696);ctx.lineTo(970,692);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(6.116883,1);ctx.arc(81.57749,105,77,0,Math.PI*2,true);ctx.scale(0.163482,1);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(970,692));listpt.Add(new Point(970,103));listpt.Add(new Point(949,127));listpt.Add(new Point(924,138));listpt.Add(new Point(890,147));listpt.Add(new Point(863,154));listpt.Add(new Point(832,159));listpt.Add(new Point(799,164));listpt.Add(new Point(762,169));listpt.Add(new Point(723,172));listpt.Add(new Point(682,176));listpt.Add(new Point(639,178));listpt.Add(new Point(594,180));listpt.Add(new Point(547,182));listpt.Add(new Point(499,182));listpt.Add(new Point(451,182));listpt.Add(new Point(404,180));listpt.Add(new Point(359,178));listpt.Add(new Point(316,176));listpt.Add(new Point(275,172));listpt.Add(new Point(236,169));listpt.Add(new Point(199,164));listpt.Add(new Point(166,159));listpt.Add(new Point(135,154));listpt.Add(new Point(108,147));listpt.Add(new Point(74,138));listpt.Add(new Point(49,127));listpt.Add(new Point(28,108));listpt.Add(new Point(28,103));listpt.Add(new Point(28,694));listpt.Add(new Point(49,717));listpt.Add(new Point(74,727));listpt.Add(new Point(108,736));listpt.Add(new Point(135,742));listpt.Add(new Point(166,748));listpt.Add(new Point(199,752));listpt.Add(new Point(236,757));listpt.Add(new Point(275,761));listpt.Add(new Point(316,764));listpt.Add(new Point(359,767));listpt.Add(new Point(404,769));listpt.Add(new Point(451,770));listpt.Add(new Point(475,770));listpt.Add(new Point(499,770));listpt.Add(new Point(523,770));listpt.Add(new Point(570,769));listpt.Add(new Point(617,768));listpt.Add(new Point(661,765));listpt.Add(new Point(703,762));listpt.Add(new Point(743,759));listpt.Add(new Point(781,755));listpt.Add(new Point(816,750));listpt.Add(new Point(848,745));listpt.Add(new Point(876,739));listpt.Add(new Point(902,733));listpt.Add(new Point(933,723));listpt.Add(new Point(961,708));listpt.Add(new Point(970,696));listpt.Add(new Point(970,692));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 4.577492f,28f,154f,154f);g.DrawEllipse(p, 4.577492f,28f,154f,154f);
        }
    }
}