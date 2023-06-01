using BussinesLayer;
using System;
using System.Data.Entity;

namespace DataLayer
{
    public class AirportDbContext: DbContext
    {

        public AirportDbContext() : base("Airport") { }

        public DbSet<Airport> Airports { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
