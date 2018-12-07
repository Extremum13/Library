using System;
using System.Collections.Generic;

namespace Library.Entities
{
    public class Author: BaseEntity
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<BookAuthor> AuthorsOfABook { get; set; }

        public Author()
        {
            AuthorsOfABook = new List<BookAuthor>();
        }
    }
}
