using DailyPlanner.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlanner.Services
{

    public static class ReadWriteTextFile
    {
        private static List<Event> events;

        public static List<Event> GetEventData(string file)
        {
            events = new List<Event>();
            string line = String.Empty;

            try
            {
                using (StreamReader rdr = new StreamReader(file))
                    {
                        while ((line = rdr.ReadLine()) != null)
                        {
                            string[] data = line.Split('|');

                            events.Add(new Event()
                            {
                                title = data[0],
                                type = data[1],
                                date = data[2],
                                status = data[3],
                                description = data[4]
                            });
                        }
                    }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return events;
        }

        public static bool ExportDataToTextFile(List<Event> data, string file)
        {
            try
            {
                //We want to
                FileStream stream = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);

                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    foreach (var d in data)
                    {
                        writer.WriteLine(d.title.ToString() + "\\" + d.type.ToString() + "\\" +
                                         d.date.ToString() + "\\" + d.status.ToString() + "\\" +
                                         d.description.ToString());

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

    }
}
