using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEPipe
{
    public class PIXIE_eb3ccb2e_34d1_4013_8e39_86a3fc514117 : Pixie
    {
        public PIXIE_eb3ccb2e_34d1_4013_8e39_86a3fc514117()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 741f; _h = 970f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(206,741);ctx.lineTo(206,652);ctx.lineTo(251,649);ctx.lineTo(296,643);ctx.lineTo(338,632);ctx.lineTo(379,617);ctx.lineTo(418,598);ctx.lineTo(455,576);ctx.lineTo(489,550);ctx.lineTo(521,521);ctx.lineTo(550,489);ctx.lineTo(576,455);ctx.lineTo(598,418);ctx.lineTo(617,379);ctx.lineTo(632,338);ctx.lineTo(643,296);ctx.lineTo(649,251);ctx.lineTo(652,229);ctx.lineTo(652,206);ctx.lineTo(741,206);ctx.lineTo(740,246);ctx.lineTo(735,285);ctx.lineTo(731,311);ctx.lineTo(725,337);ctx.lineTo(718,362);ctx.lineTo(711,386);ctx.lineTo(702,410);ctx.lineTo(691,433);ctx.lineTo(680,456);ctx.lineTo(668,478);ctx.lineTo(654,499);ctx.lineTo(632,530);ctx.lineTo(608,559);ctx.lineTo(588,580);ctx.lineTo(588,945);ctx.lineTo(639,945);ctx.lineTo(639,970);ctx.lineTo(435,970);ctx.lineTo(435,945);ctx.lineTo(486,945);ctx.lineTo(487,661);ctx.lineTo(460,676);ctx.lineTo(437,688);ctx.lineTo(412,699);ctx.lineTo(387,709);ctx.lineTo(361,718);ctx.lineTo(335,725);ctx.lineTo(308,731);ctx.lineTo(280,736);ctx.lineTo(253,739);ctx.lineTo(225,741);ctx.lineTo(215,741);ctx.lineTo(206,741);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(206,741));listpt.Add(new Point(206,652));listpt.Add(new Point(251,649));listpt.Add(new Point(296,643));listpt.Add(new Point(338,632));listpt.Add(new Point(379,617));listpt.Add(new Point(418,598));listpt.Add(new Point(455,576));listpt.Add(new Point(489,550));listpt.Add(new Point(521,521));listpt.Add(new Point(550,489));listpt.Add(new Point(576,455));listpt.Add(new Point(598,418));listpt.Add(new Point(617,379));listpt.Add(new Point(632,338));listpt.Add(new Point(643,296));listpt.Add(new Point(649,251));listpt.Add(new Point(652,229));listpt.Add(new Point(652,206));listpt.Add(new Point(741,206));listpt.Add(new Point(740,246));listpt.Add(new Point(735,285));listpt.Add(new Point(731,311));listpt.Add(new Point(725,337));listpt.Add(new Point(718,362));listpt.Add(new Point(711,386));listpt.Add(new Point(702,410));listpt.Add(new Point(691,433));listpt.Add(new Point(680,456));listpt.Add(new Point(668,478));listpt.Add(new Point(654,499));listpt.Add(new Point(632,530));listpt.Add(new Point(608,559));listpt.Add(new Point(588,580));listpt.Add(new Point(588,945));listpt.Add(new Point(639,945));listpt.Add(new Point(639,970));listpt.Add(new Point(435,970));listpt.Add(new Point(435,945));listpt.Add(new Point(486,945));listpt.Add(new Point(487,661));listpt.Add(new Point(460,676));listpt.Add(new Point(437,688));listpt.Add(new Point(412,699));listpt.Add(new Point(387,709));listpt.Add(new Point(361,718));listpt.Add(new Point(335,725));listpt.Add(new Point(308,731));listpt.Add(new Point(280,736));listpt.Add(new Point(253,739));listpt.Add(new Point(225,741));listpt.Add(new Point(215,741));listpt.Add(new Point(206,741));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}