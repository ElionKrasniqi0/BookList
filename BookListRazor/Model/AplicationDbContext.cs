using Microsoft.EntityFrameworkCore;

namespace BookListRazor.Model
{
    public class AplicationDbContext : Dbcontext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext>options) : base(options)
        (
            )
          public DbSet<Book> Book { get; set; }
    }
}
