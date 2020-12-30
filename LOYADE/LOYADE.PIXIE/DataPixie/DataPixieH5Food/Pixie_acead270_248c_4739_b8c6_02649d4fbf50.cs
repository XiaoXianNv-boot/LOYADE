using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Food
{
    public class PIXIE_acead270_248c_4739_b8c6_02649d4fbf50 : Pixie
    {
        public PIXIE_acead270_248c_4739_b8c6_02649d4fbf50()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#72727f"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#a5a5b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#bfbfcc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#a5a5b2"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#bfbfcc"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 525f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(6); var arrBorderWidth = new Array(6); arrFillColor[0] = '#72727f'; arrFillColor[1] = '#a5a5b2'; arrFillColor[2] = '#bfbfcc'; arrFillColor[3] = '#a5a5b2'; arrFillColor[4] = '#bfbfcc'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderColor[5] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; arrBorderWidth[5] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(276,493);ctx.lineTo(256,493);ctx.lineTo(256,442);ctx.lineTo(224,442);ctx.lineTo(214,452);ctx.lineTo(214,514);ctx.lineTo(224,525);ctx.lineTo(276,525);ctx.lineTo(276,493);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* ellipse */ ctx.scale(5.354839,1);ctx.arc(92.06626,90,62,0,Math.PI*2,true);ctx.scale(0.186747,1);ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(327,224);ctx.lineTo(48,214);ctx.lineTo(28,203);ctx.lineTo(28,161);ctx.lineTo(327,182);ctx.lineTo(327,224);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(327,182);ctx.lineTo(48,173);ctx.lineTo(28,161);ctx.lineTo(37,152);ctx.lineTo(182,141);ctx.lineTo(235,161);ctx.lineTo(327,182);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(804,276);ctx.lineTo(959,276);ctx.lineTo(970,265);ctx.lineTo(970,235);ctx.lineTo(804,245);ctx.lineTo(804,276);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(804,245);ctx.lineTo(961,245);ctx.lineTo(970,235);ctx.lineTo(950,224);ctx.lineTo(825,194);ctx.lineTo(825,214);ctx.lineTo(804,245);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[5];ctx.strokeStyle = arrBorderColor[5];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(276,493));listpt.Add(new Point(256,493));listpt.Add(new Point(256,442));listpt.Add(new Point(224,442));listpt.Add(new Point(214,452));listpt.Add(new Point(214,514));listpt.Add(new Point(224,525));listpt.Add(new Point(276,525));listpt.Add(new Point(276,493));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.DrawEllipse(p, 30.06626f,28f,124f,124f);
listpt = new List<Point>();listpt.Add(new Point(327,224));listpt.Add(new Point(48,214));listpt.Add(new Point(28,203));listpt.Add(new Point(28,161));listpt.Add(new Point(327,182));listpt.Add(new Point(327,224));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(327,182));listpt.Add(new Point(48,173));listpt.Add(new Point(28,161));listpt.Add(new Point(37,152));listpt.Add(new Point(182,141));listpt.Add(new Point(235,161));listpt.Add(new Point(327,182));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(804,276));listpt.Add(new Point(959,276));listpt.Add(new Point(970,265));listpt.Add(new Point(970,235));listpt.Add(new Point(804,245));listpt.Add(new Point(804,276));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(804,245));listpt.Add(new Point(961,245));listpt.Add(new Point(970,235));listpt.Add(new Point(950,224));listpt.Add(new Point(825,194));listpt.Add(new Point(825,214));listpt.Add(new Point(804,245));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[5];p.Color = _listbordercolor[5];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}