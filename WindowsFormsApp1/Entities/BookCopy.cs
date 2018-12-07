using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    public class BookCopy: BaseEntity
    {
        public int CopyNumber { get; set; }

        [ForeignKey("Book")]
        public int? BookId { get; set; }
        public virtual Book Book { get; set; }

        public virtual ICollection<BookCopyInDeal> BookCopyInDeals { get; set; }

        public BookCopy()
        {
            BookCopyInDeals = new List<BookCopyInDeal>();
        }
    }
}
