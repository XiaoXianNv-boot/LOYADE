using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Data;
using System.Drawing;

namespace LOYADE.BPM
{
    public class ObjectArc : ObjectPN
    {
        public ObjectArc()
        {            
            _selectedpointindex = 0;
            _listpoints = new List<Point>();
            _listconditions = new List<string>();
            _listoperations = new List<string>();
        }

        public bool CheckConditions(ObjectToken t, int simulatorcount)
        {
            ActionFilter f = ActionFilter.GetInstance();
            if (_listconditions.Count > 0)
            {
                bool serialbool = f.ConditionCheck(t, _listconditions[0], true, simulatorcount);
                for (int i = 1; i < _listconditions.Count; ++i)
                {
                    serialbool = f.ConditionCheck(t, _listconditions[i], serialbool, simulatorcount);
                }
                return serialbool;
            }
            else
                return true;
        }

        public bool IsContainPath(int x, int y)
        {
            bool bret = false;
            if (_listpoints.Count > 2)
            {
                //起点和终点是不可以选取的
                for (int i = 1; i < _listpoints.Count - 1; i++)
                {
                    if (Math.Abs(_listpoints[i].X - x) < 5 && Math.Abs(_listpoints[i].Y - y) < 5)
                    {
                        _selectedpointindex = i;
                        return true;
                    }
                }
                _selectedpointindex = 0;//没点选任何中间节点，被选节点置0
            }
            return bret;
        }


        public override bool IsContain(int x, int y)
        {
            bool bret = false;
            if (_listpoints.Count == 2)
            {
                Point p1;
                Point p2;
                for (int i = 1; i < _listpoints.Count; i++)
                {
                    p1 = _listpoints[i - 1];
                    p2 = _listpoints[i];
                    if (Math.Sqrt((x - p1.X) * (x - p1.X) + (y - p1.Y) * (y - p1.Y)) + Math.Sqrt((x - p2.X) * (x - p2.X) + (y - p2.Y) * (y - p2.Y)) - Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y)) < 1)
                        return true;
                }
            }
            return bret;
        }

        protected int _selectedpointindex;

        public int SelectedPointIndex
        {
            get { return _selectedpointindex; }
            set { _selectedpointindex = value; }
        }

        public void Operate(ObjectToken t, int simulationcount)
        {
            ActionFilter f = ActionFilter.GetInstance();
            foreach (string o in _listoperations)
            {
                f.Operate(t, o, simulationcount);
            }
        }

        private List<string> _listconditions;

        [
            Browsable(false)
        ]
        public List<string> ListConditions
        {
            get { return _listconditions; }
            set { _listconditions = value; }
        }

        private List<string> _listoperations;

        [
            Browsable(false)
        ]
        public List<string> ListOperations
        {
            get { return _listoperations; }
            set { _listoperations = value; }
        }

        private ObjectPN _prepno;

        public ObjectPN PrePNO
        {
            get { return _prepno; }
            set { _prepno = value; }
        }

        [
            DisplayName("Center X"),
            CategoryAttribute("Appearance"),
            DescriptionAttribute("Center X"),
            ReadOnlyAttribute(false)
        ]
        public int CenterX
        {
            get { return _listpoints[1].X; }
            set
            {
                _listpoints[1] = new Point(value, _listpoints[1].Y);
            }
        }

        [
            DisplayName("Center Y"),
            CategoryAttribute("Appearance"),
            DescriptionAttribute("Center Y"),
            ReadOnlyAttribute(false)
        ]
        public int CenterY
        {
            get { return _listpoints[1].Y; }
            set
            {
                _listpoints[1] = new Point(_listpoints[1].X, value);
            }
        }

        private ObjectPN _postpno;

        public ObjectPN PostPNO
        {
            get { return _postpno; }
            set { _postpno = value; }
        }

        public override string ToString()
        {
            return "LOYADE.BPM.ObjectArc";
        }

        public override void RefreshObject(Graphics g)
        {
            Pen p = new Pen(Color.Black, 3);
            switch (this.ArcType)
            {
                default:
                    p.EndCap = LineCap.Custom;
                    p.CustomEndCap = GetFilledArrowCap();
                    break;
                case ArcType.ObserveControl:
                    p.DashStyle = DashStyle.Dash;
                    p.EndCap = LineCap.Custom;
                    p.CustomEndCap = GetNoFilledArrowCap();
                    break;
                case ArcType.Inhibitor://只能库所到变迁                    
                    p.Color = Color.Red;
                    break;
            }
            if (_selected)
            {
                p.Color = Color.Green;
                p.Width = 6;
            }
            if (_listpoints.Count > 1)
            {
                if (this.Curved)
                    g.DrawCurve(p, _listpoints.ToArray());
                else
                    g.DrawLines(p, _listpoints.ToArray());
                SolidBrush sbpath = new SolidBrush(Color.Black);
                for (int i = 1; i < _listpoints.Count - 1; i++)
                {
                    if (_selectedpointindex == i)
                    {
                        sbpath.Color = Color.Green;
                        g.DrawEllipse(p, _listpoints[i].X - 10, _listpoints[i].Y - 10, 20, 20);
                    }
                    else
                    {
                        sbpath.Color = Color.Black;
                    }
                    g.FillEllipse(sbpath, _listpoints[i].X - 5, _listpoints[i].Y - 5, 10, 10);
                }
            }
        }

        private CustomLineCap GetFilledArrowCap()
        {
            //自定义箭头
            float acw = 6;
            float ach = 6;
            bool acf = true;
            AdjustableArrowCap myAC = new AdjustableArrowCap(acw, ach, acf);
            return myAC;
        }

        private CustomLineCap GetNoFilledArrowCap()
        {
            //自定义箭头
            float acw = 8;
            float ach = 8;
            bool acf = false;
            AdjustableArrowCap myAC = new AdjustableArrowCap(acw, ach, acf);
            return myAC;
        }

        [
            Browsable(false)
        ]
        public string Operations
        {
            get { return _drdata["Operations"].ToString(); }
            set
            {
                _drdata["Operations"] = value;
                if (value == "")
                    _listoperations.Clear();
            }
        }

        [
            Browsable(false)
        ]
        public string Conditions
        {
            get { return _drdata["Conditions"].ToString(); }
            set
            {
                _drdata["Conditions"] = value;
                if (value == "")
                    _listconditions.Clear();
            }
        }

        [
            DisplayName("Operated Post ObjectPlace Property Label"),
            CategoryAttribute("Design"),
            DescriptionAttribute("Operated PostPlace Property Label"),
            ReadOnlyAttribute(true)
        ]
        public string OperatedPostPlacePropertyName
        {
            get { return _drdata["OperatedPostPlacePropertyName"].ToString(); }
            set { _drdata["OperatedPostPlacePropertyName"] = value; }
        }

        [
            DisplayName("Convex"),
            CategoryAttribute("Appearance"),
            DescriptionAttribute("Convex"),
            ReadOnlyAttribute(false)
        ]
        public bool Convex
        {
            get { return (bool)_drdata["Convex"]; }
            set
            {
                _drdata["Convex"] = value;
                GetArcPathPoint();
            }
        }

        [
            DisplayName("Curved"),
            CategoryAttribute("Appearance"),
            DescriptionAttribute("Curved"),
            ReadOnlyAttribute(false)
        ]
        public bool Curved
        {
            get { return (bool)_drdata["Curved"]; }
            set { _drdata["Curved"] = value; }
        }

        [
            DisplayName("Inscription"),
            CategoryAttribute("Data"),
            DescriptionAttribute("Inscription"),
            ReadOnlyAttribute(false)
        ]
        public int Inscription
        {
            get { return (int)_drdata["Inscription"]; }
            set { _drdata["Inscription"] = value; }
        }

        private List<Point> _listpoints;

        [Browsable(false)]
        public List<Point> ListPoint
        {
            get { return _listpoints; }
            set { _listpoints = value; }
        }

        [Browsable(false)]
        public string Points
        {
            get
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                if (_listpoints.Count > 0)
                {
                    sb.Append(_listpoints[0].X.ToString());
                    sb.Append("|");
                    sb.Append(_listpoints[0].Y.ToString());

                    for (int i = 1; i < _listpoints.Count; ++i)
                    {
                        sb.Append("|");
                        sb.Append(_listpoints[i].X.ToString());
                        sb.Append("|");
                        sb.Append(_listpoints[i].Y.ToString());
                    }
                }
                return sb.ToString();
            }
        }

        [
            DisplayName("Start SN"),
            DescriptionAttribute("Start SN"),
            ReadOnlyAttribute(true)
        ]
        public string StartSN
        {
            get { return _drdata["StartSN"].ToString(); }
            set { _drdata["StartSN"] = value; }
        }

        [
            DisplayName("End SN"),
            DescriptionAttribute("End SN"),
            ReadOnlyAttribute(true)
        ]
        public string EndSN
        {
            get { return _drdata["EndSN"].ToString(); }
            set { _drdata["EndSN"] = value; }
        }

        [
            DisplayName("Start ID"),
            DescriptionAttribute("Start ID"),
            ReadOnlyAttribute(true)
        ]
        public string StartID
        {
            get { return _drdata["StartID"].ToString(); }
            set { _drdata["StartID"] = value; }
        }

        [
            DisplayName("End ID"),
            DescriptionAttribute("End ID"),
            ReadOnlyAttribute(true)
        ]
        public string EndID
        {
            get { return _drdata["EndID"].ToString(); }
            set { _drdata["EndID"] = value; }
        }

        [
           DisplayName("Start Type"),
           DescriptionAttribute("Start Type"),
           ReadOnlyAttribute(true)
       ]
        public PNObjectType StartType
        {
            get { return (PNObjectType)Enum.Parse(typeof(PNObjectType), _drdata["StartType"].ToString()); }
            set { _drdata["StartType"] = value; }
        }

        [
            DisplayName("End Type"),
            DescriptionAttribute("End Type"),
            ReadOnlyAttribute(true)
        ]
        public PNObjectType EndType
        {
            get { return (PNObjectType)Enum.Parse(typeof(PNObjectType), _drdata["EndType"].ToString()); }
            set { _drdata["EndType"] = value; }
        }

        [
           DisplayName("ObjectArc Type"),
           CategoryAttribute("Design"),
           DescriptionAttribute("ObjectArc Type"),
           ReadOnlyAttribute(false)
        ]
        public ArcType ArcType
        {
            get { return (ArcType)Enum.Parse(typeof(ArcType), _drdata["ArcType"].ToString()); }
            set
            {
                _drdata["ArcType"] = value.ToString();
                if (value != ArcType.Normal)
                {
                    if (this.ArcFlowType == ArcFlowType.Input && value == ArcType.Inhibitor)
                        _drdata["ArcType"] = "Normal";
                }
            }
        }

        [
           DisplayName("ObjectArc Flow Type"),
           DescriptionAttribute("ObjectArc Flow Type"),
           ReadOnlyAttribute(true)
        ]
        public ArcFlowType ArcFlowType
        {
            get { return (ArcFlowType)Enum.Parse(typeof(ArcFlowType), _drdata["ArcFlowType"].ToString()); }
            set { _drdata["ArcFlowType"] = value.ToString(); }
        }

        public override ObjectPN Clone(DataSet ds, string netname)
        {
            string type = this.GetType().FullName;
            ObjectArc pno = new ObjectArc();
            pno.NetName = netname;
            if (!ds.Tables.Contains(type))
            {
                DataTable dt = new DataTable(type);
                pno.GenerateDataTableColumns(dt);
                ds.Tables.Add(dt);
            }
            pno.CreateDataRow(ds.Tables[type]);
            base.ClonePetriNetObject(this, pno);
            return pno;
        }

        public override void Serialize()
        {
            base.SerializePNO();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            System.Text.StringBuilder sbc = new System.Text.StringBuilder();
            System.Text.StringBuilder sbo = new System.Text.StringBuilder();

            if (_listpoints.Count > 0)
            {
                sb.Append(_listpoints[0].X.ToString());
                sb.Append("|");
                sb.Append(_listpoints[0].Y.ToString());

                for (int i = 1; i < _listpoints.Count; ++i)
                {
                    sb.Append("|");
                    sb.Append(_listpoints[i].X.ToString());
                    sb.Append("|");
                    sb.Append(_listpoints[i].Y.ToString());
                }
            }
            for (int i = 0; i < _listconditions.Count; ++i)
            {
                sbc.Append(_listconditions[i]);
                sbc.Append(",");
            }
            for (int i = 0; i < _listoperations.Count; ++i)
            {
                sbo.Append(_listoperations[i]);
                sbo.Append(",");
            }
            _drdata["Points"] = sb.ToString();
            _drdata["Conditions"] = sbc.ToString();
            _drdata["Operations"] = sbo.ToString();
        }

        /// <summary>
        /// 弧的反序列化：调用该方法应该在库所变迁之后
        /// </summary>
        public override void DeSerialize()
        {
            _listpoints = new List<Point>();
            string[] arr = _drdata["Points"].ToString().Split(',');
            for (int i = 0; i < arr.Length - 1; i += 2)
            {
                if (arr[i].Trim() != "" && arr[i + 1].Trim() != "")
                {
                    _listpoints.Add(new Point(int.Parse(arr[i]), int.Parse(arr[i + 1])));
                }
            }
            arr = _drdata["Conditions"].ToString().Split(',');
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i].Trim() != "")
                {
                    _listconditions.Add(arr[i]);
                }
            }
            arr = _drdata["Operations"].ToString().Split(',');
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i].Trim() != "")
                {
                    _listoperations.Add(arr[i]);
                }
            }
            base.DeSerializePNO();
        }

        public override void GenerateDataTableColumns(DataTable dt)
        {
            base.GenerateDataTableColumns(dt);
            dt.Columns.Add(new DataColumn("Conditions", typeof(string)));
            dt.Columns.Add(new DataColumn("Operations", typeof(string)));
            dt.Columns.Add(new DataColumn("Inscription", typeof(int)));
            dt.Columns.Add(new DataColumn("StartID", typeof(string)));
            dt.Columns.Add(new DataColumn("EndID", typeof(string)));
            dt.Columns.Add(new DataColumn("StartSN", typeof(string)));
            dt.Columns.Add(new DataColumn("EndSN", typeof(string)));
            dt.Columns.Add(new DataColumn("StartType", typeof(string)));
            dt.Columns.Add(new DataColumn("EndType", typeof(string)));
            dt.Columns.Add(new DataColumn("ArcFlowType", typeof(string)));
            dt.Columns.Add(new DataColumn("ArcType", typeof(string)));
            dt.Columns.Add(new DataColumn("Curved", typeof(bool)));
            dt.Columns.Add(new DataColumn("OperatedPostPlacePropertyName", typeof(string)));
            dt.Columns.Add(new DataColumn("Convex", typeof(bool)));
            dt.Columns.Add(new DataColumn("Points", typeof(string)));
        }

        public override void CreateDataRow(DataTable dt)
        {
            base.CreateDataRow(dt);
            _drdata["ID"] = Guid.NewGuid().ToString();
            _drdata["SN"] = Guid.NewGuid().ToString();
            _drdata["Label"] = "A [" + DateTime.Now.ToString("MMddhhmmssffff") + " ]";
            _drdata["Curved"] = false;
            _drdata["Convex"] = false;
            _drdata["Inscription"] = 0;
            _drdata["ArcFlowType"] = "NotSet";
            _drdata["ArcType"] = "Normal";
            _drdata["Conditions"] = "";
            _drdata["Operations"] = "";
        }

        public override void AddPrePNO(ObjectPN pno)
        {
            _prepno = pno;
        }

        public override void AddPostPNO(ObjectPN pno)
        {
            _postpno = pno;
        }

        public void AdjustStartAndEndPoint()
        {
            if (_listpoints.Count < 2)
                return;
            int endindex = _listpoints.Count - 1;
            //起点修正
            _listpoints[0] = new Point(_prepno.X + _prepno.Width / 2, _prepno.Y + _prepno.Height / 2);
            //终点修正
            if (_postpno.Y - _listpoints[endindex - 1].Y < -_postpno.Height)//终点在上一点的上方
            {
                if (_postpno.X - _listpoints[endindex - 1].X < -_postpno.Width)
                    _listpoints[endindex] = new Point(_postpno.X + _postpno.Width, _postpno.Y + _postpno.Height);
                else if (_postpno.X - _listpoints[endindex - 1].X > _postpno.Width)
                    _listpoints[endindex] = new Point(_postpno.X, _postpno.Y + _postpno.Height);
                else
                    _listpoints[endindex] = new Point(_postpno.X + _postpno.Width / 2, _postpno.Y + _postpno.Height);
            }
            else if (_postpno.Y - _listpoints[endindex - 1].Y > _postpno.Height)//终点在上一点的下方
            {
                if (_postpno.X - _listpoints[endindex - 1].X < -_postpno.Width)
                    _listpoints[endindex] = new Point(_postpno.X + _postpno.Width, _postpno.Y);
                else if (_postpno.X - _listpoints[endindex - 1].X > _postpno.Width)
                    _listpoints[endindex] = new Point(_postpno.X, _postpno.Y);
                else
                    _listpoints[endindex] = new Point(_postpno.X + _postpno.Width / 2, _postpno.Y);
            }
            else//Y值相差在-50 ~ 50之间时
            {
                if (_postpno.X < _listpoints[endindex - 1].X)//终点在左侧
                    _listpoints[endindex] = new Point(_postpno.X + _postpno.Width, _postpno.Y + _postpno.Height / 2);
                else
                    _listpoints[endindex] = new Point(_postpno.X, _postpno.Y + _postpno.Height / 2);
            }
        }

        public void GetArcPathPoint()
        {
            _listpoints = new List<Point>();
            if (_prepno.Y < _postpno.Y)//Down
            {
                if (_prepno.X < _postpno.X)//Right
                {
                    if (this.Convex)
                    {
                        _listpoints.Add(new Point(_prepno.X + _prepno.Width, _prepno.Y + _prepno.Height / 2));
                        _listpoints.Add(new Point(_postpno.X + _postpno.Width / 2, _prepno.Y + _prepno.Height / 2));
                        _listpoints.Add(new Point(_postpno.X + _postpno.Width / 2, _postpno.Y));
                    }
                    else
                    {
                        _listpoints.Add(new Point(_prepno.X + _prepno.Width / 2, _prepno.Y + _prepno.Height));
                        _listpoints.Add(new Point(_prepno.X + _prepno.Width / 2, _postpno.Y + _postpno.Height / 2));
                        _listpoints.Add(new Point(_postpno.X, _postpno.Y + _postpno.Height / 2));
                    }
                }
                else if (_prepno.X > _postpno.X)//Left
                {
                    if (this.Convex)
                    {
                        _listpoints.Add(new Point(_prepno.X, _prepno.Y + _prepno.Height / 2));
                        _listpoints.Add(new Point(_postpno.X + _postpno.Width / 2, _prepno.Y + _prepno.Height / 2));
                        _listpoints.Add(new Point(_postpno.X + _postpno.Width / 2, _postpno.Y));
                    }
                    else
                    {
                        _listpoints.Add(new Point(_prepno.X + _prepno.Width / 2, _prepno.Y + _prepno.Height));
                        _listpoints.Add(new Point(_prepno.X + _prepno.Width / 2, _postpno.Y + _postpno.Height / 2));
                        _listpoints.Add(new Point(_postpno.X + _postpno.Width, _postpno.Y + _postpno.Height / 2));
                    }
                }
                else
                {
                    _listpoints.Add(new Point(_prepno.X + _prepno.Width / 2, _prepno.Y + _prepno.Height));
                    _listpoints.Add(new Point(_prepno.X + _prepno.Width / 2, (_prepno.Y + _prepno.Height + _postpno.Y) / 2));
                    _listpoints.Add(new Point(_prepno.X + _prepno.Width / 2, _postpno.Y));
                }
            }
            else if (_prepno.Y > _postpno.Y)//Up
            {
                if (_prepno.X < _postpno.X)//Right
                {
                    if (this.Convex)
                    {
                        _listpoints.Add(new Point(_prepno.X + _prepno.Width / 2, _prepno.Y));
                        _listpoints.Add(new Point(_prepno.X + _prepno.Width / 2, _postpno.Y + _postpno.Height / 2));
                        _listpoints.Add(new Point(_postpno.X, _postpno.Y + _postpno.Height / 2));
                    }
                    else
                    {
                        _listpoints.Add(new Point(_prepno.X + _prepno.Width, _prepno.Y + _prepno.Height / 2));
                        _listpoints.Add(new Point(_postpno.X + _postpno.Width / 2, _prepno.Y + _prepno.Height / 2));
                        _listpoints.Add(new Point(_postpno.X + _postpno.Width / 2, _postpno.Y + _postpno.Height));
                    }
                }
                else if (_prepno.X > _postpno.X)//Left
                {
                    if (this.Convex)
                    {
                        _listpoints.Add(new Point(_prepno.X + _prepno.Width / 2, _prepno.Y));
                        _listpoints.Add(new Point(_prepno.X + _prepno.Width / 2, _postpno.Y + _postpno.Height / 2));
                        _listpoints.Add(new Point(_postpno.X + _postpno.Width, _postpno.Y + _postpno.Height / 2));
                    }
                    else
                    {
                        _listpoints.Add(new Point(_prepno.X, _prepno.Y + _prepno.Height / 2));
                        _listpoints.Add(new Point(_postpno.X + _postpno.Width / 2, _prepno.Y + _prepno.Height / 2));
                        _listpoints.Add(new Point(_postpno.X + _postpno.Width / 2, _postpno.Y + _postpno.Height));
                    }
                }
                else
                {
                    _listpoints.Add(new Point(_prepno.X + _prepno.Width / 2, _prepno.Y));
                    _listpoints.Add(new Point(_prepno.X + _prepno.Width / 2, (_postpno.Y + _postpno.Height + _prepno.Y) / 2));
                    _listpoints.Add(new Point(_prepno.X + _prepno.Width / 2, _postpno.Y + _postpno.Height));
                }
            }
            else//Same Y
            {
                if (_prepno.X < _postpno.X)
                {
                    _listpoints.Add(new Point(_prepno.X + _prepno.Width, _prepno.Y + _prepno.Height / 2));
                    _listpoints.Add(new Point((_prepno.X + _postpno.X + _postpno.Width) / 2, _prepno.Y + _prepno.Height / 2));
                    _listpoints.Add(new Point(_postpno.X, _prepno.Y + _prepno.Height / 2));
                }
                else
                {
                    _listpoints.Add(new Point(_prepno.X, _prepno.Y + _prepno.Height / 2));
                    _listpoints.Add(new Point((_postpno.X + _prepno.X + _prepno.Width) / 2, _prepno.Y + _prepno.Height / 2));
                    _listpoints.Add(new Point(_postpno.X + _postpno.Width, _prepno.Y + _prepno.Height / 2));
                }
            }
        }
    }
}
