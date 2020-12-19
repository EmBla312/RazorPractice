using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPractice.Models
{
    public class Books
    {
        public int ID { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string fAuthor { get; set; }
        public string lAuthor { get; set; }
        public double price { get; set; }

    }
}
