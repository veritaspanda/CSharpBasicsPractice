using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpBasics.Models
{
    public class DataModel
    {
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
    }
}