using Microsoft.EntityFrameworkCore;

namespace BookStoreApi.Models
{
    public class BookContext: DbContext
    {

        public BookContext(DbContextOptions<BookContext> options)
          : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<BookItem>().ToTable("BookItem");

        }

        public DbSet<BookItem> BookItems { get; set; } = null!;
    }
}
