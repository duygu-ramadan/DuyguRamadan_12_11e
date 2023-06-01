using BussinesLayer;
using DataLayer;
using System;
using System.Collections.Generic;

namespace TestingLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            AirportContext airportContext = new AirportContext(new AirportDbContext());
            ReservationContext reservationContext = new ReservationContext(new AirportDbContext());

            var airport = new Airport
            {
                Id = 1,
                Name = "София Терминал 2",
                Income = 1000000000
            };

            var reservation = new Reservation
            {
                Id = 1,
                SeatNumbers = 23,
                TicketCount = 3,
                Price = 430,
                Fight = new Flight
                {
                    Id = 1,
                    Destination = "Испания",
                    TimeSpan = 180
                }
            };

            reservationContext.Create(reservation);
            Console.WriteLine("Reservatiuon was created successfully.");

            airportContext.Create(airport);
            Console.WriteLine("Airpost was created successfully.");
        }
    }
}
