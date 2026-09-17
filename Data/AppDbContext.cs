using enozomtask.Models;
using EnozomTask.Models;
using Microsoft.EntityFrameworkCore;

namespace EnozomTask.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Trip> Trips { get; set; }
        public DbSet<Train> Trains { get; set; }
        public DbSet<TripStop> TripStops { get; set; }


        public DbSet<Station> Stations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TripStop>()
                .HasKey(ts => ts.Id);
            modelBuilder.Entity<Trip>()
             .HasKey(t => new { t.TripNumber });

            modelBuilder.Entity<Train>().HasData(
            new Train { Id = 1, Name = "Talgo" },
            new Train { Id = 2, Name = "French" },
            new Train { Id = 3, Name = "Spain" }

 );
            modelBuilder.Entity<Station>().HasData(
                        new Station { Id = 1, Name = "Alexandria" },
                        new Station { Id = 2, Name = "Damnhour" },
                        new Station { Id = 3, Name = "Tanta" },
                        new Station { Id = 4, Name = "Banha" },
                        new Station { Id = 5, Name = "Cairo" }

             );
            modelBuilder.Entity<Trip>().HasData(
   new Trip { TripNumber = 1, TrainId = 1 },
   new Trip { TripNumber = 2, TrainId = 2 },
   new Trip { TripNumber = 3, TrainId = 3 },

   new Trip { TripNumber = 4, TrainId = 1 },
   new Trip { TripNumber = 5, TrainId = 2 },
   new Trip { TripNumber = 6, TrainId = 3 }
);
            modelBuilder.Entity<TripStop>().HasData(
       new TripStop
       {
           Id = 1,
           TripId = 1,
           StationId = 1,
           Time = new TimeSpan(7, 0, 0),
           StopOrder = 1
       },
       new TripStop
       {
           Id = 2,

           TripId = 1,
           StationId = 5,
           Time = new TimeSpan(9, 0, 0),
           StopOrder = 2
       },

       new TripStop
       {
           Id = 3,
           TripId = 2,
           StationId = 1,
           Time = new TimeSpan(7, 30, 0),
           StopOrder = 1
       },
       new TripStop
       {
           Id = 4,

           TripId = 2,
           StationId = 3,
           Time = new TimeSpan(8, 30, 0),
           StopOrder = 2
       },
       new TripStop
       {
           Id = 5,
           TripId = 2,
           StationId = 4,
           Time = new TimeSpan(9, 30, 0),
           StopOrder = 3
       },
       new TripStop
       {
           Id = 6,
           TripId = 2,
           StationId = 5,
           Time = new TimeSpan(10, 30, 0),
           StopOrder = 4
       },

       new TripStop
       {
           Id = 7,

           TripId = 3,
           StationId = 1,
           Time = new TimeSpan(9, 0, 0),
           StopOrder = 1
       },
       new TripStop
       {
           Id = 8,

           TripId = 3,
           StationId = 3,
           Time = new TimeSpan(10, 15, 0),
           StopOrder = 2
       },
       new TripStop
       {
           Id = 9,
           TripId = 3,
           StationId = 5,
           Time = new TimeSpan(11, 30, 0),
           StopOrder = 3
       },

        new TripStop
        {
            Id = 10,
            TripId = 4,
            StationId = 5,
            Time = new TimeSpan(7, 0, 0),
            StopOrder = 1
        },
        new TripStop
        {
            Id = 11,
            TripId = 4,
            StationId = 5,
            Time = new TimeSpan(9, 0, 0),
            StopOrder = 5
        },


       new TripStop
       {
           Id = 12,
           TripId = 5,
           StationId = 5,
           Time = new TimeSpan(10, 30, 0),
           StopOrder = 1
       },
       new TripStop
       {
           Id = 13,
           TripId = 5,
           StationId = 4,
           Time = new TimeSpan(9, 30, 0),
           StopOrder = 2
       },
       new TripStop
       {
           Id = 14,
           TripId = 5,
           StationId = 3,
           Time = new TimeSpan(8, 30, 0),
           StopOrder = 3
       },
       new TripStop
       {
           Id = 15,
           TripId = 5,
           StationId = 2,
           Time = new TimeSpan(7, 30, 0),
           StopOrder = 4
       },
       new TripStop
       {
           Id = 16,
           TripId = 5,
           StationId = 1,
           Time = new TimeSpan(7, 30, 0),
           StopOrder = 5
       },
             new TripStop
             {
                 Id = 17,
                 TripId = 5,
                 StationId = 5,
                 Time = new TimeSpan(7, 30, 0),
                 StopOrder = 6
             },
       new TripStop
       {
           Id = 18,
           TripId = 6,
           StationId = 5,
           Time = new TimeSpan(11, 30, 0),
           StopOrder = 1
       },
       new TripStop
       {
           Id = 19,

           TripId = 6,
           StationId = 3,
           Time = new TimeSpan(10, 15, 0),
           StopOrder = 2
       },
       new TripStop
       {
           Id = 20,
           TripId = 6,
           StationId = 5,
           Time = new TimeSpan(9, 0, 0),
           StopOrder = 3
       }

   );
        }
    }
}

