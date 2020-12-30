using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ConveyorSimple
{
    public class PIXIE_54b277e1_b40d_4d68_9ae4_637665608cf2 : Pixie
    {
        public PIXIE_54b277e1_b40d_4d68_9ae4_637665608cf2()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 971f; _h = 765f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(519,519);ctx.lineTo(563,571);ctx.lineTo(596,633);ctx.lineTo(615,697);ctx.lineTo(622,765);ctx.lineTo(971,765);ctx.lineTo(955,628);ctx.lineTo(916,500);ctx.lineTo(852,378);ctx.lineTo(765,273);ctx.lineTo(520,28);ctx.lineTo(27,27);ctx.lineTo(519,519);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(519,519));listpt.Add(new Point(563,571));listpt.Add(new Point(596,633));listpt.Add(new Point(615,697));listpt.Add(new Point(622,765));listpt.Add(new Point(971,765));listpt.Add(new Point(955,628));listpt.Add(new Point(916,500));listpt.Add(new Point(852,378));listpt.Add(new Point(765,273));listpt.Add(new Point(520,28));listpt.Add(new Point(27,27));listpt.Add(new Point(519,519));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}