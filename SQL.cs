using EntityFramework2.models;

namespace EntityFramework2
{
    public class SQL : DbContext
    {
        public SQL() : base(new DbContextOptionsBuilder
            ().UseSqlServer(Program.CONNECTION_STRING).Options) 
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRoles>().HasKey("UserID", "RoleID"); // has(primary keys)
            modelBuilder.Entity<v_UserRole>().HasNoKey();
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<v_UserRole> v_UserRoles { get; set; }
    }
}
