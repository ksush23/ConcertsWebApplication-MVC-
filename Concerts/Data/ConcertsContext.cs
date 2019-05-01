using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Concerts.Models;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().ToTable("Artist");
            modelBuilder.Entity<Concert>().ToTable("Concert");
            modelBuilder.Entity<Place>().ToTable("Place");
            modelBuilder.Entity<Seat>().ToTable("Seat");
            modelBuilder.Entity<Sector>().ToTable("Sector");
            modelBuilder.Entity<Ticket>().ToTable("Ticket");
            modelBuilder.Entity<TicketState>().ToTable("TicketState");
        }
    }
}
