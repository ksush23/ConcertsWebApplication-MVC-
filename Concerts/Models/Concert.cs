using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Concerts.Models
{
    public class Concert
    {
        public int ConcertId { get; set; }
        public DateTime Concert_TimeData { get; set; }
        public int ConcertArtistId { get; set; }
        public int ConcertPlaceId { get; set; }

        public Artist Artist { get; set; }
        public Place Place { get; set; }
    }
}
