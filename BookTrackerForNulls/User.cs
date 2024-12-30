using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTrackerForNulls
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void AddBookToRepository(BookRepository bookRepository, Book book)
        {
            
            bookRepository.books.Add(book);
            
        }
    }
}
