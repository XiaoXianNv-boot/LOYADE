using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_3acfc469_054d_4458_802e_bbe85e80e34d : Pixie
    {
        public PIXIE_3acfc469_054d_4458_802e_bbe85e80e34d()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 291f; _h = 258f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(149,140);ctx.lineTo(26,140);ctx.lineTo(19,142);ctx.lineTo(10,151);ctx.lineTo(8,158);ctx.lineTo(8,168);ctx.lineTo(8,240);ctx.lineTo(10,247);ctx.lineTo(19,256);ctx.lineTo(26,258);ctx.lineTo(41,258);ctx.lineTo(273,258);ctx.lineTo(280,256);ctx.lineTo(289,247);ctx.lineTo(291,240);ctx.lineTo(291,230);ctx.lineTo(291,158);ctx.lineTo(290,152);ctx.lineTo(287,147);ctx.lineTo(282,143);ctx.lineTo(276,140);ctx.lineTo(256,132);ctx.lineTo(236,124);ctx.lineTo(216,116);ctx.lineTo(197,108);ctx.lineTo(177,100);ctx.lineTo(157,91);ctx.lineTo(137,83);ctx.lineTo(117,75);ctx.lineTo(115,79);ctx.lineTo(110,88);ctx.lineTo(108,93);ctx.lineTo(128,101);ctx.lineTo(148,109);ctx.lineTo(168,117);ctx.lineTo(188,125);ctx.lineTo(207,134);ctx.lineTo(227,142);ctx.lineTo(247,150);ctx.lineTo(267,158);ctx.lineTo(271,160);ctx.lineTo(273,164);ctx.lineTo(273,234);ctx.lineTo(271,238);ctx.lineTo(267,240);ctx.lineTo(32,240);ctx.lineTo(28,238);ctx.lineTo(26,234);ctx.lineTo(26,164);ctx.lineTo(28,160);ctx.lineTo(32,158);ctx.lineTo(149,158);ctx.lineTo(149,140);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(137,34);ctx.lineTo(115,34);ctx.lineTo(150,69);ctx.lineTo(185,34);ctx.lineTo(163,34);ctx.lineTo(163,8);ctx.lineTo(137,8);ctx.lineTo(137,34);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(149,140));listpt.Add(new Point(26,140));listpt.Add(new Point(19,142));listpt.Add(new Point(10,151));listpt.Add(new Point(8,158));listpt.Add(new Point(8,168));listpt.Add(new Point(8,240));listpt.Add(new Point(10,247));listpt.Add(new Point(19,256));listpt.Add(new Point(26,258));listpt.Add(new Point(41,258));listpt.Add(new Point(273,258));listpt.Add(new Point(280,256));listpt.Add(new Point(289,247));listpt.Add(new Point(291,240));listpt.Add(new Point(291,230));listpt.Add(new Point(291,158));listpt.Add(new Point(290,152));listpt.Add(new Point(287,147));listpt.Add(new Point(282,143));listpt.Add(new Point(276,140));listpt.Add(new Point(256,132));listpt.Add(new Point(236,124));listpt.Add(new Point(216,116));listpt.Add(new Point(197,108));listpt.Add(new Point(177,100));listpt.Add(new Point(157,91));listpt.Add(new Point(137,83));listpt.Add(new Point(117,75));listpt.Add(new Point(115,79));listpt.Add(new Point(110,88));listpt.Add(new Point(108,93));listpt.Add(new Point(128,101));listpt.Add(new Point(148,109));listpt.Add(new Point(168,117));listpt.Add(new Point(188,125));listpt.Add(new Point(207,134));listpt.Add(new Point(227,142));listpt.Add(new Point(247,150));listpt.Add(new Point(267,158));listpt.Add(new Point(271,160));listpt.Add(new Point(273,164));listpt.Add(new Point(273,234));listpt.Add(new Point(271,238));listpt.Add(new Point(267,240));listpt.Add(new Point(32,240));listpt.Add(new Point(28,238));listpt.Add(new Point(26,234));listpt.Add(new Point(26,164));listpt.Add(new Point(28,160));listpt.Add(new Point(32,158));listpt.Add(new Point(149,158));listpt.Add(new Point(149,140));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(137,34));listpt.Add(new Point(115,34));listpt.Add(new Point(150,69));listpt.Add(new Point(185,34));listpt.Add(new Point(163,34));listpt.Add(new Point(163,8));listpt.Add(new Point(137,8));listpt.Add(new Point(137,34));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}