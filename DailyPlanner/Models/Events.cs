using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlanner.Models
{
    public class Event
    {
        public string title { get; set; }
        public string type { get; set; }
        public string date { get; set; }
        public string progress { get; set; }
        public string recurring { get; set; }
        public string description { get; set; }

        public Event()
        {

        }

        
        public List<Event> GetEvent()
        {
            List<Event> events = new List<Event>();
            string file = CurrentPath.GetDatabasePath() + "\\" + "EventData.txt";
            events = Services.ReadWriteTextFile.GetEventData(file);
            return events;
        }
        

    }
}
