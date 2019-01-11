using Library.Entities;
using Library.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.AlphaVersion
{
    public partial class BootPageForm : Form
    {
        public int _librarianId;
        ModelContext _db;
        bool? freeFilter;
        int fromYearFilter;
        int toYearFilter;
        List<int> checkedAuthorsIdFilter;

        public BootPageForm()
        {
            _db = new ModelContext();

            /*if (_db.Librarians.Count() == 0)
            {
                _db.Librarians.Add(new Librarian
                {
                    Id = 1,
                    Name = "Eldar",
                    Surname = "Mamishev",
                });
            }*/            

            if (ConfirmLibrarian() == false)
            {
                Close();
                return;
            }

            _db = new ModelContext();
            InitializeComponent();
            Initialize();
        }

        bool ConfirmLibrarian()
        {
            ConfirmForm conForm = new ConfirmForm();
            DialogResult conResult = conForm.ShowDialog(this);
            if (conResult == DialogResult.Cancel)
            {
                return false;
            }

            if (conForm.idTextBox.Text.ToUpper().Equals("ADMIN") && conForm.surnameTextBox.Text.ToUpper().Equals("PASSWORD"))
            {
                var adminForm = new AdminForm();
                DialogResult dialogResult = adminForm.ShowDialog(this);
                return true;
            }

            int id = int.Parse(conForm.idTextBox.Text);
            string surname = conForm.surnameTextBox.Text;
            LibrarianRepository librRep = new LibrarianRepository();
            var librarian = librRep.FindById(id);

            if (librarian == null || librarian.Surname.ToUpper() != surname.ToUpper())
            {
                return false;
            }

            _librarianId = id;

            return true;
        }

        void Initialize()
        {
            Size = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            freeFilter = null;
            checkedAuthorsIdFilter = new List<int>();
            
            mainDataGridView.Width = (int)(this.Width * 0.65);
            mainDataGridView.Height = (int)(this.Height * 0.85);
            SetDataGridView();

            filterFlowLayoutPanel.Width = (int)(this.Width * 0.15);
            filterFlowLayoutPanel.Height = mainDataGridView.Height;

            dataGridFlowLayoutPanel.Size = mainDataGridView.Size;
            dataGridFlowLayoutPanel.Location = new Point(filterFlowLayoutPanel.Location.X + filterFlowLayoutPanel.Width + 5, filterFlowLayoutPanel.Location.Y);
            
            buttonsFlowLayoutPanel.Location = new Point(dataGridFlowLayoutPanel.Width + 5 + dataGridFlowLayoutPanel.Location.X, dataGridFlowLayoutPanel.Location.Y);
            buttonsFlowLayoutPanel.Width = this.Width - buttonsFlowLayoutPanel.Location.X - 25;
            buttonsFlowLayoutPanel.Height = dataGridFlowLayoutPanel.Height;

            foreach (Control p in filterFlowLayoutPanel.Controls)
            {
                p.Width = filterFlowLayoutPanel.Width - 10;
                p.Padding = new Padding(0);

                foreach (Control b in p.Controls)
                {
                    b.Width = p.Width - 10;
                    p.Padding = new Padding(0);                    
                }
            }

            authorsCheckedListBox.Width = authorsGroupBox.Width - 10;

            foreach (GroupBox p in buttonsFlowLayoutPanel.Controls)
            {
                p.Width = buttonsFlowLayoutPanel.Width - 10;
                p.Height = buttonsFlowLayoutPanel.Height / 3 - 10;
                p.Padding = new Padding(0);

                int k = 15;

                foreach (Button b in p.Controls)
                {                    
                    b.Width = p.Width - 10;
                    b.Height = p.Height / p.Controls.Count - 20;                    
                    b.Margin = new Padding(0);
                    b.Location = new Point(5, k + 10);

                    k += b.Height + 10;
                }
            }

            TakeData();
        }

        public void SetDataGridView()
        {
            var bookRepository = new BookRepository();

            var books = bookRepository.Get().Select(b => new
            {
                b.Id,
                b.Name,
                Authors = SetAuthor(b.Id),
                b.Language,
                b.EditionYear.Year,
                CountOfCopies = b.BookCopies.Count,
                IsFree = b.BookCopies.Any(bc => (bc.BookCopyInDeals.Count.Equals(0) || bc.BookCopyInDeals.All(bcd => bcd.ActualDateOfReturning.HasValue))).ToString()
            }).ToList();

            mainDataGridView.DataSource = books;
        }

        public void TakeData()
        {
            var NSP = new List<string>();
            AuthorRepository authorRepository = new AuthorRepository();
            List<Author> authors = authorRepository.Get().ToList();

            foreach (var author in authors)
            {
                NSP.Add($"{author.Id} {author.Name} {author.Surname} {author.Patronymic}");
            }

            authorsCheckedListBox.DataSource = NSP;
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

        private void FilterDataGridView()
        {
            var bookRepository = new BookRepository();
            List<Book> books = bookRepository.GetFiltratedBooks(searchTextBox.Text, freeFilter, fromYearFilter, toYearFilter, checkedAuthorsIdFilter);

            if (books == null)
            {
                mainDataGridView.DataSource = "No readers found";
                return;
            }

            mainDataGridView.DataSource = books.OrderBy(b => b.Id).Select(b => new
            {
                b.Id,
                b.Name,
                Authors = SetAuthor(b.Id),
                b.Language,
                b.EditionYear.Year,
                CountOfCopies = b.BookCopies.Count,
                IsFree = b.BookCopies.Any(bc => (bc.BookCopyInDeals.Count.Equals(0) || bc.BookCopyInDeals.All(bcd => bcd.ActualDateOfReturning.HasValue))).ToString()
            }).ToList();
        }

        private void BootPageForm_Load(object sender, EventArgs e)
        {
            Location = new Point(-8, 0);
        }

        private void BootPageForm_DragEnter(object sender, DragEventArgs e)
        {
            Location = new Point(-8, 0);
        }

        public void addReaderButton_Click(object sender, EventArgs e)
        {
            AddReaderForm addReaderForm = new AddReaderForm();
            DialogResult dialogResult = addReaderForm.ShowDialog(this);

            if (dialogResult == DialogResult.Cancel)
                return;

            string name = addReaderForm.nameTextBox.Text;
            string surname = addReaderForm.surnameTextBox.Text;
            string patronymic = addReaderForm.patronymicTextBox.Text;
            DateTime DoB = addReaderForm.dateTimePicker.Value;
            string email = addReaderForm.emailTextBox.Text;
            string telNumber = addReaderForm.telNumberTextBox.Text;

            Reader reader = new Reader
            {
                Name = name,
                Surname = surname,
                Patronymic = patronymic,
                DateOfBirth = DoB,
                Email = email,
                TelephoneNumber = telNumber
            };

            ReaderRepository readerRepository = new ReaderRepository();
            readerRepository.Create(reader);

            _db.SaveChanges();
        }

        private void changeReaderButton_Click(object sender, EventArgs e)
        {
            ChangeReaderForm changeReaderForm = new ChangeReaderForm();
           
            changeReaderForm.ShowDialog();
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            var addBookForm = new AddBookForm();
            DialogResult dialogResult = addBookForm.ShowDialog(this);

            if (dialogResult == DialogResult.Cancel)
                return;

            string name = addBookForm.nameTextBox.Text;
            string editor = addBookForm.editorTextBox.Text;
            string type = addBookForm.typeTextBox.Text;
            string genre = addBookForm.genreTextBox.Text;
            string language = addBookForm.languageTextBox.Text;
            var editionYear = new DateTime((int)addBookForm.editionNumericUpDown.Value, 1, 1);

            BookRepository bookRepository = new BookRepository();

            var book = new Book
            {
                Name = name,
                EditorsName = editor,
                EditionYear = editionYear,
                Type = type,
                Genre = genre,
                Language = language
            };

            bookRepository.Create(book);
            
            int id = 0;
            var bookAuthorRepository = new BookAuthorRepository();
            BookAuthor bookAuthor;


            foreach (object ch in addBookForm.authorsCheckedListBox.CheckedItems)
            {
                id = int.Parse(ch.ToString().Split(' ')[0]);

                bookAuthor = new BookAuthor
                {
                    BookId = book.Id,
                    AuthorId = id
                };

                bookAuthorRepository.Create(bookAuthor);
            }

            int booksCount = (int)addBookForm.countNumericUpDown.Value;
            var bookCopyRepository = new BookCopyRepository();
            BookCopy bookCopy;

            for (int i = 0; i < booksCount; i++)
            {
                bookCopy = new BookCopy
                {
                    BookId = book.Id,
                    CopyNumber = i + 1
                };

                bookCopyRepository.Create(bookCopy);
            }

            SetDataGridView();
            _db.SaveChanges();
        }

        private void addDealButton_Click(object sender, EventArgs e)
        {
            var addDealForm = new AddDealForm();
            DialogResult dialogResult = addDealForm.ShowDialog(this);

            if (dialogResult == DialogResult.Cancel)
                return;

            int readerId = addDealForm.SelectedReader.Id;            

            var dealRepository = new DealRepository();

            var bookCopyInDealRepository = new BookCopyInDealRepository();
            BookCopyInDeal bookCopyInDeal;
            var bookCopyRepository = new BookCopyRepository();

            Deal deal = new Deal
            {
                LibrarianId = _librarianId,
                ReaderId = readerId,
                Date = DateTime.UtcNow                
            };

            dealRepository.Create(deal);
            var p = addDealForm.booksDataGridView.SelectedRows;

            for (int i = 0; i < p.Count; i++)
            {
                bookCopyInDeal = new BookCopyInDeal
                {
                    DealId = deal.Id,
                    BookCopyId = bookCopyRepository.GetAvailableBookCopiesByBookId((int)p[i].Cells[0].Value)[0].Id,
                    RequiredDateOfReturning = DateTime.UtcNow.AddDays((int)addDealForm.daysNumericUpDown.Value)
                };
                bookCopyInDealRepository.Create(bookCopyInDeal);
            }

        }

        private void returnBookButton_Click(object sender, EventArgs e)
        {
            var returnBookForm = new ReturnBookForm();
            DialogResult dialogResult = returnBookForm.ShowDialog(this);

            if (dialogResult == DialogResult.Cancel)
                return;

            int readerId = returnBookForm.SelectedReader.Id;

            var bookCopyInDealRepository = new BookCopyInDealRepository();
            BookCopyInDeal bookCopyInDeal;
            var p = returnBookForm.booksDataGridView.SelectedRows;

            for (int i = 0; i < p.Count; i++)
            {
                bookCopyInDeal = bookCopyInDealRepository.FindById((int)p[i].Cells[0].Value);
                bookCopyInDeal.ActualDateOfReturning = DateTime.UtcNow;
                bookCopyInDealRepository.Update(bookCopyInDeal);
            }

            SetDataGridView();
            _db.SaveChanges();
        }
        
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            
            TextBox thisTextBox = sender as TextBox;

            FilterDataGridView();
        }

        private void fromNumericUpDown_Leave(object sender, EventArgs e)
        {
            if (fromNumericUpDown.Value.Equals(null))
            {
                fromNumericUpDown.Value = fromNumericUpDown.Minimum;
            }

            if (fromNumericUpDown.Value > toNumericUpDown.Value)
            {
                fromNumericUpDown.Value = toNumericUpDown.Value;
            }
        }

        private void toNumericUpDown_Leave(object sender, EventArgs e)
        {
            if (toNumericUpDown.Value.Equals(null))
            {
                toNumericUpDown.Value = toNumericUpDown.Maximum;
            }

            if (toNumericUpDown.Value < fromNumericUpDown.Value)
            {
                toNumericUpDown.Value = fromNumericUpDown.Value;
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            if (yesRadioButton.Checked)
                freeFilter = true;
            else if (noRadioButton.Checked)
                freeFilter = false;
            else
                freeFilter = null;

            fromYearFilter = (int)fromNumericUpDown.Value;
            toYearFilter = (int)toNumericUpDown.Value;

            checkedAuthorsIdFilter = new List<int>();

            foreach (object a in authorsCheckedListBox.CheckedItems)
            {
                checkedAuthorsIdFilter.Add(int.Parse(a.ToString().Split(' ')[0]));
            }

            FilterDataGridView();
        }
    }
}
