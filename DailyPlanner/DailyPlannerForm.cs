﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyPlanner
{
    public partial class DailyPlannerForm : Form
    {
        public DailyPlannerForm()
        {
            InitializeComponent();
        }

        private void DailyPlannerForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
