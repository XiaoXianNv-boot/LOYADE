using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LOYADE.VEHICLE
{
    public class PortObject
    {
        public PortObject()
        {
            _bordercolor = Color.Black;
            _borderwidth = 3;
            _xstart = 50;
            _ystart = 50;
        }


        public override string ToString()
        {
            return _label;
        }

        public virtual void MoveTo(float x, float y)
        {
            _xnow = x;
            _ynow = y;
        }

        public virtual void Move(float deltax, float deltay)
        {
            _xnow += deltax;
            _ynow += deltay;
        }


        public virtual void Paint(Graphics g)
        {
            Pen p = new Pen(_bordercolor, _borderwidth);
            g.DrawRectangle(p, _xnow, _ynow, _w, _h);
        }

        protected int _index;

        [
            DisplayName("ID索引号"),
            Category("只读"),
            ReadOnly(true)
        ]
        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

        protected float _borderwidth;

        [
            DisplayName("边框宽度"),
            Category("外观")
        ]
        public float BorderWidth
        {
            get { return _borderwidth; }
            set { _borderwidth = value; }
        }

        protected Color _fillcolor;

        [
            DisplayName("填充颜色"),
            Category("外观")
        ]
        public Color FillColor
        {
            get { return _fillcolor; }
            set { _fillcolor = value; }
        }

        protected Color _bordercolor;

        [
            DisplayName("边框颜色"),
            Category("外观")
        ]
        public Color BorderColor
        {
            get { return _bordercolor; }
            set { _bordercolor = value; }
        }

        protected string _label;

        [
            DisplayName("标签"),
            Category("外观")
        ]
        public string Label
        {
            get { return _label; }
            set { _label = value; }
        }

        protected float _xnow;

        [
            DisplayName("当前X位置"),
            Category("外观")
        ]
        public float XNow
        {
            get { return _xnow; }
            set { _xnow = value; }
        }
        protected float _ynow;

        [
            DisplayName("当前Y位置"),
            Category("外观")
        ]
        public float YNow
        {
            get { return _ynow; }
            set { _ynow = value; }
        }

        protected float _xstart;

        [
            DisplayName("初始X位置"),
            Category("外观")
        ]
        public float XStart
        {
            get { return _xstart; }
            set { _xstart = value; }
        }
        protected float _ystart;

        [
            DisplayName("初始Y位置"),
            Category("外观")
        ]
        public float YStart
        {
            get { return _ystart; }
            set { _ystart = value; }
        }
        protected float _w;

        [
            DisplayName("宽度"),
            Category("外观")
        ]
        public float W
        {
            get { return _w; }
            set { _w = value; }
        }
        protected float _h;

        [
            DisplayName("高度"),
            Category("外观")
        ]
        public float H
        {
            get { return _h; }
            set { _h = value; }
        }
    }
}
