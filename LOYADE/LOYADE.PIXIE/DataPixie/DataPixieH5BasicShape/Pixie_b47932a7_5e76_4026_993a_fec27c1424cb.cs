using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5BasicShape
{
    public class PIXIE_b47932a7_5e76_4026_993a_fec27c1424cb : Pixie
    {
        public PIXIE_b47932a7_5e76_4026_993a_fec27c1424cb()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 609f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,28);ctx.lineTo(970,28);ctx.lineTo(970,581);ctx.lineTo(956,575);ctx.lineTo(926,563);ctx.lineTo(897,554);ctx.lineTo(867,546);ctx.lineTo(838,539);ctx.lineTo(808,534);ctx.lineTo(779,531);ctx.lineTo(749,529);ctx.lineTo(720,529);ctx.lineTo(690,531);ctx.lineTo(661,534);ctx.lineTo(632,539);ctx.lineTo(602,546);ctx.lineTo(573,554);ctx.lineTo(543,563);ctx.lineTo(514,575);ctx.lineTo(484,587);ctx.lineTo(455,597);ctx.lineTo(425,604);ctx.lineTo(396,608);ctx.lineTo(381,609);ctx.lineTo(366,609);ctx.lineTo(352,609);ctx.lineTo(322,608);ctx.lineTo(293,604);ctx.lineTo(263,598);ctx.lineTo(234,591);ctx.lineTo(205,582);ctx.lineTo(175,572);ctx.lineTo(146,561);ctx.lineTo(116,550);ctx.lineTo(87,537);ctx.lineTo(57,525);ctx.lineTo(42,518);ctx.lineTo(28,512);ctx.lineTo(28,28);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,28));listpt.Add(new Point(970,28));listpt.Add(new Point(970,581));listpt.Add(new Point(956,575));listpt.Add(new Point(926,563));listpt.Add(new Point(897,554));listpt.Add(new Point(867,546));listpt.Add(new Point(838,539));listpt.Add(new Point(808,534));listpt.Add(new Point(779,531));listpt.Add(new Point(749,529));listpt.Add(new Point(720,529));listpt.Add(new Point(690,531));listpt.Add(new Point(661,534));listpt.Add(new Point(632,539));listpt.Add(new Point(602,546));listpt.Add(new Point(573,554));listpt.Add(new Point(543,563));listpt.Add(new Point(514,575));listpt.Add(new Point(484,587));listpt.Add(new Point(455,597));listpt.Add(new Point(425,604));listpt.Add(new Point(396,608));listpt.Add(new Point(381,609));listpt.Add(new Point(366,609));listpt.Add(new Point(352,609));listpt.Add(new Point(322,608));listpt.Add(new Point(293,604));listpt.Add(new Point(263,598));listpt.Add(new Point(234,591));listpt.Add(new Point(205,582));listpt.Add(new Point(175,572));listpt.Add(new Point(146,561));listpt.Add(new Point(116,550));listpt.Add(new Point(87,537));listpt.Add(new Point(57,525));listpt.Add(new Point(42,518));listpt.Add(new Point(28,512));listpt.Add(new Point(28,28));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}