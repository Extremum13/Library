using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public class BookCopyRepository : GenericRepository<BookCopy>
    {
        public BookCopyRepository() : base()
        { }

        public List<BookCopy> GetBookCopiesByBookId(int bookId)
        {
            List<BookCopy> bookCopies = _db.BookCopies.Where(bc => bc.BookId.Value.Equals(bookId)).ToList();
            return bookCopies;
        }

        public List<BookCopy> GetBusyBookCopiesByBookId(int bookId)
        {
            List<BookCopy> bookCopies = _db.BookCopies.Where(bc => bc.BookId.Value.Equals(bookId) && bc.BookCopyInDeals.Any(bcd => !bcd.ActualDateOfReturning.HasValue)).ToList();
            return bookCopies;
        }

        public List<BookCopy> GetAvailableBookCopiesByBookId(int bookId)
        {
            List<BookCopy> bookCopies = _db.BookCopies.Where(bc => bc.BookId.Value.Equals(bookId) && (bc.BookCopyInDeals.Count.Equals(0) || bc.BookCopyInDeals.All(bcd => bcd.ActualDateOfReturning.HasValue))).ToList();
            return bookCopies;
        }       

        public List<BookCopy> GetBusyBookCopies()
        {
            List<BookCopy> bookCopies = _db.BookCopies.Where(bc => bc.BookCopyInDeals.Any(bcd => !bcd.ActualDateOfReturning.HasValue)).ToList();
            return bookCopies;
        }

        public List<BookCopy> GetMustReturnBookCopiesByReaderId(int readerId)
        {
            List<BookCopy> bookCopies = _db.BookCopies.Where(bc => bc.BookCopyInDeals.Any(bcd => bcd.Deal.ReaderId.Value.Equals(readerId) && !bcd.ActualDateOfReturning.HasValue && bcd.RequiredDateOfReturning <= DateTime.UtcNow)).ToList();
            return bookCopies;
        }

        public List<BookCopy> GetReadingBookCopiesByReaderId(int readerId)
        {
            List<BookCopy> bookCopies = _db.BookCopies.Where(bc => bc.BookCopyInDeals.Any(bcd => bcd.Deal.ReaderId.Value.Equals(readerId) && !bcd.ActualDateOfReturning.HasValue)).ToList();
            return bookCopies;
        }
    }
}