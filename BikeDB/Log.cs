using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BikeDB
{
    public class Log
    {
        public DateTime Date { get; set; }
        public decimal Miles { get; set; }
        public DateTime Hours { get; set; }
        public decimal AvgMPH { get; set; }
        public int DaysSince { get; set; }
    }
}