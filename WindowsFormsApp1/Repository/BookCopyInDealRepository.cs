using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    class BookCopyInDealRepository : GenericRepository<BookCopyInDeal>
    {
        public BookCopyInDealRepository() : base()
        {

        }

        public List<BookCopyInDeal> GetMustReturnBookCopiesByReaderId(int readerId)
        {
            List<BookCopyInDeal> bookCopies = _db.BookCopyInDeals.Where(bcd => (bcd.Deal.ReaderId.Value.Equals(readerId) && !bcd.ActualDateOfReturning.HasValue && bcd.RequiredDateOfReturning <= DateTime.UtcNow)).ToList();
            return bookCopies;
        }

        public List<BookCopyInDeal> GetReadingBookCopiesByReaderId(int readerId)
        {
            List<BookCopyInDeal> bookCopies = _db.BookCopyInDeals.Where(bcd => (bcd.Deal.ReaderId.Value.Equals(readerId) && !bcd.ActualDateOfReturning.HasValue)).ToList();
            return bookCopies;
        }

        public List<BookCopyInDeal> GetBookCopiesInDealByReaderId(int readerId)
        {
            List<BookCopyInDeal> bookCopyInDeal = _db.BookCopyInDeals.Where(bcd => bcd.Deal.Reader.Id.Equals(readerId)).ToList();
            return bookCopyInDeal;
        }
    }
}