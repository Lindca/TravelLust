using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebApp.DAL
{
    public class TripContext: DbContext
    {
        public TripContext() : base("TripContext")
        {
        }

        public DbSet<TripModel> Trips { get; set; }
        public DbSet<EventModel> Events { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}