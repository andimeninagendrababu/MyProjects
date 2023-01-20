using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class phase1Model
    {
        public int Sl_No { get; set; }
        public string Hotel { get; set; }
        public string Arrival { get; set; }
        public Nullable<System.DateTime> Departure { get; set; }
        public string Type { get; set; }
        public string Guests { get; set; }
        public Nullable<decimal> price { get; set; }
    }
}