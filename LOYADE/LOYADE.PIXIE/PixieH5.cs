using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOYADE.PIXIE
{
    public class PixieH5
    {
        public static PixieH5 GetInstance()
        {
            if (_pixieh5 == null)
            {
                _pixieh5 = new PixieH5();
            }
            return _pixieh5;
        }

        private static PixieH5 _pixieh5;

        protected PixieH5()
        {
            InitializeData();
            foreach (string catkey in _dicpixieh5.Keys)
            {
                foreach (string key in _dicpixieh5[catkey].Keys)
                {
                    _dicpixieh5[catkey][key].InitializeData();
                }
            }
        }

        protected string _content;

        public string Content
        {
            get { return _content; }
        }

        private Dictionary<string, Dictionary<string, PixieH5>> _dicpixieh5 = new Dictionary<string, Dictionary<string, PixieH5>>();

        public Dictionary<string, Dictionary<string, PixieH5>> DicPixieH5
        {
            get { return _dicpixieh5; }
        }

        public virtual void InitializeData()
        {
            
        }
    }
}
