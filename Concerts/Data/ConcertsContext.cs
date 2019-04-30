using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Concerts.Data
{
    public class ConcertsContext : DbContext
    {
        public ConcertsContext(DbContextOptions<ConcertsContext> options) : base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Concert> Concerts { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketState> TicketStates { get; set; }
    }
}
