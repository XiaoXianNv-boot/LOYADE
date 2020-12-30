using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Food
{
    public class PIXIE_95e96210_0955_4ceb_9796_ea1db8dd0e99 : Pixie
    {
        public PIXIE_95e96210_0955_4ceb_9796_ea1db8dd0e99()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#cff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#cff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 799f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#cff'; arrFillColor[1] = '#cff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(478,392);ctx.lineTo(970,392);ctx.lineTo(970,456);ctx.lineTo(478,456);ctx.lineTo(478,392);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(950,348);ctx.lineTo(778,113);ctx.lineTo(778,28);ctx.lineTo(691,28);ctx.lineTo(691,113);ctx.lineTo(499,348);ctx.lineTo(499,584);ctx.lineTo(327,584);ctx.lineTo(327,243);ctx.lineTo(71,243);ctx.lineTo(71,542);ctx.lineTo(28,542);ctx.lineTo(28,755);ctx.lineTo(71,755);ctx.lineTo(71,799);ctx.lineTo(135,799);ctx.lineTo(135,755);ctx.lineTo(842,755);ctx.lineTo(842,799);ctx.lineTo(906,799);ctx.lineTo(906,755);ctx.lineTo(950,755);ctx.lineTo(950,348);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(478,392));listpt.Add(new Point(970,392));listpt.Add(new Point(970,456));listpt.Add(new Point(478,456));listpt.Add(new Point(478,392));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(950,348));listpt.Add(new Point(778,113));listpt.Add(new Point(778,28));listpt.Add(new Point(691,28));listpt.Add(new Point(691,113));listpt.Add(new Point(499,348));listpt.Add(new Point(499,584));listpt.Add(new Point(327,584));listpt.Add(new Point(327,243));listpt.Add(new Point(71,243));listpt.Add(new Point(71,542));listpt.Add(new Point(28,542));listpt.Add(new Point(28,755));listpt.Add(new Point(71,755));listpt.Add(new Point(71,799));listpt.Add(new Point(135,799));listpt.Add(new Point(135,755));listpt.Add(new Point(842,755));listpt.Add(new Point(842,799));listpt.Add(new Point(906,799));listpt.Add(new Point(906,755));listpt.Add(new Point(950,755));listpt.Add(new Point(950,348));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}