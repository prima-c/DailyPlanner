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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin1_Click(object sender, EventArgs e)
        {
            if (!PassedValidation())
            {
                MessageBox.Show("Invalid Credentials!", Titles.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(OpenMainPageForm));
            t.Start();
        }

        private bool PassedValidation()
        {
            if (this.txtUser1.Text.Trim().Length == 0 ||
                this.txtPwd1.Text.Trim().Length == 0)
                return false;
            else
                return true;

        }

        private void OpenMainPageForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new MainPageForm());
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnMakeAcc1_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(OpenMakeAccountForm));
            t.Start();
        }
        private void OpenMakeAccountForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new MakeAccountForm());
        }
    }
}
