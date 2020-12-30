using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_66615349_3b3a_4979_b789_8f81ac55a76e : Pixie
    {
        public PIXIE_66615349_3b3a_4979_b789_8f81ac55a76e()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 157f; _h = 257f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(145,123);ctx.lineTo(140,129);ctx.lineTo(134,135);ctx.lineTo(128,140);ctx.lineTo(123,145);ctx.lineTo(117,151);ctx.lineTo(113,158);ctx.lineTo(109,165);ctx.lineTo(107,174);ctx.lineTo(90,249);ctx.lineTo(88,254);ctx.lineTo(85,256);ctx.lineTo(82,257);ctx.lineTo(79,256);ctx.lineTo(76,254);ctx.lineTo(74,249);ctx.lineTo(72,240);ctx.lineTo(70,230);ctx.lineTo(68,221);ctx.lineTo(66,211);ctx.lineTo(63,202);ctx.lineTo(61,193);ctx.lineTo(59,183);ctx.lineTo(57,174);ctx.lineTo(52,165);ctx.lineTo(47,158);ctx.lineTo(43,151);ctx.lineTo(38,146);ctx.lineTo(34,140);ctx.lineTo(29,135);ctx.lineTo(25,130);ctx.lineTo(20,124);ctx.lineTo(17,119);ctx.lineTo(15,114);ctx.lineTo(12,109);ctx.lineTo(9,99);ctx.lineTo(8,93);ctx.lineTo(7,88);ctx.lineTo(7,82);ctx.lineTo(9,67);ctx.lineTo(13,53);ctx.lineTo(20,40);ctx.lineTo(29,29);ctx.lineTo(40,20);ctx.lineTo(53,13);ctx.lineTo(67,9);ctx.lineTo(82,7);ctx.lineTo(97,9);ctx.lineTo(111,13);ctx.lineTo(124,20);ctx.lineTo(135,29);ctx.lineTo(144,40);ctx.lineTo(151,53);ctx.lineTo(155,67);ctx.lineTo(157,82);ctx.lineTo(157,87);ctx.lineTo(156,93);ctx.lineTo(154,103);ctx.lineTo(150,113);ctx.lineTo(148,118);ctx.lineTo(145,123);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(145,123));listpt.Add(new Point(140,129));listpt.Add(new Point(134,135));listpt.Add(new Point(128,140));listpt.Add(new Point(123,145));listpt.Add(new Point(117,151));listpt.Add(new Point(113,158));listpt.Add(new Point(109,165));listpt.Add(new Point(107,174));listpt.Add(new Point(90,249));listpt.Add(new Point(88,254));listpt.Add(new Point(85,256));listpt.Add(new Point(82,257));listpt.Add(new Point(79,256));listpt.Add(new Point(76,254));listpt.Add(new Point(74,249));listpt.Add(new Point(72,240));listpt.Add(new Point(70,230));listpt.Add(new Point(68,221));listpt.Add(new Point(66,211));listpt.Add(new Point(63,202));listpt.Add(new Point(61,193));listpt.Add(new Point(59,183));listpt.Add(new Point(57,174));listpt.Add(new Point(52,165));listpt.Add(new Point(47,158));listpt.Add(new Point(43,151));listpt.Add(new Point(38,146));listpt.Add(new Point(34,140));listpt.Add(new Point(29,135));listpt.Add(new Point(25,130));listpt.Add(new Point(20,124));listpt.Add(new Point(17,119));listpt.Add(new Point(15,114));listpt.Add(new Point(12,109));listpt.Add(new Point(9,99));listpt.Add(new Point(8,93));listpt.Add(new Point(7,88));listpt.Add(new Point(7,82));listpt.Add(new Point(9,67));listpt.Add(new Point(13,53));listpt.Add(new Point(20,40));listpt.Add(new Point(29,29));listpt.Add(new Point(40,20));listpt.Add(new Point(53,13));listpt.Add(new Point(67,9));listpt.Add(new Point(82,7));listpt.Add(new Point(97,9));listpt.Add(new Point(111,13));listpt.Add(new Point(124,20));listpt.Add(new Point(135,29));listpt.Add(new Point(144,40));listpt.Add(new Point(151,53));listpt.Add(new Point(155,67));listpt.Add(new Point(157,82));listpt.Add(new Point(157,87));listpt.Add(new Point(156,93));listpt.Add(new Point(154,103));listpt.Add(new Point(150,113));listpt.Add(new Point(148,118));listpt.Add(new Point(145,123));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}