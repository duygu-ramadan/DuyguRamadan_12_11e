using BussinesLayer;
using DataLayer;
using System;
using System.Collections.Generic;

namespace ServiceLayer
{
    public class AirportManager
    {
        private static AirportContext airportContext;

        public AirportManager(AirportDbContext dbContext)
        {
            airportContext = new AirportContext(dbContext);
        }

        public static void Create(Airport airport)
        {
            try
            {
                airportContext.Create(airport);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static Airport Read(int key)
        {
            try
            {
                return airportContext.Read(key);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static ICollection<Airport> ReadAll()
        {
            try
            {
                return airportContext.ReadAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void Update(Airport author)
        {
            try
            {
                airportContext.Update(author);
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
                airportContext.Delete(key);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
