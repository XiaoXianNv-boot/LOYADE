using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ComputerKey
{
    public class PIXIE_4f5cac67_534d_45d9_a91c_2f8d6f893579 : Pixie
    {
        public PIXIE_4f5cac67_534d_45d9_a91c_2f8d6f893579()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#ebebe1"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#adad84"));
_w = 904f; _h = 456f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#ebebe1'; arrBorderColor[0] = '#adad84'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(94,64);ctx.lineTo(109,50);ctx.lineTo(889,50);ctx.lineTo(904,64);ctx.lineTo(904,440);ctx.lineTo(889,456);ctx.lineTo(109,456);ctx.lineTo(94,440);ctx.lineTo(94,64);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(94,64));listpt.Add(new Point(109,50));listpt.Add(new Point(889,50));listpt.Add(new Point(904,64));listpt.Add(new Point(904,440));listpt.Add(new Point(889,456));listpt.Add(new Point(109,456));listpt.Add(new Point(94,440));listpt.Add(new Point(94,64));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}