using BussinesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class AirportContext : IDB<Airport, int>
    {
        private readonly AirportDbContext dbContext;
        public AirportContext(AirportDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Airport item)
        {
            try
            {
                dbContext.Airports.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Airport Read(int key)
        {
            try
            {
                return dbContext.Airports.Find(key);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Airport> ReadAll()
        {
            try
            {
                return dbContext.Airports.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Airport item)
        {
            try
            {
                dbContext.Entry(dbContext.Airports.Find(item.Id)).CurrentValues.SetValues(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int key)
        {
            dbContext.Airports.Remove(dbContext.Airports.Find(key));
            dbContext.SaveChanges();
        }
    }
}
