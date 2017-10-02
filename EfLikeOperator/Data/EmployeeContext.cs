using Microsoft.EntityFrameworkCore;

namespace EfLikeOperator.Data
{
    public class EmployeeContext : DbContext
    {
        
        public EmployeeContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
