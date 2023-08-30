using Bookstore.Models;

public class BooksRepository
{
    private readonly ApplicationDbContext _context;

    public BooksRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Books> GetAllBooks()
    {
        return (IEnumerable<Books>)_context.Books.ToList();
    }
}
