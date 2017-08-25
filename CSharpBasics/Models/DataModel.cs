using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpBasics.Models
{
    public class DataModel
    {

        //public string[] daysOfWeek { get; set; }

        public string testString { get; set; }
        string[] daysOfWeek = {
                                    "Monday",
                                    "Tuesday",
                                    "Wednesday",
                                    "Thursday",
                                    "Friday",
                                    "Saturday",
                                    "Sunday"
                                    };

        public string dataReturn(int dayVal)
        {
            var returnData = "";
            returnData = daysOfWeek[dayVal];
            return returnData;
        }

        public string ProcessName { get; set; }

        public string ProcessID { get; set; }

        public string ProcessResponding { get; set; }

        public string ProcessSessionID { get; set; }

        public DateTime ProcessStartTime { get; set; }

        public string WorkingSet { get; set; }

        public string ProcessTreads { get; set; }
    }
}