using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_ccbae2e5_ad04_471c_9ff8_ad26c2888074 : Pixie
    {
        public PIXIE_ccbae2e5_ad04_471c_9ff8_ad26c2888074()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 301f; _h = 258f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(90,258);ctx.lineTo(90,230);ctx.lineTo(88,224);ctx.lineTo(84,220);ctx.lineTo(77,217);ctx.lineTo(68,216);ctx.lineTo(60,217);ctx.lineTo(53,220);ctx.lineTo(49,224);ctx.lineTo(47,230);ctx.lineTo(47,258);ctx.lineTo(90,258);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(301,258);ctx.lineTo(129,258);ctx.lineTo(129,133);ctx.lineTo(128,121);ctx.lineTo(124,109);ctx.lineTo(118,98);ctx.lineTo(111,89);ctx.lineTo(102,82);ctx.lineTo(91,76);ctx.lineTo(79,72);ctx.lineTo(67,71);ctx.lineTo(191,71);ctx.lineTo(191,8);ctx.lineTo(231,8);ctx.lineTo(231,71);ctx.lineTo(238,71);ctx.lineTo(251,72);ctx.lineTo(263,76);ctx.lineTo(273,82);ctx.lineTo(283,89);ctx.lineTo(290,98);ctx.lineTo(296,109);ctx.lineTo(300,121);ctx.lineTo(301,133);ctx.lineTo(301,258);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(90,258));listpt.Add(new Point(90,230));listpt.Add(new Point(88,224));listpt.Add(new Point(84,220));listpt.Add(new Point(77,217));listpt.Add(new Point(68,216));listpt.Add(new Point(60,217));listpt.Add(new Point(53,220));listpt.Add(new Point(49,224));listpt.Add(new Point(47,230));listpt.Add(new Point(47,258));listpt.Add(new Point(90,258));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(301,258));listpt.Add(new Point(129,258));listpt.Add(new Point(129,133));listpt.Add(new Point(128,121));listpt.Add(new Point(124,109));listpt.Add(new Point(118,98));listpt.Add(new Point(111,89));listpt.Add(new Point(102,82));listpt.Add(new Point(91,76));listpt.Add(new Point(79,72));listpt.Add(new Point(67,71));listpt.Add(new Point(191,71));listpt.Add(new Point(191,8));listpt.Add(new Point(231,8));listpt.Add(new Point(231,71));listpt.Add(new Point(238,71));listpt.Add(new Point(251,72));listpt.Add(new Point(263,76));listpt.Add(new Point(273,82));listpt.Add(new Point(283,89));listpt.Add(new Point(290,98));listpt.Add(new Point(296,109));listpt.Add(new Point(300,121));listpt.Add(new Point(301,133));listpt.Add(new Point(301,258));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}