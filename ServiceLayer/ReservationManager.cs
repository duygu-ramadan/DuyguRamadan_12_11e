using BussinesLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public class ReservationManager
    {
        private static ReservationContext reservationContext;

        public ReservationManager(AirportDbContext dbContext)
        {
            reservationContext = new ReservationContext(dbContext);
        }

        public static void Create(Reservation reservation)
        {
            try
            {
                reservationContext.Create(reservation);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static Reservation Read(int key)
        {
            try
            {
                return reservationContext.Read(key);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static ICollection<Reservation> ReadAll()
        {
            try
            {
                return reservationContext.ReadAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void Update(Reservation author)
        {
            try
            {
                reservationContext.Update(author);
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
                reservationContext.Delete(key);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
