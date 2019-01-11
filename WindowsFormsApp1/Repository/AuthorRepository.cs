using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public class AuthorRepository : GenericRepository<Author>
    {
        public AuthorRepository() : base()
        {
            
        }

        public List<Author> GetAuthorsByBookId(int bookId)
        {
            List<Author> authors = _db.Authors.Where(a => a.AuthorsOfABook.Any(ab => ab.BookId.Equals(bookId))).ToList();
            return authors;
        }

        public string GetAuthorsToStringByBookId(int bookId)
        {
            List<Author> authorsList = _db.Authors.Where(a => a.AuthorsOfABook.Any(ab => ab.BookId.Equals(bookId))).ToList();
            string authorsStr = "";
            for (int i = 0; i < authorsList.Count; i++)
            {
                authorsStr += authorsList[i].ToString();
                if (authorsList.Count - i < 1)
                {
                    authorsStr += ", ";
                }
            }
            return authorsStr;
        }
    }
}
