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
            // display selected
        }
    }
}
