using DailyPlanner.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyPlanner
{
    public partial class AddEventForm : Form
    {
        public AddEventForm()
        {
            InitializeComponent();
        }

        private void btnUpdateEvent7_Click(object sender, EventArgs e)
        {
            if (!PassedValidation())
            {
                MessageBox.Show("Must complete Title and Date fields!", Titles.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Create account

            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(OpenMainPageForm));
            t.Start();
        }

        private bool PassedValidation()
        {
            if (this.txtTitle7.Text.Trim().Length == 0 ||
                this.txtDate7.Text.Trim().Length == 0)
                return false;
            else
                return true;
        }

        private void OpenMainPageForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new MainPageForm());
        }
    }
}
