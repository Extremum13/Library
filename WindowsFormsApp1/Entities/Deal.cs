using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    public class Deal: BaseEntity
    {
        public DateTime Date { get; set; }

        [ForeignKey("Reader")]
        public int? ReaderId { get; set; }
        public virtual Reader Reader { get; set; }

        [ForeignKey("Librarian")]
        public int? LibrarianId { get; set; }
        public virtual Librarian Librarian { get; set; }

        public virtual ICollection<BookCopyInDeal> BookCopyInDeals { get; set; }

        public Deal()
        {
            BookCopyInDeals = new List<BookCopyInDeal>();
        }
    
    }
}
