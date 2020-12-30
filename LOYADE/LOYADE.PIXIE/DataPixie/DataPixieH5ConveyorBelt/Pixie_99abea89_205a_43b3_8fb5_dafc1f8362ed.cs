using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorBelt
{
    public class PIXIE_99abea89_205a_43b3_8fb5_dafc1f8362ed : Pixie
    {
        public PIXIE_99abea89_205a_43b3_8fb5_dafc1f8362ed()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#c0c0c0"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 499f; _h = 546f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#c0c0c0'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(15,15);ctx.lineTo(389,15);ctx.lineTo(396,88);ctx.lineTo(418,159);ctx.lineTo(452,223);ctx.lineTo(499,281);ctx.lineTo(234,546);ctx.lineTo(141,430);ctx.lineTo(73,302);ctx.lineTo(29,161);ctx.lineTo(15,15);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(15,15));listpt.Add(new Point(389,15));listpt.Add(new Point(396,88));listpt.Add(new Point(418,159));listpt.Add(new Point(452,223));listpt.Add(new Point(499,281));listpt.Add(new Point(234,546));listpt.Add(new Point(141,430));listpt.Add(new Point(73,302));listpt.Add(new Point(29,161));listpt.Add(new Point(15,15));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}