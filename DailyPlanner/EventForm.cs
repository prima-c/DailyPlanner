using DailyPlanner.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyPlanner
{
    public partial class EventForm : Form
    {

        List<Event> events = new List<Event>();

        public EventForm()
        {
            InitializeComponent();
        }
        private void EventForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.GetEvents();
        }

        private void GetEvents()
        {
            Event eventObj = new Event();
            events = eventObj.GetEvents();
        }

        private void SelectedEvent(object sender, EventArgs e)
        {
            /*
            var selected = (from ev in events
                            where ev.title == xxxxx.SelectedValue.ToString()
                            select new
                            {
                                title = this.lblTitle9,
                                type = this.lblType9,
                                date = this.lblDate9,
                                status = this.lblStatus9,
                                desc = this.lblDesc9
                            }).ToList();
            if (selected.Count > 0)
            {
                this.lblTitle9.Text = selected[0].title;
                this.lblType9.Text = selected[0].type;
                this.lblDate9.Text = selected[0].date;
                this.lblStatus9.Text = selected[0].status;
                this.lblDesc9.Text = selected[0].desc;
            }
            */
        }
    }
}
