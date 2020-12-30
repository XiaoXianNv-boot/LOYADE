using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Container
{
    public class PIXIE_8981128c_7716_4aee_8c24_c333e96afc6b : Pixie
    {
        public PIXIE_8981128c_7716_4aee_8c24_c333e96afc6b()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#e5e5e5"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 401f; _h = 970f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#e5e5e5'; arrFillColor[1] = '#e5e5e5'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(269,261);ctx.lineTo(325,280);ctx.lineTo(363,299);ctx.lineTo(382,316);ctx.lineTo(401,373);ctx.lineTo(401,895);ctx.lineTo(382,952);ctx.lineTo(363,970);ctx.lineTo(63,970);ctx.lineTo(46,952);ctx.lineTo(28,895);ctx.lineTo(28,373);ctx.lineTo(46,316);ctx.lineTo(63,299);ctx.lineTo(101,280);ctx.lineTo(158,261);ctx.lineTo(158,243);ctx.lineTo(269,243);ctx.lineTo(269,261);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(176,205);ctx.lineTo(195,75);ctx.lineTo(233,75);ctx.lineTo(250,205);ctx.lineTo(176,205);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(269,261));listpt.Add(new Point(325,280));listpt.Add(new Point(363,299));listpt.Add(new Point(382,316));listpt.Add(new Point(401,373));listpt.Add(new Point(401,895));listpt.Add(new Point(382,952));listpt.Add(new Point(363,970));listpt.Add(new Point(63,970));listpt.Add(new Point(46,952));listpt.Add(new Point(28,895));listpt.Add(new Point(28,373));listpt.Add(new Point(46,316));listpt.Add(new Point(63,299));listpt.Add(new Point(101,280));listpt.Add(new Point(158,261));listpt.Add(new Point(158,243));listpt.Add(new Point(269,243));listpt.Add(new Point(269,261));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(176,205));listpt.Add(new Point(195,75));listpt.Add(new Point(233,75));listpt.Add(new Point(250,205));listpt.Add(new Point(176,205));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}