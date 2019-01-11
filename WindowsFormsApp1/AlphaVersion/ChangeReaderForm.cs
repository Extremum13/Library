using Library.Entities;
using Library.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.AlphaVersion
{
    public partial class ChangeReaderForm : Form
    {
        ModelContext _db = new ModelContext();
        public ChangeReaderForm()
        {
            InitializeComponent();
            SetDataGridView();
        }
                
        public void SetDataGridView()
        {
            var readerRepository = new ReaderRepository();
            var readers = from reader in readerRepository.Get()
                          select new 
                          {
                              Id = reader.Id,
                              Name = reader.Name,
                              Surname = reader.Surname,
                              Patronymic = reader.Patronymic,
                              DateOfBirth = reader.DateOfBirth,
                              TelephoneNumber = reader.TelephoneNumber,
                              Email = reader.Email
                          };

            this.dataGridView1.DataSource = readers.ToList();
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
            SetDataGridView();
        }

        public void changeButton_Click(object sender, EventArgs e)
        {
            if (!(dataGridView1.SelectedRows.Count > 0))
                return;
            AddReaderForm addReaderForm = new AddReaderForm();
            ReaderRepository readerRepository = new ReaderRepository();

            int index = dataGridView1.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
            if (converted == false)
                return;

            Reader reader = readerRepository.FindById(id);

            addReaderForm.nameTextBox.Text = reader.Name;
            addReaderForm.surnameTextBox.Text = reader.Surname;
            addReaderForm.patronymicTextBox.Text = reader.Patronymic;
            addReaderForm.dateTimePicker.Value = reader.DateOfBirth;
            addReaderForm.emailTextBox.Text = reader.Email;
            addReaderForm.telNumberTextBox.Text = reader.TelephoneNumber;

            DialogResult dialogResult = addReaderForm.ShowDialog(this);

            if (dialogResult == DialogResult.Cancel)
                return;

            string name = addReaderForm.nameTextBox.Text;
            string surname = addReaderForm.surnameTextBox.Text;
            string patronymic = addReaderForm.patronymicTextBox.Text;
            DateTime DoB = addReaderForm.dateTimePicker.Value;
            string email = addReaderForm.emailTextBox.Text;
            string telNumber = addReaderForm.telNumberTextBox.Text;


            reader.Name = name;
            reader.Surname = surname;
            reader.Patronymic = patronymic;
            reader.DateOfBirth = DoB;
            reader.Email = email;
            reader.TelephoneNumber = telNumber;          

            
            readerRepository.Update(reader);

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

                var readerRepository = new ReaderRepository();
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

                readerRepository.Remove(id);
                _db.SaveChanges();
                SetDataGridView();

                MessageBox.Show("Объект удален");
            }
        }

        private void dateSortLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReaderRepository readerRepository = new ReaderRepository();
            LinkLabel thisLinkLabel = (sender as LinkLabel);
            

            var readers = readerRepository.Get().Select(r => new {
                r.Id,
                r.Name,
                r.Surname,
                r.Patronymic,
                r.DateOfBirth,
                r.TelephoneNumber,
                r.Email
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
            ReaderRepository readerRepository = new ReaderRepository();
            LinkLabel thisLinkLabel = (sender as LinkLabel);

            var readers = readerRepository.Get().Select(r => new {
                r.Id,
                r.Name,
                r.Surname,
                r.Patronymic,
                r.DateOfBirth,
                r.TelephoneNumber,
                r.Email
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
            ReaderRepository readerRepository = new ReaderRepository();
            LinkLabel thisLinkLabel = (sender as LinkLabel);

            var readers = readerRepository.Get().Select(r => new {
                r.Id,
                r.Name,
                r.Surname,
                r.Patronymic,
                r.DateOfBirth,
                r.TelephoneNumber,
                r.Email
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
            ReaderRepository readerRepository = new ReaderRepository();
            LinkLabel thisLinkLabel = (sender as LinkLabel);

            var readers = readerRepository.Get().Select(r => new {
                r.Id,
                r.Name,
                r.Surname,
                r.Patronymic,
                r.DateOfBirth,
                r.TelephoneNumber,
                r.Email
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
            ReaderRepository readerRepository = new ReaderRepository();
            LinkLabel thisLinkLabel = (sender as LinkLabel);

            var readers = readerRepository.Get().Select(r => new {
                r.Id,
                r.Name,
                r.Surname,
                r.Patronymic,
                r.DateOfBirth,
                r.TelephoneNumber,
                r.Email
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
            var readerRepository = new ReaderRepository();

            if (string.IsNullOrEmpty(idNumericUpDown.Value.ToString()))
            {
                SetDataGridView();
                return;
            }

            List<Reader> readers = new List<Reader>();
            Reader reader = readerRepository.FindById((int)idNumericUpDown.Value);
            readers.Add(reader);
            if (reader == null)
            {
                dataGridView1.DataSource = "No readers found";
                return;
            }

            dataGridView1.DataSource = readers;
        }

        private void findBySurnameButton_Click(object sender, EventArgs e)
        {
            var readerRepository = new ReaderRepository();

            if (string.IsNullOrEmpty(surnameTextBox.Text))
            {
                SetDataGridView();
                return;
            }
            List<Reader> readers = readerRepository.FindBySurname(surnameTextBox.Text);

            if (readers == null)
            {
                dataGridView1.DataSource = "No readers found";
                return;
            }

            dataGridView1.DataSource = readers.OrderBy(b => b.Id)
                .Select(b => new
                {
                    b.Id,
                    b.Name,
                    b.Surname,
                    b.Patronymic,
                    b.DateOfBirth,
                    b.TelephoneNumber,
                    b.Email
                }).ToList(); ;
        }

    }
}
