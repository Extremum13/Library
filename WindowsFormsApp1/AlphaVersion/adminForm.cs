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
    public partial class AdminForm : Form
    {
        ModelContext _db = new ModelContext();

        public AdminForm()
        {
            InitializeComponent();
            SetDataGridView();
        }

        public void SetDataGridView()
        {
            var librarianRepository = new LibrarianRepository();
            var readers = from reader in librarianRepository.Get()
                          select new
                          {
                              reader.Id,
                              reader.Name,
                              reader.Surname,
                              reader.Patronymic,
                              reader.DateOfBirth,
                              reader.TelephoneNumber
                          };

            this.dataGridView1.DataSource = readers.ToList();
        }

        public void addButton_Click(object sender, EventArgs e)
        {
            var addReaderForm = new AddLibrarianForm();
            DialogResult dialogResult = addReaderForm.ShowDialog(this);

            if (dialogResult == DialogResult.Cancel)
                return;

            string name = addReaderForm.nameTextBox.Text;
            string surname = addReaderForm.surnameTextBox.Text;
            string patronymic = addReaderForm.patronymicTextBox.Text;
            DateTime DoB = addReaderForm.dateTimePicker.Value;
            string telNumber = addReaderForm.telNumberTextBox.Text;

            var reader = new Librarian
            {
                Name = name,
                Surname = surname,
                Patronymic = patronymic,
                DateOfBirth = DoB,
                TelephoneNumber = telNumber
            };

            var readerRepository = new LibrarianRepository();
            readerRepository.Create(reader);

            _db.SaveChanges();
            SetDataGridView();
        }

        public void changeButton_Click(object sender, EventArgs e)
        {
            if (!(dataGridView1.SelectedRows.Count > 0))
                return;
            var addLibrarianForm = new AddLibrarianForm();
            var librarianRepository = new LibrarianRepository();

            int index = dataGridView1.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
            if (converted == false)
                return;

            Librarian librarian = librarianRepository.FindById(id);

            addLibrarianForm.nameTextBox.Text = librarian.Name;
            addLibrarianForm.surnameTextBox.Text = librarian.Surname;
            addLibrarianForm.patronymicTextBox.Text = librarian.Patronymic;
            addLibrarianForm.dateTimePicker.Value = librarian.DateOfBirth;
            addLibrarianForm.telNumberTextBox.Text = librarian.TelephoneNumber;

            DialogResult dialogResult = addLibrarianForm.ShowDialog(this);

            if (dialogResult == DialogResult.Cancel)
                return;

            string name = addLibrarianForm.nameTextBox.Text;
            string surname = addLibrarianForm.surnameTextBox.Text;
            string patronymic = addLibrarianForm.patronymicTextBox.Text;
            DateTime DoB = addLibrarianForm.dateTimePicker.Value;
            string telNumber = addLibrarianForm.telNumberTextBox.Text;


            librarian.Name = name;
            librarian.Surname = surname;
            librarian.Patronymic = patronymic;
            librarian.DateOfBirth = DoB;
            librarian.TelephoneNumber = telNumber;


            librarianRepository.Update(librarian);

            _db.SaveChanges();
            SetDataGridView();
        }

        public void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                var librarianRepository = new LibrarianRepository();
                var dealRepository = new DealRepository();
                var bookCopyInDealRepository = new BookCopyInDealRepository();

                List<Deal> deals = dealRepository.GetDealsByReaderId(id);
                List<BookCopyInDeal> bookCopyInDeals = bookCopyInDealRepository.GetBookCopiesInDealByReaderId(id);

                for (int i = 0; i < bookCopyInDeals.Count; i++)
                {
                    bookCopyInDealRepository.Remove(bookCopyInDeals[i].Id);
                }

                for (int i = 0; i < deals.Count; i++)
                {
                    dealRepository.Remove(deals[i].Id);
                }

                librarianRepository.Remove(id);
                _db.SaveChanges();
                SetDataGridView();

                MessageBox.Show("Объект удален");
            }
        }

        private void dateSortLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var librarianRepository = new LibrarianRepository();
            LinkLabel thisLinkLabel = (sender as LinkLabel);


            var readers = librarianRepository.Get().Select(r => new {
                r.Id,
                r.Name,
                r.Surname,
                r.Patronymic,
                r.DateOfBirth,
                r.TelephoneNumber
            });
            if ((sender as LinkLabel).Text.Contains("˄"))
            {
                dataGridView1.DataSource = readers.OrderBy(r => r.DateOfBirth).ToList();
                thisLinkLabel.Text = thisLinkLabel.Text.Split('˄')[0] + "˅";
            }
            else
            {
                dataGridView1.DataSource = readers.OrderByDescending(r => r.DateOfBirth).ToList();
                thisLinkLabel.Text = thisLinkLabel.Text.Split('˅')[0] + "˄";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var librarianRepository = new LibrarianRepository();
            LinkLabel thisLinkLabel = (sender as LinkLabel);

            var readers = librarianRepository.Get().Select(r => new {
                r.Id,
                r.Name,
                r.Surname,
                r.Patronymic,
                r.DateOfBirth,
                r.TelephoneNumber
            });
            if (thisLinkLabel.Text.Contains("˄"))
            {
                dataGridView1.DataSource = readers.OrderBy(r => r.Id).ToList();
                thisLinkLabel.Text = thisLinkLabel.Text.Split('˄')[0] + "˅";
            }
            else
            {
                dataGridView1.DataSource = readers.OrderByDescending(r => r.Id).ToList();
                thisLinkLabel.Text = thisLinkLabel.Text.Split('˅')[0] + "˄";
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var librarianRepository = new LibrarianRepository();
            LinkLabel thisLinkLabel = (sender as LinkLabel);

            var readers = librarianRepository.Get().Select(r => new {
                r.Id,
                r.Name,
                r.Surname,
                r.Patronymic,
                r.DateOfBirth,
                r.TelephoneNumber
            });
            if (thisLinkLabel.Text.Contains("˄"))
            {
                dataGridView1.DataSource = readers.OrderBy(r => r.Name).ToList();
                thisLinkLabel.Text = thisLinkLabel.Text.Split('˄')[0] + "˅";
            }
            else
            {
                dataGridView1.DataSource = readers.OrderByDescending(r => r.Name).ToList();
                thisLinkLabel.Text = thisLinkLabel.Text.Split('˅')[0] + "˄";
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var librarianRepository = new LibrarianRepository();
            LinkLabel thisLinkLabel = (sender as LinkLabel);

            var readers = librarianRepository.Get().Select(r => new {
                r.Id,
                r.Name,
                r.Surname,
                r.Patronymic,
                r.DateOfBirth,
                r.TelephoneNumber
            });
            if (thisLinkLabel.Text.Contains("˄"))
            {
                dataGridView1.DataSource = readers.OrderBy(r => r.Surname).ToList();
                thisLinkLabel.Text = thisLinkLabel.Text.Split('˄')[0] + "˅";
            }
            else
            {
                dataGridView1.DataSource = readers.OrderByDescending(r => r.Surname).ToList();
                thisLinkLabel.Text = thisLinkLabel.Text.Split('˅')[0] + "˄";
            }
        }

        private void patronymicLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var librarianRepository = new LibrarianRepository();
            LinkLabel thisLinkLabel = (sender as LinkLabel);

            var readers = librarianRepository.Get().Select(r => new {
                r.Id,
                r.Name,
                r.Surname,
                r.Patronymic,
                r.DateOfBirth,
                r.TelephoneNumber
            });
            if (thisLinkLabel.Text.Contains("˄"))
            {
                dataGridView1.DataSource = readers.OrderBy(r => r.Patronymic).ToList();
                thisLinkLabel.Text = thisLinkLabel.Text.Split('˄')[0] + "˅";
            }
            else
            {
                dataGridView1.DataSource = readers.OrderByDescending(r => r.Patronymic).ToList();
                thisLinkLabel.Text = thisLinkLabel.Text.Split('˅')[0] + "˄";
            }
        }

        private void findByIdButton_Click(object sender, EventArgs e)
        {
            var librarianRepository = new LibrarianRepository();

            if (string.IsNullOrEmpty(idNumericUpDown.Value.ToString()))
            {
                SetDataGridView();
                return;
            }

            List<Librarian> librarians = new List<Librarian>();
            Librarian librarian = librarianRepository.FindById((int)idNumericUpDown.Value);
            librarians.Add(librarian);
            if (librarian == null)
            {
                dataGridView1.DataSource = "No readers found";
                return;
            }

            dataGridView1.DataSource = librarians.Select(r => new
            {
                r.Id,
                r.Name,
                r.Surname,
                r.Patronymic,
                r.DateOfBirth,
                r.TelephoneNumber
            }).ToList();
        }

        private void findBySurnameButton_Click(object sender, EventArgs e)
        {
            var librarianRepository = new LibrarianRepository();

            if (string.IsNullOrEmpty(surnameTextBox.Text))
            {
                SetDataGridView();
                return;
            }
            List<Librarian> librarians = librarianRepository.FindBySurname(surnameTextBox.Text);

            if (librarians == null)
            {
                dataGridView1.DataSource = "No readers found";
                return;
            }

            dataGridView1.DataSource = librarians.OrderBy(b => b.Id)
                .Select(b => new
                {
                    b.Id,
                    b.Name,
                    b.Surname,
                    b.Patronymic,
                    b.DateOfBirth,
                    b.TelephoneNumber
                }).ToList(); ;
        }

    }
}
