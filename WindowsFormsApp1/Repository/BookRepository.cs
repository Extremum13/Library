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

        public List<Book> GetFiltratedBooks(string namePart, bool? isFree, int fromYear, int toYear, List<int> authorsId)
        {
            if (fromYear == 0)
                return GetBooksByNamePart(namePart);

            List<Book> books = _db.Books.Where(b => b.EditionYear.Year >= fromYear
                && b.EditionYear.Year <= toYear).ToList();

            if (!authorsId.Equals(null) && !authorsId.Count.Equals(0))
            {
                books = books.Where(b => b.BookAuthors.Any(ba => authorsId.Contains(ba.AuthorId))).ToList();
            }

            if(!namePart.Equals(null) && !namePart.Length.Equals(0))
            {
                books = books.Where(b => b.Name.ToUpper().Contains(namePart.ToUpper())).ToList();                
            }

            if (isFree.Equals(true))
            {
                books = books.Where(b => b.BookCopies.Any(bc => bc.BookCopyInDeals.All(bcd => bcd.ActualDateOfReturning.HasValue)
                || bc.BookCopyInDeals.Count.Equals(0))).ToList();
            }
            else if (isFree.Equals(false))
            {
                books = books.Where(b => b.BookCopies.All(bc => bc.BookCopyInDeals.Any(bcd => !bcd.ActualDateOfReturning.HasValue)
                && !bc.BookCopyInDeals.Count.Equals(0))).ToList();
            }
            books = books.ToList();

            return books;
        }

        public List<Book> GetBooksByNamePart(string namePart)
        {
            if (namePart.Equals(null) || namePart.Length.Equals(0))
            {
                return Get();
            }

            List<Book> books = _db.Books.Where(b => b.Name.ToUpper().Contains(namePart.ToUpper())).ToList();
            return books;
        }
        
        public List<Book> GetAvailableBooks()
        {
            List<Book> books = _db.Books.Where(b => b.BookCopies.Any(cb => cb.BookCopyInDeals.All(bcd => bcd.ActualDateOfReturning.HasValue) || cb.BookCopyInDeals.Count.Equals(0))).ToList();
            return books;
        }

        public List<Book> GetAuthorBooksByAuthorId(int authorId)
        {
            List<Book> books = _db.Books.Where(b => b.BookAuthors.Any(ab => ab.AuthorId.Equals(authorId))).ToList();
            return books;
        }

    }
}
