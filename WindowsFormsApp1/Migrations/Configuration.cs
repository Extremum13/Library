namespace Library.Migrations
{
    using Library.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Library.Entities.ModelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ModelContext context)
        {
            Reader reader = new Reader
            {
                Name = "Elmir",
                Surname = "Mamishev",
                Patronymic = "Isa ogly",
                DateOfBirth = new DateTime(2006, 08, 31),
                Email = "elmir@mamishev.ua",
                TelephoneNumber = "+380661234567"
            };

            Librarian librarian = new Librarian
            {
                Name = "Rauf",
                Surname = "Mamishev",
                Patronymic = "Isa ogly",
                DateOfBirth = new DateTime(1997, 01, 05),
                TelephoneNumber = "+380661234567"
            };

            Author author = new Author
            {
                DateOfBirth = new DateTime(2000, 04, 13),
                Name = "Eldar",
                Patronymic = "Isa ogly",
                Surname = "Mamishev"
            };

            Book book = new Book
            {
                Name = "My autobiography",
                EditorsName = "Mamishev Publishers",
                EditionYear = DateTime.UtcNow,
                Type = "Fiction",
                Genre = "Autobiography",
                Language = "Ukrainian"
            };

            BookAuthor bookAuthor = new BookAuthor
            {
                Author = author,
                Book = book,
                Role = "Main author"
            };

            BookCopy bookCopy = new BookCopy
            {
                Book = book,
                CopyNumber = 1
            };

            Deal deal = new Deal
            {
                Librarian = librarian,
                Reader = reader,
                Date = DateTime.UtcNow
            };

            BookCopyInDeal bookCopyInDeal = new BookCopyInDeal
            {
                BookCopy = bookCopy,
                Deal = deal,
                RequiredDateOfReturning = DateTime.UtcNow.AddMonths(1),
                ActualDateOfReturning = null
            };


            context.Authors.Add(author);
            context.BookAuthors.Add(bookAuthor);
            context.BookCopies.Add(bookCopy);
            context.BookCopyInDeals.Add(bookCopyInDeal);
            context.Books.Add(book);
            context.Deals.Add(deal);
            context.Librarians.Add(librarian);
            context.Readers.Add(reader);

            context.SaveChanges();
        }
    }
}
