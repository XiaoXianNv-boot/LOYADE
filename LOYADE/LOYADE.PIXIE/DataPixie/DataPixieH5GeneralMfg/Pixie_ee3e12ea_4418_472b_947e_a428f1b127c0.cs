using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_ee3e12ea_4418_472b_947e_a428f1b127c0 : Pixie
    {
        public PIXIE_ee3e12ea_4418_472b_947e_a428f1b127c0()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 386f; _h = 238f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(347,27);ctx.lineTo(353,29);ctx.lineTo(355,35);ctx.lineTo(355,105);ctx.lineTo(42,105);ctx.lineTo(42,35);ctx.lineTo(45,29);ctx.lineTo(50,27);ctx.lineTo(199,27);ctx.lineTo(199,11);ctx.lineTo(42,11);ctx.lineTo(37,12);ctx.lineTo(28,21);ctx.lineTo(27,36);ctx.lineTo(27,102);ctx.lineTo(26,104);ctx.lineTo(24,105);ctx.lineTo(14,105);ctx.lineTo(11,105);ctx.lineTo(11,109);ctx.lineTo(11,117);ctx.lineTo(11,121);ctx.lineTo(386,121);ctx.lineTo(386,117);ctx.lineTo(386,113);ctx.lineTo(386,109);ctx.lineTo(386,105);ctx.lineTo(373,105);ctx.lineTo(371,104);ctx.lineTo(370,102);ctx.lineTo(370,27);ctx.lineTo(369,21);ctx.lineTo(366,16);ctx.lineTo(361,12);ctx.lineTo(355,11);ctx.lineTo(199,11);ctx.lineTo(199,27);ctx.lineTo(347,27);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(347,222);ctx.lineTo(353,219);ctx.lineTo(355,214);ctx.lineTo(355,144);ctx.lineTo(42,144);ctx.lineTo(42,214);ctx.lineTo(43,217);ctx.lineTo(47,221);ctx.lineTo(50,222);ctx.lineTo(199,222);ctx.lineTo(199,238);ctx.lineTo(42,238);ctx.lineTo(37,237);ctx.lineTo(28,228);ctx.lineTo(27,213);ctx.lineTo(27,147);ctx.lineTo(26,145);ctx.lineTo(24,144);ctx.lineTo(14,144);ctx.lineTo(11,144);ctx.lineTo(11,140);ctx.lineTo(11,129);ctx.lineTo(386,128);ctx.lineTo(386,132);ctx.lineTo(386,144);ctx.lineTo(373,144);ctx.lineTo(371,145);ctx.lineTo(370,147);ctx.lineTo(370,222);ctx.lineTo(369,228);ctx.lineTo(366,233);ctx.lineTo(361,237);ctx.lineTo(355,238);ctx.lineTo(199,238);ctx.lineTo(199,222);ctx.lineTo(347,222);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(347,27));listpt.Add(new Point(353,29));listpt.Add(new Point(355,35));listpt.Add(new Point(355,105));listpt.Add(new Point(42,105));listpt.Add(new Point(42,35));listpt.Add(new Point(45,29));listpt.Add(new Point(50,27));listpt.Add(new Point(199,27));listpt.Add(new Point(199,11));listpt.Add(new Point(42,11));listpt.Add(new Point(37,12));listpt.Add(new Point(28,21));listpt.Add(new Point(27,36));listpt.Add(new Point(27,102));listpt.Add(new Point(26,104));listpt.Add(new Point(24,105));listpt.Add(new Point(14,105));listpt.Add(new Point(11,105));listpt.Add(new Point(11,109));listpt.Add(new Point(11,117));listpt.Add(new Point(11,121));listpt.Add(new Point(386,121));listpt.Add(new Point(386,117));listpt.Add(new Point(386,113));listpt.Add(new Point(386,109));listpt.Add(new Point(386,105));listpt.Add(new Point(373,105));listpt.Add(new Point(371,104));listpt.Add(new Point(370,102));listpt.Add(new Point(370,27));listpt.Add(new Point(369,21));listpt.Add(new Point(366,16));listpt.Add(new Point(361,12));listpt.Add(new Point(355,11));listpt.Add(new Point(199,11));listpt.Add(new Point(199,27));listpt.Add(new Point(347,27));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(347,222));listpt.Add(new Point(353,219));listpt.Add(new Point(355,214));listpt.Add(new Point(355,144));listpt.Add(new Point(42,144));listpt.Add(new Point(42,214));listpt.Add(new Point(43,217));listpt.Add(new Point(47,221));listpt.Add(new Point(50,222));listpt.Add(new Point(199,222));listpt.Add(new Point(199,238));listpt.Add(new Point(42,238));listpt.Add(new Point(37,237));listpt.Add(new Point(28,228));listpt.Add(new Point(27,213));listpt.Add(new Point(27,147));listpt.Add(new Point(26,145));listpt.Add(new Point(24,144));listpt.Add(new Point(14,144));listpt.Add(new Point(11,144));listpt.Add(new Point(11,140));listpt.Add(new Point(11,129));listpt.Add(new Point(386,128));listpt.Add(new Point(386,132));listpt.Add(new Point(386,144));listpt.Add(new Point(373,144));listpt.Add(new Point(371,145));listpt.Add(new Point(370,147));listpt.Add(new Point(370,222));listpt.Add(new Point(369,228));listpt.Add(new Point(366,233));listpt.Add(new Point(361,237));listpt.Add(new Point(355,238));listpt.Add(new Point(199,238));listpt.Add(new Point(199,222));listpt.Add(new Point(347,222));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}