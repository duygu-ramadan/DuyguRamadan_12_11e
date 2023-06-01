using BussinesLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public class FlightManager
    {
        private static FlightContext flightContext;

        public FlightManager(AirportDbContext dbContext)
        {
            flightContext = new FlightContext(dbContext);
        }

        public static void Create(Flight flight)
        {
            try
            {
                flightContext.Create(flight);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static Flight Read(int key)
        {
            try
            {
                return flightContext.Read(key);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static ICollection<Flight> ReadAll()
        {
            try
            {
                return flightContext.ReadAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void Update(Flight author)
        {
            try
            {
                flightContext.Update(author);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void Delete(int key)
        {
            try
            {
                flightContext.Delete(key);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
