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
    public partial class FindReaderForm : Form
    {
        public Reader SelectedReader { get; private set; }
        public FindReaderForm()
        {
            InitializeComponent();
            SetDataGridView();

        }

        private void SetDataGridView()
        {
            var readerRepository = new ReaderRepository();
            readerDataGridView.DataSource = readerRepository.Get()
                .OrderBy(b => b.Id)
                .Select(b => new
                {
                    b.Id,
                    b.Name,
                    b.Surname,
                    b.Patronymic,
                    b.DateOfBirth,
                    b.TelephoneNumber,
                    b.Email
                }).ToList();
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
            Reader reader = readerRepository.FindById((int) idNumericUpDown.Value);
            readers.Add(reader);
            if (reader == null)
            {
                readerDataGridView.DataSource = "No readers found";
                return;
            }

            readerDataGridView.DataSource = readers;
        }

        private void findBySurnameButton_Click(object sender, EventArgs e)
        {
            var readerRepository = new ReaderRepository();
            TextBox thisTextBox = sender as TextBox;

            if (string.IsNullOrEmpty(thisTextBox.Text))
            {
                SetDataGridView();
                return;
            }
            List<Reader> readers = readerRepository.FindBySurname(thisTextBox.Text);

            if (readers == null)
            {
                readerDataGridView.DataSource = "No readers found";
                return;
            }

            readerDataGridView.DataSource = readers.OrderBy(b => b.Id)
                .Select(b => new
                {
                    b.Id,
                    b.Name,
                    b.Surname,
                    b.Patronymic,
                    b.TelephoneNumber,
                    b.Email
                }).ToList(); ;
        }

        private void readerDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var readerRepository = new ReaderRepository();
            SelectedReader = readerRepository.FindById((int)readerDataGridView.SelectedRows[0].Cells[0].Value);
            this.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            SetDataGridView();
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
                readerDataGridView.DataSource = readers.OrderBy(r => r.DateOfBirth).ToList();
                thisLinkLabel.Text = thisLinkLabel.Text.Split('˄')[0] + "˅";
            }
            else
            {
                readerDataGridView.DataSource = readers.OrderByDescending(r => r.DateOfBirth).ToList();
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
                readerDataGridView.DataSource = readers.OrderBy(r => r.Id).ToList();
                thisLinkLabel.Text = thisLinkLabel.Text.Split('˄')[0] + "˅";
            }
            else
            {
                readerDataGridView.DataSource = readers.OrderByDescending(r => r.Id).ToList();
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
                readerDataGridView.DataSource = readers.OrderBy(r => r.Name).ToList();
                thisLinkLabel.Text = thisLinkLabel.Text.Split('˄')[0] + "˅";
            }
            else
            {
                readerDataGridView.DataSource = readers.OrderByDescending(r => r.Name).ToList();
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
                readerDataGridView.DataSource = readers.OrderBy(r => r.Surname).ToList();
                thisLinkLabel.Text = thisLinkLabel.Text.Split('˄')[0] + "˅";
            }
            else
            {
                readerDataGridView.DataSource = readers.OrderByDescending(r => r.Surname).ToList();
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
                readerDataGridView.DataSource = readers.OrderBy(r => r.Patronymic).ToList();
                thisLinkLabel.Text = thisLinkLabel.Text.Split('˄')[0] + "˅";
            }
            else
            {
                readerDataGridView.DataSource = readers.OrderByDescending(r => r.Patronymic).ToList();
                thisLinkLabel.Text = thisLinkLabel.Text.Split('˅')[0] + "˄";
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(64, 64, 64);
        }
    }
}
