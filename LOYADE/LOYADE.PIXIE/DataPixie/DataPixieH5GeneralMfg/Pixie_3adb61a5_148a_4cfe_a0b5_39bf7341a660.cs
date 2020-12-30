using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_3adb61a5_148a_4cfe_a0b5_39bf7341a660 : Pixie
    {
        public PIXIE_3adb61a5_148a_4cfe_a0b5_39bf7341a660()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#161717"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#161717"));
_w = 386f; _h = 261f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#161717'; arrBorderColor[1] = '#161717'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(269,198);ctx.lineTo(152,11);ctx.lineTo(11,11);ctx.lineTo(11,104);ctx.lineTo(269,198);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(11,198);ctx.lineTo(269,198);ctx.lineTo(269,167);ctx.lineTo(270,145);ctx.lineTo(274,127);ctx.lineTo(281,111);ctx.lineTo(289,98);ctx.lineTo(300,88);ctx.lineTo(312,79);ctx.lineTo(325,71);ctx.lineTo(339,65);ctx.lineTo(344,75);ctx.lineTo(350,86);ctx.lineTo(354,95);ctx.lineTo(355,96);ctx.lineTo(342,104);ctx.lineTo(331,112);ctx.lineTo(323,119);ctx.lineTo(313,134);ctx.lineTo(310,143);ctx.lineTo(308,154);ctx.lineTo(308,167);ctx.lineTo(386,167);ctx.lineTo(386,260);ctx.lineTo(11,261);ctx.lineTo(11,198);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(269,198));listpt.Add(new Point(152,11));listpt.Add(new Point(11,11));listpt.Add(new Point(11,104));listpt.Add(new Point(269,198));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(11,198));listpt.Add(new Point(269,198));listpt.Add(new Point(269,167));listpt.Add(new Point(270,145));listpt.Add(new Point(274,127));listpt.Add(new Point(281,111));listpt.Add(new Point(289,98));listpt.Add(new Point(300,88));listpt.Add(new Point(312,79));listpt.Add(new Point(325,71));listpt.Add(new Point(339,65));listpt.Add(new Point(344,75));listpt.Add(new Point(350,86));listpt.Add(new Point(354,95));listpt.Add(new Point(355,96));listpt.Add(new Point(342,104));listpt.Add(new Point(331,112));listpt.Add(new Point(323,119));listpt.Add(new Point(313,134));listpt.Add(new Point(310,143));listpt.Add(new Point(308,154));listpt.Add(new Point(308,167));listpt.Add(new Point(386,167));listpt.Add(new Point(386,260));listpt.Add(new Point(11,261));listpt.Add(new Point(11,198));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}