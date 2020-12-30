using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.PIXIE.DataPixieH5ASHRAEDuct
{
    public class PIXIE_94554c6c_7f1f_49b4_a58b_efdfc8385447 : Pixie
    {
        public PIXIE_94554c6c_7f1f_49b4_a58b_efdfc8385447()
        { 
            _listfillcolor = new List<Color>();
            _listbordercolor = new List<Color>();
            _listborderwidth = new List<float>();
            
            _x = 0f;
            _y = 0f;
            _z = 0f; 

            _listfillcolor.Add(ColorTranslator.FromHtml("#0ff"));_listborderwidth.Add(2);_listbordercolor.Add(ColorTranslator.FromHtml("#000"));
_w = 970f; _h = 970f;
_content = "var arrFillColor = new Array(1); var arrBorderColor = new Array(1); var arrBorderWidth = new Array(1); arrFillColor[0] = '#0ff'; arrBorderColor[0] = '#000'; arrBorderWidth[0] = '2'; ctx.beginPath(); /* path */ ctx.moveTo(970,970);ctx.lineTo(922,969);ctx.lineTo(874,965);ctx.lineTo(827,959);ctx.lineTo(781,951);ctx.lineTo(736,940);ctx.lineTo(691,928);ctx.lineTo(647,913);ctx.lineTo(604,896);ctx.lineTo(562,877);ctx.lineTo(522,856);ctx.lineTo(482,833);ctx.lineTo(444,809);ctx.lineTo(407,782);ctx.lineTo(372,754);ctx.lineTo(338,725);ctx.lineTo(305,693);ctx.lineTo(273,660);ctx.lineTo(244,626);ctx.lineTo(216,591);ctx.lineTo(189,554);ctx.lineTo(165,516);ctx.lineTo(142,476);ctx.lineTo(121,436);ctx.lineTo(102,394);ctx.lineTo(85,351);ctx.lineTo(70,307);ctx.lineTo(58,262);ctx.lineTo(47,217);ctx.lineTo(39,171);ctx.lineTo(33,124);ctx.lineTo(29,76);ctx.lineTo(28,28);ctx.lineTo(420,28);ctx.lineTo(420,56);ctx.lineTo(423,84);ctx.lineTo(426,111);ctx.lineTo(431,139);ctx.lineTo(437,165);ctx.lineTo(445,191);ctx.lineTo(453,217);ctx.lineTo(463,242);ctx.lineTo(474,266);ctx.lineTo(486,290);ctx.lineTo(500,313);ctx.lineTo(514,335);ctx.lineTo(529,357);ctx.lineTo(546,378);ctx.lineTo(563,398);ctx.lineTo(581,417);ctx.lineTo(600,435);ctx.lineTo(620,452);ctx.lineTo(641,469);ctx.lineTo(663,484);ctx.lineTo(685,498);ctx.lineTo(708,512);ctx.lineTo(732,524);ctx.lineTo(756,535);ctx.lineTo(781,545);ctx.lineTo(807,553);ctx.lineTo(833,561);ctx.lineTo(859,567);ctx.lineTo(887,572);ctx.lineTo(914,575);ctx.lineTo(942,578);ctx.lineTo(970,578);ctx.lineTo(970,970);ctx.fillStyle = arrFillColor[0];ctx.fill();ctx.lineWidth = arrBorderWidth[0];ctx.strokeStyle = arrBorderColor[0];ctx.stroke();ctx.closePath();";
        }


        public override void Paint(Graphics g)
        { 
            SolidBrush sb;
            Pen p;
            List<Point> listpt;
            
listpt = new List<Point>();listpt.Add(new Point(970,970));listpt.Add(new Point(922,969));listpt.Add(new Point(874,965));listpt.Add(new Point(827,959));listpt.Add(new Point(781,951));listpt.Add(new Point(736,940));listpt.Add(new Point(691,928));listpt.Add(new Point(647,913));listpt.Add(new Point(604,896));listpt.Add(new Point(562,877));listpt.Add(new Point(522,856));listpt.Add(new Point(482,833));listpt.Add(new Point(444,809));listpt.Add(new Point(407,782));listpt.Add(new Point(372,754));listpt.Add(new Point(338,725));listpt.Add(new Point(305,693));listpt.Add(new Point(273,660));listpt.Add(new Point(244,626));listpt.Add(new Point(216,591));listpt.Add(new Point(189,554));listpt.Add(new Point(165,516));listpt.Add(new Point(142,476));listpt.Add(new Point(121,436));listpt.Add(new Point(102,394));listpt.Add(new Point(85,351));listpt.Add(new Point(70,307));listpt.Add(new Point(58,262));listpt.Add(new Point(47,217));listpt.Add(new Point(39,171));listpt.Add(new Point(33,124));listpt.Add(new Point(29,76));listpt.Add(new Point(28,28));listpt.Add(new Point(420,28));listpt.Add(new Point(420,56));listpt.Add(new Point(423,84));listpt.Add(new Point(426,111));listpt.Add(new Point(431,139));listpt.Add(new Point(437,165));listpt.Add(new Point(445,191));listpt.Add(new Point(453,217));listpt.Add(new Point(463,242));listpt.Add(new Point(474,266));listpt.Add(new Point(486,290));listpt.Add(new Point(500,313));listpt.Add(new Point(514,335));listpt.Add(new Point(529,357));listpt.Add(new Point(546,378));listpt.Add(new Point(563,398));listpt.Add(new Point(581,417));listpt.Add(new Point(600,435));listpt.Add(new Point(620,452));listpt.Add(new Point(641,469));listpt.Add(new Point(663,484));listpt.Add(new Point(685,498));listpt.Add(new Point(708,512));listpt.Add(new Point(732,524));listpt.Add(new Point(756,535));listpt.Add(new Point(781,545));listpt.Add(new Point(807,553));listpt.Add(new Point(833,561));listpt.Add(new Point(859,567));listpt.Add(new Point(887,572));listpt.Add(new Point(914,575));listpt.Add(new Point(942,578));listpt.Add(new Point(970,578));listpt.Add(new Point(970,970));sb = new SolidBrush(_listfillcolor[0]);p = new Pen(Color.Black);p.Width = _listborderwidth[0];p.Color = _listbordercolor[0];g.FillPolygon(sb, listpt.ToArray());g.DrawPolygon(p, listpt.ToArray());
        }
    }
}