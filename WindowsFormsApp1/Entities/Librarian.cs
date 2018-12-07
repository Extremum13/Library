using System;
using System.Collections.Generic;

namespace Library.Entities
{
    public class Librarian: BaseEntity
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string TelephoneNumber { get; set; }

        public virtual ICollection<Deal> Deals { get; set; }

        public Librarian()
        {
            Deals = new List<Deal>();
        }
    }
}
