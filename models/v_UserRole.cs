using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework2.models
{
    [Table("v_UserRoles")]
    public class v_UserRole
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public DateTime SzuletesiDatum { get; set; }
        [Column("Hány napos")]
        public int HanyNapos { get; set; }
    }
}
