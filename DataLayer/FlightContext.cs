using BussinesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class FlightContext : IDB<Flight, int>
    {
        private readonly AirportDbContext dbContext;
        public FlightContext(AirportDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(Flight item)
        {
            try
            {
                dbContext.Flights.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Flight Read(int key)
        {
            try
            {
                return dbContext.Flights.Find(key);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Flight> ReadAll()
        {
            try
            {
                return dbContext.Flights.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Flight item)
        {
            try
            {
                dbContext.Entry(dbContext.Flights.Find(item.Id)).CurrentValues.SetValues(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int key)
        {
            dbContext.Flights.Remove(dbContext.Flights.Find(key));
            dbContext.SaveChanges();
        }
    }
}
