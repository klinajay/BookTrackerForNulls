using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTrackerForNulls
{
    internal class BookRepository
    {
        public List<Book> books = new List<Book>();
       
        public void DisplayAllBooks()
        {
            foreach (var item in books)
            {
                Console.WriteLine("Book Name: " + item?.BookName);
                Console.WriteLine("Author Name: " + item?.Author);
                Console.WriteLine("Description: " + (item?.Description ??  "Description not added")); 
                Console.WriteLine("Price: " + (item?.Price?.ToString() ?? "Price Not added"));
                Console.WriteLine("Quantity: " + (item?.Quantity?.ToString() ?? "Quantity Not added"));
            }
        }
    }
}
