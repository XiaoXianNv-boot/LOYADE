using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEDuct
{
    public class PIXIE_6fc1bff4_b224_4c27_b36a_25b6739db563 : Pixie
    {
        public PIXIE_6fc1bff4_b224_4c27_b36a_25b6739db563()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 971f; _h = 807f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(27,252);ctx.lineTo(65,251);ctx.lineTo(103,248);ctx.lineTo(141,243);ctx.lineTo(179,237);ctx.lineTo(216,228);ctx.lineTo(253,217);ctx.lineTo(289,206);ctx.lineTo(325,191);ctx.lineTo(360,176);ctx.lineTo(395,159);ctx.lineTo(428,141);ctx.lineTo(461,121);ctx.lineTo(492,100);ctx.lineTo(523,77);ctx.lineTo(552,53);ctx.lineTo(580,27);ctx.lineTo(971,418);ctx.lineTo(948,440);ctx.lineTo(924,463);ctx.lineTo(899,484);ctx.lineTo(874,504);ctx.lineTo(848,525);ctx.lineTo(823,544);ctx.lineTo(796,563);ctx.lineTo(768,582);ctx.lineTo(742,599);ctx.lineTo(713,616);ctx.lineTo(685,632);ctx.lineTo(656,648);ctx.lineTo(627,663);ctx.lineTo(598,678);ctx.lineTo(567,691);ctx.lineTo(538,704);ctx.lineTo(507,716);ctx.lineTo(477,727);ctx.lineTo(446,738);ctx.lineTo(415,749);ctx.lineTo(383,758);ctx.lineTo(351,767);ctx.lineTo(319,774);ctx.lineTo(287,781);ctx.lineTo(255,787);ctx.lineTo(223,792);ctx.lineTo(191,797);ctx.lineTo(158,800);ctx.lineTo(125,804);ctx.lineTo(93,806);ctx.lineTo(60,807);ctx.lineTo(27,807);ctx.lineTo(27,252);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(27,252));listpt.Add(new Point(65,251));listpt.Add(new Point(103,248));listpt.Add(new Point(141,243));listpt.Add(new Point(179,237));listpt.Add(new Point(216,228));listpt.Add(new Point(253,217));listpt.Add(new Point(289,206));listpt.Add(new Point(325,191));listpt.Add(new Point(360,176));listpt.Add(new Point(395,159));listpt.Add(new Point(428,141));listpt.Add(new Point(461,121));listpt.Add(new Point(492,100));listpt.Add(new Point(523,77));listpt.Add(new Point(552,53));listpt.Add(new Point(580,27));listpt.Add(new Point(971,418));listpt.Add(new Point(948,440));listpt.Add(new Point(924,463));listpt.Add(new Point(899,484));listpt.Add(new Point(874,504));listpt.Add(new Point(848,525));listpt.Add(new Point(823,544));listpt.Add(new Point(796,563));listpt.Add(new Point(768,582));listpt.Add(new Point(742,599));listpt.Add(new Point(713,616));listpt.Add(new Point(685,632));listpt.Add(new Point(656,648));listpt.Add(new Point(627,663));listpt.Add(new Point(598,678));listpt.Add(new Point(567,691));listpt.Add(new Point(538,704));listpt.Add(new Point(507,716));listpt.Add(new Point(477,727));listpt.Add(new Point(446,738));listpt.Add(new Point(415,749));listpt.Add(new Point(383,758));listpt.Add(new Point(351,767));listpt.Add(new Point(319,774));listpt.Add(new Point(287,781));listpt.Add(new Point(255,787));listpt.Add(new Point(223,792));listpt.Add(new Point(191,797));listpt.Add(new Point(158,800));listpt.Add(new Point(125,804));listpt.Add(new Point(93,806));listpt.Add(new Point(60,807));listpt.Add(new Point(27,807));listpt.Add(new Point(27,252));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}