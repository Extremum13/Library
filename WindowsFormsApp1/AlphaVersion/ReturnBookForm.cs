using Library.Entities;
using Library.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.AlphaVersion
{
    public partial class ReturnBookForm : Form
    {
        public Reader SelectedReader;

        public ReturnBookForm()
        {
            InitializeComponent();
        }

        private void SetDataGridView(int readerId)
        {
            var bookCopyInDealRepository = new BookCopyInDealRepository();

            booksDataGridView.DataSource = bookCopyInDealRepository.GetReadingBookCopiesByReaderId(readerId)
                .OrderBy(bcd => bcd.Id)
                .Select(bcd => new
                {
                    bcd.Id,
                    bcd.BookCopyId,
                    bcd.BookCopy.BookId,
                    bcd.BookCopy.Book.Name,
                    Authors = SetAuthor(bcd.BookCopy.Book.Id),
                    bcd.DealId,
                    ReaderId = bcd.Deal.ReaderId,
                    ReaderName = $"{bcd.Deal.Reader.Name} {bcd.Deal.Reader.Surname}",
                    bcd.RequiredDateOfReturning
                }).ToList();
        }

        private string SetAuthor(int bookId)
        {
            string author = "";

            AuthorRepository authorRepository = new AuthorRepository();
            List<Author> authors = authorRepository.GetAuthorsByBookId(bookId);

            for (int i = 0; i < authors.Count; ++i)
            {
                author += $"{authors[i].Surname} {authors[i].Name}";
                if (authors.Count - i != 1)
                    author += ", ";
            }

            return author;
        }

        private void chooseReaderButton_Click(object sender, EventArgs e)
        {
            var findReaderForm = new FindReaderForm();
            DialogResult dialogResult = findReaderForm.ShowDialog(this);
            findReaderForm.Location = this.Location;

            if (dialogResult.Equals(DialogResult.Cancel))
                return;

            SelectedReader = findReaderForm.SelectedReader;
            chooseReaderButton.Text = $"{SelectedReader.Surname} {SelectedReader.Name};";
            chooseReaderButton.BackColor = Color.White;

            SetDataGridView(SelectedReader.Id);
            OKButton.Enabled = true;
        }
    }
}
