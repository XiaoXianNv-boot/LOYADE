using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Arrow
{
    public class PIXIE_4baa7e6e_aa67_41ba_b70d_2976a60b475b : Pixie
    {
        public PIXIE_4baa7e6e_aa67_41ba_b70d_2976a60b475b()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 902f; _h = 970f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(902,92);ctx.lineTo(696,565);ctx.lineTo(589,379);ctx.lineTo(213,582);ctx.lineTo(213,970);ctx.lineTo(28,970);ctx.lineTo(28,484);ctx.lineTo(501,223);ctx.lineTo(389,28);ctx.lineTo(902,92);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(902,92));listpt.Add(new Point(696,565));listpt.Add(new Point(589,379));listpt.Add(new Point(213,582));listpt.Add(new Point(213,970));listpt.Add(new Point(28,970));listpt.Add(new Point(28,484));listpt.Add(new Point(501,223));listpt.Add(new Point(389,28));listpt.Add(new Point(902,92));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}