using DailyPlanner.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyPlanner
{
    public partial class MainPageForm : Form
    {
        public MainPageForm()
        {
            InitializeComponent();
        }

        private void MainPageForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnLogOut3_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(OpenLoginForm));
            t.Start();
        }
        private void OpenLoginForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new LoginForm());
        }

        private void btnAddEvent3_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(OpenAddEventForm));
            t.Start();
        }
        private void OpenAddEventForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new AddEventForm());
        }

        private void btnSeeEvents3_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(OpenSeeEventsForm));
            t.Start();
        }
        private void OpenSeeEventsForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new SeeEventsForm());
        }

        private void OpenSeeDayForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new SeeDayForm());
        }

        private void btnSeeDay3_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(OpenSeeDayForm));
            t.Start();
        }

        private void btnSeeWeek3_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(OpenSeeWeekForm));
            t.Start();
        }
        private void OpenSeeWeekForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new SeeWeekForm());
        }

        private void btnChangePwd3_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(OpenChangePasswordForm));
            t.Start();
        }
        private void OpenChangePasswordForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new ChangePasswordForm());
        }

        //Search

        List<Event> events = new List<Event>();

        private void GetEvents()
        {
            events = Event.GetEvents();
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            String search = txtPwd.Text;
            foreach (var ev in events)
            {
                if (ev.title.Contains(search))
                {
                    //Textbox displays suggested title
                    txtPwd.Text = ev.title;
                    return;
                }
            }
        }
    }
}
