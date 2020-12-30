using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Switch
{
    public class PIXIE_38e80a05_ec1e_405e_af93_4a251e788fba : Pixie
    {
        public PIXIE_38e80a05_ec1e_405e_af93_4a251e788fba()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#b2b2b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 790f; _h = 833f;
_content = "var arrFillColor = new Array(3); var arrBorderColor = new Array(3); var arrBorderWidth = new Array(3); arrFillColor[0] = '#e5e5e5'; arrFillColor[1] = '#7f7f7f'; arrFillColor[2] = '#b2b2b2'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(374,257);ctx.lineTo(212,416);ctx.lineTo(208,431);ctx.lineTo(208,654);ctx.lineTo(212,669);ctx.lineTo(374,828);ctx.lineTo(388,833);ctx.lineTo(609,833);ctx.lineTo(626,828);ctx.lineTo(785,669);ctx.lineTo(790,654);ctx.lineTo(790,431);ctx.lineTo(785,416);ctx.lineTo(626,257);ctx.lineTo(609,251);ctx.lineTo(388,251);ctx.lineTo(374,257);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(499,542,273,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(539,232);ctx.lineTo(539,289);ctx.lineTo(593,305);ctx.lineTo(642,332);ctx.lineTo(687,369);ctx.lineTo(719,413);ctx.lineTo(740,464);ctx.lineTo(752,520);ctx.lineTo(752,576);ctx.lineTo(738,631);ctx.lineTo(714,680);ctx.lineTo(677,724);ctx.lineTo(633,758);ctx.lineTo(582,784);ctx.lineTo(528,795);ctx.lineTo(470,795);ctx.lineTo(417,784);ctx.lineTo(365,758);ctx.lineTo(321,724);ctx.lineTo(286,680);ctx.lineTo(260,631);ctx.lineTo(246,576);ctx.lineTo(244,520);ctx.lineTo(255,464);ctx.lineTo(279,413);ctx.lineTo(313,369);ctx.lineTo(355,332);ctx.lineTo(404,305);ctx.lineTo(460,289);ctx.lineTo(460,232);ctx.lineTo(539,232);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(374,257));listpt.Add(new Point(212,416));listpt.Add(new Point(208,431));listpt.Add(new Point(208,654));listpt.Add(new Point(212,669));listpt.Add(new Point(374,828));listpt.Add(new Point(388,833));listpt.Add(new Point(609,833));listpt.Add(new Point(626,828));listpt.Add(new Point(785,669));listpt.Add(new Point(790,654));listpt.Add(new Point(790,431));listpt.Add(new Point(785,416));listpt.Add(new Point(626,257));listpt.Add(new Point(609,251));listpt.Add(new Point(388,251));listpt.Add(new Point(374,257));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 226f,269f,546f,546f);g.DrawEllipse(p, 226f,269f,546f,546f);
listpt = new List<Point>();listpt.Add(new Point(539,232));listpt.Add(new Point(539,289));listpt.Add(new Point(593,305));listpt.Add(new Point(642,332));listpt.Add(new Point(687,369));listpt.Add(new Point(719,413));listpt.Add(new Point(740,464));listpt.Add(new Point(752,520));listpt.Add(new Point(752,576));listpt.Add(new Point(738,631));listpt.Add(new Point(714,680));listpt.Add(new Point(677,724));listpt.Add(new Point(633,758));listpt.Add(new Point(582,784));listpt.Add(new Point(528,795));listpt.Add(new Point(470,795));listpt.Add(new Point(417,784));listpt.Add(new Point(365,758));listpt.Add(new Point(321,724));listpt.Add(new Point(286,680));listpt.Add(new Point(260,631));listpt.Add(new Point(246,576));listpt.Add(new Point(244,520));listpt.Add(new Point(255,464));listpt.Add(new Point(279,413));listpt.Add(new Point(313,369));listpt.Add(new Point(355,332));listpt.Add(new Point(404,305));listpt.Add(new Point(460,289));listpt.Add(new Point(460,232));listpt.Add(new Point(539,232));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}