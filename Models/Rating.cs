using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace movie.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public string Value { get; set; }
    }
}