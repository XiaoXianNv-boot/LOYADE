using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace LOYADE.PIXIE
{
    public class Pixie
    {
        public Pixie()
        {
            _label = "Pixie";
            _angle = 0;
        }

        protected float _x;
        protected float _y;
        protected float _z;
        protected float _w;
        protected float _h;
        protected float _angle;
        protected List<Color> _listfillcolor;
        protected List<Color> _listbordercolor;
        protected List<float> _listborderwidth;
        protected string _content;
        protected string _label;

        public float X
        {
            get { return _x; }
            set { _x = value; }
        }

        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public float Z
        {
            get { return _z; }
            set { _z = value; }
        }

        public float W
        {
            get { return _w; }
            set { _w = value; }
        }

        public float H
        {
            get { return _h; }
            set { _h = value; }
        }

        public List<Color> ListFillColor
        {
            get { return _listfillcolor; }
            set { _listfillcolor = value; }
        }

        public List<Color> ListBorderColor
        {
            get { return _listbordercolor; }
            set { _listbordercolor = value; }
        }


        public List<float> ListBorderWidth
        {
            get { return _listborderwidth; }
            set { _listborderwidth = value; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public string Label
        {
            get { return _label; }
            set { _label = value; }
        }

        public virtual void Paint(Graphics g)
        {
        }

        public virtual void ChangeLabel(string l)
        {
            _label = l;
        }

        public virtual void ChangeAngle(float a)
        {
            _angle = a;
        }

        /// <summary>
        /// 全部填充颜色更换
        /// </summary> 
        /// <param name="intcolor"></param>
        public virtual void ChangeAllFillColorByInt(int intcolor)
        {
            for (int i = 0; i < _listfillcolor.Count; i++)
            {
                _listfillcolor[i] = Color.FromArgb(intcolor);
            }
        }

        public virtual void ChangeListFillColorByInt(int index, int intcolor)
        {
            if (index > 0 && index < _listfillcolor.Count)
            {
                _listfillcolor[index] = Color.FromArgb(intcolor);
            }
        }


        public virtual void ChangeListBorderColorByInt(int index, int intcolor)
        {
            if (index > 0 && index < _listbordercolor.Count)
            {
                _listbordercolor[index] = Color.FromArgb(intcolor);
            }
        }


        public virtual void ChangeListFillColorByHex(int index, string hexcolorstring)
        {
            if (index > 0 && index < _listfillcolor.Count)
            {
                _listfillcolor[index] = ColorTranslator.FromHtml(hexcolorstring);
            }
        }

        public virtual void ChangeListBorderColorByHex(int index, string hexcolorstring)
        {
            if (index > 0 && index < _listbordercolor.Count)
            {
                _listbordercolor[index] = ColorTranslator.FromHtml(hexcolorstring);
            }
        }

        public virtual void ChangeListBorderWidth(int index, float bw)
        {
            if (index > 0 && index < _listborderwidth.Count)
            {
                _listborderwidth[index] = bw;
            }
        }
    }
}
