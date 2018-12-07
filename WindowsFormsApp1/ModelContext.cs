using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class ModelContext: DbContext
    {
        public ModelContext() : base("DefaultConnection")
        { }

        public DbSet<Deal> Deals { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<BookCopy> BookCopies{ get; set; }
        public DbSet<BookCopyInDeal> BookCopyInDeals{ get; set; }
        public DbSet<Librarian> Librarians{ get; set; }
        public DbSet<Reader> Readers{ get; set; }
    }
}
