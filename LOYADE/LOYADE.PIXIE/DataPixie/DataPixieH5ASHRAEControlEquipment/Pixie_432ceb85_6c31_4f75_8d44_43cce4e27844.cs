using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEControlEquipment
{
    public class PIXIE_432ceb85_6c31_4f75_8d44_43cce4e27844 : Pixie
    {
        public PIXIE_432ceb85_6c31_4f75_8d44_43cce4e27844()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 735f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(185,460);ctx.lineTo(185,28);ctx.lineTo(813,28);ctx.lineTo(813,460);ctx.lineTo(970,460);ctx.lineTo(970,735);ctx.lineTo(28,735);ctx.lineTo(28,460);ctx.lineTo(185,460);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(185,460));listpt.Add(new Point(185,28));listpt.Add(new Point(813,28));listpt.Add(new Point(813,460));listpt.Add(new Point(970,460));listpt.Add(new Point(970,735));listpt.Add(new Point(28,735));listpt.Add(new Point(28,460));listpt.Add(new Point(185,460));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}