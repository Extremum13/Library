using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    public class BookCopyInDeal: BaseEntity
    {
        public DateTime RequiredDateOfReturning { get; set; }
        public DateTime? ActualDateOfReturning { get; set; }

        [ForeignKey("BookCopy")]
        public int? BookCopyId { get; set; }
        public virtual BookCopy BookCopy { get; set; }

        [ForeignKey("Deal")]
        public int? DealId { get; set; }
        public virtual Deal Deal { get; set; }
    }
}
