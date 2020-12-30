using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorSimple
{
    public class PIXIE_6120fd5c_0bcc_4875_8504_3d0411e4a570 : Pixie
    {
        public PIXIE_6120fd5c_0bcc_4875_8504_3d0411e4a570()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 971f; _h = 765f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(519,273);ctx.lineTo(563,221);ctx.lineTo(596,160);ctx.lineTo(615,96);ctx.lineTo(622,27);ctx.lineTo(971,27);ctx.lineTo(955,165);ctx.lineTo(916,293);ctx.lineTo(852,415);ctx.lineTo(765,519);ctx.lineTo(520,765);ctx.lineTo(27,765);ctx.lineTo(519,273);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(519,273));listpt.Add(new Point(563,221));listpt.Add(new Point(596,160));listpt.Add(new Point(615,96));listpt.Add(new Point(622,27));listpt.Add(new Point(971,27));listpt.Add(new Point(955,165));listpt.Add(new Point(916,293));listpt.Add(new Point(852,415));listpt.Add(new Point(765,519));listpt.Add(new Point(520,765));listpt.Add(new Point(27,765));listpt.Add(new Point(519,273));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}