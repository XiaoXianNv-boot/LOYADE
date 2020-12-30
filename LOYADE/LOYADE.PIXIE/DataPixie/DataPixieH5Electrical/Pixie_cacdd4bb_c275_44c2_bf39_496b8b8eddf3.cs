using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5Electrical
{
    public class PIXIE_cacdd4bb_c275_44c2_bf39_496b8b8eddf3 : Pixie
    {
        public PIXIE_cacdd4bb_c275_44c2_bf39_496b8b8eddf3()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));_listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 308f;
_content = "var arrFillColor = new Array(5); var arrBorderColor = new Array(5); var arrBorderWidth = new Array(5); arrFillColor[0] = '#0ff'; arrFillColor[1] = '#0ff'; arrFillColor[2] = '#0ff'; arrFillColor[3] = '#0ff'; arrFillColor[4] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderColor[1] = '#000'; arrBorderColor[2] = '#000'; arrBorderColor[3] = '#000'; arrBorderColor[4] = '#000'; arrBorderWidth[0] = '2'; arrBorderWidth[1] = '2'; arrBorderWidth[2] = '2'; arrBorderWidth[3] = '2'; arrBorderWidth[4] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(282,308);ctx.lineTo(282,28);ctx.lineTo(715,28);ctx.lineTo(715,308);ctx.lineTo(282,308);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(716,265);ctx.lineTo(716,217);ctx.lineTo(770,217);ctx.lineTo(796,224);ctx.lineTo(946,224);ctx.lineTo(956,225);ctx.lineTo(964,228);ctx.lineTo(968,233);ctx.lineTo(970,241);ctx.lineTo(968,248);ctx.lineTo(964,254);ctx.lineTo(956,258);ctx.lineTo(946,259);ctx.lineTo(796,259);ctx.lineTo(771,265);ctx.lineTo(716,265);ctx.fillStyle = arrFillColor[1];ctx.fill();ctx.lineWidth = arrBorderWidth[1];ctx.strokeStyle = arrBorderColor[1];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(282,192);ctx.lineTo(229,192);ctx.lineTo(202,185);ctx.lineTo(53,185);ctx.lineTo(42,184);ctx.lineTo(34,180);ctx.lineTo(30,175);ctx.lineTo(28,168);ctx.lineTo(30,161);ctx.lineTo(34,155);ctx.lineTo(42,151);ctx.lineTo(53,150);ctx.lineTo(202,150);ctx.lineTo(229,144);ctx.lineTo(282,144);ctx.lineTo(282,192);ctx.fillStyle = arrFillColor[2];ctx.fill();ctx.lineWidth = arrBorderWidth[2];ctx.strokeStyle = arrBorderColor[2];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(716,117);ctx.lineTo(716,70);ctx.lineTo(770,70);ctx.lineTo(796,77);ctx.lineTo(946,77);ctx.lineTo(956,78);ctx.lineTo(964,81);ctx.lineTo(968,86);ctx.lineTo(970,94);ctx.lineTo(968,101);ctx.lineTo(964,106);ctx.lineTo(956,110);ctx.lineTo(946,111);ctx.lineTo(796,111);ctx.lineTo(771,117);ctx.lineTo(716,117);ctx.fillStyle = arrFillColor[3];ctx.fill();ctx.lineWidth = arrBorderWidth[3];ctx.strokeStyle = arrBorderColor[3];ctx.stroke();ctx.closePath();ctx.beginPath(); /* path */ ctx.moveTo(299,292);ctx.lineTo(700,292);ctx.lineTo(700,44);ctx.lineTo(299,44);ctx.lineTo(299,292);ctx.fillStyle = arrFillColor[4];ctx.fill();ctx.lineWidth = arrBorderWidth[4];ctx.strokeStyle = arrBorderColor[4];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(282,308));listpt.Add(new Point(282,28));listpt.Add(new Point(715,28));listpt.Add(new Point(715,308));listpt.Add(new Point(282,308));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(716,265));listpt.Add(new Point(716,217));listpt.Add(new Point(770,217));listpt.Add(new Point(796,224));listpt.Add(new Point(946,224));listpt.Add(new Point(956,225));listpt.Add(new Point(964,228));listpt.Add(new Point(968,233));listpt.Add(new Point(970,241));listpt.Add(new Point(968,248));listpt.Add(new Point(964,254));listpt.Add(new Point(956,258));listpt.Add(new Point(946,259));listpt.Add(new Point(796,259));listpt.Add(new Point(771,265));listpt.Add(new Point(716,265));sb = new SolidBrush(_listfillcolor[1]);p = new Pen(Color.Black);p.Width = _listborderwidth[1];p.Color = _listbordercolor[1];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(282,192));listpt.Add(new Point(229,192));listpt.Add(new Point(202,185));listpt.Add(new Point(53,185));listpt.Add(new Point(42,184));listpt.Add(new Point(34,180));listpt.Add(new Point(30,175));listpt.Add(new Point(28,168));listpt.Add(new Point(30,161));listpt.Add(new Point(34,155));listpt.Add(new Point(42,151));listpt.Add(new Point(53,150));listpt.Add(new Point(202,150));listpt.Add(new Point(229,144));listpt.Add(new Point(282,144));listpt.Add(new Point(282,192));sb = new SolidBrush(_listfillcolor[2]);p = new Pen(Color.Black);p.Width = _listborderwidth[2];p.Color = _listbordercolor[2];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(716,117));listpt.Add(new Point(716,70));listpt.Add(new Point(770,70));listpt.Add(new Point(796,77));listpt.Add(new Point(946,77));listpt.Add(new Point(956,78));listpt.Add(new Point(964,81));listpt.Add(new Point(968,86));listpt.Add(new Point(970,94));listpt.Add(new Point(968,101));listpt.Add(new Point(964,106));listpt.Add(new Point(956,110));listpt.Add(new Point(946,111));listpt.Add(new Point(796,111));listpt.Add(new Point(771,117));listpt.Add(new Point(716,117));sb = new SolidBrush(_listfillcolor[3]);p = new Pen(Color.Black);p.Width = _listborderwidth[3];p.Color = _listbordercolor[3];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
listpt = new List<Point>();listpt.Add(new Point(299,292));listpt.Add(new Point(700,292));listpt.Add(new Point(700,44));listpt.Add(new Point(299,44));listpt.Add(new Point(299,292));sb = new SolidBrush(_listfillcolor[4]);p = new Pen(Color.Black);p.Width = _listborderwidth[4];p.Color = _listbordercolor[4];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}