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
    public partial class MakeAccountForm : Form
    {
        public MakeAccountForm()
        {
            InitializeComponent();
        }

        private void btnBackLogin2_Click(object sender, EventArgs e)
        {
            if (!PassedValidation())
            {
                MessageBox.Show("Username and password cannot be blank!", Titles.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Create account

            /*
            User user = new User;
             */

            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(OpenMainPageForm));
            t.Start();
        }
        private bool PassedValidation()
        {
            if (this.txtUser2.Text.Trim().Length == 0 ||
                this.txtPwd2.Text.Trim().Length == 0)
                return false;
            else
                return true;

            /*
            if (this.txtUser2.Text in users.username &&
            this.txtPwd2.Text == users[username].password)
                return true
            else
                return false
             */

        }
        private void OpenMainPageForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new MainPageForm());
        }
    }
}
