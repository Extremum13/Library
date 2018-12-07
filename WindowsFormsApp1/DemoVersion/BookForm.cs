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

namespace Library.DemoVersion
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();

            AuthorRepository authorRepository = new AuthorRepository();
            var authors = authorRepository.Get().Select(c => new { c.Name, c.Surname });
            List<string> list = new List<string>();
            foreach(var o in authors)
            {
                list.Add(o.Name + " " + o.Surname);
            }
            listBoxAuthors.DataSource = list;
        }

        private void listBoxAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
