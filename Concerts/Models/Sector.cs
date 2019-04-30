using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Concerts.Models
{
    public class Sector
    {
        public int Sector_ID { get; set; }
        public string Sector_Name { get; set; }

        public ICollection<Seat> Seat { get; set; }
        public Place Place { get; set; }
    }
}
