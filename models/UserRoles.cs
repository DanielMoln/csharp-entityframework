using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework2.models
{
    [Table("UserRoles")]
    public class UserRoles
    {
        [Required]
        public string UserID { get; set; }

        [Required]
        public int RoleID { get; set; }
    }
}
