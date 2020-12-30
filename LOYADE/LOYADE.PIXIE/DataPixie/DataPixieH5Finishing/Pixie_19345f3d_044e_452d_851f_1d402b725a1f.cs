using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Finishing
{
    public class PIXIE_19345f3d_044e_452d_851f_1d402b725a1f : Pixie
    {
        public PIXIE_19345f3d_044e_452d_851f_1d402b725a1f()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 735f; _h = 970f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#7f7f7f'; arrFillColor[1] = '#b2b2b2'; arrFillColor[2] = '#b2b2b2'; arrFillColor[3] = '#b2b2b2'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(705,380);ctx.lineTo(735,380);ctx.lineTo(735,335);ctx.lineTo(710,244);ctx.lineTo(663,163);ctx.lineTo(599,97);ctx.lineTo(518,52);ctx.lineTo(427,28);ctx.lineTo(335,28);ctx.lineTo(244,52);ctx.lineTo(163,97);ctx.lineTo(99,163);ctx.lineTo(52,244);ctx.lineTo(28,335);ctx.lineTo(28,380);ctx.lineTo(56,382);ctx.lineTo(56,339);ctx.lineTo(79,256);ctx.lineTo(122,182);ctx.lineTo(182,122);ctx.lineTo(256,79);ctx.lineTo(339,56);ctx.lineTo(423,56);ctx.lineTo(507,79);ctx.lineTo(580,122);ctx.lineTo(640,182);ctx.lineTo(684,256);ctx.lineTo(705,339);ctx.lineTo(705,380);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(735,919);ctx.lineTo(710,934);ctx.lineTo(663,948);ctx.lineTo(597,959);ctx.lineTo(518,966);ctx.lineTo(427,970);ctx.lineTo(335,970);ctx.lineTo(244,966);ctx.lineTo(163,959);ctx.lineTo(97,948);ctx.lineTo(52,934);ctx.lineTo(28,919);ctx.lineTo(28,846);ctx.lineTo(52,857);ctx.lineTo(97,867);ctx.lineTo(163,874);ctx.lineTo(244,880);ctx.lineTo(335,882);ctx.lineTo(427,882);ctx.lineTo(518,880);ctx.lineTo(597,874);ctx.lineTo(663,867);ctx.lineTo(710,857);ctx.lineTo(735,846);ctx.lineTo(735,919);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(518,497);ctx.lineTo(427,499);ctx.lineTo(335,499);ctx.lineTo(244,497);ctx.lineTo(165,493);ctx.lineTo(99,487);ctx.lineTo(52,480);ctx.lineTo(28,474);ctx.lineTo(28,465);ctx.lineTo(28,382);ctx.lineTo(735,380);ctx.lineTo(735,474);ctx.lineTo(710,480);ctx.lineTo(663,487);ctx.lineTo(597,493);ctx.lineTo(518,497);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(12.17241,1);ctx.arc(31.30028,381,29,0,Math.PI*2,true);ctx.scale(0.08215298,1);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(705,380));listpt.Add(new Point(735,380));listpt.Add(new Point(735,335));listpt.Add(new Point(710,244));listpt.Add(new Point(663,163));listpt.Add(new Point(599,97));listpt.Add(new Point(518,52));listpt.Add(new Point(427,28));listpt.Add(new Point(335,28));listpt.Add(new Point(244,52));listpt.Add(new Point(163,97));listpt.Add(new Point(99,163));listpt.Add(new Point(52,244));listpt.Add(new Point(28,335));listpt.Add(new Point(28,380));listpt.Add(new Point(56,382));listpt.Add(new Point(56,339));listpt.Add(new Point(79,256));listpt.Add(new Point(122,182));listpt.Add(new Point(182,122));listpt.Add(new Point(256,79));listpt.Add(new Point(339,56));listpt.Add(new Point(423,56));listpt.Add(new Point(507,79));listpt.Add(new Point(580,122));listpt.Add(new Point(640,182));listpt.Add(new Point(684,256));listpt.Add(new Point(705,339));listpt.Add(new Point(705,380));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(735,919));listpt.Add(new Point(710,934));listpt.Add(new Point(663,948));listpt.Add(new Point(597,959));listpt.Add(new Point(518,966));listpt.Add(new Point(427,970));listpt.Add(new Point(335,970));listpt.Add(new Point(244,966));listpt.Add(new Point(163,959));listpt.Add(new Point(97,948));listpt.Add(new Point(52,934));listpt.Add(new Point(28,919));listpt.Add(new Point(28,846));listpt.Add(new Point(52,857));listpt.Add(new Point(97,867));listpt.Add(new Point(163,874));listpt.Add(new Point(244,880));listpt.Add(new Point(335,882));listpt.Add(new Point(427,882));listpt.Add(new Point(518,880));listpt.Add(new Point(597,874));listpt.Add(new Point(663,867));listpt.Add(new Point(710,857));listpt.Add(new Point(735,846));listpt.Add(new Point(735,919));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(518,497));listpt.Add(new Point(427,499));listpt.Add(new Point(335,499));listpt.Add(new Point(244,497));listpt.Add(new Point(165,493));listpt.Add(new Point(99,487));listpt.Add(new Point(52,480));listpt.Add(new Point(28,474));listpt.Add(new Point(28,465));listpt.Add(new Point(28,382));listpt.Add(new Point(735,380));listpt.Add(new Point(735,474));listpt.Add(new Point(710,480));listpt.Add(new Point(663,487));listpt.Add(new Point(597,493));listpt.Add(new Point(518,497));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillEllipse(sb, 2.30028f,352f,58f,58f);g.DrawEllipse(p, 2.30028f,352f,58f,58f);
        }
    }
}