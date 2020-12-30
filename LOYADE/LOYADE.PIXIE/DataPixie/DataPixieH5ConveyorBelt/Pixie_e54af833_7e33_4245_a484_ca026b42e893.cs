using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorBelt
{
    public class PIXIE_e54af833_7e33_4245_a484_ca026b42e893 : Pixie
    {
        public PIXIE_e54af833_7e33_4245_a484_ca026b42e893()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#c0c0c0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#c0c0c0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 578f;
_content = "var arrFillColor = new Array(4); var arrBorderColor = new Array(4); var arrBorderWidth = new Array(4); arrFillColor[0] = '#000'; arrFillColor[1] = '#7f7f7f'; arrFillColor[2] = '#c0c0c0'; arrFillColor[3] = '#c0c0c0'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,48);ctx.lineTo(970,48);ctx.lineTo(970,558);ctx.lineTo(28,558);ctx.lineTo(28,48);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,264);ctx.lineTo(264,264);ctx.lineTo(715,558);ctx.lineTo(28,558);ctx.lineTo(28,264);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(741,558);ctx.lineTo(970,558);ctx.lineTo(970,578);ctx.lineTo(28,578);ctx.lineTo(28,558);ctx.lineTo(705,558);ctx.lineTo(263,264);ctx.lineTo(28,264);ctx.lineTo(28,244);ctx.lineTo(268,244);ctx.lineTo(741,558);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(28,28);ctx.lineTo(970,28);ctx.lineTo(970,48);ctx.lineTo(28,48);ctx.lineTo(28,28);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,48));listpt.Add(new Point(970,48));listpt.Add(new Point(970,558));listpt.Add(new Point(28,558));listpt.Add(new Point(28,48));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,264));listpt.Add(new Point(264,264));listpt.Add(new Point(715,558));listpt.Add(new Point(28,558));listpt.Add(new Point(28,264));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(741,558));listpt.Add(new Point(970,558));listpt.Add(new Point(970,578));listpt.Add(new Point(28,578));listpt.Add(new Point(28,558));listpt.Add(new Point(705,558));listpt.Add(new Point(263,264));listpt.Add(new Point(28,264));listpt.Add(new Point(28,244));listpt.Add(new Point(268,244));listpt.Add(new Point(741,558));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(28,28));listpt.Add(new Point(970,28));listpt.Add(new Point(970,48));listpt.Add(new Point(28,48));listpt.Add(new Point(28,28));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}