using BussinesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class ReservationContext : IDB<Reservation, int>
    {
        private readonly AirportDbContext dbContext;
        public ReservationContext(AirportDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Reservation item)
        {
            try
            {
                dbContext.Reservations.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Reservation Read(int key)
        {
            try
            {
                return dbContext.Reservations.Find(key);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Reservation> ReadAll()
        {
            try
            {
                return dbContext.Reservations.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Reservation item)
        {
            try
            {
                dbContext.Entry(dbContext.Reservations.Find(item.Id)).CurrentValues.SetValues(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int key)
        {
            dbContext.Reservations.Remove(dbContext.Reservations.Find(key));
            dbContext.SaveChanges();
        }
    }
}
