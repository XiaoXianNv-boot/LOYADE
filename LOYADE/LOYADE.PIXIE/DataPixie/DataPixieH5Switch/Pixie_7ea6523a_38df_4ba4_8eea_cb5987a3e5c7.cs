using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Switch
{
    public class PIXIE_7ea6523a_38df_4ba4_8eea_cb5987a3e5c7 : Pixie
    {
        public PIXIE_7ea6523a_38df_4ba4_8eea_cb5987a3e5c7()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#4c4c4c"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#7f7f7f"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 970f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#000'; arrFillColor[1] = '#e5e5e5'; arrFillColor[2] = '#000'; arrFillColor[3] = '#4c4c4c'; arrFillColor[4] = '#e5e5e5'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#7f7f7f'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(29,969);ctx.lineTo(29,29);ctx.lineTo(968,29);ctx.lineTo(968,969);ctx.lineTo(29,969);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(499,499,471,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* circle */ ctx.arc(499,499,403,0,Math.PI*2,true);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(118,593);ctx.lineTo(127,608);ctx.lineTo(146,612);ctx.lineTo(380,593);ctx.lineTo(618,593);ctx.lineTo(853,612);ctx.lineTo(870,608);ctx.lineTo(882,592);ctx.lineTo(893,499);ctx.lineTo(882,405);ctx.lineTo(870,390);ctx.lineTo(853,386);ctx.lineTo(618,405);ctx.lineTo(380,405);ctx.lineTo(146,386);ctx.lineTo(127,390);ctx.lineTo(116,405);ctx.lineTo(105,499);ctx.lineTo(118,593);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(693,539);ctx.lineTo(861,539);ctx.lineTo(861,460);ctx.lineTo(693,460);ctx.lineTo(683,461);ctx.lineTo(678,463);ctx.lineTo(678,463);ctx.lineTo(675,464);ctx.lineTo(670,467);ctx.lineTo(663,474);ctx.lineTo(659,482);ctx.lineTo(656,491);ctx.lineTo(656,493);ctx.lineTo(655,493);ctx.lineTo(655,494);ctx.lineTo(656,504);ctx.lineTo(659,513);ctx.lineTo(660,519);ctx.lineTo(667,525);ctx.lineTo(673,532);ctx.lineTo(681,536);ctx.lineTo(688,538);ctx.lineTo(689,539);ctx.lineTo(690,539);ctx.lineTo(693,539);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(29,969));listpt.Add(new Point(29,29));listpt.Add(new Point(968,29));listpt.Add(new Point(968,969));listpt.Add(new Point(29,969));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 28f,28f,942f,942f);g.DrawEllipse(p, 28f,28f,942f,942f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillEllipse(sb, 96f,96f,806f,806f);g.DrawEllipse(p, 96f,96f,806f,806f);
listpt = new List<Point>();listpt.Add(new Point(118,593));listpt.Add(new Point(127,608));listpt.Add(new Point(146,612));listpt.Add(new Point(380,593));listpt.Add(new Point(618,593));listpt.Add(new Point(853,612));listpt.Add(new Point(870,608));listpt.Add(new Point(882,592));listpt.Add(new Point(893,499));listpt.Add(new Point(882,405));listpt.Add(new Point(870,390));listpt.Add(new Point(853,386));listpt.Add(new Point(618,405));listpt.Add(new Point(380,405));listpt.Add(new Point(146,386));listpt.Add(new Point(127,390));listpt.Add(new Point(116,405));listpt.Add(new Point(105,499));listpt.Add(new Point(118,593));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(693,539));listpt.Add(new Point(861,539));listpt.Add(new Point(861,460));listpt.Add(new Point(693,460));listpt.Add(new Point(683,461));listpt.Add(new Point(678,463));listpt.Add(new Point(678,463));listpt.Add(new Point(675,464));listpt.Add(new Point(670,467));listpt.Add(new Point(663,474));listpt.Add(new Point(659,482));listpt.Add(new Point(656,491));listpt.Add(new Point(656,493));listpt.Add(new Point(655,493));listpt.Add(new Point(655,494));listpt.Add(new Point(656,504));listpt.Add(new Point(659,513));listpt.Add(new Point(660,519));listpt.Add(new Point(667,525));listpt.Add(new Point(673,532));listpt.Add(new Point(681,536));listpt.Add(new Point(688,538));listpt.Add(new Point(689,539));listpt.Add(new Point(690,539));listpt.Add(new Point(693,539));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}