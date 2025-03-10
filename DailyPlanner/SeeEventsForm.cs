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
    public partial class SeeEventsForm : Form
    {

        List<Event> events = new List<Event>();
        public String SelectedValue = null;

        public SeeEventsForm()
        {
            InitializeComponent();
        }

        private void SeeEventsForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void btnMainPage6_Click(object sender, EventArgs e)
        {
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

        private void GetEvents()
        {
            events = Event.GetEvents();
        }

        private void SetControls()
        {
            this.GetEvents();

            if (events.Count > 0)
            {
                    this.cboEventList6.DataSource = events;
                    this.cboEventList6.DisplayMember = "Title";
                    this.cboEventList6.ValueMember = "Title";
            }
        }

        //private void SetSearchControls()
        //{

        //    this.GetEvents();

        //    var matching = events.FindAll(delegate (Event ev) { return ev.title.Contains(search); });

        //    if (matching.Count > 0)
        //    {
        //        this.cboEventList6.DataSource = matching;
        //        this.cboEventList6.DisplayMember = "Title";
        //        this.cboEventList6.ValueMember = "Title";
        //    }
        //}

        private void cmbEventList6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OpenEventForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new EventForm(SelectedValue));
        }

        private void btnEditEvent_Click(object sender, EventArgs e)
        {
            if (this.cboEventList6.Text != null)
            {
                SelectedValue = cboEventList6.Text;
                //Close current form
                this.Close();
                //Create a thread to RUN a NEW application with the desired form
                Thread t = new Thread(new ThreadStart(OpenEventForm));
                t.Start();
            }
            else
            {
                MessageBox.Show("An Event Must Be Selected!", Titles.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
