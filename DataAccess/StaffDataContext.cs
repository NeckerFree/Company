using Microsoft.EntityFrameworkCore;

namespace Company.DataAccess
{
    public class StaffDataContext : DbContext
    {
        public DbSet<Departments>? Departments { get; set; }
        public DbSet<Employees>? Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"DataSource=C:\Temp\StaffDb.db");
        }
    }

    public class Employees
    {
        public int Id { get; set; }

       //public int DepartmentId { get; set; }
       public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public int Age { get; set; }
    }

    public class Departments
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public bool Active { get; set; }

        List<Employees>? Employees { get; set;}

    }
}
