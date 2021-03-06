﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    public class BookAuthor: BaseEntity
    {
        public string Role { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}
