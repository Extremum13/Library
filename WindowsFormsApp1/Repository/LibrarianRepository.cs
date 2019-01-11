using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    class LibrarianRepository : GenericRepository<Librarian>
    {
        public LibrarianRepository() : base()
        {

        }

        public List<Librarian> FindBySurname(string surname)
        {
            List<Librarian> librarians = _db.Librarians.Where(r => r.Surname.ToUpper().Contains(surname.ToUpper())).ToList();
            return librarians;
        }
    }
}