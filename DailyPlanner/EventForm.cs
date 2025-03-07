using DailyPlanner.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DailyPlanner
{
    public partial class EventForm : Form
    {

        List<Event> events = new List<Event>();
        String SelectedValue = null;

        public EventForm(string SelectedValue)
        {
            InitializeComponent();
            this.SelectedValue = SelectedValue;

        }
        private void EventForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.GetEvents();
        }

        private void GetEvents()
        {
            events = Event.GetEvents();
        }

        private void SelectedEvent(object sender, EventArgs e)
        {
            
            var selected = (from ev in events
                            where ev.title == SelectedValue.ToString()
                            select new
                            {
                                title = this.lblTitle9.ToString(),
                                type = this.lblType9.ToString(),
                                date = this.lblDate9.ToString(),
                                status = this.lblStatus9.ToString(),
                                desc = this.lblDesc9.ToString()
                            }).ToList();
            
            if (selected.Count > 0)
            {
                this.lblTitle9.Text = selected[0].title;
                this.lblType9.Text = selected[0].type;
                this.lblDate9.Text = selected[0].date;
                this.lblStatus9.Text = selected[0].status;
                this.lblDesc9.Text = selected[0].desc;
            }
            
        }

        private void btnUpdateEvent9_Click(object sender, EventArgs e)
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
    }
}
