using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    class ReaderRepository : GenericRepository<Reader>
    {
        public ReaderRepository() : base()
        { }

        public List<Reader> GetIndeptedReaders()
        {
            List<Reader> readers = _db.Readers.Where(r => r.Deals.Any(d => d.BookCopyInDeals.Any(bcd => !bcd.ActualDateOfReturning.HasValue))).ToList();
            return readers;
        }

        public List<Reader> GetReadersReadBookByBookId(int bookId)
        {
            List<Reader> readers = _db.Readers.Where(r => r.Deals.Any(d => d.BookCopyInDeals.Any(bcd => bcd.BookCopy.BookId.Equals(bookId)))).ToList();
            return readers;
        }
    }
}
