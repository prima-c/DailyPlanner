using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlanner.Models
{
    public static class CurrentPath
    {
        static string location = string.Empty;

        public static string GetPath()
        {
            location = Directory.GetCurrentDirectory();
            location = location.Substring(0, location.IndexOf("\\bin"));
            return location;
        }

        public static string GetDatabasePath()
        {
            location = GetPath() + "\\LocalData";
            return location;
        }
    }
}
