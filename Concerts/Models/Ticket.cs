using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Concerts.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int Ticket_Price { get; set; }
        public int TicketStateId { get; set; }
        public int ConcertId { get; set; }
        public int SeatId { get; set; }

        public Concert Concert { get; set; }
        public TicketState TicketState { get; set; }
        public Seat Seat { get; set; }
    }
}
