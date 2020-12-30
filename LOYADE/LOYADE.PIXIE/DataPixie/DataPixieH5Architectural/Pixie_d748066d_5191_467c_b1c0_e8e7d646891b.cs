using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Architectural
{
    public class PIXIE_d748066d_5191_467c_b1c0_e8e7d646891b : Pixie
    {
        public PIXIE_d748066d_5191_467c_b1c0_e8e7d646891b()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#ccc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 287f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#e5e5e5'; arrFillColor[1] = '#ccc'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,264);ctx.lineTo(59,264);ctx.lineTo(90,264);ctx.lineTo(120,264);ctx.lineTo(939,264);ctx.lineTo(970,264);ctx.lineTo(970,287);ctx.lineTo(939,287);ctx.lineTo(909,287);ctx.lineTo(878,287);ctx.lineTo(59,287);ctx.lineTo(28,287);ctx.lineTo(28,264);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(950,264);ctx.lineTo(970,264);ctx.lineTo(961,218);ctx.lineTo(934,174);ctx.lineTo(891,132);ctx.lineTo(832,97);ctx.lineTo(760,68);ctx.lineTo(679,46);ctx.lineTo(590,32);ctx.lineTo(499,28);ctx.lineTo(406,32);ctx.lineTo(318,46);ctx.lineTo(236,68);ctx.lineTo(165,97);ctx.lineTo(106,133);ctx.lineTo(63,173);ctx.lineTo(36,218);ctx.lineTo(28,264);ctx.lineTo(48,264);ctx.lineTo(55,220);ctx.lineTo(81,177);ctx.lineTo(122,138);ctx.lineTo(180,103);ctx.lineTo(247,76);ctx.lineTo(326,55);ctx.lineTo(410,42);ctx.lineTo(499,38);ctx.lineTo(587,42);ctx.lineTo(671,55);ctx.lineTo(751,76);ctx.lineTo(818,103);ctx.lineTo(875,138);ctx.lineTo(917,177);ctx.lineTo(943,220);ctx.lineTo(950,264);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,264));listpt.Add(new Point(59,264));listpt.Add(new Point(90,264));listpt.Add(new Point(120,264));listpt.Add(new Point(939,264));listpt.Add(new Point(970,264));listpt.Add(new Point(970,287));listpt.Add(new Point(939,287));listpt.Add(new Point(909,287));listpt.Add(new Point(878,287));listpt.Add(new Point(59,287));listpt.Add(new Point(28,287));listpt.Add(new Point(28,264));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(950,264));listpt.Add(new Point(970,264));listpt.Add(new Point(961,218));listpt.Add(new Point(934,174));listpt.Add(new Point(891,132));listpt.Add(new Point(832,97));listpt.Add(new Point(760,68));listpt.Add(new Point(679,46));listpt.Add(new Point(590,32));listpt.Add(new Point(499,28));listpt.Add(new Point(406,32));listpt.Add(new Point(318,46));listpt.Add(new Point(236,68));listpt.Add(new Point(165,97));listpt.Add(new Point(106,133));listpt.Add(new Point(63,173));listpt.Add(new Point(36,218));listpt.Add(new Point(28,264));listpt.Add(new Point(48,264));listpt.Add(new Point(55,220));listpt.Add(new Point(81,177));listpt.Add(new Point(122,138));listpt.Add(new Point(180,103));listpt.Add(new Point(247,76));listpt.Add(new Point(326,55));listpt.Add(new Point(410,42));listpt.Add(new Point(499,38));listpt.Add(new Point(587,42));listpt.Add(new Point(671,55));listpt.Add(new Point(751,76));listpt.Add(new Point(818,103));listpt.Add(new Point(875,138));listpt.Add(new Point(917,177));listpt.Add(new Point(943,220));listpt.Add(new Point(950,264));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}