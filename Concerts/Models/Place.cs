using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Concerts.Models
{
    public class Place
    {
        public int PlaceId { get; set; }
        public string Place_Name { get; set; }
        public string Place_Address { get; set; }

        public ICollection<Concert> Concert { get; set; }
    }
}
