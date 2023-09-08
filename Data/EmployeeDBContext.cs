using IEnumerableandIqueryable.Model;
using Microsoft.EntityFrameworkCore;

namespace IEnumerableandIqueryable.Data
{
    public class EmployeeDBContext:DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options):base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
