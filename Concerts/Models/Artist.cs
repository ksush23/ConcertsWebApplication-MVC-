﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Concerts.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string Artist_Name { get; set; }
        public string Artist_Genre { get; set; }

        public ICollection<Concert> Concerts { get; set; }
    }
}
