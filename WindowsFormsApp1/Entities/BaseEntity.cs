using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    public class BaseEntity
    {
        [Key]
        [Index(IsUnique = true)]
        public int Id { get; set; }
    }
}
