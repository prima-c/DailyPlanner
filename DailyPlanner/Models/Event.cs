using DailyPlanner.Services;
using System.Collections.Generic;

namespace DailyPlanner.Models
{
    public class Event
    {
        public string title { get; set; }
        public string type { get; set; }
        public string date { get; set; }
        public string status { get; set; }
        public string description { get; set; }

        public Event()
        {

        }
        
        public static List<Event> GetEvents()
        {
            List<Event> events = new List<Event>();
            string file = CurrentPath.GetDatabasePath() + "\\" + "EventData.txt";
            events = ReadWriteTextFile.GetEventData(file);

            return events;
        }       
    }
}
