using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5GeneralMfg
{
    public class PIXIE_fe55531f_36da_4e1f_a8bc_a2c152af4245 : Pixie
    {
        public PIXIE_fe55531f_36da_4e1f_a8bc_a2c152af4245()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 195f; _h = 257f;
_content = "var arrFillColor = new Array(2); var arrBorderColor = new Array(2); var arrBorderWidth = new Array(2); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(101,257);ctx.lineTo(101,202);ctx.lineTo(117,195);ctx.lineTo(117,148);ctx.lineTo(39,132);ctx.lineTo(117,116);ctx.lineTo(117,70);ctx.lineTo(101,62);ctx.lineTo(101,7);ctx.lineTo(7,7);ctx.lineTo(7,257);ctx.lineTo(101,257);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(195,257);ctx.lineTo(195,7);ctx.lineTo(109,7);ctx.lineTo(109,46);ctx.lineTo(136,58);ctx.lineTo(136,206);ctx.lineTo(109,218);ctx.lineTo(109,257);ctx.lineTo(195,257);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(101,257));listpt.Add(new Point(101,202));listpt.Add(new Point(117,195));listpt.Add(new Point(117,148));listpt.Add(new Point(39,132));listpt.Add(new Point(117,116));listpt.Add(new Point(117,70));listpt.Add(new Point(101,62));listpt.Add(new Point(101,7));listpt.Add(new Point(7,7));listpt.Add(new Point(7,257));listpt.Add(new Point(101,257));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(195,257));listpt.Add(new Point(195,7));listpt.Add(new Point(109,7));listpt.Add(new Point(109,46));listpt.Add(new Point(136,58));listpt.Add(new Point(136,206));listpt.Add(new Point(109,218));listpt.Add(new Point(109,257));listpt.Add(new Point(195,257));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}