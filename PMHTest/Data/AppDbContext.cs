using Microsoft.EntityFrameworkCore;
using PMHTest.Models;

namespace TestPMH.Data
{
    public class AppDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;  
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = _configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseNpgsql(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, DepartmentName = "IT" },
                new Department { Id = 2, DepartmentName = "HR" },
                new Department { Id = 3, DepartmentName = "Marketing" }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, DepartmentId = 1, Name = "Nikita Prokhorenko", PhoneNumber = "+79111234567", PhotoPath = "/img/fcbfcf72-3d1d-4716-a883-c28340ced39c.jpg" },
                new Employee { Id = 2, DepartmentId = 1, Name = "Andrey Andreevich", PhoneNumber = "89211234567"},
                new Employee { Id = 3, DepartmentId = 2, Name = "Maria Osipova", PhoneNumber = "89115634569"}
            );
        }

    }
}