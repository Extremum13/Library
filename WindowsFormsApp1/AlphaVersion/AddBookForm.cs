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
    public partial class AddBookForm : Form
    {
        ModelContext _db;

        public AddBookForm()
        {
            _db = new ModelContext();            

            InitializeComponent();
            authorsCheckedListBox.ScrollAlwaysVisible = true;
            takeData();
        }

        public void takeData()
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

        private void addAuthorLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddAuthorForm addAuthorForm = new AddAuthorForm();
            DialogResult dialogResult = addAuthorForm.ShowDialog(this);

            if (dialogResult == DialogResult.Cancel)
                return;

            string name = addAuthorForm.nameTextBox.Text;
            string surname = addAuthorForm.surnameTextBox.Text;
            string patronymic = addAuthorForm.patronymicTextBox.Text;
            DateTime DoB = addAuthorForm.dateTimePicker.Value;

            Author author = new Author
            {
                Name = name,
                Surname = surname,
                Patronymic = patronymic,
                DateOfBirth = DoB
            };

            AuthorRepository readerRepository = new AuthorRepository();
            readerRepository.Create(author);

            _db.SaveChanges();
            takeData();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox thisTextBox = (sender as TextBox);
            if (Validation.Validation.BookNameEnteringValidation(thisTextBox.Text))
            {
                thisTextBox.BackColor = Color.White;
            }
            else
            {
                thisTextBox.BackColor = Color.Red;
            }
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            TextBox thisTextBox = (sender as TextBox);
            if (Validation.Validation.BookNameValidation(thisTextBox.Text))
            {
                thisTextBox.BackColor = Color.White;
            }
            else
            {
                thisTextBox.BackColor = Color.Red;
            }
        }

        private void patronymicTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox thisTextBox = (sender as TextBox);
            if (Validation.Validation.PatronymicEnteringValidation(thisTextBox.Text))
            {
                thisTextBox.BackColor = Color.White;
            }
            else
            {
                thisTextBox.BackColor = Color.Red;
            }
        }

        private void patronymicTextBox_Leave(object sender, EventArgs e)
        {
            TextBox thisTextBox = (sender as TextBox);
            if (Validation.Validation.PatronymicValidation(thisTextBox.Text))
            {
                thisTextBox.BackColor = Color.White;
            }
            else
            {
                thisTextBox.BackColor = Color.Red;
            }
        }

        private void languageTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox thisTextBox = (sender as TextBox);
            if (Validation.Validation.LanguageEnteringValidation(thisTextBox.Text))
            {
                thisTextBox.BackColor = Color.White;
            }
            else
            {
                thisTextBox.BackColor = Color.Red;
            }
        }

        private void languageTextBox_Leave(object sender, EventArgs e)
        {
            TextBox thisTextBox = (sender as TextBox);
            if (Validation.Validation.LanguageValidation(thisTextBox.Text))
            {
                thisTextBox.BackColor = Color.White;
            }
            else
            {
                thisTextBox.BackColor = Color.Red;
            }
        }

        private void OKButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Validation.Validation.BookNameValidation(nameTextBox.Text))
            {
                nameTextBox.BackColor = Color.Red;
                (sender as Button).Enabled = false;
            }
            if (!Validation.Validation.PatronymicValidation(editorTextBox.Text))
            {
                editorTextBox.BackColor = Color.Red;
                (sender as Button).Enabled = false;
            }
            if (!Validation.Validation.PatronymicValidation(genreTextBox.Text))
            {
                genreTextBox.BackColor = Color.Red;
                (sender as Button).Enabled = false;
            }
            if (!Validation.Validation.PatronymicValidation(typeTextBox.Text))
            {
                typeTextBox.BackColor = Color.Red;
                (sender as Button).Enabled = false;
            }
            if (!Validation.Validation.LanguageValidation(languageTextBox.Text))
            {
                languageTextBox.BackColor = Color.Red;
                (sender as Button).Enabled = false;
            }
            if(authorsCheckedListBox.CheckedItems.Count == 0)
            {
                authorsCheckedListBox.BackColor = Color.OrangeRed;
                MessageBox.Show("Check author or add new one");
                (sender as Button).Enabled = false;
            }
        }

        private void OKButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (Validation.Validation.BookNameValidation(nameTextBox.Text)
                && Validation.Validation.PatronymicValidation(typeTextBox.Text)
                && Validation.Validation.PatronymicValidation(genreTextBox.Text)
                && Validation.Validation.PatronymicValidation(editorTextBox.Text)
                && Validation.Validation.LanguageValidation(languageTextBox.Text)
                && authorsCheckedListBox.CheckedItems.Count > 0)
            {
                OKButton.Enabled = true;
            }
            else
            {
                OKButton.Enabled = false;
            }
        }

        private void authorsCheckedListBox_Leave(object sender, EventArgs e)
        {
            if (authorsCheckedListBox.CheckedItems.Count == 0)
            {
                authorsCheckedListBox.BackColor = Color.OrangeRed;
            }
            else
            {
                authorsCheckedListBox.BackColor = Color.White;
            }
        }
    }
}
