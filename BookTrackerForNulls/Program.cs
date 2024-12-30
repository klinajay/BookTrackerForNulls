using BookTrackerForNulls;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        BookRepository bookRepository = new BookRepository();
        Book book = new Book("C# Programming", "John Doe");
        User user = new User();
        user.AddBookToRepository(bookRepository,book);
        bookRepository.DisplayAllBooks();
    }
}