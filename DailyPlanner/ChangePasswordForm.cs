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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private bool PassedValidation()
        {
            if (this.txtUser8.Text.Trim().Length == 0 ||
                this.txtPwdOld8.Text.Trim().Length == 0)
                return false;
            else
                return true;

        }

        private bool DifferentPwd()
        {
            if (this.txtPwdOld8.Text == this.txtPwdNew8.Text ||
                this.txtPwdNew8.Text.Trim().Length == 0)
                return false;
            else
                return true;
        }

        private void btnChangePwd8_Click(object sender, EventArgs e)
        {
            if (!PassedValidation())
            {
                MessageBox.Show("Invalid credentials!", Titles.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DifferentPwd())
            {
                MessageBox.Show("New password must be different from old!", Titles.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(OpenMainPageForm));
            t.Start();
        }
        private void OpenMainPageForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new MainPageForm());
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
