using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ComputerHardware
{
    public class PIXIE_3a00b717_bf9c_49c1_90ab_e10209a86696 : Pixie
    {
        public PIXIE_3a00b717_bf9c_49c1_90ab_e10209a86696()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#f00"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f00"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f00"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f00"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f00"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#f00"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 534.6207f; _h = 329f;
_content = "var arrFillColor = new Array(6); var arrBorderColor = new Array(6); var arrBorderWidth = new Array(6); arrFillColor[0] = '#f00'; arrFillColor[1] = '#f00'; arrFillColor[2] = '#f00'; arrFillColor[3] = '#f00'; arrFillColor[4] = '#f00'; arrFillColor[5] = '#f00'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; ctx.beginPath(); /* ellipse */ ctx.scale(1.526316,1);ctx.arc(127.7586,310,19,0,Math.PI*2,true);ctx.scale(0.6551724,1);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(1.526316,1);ctx.arc(209.6552,310,19,0,Math.PI*2,true);ctx.scale(0.6551724,1);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(1.526316,1);ctx.arc(286.9655,310,19,0,Math.PI*2,true);ctx.scale(0.6551724,1);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(1.526316,1);ctx.arc(368.8621,310,19,0,Math.PI*2,true);ctx.scale(0.6551724,1);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(1.526316,1);ctx.arc(440.2758,310,19,0,Math.PI*2,true);ctx.scale(0.6551724,1);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(1.526316,1);ctx.arc(515.6207,310,19,0,Math.PI*2,true);ctx.scale(0.6551724,1);ctx.fillStyle = arrFillColor[5];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillEllipse(sb, 108.7586f,291f,38f,38f);g.DrawEllipse(p, 108.7586f,291f,38f,38f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillEllipse(sb, 190.6552f,291f,38f,38f);g.DrawEllipse(p, 190.6552f,291f,38f,38f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillEllipse(sb, 267.9655f,291f,38f,38f);g.DrawEllipse(p, 267.9655f,291f,38f,38f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillEllipse(sb, 349.8621f,291f,38f,38f);g.DrawEllipse(p, 349.8621f,291f,38f,38f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillEllipse(sb, 421.2758f,291f,38f,38f);g.DrawEllipse(p, 421.2758f,291f,38f,38f);
listpt = new List<Point>();sb = new SolidBrush(_listfillcolor[5]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillEllipse(sb, 496.6207f,291f,38f,38f);g.DrawEllipse(p, 496.6207f,291f,38f,38f);
        }
    }
}