﻿using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Cart
    {
        public int CartId { get; set; }
        public string CartCode { get; set; }
        public int AlbumId { get; set; }
        public int Count { get; set; }
        public DateTime? DateCreated { get; set; }
        public double UnitPrice { get; set; }
        public double LineTotal { get; set; }
        public string Comments { get; set; }

        public Album Album { get; set; }
    }
}
