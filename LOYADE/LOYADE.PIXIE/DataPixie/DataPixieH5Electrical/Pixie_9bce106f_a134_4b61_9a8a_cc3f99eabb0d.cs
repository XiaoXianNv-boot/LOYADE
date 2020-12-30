using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Electrical
{
    public class PIXIE_9bce106f_a134_4b61_9a8a_cc3f99eabb0d : Pixie
    {
        public PIXIE_9bce106f_a134_4b61_9a8a_cc3f99eabb0d()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 608f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(390,28);ctx.lineTo(443,29);ctx.lineTo(492,31);ctx.lineTo(539,36);ctx.lineTo(583,43);ctx.lineTo(624,51);ctx.lineTo(663,62);ctx.lineTo(699,76);ctx.lineTo(734,91);ctx.lineTo(768,109);ctx.lineTo(799,131);ctx.lineTo(829,154);ctx.lineTo(859,181);ctx.lineTo(888,210);ctx.lineTo(916,243);ctx.lineTo(943,279);ctx.lineTo(957,298);ctx.lineTo(970,318);ctx.lineTo(957,338);ctx.lineTo(929,375);ctx.lineTo(902,409);ctx.lineTo(873,441);ctx.lineTo(844,469);ctx.lineTo(815,494);ctx.lineTo(784,516);ctx.lineTo(751,536);ctx.lineTo(717,553);ctx.lineTo(681,567);ctx.lineTo(643,579);ctx.lineTo(604,589);ctx.lineTo(561,597);ctx.lineTo(516,602);ctx.lineTo(468,606);ctx.lineTo(417,608);ctx.lineTo(390,608);ctx.lineTo(100,608);ctx.lineTo(125,579);ctx.lineTo(148,547);ctx.lineTo(166,513);ctx.lineTo(182,477);ctx.lineTo(193,438);ctx.lineTo(202,399);ctx.lineTo(207,359);ctx.lineTo(209,318);ctx.lineTo(207,277);ctx.lineTo(202,237);ctx.lineTo(193,197);ctx.lineTo(182,159);ctx.lineTo(167,123);ctx.lineTo(148,88);ctx.lineTo(126,57);ctx.lineTo(113,42);ctx.lineTo(100,28);ctx.lineTo(390,28);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(390,28));listpt.Add(new Point(443,29));listpt.Add(new Point(492,31));listpt.Add(new Point(539,36));listpt.Add(new Point(583,43));listpt.Add(new Point(624,51));listpt.Add(new Point(663,62));listpt.Add(new Point(699,76));listpt.Add(new Point(734,91));listpt.Add(new Point(768,109));listpt.Add(new Point(799,131));listpt.Add(new Point(829,154));listpt.Add(new Point(859,181));listpt.Add(new Point(888,210));listpt.Add(new Point(916,243));listpt.Add(new Point(943,279));listpt.Add(new Point(957,298));listpt.Add(new Point(970,318));listpt.Add(new Point(957,338));listpt.Add(new Point(929,375));listpt.Add(new Point(902,409));listpt.Add(new Point(873,441));listpt.Add(new Point(844,469));listpt.Add(new Point(815,494));listpt.Add(new Point(784,516));listpt.Add(new Point(751,536));listpt.Add(new Point(717,553));listpt.Add(new Point(681,567));listpt.Add(new Point(643,579));listpt.Add(new Point(604,589));listpt.Add(new Point(561,597));listpt.Add(new Point(516,602));listpt.Add(new Point(468,606));listpt.Add(new Point(417,608));listpt.Add(new Point(390,608));listpt.Add(new Point(100,608));listpt.Add(new Point(125,579));listpt.Add(new Point(148,547));listpt.Add(new Point(166,513));listpt.Add(new Point(182,477));listpt.Add(new Point(193,438));listpt.Add(new Point(202,399));listpt.Add(new Point(207,359));listpt.Add(new Point(209,318));listpt.Add(new Point(207,277));listpt.Add(new Point(202,237));listpt.Add(new Point(193,197));listpt.Add(new Point(182,159));listpt.Add(new Point(167,123));listpt.Add(new Point(148,88));listpt.Add(new Point(126,57));listpt.Add(new Point(113,42));listpt.Add(new Point(100,28));listpt.Add(new Point(390,28));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}