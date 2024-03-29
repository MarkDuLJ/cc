﻿using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Genre
    {
        public Genre()
        {
            Album = new HashSet<Album>();
        }

        public int GenreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Album> Album { get; set; }
    }
}
