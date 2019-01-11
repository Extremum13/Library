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
    public partial class AddAuthorForm : Form
    {
        public AddAuthorForm()
        {
            InitializeComponent();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox thisTextBox = (sender as TextBox);
            if (Validation.Validation.NameEnteringValidation(thisTextBox.Text))
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
            if (Validation.Validation.NameValidation(thisTextBox.Text))
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
            if (!Validation.Validation.NameValidation(nameTextBox.Text))
            {
                nameTextBox.BackColor = Color.Red;
                (sender as Button).Enabled = false;
            }
            if (!Validation.Validation.NameValidation(surnameTextBox.Text))
            {
                surnameTextBox.BackColor = Color.Red;
                (sender as Button).Enabled = false;
            }
            if (!Validation.Validation.NameValidation(patronymicTextBox.Text))
            {
                patronymicTextBox.BackColor = Color.Red;
                (sender as Button).Enabled = false;
            }
        }

        private void OKButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (Validation.Validation.NameValidation(nameTextBox.Text)
                && Validation.Validation.NameValidation(surnameTextBox.Text)
                && Validation.Validation.NameValidation(patronymicTextBox.Text))
            {
                OKButton.Enabled = true;
            }
            else
            {
                OKButton.Enabled = false;
            }
        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox thisTextBox = (sender as TextBox);
            if (Validation.Validation.SurnameEnteringValidation(thisTextBox.Text))
            {
                thisTextBox.BackColor = Color.White;
            }
            else
            {
                thisTextBox.BackColor = Color.Red;
            }
        }

        private void surnameTextBox_Leave(object sender, EventArgs e)
        {
            TextBox thisTextBox = (sender as TextBox);
            if (Validation.Validation.SurnameValidation(thisTextBox.Text))
            {
                thisTextBox.BackColor = Color.White;
            }
            else
            {
                thisTextBox.BackColor = Color.Red;
            }
        }
    }
}
