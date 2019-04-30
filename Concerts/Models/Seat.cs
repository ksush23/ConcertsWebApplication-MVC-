using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Concerts.Models
{
    public class Seat
    {
        public int Seat_ID { get; set; }
        public int Seat_Line_number { get; set; }
        public int Seat_Number { get; set; }

        public ICollection<Ticket>  Ticket { get; set; }
        public Sector Sector { get; set; }
    }
}
