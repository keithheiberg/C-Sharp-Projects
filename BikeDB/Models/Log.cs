//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BikeDB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Log
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<decimal> Miles { get; set; }
        public Nullable<System.TimeSpan> Hours { get; set; }
        public Nullable<decimal> AvgMPH { get; set; }
        public Nullable<int> DaysSince { get; set; }
    }
}