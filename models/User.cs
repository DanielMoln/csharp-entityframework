using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework2.models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Required]
        public string UserID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public string? Address { get; set; }

        [NotMapped]
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{UserID} {Name} {BirthDate} {Address}";
        }
    }
}
