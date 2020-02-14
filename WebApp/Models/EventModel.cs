using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{   
    public partial class EventModel
    {
        public int Id { get; set; }
        public int TripId { get; set; }
        public string StreetAddress { get; set; }
        public string StateOrRegion { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public int Cost { get; set; }
        public string Name { get; set; }
        public DateTimeOffset DateTimeStart { get; set; }
        public DateTimeOffset DateTimeEnd { get; set; }
        public string EventType { get; set; }
    }
}
