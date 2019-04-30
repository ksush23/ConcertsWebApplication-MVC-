using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Concerts.Models
{
    public class TicketState
    {
        public int TicketState_ID { get; set; }
        public string TicketState_Name { get; set; }

        public ICollection<Ticket> Ticket { get; set; }
    }
}
