using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEControlEquipment
{
    public class PIXIE_67295118_656e_4393_86e8_cda938060f51 : Pixie
    {
        public PIXIE_67295118_656e_4393_86e8_cda938060f51()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 813f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,813);ctx.lineTo(71,813);ctx.lineTo(114,811);ctx.lineTo(156,809);ctx.lineTo(197,806);ctx.lineTo(237,802);ctx.lineTo(276,797);ctx.lineTo(315,791);ctx.lineTo(352,785);ctx.lineTo(388,778);ctx.lineTo(424,769);ctx.lineTo(458,761);ctx.lineTo(492,751);ctx.lineTo(524,741);ctx.lineTo(556,730);ctx.lineTo(587,718);ctx.lineTo(617,705);ctx.lineTo(646,692);ctx.lineTo(674,678);ctx.lineTo(701,664);ctx.lineTo(727,648);ctx.lineTo(753,633);ctx.lineTo(777,616);ctx.lineTo(800,599);ctx.lineTo(823,581);ctx.lineTo(845,563);ctx.lineTo(865,544);ctx.lineTo(885,525);ctx.lineTo(904,505);ctx.lineTo(922,485);ctx.lineTo(939,464);ctx.lineTo(955,442);ctx.lineTo(970,420);ctx.lineTo(955,398);ctx.lineTo(939,377);ctx.lineTo(922,356);ctx.lineTo(904,336);ctx.lineTo(885,316);ctx.lineTo(865,297);ctx.lineTo(845,278);ctx.lineTo(823,260);ctx.lineTo(800,242);ctx.lineTo(777,225);ctx.lineTo(753,208);ctx.lineTo(727,193);ctx.lineTo(701,177);ctx.lineTo(674,163);ctx.lineTo(646,149);ctx.lineTo(617,136);ctx.lineTo(587,123);ctx.lineTo(556,111);ctx.lineTo(524,100);ctx.lineTo(492,90);ctx.lineTo(458,80);ctx.lineTo(424,71);ctx.lineTo(388,63);ctx.lineTo(352,56);ctx.lineTo(315,49);ctx.lineTo(276,44);ctx.lineTo(237,39);ctx.lineTo(197,35);ctx.lineTo(156,32);ctx.lineTo(114,30);ctx.lineTo(71,28);ctx.lineTo(28,28);ctx.lineTo(49,50);ctx.lineTo(69,73);ctx.lineTo(88,96);ctx.lineTo(105,120);ctx.lineTo(121,143);ctx.lineTo(136,168);ctx.lineTo(149,192);ctx.lineTo(160,217);ctx.lineTo(171,242);ctx.lineTo(180,267);ctx.lineTo(187,292);ctx.lineTo(193,318);ctx.lineTo(202,369);ctx.lineTo(205,420);ctx.lineTo(202,472);ctx.lineTo(193,523);ctx.lineTo(187,549);ctx.lineTo(180,574);ctx.lineTo(171,599);ctx.lineTo(160,624);ctx.lineTo(149,649);ctx.lineTo(136,673);ctx.lineTo(121,698);ctx.lineTo(105,721);ctx.lineTo(88,745);ctx.lineTo(69,768);ctx.lineTo(49,791);ctx.lineTo(28,813);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,813));listpt.Add(new Point(71,813));listpt.Add(new Point(114,811));listpt.Add(new Point(156,809));listpt.Add(new Point(197,806));listpt.Add(new Point(237,802));listpt.Add(new Point(276,797));listpt.Add(new Point(315,791));listpt.Add(new Point(352,785));listpt.Add(new Point(388,778));listpt.Add(new Point(424,769));listpt.Add(new Point(458,761));listpt.Add(new Point(492,751));listpt.Add(new Point(524,741));listpt.Add(new Point(556,730));listpt.Add(new Point(587,718));listpt.Add(new Point(617,705));listpt.Add(new Point(646,692));listpt.Add(new Point(674,678));listpt.Add(new Point(701,664));listpt.Add(new Point(727,648));listpt.Add(new Point(753,633));listpt.Add(new Point(777,616));listpt.Add(new Point(800,599));listpt.Add(new Point(823,581));listpt.Add(new Point(845,563));listpt.Add(new Point(865,544));listpt.Add(new Point(885,525));listpt.Add(new Point(904,505));listpt.Add(new Point(922,485));listpt.Add(new Point(939,464));listpt.Add(new Point(955,442));listpt.Add(new Point(970,420));listpt.Add(new Point(955,398));listpt.Add(new Point(939,377));listpt.Add(new Point(922,356));listpt.Add(new Point(904,336));listpt.Add(new Point(885,316));listpt.Add(new Point(865,297));listpt.Add(new Point(845,278));listpt.Add(new Point(823,260));listpt.Add(new Point(800,242));listpt.Add(new Point(777,225));listpt.Add(new Point(753,208));listpt.Add(new Point(727,193));listpt.Add(new Point(701,177));listpt.Add(new Point(674,163));listpt.Add(new Point(646,149));listpt.Add(new Point(617,136));listpt.Add(new Point(587,123));listpt.Add(new Point(556,111));listpt.Add(new Point(524,100));listpt.Add(new Point(492,90));listpt.Add(new Point(458,80));listpt.Add(new Point(424,71));listpt.Add(new Point(388,63));listpt.Add(new Point(352,56));listpt.Add(new Point(315,49));listpt.Add(new Point(276,44));listpt.Add(new Point(237,39));listpt.Add(new Point(197,35));listpt.Add(new Point(156,32));listpt.Add(new Point(114,30));listpt.Add(new Point(71,28));listpt.Add(new Point(28,28));listpt.Add(new Point(49,50));listpt.Add(new Point(69,73));listpt.Add(new Point(88,96));listpt.Add(new Point(105,120));listpt.Add(new Point(121,143));listpt.Add(new Point(136,168));listpt.Add(new Point(149,192));listpt.Add(new Point(160,217));listpt.Add(new Point(171,242));listpt.Add(new Point(180,267));listpt.Add(new Point(187,292));listpt.Add(new Point(193,318));listpt.Add(new Point(202,369));listpt.Add(new Point(205,420));listpt.Add(new Point(202,472));listpt.Add(new Point(193,523));listpt.Add(new Point(187,549));listpt.Add(new Point(180,574));listpt.Add(new Point(171,599));listpt.Add(new Point(160,624));listpt.Add(new Point(149,649));listpt.Add(new Point(136,673));listpt.Add(new Point(121,698));listpt.Add(new Point(105,721));listpt.Add(new Point(88,745));listpt.Add(new Point(69,768));listpt.Add(new Point(49,791));listpt.Add(new Point(28,813));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}