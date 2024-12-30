using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTrackerForNulls
{
    internal class Book
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get; set; }

        public Book(string bookName, string author)
        {
            BookName = bookName;
            Author = author;
        }
        


    }
}
