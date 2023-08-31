using Microsoft.EntityFrameworkCore;
using Bookstore.Models;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Book> Book { get; set; }
}
