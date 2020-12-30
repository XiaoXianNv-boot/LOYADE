using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEDuct
{
    public class PIXIE_7cb2e5e6_7b3b_488c_999a_75dc827363fa : Pixie
    {
        public PIXIE_7cb2e5e6_7b3b_488c_999a_75dc827363fa()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 971f; _h = 807f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(971,252);ctx.lineTo(933,251);ctx.lineTo(895,248);ctx.lineTo(857,243);ctx.lineTo(819,237);ctx.lineTo(782,228);ctx.lineTo(745,217);ctx.lineTo(709,206);ctx.lineTo(673,191);ctx.lineTo(638,176);ctx.lineTo(603,159);ctx.lineTo(570,141);ctx.lineTo(537,121);ctx.lineTo(506,100);ctx.lineTo(475,77);ctx.lineTo(446,53);ctx.lineTo(418,27);ctx.lineTo(27,418);ctx.lineTo(50,440);ctx.lineTo(74,463);ctx.lineTo(99,484);ctx.lineTo(124,504);ctx.lineTo(150,525);ctx.lineTo(175,544);ctx.lineTo(202,563);ctx.lineTo(230,582);ctx.lineTo(256,599);ctx.lineTo(285,616);ctx.lineTo(313,632);ctx.lineTo(342,648);ctx.lineTo(371,663);ctx.lineTo(400,678);ctx.lineTo(431,691);ctx.lineTo(461,704);ctx.lineTo(491,716);ctx.lineTo(521,727);ctx.lineTo(552,738);ctx.lineTo(583,749);ctx.lineTo(615,758);ctx.lineTo(647,767);ctx.lineTo(679,774);ctx.lineTo(711,781);ctx.lineTo(743,787);ctx.lineTo(775,792);ctx.lineTo(807,797);ctx.lineTo(840,800);ctx.lineTo(873,804);ctx.lineTo(905,806);ctx.lineTo(938,807);ctx.lineTo(971,807);ctx.lineTo(971,252);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(971,252));listpt.Add(new Point(933,251));listpt.Add(new Point(895,248));listpt.Add(new Point(857,243));listpt.Add(new Point(819,237));listpt.Add(new Point(782,228));listpt.Add(new Point(745,217));listpt.Add(new Point(709,206));listpt.Add(new Point(673,191));listpt.Add(new Point(638,176));listpt.Add(new Point(603,159));listpt.Add(new Point(570,141));listpt.Add(new Point(537,121));listpt.Add(new Point(506,100));listpt.Add(new Point(475,77));listpt.Add(new Point(446,53));listpt.Add(new Point(418,27));listpt.Add(new Point(27,418));listpt.Add(new Point(50,440));listpt.Add(new Point(74,463));listpt.Add(new Point(99,484));listpt.Add(new Point(124,504));listpt.Add(new Point(150,525));listpt.Add(new Point(175,544));listpt.Add(new Point(202,563));listpt.Add(new Point(230,582));listpt.Add(new Point(256,599));listpt.Add(new Point(285,616));listpt.Add(new Point(313,632));listpt.Add(new Point(342,648));listpt.Add(new Point(371,663));listpt.Add(new Point(400,678));listpt.Add(new Point(431,691));listpt.Add(new Point(461,704));listpt.Add(new Point(491,716));listpt.Add(new Point(521,727));listpt.Add(new Point(552,738));listpt.Add(new Point(583,749));listpt.Add(new Point(615,758));listpt.Add(new Point(647,767));listpt.Add(new Point(679,774));listpt.Add(new Point(711,781));listpt.Add(new Point(743,787));listpt.Add(new Point(775,792));listpt.Add(new Point(807,797));listpt.Add(new Point(840,800));listpt.Add(new Point(873,804));listpt.Add(new Point(905,806));listpt.Add(new Point(938,807));listpt.Add(new Point(971,807));listpt.Add(new Point(971,252));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}