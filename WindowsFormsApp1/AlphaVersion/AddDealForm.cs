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
    public partial class AddDealForm : Form
    {
        public Reader SelectedReader;

        public AddDealForm()
        {
            InitializeComponent();
            
            SetDataGridView();

            OKButton.Enabled = false;


        }

        private void SetDataGridView()
        {
            var bookRepository = new BookRepository();

            booksDataGridView.DataSource = bookRepository.GetAvailableBooks()
                .OrderBy(b => b.Id)
                .Select(b => new
                {
                    b.Id,
                    b.Name,
                    Authors = SetAuthor(b.Id),
                    b.EditionYear,
                    b.Genre,
                    b.Type,
                    b.Language
                }).ToList();
        }

        private string SetAuthor(int bookId)
        {
            string author = "";

            AuthorRepository authorRepository = new AuthorRepository();
            List<Author> authors = authorRepository.GetAuthorsByBookId(bookId);

            for(int i = 0; i < authors.Count; ++i)
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
           
            try
            {
                SelectedReader = findReaderForm.SelectedReader;
                chooseReaderButton.Text = $"{SelectedReader.Surname} {SelectedReader.Name};";
                chooseReaderButton.BackColor = Color.White;
                OKButton.Enabled = true;
            }
            catch (Exception)
            {
                
            }
        }
    }
}
