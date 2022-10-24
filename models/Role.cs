
namespace EntityFramework2.models
{
    [Table("Roles")]
    public class Role
    {
        [Key]
        public int RoleID { get; set; }

        [Required]
        [Column("Name")]
        public string Nev { get; set; }

        public string? Description { get; set; }
    }
}
