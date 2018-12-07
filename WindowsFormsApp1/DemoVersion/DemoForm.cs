using Library.DemoVersion;
using Library.Entities;
using Library.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    public partial class DemoForm : Form
    {
        Button button = new Button();

        public DemoForm()
        {
            InitializeComponent();



            using (ModelContext db = new ModelContext())
            {
                var books = from book in db.Books
                            join bookCopy in db.BookCopies on book.Id equals bookCopy.BookId
                            join bookCopyInDeal in db.BookCopyInDeals on bookCopy.Id equals bookCopyInDeal.BookCopyId
                            join deal in db.Deals on bookCopyInDeal.DealId equals deal.Id
                            join reader in db.Readers on deal.ReaderId equals reader.Id
                            where !bookCopyInDeal.ActualDateOfReturning.HasValue
                            select new
                            {
                                Name = reader.Name,
                                SurName = reader.Surname,
                                BookName = book.Name
                            };
                dataGridView1.DataSource = books.ToList();

            }
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookRepository bookRepository;
            bookRepository = new BookRepository();
            List<Book> books = bookRepository.Get();
            dataGridView1.DataSource = books;
        }

        private void copiesOfBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookCopyRepository bookCopyRepository;
            bookCopyRepository = new BookCopyRepository();
            List<BookCopy> bookCopies = bookCopyRepository.Get();
            dataGridView1.DataSource = bookCopies;
        }

        private void readerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReaderRepository readerRepository;
            readerRepository = new ReaderRepository();
            List<Reader> readers = readerRepository.Get();
            dataGridView1.DataSource = readers;
        }

        private void copiesOfABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                var books = from book in db.Books
                            join bookCopy in db.BookCopies on book.Id equals bookCopy.BookId
                            join bookCopyInDeal in db.BookCopyInDeals on bookCopy.Id equals bookCopyInDeal.BookCopyId
                            join deal in db.Deals on bookCopyInDeal.DealId equals deal.Id
                            join reader in db.Readers on deal.ReaderId equals reader.Id
                            where !bookCopyInDeal.ActualDateOfReturning.HasValue
                            select new
                            {
                                Name = reader.Name,
                                SurName = reader.Surname,
                                BookName = book.Name
                            };
                dataGridView1.DataSource = books.ToList();
            }
        }

        private void booksReadByReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                var books = from book in db.Books
                            join bookCopy in db.BookCopies on book.Id equals bookCopy.BookId
                            join bookCopyInDeal in db.BookCopyInDeals on bookCopy.Id equals bookCopyInDeal.BookCopyId
                            join deal in db.Deals on bookCopyInDeal.DealId equals deal.Id
                            join reader in db.Readers on deal.ReaderId equals reader.Id
                            where bookCopyInDeal.ActualDateOfReturning.HasValue
                            select new
                            {
                                Name = reader.Name,
                                SurName = reader.Surname,
                                BookName = book.Name
                            };
                dataGridView1.DataSource = books.ToList();
            }
        }

        private void copiesOfABookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                var books = from book in db.Books
                            join bookCopy in db.BookCopies on book.Id equals bookCopy.BookId
                            join bookAuthor in db.BookAuthors on book.Id equals bookAuthor.BookId
                            join author in db.Authors on bookAuthor.AuthorId equals author.Id
                            select new
                            {
                                BookName = book.Name,
                                AuthorName = author.Name,
                                CopiesCount = book.BookCopies.Count
                            };
                dataGridView1.DataSource = books.ToList();
            }
        }

        private void availableCopiesOfABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                var books = from book in db.Books
                            join bookCopy in db.BookCopies on book.Id equals bookCopy.BookId
                            join bookAuthor in db.BookAuthors on book.Id equals bookAuthor.BookId
                            join author in db.Authors on bookAuthor.AuthorId equals author.Id
                            join bookCopyInDeal in db.BookCopyInDeals on bookCopy.Id equals bookCopyInDeal.BookCopyId
                            where !bookCopyInDeal.ActualDateOfReturning.HasValue
                            select new
                            {
                                BookName = book.Name,
                                AuthorName = author.Name,
                                CopyNumber = bookCopy.CopyNumber,
                                CopyId = bookCopy.Id
                            };
                dataGridView1.DataSource = books.ToList();
            }
        }

        private void BookAdd_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            DialogResult dialogResult = bookForm.ShowDialog(this);

            if (dialogResult == DialogResult.Cancel)
                return;

            Book book = new Book();
            book.Name = bookForm.nameTextBox.Text;

        }
        
        private void BookChange_Click(object sender, EventArgs e)
        {

        }

        private void BookDelete_Click(object sender, EventArgs e)
        {

        }

        private void BookCopyAdd_Click(object sender, EventArgs e)
        {

        }

        private void BookCopyChange_Click(object sender, EventArgs e)
        {

        }

        private void BookCopyDelete_Click(object sender, EventArgs e)
        {

        }

        private void ReaderAdd_Click(object sender, EventArgs e)
        {

        }

        private void ReaderChange_Click(object sender, EventArgs e)
        {

        }

        private void ReaderDelete_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookAdd_Click(sender, e);
        }
    }
}
