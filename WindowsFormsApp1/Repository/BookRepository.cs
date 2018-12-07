using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public class BookRepository: GenericRepository<Book>
    {
        public BookRepository() : base()
        {  }

        public List<Book> GetReadBooksByReaderId(int readerId)
        {
            List<Book> books = _db.Books.Where(b => b.BookCopies.Any(cb => cb.BookCopyInDeals.Any(bcd => bcd.Deal.ReaderId.Value.Equals(readerId) && bcd.ActualDateOfReturning.HasValue))).ToList();
            return books;
        }        

        public List<Book> GetAvailableBooks()
        {
            List<Book> books = _db.Books.Where(b => b.BookCopies.Any(cb => cb.BookCopyInDeals.All(bcd => bcd.ActualDateOfReturning.HasValue))).ToList();
            return books;
        }

        public List<Book> GetAuthorBooksByAuthorId(int authorId)
        {
            List<Book> books = _db.Books.Where(b => b.BookAuthors.Any(ab => ab.AuthorId.Equals(authorId))).ToList();
            return books;
        }

    }
}
