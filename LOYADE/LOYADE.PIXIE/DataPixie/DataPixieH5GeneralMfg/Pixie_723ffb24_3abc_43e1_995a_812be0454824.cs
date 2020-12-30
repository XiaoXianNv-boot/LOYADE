using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_723ffb24_3abc_43e1_995a_812be0454824 : Pixie
    {
        public PIXIE_723ffb24_3abc_43e1_995a_812be0454824()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#161717"));
_w = 386f; _h = 229f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#161717'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(11,229);ctx.lineTo(11,109);ctx.lineTo(27,109);ctx.lineTo(27,79);ctx.lineTo(73,79);ctx.lineTo(73,169);ctx.lineTo(89,169);ctx.lineTo(89,154);ctx.lineTo(105,154);ctx.lineTo(97,139);ctx.lineTo(97,131);ctx.lineTo(105,116);ctx.lineTo(159,116);ctx.lineTo(167,131);ctx.lineTo(167,139);ctx.lineTo(159,154);ctx.lineTo(175,154);ctx.lineTo(175,169);ctx.lineTo(183,169);ctx.lineTo(183,109);ctx.lineTo(214,109);ctx.lineTo(214,199);ctx.lineTo(222,199);ctx.lineTo(222,109);ctx.lineTo(253,109);ctx.lineTo(253,176);ctx.lineTo(269,176);ctx.lineTo(269,146);ctx.lineTo(316,146);ctx.lineTo(316,101);ctx.lineTo(331,101);ctx.lineTo(331,41);ctx.lineTo(339,41);ctx.lineTo(339,11);ctx.lineTo(347,11);ctx.lineTo(347,41);ctx.lineTo(355,41);ctx.lineTo(355,11);ctx.lineTo(363,11);ctx.lineTo(363,41);ctx.lineTo(370,41);ctx.lineTo(370,109);ctx.lineTo(386,109);ctx.lineTo(386,229);ctx.lineTo(11,229);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(11,229));listpt.Add(new Point(11,109));listpt.Add(new Point(27,109));listpt.Add(new Point(27,79));listpt.Add(new Point(73,79));listpt.Add(new Point(73,169));listpt.Add(new Point(89,169));listpt.Add(new Point(89,154));listpt.Add(new Point(105,154));listpt.Add(new Point(97,139));listpt.Add(new Point(97,131));listpt.Add(new Point(105,116));listpt.Add(new Point(159,116));listpt.Add(new Point(167,131));listpt.Add(new Point(167,139));listpt.Add(new Point(159,154));listpt.Add(new Point(175,154));listpt.Add(new Point(175,169));listpt.Add(new Point(183,169));listpt.Add(new Point(183,109));listpt.Add(new Point(214,109));listpt.Add(new Point(214,199));listpt.Add(new Point(222,199));listpt.Add(new Point(222,109));listpt.Add(new Point(253,109));listpt.Add(new Point(253,176));listpt.Add(new Point(269,176));listpt.Add(new Point(269,146));listpt.Add(new Point(316,146));listpt.Add(new Point(316,101));listpt.Add(new Point(331,101));listpt.Add(new Point(331,41));listpt.Add(new Point(339,41));listpt.Add(new Point(339,11));listpt.Add(new Point(347,11));listpt.Add(new Point(347,41));listpt.Add(new Point(355,41));listpt.Add(new Point(355,11));listpt.Add(new Point(363,11));listpt.Add(new Point(363,41));listpt.Add(new Point(370,41));listpt.Add(new Point(370,109));listpt.Add(new Point(386,109));listpt.Add(new Point(386,229));listpt.Add(new Point(11,229));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}