using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TheAutodidact3.Models
{
    public class Blog
    {
        private DateTime _Date = DateTime.Now;

        public int Id { get; set;}

        public string Title { get; set; }

        public DateTime Date { get { return _Date; } set { _Date = value; } }

        public string Author { get; set; }

        public string Content { get; set; }
    }
}