using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Domain.Entities
{
    public class Reservation
    {
        public int Id { get; set; }

        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public DateTime ReservationDate { get; set; }      
        public string? ReservationTime { get; set; }       

        public int NumberOfPeople { get; set; }
        public string? Note { get; set; }
        public string Status { get; set; }
    }
}

