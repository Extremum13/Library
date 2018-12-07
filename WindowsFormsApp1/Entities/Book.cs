using System;
using System.Collections.Generic;

namespace Library.Entities
{
    public class Book: BaseEntity
    {
        public string Name { get; set; }
        public string EditorsName { get; set; }
        public DateTime EditionYear { get; set; }
        public string Type { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }

        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
        public virtual ICollection<BookCopy> BookCopies { get; set; }

        public Book()
        {
            BookAuthors = new List<BookAuthor>();
            BookCopies = new List<BookCopy>();
        }
    }
}
