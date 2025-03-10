using DailyPlanner.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace DailyPlanner
{
    public partial class EventForm : Form
    {

        List<Event> events = new List<Event>();
        string SelectedValue = null;
        string NameToEdit = null;

        public EventForm(string SelectedValue)
        {
            InitializeComponent();
            this.SelectedValue = SelectedValue;

        }
        private void EventForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.GetEvents();
            this.SetControls();
        }

        private void GetEvents()
        {
            events = Event.GetEvents();
        }

        private void SetControls()
        {
            //Populate Combo Boxes

            NameToEdit = SelectedValue.ToString();

            //Populate the Controls
            var selected = (from ev in events
                            where ev.title == SelectedValue.ToString()
                            select ev).ToList();

            if (selected.Count > 0)
            {
                this.txtTitle.Text = selected[0].title;
                this.cboType.SelectedText = selected[0].type;
                this.txtDate.Text = selected[0].date;
                this.cboStatus.SelectedText = selected[0].status;
                this.txtDesc.Text = selected[0].description;
            }            
        }

        private void btnUpdateEvent9_Click(object sender, EventArgs e)
        {

            //var selected = (from ev in events
            //                where ev.title == SelectedValue.ToString()
            //                select ev).ToList();

            //Event event = from ev in events
            //              where ev.title == SelectedValue.ToString()
            //              select ev;


            string file = CurrentPath.GetDatabasePath() + "\\" + "EventData.txt";

            // Write all but old event
            events = Event.GetEvents();
            events.RemoveAll(ev => ev.title == NameToEdit);

            System.IO.File.Delete(file);

            string prefix = "";

            foreach (Event ev in events)
            {
                //Debug.WriteLine(ev.title);
                
                string eventString = $"{prefix}{ev.title}|{ev.type}|{ev.date}|{ev.status}|{ev.description}";
                System.IO.File.AppendAllText(file, eventString);
                prefix = "\n";
            }

            // Add event

            string title = txtTitle.Text;
            string type = cboType.Text;
            string date = txtDate.Text;
            string status = cboStatus.Text;
            string description = txtDesc.Text;

            //Debug.WriteLine("type " + type);

            string addedEvent = $"\n{title}|{type}|{date}|{status}|{description}";
            System.IO.File.AppendAllText(file, addedEvent);

            //selected[0].title = this.txtTitle.Text;

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
