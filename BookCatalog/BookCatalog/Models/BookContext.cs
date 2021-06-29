using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookCatalog.Models
{
    public class BookContext:DbContext
    {
        public BookContext(DbContextOptions<BookContext> dbContextOptions) : base(dbContextOptions)
        {
            Database.EnsureCreated();
        }
        public DbSet<Book> Books { get; set; }
    }
}
