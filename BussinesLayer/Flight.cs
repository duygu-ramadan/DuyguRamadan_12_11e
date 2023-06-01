using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BussinesLayer
{
    public class Flight
    {
        public Flight()
        {
            Reservations = new List<Reservation>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Destination { get; set; }

        [Range(1, 1500)]
        public int TimeSpan { get; set; }

        public List<Reservation> Reservations { get; set; }
    }
}
