using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LOYADE.VEHICLE
{
    public class Port : PortObject
    {
        public Port()
        {
            _bordercolor = Color.Black;
            _borderwidth = 3;
            _xstart = 100;
            _ystart = 40;
            _xnow = 100;
            _ynow = 40;
            _w = 1000;
            _h = 700;
            _agvrunningcount = 4;
            _pathcount = 3;
            _shipcount = 10;
            _agvcount = 30;
            _label = "港口对象";
        }

        private int _pathcount;

        [
            DisplayName("固定路径数量"),
            Category("数据")
        ]
        public int PathCount
        {
            get { return _pathcount; }
            set
            {
                if (value > 0)
                    _pathcount = value;
                else
                    _pathcount = 1;
            }
        }

        private int _shipcount;

        [
            DisplayName("船舶数量"),
            Category("数据")
        ]
        public int ShipCount
        {
            get { return _shipcount; }
            set
            {
                if (value > 0)
                    _shipcount = value;
                else
                    _shipcount = 1;
            }
        }

        private int _agvrunningcount;

        [
            DisplayName("AGV同时运行数量"),
            Category("数据")
        ]
        public int AgvRunningCount
        {
            get { return _agvrunningcount; }
            set
            {
                if (value > 0)
                    _agvrunningcount = value;
                else
                    _agvrunningcount = 1;
            }
        }

        private int _agvcount;

        [
            DisplayName("AGV数量"),
            Category("数据")
        ]
        public int AgvCount
        {
            get { return _agvcount; }
            set
            {
                if (value > 0)
                    _agvcount = value;
                else
                    _agvcount = 1;
            }
        }
        private int _berthcount = 3;

        [
            DisplayName("泊位数量"),
            Category("数据")
        ]
        public int BerthCount
        {
            get { return _berthcount; }
            set
            {
                if (value > 0)
                    _berthcount = value;
                else
                    _berthcount = 1;
            }
        }
        private int _berthbridgepercount = 3;

        [
            DisplayName("泊位岸桥单位数量"),
            Category("数据")
        ]
        public int BerthBridgePerCount
        {
            get { return _berthbridgepercount; }
            set
            {
                if (value > 0)
                    _berthbridgepercount = value;
                else
                    _berthbridgepercount = 1;
            }
        }
        private int _maintaincount = 1;

        [
            DisplayName("维修区数量"),
            Category("数据")
        ]
        public int MaintainCount
        {
            get { return _maintaincount; }
            set
            {
                if (value > 0)
                    _maintaincount = value;
                else
                    _maintaincount = 1;
            }
        }
        private int _yardcount = 4;

        [
            DisplayName("堆区数量"),
            Category("数据")
        ]
        public int YardCount
        {
            get { return _yardcount; }
            set
            {
                if (value > 0)
                    _yardcount = value;
                else
                    _yardcount = 1;
            }
        }
        private int _yardbridgepercount = 1;

        [
            DisplayName("堆区场桥单位数量"),
            Category("数据")
        ]
        public int YardBridgePerCount
        {
            get { return _yardbridgepercount; }
            set
            {
                if (value > 0)
                    _yardbridgepercount = value;
                else
                    _yardbridgepercount = 1;
            }
        }
    }
}
