using Bookstore.Models;

public class BooksRepository
{
    private readonly ApplicationDbContext _context;

    public BooksRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Book> GetAllBooks()
    {
        return (IEnumerable<Book>)_context.Book.ToList();
    }

    public IEnumerable<Book> AddBook(Book book)
    {
        //TODO ADD BOOK TO DB and replace the row below
        return (IEnumerable<Book>)_context.Book.ToList();
    }
}
