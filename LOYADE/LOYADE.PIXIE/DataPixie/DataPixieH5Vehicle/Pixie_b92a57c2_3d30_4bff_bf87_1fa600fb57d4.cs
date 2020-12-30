using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Vehicle
{
    public class PIXIE_b92a57c2_3d30_4bff_bf87_1fa600fb57d4 : Pixie
    {
        public PIXIE_b92a57c2_3d30_4bff_bf87_1fa600fb57d4()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 617f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(28,597);ctx.lineTo(48,617);ctx.lineTo(165,617);ctx.lineTo(185,597);ctx.lineTo(185,538);ctx.lineTo(813,538);ctx.lineTo(813,597);ctx.lineTo(833,617);ctx.lineTo(951,617);ctx.lineTo(970,597);ctx.lineTo(970,381);ctx.lineTo(931,224);ctx.lineTo(970,224);ctx.lineTo(951,165);ctx.lineTo(843,146);ctx.lineTo(735,28);ctx.lineTo(263,28);ctx.lineTo(155,146);ctx.lineTo(48,165);ctx.lineTo(28,224);ctx.lineTo(67,224);ctx.lineTo(28,381);ctx.lineTo(28,597);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(28,597));listpt.Add(new Point(48,617));listpt.Add(new Point(165,617));listpt.Add(new Point(185,597));listpt.Add(new Point(185,538));listpt.Add(new Point(813,538));listpt.Add(new Point(813,597));listpt.Add(new Point(833,617));listpt.Add(new Point(951,617));listpt.Add(new Point(970,597));listpt.Add(new Point(970,381));listpt.Add(new Point(931,224));listpt.Add(new Point(970,224));listpt.Add(new Point(951,165));listpt.Add(new Point(843,146));listpt.Add(new Point(735,28));listpt.Add(new Point(263,28));listpt.Add(new Point(155,146));listpt.Add(new Point(48,165));listpt.Add(new Point(28,224));listpt.Add(new Point(67,224));listpt.Add(new Point(28,381));listpt.Add(new Point(28,597));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}