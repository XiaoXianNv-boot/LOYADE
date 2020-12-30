using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Blower
{
    public class PIXIE_ad2a9c6c_231e_4488_b2b8_96d37ad4b8da : Pixie
    {
        public PIXIE_ad2a9c6c_231e_4488_b2b8_96d37ad4b8da()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#033"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#194c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#033"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#699"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 700f; _h = 473f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#033'; arrFillColor[1] = '#194c4c'; arrFillColor[2] = '#033'; arrFillColor[3] = '#699'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(254,109);ctx.lineTo(376,109);ctx.lineTo(376,332);ctx.lineTo(254,332);ctx.lineTo(254,109);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(569,96);ctx.lineTo(560,90);ctx.lineTo(555,82);ctx.lineTo(552,71);ctx.lineTo(552,68);ctx.lineTo(551,65);ctx.lineTo(551,62);ctx.lineTo(552,52);ctx.lineTo(555,43);ctx.lineTo(559,35);ctx.lineTo(567,29);ctx.lineTo(572,28);ctx.lineTo(574,28);ctx.lineTo(576,28);ctx.lineTo(584,32);ctx.lineTo(590,40);ctx.lineTo(594,48);ctx.lineTo(595,58);ctx.lineTo(595,62);ctx.lineTo(595,65);ctx.lineTo(594,76);ctx.lineTo(590,85);ctx.lineTo(586,92);ctx.lineTo(578,97);ctx.lineTo(576,98);ctx.lineTo(574,98);ctx.lineTo(574,88);ctx.lineTo(579,87);ctx.lineTo(584,77);ctx.lineTo(586,67);ctx.lineTo(586,57);ctx.lineTo(584,48);ctx.lineTo(579,39);ctx.lineTo(574,37);ctx.lineTo(567,41);ctx.lineTo(562,52);ctx.lineTo(561,62);ctx.lineTo(562,74);ctx.lineTo(567,84);ctx.lineTo(571,88);ctx.lineTo(569,96);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(456,123);ctx.lineTo(700,123);ctx.lineTo(700,473);ctx.lineTo(456,473);ctx.lineTo(456,123);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(464,281);ctx.lineTo(691,281);ctx.lineTo(691,315);ctx.lineTo(464,315);ctx.lineTo(464,281);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(254,109));listpt.Add(new Point(376,109));listpt.Add(new Point(376,332));listpt.Add(new Point(254,332));listpt.Add(new Point(254,109));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(569,96));listpt.Add(new Point(560,90));listpt.Add(new Point(555,82));listpt.Add(new Point(552,71));listpt.Add(new Point(552,68));listpt.Add(new Point(551,65));listpt.Add(new Point(551,62));listpt.Add(new Point(552,52));listpt.Add(new Point(555,43));listpt.Add(new Point(559,35));listpt.Add(new Point(567,29));listpt.Add(new Point(572,28));listpt.Add(new Point(574,28));listpt.Add(new Point(576,28));listpt.Add(new Point(584,32));listpt.Add(new Point(590,40));listpt.Add(new Point(594,48));listpt.Add(new Point(595,58));listpt.Add(new Point(595,62));listpt.Add(new Point(595,65));listpt.Add(new Point(594,76));listpt.Add(new Point(590,85));listpt.Add(new Point(586,92));listpt.Add(new Point(578,97));listpt.Add(new Point(576,98));listpt.Add(new Point(574,98));listpt.Add(new Point(574,88));listpt.Add(new Point(579,87));listpt.Add(new Point(584,77));listpt.Add(new Point(586,67));listpt.Add(new Point(586,57));listpt.Add(new Point(584,48));listpt.Add(new Point(579,39));listpt.Add(new Point(574,37));listpt.Add(new Point(567,41));listpt.Add(new Point(562,52));listpt.Add(new Point(561,62));listpt.Add(new Point(562,74));listpt.Add(new Point(567,84));listpt.Add(new Point(571,88));listpt.Add(new Point(569,96));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(456,123));listpt.Add(new Point(700,123));listpt.Add(new Point(700,473));listpt.Add(new Point(456,473));listpt.Add(new Point(456,123));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(464,281));listpt.Add(new Point(691,281));listpt.Add(new Point(691,315));listpt.Add(new Point(464,315));listpt.Add(new Point(464,281));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}