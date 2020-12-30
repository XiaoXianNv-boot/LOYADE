using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestLOYADE
{
    public partial class formVDT : Form
    {
        public formVDT(DataTable dt)
        {
            InitializeComponent();
            dgv.DataSource = dt;
        }

        private void formVDT_Load(object sender, EventArgs e)
        {

        }
    }
}
