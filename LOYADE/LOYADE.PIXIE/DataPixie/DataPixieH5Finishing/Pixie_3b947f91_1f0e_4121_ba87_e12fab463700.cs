using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Finishing
{
    public class PIXIE_3b947f91_1f0e_4121_ba87_e12fab463700 : Pixie
    {
        public PIXIE_3b947f91_1f0e_4121_ba87_e12fab463700()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#8c0000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f0000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#900"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c0000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f0000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#8c0000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#900"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#4c0000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f0000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#bf0000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 868f; _h = 786f;
_content = "var arrFillColor = new Array(9); var arrBorderColor = new Array(9); var arrBorderWidth = new Array(9); arrFillColor[0] = '#8c0000'; arrFillColor[1] = '#7f0000'; arrFillColor[2] = '#900'; arrFillColor[3] = '#4c0000'; arrFillColor[4] = '#7f0000'; arrFillColor[5] = '#8c0000'; arrFillColor[6] = '#900'; arrFillColor[7] = '#7f0000'; arrFillColor[8] = '#bf0000'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderColor[6] = '#4c0000'; arrBorderColor[7] = '#000'; arrBorderColor[8] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; arrBorderWidth[6] = '2'; arrBorderWidth[7] = '2'; arrBorderWidth[8] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(242,191);ctx.lineTo(357,191);ctx.lineTo(357,294);ctx.lineTo(242,294);ctx.lineTo(242,191);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(376,252);ctx.lineTo(417,252);ctx.lineTo(417,294);ctx.lineTo(376,294);ctx.lineTo(376,252);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(396,273);ctx.lineTo(828,273);ctx.lineTo(828,294);ctx.lineTo(396,294);ctx.lineTo(396,273);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(151,744);ctx.lineTo(807,744);ctx.lineTo(807,786);ctx.lineTo(151,786);ctx.lineTo(151,744);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(37,315);ctx.lineTo(130,315);ctx.lineTo(130,756);ctx.lineTo(37,756);ctx.lineTo(37,315);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(766,561,41,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(849,436);ctx.lineTo(868,436);ctx.lineTo(868,683);ctx.lineTo(849,683);ctx.lineTo(849,436);ctx.fillStyle = arrFillColor[6];ctx.fill();ctx.lineWidth = arrBorderWidth[6];ctx.strokeStyle = arrBorderColor[6];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(37,315);ctx.lineTo(28,315);ctx.lineTo(28,765);ctx.lineTo(37,765);ctx.lineTo(37,315);ctx.fillStyle = arrFillColor[7];ctx.fill();ctx.lineWidth = arrBorderWidth[7];ctx.strokeStyle = arrBorderColor[7];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(457,273);ctx.lineTo(622,233);ctx.lineTo(643,233);ctx.lineTo(643,273);ctx.lineTo(622,273);ctx.lineTo(622,242);ctx.lineTo(489,273);ctx.lineTo(457,273);ctx.fillStyle = arrFillColor[8];ctx.fill();ctx.lineWidth = arrBorderWidth[8];ctx.strokeStyle = arrBorderColor[8];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(242,191));listpt.Add(new Point(357,191));listpt.Add(new Point(357,294));listpt.Add(new Point(242,294));listpt.Add(new Point(242,191));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(376,252));listpt.Add(new Point(417,252));listpt.Add(new Point(417,294));listpt.Add(new Point(376,294));listpt.Add(new Point(376,252));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(396,273));listpt.Add(new Point(828,273));listpt.Add(new Point(828,294));listpt.Add(new Point(396,294));listpt.Add(new Point(396,273));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(151,744));listpt.Add(new Point(807,744));listpt.Add(new Point(807,786));listpt.Add(new Point(151,786));listpt.Add(new Point(151,744));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(37,315));listpt.Add(new Point(130,315));listpt.Add(new Point(130,756));listpt.Add(new Point(37,756));listpt.Add(new Point(37,315));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillEllipse(sb, 725f,520f,82f,82f);g.DrawEllipse(p, 725f,520f,82f,82f);
listpt = new List<Point>();listpt.Add(new Point(849,436));listpt.Add(new Point(868,436));listpt.Add(new Point(868,683));listpt.Add(new Point(849,683));listpt.Add(new Point(849,436));sb = new SolidBrush(_listfillcolor[6]);p = new Pen(Color.Black);p.Width = _listborderwidth[6];p.Color = _listbordercolor[6];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(37,315));listpt.Add(new Point(28,315));listpt.Add(new Point(28,765));listpt.Add(new Point(37,765));listpt.Add(new Point(37,315));sb = new SolidBrush(_listfillcolor[7]);p = new Pen(Color.Black);p.Width = _listborderwidth[7];p.Color = _listbordercolor[7];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(457,273));listpt.Add(new Point(622,233));listpt.Add(new Point(643,233));listpt.Add(new Point(643,273));listpt.Add(new Point(622,273));listpt.Add(new Point(622,242));listpt.Add(new Point(489,273));listpt.Add(new Point(457,273));sb = new SolidBrush(_listfillcolor[8]);p = new Pen(Color.Black);p.Width = _listborderwidth[8];p.Color = _listbordercolor[8];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}