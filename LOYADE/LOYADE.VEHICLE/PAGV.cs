using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Timers;

namespace LOYADE.VEHICLE
{
    public class PAGV : PortObject
    {
        private Timer _trun = new Timer();
        private Timer _tcharge = new Timer();
        private Timer _tloadunload = new Timer();

        private float _onpathsectionerror = 1.5f;
        private float _ontargetlocationerror = 3f;

        public PAGV()
        {
            _agvnextaction = AGVAction.Maintain;
            _direction = AGVDirection.None;
            _listcontainerplan = new List<PContainer>();
            _borderwidth = 1;
            _isrunning = false;
            _ismaintain = true;
            _issuspend = true;
            _ischarge = false;
            _energy = 100;
            _speed = 10000;
            _starttokendelay = 1;
            _loadunloaddelay = 3000;
            _chargespeed = 1;
            _w = 30;
            _h = 30;
            _chargelimit = 20f;
            _pathindex = 0;
            _fillcolor = Color.YellowGreen;
            _trun.Interval = 10000 / _speed;
            _trun.Elapsed += _trun_Elapsed;
            _trun.Start();
            _tcharge.Interval = 1000 / _chargespeed;
            _tcharge.Elapsed += _tcharge_Elapsed;
            _tcharge.Start();
            _tloadunload.Interval = _loadunloaddelay;
            _tloadunload.Elapsed += _tloadunload_Elapsed;
        }

        private void _tloadunload_Elapsed(object sender, ElapsedEventArgs e)
        {
            _isrunning = true;
            _tloadunload.Stop();
        }

        private void _tcharge_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_ischarge && !_issuspend)
            {
                if (_energy < 100)
                {
                    _energy++;
                    _isrunning = false;
                }
                else
                {
                    _ischarge = false;
                    _isrunning = true;
                }
            }
        }

        /*
         AGV运动逻辑：
         * 1、检查是否在路径段上，不在的话找到最近的路径段并定位
         * 2、检查下一个目标点坐标，按路径逆时针靠近目标，到达目标范围，停止3秒钟
         * 3、出堆区为右优先，出维修区为上优先，这样就不会撞车
         * 4、目标点是实时计算的，当AGV无负载，目标点为下一个集装箱的岸桥位置，当AGV有负载，目标点为当前集装箱的场桥位置
         * 5、当AGV能量低于警戒线，目标点是维修区原始起点，此时停止时间受充电定时器约束
         */
        private void _trun_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_starttokendelay > 1)
            {
                _starttokendelay--;
                return;
            }
            if (_isrunning && !_issuspend)
            {
                if (_energy > 0.01f)
                {
                    _energy -= 0.015f;
                    switch (_direction)
                    {
                        default:
                            break;
                        case AGVDirection.Up:
                            MoveUp();
                            break;
                        case AGVDirection.Down:
                            MoveDown();
                            break;
                        case AGVDirection.Left:
                            MoveLeft();
                            break;
                        case AGVDirection.Right:
                            MoveRight();
                            break;
                    }
                }
                else
                {
                    _isrunning = false;
                }
            }
        }

        public void GetNextTargetLocationAndAction()
        {
            if (_ischarge)
                return;
            //优先考虑是否需要充电，但若载有集装箱，仍优先将集装箱送到位置再返回维修区
            //有集装箱，目标为堆区场桥
            if (_carrycontainer != null)
            {
                _targetx = _carrycontainer.YardBridgeX;
                _targety = _carrycontainer.YardBridgeY;
                _agvnextaction = AGVAction.UnloadContainer;
            }
            else //无集装箱，目标为岸桥或维修区
            {
                //电力低下，返回维修区
                if (_energy < _chargelimit)
                {
                    _targetx = _xstart;
                    _targety = _ystart;
                    _agvnextaction = AGVAction.Charge;
                }
                else//去岸桥
                {
                    _targetx = _listcontainerplan[0].BerthBridgeX;
                    _targety = _listcontainerplan[0].BerthBridgeY;
                    _agvnextaction = AGVAction.LoadContainer;
                }
            }

        }

        private float GetDistance(float x1, float y1, float x2, float y2)
        {
            return Convert.ToSingle(Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)));
        }

        public void ActionAtTargetLocation(List<PYard> listyard, List<PShip> listship)
        {
            if (_ischarge)
                return;
            //只有到达目标位置才启动行为
            if (GetDistance(_xnow, _ynow, _targetx, _targety) < _ontargetlocationerror)
            {
                switch (_agvnextaction)
                {
                    default:
                        break;
                    case AGVAction.Charge:
                        _ischarge = true;
                        _isrunning = false;
                        break;
                    case AGVAction.UnloadContainer:
                        if (_carrycontainer != null)
                        {
                            //若到达堆区，从AGV卸载，堆场加载此集装箱
                            _isrunning = false;
                            _carrycontainer.UnloadToYardDateTime = DateTime.Now;
                            listyard[_carrycontainer.YardIndex].ListContainer.Add(_carrycontainer);
                            _carrycontainer = null;
                            _tloadunload.Start();
                        }
                        break;
                    case AGVAction.LoadContainer:
                        if (_listcontainerplan.Count > 0)
                        {
                            _isrunning = false;
                            //若到达泊位，装载到AGV，船舶移除此集装箱
                            Carry(_listcontainerplan[0]);
                            _carrycontainer.LoadToAGVDateTime = DateTime.Now;
                            listship[_listcontainerplan[0].ShipIndex].ListContainer.Remove(_listcontainerplan[0]);
                            _listcontainerplan.RemoveAt(0);
                            _tloadunload.Start();
                        }
                        break;
                    case AGVAction.StopImmediately:
                        _isrunning = false;
                        break;
                    case AGVAction.Maintain:
                        _ismaintain = true;
                        _isrunning = false;
                        _ischarge = false;
                        break;
                }
            }
        }

        private void GetNearestPathSectionIndex()
        {

        }

        private int FindMinIndex(float[] farr)
        {
            int iret = -1;
            if (farr.Length == 1)
                iret = 0;
            else if (farr.Length > 1)
            {
                float temp = farr[0];
                iret = 0;
                for (int i = 1; i < farr.Length; i++)
                {
                    if (farr[i] < temp)
                    {
                        temp = farr[i];
                        iret = i;
                    }
                }
            }
            return iret;
        }

        /// <summary>
        /// 取得方向，主要是保证AGV沿路径行驶
        /// </summary>
        /// <param name="listpath"></param>
        public void GetDirection(List<PAGVPath> listpath)
        {
            if (_ischarge)
                return;
            //如果是充电状态，且在0号或1号路径，立刻向下，到达维修区后归位，不再循迹
            if (_agvnextaction == AGVAction.Charge)
            {
                if (_pathsectionindex == 0 || _pathsectionindex == 1)
                {
                    if (GetDistance(_xnow, _ynow, _xnow, _targety) < _ontargetlocationerror)
                    {
                        if (_xnow > _targetx)
                            _direction = AGVDirection.Left;
                        else
                            _direction = AGVDirection.Right;
                    }
                    else
                        _direction = AGVDirection.Down;
                    return;
                }
            }
            float xcenter = _xnow + _w / 2;
            float ycenter = _ynow + _h / 2;
            //判断是否在路径段上，不在的话立即靠近
            int judgepathsectionindex = -1;
            float[] distancearr = new float[4];
            for (int i = 0; i < listpath[_pathindex].PathPoint.Count / 2; i++)
            {
                PointF pf1 = listpath[_pathindex].PathPoint[i * 2];
                PointF pf2 = listpath[_pathindex].PathPoint[i * 2 + 1];
                distancearr[i] = GetDistance(xcenter, ycenter, pf1.X, pf1.Y) + GetDistance(xcenter, ycenter, pf2.X, pf2.Y) - GetDistance(pf2.X, pf2.Y, pf1.X, pf1.Y);
                if (distancearr[i] < _onpathsectionerror)
                {
                    judgepathsectionindex = i;
                }
            }
            if (judgepathsectionindex == -1)//不在路径段上，判断目标位置与当前位置的关系得到方向
            {
                int nearestpathsection = FindMinIndex(distancearr);
                //此处优先保证AGV朝着下一个目标前进，否则会一直处于在和不在的状态切换
                if (_pathsectionindex == nearestpathsection)
                {
                    if (nearestpathsection < 3)
                        nearestpathsection++;
                    else
                        nearestpathsection = 0;
                }
                if (nearestpathsection == 0 || nearestpathsection == 2)
                {
                    if (xcenter > listpath[_pathindex].PathPoint[nearestpathsection * 2].X)
                        _direction = AGVDirection.Left;
                    else if (xcenter < listpath[_pathindex].PathPoint[nearestpathsection * 2].X)
                        _direction = AGVDirection.Right;
                    else
                    {
                        if (nearestpathsection == 0)
                        {
                            if (ycenter > listpath[_pathindex].PathPoint[nearestpathsection * 2 + 1].Y)
                                _direction = AGVDirection.Up;
                            else if (ycenter < listpath[_pathindex].PathPoint[nearestpathsection * 2].Y)
                                _direction = AGVDirection.Down;
                        }
                        else
                        {
                            if (ycenter > listpath[_pathindex].PathPoint[nearestpathsection * 2].Y)
                                _direction = AGVDirection.Up;
                            else if (ycenter < listpath[_pathindex].PathPoint[nearestpathsection * 2 + 1].Y)
                                _direction = AGVDirection.Down;
                        }
                    }
                }
                else
                {
                    if (ycenter > listpath[_pathindex].PathPoint[nearestpathsection * 2].Y)
                        _direction = AGVDirection.Up;
                    else if (ycenter < listpath[_pathindex].PathPoint[nearestpathsection * 2].Y)
                        _direction = AGVDirection.Down;
                    else
                    {
                        if (nearestpathsection == 1)
                        {
                            if (xcenter > listpath[_pathindex].PathPoint[nearestpathsection * 2 + 1].X)
                                _direction = AGVDirection.Left;
                            else if (xcenter < listpath[_pathindex].PathPoint[nearestpathsection * 2].X)
                                _direction = AGVDirection.Right;
                        }
                        else
                        {
                            if (xcenter > listpath[_pathindex].PathPoint[nearestpathsection * 2].X)
                                _direction = AGVDirection.Left;
                            else if (xcenter < listpath[_pathindex].PathPoint[nearestpathsection * 2 + 1].X)
                                _direction = AGVDirection.Right;
                        }
                    }
                }
            }
            else//在路径段上，逆时针行走
            {
                _pathsectionindex = judgepathsectionindex;
                //进一步纠正AGV位置使之完全在路径上
                if (_pathsectionindex == 0)
                {
                    _direction = AGVDirection.Down;
                    _xnow = listpath[_pathindex].PathPoint[_pathsectionindex * 2].X - _w / 2;
                }
                else if (_pathsectionindex == 1)
                {
                    _direction = AGVDirection.Right;
                    _ynow = listpath[_pathindex].PathPoint[_pathsectionindex * 2].Y - _h / 2;
                }
                else if (_pathsectionindex == 2)
                {
                    _direction = AGVDirection.Up;
                    _xnow = listpath[_pathindex].PathPoint[_pathsectionindex * 2].X - _w / 2;
                }
                else
                {
                    _direction = AGVDirection.Left;
                    _ynow = listpath[_pathindex].PathPoint[_pathsectionindex * 2].Y - _h / 2;
                }

            }
        }

        public override void Paint(Graphics g)
        {
            SolidBrush sb = new SolidBrush(Color.Orange);
            g.FillRectangle(sb, _xnow, _ynow, _w, _h);
            sb = new SolidBrush(_fillcolor);
            g.FillRectangle(sb, _xnow, _ynow, _w, _h * Convert.ToSingle(_energy / 100));
            SolidBrush sbstring = new SolidBrush(Color.Black);
            Font f = new Font("Arial", 6);
            g.DrawString(_label, f, sbstring, new PointF(_xnow + 3, _ynow + 3));
            g.DrawString(_energy.ToString("0.00"), f, sbstring, new PointF(_xnow + 3, _ynow + 15));
            base.Paint(g);
        }

        public void Carry(PContainer pc)
        {
            _carrycontainer = pc;
            _carrycontainer.XNow = _xnow + 10;
            _carrycontainer.YNow = _ynow + 10;
        }

        public override void MoveTo(float x, float y)
        {
            float deltax = _xnow - x;
            float deltay = _xnow - y;
            _xnow = x;
            _ynow = y;
            if (_carrycontainer != null)
            {
                _carrycontainer.XNow -= deltax;
                _carrycontainer.YNow -= deltay;
            }
        }

        private void MoveUp()
        {
            _ynow -= 0.5f;
            if (_carrycontainer != null)
            {
                _carrycontainer.YNow -= 0.5f;
            }
        }

        private void MoveDown()
        {
            _ynow += 0.5f;
            if (_carrycontainer != null)
            {
                _carrycontainer.YNow += 0.5f;
            }
        }

        private void MoveLeft()
        {
            _xnow -= 0.5f;
            if (_carrycontainer != null)
            {
                _carrycontainer.XNow -= 0.5f;
            }
        }

        private void MoveRight()
        {
            _xnow += 0.5f;
            if (_carrycontainer != null)
            {
                _carrycontainer.XNow += 0.5f;
            }
        }

        private List<PContainer> _listcontainerplan;

        [
            DisplayName("集装箱列表"),
            Category("调度参数")
        ]
        public List<PContainer> ListContainerPlan
        {
            get { return _listcontainerplan; }
            set { _listcontainerplan = value; }
        }

        private AGVAction _agvnextaction;

        [
            DisplayName("当前行为"),
            Category("只读"),
            ReadOnly(true)
        ]
        public AGVAction AGVNextAction
        {
            get { return _agvnextaction; }
            set { _agvnextaction = value; }
        }

        private AGVDirection _direction;

        [
            DisplayName("当前运动方向"),
            Category("只读"),
            ReadOnly(true)
        ]
        public AGVDirection Direction
        {
            get { return _direction; }
            set { _direction = value; }
        }

        private int _pathindex;

        [
            DisplayName("当前所在路径号"),
            Category("只读"),
            ReadOnly(true)
        ]
        public int PathIndex
        {
            get { return _pathindex; }
            set { _pathindex = value; }
        }

        private int _pathsectionindex;

        [
            DisplayName("当前所在路径线段号"),
            Category("只读"),
            ReadOnly(true)
        ]
        public int PathSectionIndex
        {
            get { return _pathsectionindex; }
            set { _pathsectionindex = value; }
        }

        private bool _issuspend;

        [
            DisplayName("是否暂停"),
            Category("只读"),
            ReadOnly(true)
        ]
        public bool IsSuspend
        {
            get { return _issuspend; }
            set { _issuspend = value; }
        }

        private bool _ischarge;

        [
            DisplayName("是否为充电状态"),
            Category("只读"),
            ReadOnly(true)
        ]
        public bool IsCharge
        {
            get { return _ischarge; }
            set { _ischarge = value; }
        }

        private bool _ismaintain;

        [
            DisplayName("是否为维修状态"),
            Category("只读"),
            ReadOnly(true)
        ]
        public bool IsMaintain
        {
            get { return _ismaintain; }
            set { _ismaintain = value; }
        }
        private bool _isrunning;

        [
            DisplayName("是否为运行状态"),
            Category("只读"),
            ReadOnly(true)
        ]
        public bool IsRunning
        {
            get { return _isrunning; }
            set { _isrunning = value; }
        }

        private float _targetx;

        [
            DisplayName("目标X位置"),
            Category("自动调度参数"),
            ReadOnly(true)
        ]
        public float TargetX
        {
            get { return _targetx; }
            set { _targetx = value; }
        }
        private float _targety;

        [
            DisplayName("目标Y位置"),
            Category("自动调度参数"),
            ReadOnly(true)
        ]
        public float TargetY
        {
            get { return _targety; }
            set { _targety = value; }
        }

        private float _chargelimit;

        [
            DisplayName("充电标志"),
            Category("调度参数"),
        ]
        public float ChargeLimit
        {
            get { return _chargelimit; }
            set { _chargelimit = value; }
        }

        private float _energy;

        [
            DisplayName("能量值"),
            Category("只读"),
            ReadOnly(true)
        ]
        public float Energy
        {
            get { return _energy; }
            set { _energy = value; }
        }

        private int _starttokendelay;

        [
            DisplayName("启动令牌延时"),
            Category("调度参数")
        ]
        public int StartTokenDelay
        {
            get { return _starttokendelay; }
            set
            {
                if (value > 0)
                    _starttokendelay = value;
                else
                    _starttokendelay = 1;
            }
        }

        private int _loadunloaddelay;

        [
            DisplayName("装卸载时延"),
            Category("调度参数")
        ]
        public int LoadUnloadDelay
        {
            get { return _loadunloaddelay; }
            set
            {
                if (value > 1000)
                    _loadunloaddelay = value;
                else
                    _loadunloaddelay = 3000;
            }
        }

        private int _chargespeed;

        [
            DisplayName("充电速度"),
            Category("调度参数")
        ]
        public int ChargeSpeed
        {
            get { return _chargespeed; }
            set
            {
                if (value > 0)
                    _chargespeed = value;
                else
                    _chargespeed = 1;
                _tcharge.Interval = 1000 / _chargespeed;
            }
        }

        private float _speed;

        [
            DisplayName("速度"),
            Category("调度参数")
        ]
        public float Speed
        {
            get { return _speed; }
            set
            {
                if (value < 10001 && value > 0)
                    _speed = value;
                else
                    _speed = 100;
                _trun.Interval = 10000 / _speed;
            }
        }

        private PContainer _carrycontainer;

        [
            DisplayName("承载的集装箱"),
            Category("只读"),
            ReadOnly(true)
        ]
        public PContainer CarryContainer
        {
            get { return _carrycontainer; }
            set { _carrycontainer = value; }
        }


    }
}
