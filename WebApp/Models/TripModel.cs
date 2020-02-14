using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{   
    public partial class TripModel
    {
        public int TripID { get; set; }
        public int UserID { get; set; }
        public DateTimeOffset DateTimeStart { get; set; }
        public DateTimeOffset DateTimeEnd { get; set; }
        public string Destination { get; set; }
        public string Name { get; set; }
        public List<EventModel> Events { get; set; }


        public class RootObject
        {

            public RootObject()
            {
                var eventList = new List<EventModel>();
            }
        }


        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        RootObject robj = new RootObject();
        //        robj.eventList.Add(someEvent);

        //    }
        //}
    }
}
