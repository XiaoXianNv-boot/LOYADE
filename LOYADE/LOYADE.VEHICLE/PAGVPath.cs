using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace LOYADE.VEHICLE
{
    public class PAGVPath : PortObject
    {
        public PAGVPath()
        {
            _pathpoint = new List<PointF>();
        }

        private List<PointF> _pathpoint;

        public List<PointF> PathPoint
        {
            get { return _pathpoint; }
            set { _pathpoint = value; }
        }

        private PointF[] _pathpointarray;

        public PointF[] PathPointArray
        {
            get { return _pathpointarray; }
            set { _pathpointarray = value; }
        }

        /// <summary>
        /// 8个点组成四条线段
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        public void GeneratePathSectionPoint(float x, float y, float x2, float y2)
        {
            //注意这里的点顺序要和AGV的规划一致
            //当前AGV使用的是逆时针运行
            PointF pf = new PointF(x, y);//0 ------| 左-------
            _pathpoint.Add(pf);
            pf = new PointF(x, y2);
            _pathpoint.Add(pf);
            pf = new PointF(x, y2);//1 ------下__-------
            _pathpoint.Add(pf);
            pf = new PointF(x2, y2);
            _pathpoint.Add(pf);
            pf = new PointF(x2, y2);//2 ------右 |-------
            _pathpoint.Add(pf);
            pf = new PointF(x2, y);
            _pathpoint.Add(pf);
            pf = new PointF(x2, y);//3 ------上-------
            _pathpoint.Add(pf);
            pf = new PointF(x, y);
            _pathpoint.Add(pf);
            _pathpointarray = _pathpoint.ToArray();
            //PointF pf = new PointF(x, y);
            //_pathpoint.Add(pf);
            //pf = new PointF(x, y + h);
            //_pathpoint.Add(pf);
            //pf = new PointF(x, y + h);
            //_pathpoint.Add(pf);
            //pf = new PointF(x + w, y + h);
            //_pathpoint.Add(pf);
            //pf = new PointF(x + w, y + h);
            //_pathpoint.Add(pf);
            //pf = new PointF(x + w, y);
            //_pathpoint.Add(pf);
            //pf = new PointF(x + w, y);
            //_pathpoint.Add(pf);
            //pf = new PointF(x, y);
            //_pathpoint.Add(pf);
            //顺时针
            //PointF pf = new PointF(x, y);
            //_pathpoint.Add(pf);
            //pf = new PointF(x + w, y);
            //_pathpoint.Add(pf);
            //pf = new PointF(x + w, y);
            //_pathpoint.Add(pf);
            //pf = new PointF(x + w, y + h);
            //_pathpoint.Add(pf);
            //pf = new PointF(x + w, y + h);
            //_pathpoint.Add(pf);
            //pf = new PointF(x, y + h);
            //_pathpoint.Add(pf);
            //pf = new PointF(x, y + h);
            //_pathpoint.Add(pf);
            //pf = new PointF(x, y);
            //_pathpoint.Add(pf);
        }

        public override void Paint(Graphics g)
        {
            Pen p = new Pen(Color.SlateGray, 1);
            p.DashStyle = DashStyle.DashDotDot;
            g.DrawLines(p, _pathpoint.ToArray());
        }

     
    }
}
