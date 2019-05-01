using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Concerts.Models
{
    public class Ticket
    {
        public int Ticket_ID { get; set; }
        public double Ticket_Price { get; set; }
        public int Ticket_State_ID { get; set; }
        public int Ticket_Concert_ID { get; set; }
        public int Ticket_Seat_ID { get; set; }

        public Concert Concert { get; set; }
        public TicketState TicketState { get; set; }
        public Seat Seat { get; set; }
    }
}
