using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BussinesLayer
{
    public class Reservation
    {
        public Reservation()
        {
        }

        [Key]
        public int Id { get; set; }

        [Range(0, int.MaxValue)]
        [Required]
        public int SeatNumbers { get; set; }

        [Range(0, int.MaxValue)]
        [Required]
        public int TicketCount { get; set; }

        [Range(0, int.MaxValue)]
        [Required]
        public decimal Price { get; set; }

        public Flight Fight { get; set; }
    }
}
